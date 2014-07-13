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
    public partial class TransactionUnfreezeAccount : Form
    {

        public event EventHandler dgClicked;
        public event EventHandler cboChanged;
        public event EventHandler unfreezeClicked;

        public TransactionUnfreezeAccount()
        {
            InitializeComponent();
        }

        public void setAccountNo(string text)
        {
            txtAccountNo.Text = text;
        }

        public void setMemberName(string text)
        {
            txtMemberName.Text = text;
        }

        public void setAmount(string text)
        {
            txtAmount.Text = text;
        }

        public void setSavingsAccount(string text)
        {
            txtSavingsAccount.Text = text;
        }

        public void setCurrentBalance(string text)
        {
            txtCurrentBalance.Text = text;
        }

        public void setLastTransaction(string text)
        {
            txtLastTransaction.Text = text;
        }

        public string getAccountNo()
        {
            return txtAccountNo.Text;
        }

        public string getMemberName()
        {
            return txtMemberName.Text;
        }

        public string getAmount()
        {
            return txtAmount.Text;
        }

        public void setDataGrid(DataSet ds)
        {
            dgDormantAccounts.DataSource = ds.Tables[0];
        }

        public DataGridView getDataGrid()
        {
            return dgDormantAccounts;
        }

        private void dgDormantAccounts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgClicked != null)
            {
                dgClicked(sender,e);
            }
        }

        private void cboSearchBy_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cboChanged != null)
            {
                cboChanged(sender,e);
            }
        }

        private void btnUnfreezeAccount_Click(object sender, EventArgs e)
        {
            if (unfreezeClicked != null)
            {
                unfreezeClicked(sender,e);
            }
        }

        private void txtMemberName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSavingsAccount_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCurrentBalance_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLastTransaction_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
