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
    public partial class MaintenancePenaltyView : Form
    {
        public MaintenancePenaltyView()
        {
            InitializeComponent();
            cboInterval.SelectedIndex = 0;
            cboGracePeriod.SelectedIndex = 0;
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

        public void setTxtSearchEvent(EventHandler e)
        {
            txtSearchBox.TextChanged += e;
        }

        public void setLoanTypeID(string loanTypeID)
        {
            cboLoanType.SelectedValue = Convert.ToInt32(loanTypeID);
        }

        public void setLoanTypes(DataSet loanTypes)
        {
            cboLoanType.DataSource = loanTypes.Tables[0];
            cboLoanType.ValueMember = "loanTypeID";
            cboLoanType.DisplayMember = "loanName";
        }

        public string getLoanTypeID()
        {
            return cboLoanType.SelectedValue.ToString();
        }

        public void enableCboLoanType()
        {
            cboLoanType.Enabled = true;
        }

        public void disableCboLoanType()
        {
            cboLoanType.Enabled = false;
        }

        public void setPenaltyRate(string penaltyRate)
        {
            if (penaltyRate.Length != 0)
            {
                penaltyRate = this.amountFormatter(penaltyRate);
            }
            txtPenaltyRate.Text = penaltyRate;
        }

        public string getPenaltyRate()
        {
            return txtPenaltyRate.Text;
        }

        public void setIsPercentage(string isPercentage)
        {
            if (isPercentage == "1")
            {
                rbtnPercentage.Checked = true;
            }

            else
            {
                rbtnFixed.Checked = true;
            }
        }

        public void clearCBBox()
        {

            cboLoanType.Select(0, 0);

        }

        public string getIsPercentage()
        {
            string isPercentage = "";
            if (rbtnPercentage.Checked)
            {
                isPercentage = "1";
            }

            else
            {
                isPercentage = "0";
            }
            return isPercentage;
        }

        public void setEffectivityDate(string effectivityDate)
        {
            dtpEffectivityDate.Value = Convert.ToDateTime(effectivityDate);
        }

        public void enableBtnAdd()
        {
            btnSave.Enabled = true;
        }

        public void disableBtnAdd()
        {
            btnSave.Enabled = false;
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

        public void enableBtnUpdate()
        {
            btnUpdate.Enabled = true;
        }

        public void disableBtnUpdate()
        {
            btnUpdate.Enabled = false;
        }

        public string getEffectivityDate()
        {
            return dtpEffectivityDate.Value.ToString();
        }

        public string amountFormatter(string text)
        {
            double deduction = Convert.ToDouble(text);
            double truncated = Math.Truncate(deduction * 100) / 100;
            text = String.Format("{0:0.00}", truncated);
            return text;
        }

        //============ DG ===========================
        public void setDataGrid(DataSet ds)
        {
            dgPenalty.DataSource = ds.Tables[0];
            dgPenalty.Columns[0].Visible = false;
            dgPenalty.Columns["Penalty Amount"].DefaultCellStyle.Format = "0.00";
        }

        public DataGridView getDataGrid()
        {
            return dgPenalty;
        }

        public void setGracePeriod(string gracePeriod)
        {
            txtGracePeriod.Text = gracePeriod;
        }

        public string getGracePeriod()
        {
            return txtGracePeriod.Text;
        }

        public void setCboGracePeriod(int index)
        {
            cboGracePeriod.SelectedIndex = (index - 1);
        }

        public void enableBtnSave()
        {
            btnSave.Enabled = true;
        }

        public void disableBtnSave()
        {
            btnSave.Enabled = false;
        }

        public int getCboGracePeriod()
        {
            return cboGracePeriod.SelectedIndex + 1;
        }

        public void setInterval(string interval)
        {
            txtInterval.Text = interval;
        }

        public string getInterval()
        {
            return txtInterval.Text;
        }

        public void setCboInterval(int index)
        {
            cboInterval.SelectedIndex = (index - 1);
        }

        public int getCboInterval()
        {
            return cboInterval.SelectedIndex + 1;
        }

        public void clearRadioButton()
        {
            rbtnActive.Checked = false;
            rbtnFixed.Checked = false;
            rbtnInactive.Checked = false;
            rbtnPercentage.Checked = false;
        }
        //----------------VALIDATIONS---------------------------------
        //PenaltyRate
        public void errPenaltyRate()
        {
            txtPenaltyRate.BackColor = Color.Salmon;
        }

        public void unPenaltyRate()
        {
            txtPenaltyRate.BackColor = Color.White;
        }
        //GracePeriod
        public void errGracePeriod()
        {
            txtGracePeriod.BackColor = Color.Salmon;
        }

        public void unGracePeriod()
        {
            txtGracePeriod.BackColor = Color.White;
        }
        //Interval
        public void errInterval()
        {
            txtInterval.BackColor = Color.Salmon;
        }

        public void unInterval()
        {
            txtInterval.BackColor = Color.White;
        }
        //StatusActiveInactive
        public void errStatus()
        {
            StatusPanel.BackColor = Color.Salmon;
        }

        public void unStatus()
        {
            StatusPanel.BackColor = Color.White;
        }

        public int status()
        {
            int i = 0;
            if (rbtnActive.Checked == false && rbtnInactive.Checked == false)
                i = 1;
            return i;
        }
        //IsPercentage
        public void errPercentage()
        {
            PercentagePanel.BackColor = Color.Salmon;
        }

        public void unPercentage()
        {
            PercentagePanel.BackColor = Color.White;
        }

        public int percentage()
        {
            int i = 0;
            if (rbtnFixed.Checked == false && rbtnPercentage.Checked == false)
                i = 1;
            return i;
        }

        private void txtPenaltyRate_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtGracePeriod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void txtInterval_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

    }
}
