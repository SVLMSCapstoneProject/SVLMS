using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SVLMS.Loaning;
using SVLMS.Loaning.View;

namespace SVLMS.Loaning.View
{
    public partial class MaintenanceLoanTypeView : Form
    {
        public MaintenanceLoanTypeView()
        {
            InitializeComponent();
            dgLoantype.ReadOnly = true;
            dgLoantype.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            cboFilter.SelectedIndex = 0;
        }

        public void setBtnAddEvent(EventHandler e)
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
            dgLoantype.CellDoubleClick += e;
        }

        public void setCboFilterEvent(EventHandler e)
        {
            cboFilter.SelectedIndexChanged += e;
        }

        public void setTxtSearchEvent(EventHandler e)
        {
            txtSearch.TextChanged += e;
        }

        public string getCboFilter()
        {
            return cboFilter.SelectedItem.ToString();
        }

        public string[] getMemberType()
        {
            int count = listUnselected.CheckedItems.Count;
            string[] value = new string[count];
            int x = 0;
            foreach (var item in listUnselected.CheckedItems)
            { 
                var row = (item as DataRowView).Row;
                value[x] = row["TypeID"].ToString(); 
               // MessageBox.Show(row["TypeID"].ToString());
                x++;
            }   

            return value;
        }

        public void setApplicable(List<int> list)
        {
            int value = 0;
            for (int i = 0; i < listUnselected.Items.Count; i++)
			{
			    DataRowView view = listUnselected.Items[i] as DataRowView;
                value = (int)view["TypeID"];
                if(list.Contains(value))
                 {
                   listUnselected.SetItemChecked(i,true);
                 }
                 else
                 {
                   listUnselected.SetItemChecked(i,false);
                 }
			}
        }

        public void getLoanApplicableInfo(DataSet ds)
        { 
            
        }

        public void disableEntitlement()
        {
            txtLoanEntitlement.Enabled = false;
            txtLoanEntitlement.Text = "";
            //rbtnLoanEntitleFixed.Enabled = false;
            //rbtnLoanEntitlePercentage.Enabled = false;
            //rbtnLoanEntitleFixed.Checked = false;
            //rbtnLoanEntitlePercentage.Checked = false;
        }

        public void enableEntitlement()
        {
            txtLoanEntitlement.Enabled = true;
            //rbtnLoanEntitleFixed.Enabled = true;
            //rbtnLoanEntitlePercentage.Enabled = true;
        }

        public void setMemberType(DataSet ds)
        {
            listUnselected.DataSource = ds.Tables[0];
            listUnselected.ValueMember = "TypeID";
            listUnselected.DisplayMember = "MemberType";
        }

        public void clearCheckBoxes()
        {
            chkNoEntitlement.Checked = false;
        }

        //================= BTN ===================================
        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        public void setNoEntitlement(string text)
        {
            if (text == "0")
            {
                chkNoEntitlement.Checked = true;
            }

            else
            {
                chkNoEntitlement.Checked = false;
            }
        }

        public void setChkEntitlementEvent(EventHandler e)
        {
            chkNoEntitlement.CheckedChanged += e;
        }

