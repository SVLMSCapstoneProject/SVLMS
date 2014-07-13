using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SVLMS.Loaning.Model;
using SVLMS.Loaning.View;
using System.Configuration;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace SVLMS.Loaning.Controller
{
    class ControllerLoanModification
    {
        ModelLoan model;
        TransactionLoanModificationView view;

        private string[,] amortSched { get; set; }

        public ControllerLoanModification(ModelLoan model, TransactionLoanModificationView view)
        {
            this.view = view;
            this.model = model;

            this.view.setBtnComputeAmortizationEvent(BtnComputeAmortizationClicked);
            this.view.setBtnSaveEvent(BtnSaveClicked);
            this.view.setDataGridLoanRecordsEvent(dataGridLoanRecordsClicked);
            this.RefreshFields();
            this.view.Show();
            this.view.searchPressed += new EventHandler(searchPressed);

        }

        public void searchPressed(object sender,EventArgs e)
        {
            if (view.getSearchBy() == "Loan No")
            {
                model.loanNo = view.getTxtSearch();
                view.setDataGridLoanRecords(model.SearchByReleasedLoans(1));

            }

            else if (view.getSearchBy() == "Member Name")
            {
                model.memberName = view.getTxtSearch();
                view.setDataGridLoanRecords(model.SearchByReleasedLoans(2));

            }

        }

        public void dataGridLoanRecordsClicked(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dg = view.getDataGridLoanRecords();
            int row = dg.CurrentCell.RowIndex;
            //view.setIsPercentageShare(""); view.setIsPercentageSavings(""); view.setIsPercentageInterest("");
            //view.setInterestRate(""); view.setSavingsRate(""); view.setShareRate("");
            view.setLoanNo(dg.Rows[row].Cells[0].Value.ToString());
            view.setMemberName(dg.Rows[row].Cells[1].Value.ToString());
            model.loanNo = dg.Rows[row].Cells[0].Value.ToString();
            view.setRemainingPrincipal(model.getTotalLoanPrincipalBalance().ToString());
            //view.setPenalty(model.getTotalPenalties().ToString());
            view.setTotalBalance(model.getTotalBalance().ToString());

            ModelAmortization ma = new ModelAmortization();
            ma.loanNo = view.getLoanNo();
            view.setPenalty(ma.getPenalty(ma.countRemainingAmortization()).ToString());

            //model.loanNo = view.getLoanNo();
            //SqlDataReader reader1 = model.searchLoanApplicationRecord();
            //if (reader1.Read())
            //{
            //    model.savingsAccountNo = reader1["savingsAccountNo"].ToString();
            //}

            SqlDataReader reader = model.getLoanRates();
            if (reader.Read())
            {
                view.setInterestRate(reader["interestRate"].ToString());
                view.setIsPercentageInterest(reader["isPercentageInterest"].ToString());
                view.setShareRate(reader["shareRate"].ToString());
                view.setIsPercentageShare(reader["isPercentageShare"].ToString());

                //if (model.savingsAccountNo.Length != 0)
                //{
                //    view.setSavingsRate(reader["savingsRate"].ToString());
                //    view.setIsPercentageSavings(reader["isPercentageSavings"].ToString());
                //}

                //else
                //{
                //    view.setSavingsRate("0.00");
                //    view.setIsPercentageSavings("1");
                //}
            }
            reader.Close();
        }

        public void BtnComputeAmortizationClicked(object sender, EventArgs e)
        {
            //MessageBox.Show(view.getRemainingPrincipal());
            AmortizationCalculator ac = new AmortizationCalculator();
            if (this.validateComputeAmortization())
            {
                model.loanNo = view.getLoanNo();
                string loanAmount = "";
                if (view.getIncludePenalty() == "1")
                {
                    //loanAmount = view.getTotalBalance();
                    double loan = Convert.ToDouble(view.getRemainingPrincipal()) + Convert.ToDouble(view.getPenalty());
                    loanAmount = loan.ToString();
                }

                else
                {
                    loanAmount = view.getRemainingPrincipal();
                }
                ac.loanAmount = Convert.ToDouble(loanAmount);
                ac.interestRate = Convert.ToDouble(view.getInterestRate());
                ac.isPercentageInterest = Convert.ToInt32(view.getIsPercentageInterest());
                ac.capitalRate = Convert.ToDouble(view.getShareCapitalRate());
                ac.isPercentageShare = Convert.ToInt32(view.getIsPercentageShare());
                ac.termsOfPayment = Convert.ToInt32(view.getTermsOfPayment());
                ac.termsOfPaymentDays = Convert.ToInt32(view.getTermsOfPayment()) * 30;
                ac.paymentIntervalDays = Convert.ToInt32(view.getPaymentInterval());
                ac.loanDate = DateTime.Today.ToShortDateString();

                //if (model.savingsAccountNo.Length != 0)
                //{
                //    ac.savingsRate = Convert.ToDouble(view.getSavingsRate());
                //    ac.isPercentageSavings = Convert.ToInt32(view.getIsPercentageSavings());
                //}

                //else
                //{
                //    ac.savingsRate = 0;
                //    ac.isPercentageSavings = 1;
                //}
                amortSched = ac.getAmortizationSchedule(loanAmount);
                view.setDataGridAmortization(amortSched);
                view.setLoanAmount(ac.amortizationAmount.ToString());
                view.setLblLoanAmount(ac.loanAmount.ToString());
                view.setLblShareCapital(ac.totalShare.ToString());
                view.setLblTotalInterest(ac.totalInterest.ToString());
                view.setLblTotalAmount(ac.getTotalAmount().ToString());
                //MessageBox.Show(ac.noOfAmortization.ToString());
                //MessageBox.Show(loanAmount);
                view.increaseTabIndex();
            }
        }

        public void BtnSaveClicked(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to restructure this loan?", "Loan Modification", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                if (this.validateSaveModification())
                {
                    //Loan Rates
                    model.paymentInterval = Convert.ToInt32(view.getPaymentIntervalIndex());
                    model.termsOfPayment = view.getTermsOfPayment();
                    this.insertRatesRestructure();
                    model.restructureLoan();
                    ModelAmortization ma = new ModelAmortization();
                    ma.loanNo = view.getLoanNo();
                    ma.insertAmortizationSchedule(amortSched);
                    //model.insertAmortizationSchedule(amortSched);
                    MessageBox.Show("Loan Successfully Restructured.");
                    this.RefreshFields();
                }
            }
        }

        private void insertRatesRestructure()
        {
            ModelLoanRates ratesModel = new ModelLoanRates();
            ratesModel.loanRatesID = ratesModel.getNextRateID();
            ratesModel.interestRate = view.getInterestRate();
            ratesModel.isPercentageInterest = view.getIsPercentageInterest();
            ratesModel.shareRate = view.getShareCapitalRate();
            ratesModel.isPercentageShare = view.getIsPercentageShare();
            //if (model.savingsAccountNo.Length != 0)
            //{
            //    ratesModel.savingsRate = view.getSavingsRate();
            //    ratesModel.isPercentageSavings = view.getIsPercentageSavings();
            //}

            //else
            //{
            //    ratesModel.savingsRate = "0";
            //    ratesModel.isPercentageSavings = "1";
            //}
            ratesModel.effectivityDate = DateTime.Today.ToShortDateString();
            ratesModel.status = "0";
            ratesModel.loanTypeID = model.getLoanTypeID();
            ratesModel.insertLoanRates();
            model.loanRatesID = ratesModel.loanRatesID;
            model.updateLoanRates();
        }

        public bool validateSaveModification()
        {
            bool check = false;
            if (this.validateComputeAmortization())
            {
                check = true;
            }
            return check;
        }

        public bool validateComputeAmortization()
        {
            bool check = false;
            ModelLoanType mlt = new ModelLoanType();
            if (view.getLoanNo().Length != 0)
            {
                if (Validator.isValidDigit(view.getTermsOfPayment()))
                {
                    model.loanNo = view.getLoanNo();
                    mlt.loanId = model.getLoanTypeID();
                    mlt.searchLoanType();
                    int maxTerm = Convert.ToInt32(mlt.maxTerm);
                    int termsOfPayment = Convert.ToInt32(view.getTermsOfPayment());
                    if (termsOfPayment <= maxTerm)
                    {
                        if (Validator.isValidRate(view.getInterestRate()) && view.getInterestRate().Length < 6)
                        {
                            //if (Validator.isValidRate(view.getSavingsRate()) && view.getSavingsRate().Length < 6)
                            //{
                                if (Validator.isValidRate(view.getShareCapitalRate()) && view.getShareCapitalRate().Length < 6)
                                {
                                    check = true;
                                }

                                else
                                {
                                    MessageBox.Show("Invalid value in share capital rate.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            //}

                            //else
                            //{
                                //MessageBox.Show("Invalid value in savings rate.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            //}
                        }

                        else
                        {
                            MessageBox.Show("Invalid value in interest rate.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                    else
                    {
                        MessageBox.Show("The maximum term for this loan is "+mlt.maxTerm+" month/s.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                else
                {
                    MessageBox.Show("Invalid value in terms of payment.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else
            {
                MessageBox.Show("Please select a loan to be modified first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return check;
        }

        public void RefreshFields()
        {
            view.setDataGridLoanRecords(model.getReleasedLoans());
            view.setMemberName("");
            view.setLoanNo("");
            view.setPenalty("");
            view.setRemainingPrincipal("");
            view.setInterestRate("");
            view.setTermsOfPayment("");
            //view.setSavingsRate("");
            view.setShareRate("");
            view.setLoanAmount("");
            view.clearRadioButton();
            view.clearDataGridAmortization();
        }
    }
}
