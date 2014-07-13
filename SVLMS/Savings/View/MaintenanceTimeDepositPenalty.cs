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
    public partial class MaintenanceTimeDepositPenalty : Form
    {
        public MaintenanceTimeDepositPenalty()
        {
            InitializeComponent();
            cboFilter.SelectedIndex = 0;
        }

        public string getCboFilter()
        {
            return cboFilter.SelectedItem.ToString();
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
            dgPenalty.CellDoubleClick += e;
        }

        public void setCboFilterEvent(EventHandler e)
        {
            cboFilter.SelectedIndexChanged += e;
        }

        public void setTermElapsedMinimum(string minimum)
        {
            txtMinTerm.Text = minimum;
        }

        public string getTermElapsedMinimum()
        {
            return txtMinTerm.Text;
        }

        public void setTermElapsedMaximum(string maximum)
        {
            txtMaxTerm.Text = maximum;  
        }

        public string getTermElapsedMaximum()
        {
            return txtMaxTerm.Text;
        }

        public void setRateAdjustment(string adjustment)
        {
            txtRateAdjustment.Text = adjustment;
        }

        public string getRateAdjustment()
        {
            return txtRateAdjustment.Text;
        }

        public void setdgPenalty(DataSet ds)
        {
            dgPenalty.DataSource = ds.Tables[0];
            dgPenalty.Columns[0].Visible = false;
            dgPenalty.Columns["Minimum"].DefaultCellStyle.Format = "0.00\\%";
            dgPenalty.Columns["Maximum"].DefaultCellStyle.Format = "0.00\\%";
            dgPenalty.Columns["Rate Adjustment"].DefaultCellStyle.Format = "0.00\\%";
        }

        public DataGridView getdgPenalty()
        {
            return dgPenalty;
        }

        public void setStatus(string status)
        {
            if (status == "1" || status == "Active")
            {
                rbtnActive.Checked = true;
            }
            if (status == "0" || status == "Inactive")
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
            if (rbtnInactive.Checked)
            {
                status = "0";
            }
            return status;
        }

        public void disableWhenupdate()
        {
            btnSave.Enabled = false;
            btnUpdate.Enabled = true;
        }

        public void enableWhenupdate()
        {
            btnUpdate.Enabled = false;
            btnSave.Enabled = true;
        }

        public void disableTextboxes()
        {
            txtMaxTerm.Enabled = false;
            txtMinTerm.Enabled = false;
        }

        public void enableTextboxes()
        {
            txtMaxTerm.Enabled = true;
            txtMinTerm.Enabled = true;
        }

        public void resetRadioButton()
        {
            rbtnActive.Checked = false;
            rbtnInactive.Checked = false;
        }
        //====================================================================================================
        public void errMinTerm()
        {
            txtMinTerm.BackColor = Color.Salmon;
        }

        public void unMinTerm()
        {
            txtMinTerm.BackColor = Color.White;
        }

        public void errMaxTerm()
        {
            txtMaxTerm.BackColor = Color.Salmon;
        }

        public void unMaxTerm()
        {
            txtMaxTerm.BackColor = Color.White;
        }

        public void errRate()
        {
            txtRateAdjustment.BackColor = Color.Salmon;
        }

        public void unRate()
        {
            txtRateAdjustment.BackColor = Color.White;
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
                i = 1;
            return i;
        }

        private void txtMinTerm_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtMaxTerm_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtRateAdjustment_KeyPress(object sender, KeyPressEventArgs e)
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
