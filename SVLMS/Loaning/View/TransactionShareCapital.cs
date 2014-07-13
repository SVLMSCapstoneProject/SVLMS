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
    public partial class TransactionShareCapital : Form
    {
        public TransactionShareCapital()
        {
            InitializeComponent();
            cboSearchBy.SelectedIndex = 0;
        }

        public event EventHandler searchPressed;

        public void setDataGridCellClickedEvent(DataGridViewCellEventHandler e)
        {
            dgMemberInformation.CellDoubleClick += e;
        }

        public void setBtnDepositClickedEvent(EventHandler e)
        {
            btnDepositShare.Click += e;
        }

        public void setBtnPrintStockClickedEvent(EventHandler e)
        {
            btnPrintStockCertificate.Click += e;
        }

        public void setTxtSearchChangedEvent(EventHandler e)
        {
            txtSearch.TextChanged += e;
        }

        public void setAccountNo(string text)
        {
            txtAccountNo.Text = text;
        }

        public void setMemberName(string text)
        {
            txtMemberName.Text = text;
        }

        public void setTotalShares(string text)
        {
            if (text.Length != 0)
            {
                text = this.amountFormatter(text);
            }
            txtTotalShares.Text = text;
        }

        public void setShareAmount(string text)
        {
            txtShareAmount.Text = text;
        }

        public string getShareAmount()
        {
            return txtShareAmount.Text;
        }

        public string getAccountNo()
        {
            return txtAccountNo.Text;
        }

        public string getMemberName()
        {
            return txtMemberName.Text;
        }

        public string getTotalShares()
        {
            return txtTotalShares.Text;
        }

        //public void setAmountTendered(string text)
        //{
        //    txtAmountTendered.Text = text;
        //}

        //public string getAmountTendered()
        //{
        //    return txtAmountTendered.Text;
        //}

        public string getSearchBy()
        {
            return cboSearchBy.SelectedItem.ToString();
        }

        public string getTxtSearch()
        {
            return txtSearch.Text;
        }

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

        public void setDataGridMemberInfo(DataSet ds)
        {
            dgMemberInformation.DataSource = ds.Tables[0];
        }

        public DataGridView getDataGridMemberInfo()
        {
            return dgMemberInformation;
        }

        public string amountFormatter(string text)
        {
            double deduction = Convert.ToDouble(text);
            double truncated = Math.Truncate(deduction * 100) / 100;
            text = String.Format("{0:0.00}", truncated);
            return text;
        }

        public void enableBtnPrintStock()
        {
            btnPrintStockCertificate.Enabled = true;
        }

        public void disableBtnPrintStock()
        {
            btnPrintStockCertificate.Enabled = false;
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
