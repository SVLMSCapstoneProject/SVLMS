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
using SVLMS.Loaning.Model;
using SVLMS.Loaning.Controller;
namespace SVLMS.Loaning.View
{
    public partial class TransactionLoanApplicationView : Form
    {

        public TransactionLoanApplicationView()
        {
            InitializeComponent();
            //cboIntervalPayment.SelectedIndex = 0;
            cboStatus.SelectedIndex = 0;
            CboSearchBy.SelectedIndex = 0;
            cboOperation.SelectedIndex = 0;
            cboInterval.SelectedIndex = 0;
            cboIntervalPayment.SelectedIndex = 0;
        }
        TransactionLoanApprovalView formatter = new TransactionLoanApprovalView();

        // GET VALUES FROM TEXTBOX

        public string getSearchBy()
        {
            return CboSearchBy.SelectedItem.ToString();
        }

        public string getTxtSearch()
        {
            return txtSearch.Text;
        }

        public string getAccountNo()
        {
            return txtAccountNo.Text;
        }

        public string getMemberName()
        {
            return txtMemberName.Text;
        }

        public string getComakerFamily()
        { 
            return txtComakerFamily.Text;
        }

        public string getComakerMember()
        {
            return txtComakerMember.Text;
        }

        //public string getCollateral()
        //{
        //    //return (cboCollateral.SelectedIndex + 1).ToString();
        //    return cboCollateral.SelectedValue.ToString();
        //}

        public void setCboStatusEvent(EventHandler e)
        {
            cboStatus.SelectedIndexChanged += e;
        }

        public void enableApprovedAmount()
        {
            txtApprovedAmount.Enabled = true;
        }

        public void disableApprovedAmount()
        {
            txtApprovedAmount.Enabled = false;
            txtApprovedAmount.Text = "";
        }

        public void setStatus(string index)
        {
            cboStatus.SelectedIndex = Convert.ToInt32(index);
        }

        public string getStatus()
        {
            return (cboStatus.SelectedIndex+1).ToString();
        }

        public void setRemarks(string text)
        {
            txtRemarks.Text = text;
        }

        public string getRemarks()
        {
            return txtRemarks.Text;
        }

        public void setApprovedAmount(string text)
        {
            if (text.Trim().Length != 0)
            {
                text = Validator.truncateNumber(text).ToString();
            }
            txtApprovedAmount.Text = text;
        }

        public string getApprovedAmount()
        {
            return txtApprovedAmount.Text;
        }

        public string getCollateral()
        {
            return txtCollateral.Text;
        }

        public string getCollateralDescription()
        {
            return txtCollateralDescription.Text;
        }

        public string getDateOfApplication()
        {
            return dtpLoanDate.Value.ToString();
        }

        public string getApplicableLoanType()
        {
            string loanType = "";
            if (cboApplicableLoans.SelectedValue != null)
            {
                loanType = cboApplicableLoans.SelectedValue.ToString();
            }
            return loanType;
        }

        public string getRequestedAmount()
        {
            return txtRequestedAmount.Text;
        }

        public string getTermsOfPayment()
        {
            return txtTermsOfPayment.Text;
        }

        //public string getSavingsAccount()
        //{
        //    string savingsAccountNo = "";
        //    if (cboSavingsAccount.SelectedValue != null)
        //    {
        //        savingsAccountNo = cboSavingsAccount.SelectedValue.ToString();
        //    }
        //    return savingsAccountNo;
        //}

        public string getIntervalOfPayment()
        {
            //return (cboIntervalPayment.SelectedIndex + 1).ToString();        
            //return cboIntervalPayment.SelectedValue.ToString();
            string interval = "";
            if (cboIntervalPayment.SelectedItem.ToString() == "Weekly")
            {
                interval = "2";
            }

            else if (cboIntervalPayment.SelectedItem.ToString() == "Semi-monthly")
            {
                interval = "5";
            }

            else if (cboIntervalPayment.SelectedItem.ToString() == "Monthly")
            {
                interval = "3";
            }
            return interval;
        }

        //public string getlblSavings()
        //{
        //    return lblSavings.Text;
        //}

        public DataGridView getdgMembers()
        {
            return dgMembers;
        }

        // SET VALUES TO TEXTBOX
        public void setAccountNo(string text)
        {
            this.txtAccountNo.Text = text;
        }

        public void setMemberName(string text)
        {
            this.txtMemberName.Text = text;
        }

