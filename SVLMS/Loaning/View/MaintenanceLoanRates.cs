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
    public partial class MaintenanceLoanRates : Form
    {
        public MaintenanceLoanRates()
        {
            InitializeComponent();
            cboIsPercentageInterest.SelectedIndex = 0;
            //cboIsPercentageSavings.SelectedIndex = 0;
            cboIsPercentageShare.SelectedIndex = 0;
            cboFilter.SelectedIndex = 0;
        }

        public string getCboFilter()
        {
            return cboFilter.SelectedItem.ToString();
        }

        public string getTextSearch()
        {
            return txtSearchBox.Text;
        }

        public void setCboFilterEvent(EventHandler e)
        {
            cboFilter.SelectedIndexChanged += e;
        }

        public void setTxtSearchEvent(EventHandler e)
        {
            txtSearchBox.TextChanged += e;
        }

        public string getLoanTypeID()
        {
            return cboLoanType.SelectedValue.ToString();
        }

        public void setInterestRate(string text)
        {
            if (text.Length != 0)
            {
                text = this.amountFormatter(text);
            }
            txtInterestRate.Text = text;
        }

        public string getInterestRate()
        {
            return txtInterestRate.Text;
        }

        //public void setSavingsRate(string text)
        //{
        //    if (text.Length != 0)
        //    {
        //        text = this.amountFormatter(text);
        //    }
        //    txtSavingsRate.Text = text;
        //}

        //public string getSavingsRate()
        //{
        //    return txtSavingsRate.Text;
        //}

        public void setShareRate(string text)
        {
            if (text.Length != 0)
            {
                text = this.amountFormatter(text);
            }
            txtShareRate.Text = text;
        }

        public string getShareRate()
        {
            return txtShareRate.Text;
        }

        public void setIsPercentageInterest(string num)
        {
            cboIsPercentageInterest.SelectedIndex = Convert.ToInt32(num);
        }

        public string getIsPercentageInterest()
        {
            return cboIsPercentageInterest.SelectedIndex.ToString();
        }

        //public void setIsPercentageSavings(string num)
        //{
        //    cboIsPercentageSavings.SelectedIndex = Convert.ToInt32(num);
        //}

        //public string getIsPercentageSavings()
        //{
        //    return cboIsPercentageSavings.SelectedIndex.ToString();
        //}

        public void setIsPercentageShare(string num)
        {
            cboIsPercentageShare.SelectedIndex = Convert.ToInt32(num);
        }

        public string getIsPercentageShare()
        {
            return cboIsPercentageShare.SelectedIndex.ToString();
        }

        public void setCboLoanType(DataSet ds)
        {
            cboLoanType.ValueMember = "loanTypeID";
            cboLoanType.DisplayMember = "loanName";
            cboLoanType.DataSource = ds.Tables[0];
        }

        public void setStatus(string status)
        {
            if (status == "1")
            {
                rbtnActive.Checked = true;
            }

            else
            {
                rbtnInactive.Checked = true;
            }
        }

        public string getStatus()
        {
            string status = "";
            if (rbtnActive.Checked)
            {
                status = "1";
            }

            else if (rbtnInactive.Checked)
            {
                status = "0";
            }
            return status;
        }

        public void setlblTitle(string title)
        {
            //lblTitle.Text = title;
        }

        public void setlblRate(string rate)
        {
            lblRate.Text = rate + ":";
        }


        public void setEffectivityDate(string date)
        {
            if (date.Length != 0)
            {
                dtpEffectivity.Value = Convert.ToDateTime(date);
            }
        }

        public void setRate(string text)
        {
            if (text.Length != 0)
            {
                text = this.amountFormatter(text);
            }
            txtInterestRate.Text = text;
        }

        public void enableUpdate()
        {
            btnUpdate.Enabled = true;
        }

        public void disableUpdate()
        {
            btnUpdate.Enabled = false;
        }

        public void enableAdd()
        {
            btnSave.Enabled = true;
        }

        public void disableAdd()
        {
            btnSave.Enabled = false;
        }

        public void setCboLoanTypeSelectedValue(string value)
        {
            cboLoanType.SelectedValue = value;
        }

        public string getRate()
        {
            return txtInterestRate.Text;
        }

        public string getEffectivity()
        {
            return dtpEffectivity.Value.ToString();
        }

        //public void setRateID(string text)
        //{
        //    txtRateID.Text = text;
        //}

        //public string getRateID()
        //{
        //    return txtRateID.Text;
        //}

        public DataGridView getDataGrid()
        {
            return dgLoanRates;
        }

        public void setDataGrid(DataSet ds)
        {
            dgLoanRates.DataSource = ds.Tables[0];
            dgLoanRates.Columns[0].Visible = false;
            dgLoanRates.Columns["Interest Rate"].DefaultCellStyle.Format = "0.00\\%";
            dgLoanRates.Columns["Share Capital Rate"].DefaultCellStyle.Format = "0.00\\%";
        }

        public void setBtnAddEvent(EventHandler e)
        {
            btnSave.Click += e;
        }

        public void setClearEvent(EventHandler e)
        {
            btnClear.Click += e;
        }

        public void setBtnUpdateEvent(EventHandler e)
        {
            btnUpdate.Click += e;
        }

        public void setDataGridDoubleClickEvent(EventHandler e)
        {
            dgLoanRates.DoubleClick += e;
        }

        public string amountFormatter(string text)
        {
            double deduction = Convert.ToDouble(text);
            double truncated = Math.Truncate(deduction * 100) / 100;
            text = String.Format("{0:0.00}", truncated);
            return text;
        }

        public void clearRadioButton()
        {
            rbtnActive.Checked = false;
            rbtnInactive.Checked = false;
        }

        public void errInterestRate()
        {
            txtInterestRate.BackColor = Color.Salmon;
        }

        public void unInterestRate()
        {
            txtInterestRate.BackColor = Color.White;
        }

        public void errShareCapital()
        {
            txtShareRate.BackColor = Color.Salmon;
        }

        public void unShareCapital()
        {
            txtShareRate.BackColor = Color.White;
        }

        public void errStatus()
        {
            statusPanel.BackColor = Color.Salmon;
        }

        public void unStatus()
        {
            statusPanel.BackColor = Color.White;
        }

        public int status()
        {
            int i = 0;
            if (rbtnActive.Checked == true || rbtnInactive.Checked == true)
                i = 0;
            else
                i = 1;
            return i;
        }

        private void txtInterestRate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void txtShareRate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

    }
}
