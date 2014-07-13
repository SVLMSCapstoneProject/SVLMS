using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using SVLMS.Savings.Model;
using SVLMS.Loaning.Model;
using SVLMS.Loaning.View;
using System.Windows.Forms;

namespace SVLMS.Loaning.Controller
{
    class ControllerLoanPayment
    {
        ModelLoanPayment model;
        TransactionLoanPaymentView view;

        ModelSavingsAccount msa = new ModelSavingsAccount();

        private string accountNo { get; set; }

        public ControllerLoanPayment(ModelLoanPayment model, TransactionLoanPaymentView view)
        {
            this.model = model;
            this.view = view;
            this.RefreshFields();
            this.view.setDataGridLoanRecordsCellDoubleClick(setDataGridLoanRecordsClicked);
            this.view.setBtnComputeTotal(BtnComputeTotalClicked);
            this.view.setBtnSavePaymentEvent(BtnSavePaymentClicked);
            this.view.Show();
            this.view.searchPressed += new EventHandler(searchPressed);
        }

        public void searchPressed(object sender, EventArgs e)
        {
            if (view.getSearchBy() == "Loan No")
            {
                model.loanNo = view.getTxtSearch();
                view.setDataGridLoanRecords(model.searchByLoanNo());
            }

            else if (view.getSearchBy() == "Member Name")
            {
                model.memberName = view.getTxtSearch();
                view.setDataGridLoanRecords(model.searchByMemberName());

            }
        }

        public void BtnSavePaymentClicked(object sender, EventArgs e)
        {
            ModelAmortization ma = new ModelAmortization();

            if (this.validateCashPayment())
            {
                //int noOfPeriod = (view.getCboPaymentType() == "Normal") ? 1 : Convert.ToInt32(view.getNoOfPeriod());
                int noOfPeriod = Convert.ToInt32(view.getNoOfPeriod());
                int isChangeAdvance = Convert.ToInt32(view.getIsChangeAdvance());
                int num = (isChangeAdvance == 1) ? 1 : 0;
                noOfPeriod = num + noOfPeriod;
                ma.loanNo = view.getLoanNo();
                model.paymentAmount = view.getAmountTendered();
                model.userID = ModelUser.userID;
                double change = model.insertLoanPayment(noOfPeriod, isChangeAdvance, "");

                MessageBox.Show("Payment was successfully saved.");
                if (ma.countRemainingAmortization() != 0)
                {
                    this.nextAmortizationPayment();
                }
                view.setIsChangeAdvance("0");
                view.setAmountTendered("");
                view.setChange(change.ToString());
                view.setDataGridAmortization(model.getAmortizationPaymentSched(ma.getNoOfAmortization()));
                view.setDataGridLoanRecords(model.getLoanRecords());
                //****1
                view.setLblNoOfPaymentsMade(((ma.getNoOfAmortization() - ma.countRemainingAmortization()) + "/" + ma.getNoOfAmortization()));
                view.setLblAmountPaid(ma.getAmountPaid().ToString());
                //***change
                view.setLblRemainingAmount(ma.getLoanBalance(ma.countRemainingAmortization()).ToString());
                view.setLblPenaltyAmount(ma.getLoanPenalty(ma.countRemainingAmortization()).ToString());
                decimal totalAmounUnpaid = ma.getLoanPenalty(ma.countRemainingAmortization()) + ma.getLoanBalance(ma.countRemainingAmortization());
                view.setAmountUnpaid(totalAmounUnpaid.ToString());

            }


            //if (view.getCboModeOfPayment() == 0)
            //{
            //    if (this.validateCashPayment())
            //    {
            //        int noOfPeriod = (view.getCboPaymentType() == "Normal") ? 1 : Convert.ToInt32(view.getNoOfPeriod());
            //        int isChangeAdvance = Convert.ToInt32(view.getIsChangeAdvance());
            //        int num = (isChangeAdvance == 1) ? 1 : 0;
            //        noOfPeriod = num + noOfPeriod;
            //        ma.loanNo = view.getLoanNo();
            //        model.paymentAmount = view.getAmountTendered();
            //        model.userID = ModelUser.userID;
            //        double change = model.insertLoanPayment(noOfPeriod, isChangeAdvance,"");

            //        MessageBox.Show("Payment was successfully saved.");
            //        if (ma.countRemainingAmortization() != 0)
            //        {
            //            this.nextAmortizationPayment();
            //        }
            //        view.setIsChangeAdvance("0");
            //        view.setAmountTendered("");
            //        view.setChange(change.ToString());
            //        view.setDataGridAmortization(model.getAmortizationPaymentSched(ma.getNoOfAmortization()));
            //        view.setDataGridLoanRecords(model.getLoanRecords());
            //      //****1
            //        view.setLblNoOfPaymentsMade(((ma.getNoOfAmortization() - ma.countRemainingAmortization()) + "/" + ma.getNoOfAmortization()));
            //        view.setLblAmountPaid(ma.getAmountPaid().ToString());
            //        //***change
            //        view.setLblRemainingAmount(ma.getLoanBalance(ma.countRemainingAmortization()).ToString());
            //        view.setLblPenaltyAmount(ma.getLoanPenalty(ma.countRemainingAmortization()).ToString());
            //        decimal totalAmounUnpaid = ma.getLoanPenalty(ma.countRemainingAmortization()) + ma.getLoanBalance(ma.countRemainingAmortization());
            //        view.setAmountUnpaid(totalAmounUnpaid.ToString());

            //    }
            //}

            //else if (view.getCboModeOfPayment() == 1)
            //{
            //    if (this.validateSavingsPayment())
            //    {
            //        int noOfPeriod = (view.getCboPaymentType() == "Normal") ? 1 : Convert.ToInt32(view.getNoOfPeriod());
            //        int isChangeAdvance = Convert.ToInt32(view.getIsChangeAdvance());
            //        int num = (isChangeAdvance == 1) ? 1 : 0;
            //        noOfPeriod = num + noOfPeriod;
            //        ma.loanNo = view.getLoanNo();
            //        model.paymentAmount = view.getAmountTendered();
            //        model.userID = ModelUser.userID;
            //        double change = model.insertLoanPayment(noOfPeriod, isChangeAdvance,msa.savingsAccountID);

            //        MessageBox.Show("Payment was successfully saved.");
            //        if (ma.countRemainingAmortization() != 0)
            //        {
            //            this.nextAmortizationPayment();
            //        }
            //        view.setIsChangeAdvance("0");
            //        view.setAmountTendered("");
            //        view.setChange(change.ToString());
            //        view.setDataGridAmortization(model.getAmortizationPaymentSched(ma.getNoOfAmortization()));
            //        view.setDataGridLoanRecords(model.getLoanRecords());
            //       //***2
            //        view.setLblNoOfPaymentsMade(((ma.getNoOfAmortization() - ma.countRemainingAmortization()) + "/" + ma.getNoOfAmortization()));
            //        view.setLblAmountPaid(ma.getAmountPaid().ToString());
            //        //***change
            //        view.setLblRemainingAmount(ma.getLoanBalance(ma.countRemainingAmortization()).ToString());
            //        view.setLblPenaltyAmount(ma.getLoanPenalty(ma.countRemainingAmortization()).ToString());
            //        decimal totalAmounUnpaid = ma.getLoanPenalty(ma.countRemainingAmortization()) + ma.getLoanBalance(ma.countRemainingAmortization());
            //        view.setAmountUnpaid(totalAmounUnpaid.ToString());

            //    }
            //}
        }

