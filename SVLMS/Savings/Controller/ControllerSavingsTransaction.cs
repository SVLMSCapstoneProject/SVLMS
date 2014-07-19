using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using SVLMS.Savings.Model;
using SVLMS.Loaning.Model;
using SVLMS.Savings.View;
using System.Windows.Forms;

namespace SVLMS.Savings.Controller
{
    class ControllerSavingsTransaction
    {
        ModelSavingsTransaction model;
        TransactionSavings view;

        public ControllerSavingsTransaction(ModelSavingsTransaction model, TransactionSavings view)
        {
            this.view = view;
            this.model = model;

            this.view.Show();
            this.RefreshFields();
            this.view.setDataGridEvent(dataGridClicked);
            this.view.setBtnSaveTransactionEvent(btnSaveTransaction);
            this.view.setTextSearchChange(txtSearchTextChange);
            this.view.setCboTransactionTypeEvent(cboTransactionTypeChange);
            this.view.setDataGridAccountHoldersEvent(dataGridAccountHoldersClicked);
            this.view.setRbtnMemberClickEvent(rbtnMemberClicked);
            this.view.setRbtnFamilyClickEvent(rbtnFamilyClicked);
            //this.view.setCboReleaseTypeEvent(cboReleaseTypeChange);
        }

        //public void cboReleaseTypeChange(object sender, EventArgs e)
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

        public void rbtnMemberClicked(object sender, EventArgs e)
        {
            ModelSavingsAccount m = new ModelSavingsAccount();
            m.savingsAccountID = view.getSavingsAccountNo();
            m.accountNo = view.getSavingsAccountNo();
            view.setIsFamily("0");
            view.setDataGridAccountHolders(m.getMemberSecondaryHolders());
        }

        public void rbtnFamilyClicked(object sender, EventArgs e)
        {
            ModelSavingsAccount m = new ModelSavingsAccount();
            m.accountNo = view.getSavingsAccountNo();
            m.savingsAccountID = view.getSavingsAccountNo();
            view.setIsFamily("1");
            view.setDataGridAccountHolders(m.getFamilyAccountHolders());
        }

        public void dataGridAccountHoldersClicked(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dg = view.getDataGridAccountHolders();
            int row = dg.CurrentCell.RowIndex;
            string isFamily = view.getIsFamily();
            ModelSavingsAccount m = new ModelSavingsAccount();
            m.savingsAccountID = view.getSavingsAccountNo();

            if (isFamily == "1")
            {
                m.familyID = dg.Rows[row].Cells[0].Value.ToString();
                view.setAccountHolderName(dg.Rows[row].Cells[1].Value.ToString());
                view.setAccountHolderType("Secondary Holder");
            }

            else
            {
                m.accountNo = dg.Rows[row].Cells[0].Value.ToString();
                view.setAccountHolderName(dg.Rows[row].Cells[1].Value.ToString());
                view.setAccountHolderType(dg.Rows[row].Cells[2].Value.ToString());
            }
            
            view.setPictureSingature1("SpecimenSignatures1//" + m.getSignatureImage(isFamily), m.getSignatureImage(isFamily));
            view.setPictureSingature2("SpecimenSignatures2//" + m.getSignatureImage(isFamily), m.getSignatureImage(isFamily));
        }

        public void cboTransactionTypeChange(object sender, EventArgs e)
        {
            //view.disableCheckInformation();
            if (view.getTransactionType() == "D")
            {
                view.enableDeposit();
                view.disablePrintVoucher();
                view.enableTxtTransact();
                //view.disableReleaseType();
            }

            else if (view.getTransactionType() == "C")
            {
                view.disableDeposit();
                view.disablePrintVoucher();
                view.disableTxtTransact();
                view.setAmountSavings(model.getCurrentBalance(view.getSavingsAccountNo()));
                //view.enableReleaseType();
            }

            else if (view.getTransactionType() == "W")
            {
               view.disableDeposit();
               view.enablePrintVoucher();
               view.enableTxtTransact();
               //view.enableReleaseType();
            }
        }

        public void txtSearchTextChange(object sender, EventArgs e)
        {
            if (view.getSearchBy() == "Savings Account No")
            {
                view.setDataGrid(new ModelSavingsAccount().searchAllSavingsAccount(0,view.getSearchBoxText()));
            }

            if (view.getSearchBy() == "Account Name")
            {
                view.setDataGrid(new ModelSavingsAccount().searchAllSavingsAccount(1,view.getSearchBoxText()));
            }
        }