        //public void setCollateral(string text)
        //{
        //    this.cboCollateral.SelectedItem = text;
        //}

        public void setCollateral(string text)
        {
            txtCollateral.Text = text;
        }

        public void setCollateralDescription(string text)
        {
            txtCollateralDescription.Text = text;
        }

        public void setComakerFamily(string text)
        {
            this.txtComakerFamily.Text = text;
        }

        public void setComakerMember(string text)
        {
            this.txtComakerMember.Text = text;
        }

        public void setDateOfApplication(string text)
        {
            this.dtpLoanDate.Value = Convert.ToDateTime(text);
        }

        public void setLoantype(string text)
        {
            this.cboApplicableLoans.SelectedItem = text;
        }

        public void setLoanTypeValue(string text)
        {
            cboApplicableLoans.SelectedValue = text;
        }

        public void setRequestedAmount(string text)
        {
            if (text.Length != 0)
            {
                text = Validator.truncateNumber(text).ToString();
            }

            this.txtRequestedAmount.Text = text;
        }

        public void setTermsOfPayment(string text)
        {
            this.txtTermsOfPayment.Text = text;
        }

        //public void setSavingsAccount(string text)
        //{
        //    this.cboSavingsAccount.SelectedItem = text;
        //}

        //public void setIntervalOfPayment(DataSet ds)
        //{
        //    //this.cboIntervalPayment.SelectedItem = text;
        //    if (ds != null)
        //    {
        //        cboIntervalPayment.DisplayMember = "indicatorDesc";
        //        cboIntervalPayment.ValueMember = "indicatorID";
        //        cboIntervalPayment.DataSource = ds.Tables[0];
        //        cboInterval.DisplayMember = "indicatorDesc";
        //        cboInterval.ValueMember = "indicatorID";
        //        cboInterval.DataSource = ds.Tables[0];
        //    }
        //}

        public void setIntervalOfPayment(string value)
        {
            MessageBox.Show(value);
            if (value == "2")
            {
                cboIntervalPayment.SelectedIndex = 0;//cboIntervalPayment.FindStringExact("Weekly");
            }

            else if (value == "5")
            {
                cboIntervalPayment.SelectedIndex = 1;//cboIntervalPayment.FindStringExact("Semi-monthly");
            }

            else if (value == "3")
            {
                cboIntervalPayment.SelectedIndex = 2;// cboIntervalPayment.FindStringExact("Monthly");
            }
        }

        //public void setlblSavings(string text)
        //{
        //    try
        //    {
        //        double num = Convert.ToDouble(text);
        //        text = formatter.amountFormatter(text);
        //    }
        //    catch (Exception)
        //    {
                
        //    }
        //    this.lblSavings.Text = text;
        //}

        public void setDgMembers(DataSet ds)
        {
            dgMembers.DataSource = ds.Tables[0];
            dgMembers.Columns[3].DefaultCellStyle.Format = "0.00";
            //dgMembers.Columns[3].Visible = false;
        }

        //public void setCboSavingsAccount(DataSet ds)
        //{
        //    if (ds != null)
        //    {

        //        cboSavingsAccount.DisplayMember = "savingsName";
        //        cboSavingsAccount.ValueMember = "savingsAccountNo";
        //        cboSavingsAccount.DataSource = ds.Tables[0];
        //    }

        //    else
        //    {
        //        cboSavingsAccount.DataSource = null;
        //        cboSavingsAccount.Refresh();
        //    }
        //}

        public void hideDataGridColumnIndex(int index)
        {
            dgMembers.Columns[index].Visible = false;
        }

        //public DataRowView getCboSavingsType()
        //{
        //    return (cboSavingsAccount.SelectedItem as DataRowView);
        //}

        //public void setCboCollateral(DataSet ds)
        //{
        //    if (ds != null)
        //    {
        //        cboCollateral.DisplayMember = "collateralName";
        //        cboCollateral.ValueMember = "collateralID";
        //        cboCollateral.DataSource = ds.Tables[0];
        //    }

        //    else
        //    {
        //        cboCollateral.DataSource = null;
        //        cboCollateral.DataBindings.Clear();
        //        cboCollateral.Refresh();
        //    }
        //}

        //public DataRowView getCboCollateral()
        //{
        //    return (cboCollateral.SelectedItem as DataRowView);
        //}

        public void setCboLoanType(DataSet ds)
        {
            cboLoanType.DisplayMember = "loanName";
            cboLoanType.ValueMember = "loanTypeID";
            cboLoanType.DataSource = ds.Tables[0];
        }

