using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SVLMS.Savings;
using SVLMS.Savings.Controller;
using SVLMS.Savings.Model;
using SVLMS.Savings.View;

namespace SVLMS.Savings.View
{
    public partial class MaintenanceTimeDeposit : Form
    {
        public MaintenanceTimeDeposit()
        {
            InitializeComponent();
            cboSortBy.SelectedIndex = 0;
            cboFilter.SelectedIndex = 0;
        }

        public void setBtnSaveEvent(EventHandler e)
        {
            btnSave.Click += e;
        }

        public void setBtnUpdateEvent(EventHandler e)
        {
            btnUpdate.Click += e;
        }

        public void setBtnClearEvent(EventHandler e)
        {
            btnClear.Click += e;
        }

        public void setDataGridEvent(DataGridViewCellEventHandler e)
        {
            dgTimeDeposit.CellDoubleClick += e;
        }

        public void setCboFilter(EventHandler e)
        {
            cboFilter.SelectedIndexChanged += e;
        }

        public string getCboFilter()
        {
            return cboFilter.SelectedItem.ToString();
        }

        public void setNumberOfDays(string days)
        {
            txtNoOfDays.Text = days;
        }

        public string getNumberOfDays()
        {
            return txtNoOfDays.Text;
        }

        public void setMinimumBracket(string minBracket)
        {
            if (minBracket.Length != 0)
            {
                minBracket = Validator.truncateNumber(minBracket).ToString();
            }
            txtMinimumBracket.Text = minBracket;
        }

        public string getMinimumBracket()
        {
            return txtMinimumBracket.Text;
        }

        public void setMaximumBracket(string maxBracket)
        {
            if (maxBracket.Length != 0)
            {
                maxBracket = Validator.truncateNumber(maxBracket).ToString();
            }
            txtMaximumBracket.Text = maxBracket;
        }

        public string getMaximumBracket()
        {
            return txtMaximumBracket.Text;
        }

        public void setInterestRate(string interestRate)
        {
            txtInterestRate.Text = interestRate;
        }

        public string getInterestRate()
        {
            return txtInterestRate.Text;
        }

        public void setStatus(string status)
        {
            if (status == "1" || status == "Active")
            {
                rbtnActive.Checked = true;
            }
            else if (status == "0" || status == "Inactive")
            {
                rbtnInactive.Checked = true;
            }
        }

        public string getStatus()
        {
            string status = "";
            if (rbtnInactive.Checked)
            {
                status = "0";
            }
            else if (rbtnActive.Checked)
            {
                status = "1";
            }
            return status;
        }

        public void setDataGrid(DataSet ds)
        {
            dgTimeDeposit.DataSource = ds.Tables[0];
            dgTimeDeposit.Columns["Interest Rate"].DefaultCellStyle.Format = "0.00\\%";
            dgTimeDeposit.Columns[2].DefaultCellStyle.Format = "#,##0.00";
            dgTimeDeposit.Columns[3].DefaultCellStyle.Format = "#,##0.00";
            dgTimeDeposit.Columns[0].Visible = false;
        }

        public DataGridView getDataGrid()
        {
            return dgTimeDeposit;
        }

        public void resetRadioButton()
        {
            rbtnActive.Checked = false;
            rbtnInactive.Checked = false;
        }

        public void enableAdd()
        {
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
        }

        public void enableUpdate()
        {
            btnSave.Enabled = false;
            btnUpdate.Enabled = true;
        }

        //====================================================================================
        public void errNoDays()
        {
            txtNoOfDays.BackColor = Color.Salmon;
        }

        public void unNoDays()
        {
            txtNoOfDays.BackColor = Color.White;
        }

        public void errMinBracket()
        {
            txtMinimumBracket.BackColor = Color.Salmon;
        }

        public void unMinBracket()
        {
            txtMinimumBracket.BackColor = Color.White;
        }

        public void errMaxBracket()
        {
            txtMaximumBracket.BackColor = Color.Salmon;
        }

        public void unMaxBracket()
        {
            txtMaximumBracket.BackColor = Color.White;
        }

        public void errInterestRate()
        {
            txtInterestRate.BackColor = Color.Salmon;
        }

        public void unInterestRate()
        {
            txtInterestRate.BackColor = Color.White;
        }

        public void errStatus()
        {
            statusPanel.BackColor = Color.Salmon;
        }

        public void unStatus()
        {
            statusPanel.BackColor = Color.CornflowerBlue;
        }

        public int status()
        {
            int i = 0;
            if (rbtnActive.Checked == false && rbtnInactive.Checked == false)
                i=1;
            return i;
        }

        public void setCboSortByEvent(EventHandler e)
        {
            cboSortBy.SelectionChangeCommitted += e;
        }

        public int getCboSortBy()
        {
            return cboSortBy.SelectedIndex;
        }

        public string getTextSearch()
        {
            return txtSearch.Text;
        }

        public void setTextSearchEvent(EventHandler e)
        {
            txtSearch.TextChanged += e;
        }

        private void txtNoOfDays_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void txtMinimumBracket_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtMaximumBracket_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
