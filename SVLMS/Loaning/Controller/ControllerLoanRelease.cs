using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SVLMS.Loaning.Model;
using SVLMS.Loaning.View;
using SVLMS.Savings.Model;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace SVLMS.Loaning.Controller
{
    class ControllerLoanRelease
    {
        ModelLoan model;
        TransactionLoanReleaseView view;
        ModelLoanApplication mla = new ModelLoanApplication();

        public ControllerLoanRelease(ModelLoan model, TransactionLoanReleaseView view)
        {
            this.model = model;
            this.view = view;

            //Set Events
            this.RefreshFields();
            this.view.setBtnReleaseEvent(BtnReleaseClicked);
            this.view.setDataGridApprovedLoansEvent(DataGridViewApprovedLoansClicked);
            this.view.setRbtnCheckEvent(RbtnCheckClicked);
            this.view.setRbtnCashEvent(RbtnCashClicked);
            this.view.Show();
            this.view.searchPressed += new EventHandler(searchPressed);
        }

        public void searchPressed(object sender,EventArgs e)
        {
            if (view.getSearchBy() == "Loan No")
            {
                view.setDataGridApprovedLoans(model.SearchByApprovedLoans(1,view.getTxtSearch()));
            }

            else if (view.getSearchBy() == "Member Name")
            {
                view.setDataGridApprovedLoans(model.SearchByApprovedLoans(2, view.getTxtSearch()));

            }

        }

        public void RbtnCheckClicked(object sender, EventArgs e)
        {
            view.enableCheckInformation();
        }

        public void RbtnCashClicked(object sender, EventArgs e)
        {
            view.disableCheckInformation();
        }

        public void BtnReleaseClicked(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to release the loan?","Loan Release",MessageBoxButtons.YesNo);
            
            if (dr == DialogResult.Yes)
            {
                if (this.validateLoanRelease())
                {
                    ModelCheckInformation checkModel = new ModelCheckInformation();
                    model.releaseType = view.getReleaseType();
                    model.loanNo = view.getLoanNo();
                    model.userID = ModelUser.userID;

                    if (Convert.ToDouble(view.getPreviousLoanBalance()) > 0)
                    {
                        //Pay the previous loan
                        ModelLoanPayment mlp = new ModelLoanPayment();
                        mlp.loanNo = mla.loanNo;
                        mlp.accountNo = 
                        mlp.paymentAmount = view.getPreviousLoanBalance();
                        mlp.userID = ModelUser.userID;
                        mlp.insertLoanPayment(new ModelAmortization() { loanNo = mlp.loanNo }.countRemainingAmortization(), 0, "");
                    }

                    //Release Loan
                    int transactionID = model.loanRelease();

                    if (model.releaseType == "CH")
                    {
                        checkModel.checkNo = view.getCheckNo();
                        checkModel.bankName = view.getBankName();
                        checkModel.dateIssued = view.getDateIssued();
                        checkModel.transactionID = transactionID.ToString();
                        checkModel.transactionTable = "L";
                        checkModel.insertCheckInformation();
                    }

                    AmortizationCalculator ac = new AmortizationCalculator();
                    model.loanNo = view.getLoanNo();
                    model.loanTypeID = model.getLoanTypeID();
                    model.setLoanFieldsCalculateAmort();

                    //Set values to calculator
                    SqlDataReader reader = model.getLoanRates();
                    if (reader.Read())
                    {
                        ac.interestRate = Convert.ToDouble(reader["interestRate"]);
                        ac.isPercentageInterest = Convert.ToInt32(reader["isPercentageInterest"]);
                        ac.capitalRate = Convert.ToDouble(reader["shareRate"]);
                        ac.isPercentageShare = Convert.ToInt32(reader["isPercentageShare"]);

                        //if (model.savingsAccountNo.Length != 0)
                        //{
                        //    ac.savingsRate = Convert.ToDouble(reader["savingsRate"]);
                        //    ac.isPercentageSavings = Convert.ToInt32(reader["isPercentageSavings"]);
                        //}

                        //else
                        //{
                        //    ac.savingsRate = 0;
                        //    ac.isPercentageSavings = 1;
                        //}
                    }

                    ac.loanDate = model.loanDate;
                    ac.termsOfPayment = Convert.ToInt32(model.termsOfPayment);
                    ac.termsOfPaymentDays = ac.termsOfPayment * 30;
                    ac.paymentIntervalDays = model.paymentIntervalDays;
                    string[,] amortSchedule = ac.getAmortizationSchedule(view.getApprovedAmountRelease());
                    model.insertChargedFromLoans();
                    ModelAmortization ma = new ModelAmortization();
                    ma.loanNo = view.getLoanNo();
                    ma.insertAmortizationSchedule(amortSchedule);

                    MessageBox.Show("Loan successfully Released.");
                    view.disableBtnRelease();
                    view.enablePrintVoucher();
                    this.RefreshFields();
                }
            }
        }

        public void DataGridViewApprovedLoansClicked(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dg = view.getDataGridApprovedLoans();
            int row = dg.CurrentCell.RowIndex;
            
            mla.accountNo = dg.Rows[row].Cells[5].Value.ToString();
            mla.loanNo = "";
            view.setPreviousLoanBalance(mla.getLoanBalance().ToString());
            SqlDataReader reader = mla.getPreviousLoan();
            if (reader.Read())
            {
                mla.loanNo = reader["loanNo"].ToString();
            }

            //Set values to Loan Information
            view.setLoanNo(dg.Rows[row].Cells[0].Value.ToString());
            view.setMemberName(dg.Rows[row].Cells[1].Value.ToString());
            view.setApprovedAmount(dg.Rows[row].Cells[2].Value.ToString());
            view.setApprovedAmountRelease(dg.Rows[row].Cells[2].Value.ToString());
            view.setRequestedAmount(dg.Rows[row].Cells[3].Value.ToString());
            view.setApprovalDate(dg.Rows[row].Cells[4].Value.ToString());

            //Set Values to charges
            model.loanNo = dg.Rows[row].Cells[0].Value.ToString();
            view.setDataGridCharges(model.getApprovedLoansCharges());
            model.loanNo = view.getLoanNo();
            //SqlDataReader reader = model.searchLoanApplicationRecord();
            //if (reader.Read())
            //{
            //    model.savingsAccountNo = reader["savingsAccountNo"].ToString();
            //}

            //Get the net amount
            double netAmount = 0;
            double totalCharges = model.getTotalCharges();
            double previousLoanBalance = mla.getLoanBalance();
            double approvedAmount = Convert.ToDouble(view.getApprovedAmountRelease());
            netAmount = approvedAmount - (totalCharges + previousLoanBalance);
            view.setNetAmount(netAmount.ToString());
            view.enableBtnRelease();
            view.disablePrintVoucher();
        }

        public bool validateLoanRelease()
        {
            bool check = false;
            if (view.getLoanNo().Length != 0)
            {
                check = true;
                if (view.getReleaseType().Length != 0)
                {
                    if (view.getReleaseType() == "CH")
                    {
                        if (Validator.isValidDigit(view.getCheckNo()))
                        {
                            if (Validator.isAlphanumeric(view.getBankName()) && view.getBankName().Length > 0)
                            {
                                check = true;
                            }

                            else
                            {
                                check = false;
                                MessageBox.Show("Invalid value for bank name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }

                        else
                        {
                            check = false;
                            MessageBox.Show("Invalid value for check number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }

                else
                {
                    MessageBox.Show("Please choose a release type.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    check = false;
                }
            }

            else
            {
                MessageBox.Show("Please choose an approved loan application first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return check;
        }


        public void RefreshFields()
        {
            view.setDataGridApprovedLoans(model.SearchByApprovedLoans(1,view.getTxtSearch()));
            view.disableCheckInformation();
            //view.setLoanNo("");
            //view.setMemberName("");
            //view.setRequestedAmount("");
            //view.setApprovalDate("");
            //view.setApprovedAmount("");
            view.setCheckNo("");
            view.setBankName("");
            view.setApprovedAmountRelease("");
            view.setNetAmount("");
            view.clearDataGrid();
            view.clearRadioButton();
        }
    }
}
