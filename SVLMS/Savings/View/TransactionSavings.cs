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
    public partial class TransactionSavings : Form
    {
        public TransactionSavings()
        {
            InitializeComponent();
            cboTransactionType.SelectedIndex = 0;
            cboSearchBy.SelectedIndex = 0;
            dgAccountHolders.ClearSelection();
            cboSearchBy.SelectedIndex = 0;
            //cboReleaseType.SelectedIndex = 0;
        }

        public void setAccountNo(string text)
        {
            txtSavingsAccountNo.Text = text;
        }

        public void setMemberName(string text)
        {
            txtMemberName.Text = text;
        }

        public void setCurrentBalance(string text)
        {
            if (text.Length != 0)
            {
                text = this.amountFormatter(text);
            }
            txtCurrentBalance.Text = text;
        }

        public string getCurrentBalance()
        {
            return txtCurrentBalance.Text;
        }

        public void setDataGrid(DataSet ds)
        {
            dgSavingsAccount.DataSource = ds.Tables[0];
            dgSavingsAccount.Columns["Balance"].DefaultCellStyle.Format = "0.00";
        }

        public void setAmountSavings(string text)
        {
            if (text.Length != 0)
            {
                text = this.amountFormatter(text);
            }
            txtAmount.Text = text;
        }

        public string getAmountSavings()
        {
            return txtAmount.Text;
        }

        public DataGridView getDataGrid()
        {
            return dgSavingsAccount;
        }

        public string getSavingsAccountNo()
        {
            return txtSavingsAccountNo.Text;
        }

        public string getMemberName()
        {
            return txtMemberName.Text;
        }

        public string getTransactionType()
        {
            return cboTransactionType.SelectedItem.ToString()[0].ToString();
        }

        public string getSearchBy()
        {
            return cboSearchBy.SelectedItem.ToString();
        }

        public string getSearchByIndex()
        {
            return cboSearchBy.SelectedIndex.ToString();
        }

        public string getSearchBoxText()
        {
            return txtSearch.Text;
        }

        public void setSavingsType(string text)
        {
            txtSavingsType.Text = text;
        }

        //public void enableDeposit()
        //{
        //    txtAmountTendered.Enabled = true;
        //    //btnPrintVoucher.Enabled = true;
        //}

        //public void disableDeposit()
        //{
        //    txtAmountTendered.Enabled = false;
        //    //btnPrintVoucher.Enabled = false;
        //}

        //public void enablePrintVoucher()
        //{
        //    btnPrintVoucher.Enabled = true;
        //}

        //public void disablePrintVoucher()
        //{
        //    btnPrintVoucher.Enabled = false;
        //}

        //public void setAmountTendered(string text)
        //{
        //    if (text.Length != 0)
        //    {
        //        text = this.amountFormatter(text);
        //    }
        //    txtAmountTendered.Text = text;
        //}

        //public string getAmountTendered()
        //{
        //    return txtAmountTendered.Text;
        //}

        public string getSavingsType()
        {
            return txtSavingsType.Text;
        }

        //public void setBtnComputeChangeEvent(EventHandler e)
        //{
        //    btnPrintVoucher.Click += e;
        //}

        //public void setChange(string text)
        //{
        //    if (text.Length != 0)
        //    {
        //        text = this.amountFormatter(text);
        //    }
        //    txtChange.Text = text;
        //}

        //public string getChange()
        //{
        //    return txtChange.Text;
        //}

        public string amountFormatter(string text)
        {
            double deduction = Convert.ToDouble(text);
            double truncated = Math.Truncate(deduction * 100) / 100;
            text = String.Format("{0:0.00}", truncated);
            return text;
        }

        public void setCboTransactionTypeEvent(EventHandler e)
        {
            cboTransactionType.SelectionChangeCommitted += e;
        }

        public void enableTxtTransact()
        {
            txtAmount.Enabled = true;
        }

        public void disableTxtTransact()
        {
            txtAmount.Enabled = false;
        }

        //public void setSignatureImage(string path,string tag)
        //{
        //    picSignature.SizeMode = PictureBoxSizeMode.StretchImage;
        //    picSignature.ImageLocation = path;
        //    picSignature.Tag = tag;
        //}

        //public void clearSignaturePic()
        //{
        //    picSignature.Image = null;
        //}

        public string getControlNumber()
        {
            return txtControlNo.Text;
        }

        public void setControlNumber(string text)
        {
            txtControlNo.Text = text;
        }

        public void setTransactionType(int index)
        {
            cboTransactionType.SelectedIndex = index;
        }

        public void addMainPanel()
        {
            this.Controls.Clear();
            this.Controls.Add(panelMain);
        }

        private void backClicked(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.Controls.Add(panelMain);
        }

        public void setDataGridAccountHoldersEvent(DataGridViewCellEventHandler e)
        {
            dgAccountHolders.CellDoubleClick += e;
        }

        public void setDataGridAccountHolders(DataSet ds)
        {
            dgAccountHolders.DataSource = ds.Tables[0];
            dgAccountHolders.Columns[0].Visible = false;
            dgAccountHolders.ClearSelection();
        }

        public DataGridView getDataGridAccountHolders()
        {
            return dgAccountHolders;
        }

        public void setIsFamily(string text)
        {
            if (text == "0")
            {
                rbtnMember.Checked = true;
            }

            else
            {
                rbtnFamily.Checked = true;
            }
        }

        public string getIsFamily()
        {
            string text = "";
            if (rbtnFamily.Checked)
            {
                text = "1";
            }

            else
            {
                text = "0";
            }

            return text;
        }

        public void setRbtnMemberClickEvent(EventHandler e)
        {
            rbtnMember.Click += e;
            dgAccountHolders.ClearSelection();
        }

        public void setRbtnFamilyClickEvent(EventHandler e)
        {
            rbtnFamily.Click += e;
            dgAccountHolders.ClearSelection();
        }

        public void setAccountHolderName(string text)
        {
            lblAccountHolderName.Text = text;
        }

        public string getAccountHolderName()
        {
            return lblAccountHolderName.Text;
        }

        public void setAccountHolderType(string text)
        {
            lblAccountHolderType.Text = text;
        }

        public string getAccountHolderType()
        {
            return lblAccountHolderType.Text;
        }

        public void setPictureSingature1(string imagePath, string tag)
        {
            pictureSignature1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureSignature1.ImageLocation = imagePath;
            pictureSignature1.Tag = tag;
        }

        public void setPictureSingature2(string imagePath, string tag)
        {
            pictureSignature2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureSignature2.ImageLocation = imagePath;
            pictureSignature2.Tag = tag;
        }

        //public string getReleaseType()
        //{
        //    string releaseType = "";
        //    if (cboReleaseType.SelectedItem.ToString() == "Cash")
        //    {
        //        releaseType = "C";
        //    }

        //    else
        //    {
        //        releaseType = "CH";
        //    }

        //    return releaseType;
        //}

        public void setDataGridSelection(int row)
        {
            dgSavingsAccount.Rows[row].Selected = true;
        }

        public void dataGridSavingsAccountClearSelection()
        {
            dgSavingsAccount.ClearSelection();
        }

        public void setBtnSaveTransactionEvent(EventHandler e)
        {
            btnSaveTransaction.Click += e;
        }

        public void setDataGridEvent(DataGridViewCellEventHandler e)
        {
            dgSavingsAccount.CellDoubleClick += e;
        }

        public void setTextSearchChange(EventHandler e)
        {
            txtSearch.TextChanged += e;
        }

        //public void setCboReleaseTypeEvent(EventHandler e)
        //{
        //    cboReleaseType.SelectedIndexChanged += e;
        //}

        //public void enableCheckInformation()
        //{
        //    txtCheckNo.Enabled = true;
        //    txtBankName.Enabled = true;
        //    dtpDateIssued.Enabled = true;
        //}

        //public void disableCheckInformation()
        //{
        //    txtCheckNo.Text = "";
        //    txtBankName.Text = "";
        //    txtCheckNo.Enabled = false;
        //    txtBankName.Enabled = false;
        //    dtpDateIssued.Enabled = false;
        //}

        //public void enableReleaseType()
        //{
        //    cboReleaseType.SelectedIndex = 0;
        //    cboReleaseType.Enabled = true;
        //}

        //public void disableReleaseType()
        //{
        //    cboReleaseType.SelectedIndex = 0;
        //    cboReleaseType.Enabled = false;
        //}

        //public string getCheckNo()
        //{
        //    return txtCheckNo.Text;
        //}

        //public string getBankName()
        //{
        //    return txtBankName.Text;
        //}

        //public string getCheckDateIssued()
        //{
        //    return dtpDateIssued.Value.ToShortDateString();
        //}
    }
}
