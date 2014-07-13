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
    public partial class TransactionCreateSavingsAccountView : Form
    {
        public TransactionCreateSavingsAccountView()
        {
            InitializeComponent();
            cboSearchBy.SelectedIndex = 0;
        }

        public void setAccountNo(string text)
        {
            txtAccountNo.Text = text;
        }

        public void setMemberName(string text)
        {
            txtMemberName.Text = text;
        }

        public void setAccountHolder(string text)
        {
            txtAccountHolder.Text = text;
        }

        public void setInitialDeposit(string text)
        {
            txtInitialDeposit.Text = text;
        }

        public void setDataGrid(DataSet ds)
        {
            dgMembers.DataSource = ds.Tables[0];
            dgMembers.Columns[2].Visible = false;
        }

        public void setCboSavingsType(DataSet ds)
        {
            if (ds != null)
            {
                cboSavingsType.DisplayMember = "savingsName";
                cboSavingsType.ValueMember = "savingsTypeID";
                cboSavingsType.DataSource = ds.Tables[0];
            }
        }

        public DataRowView getCboSavingsType()
        {
            return (cboSavingsType.SelectedItem as DataRowView);
        }

        public DataGridView getDataGrid()
        {
            return dgMembers;
        }

        public string getSearchValue()
        {
            return txtSearch.Text;
        }

        public string getCboSearchBy()
	    {
            return cboSearchBy.SelectedItem.ToString();
	    }
        
        public string getAccountNo()
	    {
            return txtAccountNo.Text;
	    }

        public string getMemberName()
	    {
            return txtMemberName.Text;
	    }

        public string getInitialDeposit()
	    {
            return txtInitialDeposit.Text;
	    }

        public string getAccountHolder()
	    {
            return txtAccountHolder.Text;
	    }

        public void enableAccountHolder()
        {
            btnPlus.Enabled = true;
            btnAddAccountHolder.Enabled = true;
            btnPlus.Enabled = true;
            btnUploadJoint.Enabled = true;
            btnUploadJoint2.Enabled = true;
            //btnRemoveAccountHolder.Enabled = true;
            btnAddAccountHolder.Enabled = true;
        }

        public void disableAccountHolder()
        {
            btnPlus.Enabled = false;
            btnAddAccountHolder.Enabled = false;
            //btnRemoveAccountHolder.Enabled = false;
            btnUpdateAccountHolder.Enabled = false;
            btnPlus.Enabled = false;
            btnUploadJoint.Enabled = false;
            btnUploadJoint2.Enabled = false;
            txtAccountHolder.Text = "";
        }

        public void enableUploadJoint()
        {
            btnUploadJoint.Enabled = true;
            btnUploadJoint2.Enabled = true;
        }

        public void disableUploadJoint()
        {
            btnUploadJoint.Enabled = false;
            btnUploadJoint2.Enabled = false;
        }
        public void clearCboSavingsType()
        {
            cboSavingsType.Items.Clear();
        }

        public void setPrimaryAccountHolder(string text)
        {
            txtPrimaryHolder.Text = text;
        }

        public string getPrimaryAccountHolder()
        {
            return txtPrimaryHolder.Text;
        }

        public void setDatagridAccountHolders(DataSet ds, string isFamily)
        {
            dgAccountHolders.DataSource = ds.Tables[0];
            dgAccountHolders.Columns[0].Visible = false;
            if (isFamily == "0")
            {
                dgAccountHolders.Columns[3].Visible = false;
            }
            dgAccountHolders.ClearSelection();
        }

        public DataGridView getDatagridAccountHolders()
        {
            return dgAccountHolders;
        }

        public void dgAccountHoldersClickedEvent(DataGridViewCellEventHandler e)
        {
            dgAccountHolders.CellDoubleClick += e;
        }

        public void setBtnAddAccountHolderEvent(EventHandler e)
        {
            btnAddAccountHolder.Click += e;
        }

        //public void setBtnRemoveAccountHolderEvent(EventHandler e)
        //{
        //    btnRemoveAccountHolder.Click += e;
        //}

        public void setCboSavingsJointSelectedIndex(EventHandler e)
        {
            cboSavingsJoint.SelectionChangeCommitted += e;
        }

        public void clearCboJoint()
        {
            cboSavingsJoint.DataBindings.Clear();
        }

        public void setCboSavingsJoint(DataSet ds)
        {            
            cboSavingsJoint.DataSource = ds.Tables[0];
            cboSavingsJoint.ValueMember = "savingsAccountNo";
            cboSavingsJoint.DisplayMember = "Savings Name";
        }

        public string getCboSavingsJoint()
        {
            string savingsAccountNo = "";
            if (cboSavingsJoint.SelectedValue != null)
            {
                savingsAccountNo = cboSavingsJoint.SelectedValue.ToString();
            }

            return savingsAccountNo;
        }

        public void setSavingsAccountNo(string text)
        {
            txtSavingsAccountNo.Text = text;
        }

        public string getSavingsAccountNo()
        {
            return txtSavingsAccountNo.Text;
        }

        public void setSavingsAccountNoJoint(string text)
        {
            txtSavingsAccountNoJoint.Text = text;
        }

        public string getSavingsAccountNoJoint()
        {
            return txtSavingsAccountNoJoint.Text;
        }

        public void setRbtnMemberClick(EventHandler e)
        {
            rbtnMember.Click += e;
        }

        public void setRbtnFamilyClick(EventHandler e)
        {
            rbtnFamily.Click += e;
        }

        public void clearDataGridJoint()
        {
            dgAccountHolders.DataSource = null;
        }

        public void setIsMemberRbtn(string text)
        {
            if (text == "1")
            {
                rbtnMember.Checked = true;
            }

            else
            {
                rbtnFamily.Checked = true;
            }
        }

        public void enableBtnAddAccountHolder()
        {
            btnAddAccountHolder.Enabled = true;
        }

        public void disableBtnAddAccountHolder()
        {
            btnAddAccountHolder.Enabled = false;
        }

        //public void enableBtnRemoveAccountHolder()
        //{
        //    btnRemoveAccountHolder.Enabled = true;
        //}

        //public void disableBtnRemoveAccountHolder()
        //{
        //    btnRemoveAccountHolder.Enabled = false;
        //}

        public string getIsFamily()
        {
            string isFamily = "";
            if (rbtnFamily.Checked)
            {
                isFamily = "1";
            }

            else
            {
                isFamily = "0";
            }
            return isFamily;
        }

        public void setBtnClearEvent(EventHandler e)
        {
            btnClear.Click += e;
        }

        public void disablePlusButton()
        {
            btnPlus.Enabled = false;
        }

        public void enablePlusButton()
        {
            btnPlus.Enabled = true;
        }

        public void setBtnUploadJointEvent(EventHandler e)
        {
            btnUploadJoint.Click += e;
        }

        public void setSignatureImageJoint(string imagePath, string tag)
        {
            pictureSignatureJoint.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureSignatureJoint.ImageLocation = imagePath;
            pictureSignatureJoint.Tag = tag;
        }

        public PictureBox getSignatureImageJoint()
        {
            return pictureSignatureJoint;
        }

        public void setSignatureImageJoint2(string imagePath, string tag)
        {
            pictureSignatureJoint2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureSignatureJoint2.ImageLocation = imagePath;
            pictureSignatureJoint2.Tag = tag;
        }

        public PictureBox getSignatureImageJoint2()
        {
            return pictureSignatureJoint2;
        }

        public void setBtnUploadJoint2Event(EventHandler e)
        {
            btnUploadJoint2.Click += e;
        }

        public void enableBtnUpdate()
        {
            btnUpdateAccountHolder.Enabled = true;
        }

        public void disableBtnUpdate()
        {
            btnUpdateAccountHolder.Enabled = false;
        }

        public void setBtnUpdateAccountHolderEvent(EventHandler e)
        {
            btnUpdateAccountHolder.Click += e;
        }

        public void setBtnOpenAccountEvent(EventHandler e)
        {
            btnOpenAccount.Click += e;
        }

        public void setBtnPlusEvent(EventHandler e)
        {
            btnPlus.Click += e;
        }

        public void setDataGridEvent(DataGridViewCellEventHandler e)
        {
            dgMembers.CellDoubleClick += e;
        }

        public void setCboSavingsChange(EventHandler e)
        {
            cboSavingsType.SelectedIndexChanged += e;
        }

        public void setTextSearchChange(EventHandler e)
        {
            txtSearch.TextChanged += e;
        }
    }
}