        public bool getNoEntitlement()
        {
            bool check = false;
            if (chkNoEntitlement.Checked)
            {
                check = true;
            }
            return check;
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


        //-------------- DG BTN -------------
        
        private void dgLoantype_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {

        }

        //=================== Data Grid View GetSET ==============================
        public DataGridView getLoanTypeInfo()
        {
            return dgLoantype;
        }

        public void setLoanTypeInfo(DataSet ds)
        {
            dgLoantype.DataSource = ds.Tables[0];
            dgLoantype.Columns[0].Visible = false;
            dgLoantype.Columns["Min Amount"].DefaultCellStyle.Format = "0.00";
            dgLoantype.Columns["Max Amount"].DefaultCellStyle.Format = "0.00";
         ///   MessageBox.Show(ds.Tables[0].ToString());
        }
        //========================= GET ===========================
       
        //public string getLoanId()
        //{
        //    return txtLoanTypeId.Text;
        //}

        public string getLoanName()
        {
            return txtLoanName.Text;
        }

        public string getMinAmount()
        {
            return txtMinAmount.Text;
        }

        public string getMaxAmount()
        {
            return txtMaxAmount.Text;
        }

        public string getMaxTerm()
        {
            return txtMaxTerm.Text;
        }

        //public int isMaxTerm()
        //{
        //    int isMaxTerm = 0;
        //    if (rbtnMonths.Checked)
        //    {
        //        isMaxTerm = 1;
        //    }
        //    if (rbtnYears.Checked)
        //    {
        //        isMaxTerm = 0;
        //    }
        //    return isMaxTerm;
        //}

        public int hasCoMaker()
        {
            int hasComaker = 0;
            if (rbtnCoMakerYes.Checked)
            {
                hasComaker = 1;
            }
            if (rbtnCoMakerNo.Checked)
            {
                hasComaker = 0;
            }
            return hasComaker;
        }

//=================== SET ========================

        public void refresh() 
        {
            rbtnCoMakerNo.Checked = false;
            rbtnCoMakerYes.Checked = false;
            //rbtnMonths.Checked = false;
            //rbtnYears.Checked = false;
            rbtnActive.Checked = false;
            rbtnInactive.Checked = false;
            rbtnYes.Checked = false;
            rbtnNo.Checked = false;
            listUnselected.ClearSelected();
        }
        
        //public void setLoanId(string LoanId)
        //{
        //    this.txtLoanTypeId.Text = LoanId;
        //}

        public void setLoanName(string loanName) 
        {
            this.txtLoanName.Text = loanName;
        }

        public void setMinAmount(string minAmount)
        {
            if (minAmount.Length != 0)
            {
                 minAmount = this.amountFormatter(minAmount);
            }
            this.txtMinAmount.Text = minAmount;
        }

        public void setMaxAmount(string maxAmount)
        {
            if (maxAmount.Length != 0)
            {
                maxAmount = this.amountFormatter(maxAmount);
            }
            this.txtMaxAmount.Text = maxAmount;
        }

        public void setMaxTerm(string maxTerm)
        {
            this.txtMaxTerm.Text = maxTerm;
        }

        //public void setIsMaxTerm(string maxTerm)
        //{
        //    if (maxTerm == "1")
        //    {
        //        rbtnMonths.Checked = true;
        //    }
        //    else
        //    {
        //        rbtnYears.Checked = true;
        //    }
        //}

        public void setIsCoMaker(string comaker)
        {
            if (comaker == "0")
            {
                rbtnCoMakerNo.Checked = true;
            }
            else 
            {
                rbtnCoMakerYes.Checked = true;
            }
        }

        public void setLoanEntitlement(string text)
        {
            if (text.Length != 0)
            {
                text = this.amountFormatter(text);
            }
            txtLoanEntitlement.Text = text;
        }

        public string getLoanEntitlement()
        {
            return txtLoanEntitlement.Text;
        }

        //public void setIsPercentageEntitlement(string isPercentage)
        //{
        //    if (isPercentage == "1")
        //    {
        //        rbtnLoanEntitlePercentage.Checked= true;
        //    }

        //    else if (isPercentage == "0")
        //    {
        //        rbtnLoanEntitleFixed.Checked= true;
        //    }
        //    else
        //    {
        //        rbtnLoanEntitlePercentage.Checked = false;
        //        rbtnLoanEntitleFixed.Checked = false;
        //    }
        //}

        //public int getIsPercentageEntitlement()
        //{
        //    int isPercent = 0;
        //    if (rbtnLoanEntitlePercentage.Checked)
        //    {
        //        isPercent = 1;
        //    }

        //    return isPercent;
        //}

        //public void clearIsPercentageEntitlement()
        //{
        //    rbtnLoanEntitleFixed.Checked = false;
        //    rbtnLoanEntitlePercentage.Checked = false;
        //}

        public string getSearchText()
        {
            return txtSearch.Text;
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

        public void setIsCollateralized(string text)
        {
            if (text == "1")
            {
                rbtnYes.Checked = true;
            }

            else
            {
                rbtnNo.Checked = true;
            }
        }

        public string getIsCollateralized()
        {
            string isCollateralized = "0";
            if (rbtnYes.Checked)
            {
                isCollateralized = "1";
            }

            else
            {
                isCollateralized = "0";
            }
            return isCollateralized;
        }
        
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void rbtnInterestPercentage_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbtnInterestFixed_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbtnCapitalBuildUpPercentage_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbtnCapitalBuildUpFixed_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }


        public string amountFormatter(string text)
        {
            double deduction = Convert.ToDouble(text);
            double truncated = Math.Truncate(deduction * 100) / 100;
            text = String.Format("{0:0.00}", truncated);
            return text;
        }

        //--------------------------------------VALIDATIONS--------------------------------------
        //LoanName
        public void errLoanName()
        {
            txtLoanName.BackColor = Color.Salmon;
        }

        public void unLoanName()
        {
            txtLoanName.BackColor = Color.White;
        }
        //MinimumAmount
        public void errMinimumAmount()
        {
            txtMinAmount.BackColor = Color.Salmon;
        }

        public void unMinimumAmount()
        {
            txtMinAmount.BackColor = Color.White;
        }
        //MaximumAmount
        public void errMaximumAmount()
        {
            txtMaxAmount.BackColor = Color.Salmon;
        }

        public void unMaximumAmount()
        {
            txtMaxAmount.BackColor = Color.White;
        }
        //MaximumTerm
        public void errMaximumTerm()
        {
            txtMaxTerm.BackColor = Color.Salmon;
        }

        public void unMaximumTerm()
        {
            txtMaxTerm.BackColor = Color.White;
        }
        //LoanEntitleMent
        public void errLoanEntitlement()
        {
            txtLoanEntitlement.BackColor = Color.Salmon;
        }

        public void unLoanEntitlement()
        {
            txtLoanEntitlement.BackColor = Color.White;
        }
        ////Duration
        //public void errDuration()
        //{
        //    durationPanel.BackColor = Color.Salmon;
        //}

        //public void unDuration()
        //{
        //    durationPanel.BackColor = Color.CornflowerBlue;
        //}

        //public int duration()
        //{
        //    int i = 0;
        //    if (rbtnMonths.Checked == false && rbtnYears.Checked == false)
        //        i = 1;
        //    return i;
        //}
        //CoMaker
        public void errComaker()
        { 
            comakerPanel.BackColor = Color.Salmon;
        }

        public void unComaker()
        {
            comakerPanel.BackColor = Color.CornflowerBlue;
        }

        public int comaker()
        { 
            int i = 0;
            if (rbtnCoMakerYes.Checked == false && rbtnCoMakerNo.Checked == false)
                i = 1;
            return i;
        }
        //status
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

        public void errCollateral()
        {
            collateraPanel.BackColor = Color.Salmon;
        }

        public void unCollateral()
        {
            collateraPanel.BackColor = Color.CornflowerBlue;
        }

        public int collateral()
        {
            int i = 0;
            if (rbtnYes.Checked == false || rbtnNo.Checked == false)
                i = 1;
            return i;
        }

        public void setLoanEligibility(string text)
        {
            if (text.Length != 0)
            {
                text = Validator.amountFormatter(text);
            }
            txtLoanEligibility.Text = text;
        }

        public string getLoanEligibility()
        {
            return txtLoanEligibility.Text;
        }
        
        //Percentage
        //public void errPercentage()
        //{
        //    percentagePanel.BackColor = Color.Salmon;
        //}

        //public void unPercentage()
        //{
        //    percentagePanel.BackColor = Color.CornflowerBlue;
        //}

        //public int percentage()
        //{
        //    int i = 0;
        //    if (rbtnLoanEntitleFixed.Checked == false && rbtnLoanEntitlePercentage.Checked == false)
        //        i = 1;
        //    return i;
        //}
        //CheckboxLoanEntitlement
        public void errcboxLoan()
        {
            LoanEntitlementPanel.BackColor = Color.Salmon;
        }

        public void uncboxLoan()
        {
            LoanEntitlementPanel.BackColor = Color.CornflowerBlue;
        }

        private void txtMinAmount_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtMaxAmount_KeyPress(object sender, KeyPressEventArgs e)
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
            e.Handled = !(char.IsControl(e.KeyChar) || char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || char.IsWhiteSpace(e.KeyChar));
        }

        private void txtLoanEntitlement_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtLoanName_Validating(object sender, CancelEventArgs e)
        {
            setLoanName(txtLoanName.Text.Trim());
        }
    }
}