        public void btnSaveTransaction(object sender, EventArgs e)
        {
            ModelCheckInformation checkModel = new ModelCheckInformation();
            model.transactionType = view.getTransactionType();
            model.amount = view.getAmountSavings();
            model.controlNo = view.getControlNumber();
            model.savingsAccountID = view.getSavingsAccountNo();
            model.userID = ModelUser.userID;
            model.comments = "";
            
            if (view.getTransactionType() == "D")
            {
                if (this.validateTransactionDeposit())
                {
                    double amountTendered = Convert.ToDouble(view.getAmountTendered());
                    double transactionAmount = Convert.ToDouble(view.getAmountSavings());
                    view.setChange((amountTendered - transactionAmount).ToString());
                    model.insertSavingsTransaction();
                    MessageBox.Show("Transaction successfully saved.");
                    this.RenewFields();
                }
            }

            if (view.getTransactionType() == "W")
            {
                if (this.validateTransactionWithdrawal())
                {
                    checkModel.transactionID = model.insertSavingsTransaction();
                    MessageBox.Show("Transaction successfully saved.");
                    this.RenewFields();
                }

                //if (view.getReleaseType() == "CH")
                //{
                //    checkModel.checkNo = view.getCheckNo();
                //    checkModel.bankName = view.getBankName();
                //    checkModel.dateIssued = view.getCheckDateIssued();
                //    checkModel.transactionTable = "S";
                //    checkModel.insertCheckInformation();
                //}
            }

            if (view.getTransactionType() == "C")
            {
                DialogResult dr = MessageBox.Show("Are you sure you want to close this account?","Close Account",MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    model.insertSavingsTransaction();
                    MessageBox.Show("Savings account successfully closed.");
                    view.setDataGrid(new ModelSavingsAccount().getAllSavingsAccounts());
                    //this.RefreshFields();
                }
            }
            
        }

