using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SVLMS.Savings.View
{
    public partial class TransactionMembershipTermination : Form
    {
        public TransactionMembershipTermination()
        {
            InitializeComponent();
            cboSearchBy.SelectedIndex = 0;
            cboReason.SelectedIndex = 0;
            cboOperation.SelectedIndex = 0;
        }

        public void setDataGrid(DataSet ds)
        {
            dgMembers.DataSource = ds.Tables[0];
        }

        public void setAccountNo(string text)
        {
            txtAccountNo.Text = text;
        }

        public void setMemberName(string text)
        {
            txtMemberName.Text = text;
        }

        public void setMembershipDate(string text)
        {
            txtMembershipDate.Text = text;
        }

        public void setRemarks(string text)
        {
            txtRemarks.Text = text;
        }

        public string getAccountNo()
        {
            return txtAccountNo.Text;
        }



        public string getDateEffective()
        {
            return dtpEffectivityDate.Value.ToString();
        }

        public string getReason()
        {
            return cboReason.SelectedItem.ToString();
        }

        public string getRemarks()
        {
            return txtRemarks.Text; 
        }

        public DataGridView getDataGrid()
        {
            return dgMembers;
        }

        public string getTxtSearch()
        {
            return txtSearch.Text;
        }

        public string getSearchBy()
        {
            return cboSearchBy.SelectedItem.ToString();
        }

        public void setTotalShares(string text)
        {
            if (text.Length != 0)
            {
                text = this.amountFormatter(text);
            }
            txtTotalShares.Text = text;
        }

        public int getOperation()
        {
            return cboOperation.SelectedIndex;
        }

        public string getTotalShares()
        {
            return txtTotalShares.Text;
        }

        public void setTotalSavings(string text)
        {
            if (text.Length != 0)
            {
                text = this.amountFormatter(text);
            }
            txtTotalSavings.Text = text;
        }

        public string getTotalSavings()
        {
            return txtTotalSavings.Text;
        }

        public void setTotalAmount(string text)
        {
            if (text.Length != 0)
            {
                text = this.amountFormatter(text);
            }
            txtTotalAmount.Text = text;
        }

        public string getTotalAmount()
        {
            return txtTotalAmount.Text;
        }

        public void showPanelTermination()
        {
            panelTermination.Visible = true;
            panelCloseAccount.Visible = false;
        }

        public void showPanelCloseAccount()
        {
            panelTermination.Visible = false;
            panelCloseAccount.Visible = true;
        }

        public string amountFormatter(string text)
        {
            double deduction = Convert.ToDouble(text);
            double truncated = Math.Truncate(deduction * 100) / 100;
            text = String.Format("{0:0.00}", truncated);
            return text;
        }

        public void setDataGridSavingsAccounts(DataSet ds)
        {
            dgSavingsAccounts.DataSource = ds.Tables[0];
            dgSavingsAccounts.Columns["AccountNo"].Visible = false;
            dgSavingsAccounts.Columns["MemberName"].Visible = false;
            dgSavingsAccounts.Columns["savingsAccountNo"].Visible = false;
            dgSavingsAccounts.Columns["Current Balance"].DefaultCellStyle.Format = "0.00";
        }

        public void setLoanBalance(string text)
        {
            if (text.Length != 0)
            {
                text = this.amountFormatter(text);
            }
            txtLoanBalance.Text = text;
        }

        public string getLoanBalance()
        {
            return txtLoanBalance.Text;
        }

        public void setBtnTerminateEvent(EventHandler e)
        {
            btnTerminate.Click += e;
        }

        public void setBtnCloseAccount(EventHandler e)
        {
            btnCloseAccount.Click += e;
        }

        public void setTextSearchEvent(EventHandler e)
        {
            txtSearch.TextChanged += e;
        }

        public void setDataGridEvent(DataGridViewCellEventHandler e)
        {
            dgMembers.CellDoubleClick += e;
        }
                
        public void setCboOperationEvent(EventHandler e)
        {
            cboOperation.SelectionChangeCommitted += e;
        }

        public void setLblTerminationMembership(string text)
        {
            lblTerminationMembership.Text = text;
        }

        private void TransactionMembershipTermination_Load(object sender, EventArgs e)
        {

        }
    }
}
