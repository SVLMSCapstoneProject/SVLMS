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
    public partial class MaintenanceSavingsTypeView : Form
    {
        public MaintenanceSavingsTypeView()
        {
            InitializeComponent();
            cboWithdrawDuration.SelectedIndex = 0;
            dgSavingsType.ReadOnly = true;
            dgSavingsType.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            cboFilter.SelectedIndex = 0;
        }

        //public void setSavingsNo(string savingsNo)
        //{
        //    this.txtSavingsNo.Text = savingsNo;
        //}

        public void setSavingsTypeName(string savingsName)
        {
            this.txtSavingsName.Text = savingsName;
        }

        public void setInterest(string interest)
        {
            if (interest.Length != 0)
            {
                interest = this.amountFormatter(interest);
            }
            this.txtInterest.Text = interest;
        }

        //public void setStartEarning(string startEarning)
        //{
        //    if (startEarning.Length != 0)
        //    {
        //        startEarning = this.amountFormatter(startEarning);
        //    }
        //    txtStartEarning.Text = startEarning;
        //}

        public void setMaintainingBalance(string maintainingBalance)
        {
            if (maintainingBalance.Length != 0)
            {
                maintainingBalance = this.amountFormatter(maintainingBalance); ;
            }

            txtMaintainingBalance.Text = maintainingBalance;
        }

        public void setMaxWithdrawal(string maxWithdrawal)
        {
            if (maxWithdrawal.Length != 0)
            {
               maxWithdrawal = amountFormatter(maxWithdrawal);
            }
            txtMaxWithdrawal.Text = maxWithdrawal;
        }

        public string amountFormatter(string text)
        {
            double deduction = Convert.ToDouble(text);
            double truncated = Math.Truncate(deduction * 100) / 100;
            text = String.Format("{0:0.00}", truncated);
            return text;
        }

        public void setIsPercentage(int isPercentage)
        {
            if (isPercentage == 0)
            {
                rbtnFixed.Checked = true;
            }

            else if (isPercentage == 1)
            {
                rbtnPercentage.Checked = true;
            }
        }

        public void setSavingsTypeInfo(DataSet ds)
        {
            dgSavingsType.DataSource = ds.Tables[0];
            dgSavingsType.Columns["Interest Rate"].DefaultCellStyle.Format = "0.00";
            dgSavingsType.Columns[0].Visible = false;
        }

        public string getSearchBox()
        {
            return txtSearchBox.Text;
        }

        public string getSelectedItem()
        {
            return cboFilter.SelectedItem.ToString();
        }

        public void disableMaxWithdrawal()
        {
            txtMaxWithdrawal.Enabled = false;
            cboWithdrawDuration.Enabled = false;
            //txtWithdrawLimit.Enabled = false;
            txtMaxWithdrawal.Text = "";
            //txtWithdrawLimit.Text = "";
        }

        public void setChkWithdrawalEvent(EventHandler e)
        {
            chkWithdrawalLimit.CheckedChanged += e;
        }

        public void enableMaxWithdrawal()
        {
            chkWithdrawalLimit.Checked = false;
            txtMaxWithdrawal.Enabled = true;
            cboWithdrawDuration.Enabled = true;
            //txtWithdrawLimit.Enabled = true;
        }

        public void clearRadioButton()
        {
            rbtnActive.Checked = false;
            rbtnFixed.Checked = false;
            rbtnInactive.Checked = false;
            rbtnPercentage.Checked = false;
        }

        public DataGridView getSavingsTypeInfo()
        {
            return dgSavingsType;
        }

        public string getSavingsTypeName()
        {
            return txtSavingsName.Text.Trim();
        }

        public string getInterest()
        {
            return txtInterest.Text;
        }

        public string getMaintainingBalance()
        {
            return txtMaintainingBalance.Text;
        }

        public string getMaxWithdrawal()
        {
            return txtMaxWithdrawal.Text;
        }

        public int getIsPercentage()
        {
            int isPercentage = 0;
            if (rbtnPercentage.Checked)
            {
                isPercentage = 1;
            }

            else if (rbtnFixed.Checked)
            {
                isPercentage = 0;
            }
            return isPercentage;
        }

        public void setWithdrawDuration(string index)
        {
            cboWithdrawDuration.SelectedIndex = Convert.ToInt32(index)-1;
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

            else if (rbtnInactive.Checked)
            {
                status = "0";
            }
            return status;
        }

        public int getWithdrawDuration()
        {
            return cboWithdrawDuration.SelectedIndex + 1;
        }

        //============== DISABLE & ENABLE BTN================
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

        public void setNoAccountHolders(string text)
        {
            txtNoAccountHolder.Text = text;
        }

        public string getNoAccountHolders()
        {
            return txtNoAccountHolder.Text;
        }

        public void setNoWithdrawalLimit(string text)
        {
            double num = Convert.ToDouble(text);
            if (num == 0)
            {
                chkWithdrawalLimit.Checked = true;
            }

            else
            {
                chkWithdrawalLimit.Checked = false;
            }
        }

        public bool getNoWithdrawalLimit()
        {
            bool check = false;
            if (chkWithdrawalLimit.Checked)
            {
                check = true;
            }
            return check;
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

        public void setTxtSavingsName(EventHandler e)
        {
            txtSavingsName.Leave += e;
        }

        public void setDataGridEvent(DataGridViewCellEventHandler e)
        {
            dgSavingsType.CellDoubleClick += e;
        }

        //Duration(DropDown)
        public void errDuration()
        {
            Duration.Visible = true;
        }

        public void unDuration()
        {
            Duration.Visible = false;
        }

        //SavingsTypeName
        public void errSavingsTypeName()
        {
            txtSavingsName.BackColor = Color.Salmon;
        }

        public void unSavingsTypeName()
        {
            txtSavingsName.BackColor = Color.White;
        }
        //AccountHolders
        public void errAccountHolders()
        { 
            txtNoAccountHolder.BackColor = Color.Salmon;
        }

        public void unAccountHolders()
        {
            txtNoAccountHolder.BackColor = Color.White;
        }
        //MaxWithdrawalAmount
        public void errMaxWithdrawalAmount()
        {
            txtMaxWithdrawal.BackColor = Color.Salmon;
        }

        public void unMaxWithdrawalAmount()
        {
            txtMaxWithdrawal.BackColor = Color.White;
        }
        //WithdrawalLimit
        //public void errWithdrawalLimit()
        //{
        //    txtWithdrawLimit.BackColor = Color.Salmon;
        //}

        //public void unWithdrawalLimit()
        //{
        //    txtWithdrawLimit.BackColor = Color.White;
        //}
        ////MinimumWithrawalAmount
        //public void errMinimumWithdrawalAmount()
        //{
        //    txtMinimumWithdrawal.BackColor = Color.Salmon;
        //}

        //public void unMinimumWithrawalAmount()
        //{
        //    txtMinimumWithdrawal.BackColor = Color.White;
        //}
        //MaintainingBalance
        public void errMaintainingBalance()
        {
            txtMaintainingBalance.BackColor = Color.Salmon;
        }

        public void unMaintainingBalance()
        {
            txtMaintainingBalance.BackColor = Color.White;
        }
        //Interest
        public void errInterest()
        {
            txtInterest.BackColor = Color.Salmon;
        }

        public void unInterest()
        {
            txtInterest.BackColor = Color.White;
        }
        //StartEarningAt
        //public void errStartEarningAt()
        //{
        //    txtStartEarning.BackColor = Color.Salmon;
        //}

        //public void unStartEarningAt()
        //{
        //    txtStartEarning.BackColor = Color.White;
        //}
        //Status
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
            if (rbtnActive.Checked == false && rbtnInactive.Checked == false)
                i = 1;
            return i;
        }
        //Percentage
        public void errPercentage()
        {
            percentagePanel.BackColor = Color.Salmon;
        }

        public void unPercentage()
        {
            percentagePanel.BackColor = Color.White;
        }

        public int percentage()
        {
            int i = 0;
            if (rbtnFixed.Checked == false && rbtnPercentage.Checked == false)
                i = 1;
            return i;
        }
        //withdrawalLimit
        public void errWithdrawLimit()
        {
            NoWithdrawalLimitPanel.BackColor = Color.Salmon;
        }

        public void unWithdrawLimit()
        {
            NoWithdrawalLimitPanel.BackColor = Color.White;
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

        private void txtSavingsName_Validating_1(object sender, CancelEventArgs e)
        {
            setSavingsTypeName(txtSavingsName.Text.Trim());
        }

        public string getName()
        {
            string result = "";
            char[] str = txtSavingsName.Text.ToCharArray();
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ' ')
                { }
                else
                    result += str[i];
            }
            return result.ToLower();
        }

        private void txtNoAccountHolder_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void txtMaxWithdrawal_KeyPress_1(object sender, KeyPressEventArgs e)
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

        private void txtMaintainingBalance_KeyPress_1(object sender, KeyPressEventArgs e)
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

        private void txtInterest_KeyPress(object sender, KeyPressEventArgs e)
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
