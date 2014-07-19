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
    public partial class TransactionLoanReleaseView : Form
    {
        public TransactionLoanReleaseView()
        {
            InitializeComponent();
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

        public string getSearchBy()
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

        public void setApprovedAmount(string text)
        {
            if (text.Length != 0)
            {
                text = this.amountFormatter(text);
            }
            txtApprovedAmount.Text = text;
        }

        public string getApprovedAmount()
        {
            return txtApprovedAmount.Text;
        }

        public void setApprovalDate(string text)
        {
            if (text.Length != 0)
            {
                text = Convert.ToDateTime(text).ToShortDateString();
            }
            txtApprovalDate.Text = text;
        }

        public string getApprovalDate()
        {
            return txtApprovalDate.Text;
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

        public void setCheckNo(string text)
        {
            txtCheckNo.Text = text;
        }

        public string getCheckNo()
        {
            return txtCheckNo.Text;
        }

        public void setBankName(string text)
        {
            txtBankName.Text = text;
        }

        public string getBankName()
        {
            return txtBankName.Text;
        }

        public string getDateIssued()
        {
            return dtpDateIssued.Value.ToString();
        }

        public void setApprovedAmountRelease(string text)
        {
            if (text.Length != 0)
            {
                text = this.amountFormatter(text);
            }
            txtApprovedRelease.Text = text;
        }

        public string getApprovedAmountRelease()
        {
            return txtApprovedRelease.Text;
        }

        public void setNetAmount(string text)
        {
            if (text.Length != 0)
            {
                text = this.amountFormatter(text);
            }
            txtNetAmount.Text = text;
        }

        public string getNetAmount()
        {
            return txtNetAmount.Text;
        }

        public void setReleaseType(string text)
        {
            if (text == "C")
            {
                rbtnCash.Checked = true;
            }

            if (text == "CH")
            {
                rbtnCheck.Checked = true;
            }
        }

        public string getReleaseType()
        {
            string isCheck = "";
            if (rbtnCash.Checked)
            {
                isCheck = "C";
            }

            else if (rbtnCheck.Checked)
            {
                isCheck = "CH";
            }
            return isCheck;
        }

        public void setDataGridCharges(DataSet ds)
        {
            dgCharges.DataSource = ds.Tables[0];
            dgCharges.Columns["Amount"].DefaultCellStyle.Format = "0.00";
        }

        public DataGridView getDataGridCharges()
        {
            return dgCharges;
        }

        public void setDataGridApprovedLoans(DataSet ds)
        {
            dgApprovedLoans.DataSource = ds.Tables[0];
            dgApprovedLoans.Columns["Requested Amount"].Visible = false;
            dgApprovedLoans.Columns["Approved Amount"].DefaultCellStyle.Format = "0.00";
        }

        public DataGridView getDataGridApprovedLoans()
        {
            return dgApprovedLoans;
        }

        public void setBtnReleaseEvent(EventHandler e)
        {
            btnRelease.Click += e;
        }

        public void setDataGridApprovedLoansEvent(DataGridViewCellEventHandler e)
        {
            dgApprovedLoans.CellDoubleClick += e;
        }

        public void setRbtnCheckEvent(EventHandler e)
        {
            rbtnCheck.Click += e;
        }

        public void setRbtnCashEvent(EventHandler e)
        {
            rbtnCash.Click += e;
        }

        public void enableCheckInformation()
        {
            txtCheckNo.Enabled = true;
            txtBankName.Enabled = true;
            dtpDateIssued.Enabled = true;
        }

        public void disableCheckInformation()
        {
            txtCheckNo.Enabled = false;
            txtBankName.Enabled = false;
            dtpDateIssued.Enabled = false;
        }

        public void enableBtnRelease()
        {
            btnRelease.Enabled = true;
        }

        public void disableBtnRelease()
        {
            btnRelease.Enabled = false;
        }

        public void enablePrintVoucher()
        {
            btnPrintVoucher.Enabled = true;
        }

        public void disablePrintVoucher()
        {
            btnPrintVoucher.Enabled = false;
        }

        public void clearRadioButton()
        {
            rbtnCheck.Checked = false;
            rbtnCash.Checked = false;
        }

        public void clearDataGrid()
        {
            dgCharges.DataSource = null;
            dgCharges.DataBindings.Clear();
            dgCharges.Refresh();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
           if(searchPressed != null)
           {
               searchPressed(sender, e);
           }
        }
    }
}
