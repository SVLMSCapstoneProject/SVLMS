using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SVLMS.Loaning.Model;
using SVLMS.Loaning.View;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace SVLMS.Loaning.Controller
{
    class ControllerLoanApproval
    {
        ModelLoan model;
        TransactionLoanApprovalView view;

        //public string savingsAccountNo { get; set; }

        public ControllerLoanApproval(ModelLoan model, TransactionLoanApprovalView view)
        {
            this.model = model;
            this.view = view;
            this.RefreshFields();
            this.view.disableAmortization();
            this.view.setDataGridLoanApplicationsEvent(dataGridLoanApplications);
            this.view.setBtnApproveEvent(BtnApproveClicked);
            this.view.setBtnRejectEvent(BtnRejectClicked);
            this.view.setBtnComputeAmortEvent(BtnComputeAmort);
            this.view.searchPressed += new EventHandler(searchPressed);
            this.view.Show();
        }

        public void searchPressed(object sender,EventArgs e)
        {
            if (view.getSearchBy() == "Loan No")
            {
                model.loanNo = view.getTxtSearch();
                view.setDataGridLoanApplications(model.SearchByLoanApplication(1));
            }

            else if (view.getSearchBy() == "Member Name")
            {
                model.memberName= view.getTxtSearch();
                view.setDataGridLoanApplications(model.SearchByLoanApplication(2));

            }


        }
        public void BtnComputeAmort(object sender, EventArgs e)
        {
            AmortizationCalculator ac = new AmortizationCalculator();
            ModelLoanRates ratesModel = new ModelLoanRates();

            if (this.validateComputeAmortization())
            {
                model.loanNo = view.getLoanNo();
                model.loanTypeID = model.getLoanTypeID();
                model.setLoanFieldsCalculateAmort();

                //Set values to calculator
                ratesModel.loanTypeID = model.loanTypeID;
                ratesModel.setLoanRatesValuesByLoanType();
                ac.interestRate = Convert.ToDouble(ratesModel.interestRate);
                ac.isPercentageInterest = Convert.ToInt32(ratesModel.isPercentageInterest);
                ac.capitalRate = Convert.ToDouble(ratesModel.shareRate);
                ac.isPercentageShare = Convert.ToInt32(ratesModel.isPercentageShare);
                ac.loanDate = model.loanDate;
                ac.termsOfPayment = Convert.ToInt32(view.getTermsOfPayment());
                ac.termsOfPaymentDays = ac.termsOfPayment*30;
                ac.paymentIntervalDays = model.paymentIntervalDays;

                //if (savingsAccountNo.Length != 0)
                //{
                //    ac.savingsRate = Convert.ToDouble(ratesModel.savingsRate);
                //    ac.isPercentageSavings = Convert.ToInt32(ratesModel.isPercentageSavings);
                //}
            
                string[,] amortSched = ac.getAmortizationSchedule(view.getApprovedAmount());
                view.setDataGridAmortization(amortSched);
                view.setlblLoanAmount(ac.getLoanAmount());
                view.setlblTotalAmount(ac.getTotalAmount());
                view.setlblTotalInterest(ac.getTotalInterest());
                //view.setlblTotalSavings(ac.getTotalSavings());
                view.setlblTotalShares(ac.getTotalShares());
                view.enableAmortization();
                view.increaseTabIndex();
            }
        }

        public void BtnApproveClicked(object sender, EventArgs e)
        {
            model.loanNo = view.getLoanNo();
            model.approvedAmount = view.getApprovedAmount();
            model.termsOfPayment = view.getTermsOfPayment();
            model.isApproved = "1";
            model.approvalRemarks = view.getRemarks();
            if (this.validateApproval())
            {
                model.loanApproval();
                MessageBox.Show("Loan successfully approved.");
                this.RefreshFields();
            }
        }

        public void BtnRejectClicked(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to reject this loan application?","Loan Approval",MessageBoxButtons.YesNo);
            model.loanNo = view.getLoanNo();
            model.approvedAmount = "0";
            model.isApproved = "0";
            model.termsOfPayment = view.getTermsOfPayment();
            model.approvalRemarks = view.getRemarks();
            if (dr == DialogResult.Yes)
            {
                if (this.validateRejection())
                {
                    model.loanApproval();
                    MessageBox.Show("Loan successfully rejected.");
                    this.RefreshFields();
                }
            }
        }

        public void dataGridLoanApplications(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dg = view.getDataGridLoanApplications();
            int row = dg.CurrentCell.RowIndex;
            model.loanNo = dg.Rows[row].Cells[0].Value.ToString();
            SqlDataReader reader = model.searchLoanApplicationRecord();
            if (reader.Read())
            {
                view.setLoanNo(reader[0].ToString());
                view.setMemberName(reader[1].ToString());
                view.setRequestedAmount(reader[2].ToString());
                view.setDateApplied(Convert.ToDateTime(reader[3]).Date.ToString("d"));
                view.setCollateral(reader[4].ToString());
                view.setTermsOfPayment(reader[5].ToString());
                view.setApprovedAmount(reader[6].ToString());
                view.setPaymentInterval(reader[7].ToString());
                model.loanTypeID = reader[8].ToString();
                //savingsAccountNo = reader[9].ToString();
            }
        }

        public bool validateApproval()
        {
            bool check = false;
            if (this.validateComputeAmortization())
            {
                check = true;
            }
            return check;
        }

        public bool validateRejection()
        {
            bool check = false;
            if (view.getLoanNo().Length != 0)
            {
                if (Validator.isValidDigit(view.getTermsOfPayment()))
                {
                    if (Validator.isAlphanumeric(view.getRemarks()) && view.getRemarks().Length > 0  && view.getRemarks().Length < 100)
                    {
                        check = true;
                    }

                    else
                    {
                        MessageBox.Show("Please input a correct value for remarks.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                else
                {
                    MessageBox.Show("Invalid value for the terms of payment.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else
            {
                MessageBox.Show("Please choose a loan application first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return check;
        }

        public bool validateComputeAmortization()
        {
            bool check = false;
            ModelLoanType mlt = new ModelLoanType();
            mlt.loanId = model.loanTypeID;

            if (view.getLoanNo().Length != 0)
            {
                if (Validator.isValidDigit(view.getTermsOfPayment()))
                {
                    if (Validator.isValidAmount(view.getApprovedAmount()) && view.getApprovedAmount().Length < 16)
                    {
                        mlt.searchLoanType();
                        int termsOfPayment = Convert.ToInt32(view.getTermsOfPayment());
                        int maxTerm = Convert.ToInt32(mlt.maxTerm);
                        double approvedAmount = Convert.ToDouble(view.getApprovedAmount());
                        double requestedAmount = Convert.ToDouble(view.getRequestedAmount());

                        if (approvedAmount <= requestedAmount)
                        {
                            if (approvedAmount >= Convert.ToDouble(mlt.minAmount) && approvedAmount <= Convert.ToDouble(mlt.maxAmount))
                            {
                                if ( termsOfPayment <= maxTerm)
                                {
                                    check = true;
                                }

                                else
                                {
                                    MessageBox.Show("The maximum term for this loan is " + maxTerm + " month/s.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                                 
                            else
                            {
                                MessageBox.Show("The amount required for this loan is from P " + Validator.amountFormatter(mlt.minAmount) + " to P " + Validator.amountFormatter(mlt.maxAmount) + ".", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }

                        else
                        {
                            MessageBox.Show("The approved amount is higher than the requested amount.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }

                    else
                    {
                        MessageBox.Show("Invalid value for the approved amount.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                else
                {
                    MessageBox.Show("Invalid value for the terms of payment.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else
            {
                MessageBox.Show("Please choose a loan application first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return check;
        }

        public void RefreshFields()
        {
            view.setDataGridLoanApplications(model.getLoanApplications());
            view.setLoanNo("");
            view.setMemberName("");
            view.setRequestedAmount("");
            view.setDateApplied("");
            view.setCollateral("");
            view.setTermsOfPayment("");
            view.setApprovedAmount("");
            view.setRemarks("");
            view.setPaymentInterval("");
        }
    }
}