        public void BtnComputeTotalClicked(object sender, EventArgs e)
        {
            ModelAmortization ma = new ModelAmortization();
            if (this.validateComputeTotal())
            {
                ma.loanNo = view.getLoanNo();
                int loanPeriod = Convert.ToInt32(view.getNoOfPeriod());
                decimal total = ma.getLoanBalance(loanPeriod) + ma.getPenalty(loanPeriod);

                view.setAmountToBePaid(ma.getLoanBalance(loanPeriod).ToString());
                view.setPenalty(ma.getPenalty(loanPeriod).ToString());
                view.setTotalAmount(total.ToString());
            }
        }

        public void cboPaymentTypeSelectionChange(object sender, EventArgs e)
        {
            ModelAmortization ma = new ModelAmortization();
            ma.loanNo = view.getLoanNo();
            view.disableAdvance();
            //double total = ma.getLoanBalance(1) + ma.getPenalty(1);
            view.setAmountToBePaid(ma.getLoanBalance(1).ToString());
            view.setPenalty(ma.getPenalty(1).ToString());
            double total = Convert.ToDouble(view.getAmountToBePaid()) +  Convert.ToDouble(view.getPenalty());
            view.setTotalAmount(total.ToString());
        }

        public void setDataGridLoanRecordsClicked(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dg = view.getDataGridLoanRecords();
            int row = dg.CurrentCell.RowIndex;
            view.setLoanNo(dg.Rows[row].Cells[0].Value.ToString());
            view.setMemberName(dg.Rows[row].Cells[2].Value.ToString());
            accountNo = dg.Rows[row].Cells[3].Value.ToString();
            view.setNoOfPeriod("1");
            this.nextAmortizationPayment();
        }