        public bool validateTransactionDeposit()
        {
            bool check = false;
            if (view.getSavingsAccountNo().Length != 0)
            {
                if (Validator.isValidDigit(view.getControlNumber()))
                {
                    if (!Validator.isAlphanumeric(view.getAmountSavings()) && view.getAmountSavings().Length < 16 && Convert.ToDouble(view.getAmountSavings()) > 0)
                    {
                        if (!Validator.isAlphanumeric(view.getAmountTendered()) && view.getAmountTendered().Length < 16 && Convert.ToDouble(view.getAmountTendered()) > 0)
                        {
                            double amountSavings = Convert.ToDouble(view.getAmountSavings());
                            double amountTendered = Convert.ToDouble(view.getAmountTendered());
                            if (amountTendered >= amountSavings)
                            {
                                if (!Validator.isAlphanumeric(view.getControlNumber()))
                                {
                                    check = true;
                                }

                                else
                                {
                                    MessageBox.Show("Invalid value for control number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }

                            else
                            {
                                MessageBox.Show("Amount tendered must be greater than or equal to the transaction amount.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }

                        else
                        {
                            MessageBox.Show("Invalid value for amount tendered.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                    else
                    {
                        MessageBox.Show("Invalid value for transaction amount.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                else
                {
                    MessageBox.Show("Invalid value for control number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else
            {
                MessageBox.Show("Please choose a savings account first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return check;
        }

        public bool validateTransactionWithdrawal()
        {
            bool check = false;
            ModelSavingsAccount msa = new ModelSavingsAccount();
            ModelSavingsType mst = new ModelSavingsType();
            msa.savingsAccountID = view.getSavingsAccountNo();
            msa.searchSavingsAccount();
            mst.savingsTypeID = msa.savingsTypeID;
            mst.searchSavingsType();
            int days = Convert.ToInt32(mst.maxWithdrawDuration) * ModelUser.getIntervalInDays(mst.maxWithdrawalTime.ToString());
            if (view.getSavingsAccountNo().Length != 0)
            {
                if (Validator.isValidDigit(view.getControlNumber()))
                {
                    if (!Validator.isAlphanumeric(view.getAmountSavings()) && view.getAmountSavings().Length < 16 && Convert.ToDouble(view.getAmountSavings()) > 0)
                    {
                        double remainingBalance = Convert.ToDouble(view.getCurrentBalance()) - Convert.ToDouble(view.getAmountSavings());
                        //double maintainingBalance = Convert.ToDouble(mst.maintainingBalance);
                    
                        if (remainingBalance > 0)
                        {
                            if (Convert.ToDouble(view.getAmountSavings()) >= Convert.ToDouble(mst.minimumWithdrawal))
                            {
                                double totalWithdrawals = msa.getAccountWithdrawalAmount(days) + Convert.ToDouble(view.getAmountSavings());
                                double maxAmount = Convert.ToDouble(mst.maxWithdrawalAmount);
                                if (maxAmount > 0)
                                {
                                    if (totalWithdrawals <= maxAmount)
                                    {
                                        check = true;
                                    }

                                    else
                                    {
                                        MessageBox.Show("The total amount withdrawn from this account for the last " + days + " days is P" + Validator.amountFormatter(msa.getAccountWithdrawalAmount(days).ToString()) + ". The withdrawal transaction will exceed the maximum withdrawal amount of P " + Validator.amountFormatter(mst.maxWithdrawalAmount) + ".", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }

                                else
                                {
                                    check = true;
                                }
                            }

                            else
                            {
                                MessageBox.Show("The minimum withdrawal amount for this account is P "+Validator.amountFormatter(mst.minimumWithdrawal)+".", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }

                        else
                        {
                           // MessageBox.Show("The account must have a maintaining balance of P"+Validator.amountFormatter(mst.maintainingBalance)+".", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            MessageBox.Show("The remaining balance must be greater than 0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                    else
                    {
                        MessageBox.Show("Invalid value for transaction amount.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                else
                {
                    MessageBox.Show("Invalid value for control number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else
            {
                MessageBox.Show("Please choose a savings account first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return check;
        }

        public void dataGridClicked(object sender, EventArgs e)
        {
            DataGridView dg = view.getDataGrid();
            int row = dg.CurrentCell.RowIndex;
            this.RefreshFields2();
            view.setDataGridSelection(row);
            view.setAccountNo(dg.Rows[row].Cells[0].Value.ToString());
            view.setMemberName(dg.Rows[row].Cells[1].Value.ToString());
            view.setSavingsType(dg.Rows[row].Cells[2].Value.ToString());
            view.setCurrentBalance(dg.Rows[row].Cells[3].Value.ToString());
            string signature = "SpecimenSignatures1\\" + model.getSignatureImage(dg.Rows[row].Cells[0].Value.ToString());
            //view.setSignatureImage(signature, model.getSignatureImage(dg.Rows[row].Cells[0].Value.ToString()));

            //Set Account Holders DataGrid
            ModelSavingsAccount m = new ModelSavingsAccount();
            m.accountNo = view.getSavingsAccountNo();
            m.savingsAccountID = dg.Rows[row].Cells[0].Value.ToString();
            view.setIsFamily("0");
            view.setDataGridAccountHolders(m.getMemberSecondaryHolders());
        }

        public void RenewFields()
        {
            view.setCurrentBalance(model.getCurrentBalance(view.getSavingsAccountNo()));
            view.setDataGrid(new ModelSavingsAccount().getAllSavingsAccounts());
            //view.disableDeposit();
            //view.setChange("");
            view.setControlNumber("");
            view.setAmountTendered("");
            view.setAmountSavings("");
        }

        public void RefreshFields()
        {
            view.setDataGrid(new ModelSavingsAccount().getAllSavingsAccounts());
            view.setAccountNo("");
            view.setMemberName("");
            view.setCurrentBalance("");
            view.setAmountSavings("");
            view.setSavingsType("");
            view.disableDeposit();
            view.setChange("");
            view.setControlNumber("");
            view.setAmountTendered("");
            //view.clearSignaturePic();
            view.enableDeposit();
            view.setPictureSingature1("", "");
            view.setPictureSingature2("", "");
            view.disablePrintVoucher();
            view.enableTxtTransact();
            view.setTransactionType(0);
            view.setAccountHolderName("");
            view.setAccountHolderType("");
            view.dataGridSavingsAccountClearSelection();
            //view.disableCheckInformation();
            //view.disableReleaseType();
        }

        public void RefreshFields2()
        {
            view.setAccountNo("");
            view.setMemberName("");
            view.setCurrentBalance("");
            view.setAmountSavings("");
            view.setSavingsType("");
            view.disableDeposit();
            view.setChange("");
            view.setControlNumber("");
            view.setAmountTendered("");
            //view.clearSignaturePic();
            view.enableDeposit();
            view.setPictureSingature1("", "");
            view.setPictureSingature2("", "");
            view.disablePrintVoucher();
            view.enableTxtTransact();
            view.setTransactionType(0);
            view.setAccountHolderName("");
            view.setAccountHolderType("");
            //view.disableCheckInformation();
            //view.disableReleaseType();
        }
    }
}
