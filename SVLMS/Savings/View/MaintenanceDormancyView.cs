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
    public partial class MaintenanceDormancyView : Form
    {
        public MaintenanceDormancyView()
        {
            InitializeComponent();
            cboFilter.SelectedIndex = 0;
            cboInactivity.SelectedIndex = 0;
            cboDeductionTime.SelectedIndex = 0;
        }

        public void setDormancyNo(string dormancyNo)
        {
            txtDormancyNo.Text = dormancyNo;
        }

        public string getDormancyNo()
        {
            return txtDormancyNo.Text;
        }

        public void setInactivityDuration(string inactivityDuration)
        {
            txtInactivity.Text = inactivityDuration;
        }

        public string getInactivityDuration()
        {
            return txtInactivity.Text;
        }

        public void setInactivityTime(string inactivityTime)
        {
            cboInactivity.SelectedIndex = Convert.ToInt32(inactivityTime)-1;
        }

        public string getInactivityTime()
        {
            return (cboInactivity.SelectedIndex +1).ToString();
        }

        public void setDeductionAmount(string deductionAmount)
        {
            //Formatting number
            if (deductionAmount.Length != 0)
            {
                double deduction = Convert.ToDouble(deductionAmount);
                double truncated = Math.Truncate(deduction*100)/100;
                deductionAmount = String.Format("{0:0.00}",truncated);
            }

            txtDeductionAmount.Text = deductionAmount;
        }

        public string getDeductionAmount()
        {
            return txtDeductionAmount.Text;
        }

        public void setDormancyInfo(DataSet ds)
        {
            dgDormancy.DataSource = ds.Tables[0];
            dgDormancy.Columns["DeductionAmount"].DefaultCellStyle.Format = "0.00";
            dgDormancy.Columns[0].Visible = false;
        }

        public DataGridView getDormancyInfo()
        {
            return dgDormancy;
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

        //public void setDeductEvery(string deductEvery)
        //{
        //    txtDeductEvery.Text = deductEvery;
        //}

        //public string getDeductEvery()
        //{
        //    return txtDeductEvery.Text;
        //}

        public void setDeductionTime(string deductionTime)
        {
            cboDeductionTime.SelectedIndex = Convert.ToInt32(deductionTime)-1;
        }

        public string getDeductionTime()
        {
            return (cboDeductionTime.SelectedIndex + 1).ToString();
        }

        public void setSavingsType(int loanTypeID)
        {
            cboSavingsType.SelectedValue = loanTypeID;
        }

        public string getSavingsType()
        {
            return cboSavingsType.SelectedValue.ToString();
        }

        public void setSavingsType(DataSet ds)
        {
            cboSavingsType.DataSource = ds.Tables[0];
            cboSavingsType.ValueMember = "savingsTypeID";
            cboSavingsType.DisplayMember = "savingsName";
        }

        public void setStatus(string status)
        {
            if (status == "1")
            {
                rbtnActive.Checked = true;
            }

            else if (status == "0")
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

            else
            {
                status = "0";
            }

            return status;
        }

        //public void setEffectivityDate(string date)
        //{
        //    dtpEffectivity.Value = Convert.ToDateTime(date);
        //}

        //public string getEffectivityDate()
        //{
        //    return dtpEffectivity.Value.ToString();
        //}

        public string getSearchBox()
        {
            return txtSearchBox.Text;
        }

        public string getSearchBy()
        {
            return cboFilter.SelectedItem.ToString();
        }

        public void enableSaveBtn()
        {
            btnSave.Enabled = true;
        }

        public void disableSaveBtn()
        {
            btnSave.Enabled = false;
        }

        public void enableUpdateBtn()
        {
            btnUpdate.Enabled = true;
        }

        public void disableUpdateBtn()
        {
            btnUpdate.Enabled = false;
        }

        public void enableCboSavingsType()
        {
            cboSavingsType.Enabled = true;
        }

        public void disableCboSavingsType()
        {
            cboSavingsType.Enabled = false;
        }

        public void clearRadioButton()
        {
            rbtnActive.Checked = false;
            rbtnInactive.Checked = false;
            rbtnFixed.Checked = false;
            rbtnPercentage.Checked = false;
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
            dgDormancy.CellDoubleClick += e;
        }

        public void setTxtSearchEvent(EventHandler e)
        {
            txtSearchBox.TextChanged += e;
        }

        public void setCboFilterEvent(EventHandler e)
        {
            cboFilter.SelectedIndexChanged += e;
        }

        public string getTxtSearch()
        {
            return txtSearchBox.Text;
        }

        public string getCboFilter()
        {
            return cboFilter.SelectedItem.ToString();
        }
        
        //InactivityDuration--------------
        public void errInactivityDuration()
        {
            txtInactivity.BackColor = Color.Salmon;
        }

        public void unInactivityDuration()
        {
            txtInactivity.BackColor = Color.White;
        }
        //DeductionAmount------------------
        public void errDeductionAmount()
        {
            txtDeductionAmount.BackColor = Color.Salmon;
        }

        public void unDeductionAmount()
        {
            txtDeductionAmount.BackColor = Color.White;
        }
        //DeductEvery----------------------
        //public void errDeductEvery()
        //{
        //    txtDeductEvery.BackColor = Color.Salmon;
        //}

        //public void unDeductEvery()
        //{
        //    txtDeductEvery.BackColor = Color.White;
        //}
        //Status----------------------
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
            {
                i = 1;
            }
            return i;
        }
        //Percentage----------------------
        public void errPercentage()
        {
            percentagePanel.BackColor = Color.Salmon;
        }

        public void unPercentage()
        {
            percentagePanel.BackColor = Color.CornflowerBlue;
        }

        public int percentage()
        {
            int i = 0;
            if (rbtnFixed.Checked == false && rbtnPercentage.Checked == false)
            {
                i = 1;
            }
            return i;
        }
        //deductionAmount
        public void errDeductAmount()
        {
            txtDeductionAmount.BackColor = Color.Salmon;
        }

        public void unDeductAmount()
        {
            txtDeductionAmount.BackColor = Color.White;
        }

        private void txtInactivity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void txtDeductionAmount_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtDeductEvery_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }
    }
}
