using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using SVLMS.Savings.Model;
using SVLMS.Loaning.Model;
using SVLMS.Savings.View;

namespace SVLMS.Savings.Controller
{
    class ControllerTimeDepositTransaction
    {
        ModelTimeDepositTransaction model;
        TransactionTimeDeposit view;

        public string accountNo { get; set; }

        public ControllerTimeDepositTransaction(ModelTimeDepositTransaction model, TransactionTimeDeposit view)
        {
            this.view = view;
            this.model = model;

            this.RefreshFields();
            //this.view.disablePrintCertificate();
            //this.view.disableCboExtensionDays();
            this.view.setDataGrid(model.getTimeDepositAccounts());
            this.view.setDataGridEvent(dataGridClickedEvent);
            this.view.setCboTransactionTypeSelectedIndexChanged(CboTransactionTypeSelectedIndexChanged);
            this.view.setBtnSaveTransactionEvent(BtnSaveTransaction);
            this.view.setCboMaturityOptionEvent(CboMaturityOptionSelectionChangeCommitted);
            this.view.setBtnSaveMaturityEvent(BtnSaveMaturityOption);
            //this.view.setCboReleaseTypeEvent(cboReleaseTypeChanged);
            this.view.Show();
            this.view.searchPressed += new EventHandler(searchPressed);
        }

        //public void cboReleaseTypeChanged(object sender,EventArgs e)
        //{
        //    if (view.getReleaseType() == "C")
        //    {
        //        view.disableCheckInformation();
        //    }

        //    else
        //    {
        //        view.enableCheckInformation();
        //    }
        //}

        public void searchPressed(object sender,EventArgs e)
        {
            if (view.getSearchBy() == "Time Deposit No")
            {
                model.timeAccountNo = view.getTxtSearch();
                view.setDataGrid(model.searchByTimeDepositNo());
            }

            else if (view.getSearchBy() == "Member Name")
            {
                model.memberName = view.getTxtSearch();
                view.setDataGrid(model.searchByMemberName());   

            }
        }

        public void BtnSaveMaturityOption(object sender, EventArgs e)
        {
            if (this.validateSaveMaturity())
            {
                ModelTimeDepositAccount mtda = new ModelTimeDepositAccount();
                mtda.timeDepositNo = view.getTimeDepositNo();
                mtda.maturityInstruction = view.getMaturityOption().ToString();
                mtda.savingsAccountNo = view.getCboSavingsTransfer();
                mtda.updateMaturityOption();
                MessageBox.Show("Maturity instruction successfully updated","Time deposit renewal",MessageBoxButtons.OK);
            }
        }

        public void CboMaturityOptionSelectionChangeCommitted(object sender, EventArgs e)
        {
            if (view.getMaturityOption() >= 3)
            {
                ModelSavingsAccount msa = new ModelSavingsAccount();
                msa.accountNo = accountNo;
                view.setCboSavingsTransfer(msa.getSavingsAccounts());
                view.enableCboSavingsTransfer();

            }

            else
            {
                view.disableCboSavingsTransfer();
            }
        }

        public void BtnSaveTransaction(object sender, EventArgs e)
        {
            ModelCheckInformation checkModel = new ModelCheckInformation();
            DialogResult dr = MessageBox.Show("Are you sure you want to close this account?", "Time Deposit Closure", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                if (this.validateTransaction())
                {
                    if (view.getTransactionType() == "Transfer to savings")
                    {
                        //Deposit on savings
                        ModelSavingsTransaction mst = new ModelSavingsTransaction();
                        mst.savingsAccountID = view.getCboSavings();
                        mst.transactionType = "D";
                        mst.userID = ModelUser.userID;
                        mst.amount = view.getTotal();
                        mst.comments = "Deposit from time deposit closure";
                        mst.controlNo = "";
                        mst.insertSavingsTransaction();
                    }

                    //Insert the pretermination penalty upon closure
                    ModelTimeDepositAccount mtda = new ModelTimeDepositAccount();
                    mtda.preterminationPenalty = view.getPenalty();
                    mtda.timeDepositNo = view.getTimeDepositNo();
                    mtda.insertPreterminationPenalty();

                    //Insert Time Deposit Transaction
                    model.timeAccountNo = view.getTimeDepositNo();
                    model.amount = view.getTotal();
                    model.userID = ModelUser.userID;
                    model.transactionType = "C";
                    checkModel.transactionID = model.insertTransaction();
                    MessageBox.Show("Time deposit account successfully closed.");
                    view.setDataGrid(model.getTimeDepositAccounts());
                    view.disableTransactionType();

                    //if (view.getReleaseType() == "CH")
                    //{
                    //    checkModel.checkNo = view.getCheckNo();
                    //    checkModel.bankName = view.getBankName();
                    //    checkModel.dateIssued = view.getCheckDateIssued();
                    //    checkModel.transactionTable = "TD";
                    //    checkModel.insertCheckInformation();
                    //}
                }
            }   
        }

