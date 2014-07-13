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
    public partial class TransactionLoanPaymentView : Form
    {
        public TransactionLoanPaymentView()
        {
            InitializeComponent();
            cboSearchBy.SelectedIndex = 0;
        }

        public event EventHandler searchPressed;

        public string getSearchBy()
        {
            return cboSearchBy.SelectedItem.ToString();
        }

        public string getTxtSearch()
        {
            return txtSearch.Text;
        }

        public void setDataGridLoanRecords(DataSet ds)
        {
            dgLoanRecords.DataSource = ds.Tables[0];
            dgLoanRecords.Columns[3].Visible = false;
        }

        public DataGridView getDataGridLoanRecords()
        {
            return dgLoanRecords;
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

        public void setCurrentBalance(string text)
        {
            if (text.Length != 0)
            {
                text = Validator.amountFormatter(text);
            }
            txtCurrentBalance.Text = text;
        }

        //public void setAmortization(string text)
        //{
        //    MessageBox.Show("Test");
        //    if (text.Length != 0)
        //    {
        //        MessageBox.Show(Math.Round(Convert.ToDouble(text), 3).ToString());
        //        text = text = (Math.Round(Convert.ToDouble(text), 2)).ToString();
        //    }
        //    txtAmortization.Text = text;
        //}

        public string getAmortization()
        {
            return txtAmortization.Text;
        }

        public void setPenalty(string text)
        {
            if (text.Length != 0)
            {
                text = Validator.amountFormatter(text);
            }

            txtPenalty.Text = text;
        }

        public string getPenalty()
        {
            return txtPenalty.Text;
        }

        public void setTotalAmount(string text)
        {
            if (text.Length != 0)
            {
                text = Validator.amountFormatter(text);
            }
            txtTotal.Text = text;
        }

        public string getTotalAmount()
        {
            return txtTotal.Text;
        }

        public void setChange(string text)
        {
            if (text.Length != 0)
            {
                text = Validator.amountFormatter(text);
            }
            txtChange.Text = text;
        }

        public string getChange()
        {
            return txtChange.Text;
        }

        public void setDataGridLoanRecordsCellDoubleClick(DataGridViewCellEventHandler e)
        {
            dgLoanRecords.CellDoubleClick += e;
        }

        public void enableAdvance()
        {
            txtPeriod.Enabled = true;
            btnComputeTotal.Enabled = true;
        }

        public void disableAdvance()
        {
            txtPeriod.Enabled = false;
            btnComputeTotal.Enabled = false;
            txtPeriod.Text = "";
        }

        public void setDueDate(string text)
        {
            if (text.Length != 0)
            {
                txtDueDate.Text = Convert.ToDateTime(text).ToShortDateString();
            }
        }

        public string getDueDate()
        {
            return txtDueDate.Text;
        }

        public void setAmountToBePaid(string text)
        {
            if (text.Length != 0)
            {
                text = Math.Round(Convert.ToDouble(text), 2).ToString();
            }
            txtAmortization.Text = text;
        }

        public string getAmountToBePaid()
        {
            return txtAmortization.Text;
        }

        public void setNoOfPeriod(string text)
        {
            txtPeriod.Text = text;
        }

        public string getNoOfPeriod()
        {
            return txtPeriod.Text;
        }

        public void setAmountTendered(string text)
        {
            if (text.Length != 0)
            {
                text = Validator.amountFormatter(text);
            }
            txtAmountTendered.Text = text;
        }

        public string getAmountTendered()
        {
            return txtAmountTendered.Text;
        }

        public void setIsChangeAdvance(string text)
        {
            if (text == "1")
            {
                chkAdvancePayment.Checked = true;
            }

            else
            {
                chkAdvancePayment.Checked = false;
            }
        }

        public string getIsChangeAdvance()
        {
            string isAdvance = "";
            if (chkAdvancePayment.Checked)
            {
                isAdvance = "1";
            }

            else
            {
                isAdvance = "0";
            }
            return isAdvance;
        }

        public void setBtnComputeTotal(EventHandler e)
        {
            btnComputeTotal.Click += e;
        }

        public void setBtnSavePaymentEvent(EventHandler e)
        {
            btnSavePayment.Click += e;
        }

        public void setDataGridAmortization(DataSet ds)
        {
            dgAmortization.DataSource = ds.Tables[0];
            dgAmortization.Columns["Remaining Amount"].DefaultCellStyle.Format = "#,##0.00";
            dgAmortization.Columns["Penalty"].DefaultCellStyle.Format = "#,##0.00";
        }

        public DataGridView getDataGridAmortization()
        {
            return dgAmortization;
        }

        public void clearDataGridAmortization()
        {
            dgAmortization.DataBindings.Clear();
            dgAmortization.Refresh();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if(searchPressed != null)
            {
                searchPressed(sender,e);    
            }
        }

        public void setLblNoOfPaymentsMade(string text)
        {
            lblNoOfPayment.Text = text;
        }

        public void setLblRemainingAmount(string text)
        {
             lblRemainingAmount.Text = Validator.amountFormatter(text);
        }

        public void setLblAmountPaid(string text)
        {
            lblAmountPaid.Text = Validator.amountFormatter(text);
        }

        public void setLblPenaltyAmount(string text) 
        {
            lblPenaltyAmount.Text = Validator.amountFormatter(text);
        }

        public void setAmountUnpaid(string text) 
        {
            lblAmountUnpaid.Text = Validator.amountFormatter(text);
        }
    }
}
