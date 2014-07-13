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
    public partial class TransactionTimeDeposit : Form
    {
        public TransactionTimeDeposit()
        {
            InitializeComponent();
            cboTransactionType.SelectedIndex = 0;
            cboSearchBy.SelectedIndex = 0;
            cboMaturityOption.SelectedIndex = 0;
            cboSavingsAccountTransfer.Enabled = false;
            //cboReleaseType.SelectedIndex = 0;
        }

        public event EventHandler searchPressed;

        public string amountFormatter(string text)
        {
            double deduction = Convert.ToDouble(text);
            double truncated = Math.Truncate(deduction * 100) / 100;
            text = String.Format("{0:0.00}", truncated);
            return text;
        }

        public void setDataGrid(DataSet ds)
        {
            dgTimeDeposits.DataSource = ds.Tables[0];
            dgTimeDeposits.Columns["accountNo"].Visible = false;
            dgTimeDeposits.Columns["amount"].DefaultCellStyle.Format = "0.00";
        }

        public DataGridView getDataGrid()
        {
            return dgTimeDeposits;
        }

        public void setTimeDepositNo(string text)
        {
            txtTimeDepositNo.Text = text;
        }

        public string getTimeDepositNo()
        {
            return txtTimeDepositNo.Text;
        }

        public void setMemberName(string text)
        {
            txtMemberName.Text = text;
        }

        public string getMemberName()
        {
            return txtMemberName.Text;
        }

        public void setMaturityDate(string text)
        {
            if (text.Length != 0)
            {
                text = Convert.ToDateTime(text).ToShortDateString();
            }
            txtMaturityDate.Text = text;
        }

        public string getMaturityDate()
        {
            return txtMaturityDate.Text;
        }

        public string getTxtSearch()
        {
            return txtSearch.Text;
        }

        public string getSearchBy()
        {
            return cboSearchBy.SelectedItem.ToString();
        }

        //public void setCboExtensionDays(DataSet ds)
        //{
        //    cboExtensionDays.DisplayMember = "daysNo";
        //    cboExtensionDays.ValueMember = "timeDayID";
        //    cboExtensionDays.DataSource = ds.Tables[0];
        //}

        //public string getCboExtensionDays()
        //{
        //    return cboExtensionDays.SelectedValue.ToString();
        //}

        public void setAmount(string text)
        {
            if (text.Length != 0)
            {
                text = this.amountFormatter(text);
            }
            txtAmount.Text = text;
        }

        public string getAmount()
        {
            return txtAmount.Text;
        }

        public void setBalance(string text)
        {
            if (text.Length != 0)
            {
                text = this.amountFormatter(text);
            }
            txtBalance.Text = text;
        }

        public string getBalance()
        {
            return txtBalance.Text;
        }

        public void setInterest(string text)
        {
            if (text.Length != 0)
            {
                text = this.amountFormatter(text);
            }
            txtInterest.Text = text;
        }

        public string getInterest()
        {
            return txtInterest.Text;
        }

        public void setPenalty(string text)
        {
            if (text.Length != 0)
            {
                text = this.amountFormatter(text);
            }
            txtPenalty.Text = text;
        }

        public void setMaturitOption(int index)
        {
            cboMaturityOption.SelectedIndex = index;
        }

        public string getPenalty()
        {
            return txtPenalty.Text;
        }

        public void setTotal(string text)
        {
            if (text.Length != 0)
            {
                text = this.amountFormatter(text);
            }
            txtTotal.Text = text;
        }

        public string getTotal()
        {
            return txtTotal.Text;
        }

        public string getTransactionType()
        {
            return cboTransactionType.SelectedItem.ToString();
        }

        public void setSignatureImage1(string path,string tag)
        {
            picSignature.SizeMode = PictureBoxSizeMode.StretchImage;
            picSignature.ImageLocation = path;
            picSignature.Tag = tag;
        }

        public void setSignatureImage2(string path, string tag)
        {
            picSignature2.SizeMode = PictureBoxSizeMode.StretchImage;
            picSignature2.ImageLocation = path;
            picSignature2.Tag = tag;
        }

        //public void setTerm(DataSet ds)
        //{
        //    if (ds != null)
        //    {
        //        cboExtensionDays.DisplayMember = "daysDisplay";
        //        cboExtensionDays.ValueMember = "daysNo";
        //        cboExtensionDays.DataSource = ds.Tables[0];
        //    }
        //}

        //public void enableCboExtensionDays()
        //{
        //    cboExtensionDays.Enabled = true;
        //}

        //public void disableCboExtensionDays()
        //{
        //    cboExtensionDays.Enabled = false;
        //}

        //public void enablePrintCertificate()
        //{
        //    btnPrintCertificate.Enabled = true;
        //}

        //public void disablePrintCertificate()
        //{
        //    btnPrintCertificate.Enabled = false;
        //}

        //public void enablePrintVoucher()
        //{
        //    btnPrintVoucher.Enabled = true;
        //}

        //public void disablePrintVoucher()
        //{
        //    btnPrintVoucher.Enabled = false;
        //}

        public void enableTransactionType()
        {
            cboTransactionType.Enabled = true;
        }

        public void disableTransactionType()
        {
            cboTransactionType.Enabled = false;
        }

        public void setDataGridEvent(DataGridViewCellEventHandler e)
        {
            dgTimeDeposits.CellDoubleClick += e;
        }

        public void setBtnSaveTransactionEvent(EventHandler e)
        {
            btnClose.Click += e;
        }

        //public void setBtnPrintCertificateEvent(EventHandler e)
        //{
        //    btnPrintCertificate.Click += e;
        //}

        //public void setBtnPrintVoucherEvent(EventHandler e)
        //{
        //    btnPrintVoucher.Click += e;
        //}

        public void setCboTransactionTypeSelectedIndexChanged(EventHandler e)
        {
            cboTransactionType.SelectedIndexChanged += e;
        }

        public void setCboSavings(DataSet ds)
        {
            cboSavings.DisplayMember = "Savings Name";
            cboSavings.ValueMember = "savingsAccountNo";
            cboSavings.DataSource = ds.Tables[0];
        }

        public string getCboSavings()
        {
            string savingsAccountNo = "";
            if (cboSavings.SelectedValue != null)
            {
                savingsAccountNo = cboSavings.SelectedValue.ToString();
            }
            return savingsAccountNo;
        }

        public void enableCboSavings()
        {
            cboSavings.Enabled = true;
        }

        public void disableCboSavings()
        {
            cboSavings.Enabled = false;
            cboSavings.DataSource = null;
        }

        public void refreshCombobox()
        {
            cboTransactionType.SelectedIndex = 0;
            cboMaturityOption.SelectedIndex = 0;
        }

        public void setBtnSaveMaturityEvent(EventHandler e)
        {
            btnSaveMaturity.Click += e;
        }

        public void setCboMaturityOptionEvent(EventHandler e)
        {
            cboMaturityOption.SelectedIndexChanged+= e;
        }

        public int getMaturityOption()
        {
            return cboMaturityOption.SelectedIndex;
        }

        public void setCboSavingsTransfer(DataSet ds)
        {
            cboSavingsAccountTransfer.DisplayMember = "Savings Name";
            cboSavingsAccountTransfer.ValueMember = "savingsAccountNo";
            cboSavingsAccountTransfer.DataSource = ds.Tables[0];
        }

        public void enableCboSavingsTransfer()
        {
            cboSavingsAccountTransfer.Enabled = true;
        }

        public void disableCboSavingsTransfer()
        {
            cboSavingsAccountTransfer.Enabled = false;
            cboSavingsAccountTransfer.DataSource = null;
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

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if(searchPressed !=null)
            {
                searchPressed(sender, e);
            }
        }

        public void setInterestRate(string text)
        {
            if (text.Length != 0)
            {
                text = Validator.amountFormatter(text);
            }
            txtInterestRate.Text = text;
        }

        public string getInterestRate()
        {
            return txtInterestRate.Text;
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

        //public string getReleaseType()
        //{
        //    string releaseType = "";
        //    string cbo = cboReleaseType.SelectedItem.ToString();
        //    if (cbo == "Cash")
        //    {
        //        releaseType = "C";
        //    }

        //    else
        //    {
        //        releaseType = "CH";
        //    }
        //    return releaseType;
        //}
    }
}
