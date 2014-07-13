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
    public partial class TransactionCreateTimeDeposit : Form
    {
        public TransactionCreateTimeDeposit()
        {
            InitializeComponent();
            dgMembers.ReadOnly = true;
            dgMembers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            txtAccountNo.ReadOnly = true;
            txtMemberName.ReadOnly = true;
            txtTimeDepositNo.ReadOnly = true;
            cboSearch.SelectedIndex = 0;
            cboMaturityInstruction.SelectedIndex = 0;
        }

        //SET VALUES TO VIEW -----------------------------  >
        public void setAccountNo(string text)
        {
            this.txtAccountNo.Text = text;
        }

        public void setMemberName(string text)
        {
            this.txtMemberName.Text = text;
        }

        public void setTimeDepositNo(string text)
        {
            this.txtTimeDepositNo.Text = text;
        }

        public void setInitialDeposit(string text)
        {
            this.txtInitialDeposit.Text = text;
        }

        public void setTxtInitialDepositEvent(EventHandler e)
        {
            txtInitialDeposit.TextChanged += e;
        }

        public void setCboDaysEvent(EventHandler e)
        {
            cboTerm.SelectedIndexChanged += e;
        }

        //public void setTerm(string text)
        //{
        //    txtTerm
        //}

        public void setDgMembers(DataSet ds)
        {
            dgMembers.DataSource = ds.Tables[0];
            
        }

        public void setCboTerm(DataSet ds)
        {
            if (ds != null)
            {
                cboTerm.DisplayMember = "daysDisplay";
                cboTerm.ValueMember = "daysNo";
                cboTerm.DataSource = ds.Tables[0];
            }
        }

        public string getCboTerm()
        {
            return cboTerm.SelectedValue.ToString();
        }

        // GET VALUES ---------------------- > 
        public string getSearchBy()
        {
            return cboSearch.SelectedItem.ToString();
        }

        public string getTxtSearch()
        {
            return txtSearch.Text;
        }
            
        public string getAccountNo()
        {
            return txtAccountNo.Text;
        }

        public string getMemberName()
        {
            return txtMemberName.Text;
        }

        public string getTimeDepositNo()
        {
            return txtTimeDepositNo.Text;
        }

        public string getInitialDeposit()
        {
            return txtInitialDeposit.Text;
        }

        public DataGridView getdgMembers()
        {
            return dgMembers;
        }

        public void setDatagridEvent(DataGridViewCellEventHandler e)
        {
            dgMembers.CellDoubleClick += e;
        }

        public void setOpenAccountEvent(EventHandler e)
        {
            btnAddDeposit.Click += e;
        }

        public void setTextSearchEvent(EventHandler e)
        {
            txtSearch.TextChanged += e;
        }

        //public void setCboDepositTypeEvent(EventHandler e)
        //{
        //    cboDepositType.SelectionChangeCommitted += e;
        //}

        public void setCboMaturityInstructionsEvent(EventHandler e)
        {
            cboMaturityInstruction.SelectionChangeCommitted += e;
        }

        public int getCboMaturityInstruction()
        {
            return cboMaturityInstruction.SelectedIndex;
        }

        //public int getCboDepositType()
        //{
        //    return cboDepositType.SelectedIndex;
        //}

        //public void enableCboSavings()
        //{
        //    cboSavingsAccount.Enabled = true;
        //}

        //public void disableCboSavings()
        //{
        //    cboSavingsAccount.Enabled = false;
        //    cboSavingsAccount.DataSource = null;
        //}

        public void enableCboSavingsTransfer()
        {
            cboSavingsAccountTransfer.Enabled = true;
        }

        public void disableCboSavingsTransfer()
        {
            cboSavingsAccountTransfer.Enabled = false;
            cboSavingsAccountTransfer.DataSource = null;
        }

        //public void setCboSavings(DataSet ds)
        //{
        //    cboSavingsAccount.DisplayMember = "Savings Name";
        //    cboSavingsAccount.ValueMember = "savingsAccountNo";
        //    cboSavingsAccount.DataSource = ds.Tables[0];
        //}

        public void setCboSavingsTransfer(DataSet ds)
        {
            cboSavingsAccountTransfer.DisplayMember = "Savings Name";
            cboSavingsAccountTransfer.ValueMember = "savingsAccountNo";
            cboSavingsAccountTransfer.DataSource = ds.Tables[0];
        }

        //public string getCboSavings()
        //{
        //    string savingsAccountNo = "";
        //    if (cboSavingsAccount.DataSource != null)
        //    {
        //        savingsAccountNo = cboSavingsAccount.SelectedValue.ToString();
        //    }
        //    return savingsAccountNo;
        //}

        public void setDataGridRates(DataSet ds)
        {
            dgRates.DataSource = ds.Tables[0];
            dgRates.Columns["From"].DefaultCellStyle.Format = "#,##0.00";
            dgRates.Columns["To"].DefaultCellStyle.Format = "#,##0.00";
            dgRates.Columns["Interest"].DefaultCellStyle.Format = "0.00";
        }

        public string getCboSavingsTransfer()
        {
            string savingsAccountNo = "";
            if (cboSavingsAccountTransfer.SelectedValue != null)
            {
                savingsAccountNo = cboSavingsAccountTransfer.SelectedValue.ToString();
            }
            return savingsAccountNo;
        }

        public void refreshCombobox()
        {
            //cboDepositType.SelectedIndex = 0;
            cboMaturityInstruction.SelectedIndex = 0;
        }
    }
}
