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
    public partial class TransactionLoanApprovalView : Form
    {
        public TransactionLoanApprovalView()
        {
            InitializeComponent();
            cboSearchBy.SelectedIndex = 0;
        }

        public event EventHandler searchPressed;

        public  string getSearchBy()
        {
            return cboSearchBy.SelectedItem.ToString();
        }

        public string getTxtSearch()
        {
            return txtSearch.Text;
        }
        
        public void setLoanNo(string text)
        {
            txtLoanNo.Text = text;
        }

        public string getLoanNo()
        {
            return txtLoanNo.Text;
        }

        public void setMemberName(string text)
        {
            txtMemberName.Text = text;
        }

        public string getMemberName()
        {
            return txtMemberName.Text;
        }

        public void setRequestedAmount(string text)
        {
            if (text.Length != 0)
            {
                text = this.amountFormatter(text);
            }
            txtRequestedAmount.Text = text;
        }

        public string getRequestedAmount()
        {
            return txtRequestedAmount.Text;
        }

        public void setDateApplied(string text)
        {
            txtDateApplied.Text = text;
        }

        public string getDateApplied()
        {
            return txtDateApplied.Text;
        }

        public void setCollateral(string text)
        {
            txtCollateral.Text = text;
        }

        public string getCollateral()
        {
            return txtCollateral.Text;
        }

        public void setTermsOfPayment(string text)
        {
            txtTermsOfPayment.Text = text;
        }

        public string getTermsOfPayment()
        {
            return txtTermsOfPayment.Text;
        }

        public string amountFormatter(string text)
        {
            double deduction = Convert.ToDouble(text);
            double truncated = Math.Truncate(deduction * 100) / 100;
            text = String.Format("{0:0.00}", truncated);
            return text;
        }

        public void setBtnComputeAmortEvent(EventHandler e)
        {
            btnCompute.Click += e;
        }

        public void setBtnApproveEvent(EventHandler e)
        {
            btnApprove.Click += e;
        }

        public void setBtnRejectEvent(EventHandler e)
        {
            btnReject.Click += e;
        }

        public void disableAmortization()
        {
            //((Control)tabPageAmortization).Enabled = false;
            panelAmortization.Visible = false;
        }

        public void enableAmortization()
        {
            panelAmortization.Visible = true;
        }

        public void setDataGridLoanApplications(DataSet ds)
        {
            dgLoanApplications.DataSource = ds.Tables[0];
            dgLoanApplications.Columns["Amount"].DefaultCellStyle.Format = "0.00";
        }

        public DataGridView getDataGridLoanApplications()
        {
            return dgLoanApplications;
        }

        public void setDataGridLoanApplicationsEvent(DataGridViewCellEventHandler e)
        {
            dgLoanApplications.CellDoubleClick += e;
        }

        public void setApprovedAmount(string text)
        {
            if (text.Length != 0)
            {
                text = this.amountFormatter(text);
            }
            txtApprovedAmount.Text = text;
        }

        public void setDataGridAmortization(string[,] array)
        {
            dgLoanAmortization.Columns.Clear();
            dgLoanAmortization.Rows.Clear();
            dgLoanAmortization.Refresh();


            int length = array.GetLength(0);
            dgLoanAmortization.Columns.Add("DueDate","Due Date");
            //dgLoanAmortization.Columns.Add("Principal","Principal");
            //dgLoanAmortization.Columns.Add("Interest","Interest");
            //dgLoanAmortization.Columns.Add("Savings","Savings");
            //dgLoanAmortization.Columns.Add("ShareCapital","Share Capital");
            dgLoanAmortization.Columns.Add("Amortization","Amortization");

            for (int x = 0; x < length; x++ )
            {
                //dgLoanAmortization.Rows.Add(array[x, 0],array[x, 1], array[x, 2], array[x, 3], array[x, 4], array[x, 5]);
                dgLoanAmortization.Rows.Add(array[x, 0], this.amountFormatter(array[x, 4]));
            }
        }

        public void setRemarks(string text)
        {
            txtRemarks.Text = text;
        }

        public string getRemarks()
        {
            return txtRemarks.Text;
        }

        public string getApprovedAmount()
        {
            return txtApprovedAmount.Text;
        }

        public void setPaymentInterval(string text)
        {
            txtPaymentInterval.Text = text;
        }

        public string getPaymentInterval()
        {
            return txtPaymentInterval.Text;
        }

        //public void setlblTotalSavings(double totalSavings)
        //{
        //    lblSavings.Text = this.amountFormatter(totalSavings.ToString());
        //}

        public void setlblTotalShares(double totalShares)
        {
            lblShareCapital.Text = this.amountFormatter(totalShares.ToString());
        }

        public void setlblTotalInterest(double totalInterest)
        {
            lblTotalInterest.Text = this.amountFormatter(totalInterest.ToString());
        }

        public void setlblTotalAmount(double totalAmount)
        {
            lblTotalAmount.Text = this.amountFormatter(totalAmount.ToString());
        }

        public void setlblLoanAmount(double loanAmount)
        {
            lblLoanAmount.Text = this.amountFormatter(loanAmount.ToString());
        }

        public void increaseTabIndex()
        {
            tabControl1.SelectedIndex = tabControl1.SelectedIndex + 1;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (searchPressed != null)
            {
                searchPressed(sender, e);
            }
        }
    }
}