        public void nextAmortizationPayment()
        {
            ModelAmortization ma = new ModelAmortization();
            model.loanNo = view.getLoanNo();
            model.accountNo = accountNo;
            ma.loanNo = view.getLoanNo();
            view.setCurrentBalance(ma.getLoanBalance(ma.countRemainingAmortization()).ToString());
        //***3
            view.setLblNoOfPaymentsMade(((ma.getNoOfAmortization() - ma.countRemainingAmortization()) + "/" + ma.getNoOfAmortization()));
            view.setLblAmountPaid(ma.getAmountPaid().ToString());
            //***change
            view.setLblRemainingAmount(ma.getLoanBalance(ma.countRemainingAmortization()).ToString());
            view.setLblPenaltyAmount(ma.getLoanPenalty(ma.countRemainingAmortization()).ToString());
            decimal totalAmounUnpaid = ma.getLoanPenalty(ma.countRemainingAmortization()) + ma.getLoanBalance(ma.countRemainingAmortization());
            view.setAmountUnpaid(totalAmounUnpaid.ToString());

            view.setPenalty(ma.getPenalty(1).ToString());
            view.setDataGridAmortization(model.getAmortizationPaymentSched(ma.getNoOfAmortization()));
            ma.getTotalAmount();
            SqlDataReader reader = ma.getNextAmortization();
            if (reader.HasRows)
            {
                reader.Read();
                view.setDueDate(reader["dueDate"].ToString());
                view.setAmountToBePaid(reader["balanceAmount"].ToString());
            }

            else
            {
                view.setDueDate("");
                view.setAmountToBePaid("0");
            }
            //MessageBox.Show(view.getAmountToBePaid());
            //double totalAmount = ma.getLoanBalance(1) + ma.getPenalty(1);
            decimal totalAmount = Convert.ToDecimal(view.getAmountToBePaid())+ Convert.ToDecimal(view.getPenalty());
            view.setTotalAmount(totalAmount.ToString());
            view.setChange("");
        }

        public void resetAction()
        {
            ModelAmortization ma = new ModelAmortization();
            ma.loanNo = view.getLoanNo();
            view.setCurrentBalance(ma.getLoanBalance(ma.countRemainingAmortization()).ToString());
            view.setPenalty(ma.getPenalty(1).ToString());
            SqlDataReader reader = ma.getNextAmortization();
            if (reader.HasRows)
            {
                reader.Read();
                view.setDueDate(reader["dueDate"].ToString());
                view.setAmountToBePaid(reader["balanceAmount"].ToString());
            }

            else
            {
                view.setDueDate("");
                view.setAmountToBePaid("0");
            }
            view.setTotalAmount((Convert.ToDouble(view.getAmountToBePaid()) + Convert.ToDouble(view.getPenalty())).ToString());
        }

        public bool validateComputeTotal()
        {
            bool check = false;
            if (view.getLoanNo().Length != 0)
            {
                if (Validator.isValidDigit(view.getNoOfPeriod()))
                {
                    check = true;
                }

                else
                {
                    MessageBox.Show("Invalid value in no. of period.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else
            {
                MessageBox.Show("Please select a loan first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return check;
        }

        public bool validateCashPayment()
        {
            bool check = false;

            if (view.getLoanNo().Length != 0)
            {
                if (Validator.isValidAmount(view.getAmountTendered()) && view.getAmountTendered().Length < 15)
                {
                    if (Validator.isValidDigit(view.getNoOfPeriod()))
                    {
                        check = true;
                    }

                    else
                    {
                        check = false;
                        MessageBox.Show("Invalid value in no. of periods.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                else
                {
                    MessageBox.Show("Invalid value in amount tendered.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else
            {
                MessageBox.Show("Please select a loan first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return check;
        }

        //public bool validateSavingsPayment()
        //{
        //    bool check = false;
        //    msa.savingsAccountID = view.getCboSavingsAccount();
        //    msa.searchSavingsAccount();
        //    ModelSavingsType mst = new ModelSavingsType();
        //    mst.savingsTypeID = msa.savingsTypeID;
        //    mst.searchSavingsType();

        //    if (this.validateCashPayment())
        //    {
        //        double remainingBalance = Convert.ToDouble(msa.currentBalance) - Convert.ToDouble(view.getAmountTendered());

        //        if (remainingBalance > 0)
        //        {
        //            check = true;
        //        }

        //        else
        //        {
        //            MessageBox.Show("Insufficient balance in savings account to make loan payment.","Loan Payment",MessageBoxButtons.OK,MessageBoxIcon.Error);
        //        }
        //    }
        //    return check;
        //}

        public void RefreshFields()
        {
            ModelAmortization ma = new ModelAmortization();
            ma.loanNo = view.getLoanNo();
          //***4
            view.setLblNoOfPaymentsMade(((ma.getNoOfAmortization() - ma.countRemainingAmortization()) + "/" + ma.getNoOfAmortization()));
            //***change
            view.setLblRemainingAmount(ma.getLoanBalance(ma.countRemainingAmortization()).ToString());
            view.setLblPenaltyAmount(ma.getLoanPenalty(ma.countRemainingAmortization()).ToString());
            decimal totalAmounUnpaid = ma.getLoanPenalty(ma.countRemainingAmortization()) + ma.getLoanBalance(ma.countRemainingAmortization());
            view.setAmountUnpaid(totalAmounUnpaid.ToString());

            view.setDataGridLoanRecords(model.getLoanRecords());
            view.clearDataGridAmortization();
            view.setAmountToBePaid("");
            view.setPenalty("");
            view.setTotalAmount("");
            view.setAmountTendered("");
            view.setNoOfPeriod("");
            view.setIsChangeAdvance("0");
        }
    }
}