        public void setCboApplicableLoans(DataSet ds)
        {
            if (ds != null)
            {
                cboApplicableLoans.DisplayMember = "loanName";
                cboApplicableLoans.ValueMember = "loanTypeID";
                cboApplicableLoans.DataSource = ds.Tables[0];
                
            }

            else
            {
                cboApplicableLoans.DataSource = null;
                cboApplicableLoans.Refresh();
            }
        }

        public DataRowView getCboLoanType()
        {
            return (cboApplicableLoans.SelectedItem as DataRowView);
        }

        public void setDataGridEvent(DataGridViewCellEventHandler e)
        {
            dgMembers.CellDoubleClick += e;
        }

        public void setTextSearchEvent(EventHandler e)
        {
            txtSearch.TextChanged += e;
        }

        public void setBtnComakerFamilyEvent(EventHandler e)
        {
            btnComakerFamily.Click += e;
        }

        public void setBtnComakerMemberFamily(EventHandler e)
        {
            btnComakerMember.Click += e;
        }

        public void cboLoanTypeSelectionChangedEvent(EventHandler e)
        {
            cboApplicableLoans.SelectionChangeCommitted += e;
        }

        public void setCboOperationEvent(EventHandler e)
        {
            cboOperation.SelectionChangeCommitted += e;
        }

        public int getCboOperationIndex()
        {
            return cboOperation.SelectedIndex;
        }

        public void enableCollateral()
        {
            txtCollateral.Enabled = true;
            txtCollateralDescription.Enabled = true;
        }

        public void disableCollateral()
        {
            txtCollateral.Enabled = false;
            txtCollateralDescription.Enabled = false;
            txtCollateral.Text = "";
            txtCollateralDescription.Text = "";
        }

        public void enableComaker()
        {
            txtComakerFamily.Text = "";
            txtComakerMember.Text = "";
            btnComakerFamily.Enabled = true;
            btnComakerMember.Enabled = true;
            txtBlkNo.Enabled = true;
            txtStreet.Enabled = true;
            txtBrgy.Enabled = true;
            txtCity.Enabled = true;
            txtBlkNo.Text = "";
            txtStreet.Text = "";
            txtCity.Text = "";
            txtBrgy.Text = "";
        }

        public void disableComaker()
        {
            txtComakerFamily.Text = "";
            txtComakerMember.Text = "";
            btnComakerFamily.Enabled = false;
            btnComakerMember.Enabled = false;
            txtBlkNo.Enabled = false;
            txtStreet.Enabled = false;
            txtBrgy.Enabled = false;
            txtCity.Enabled = false;
            txtBlkNo.Text = "";
            txtStreet.Text = "";
            txtCity.Text = "";
            txtBrgy.Text = "";
        }

        public void setBtnSaveEvent(EventHandler e)
        {
            btnSave.Click += e;
        }

        public void setBtnClearEvent(EventHandler e)
        {
            btnClear.Click += e;
        }

        public void setBtnComputeAmortization(EventHandler e)
        {
            btnComputeAmortization.Click += e;
        }

        public void focusTabAmortization()
        {
            tab.SelectedIndex = (tab.SelectedIndex + 1);
        }

        public void setDataGridAmortization(string[,] array)
        {
            
            dgLoanAmortization.Columns.Clear();
            dgLoanAmortization.Rows.Clear();
            dgLoanAmortization.Refresh();


            int length = array.GetLength(0);
            dgLoanAmortization.Columns.Add("DueDate", "Due Date");
            //dgLoanAmortization.Columns.Add("Principal","Principal");
            //dgLoanAmortization.Columns.Add("Interest","Interest");
            //dgLoanAmortization.Columns.Add("Savings","Savings");
            //dgLoanAmortization.Columns.Add("ShareCapital","Share Capital");
            dgLoanAmortization.Columns.Add("Amortization", "Amortization");

            for (int x = 0; x < length; x++)
            {
                //dgLoanAmortization.Rows.Add(array[x, 0],array[x, 1], array[x, 2], array[x, 3], array[x, 4], array[x, 5]);
                dgLoanAmortization.Rows.Add(array[x, 0], formatter.amountFormatter(array[x, 4]));
            }
        }

        public void setLblLoanAmount(string text)
        {
            try
            {
                double amount = Convert.ToDouble(text);
                text = formatter.amountFormatter(text);
            }
            catch (Exception)
            {
                
            }
            lblLoanAmount.Text = text;
        }

