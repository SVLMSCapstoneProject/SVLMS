using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SVLMS.Loaning.View
{
    public partial class TransactionLoanModificationView : Form
    {
        public TransactionLoanModificationView()
        {
            InitializeComponent();
            cboPaymentInterval.SelectedIndex = 0;
            cboSearchBy.SelectedIndex = 0;
        }

        public event EventHandler searchPressed;

        public string amountFormatter(string text)
        {
            double deduction = Convert.ToDouble(text);
            double truncated = Math.Truncate(deduction * 100) / 100;
            text = String.Format("{0:0.00}", truncated);
            return text;
        }

        public void setDataGridLoanRecords(DataSet ds)
        {
            dgLoanRecords.DataSource = ds.Tables[0];
            dgLoanRecords.Columns["Approved Amount"].DefaultCellStyle.Format = "#,##0.00";
        }

        public DataGridView getDataGridLoanRecords()
        {
            return dgLoanRecords;
        }

        public string getSearchBy()
        {
            return cboSearchBy.SelectedItem.ToString();
        }

        public string getTxtSearch()
        {
            return txtSearch.Text;
        }

        public void setMemberName(string text)
        {
            txtMemberName.Text = text;
        }

        public string getMemberName()
        {
            return txtMemberName.Text;
        }

        public void setLoanNo(string text)
        {
            txtLoanNo.Text = text;
        }

        public string getLoanNo()
        {
            return txtLoanNo.Text;
        }

        public void setPenalty(string text)
        {
            if (text.Length != 0)
            {
                text = this.amountFormatter(text);
            }
            txtPenalty.Text = text;
        }

        public string getPenalty()
        {
            return txtPenalty.Text;
        }

        public void setRemainingPrincipal(string text)
        {
            if (text.Length != 0)
            {
                text = this.amountFormatter(text);
            }
            txtRemainingPrincipal.Text = text;
        }

        public string getRemainingPrincipal()
        {
            return txtRemainingPrincipal.Text;
        }

        public void setInterestRate(string text)
        {
            if (text.Length != 0)
            {
                text = this.amountFormatter(text);
            }
            txtInterest.Text = text;
        }

        public string getInterestRate()
        {
            return txtInterest.Text;
        }

        public void setIsPercentageInterest(string text)
        {
            if (text == "0")
            {
                rbtnInterestFixed.Checked = true;
            }

            else if (text == "1")
            {
                rbtnInterestPercentage.Checked = true;
            }

            else
            {
                rbtnInterestPercentage.Checked = false;
                rbtnInterestFixed.Checked = false;
            }
        }

        public string getIsPercentageInterest()
        {
            string text = "";
            if (rbtnInterestPercentage.Checked)
            {
                text = "1";
            }

            else
            {
                text = "0";
            }
            return text;
        }

        //public void setIsPercentageSavings(string text)
        //{
        //    if (text == "0")
        //    {
        //        rbtnSavingsFixed.Checked = true;
        //    }

        //    else if (text == "1")
        //    {
        //        rbtnSavingsPercentage.Checked = true;
        //    }

        //    else
        //    {
        //        rbtnSavingsFixed.Checked = false;
        //        rbtnSavingsPercentage.Checked = false;
        //    }
        //}

        //public string getIsPercentageSavings()
        //{
        //    string text = "";
        //    if (rbtnSavingsPercentage.Checked)
        //    {
        //        text = "1";
        //    }

        //    else
        //    {
        //        text = "0";
        //    }
        //    return text;
        //}

        public void setIsPercentageShare(string text)
        {
            if (text == "0")
            {
                rbtnShareFixed.Checked = true;
            }

            else if (text == "1")
            {
                rbtnSharePercentage.Checked = true;
            }

            else 
            {
                rbtnSharePercentage.Checked = false;
                rbtnShareFixed.Checked = false;
            }
        }

        public string getIsPercentageShare()
        {
            string text = "";
            if (rbtnSharePercentage.Checked)
            {
                text = "1";
            }

            else
            {
                text = "0";
            }
            return text;
        }

        public void setPaymentInterval(string text)
        {
            cboPaymentInterval.SelectedItem = text;
        }

        public string getPaymentInterval()
        {
            //return cboPaymentInterval.SelectedItem.ToString();
            string paymentIntervalDays = "0";
            if (cboPaymentInterval.SelectedIndex == 0)
            {
                paymentIntervalDays = "1";
            }

            if (cboPaymentInterval.SelectedIndex == 1)
            {
                paymentIntervalDays = "7";
            }

            if (cboPaymentInterval.SelectedIndex == 2)
            {
                paymentIntervalDays = "30";
            }
            return paymentIntervalDays;
        }

        public string getPaymentIntervalIndex()
        {
            return (cboPaymentInterval.SelectedIndex + 1).ToString();
        }

        public void setTermsOfPayment(string text)
        {
            txtTermsOfPayment.Text = text;
        }

        public string getTermsOfPayment()
        {
            return txtTermsOfPayment.Text;
        }

        public void setLoanAmount(string text)
        {
            if (text.Length != 0)
            {
                text = this.amountFormatter(text);
            }
            txtLoanAmount.Text = text;
        }

        public string getLoanAmount()
        {
            return txtLoanAmount.Text;
        }

        public string getIncludePenalty()
        {
            string text = "";
            if (chkIncludePenalty.Checked)
            {
                text = "1";
            }

            else
            {
                text = "0";
            }
            return text;
        }

        public void setIncludePenalty(string text)
        {
            if (text == "1")
            {
                chkIncludePenalty.Checked = true;
            }

            else
            {
                chkIncludePenalty.Checked = false;
            }
        }

        public void setBtnSaveEvent(EventHandler e)
        {
            btnSaveModification.Click += e;
        }

        public void setBtnComputeAmortizationEvent(EventHandler e)
        {
            btnComputeAmortization.Click += e;
        }

        public void setDataGridLoanRecordsEvent(DataGridViewCellEventHandler e)
        {
            dgLoanRecords.CellDoubleClick += e;
        }

        //public void setSavingsRate(string text)
        //{
        //    if (text.Length != 0)
        //    {
        //        text = this.amountFormatter(text);
        //    }
        //    txtSavingsRate.Text = text;
        //}

        public void setShareRate(string text)
        {
            if (text.Length != 0)
            {
                text = this.amountFormatter(text);
            }
            txtShareCapitalRates.Text = text;
        }

        public void clearRadioButton()
        {
            rbtnInterestFixed.Checked = false;
            rbtnInterestPercentage.Checked = false;
            chkIncludePenalty.Checked = false;
            //rbtnSavingsFixed.Checked = false;
            //rbtnSavingsPercentage.Checked = false;
            rbtnShareFixed.Checked = false;
            rbtnSharePercentage.Checked = false;
        }

        public void setTotalBalance(string text)
        {
            if (text.Length != 0)
            {
                text = this.amountFormatter(text);
            }

            txtTotalBalance.Text = text;
        }

        public string getTotalBalance()
        {
            return txtTotalBalance.Text;
        }

        //public string getSavingsRate()
        //{
        //    return txtSavingsRate.Text;
        //}

        public string getShareCapitalRate()
        {
            return txtShareCapitalRates.Text;
        }

        public void setDataGridAmortization(string[,] array)
        {
            dgLoanAmortization.Columns.Clear();
            dgLoanAmortization.Rows.Clear();
            dgLoanAmortization.Refresh();


            int length = array.GetLength(0);
            dgLoanAmortization.Columns.Add("DueDate", "Due Date");
            dgLoanAmortization.Columns.Add("Principal","Principal");
            dgLoanAmortization.Columns.Add("Interest","Interest");
            //dgLoanAmortization.Columns.Add("Savings","Savings");
            dgLoanAmortization.Columns.Add("ShareCapital","Share Capital");
            dgLoanAmortization.Columns.Add("Amortization", "Amortization");
            
            for (int x = 0; x < length; x++)
            {
                dgLoanAmortization.Rows.Add(array[x, 0], this.amountFormatter(array[x, 1]), this.amountFormatter(array[x, 2]), this.amountFormatter(array[x, 3]), this.amountFormatter(array[x, 4]));
            }

            dgLoanAmortization.Columns["Principal"].Visible = false;
            dgLoanAmortization.Columns["Interest"].Visible = false;
            dgLoanAmortization.Columns["ShareCapital"].Visible = false;
        }

        public void increaseTabIndex()
        {
            tabLoan.SelectedIndex = tabLoan.SelectedIndex + 1;
        }

        public void clearDataGridAmortization()
        {
            dgLoanAmortization.Columns.Clear();
            dgLoanAmortization.Rows.Clear();
            dgLoanAmortization.Refresh();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (searchPressed != null)
            {
                searchPressed(sender, e);
            }
        }

        public void setLblLoanAmount(string text)
        {
            try
            {
                double amount = Convert.ToDouble(text);
                text = Validator.amountFormatter(text);
            }
            catch (Exception)
            {

            }
            lblLoanAmount.Text = text;
        }

        //public void setLblSavings(string text)
        //{
        //    try
        //    {
        //        double amount = Convert.ToDouble(text);
        //        text = Validator.amountFormatter(text);
        //    }
        //    catch (Exception)
        //    {

        //    }
        //    lblSavings.Text = text;
        //}

        public void setLblShareCapital(string text)
        {
            try
            {
                double amount = Convert.ToDouble(text);
                text = Validator.amountFormatter(text);
            }
            catch (Exception)
            {

            }
            lblShareCapital.Text = text;
        }

        public void setLblTotalInterest(string text)
        {
            try
            {
                double amount = Convert.ToDouble(text);
                text = Validator.amountFormatter(text);
            }
            catch (Exception)
            {

            }
            lblTotalInterest.Text = text;
        }

        public void setLblTotalAmount(string text)
        {
            try
            {
                double amount = Convert.ToDouble(text);
                text = Validator.amountFormatter(text);
            }
            catch (Exception)
            {

            }
            lblTotalAmount.Text = text;
        }
    }
}