        public bool validateSaveMaturity()
        {
            bool check = false;

            if (view.getTimeDepositNo().Length != 0)
            {
                check = true;
                if (view.getMaturityOption() > 2)
                {
                    if (view.getCboSavingsTransfer().Length != 0)
                    {
                        check = true;
                    }

                    else
                    {
                        check = false;
                        MessageBox.Show("The member has no savings account.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            else
            {
                MessageBox.Show("Please choose a time deposit account.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return check;
        }

        public bool validateTransaction()
        {
            bool check = false;
            if (view.getTimeDepositNo().Length != 0)
            {
                if (Validator.isValidAmount(view.getAmount()))
                {
                    check = true;
                    if (view.getTransactionType() == "Transfer to savings")
                    {
                        if (view.getCboSavings().Length != 0)
                        {
                            check = true;
                        }

                        else
                        {
                            check = false;
                            MessageBox.Show("The member has no savings account.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }

                else
                {
                    MessageBox.Show("Please select a transaction type.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else
            {
                MessageBox.Show("Please choose a time deposit account.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return check;
        }

        public void CboTransactionTypeSelectedIndexChanged(object sender, EventArgs e)
        {
            if (view.getTransactionType() == "Transfer to savings")
            {
                ModelSavingsAccount msa = new ModelSavingsAccount();
                msa.accountNo = accountNo;
                view.setCboSavings(msa.getSavingsAccounts());
                view.enableCboSavings();
            }

            else
            {
                view.disableCboSavings();
            }
        }

        public void dataGridClickedEvent(object sender, DataGridViewCellEventArgs e)
        {
            view.refreshCombobox();
            view.disableCboSavings();
            view.setTotal("");
            view.setPenalty("");
            view.setAmount("");
            view.setInterest("");
            view.enableTransactionType();
            DataGridView dg = view.getDataGrid();
            int row = dg.CurrentCell.RowIndex;
            model.timeAccountNo = dg.Rows[row].Cells[0].Value.ToString();
            accountNo = dg.Rows[row].Cells[4].Value.ToString();
            SqlDataReader reader = model.searchTimeDepositAccount();
            if (reader.Read())
            {
                view.setTimeDepositNo(reader[0].ToString());
                view.setMemberName(reader[1].ToString());
                view.setBalance(reader[2].ToString());
                view.setMaturityDate(reader[3].ToString());
                view.setMaturitOption(Convert.ToInt32(reader[5]));
                view.setInterestRate(reader[7].ToString());
            }
            
            model.timeAccountNo = view.getTimeDepositNo();
            view.setAmount(view.getBalance());
            view.setInterest(model.getInterest().ToString());
            //view.disableCboExtensionDays();
            //view.disablePrintCertificate();
            //view.enablePrintVoucher();
            if (view.getMaturityDate().Length != 0)
            {
                if (Convert.ToDateTime(view.getMaturityDate()) <= DateTime.Now)
                {
                    view.setPenalty("0.00");
                }

                else
                {
                    view.setPenalty(model.getPenalty().ToString());
                }
            }

            if (view.getInterest().Length != 0 && view.getAmount().Length != 0)
            {
                double total = Convert.ToDouble(view.getInterest()) + Convert.ToDouble(view.getAmount()) - Convert.ToDouble(view.getPenalty());
                view.setTotal(total.ToString());
            }
            view.setSignatureImage1("SpecimenSignatures1//"+accountNo+".jpeg",accountNo+".jpeg");
            view.setSignatureImage2("SpecimenSignatures2//" + accountNo + ".jpeg", accountNo + ".jpeg");
        }

        public void RefreshFields()
        {
            //view.setTerm(new ModelTimeDepositAccount().getTerms());
            view.setTimeDepositNo("");
            view.setMaturityDate("");
            view.setSignatureImage1("", "");
            view.setSignatureImage2("", "");
            view.setAmount("");
            view.setMemberName("");
            view.setBalance("");
            view.setInterest("");
            view.setTotal("");
            view.setPenalty("");
            view.disableCboSavings();
            view.disableTransactionType();
            //view.disableCheckInformation();
        }
    }
}