        //public void setLblSavings(string text)
        //{
        //    try
        //    {
        //        double amount = Convert.ToDouble(text);
        //        text = formatter.amountFormatter(text);
        //    }
        //    catch (Exception)
        //    {

        //    }
        //    lblSavings.Text = text;
        //}

        public void setLblShareCapital(string text)
        {
            try
            {
                double amount = Convert.ToDouble(text);
                text = formatter.amountFormatter(text);
            }
            catch (Exception)
            {

            }
            lblShareCapital.Text = text;
        }

        public void setLblTotalInterest(string text)
        {
            try
            {
                double amount = Convert.ToDouble(text);
                text = formatter.amountFormatter(text);
            }
            catch (Exception)
            {

            }
            lblTotalInterest.Text = text;
        }

        public void setLblTotalAmount(string text)
        {
            try
            {
                double amount = Convert.ToDouble(text);
                text = formatter.amountFormatter(text);
            }
            catch (Exception)
            {

            }
            lblTotalAmount.Text = text;
        }

        public void setLoanNo(string text)
        {
            txtLoanNo.Text = text;
        }

        public string getLoanNo()
        {
            return txtLoanNo.Text;
        }

        public void clearAmortization()
        {
            dgLoanAmortization.Columns.Clear();
            dgLoanAmortization.Rows.Clear();
            dgLoanAmortization.Refresh();
        }

        public void searchByCreate()
        {
            CboSearchBy.Items.Clear();
            CboSearchBy.Items.Add("Account No");
            CboSearchBy.Items.Add("Member Name");
            CboSearchBy.SelectedIndex = 0;
        }

        public void searchByUpdate()
        {
            CboSearchBy.Items.Clear();
            CboSearchBy.Items.Add("Loan No");
            CboSearchBy.Items.Add("Member Name");
            CboSearchBy.SelectedIndex = 0;
        }

        public void setBlkNo(string text)
        {
            txtBlkNo.Text = text;
        }

        public void setStreet(string text)
        {
            txtStreet.Text = text;
        }

        public void setBrgy(string text)
        {
            txtBrgy.Text = text;
        }

        public void setCity(string text)
        {
            txtCity.Text = text;
        }

        public string getBlkNo()
        {
            return txtBlkNo.Text;
        }

        public string getStreet()
        {
            return txtStreet.Text;
        }

        public string getCity()
        {
            return txtCity.Text;
        }

        public string getBrgy()
        {
            return txtBrgy.Text;
        }

        public void enableBtnSave()
        {
            btnSave.Enabled = true;
        }

        public void disableBtnSave()
        {
            btnSave.Enabled = false;
        }

        public string getComputeLoanType()
        {
            return cboLoanType.SelectedValue.ToString();
        }

        public string getComputeLoanAmount()
        {
            return txtLoanAmount.Text;
        }

        public string getComputeTermsOfPayment()
        {
            return txtTerms.Text;
        }

        public string getComputeInterval()
        {
            string interval = "";
            if (cboInterval.SelectedItem.ToString() == "Weekly")
            {
                interval = "2";
            }

            else if (cboInterval.SelectedItem.ToString() == "Semi-monthly")
            {
                interval = "5";
            }

            else if (cboInterval.SelectedItem.ToString() == "Monthly")
            {
                interval = "3";
            }

            return interval;
        }

        public void setLoanNoPrevious(string text)
        {
            txtLoanNoPrevious.Text = text;
        }

        public void setLoanTypePrevious(string text)
        {
            txtLoanTypePrevious.Text = text;
        }

        public void setMaturityDatePrevious(string text)
        {
            txtMaturityPrevious.Text = text;
        }

        public void setCurrentBalancePrevious(string text)
        {
            txtCurrentBalancePrevious.Text = text;
        }

        public void setShareCapital(string text)
        {
            if (text.Length != 0)
            {
                text = Validator.amountFormatter(text);
            }
            txtShareCapital.Text = text;
        }

        public void setRequestedAmountTooltip(string text)
        {
            toolTip1.SetToolTip(txtRequestedAmount, text);
            toolTip1.SetToolTip(txtApprovedAmount, text);
        }

        public void setTermsTooltip(string text)
        {
            toolTip1.SetToolTip(txtTermsOfPayment, text);
        }

        public void setLblEligibility(string text)
        {
            lblEligibility.Text = text;
        }
    }
}
