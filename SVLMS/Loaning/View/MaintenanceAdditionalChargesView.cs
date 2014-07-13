using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SVLMS.Loaning.View
{
    public partial class MaintenanceAdditionalChargesView : Form
    {
        public MaintenanceAdditionalChargesView()
        {
            InitializeComponent();
            dgCharges.ReadOnly = true;
            dgCharges.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            cboFilter.SelectedIndex = 0;
        }

        public string getCboFilter()
        {
            return cboFilter.SelectedItem.ToString();
        }

        public string getTextSearch()
        {
            return txtSearch.Text;
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
            dgCharges.CellDoubleClick += e;
        }

        public void setCboFilterEvent(EventHandler e)
        {
            cboFilter.SelectedIndexChanged += e;
        }

        public void setTxtSearchEvent(EventHandler e)
        {
            txtSearch.TextChanged += e;
        }

        public string amountFormatter(string text)
        {
            double deduction = Convert.ToDouble(text);
            double truncated = Math.Truncate(deduction * 100) / 100;
            text = String.Format("{0:0.00}", truncated);
            return text;
        }

        public CheckedListBox getCheckListBox()
        {
            return listLoanTypes;
        }

        public void setCheckListBox(CheckedListBox chklistBox)
        {
            listLoanTypes = chklistBox;
        }

        //================= DG ============================
        public void setDataGrid(DataSet ds)
        {
            dgCharges.DataSource = ds.Tables[0];
            dgCharges.Columns[0].Visible = false;
            dgCharges.Columns["Charge Amount"].DefaultCellStyle.Format = "N2";
        }

        public DataGridView getDataGrid()
        {
            return dgCharges;
        }

        //================= SET & GET ============================



        public void setlistbox(DataSet ds)
        {
            listLoanTypes.DataSource = ds.Tables[0];
            listLoanTypes.ValueMember = "loanTypeID";
            listLoanTypes.DisplayMember = "loanName";

            //ArrayList additionalCharges = new ArrayList();
            //additionalCharges.Add(new AdditionalCharges("0","All"));
            //for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            //    additionalCharges.Add(new AdditionalCharges(ds.Tables[0].Rows[i][0].ToString(), ds.Tables[0].Rows[i][1].ToString()));
            //listLoanTypes.DataSource = additionalCharges;
            //listLoanTypes.ValueMember = "ChargeID";
            //listLoanTypes.DisplayMember = "ChargeName";
        }

        public void setChkApplicableAllEvent(EventHandler e)
        {
            chkApplicableAll.Click += e;
        }

        public bool isApplicableToAll()
        {
            bool chk = false;
            if (chkApplicableAll.Checked)
            {
                chk = true;
            }

            else
            {
                chk = false;
            }
            return chk;
        }

        public void setchecklistbox(List<int> list)
        {


            int value = 0;

            for (int i = 0; i < listLoanTypes.Items.Count; i++)
            {

                DataRowView view = listLoanTypes.Items[i] as DataRowView;
                value = (int)view["loanTypeID"];
                if (list.Contains(value))
                {
                    listLoanTypes.SetItemChecked(i, true);
                }
                else
                {
                    listLoanTypes.SetItemChecked(i, false);
                }
            }
            chkApplicableAll.Checked = false;
        }

        public List<int> getchecklistselected()
        {
            List<int> a = new List<int>();
            foreach (DataRowView checkedItem in listLoanTypes.CheckedItems)
            {
                a.Add(int.Parse(checkedItem[listLoanTypes.ValueMember].ToString()));
            }
            return a;
        }

        public String getlistbox()
        {
            return listLoanTypes.SelectedValue.ToString();
        }

        //public void setChargeID(string chargeID)
        //{
        //    txtChargeID.Text = chargeID;
        //}

        //public string getChargeID()
        //{
        //    return txtChargeID.Text;
        //}

        public void setChargeName(string chargeName)
        {
            txtChargeName.Text = chargeName;
        }

        public void setChargeID(string chargeID)
        {
            txtChargeID.Text = chargeID;
        }

        public string getChargeName()
        {
            return txtChargeName.Text;
        }

        public void setAmount(string amount)
        {
            if (amount.Length != 0)
            {
                amount = this.amountFormatter(amount);
            }
            txtAmount.Text = amount;
        }

        public string getAmount()
        {
            return txtAmount.Text;
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
            if (rbtnFixed.Checked)
            {
                isPercentage = "0";
            }

            else
            {
                isPercentage = "1";
            }

            return isPercentage;
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



        //==================== BTN ===============================


        public void enableBtnAdd()
        {
            btnSave.Enabled = true;
        }

        public void disableBtnAdd()
        {
            btnSave.Enabled = false;
        }

        public void enableBtnUpdate()
        {
            btnUpdate.Enabled = true;
        }

        public void disableBtnUpdate()
        {
            btnUpdate.Enabled = true;
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

        public void resetRadioButton()
        {
            rbtnPercentage.Checked = false;
            rbtnFixed.Checked = false;
            rbtnActive.Checked = false;
            rbtnInactive.Checked = false;
        }
        //---------------------------------------VALIDATION---------------------------------------
        //ChargeName
        public void errChargeName()
        {
            txtChargeName.BackColor = Color.Salmon;
        }

        public void unChargeName()
        {
            txtChargeName.BackColor = Color.White;
        }
        //AMount
        public void errAmount()
        {
            txtAmount.BackColor = Color.Salmon;
        }

        public void unAmount()
        {
            txtAmount.BackColor = Color.White;
        }
        //PercentageFixed
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
        //ActiveInactive
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

        private void txtChargeName_Validating(object sender, CancelEventArgs e)
        {
            setChargeName(txtChargeName.Text.Trim());
        }

        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
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

    public partial class AdditionalCharges
    {
        private string chargeID;
        private string chargeName;

        public AdditionalCharges(string chargeID, string chargeName)
        {
            this.chargeID = chargeID;
            this.chargeName = chargeName;
        }

        public string ChargeID
        {
            get
            {
                return chargeID;
            }
        }

        public string ChargeName
        {
            get
            {
                return chargeName;
            }
        }
    }
}
