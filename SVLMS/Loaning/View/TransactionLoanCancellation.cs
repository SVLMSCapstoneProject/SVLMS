using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SVLMS.Loaning;
using SVLMS.Loaning.View;
using SVLMS.Loaning.Model;
using SVLMS.Loaning.Controller;

namespace SVLMS.Loaning.View
{
    public partial class TransactionLoanCancellation : Form
    {
        public event EventHandler cancelLoanClicked;
        public event EventHandler dgClicked;
        public event EventHandler searchPressed;

        public TransactionLoanCancellation()
        {
            InitializeComponent();
            cboSearchBy.SelectedIndex = 0;
        }

        private void dgCancelledLoan_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgClicked != null)
            {
                dgClicked(sender, e);
            }
        }

        public string getSearchBy()
        {
            return cboSearchBy.SelectedItem.ToString();
        }

        public string getTxtSearch()
        {
            return txtSearch.Text;
        }

        public void setLoanNo(string loanNo)
        {
            this.txtLoanNo.Text = loanNo;
        }

        public string getLoanNo()
        {
            return txtLoanNo.Text;
        }

        public void setMemberName(string memberName)
        {
            this.txtMemberName.Text = memberName;
        }

        public string getMemberName()
        {
            return txtMemberName.Text;
        }

        public void setLoanType(string loanType)
        {
            this.txtLoanType.Text = loanType;
        }

        public string getLoanType()
        {
            return txtLoanType.Text;
        }

        public void setApprovedAmount(string approvedAmount)
        {
            if (approvedAmount.Length != 0)
            {
                approvedAmount = Validator.amountFormatter(approvedAmount);
            }
            this.txtApprovedAmount.Text = approvedAmount;
        }

        public string getApprovedAmount()
        {
            return txtApprovedAmount.Text;
        }

        public void setApprovalDate(string date)
        {
            if (date.Length != 0)
            {
                date = Convert.ToDateTime(date).ToShortDateString();
            }
            txtApprovalDate.Text = date;
        }

        public string getApprovalDate()
        {
            return txtApprovalDate.Text;
        }

        public void setReasonCancellation(string reasonCancellation)
        {
            this.txtReasonCancellation.Text = reasonCancellation;
        }

        public string getReasonCancellation()
        {
            return txtReasonCancellation.Text;
        }

        public DataGridView getDataGrid()
        {
            return dgCancelledLoan;
        }

        public void setDataGrid(DataSet ds)
        {
            dgCancelledLoan.DataSource = ds.Tables[0];
        }

        private void btnCancelLoan_Click(object sender, EventArgs e)
        {
            if (cancelLoanClicked != null)
            {
                cancelLoanClicked(sender, e);
            }
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
