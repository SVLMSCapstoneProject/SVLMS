using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SVLMS.Loaning;
using System.Windows.Forms;
using SVLMS.Loaning.View;
using SVLMS.Loaning.Controller;
using SVLMS.Loaning.Model;

namespace SVLMS.Loaning.Controller
{
    class ControllerLoanType
    {
        ModelLoanType model;
        MaintenanceLoanTypeView view;

        bool update;
        string updateTypeName = "";
        public ControllerLoanType(ModelLoanType maltm, MaintenanceLoanTypeView mltv)
        {
            this.model = maltm;
            this.view = mltv;

            this.refreshfields();
            //mltv.enableAdd();
            ///mltv.disableUpdate();
            mltv.Show();
            mltv.setLoanTypeInfo(maltm.getLoanTypeInfo());
            mltv.setChkEntitlementEvent(chkNoEntitlementClicked);
            mltv.setBtnAddEvent(btnSaveClicked);
            mltv.setBtnClearEvent(btnClearClicked);
            mltv.setBtnUpdateEvent(btnUpdateClicked);
            mltv.setDataGridEvent(dgClicked);
            mltv.setMemberType(maltm.getMemberType());
            mltv.setTxtSearchEvent(TxtSearchTextChanged);
            mltv.setCboFilterEvent(CboFilterSelectedIndexChanged);
            mltv.settxtLoanName(txtLoanNameLeave);
            view.enableAdd();
            view.disableUpdate();
        }

        public void txtLoanNameLeave(object sender, EventArgs e)
        {
            int check = LoanTypeName();
            if (update == true)
            {
                int check1 = LoanTypeID();
                if (check1 == 1)
                {
                    view.unLoanName();
                }
                else
                {
                    if (check == 1)
                    {
                        view.errLoanName();
                        MessageBox.Show("There's an existing Loan Type Name");
                    }
                    else
                        view.unLoanName();
                }
            }
            else
            {
                if (check == 1)
                {
                    view.errLoanName();
                    MessageBox.Show("There's an existing Loan Type Name");
                }
                else
                    view.unLoanName();            
            }
        }

        public void CboFilterSelectedIndexChanged(object sender, EventArgs e)
        {
            view.setLoanTypeInfo(model.searchLoanTypeInfo(view.getCboFilter(), view.getSearchText()));
        }

        public void TxtSearchTextChanged(object sender, EventArgs e)
        {
            view.setLoanTypeInfo(model.searchLoanTypeInfo(view.getCboFilter(), view.getSearchText()));
        }

        public void chkNoEntitlementClicked(object sender, EventArgs e)
        {
            if (view.getNoEntitlement())
            {
                view.disableEntitlement();
                //mltv.unPercentage();
                view.unLoanEntitlement();
            }

            else
            {
                view.enableEntitlement();
            }
        }

        public void btnClearClicked(object sender, EventArgs e)
        {
      
            this.refreshfields();
          
        }

        public void dgClicked(object sender, EventArgs e)
        {
            this.refreshfields();

            view.disableAdd();
            view.enableUpdate();
           
            DataGridView dg = view.getLoanTypeInfo();   
            int row = dg.CurrentCell.RowIndex;
            model.loanId = dg.Rows[row].Cells[0].Value.ToString();

            model.searchLoanType();

            view.setLoanName(model.loanName);
            view.setMinAmount(model.minAmount);
            view.setMaxAmount(model.maxAmount);
            view.setMaxTerm(model.maxTerm);
            //mltv.setIsMaxTerm(maltm.hasmaxTerm.ToString());
            view.setIsCoMaker(model.hasCoMaker.ToString());
            view.setIsCollateralized(model.hasCollateral.ToString());
            view.setStatus(model.status);
            view.setLoanEligibility(model.loanEligibility);
            updateTypeName = model.loanName.ToString();
            update = true;

            double entitlement = Convert.ToDouble(model.loanEntitlement);

            if (entitlement == 0)
            {
                view.disableEntitlement();
                view.setNoEntitlement(entitlement.ToString());
            }

            else
            {
                view.enableEntitlement();
                view.setNoEntitlement(entitlement.ToString());
                view.setLoanEntitlement(model.loanEntitlement);
                //mltv.setIsPercentageEntitlement(maltm.isPercentageEntitlement.ToString());
            }

            model.setApplicableLoanInfo();
            view.setApplicable(model.list);
        }

        public void btnSaveClicked(object sender, EventArgs e)
        {
            int check = LoanTypeName();

            this.setModelValues();

            bool perform = PerformAction();

            if (perform == true)
            {
                if (check == 1)
                {
                    view.errLoanName();
                    MessageBox.Show("There's an existing Loan Type Name");
                }
                else
                {
                    if (view.getNoEntitlement() == true)
                    {
                        DialogResult dialogResult = MessageBox.Show("Are you sure of not having a Loan Entitlement?", "No Loan Entitlement", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                        if (dialogResult == DialogResult.Yes)
                        {
                            view.uncboxLoan();
                            model.loanId = model.getLoanId();
                            model.memberTypeID = view.getMemberType();
                            model.insertLoanType();
                            MessageBox.Show("The Record is Successfully Inserted");
                            view.setLoanTypeInfo(model.getLoanTypeInfo());
                            this.refreshfields();
                        }
                        else if (dialogResult == DialogResult.No)
                        {
                            view.errcboxLoan();
                        }
                    }
                    else
                    {
                        view.unCollateral();

                        DialogResult dialogResult = MessageBox.Show("Are you sure of having a Loan Entitlement?", "No Loan Entitlement", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                        if (dialogResult == DialogResult.Yes)
                        {
                            view.uncboxLoan();
                            model.loanId = model.getLoanId();
                            model.memberTypeID = view.getMemberType();
                            model.insertLoanType();
                            MessageBox.Show("The Record is Successfully Inserted");
                            view.setLoanTypeInfo(model.getLoanTypeInfo());
                            this.refreshfields();
                        }
                        else if (dialogResult == DialogResult.No)
                        {
                            view.errcboxLoan();
                        }
                    }
                }
            }
        }

        public void btnUpdateClicked(object sender, EventArgs e)
        {
            int check = LoanTypeID();
            int check1 = LoanTypeName();

            this.setModelValues();

            bool perform = PerformAction();

            if (perform == true)
            {
                if (check == 1)
                {
                    view.unLoanName();
                    Update();
                }
                else
                {
                    if (check1 == 1)
                    {
                        view.errLoanName();
                        MessageBox.Show("There's an existing Loan Type Name");
                    }
                    else
                    {
                        Update();
                    }
                }
            }
        }

        public void setModelValues()
        {
            model.loanName = view.getLoanName();
            model.minAmount = view.getMinAmount();
            model.maxAmount = view.getMaxAmount();
            model.maxTerm = view.getMaxTerm();
            //maltm.hasmaxTerm = mltv.isMaxTerm();
            model.hasCoMaker = view.hasCoMaker();
            model.memberTypeID = view.getMemberType();
            model.hasCollateral = Convert.ToInt32(view.getIsCollateralized());
            model.status = view.getStatus();
            model.loanEligibility = view.getLoanEligibility();

            if (view.getNoEntitlement())
            {
                model.loanEntitlement = "0";
                model.isPercentageEntitlement = 0;   
            }

            else
            {
                model.loanEntitlement = view.getLoanEntitlement();
                model.isPercentageEntitlement = 1;
                //maltm.isPercentageEntitlement = mltv.getIsPercentageEntitlement();
            }

            //MessageBox.Show(maltm.isPercentageEntitlement.ToString());
        }

        public void refreshfields()
        {           
            update = false;
            view.setLoanName("");
            view.setMinAmount("");
            view.setMaxAmount("");
            view.setMaxTerm("");
            view.refresh();
            view.setMinAmount("");
            view.setMaxAmount("");
            view.setLoanEntitlement("");
            //mltv.clearIsPercentageEntitlement();
            //view.setLoanId(model.getLoanId());
            model.list.Clear();
            view.setApplicable(model.list);
            view.enableAdd();
            view.disableUpdate();
            view.clearCheckBoxes();
            view.unStatus();
            //mltv.unPercentage();
            view.unMinimumAmount();
            view.unMaximumTerm();
            view.unMaximumAmount();
            view.unLoanName();
            view.unLoanEntitlement();
            //mltv.unDuration();
            view.unComaker();
            view.uncboxLoan();
            view.unCollateral();
            view.setLoanEligibility("");
        }

        public void Update()
        {
                    if (view.getNoEntitlement() == true)
                    {
                        DialogResult dialogResult = MessageBox.Show("Are you sure of not having a Loan Entitlement?", "No Loan Entitlement", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                        if (dialogResult == DialogResult.Yes)
                        {
                            view.uncboxLoan();
                            model.updateLoanType();
                            view.setLoanTypeInfo(model.getLoanTypeInfo());
                            MessageBox.Show("The Record is Successfully Updated");
                            this.refreshfields();
                        }
                        else if (dialogResult == DialogResult.No)
                        {
                            view.errcboxLoan();
                        }
                    }
                    else
                    {
                        DialogResult dialogResult = MessageBox.Show("Are you sure of not having a Loan Entitlement?", "No Loan Entitlement", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                        if (dialogResult == DialogResult.Yes)
                        {
                            view.uncboxLoan();
                            model.updateLoanType();
                            view.setLoanTypeInfo(model.getLoanTypeInfo());
                            MessageBox.Show("The Record is Successfully Updated");
                            this.refreshfields();
                        }
                        else if (dialogResult == DialogResult.No)
                        {
                            view.errcboxLoan();
                        }
                    }        
        }

        public bool PerformAction()
        {
            bool perform = false;
            int validate = Validate();
            //if No Loan Entitlement is checked
            if (view.getNoEntitlement() == true)
            {
                if (validate == 7)
                {
                    if (Convert.ToDouble(model.maxAmount) < Convert.ToDouble(model.minAmount))
                    {
                        MessageBox.Show("Maximum Amount must be greater than the Minimum Amount.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        view.errMaximumAmount();
                        view.errMinimumAmount();
                    }
                    else
                    {
                        perform = true;
                        view.unMaximumAmount();
                        view.unMinimumAmount();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Input/s", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            //if No Loan Entitlement is not checked
            else
            {
                if (validate == 8)
                {
                    if (Convert.ToDouble(model.maxAmount) < Convert.ToDouble(model.minAmount))
                    {
                        MessageBox.Show("Maximum Amount must be greater than the Minimum Amount.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        view.errMaximumAmount();
                        view.errMinimumAmount();
                    }
                    else
                    {
                        perform = true;
                        view.unMaximumAmount();
                        view.unMinimumAmount();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Input/s", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

            return perform;
        }


        public int Validate()
        {
            this.setModelValues();

            string special = "!@#$%^&*(){}/;:><+=_?.,1234567890";
            bool pass = true;
            int correct = 0;
            int integer;
            double num;

            bool error= false;
            int status = view.status();
            //int percentage = mltv.percentage();
            //int duration = mltv.duration();
            int comaker = view.comaker();
            int collateral = view.collateral();
            //LoanName
            if (string.IsNullOrWhiteSpace(model.loanName))
            {
                view.errLoanName();
            }
            else
            {
                    char[] spec = special.ToCharArray();
                    char[] str = model.loanName.ToCharArray();

                    for (int x = 0; x < special.Length; x++)
                    {
                        for (int i = 0; i < str.Length; i++)
                        {
                            if (str[i] == special[x])
                            {
                                view.errLoanName();
                                pass = false;
                                error = true;
                                x = special.Length;
                                i = str.Length;
                            }
                        }
                    }

                    if (pass)
                    {
                        for (int i = 0; i < str.Length - 1; i++)
                        {
                            if (char.IsLetter(str[i]) || str[i] == ' ' || str[i] == '\'' || str[i] == '-')
                            {
                                view.unLoanName();
                                error = false;
                            }
                            else
                            {
                                view.errLoanName();
                                i = model.loanName.Length;
                                error = true;
                            }
                        }
                    }
                if (error == false)
                {
                    view.unLoanName();
                    correct++;
                }
            }
            //MinimumAmount
            if (string.IsNullOrWhiteSpace(model.minAmount))
            {
                view.errMinimumAmount();
            }
            else
            {
                if (double.TryParse(model.minAmount, out num))
                {
                    if (Convert.ToDouble(model.minAmount) < 0)
                    {
                        view.errMinimumAmount();
                    }
                    else
                    {
                        view.unMinimumAmount();
                        correct++;
                    }
                }
                else
                {
                    view.errMinimumAmount();
                }
            }
            //MaximumAmount
            if (string.IsNullOrWhiteSpace(model.maxAmount))
            {
                view.errMaximumAmount();
            }
            else
            {
                if (double.TryParse(model.maxAmount, out num))
                {
                    if (Convert.ToDouble(model.maxAmount) < 0)
                    {
                        view.errMaximumAmount();
                    }
                    else
                    {
                        view.unMaximumAmount();
                        correct++;
                    }
                }
                else
                {
                    view.errMaximumAmount();
                }
            }
            //LoanEligibility
            if (string.IsNullOrWhiteSpace(model.loanEligibility))
            {
                view.errLoanEligibility();
            }
            else
            {
                if (double.TryParse(model.loanEligibility, out num))
                {
                    if (Convert.ToDouble(model.loanEligibility) < 0)
                    {
                        view.errLoanEligibility();
                    }
                    else
                    {
                        if (Convert.ToDouble(model.loanEligibility) >= 0 && Convert.ToDouble(model.loanEligibility) <= 100)
                        {
                            view.unLoanEligibility();
                            correct++;
                        }
                        else
                        {
                            view.errLoanEligibility();
                        }
                    }
                }
                else
                {
                    view.errLoanEligibility();
                }
            }
            //MaximumTerm
            if (string.IsNullOrWhiteSpace(model.maxTerm))
            {
                view.errMaximumTerm();
            }
            else
            {
                if (int.TryParse(model.maxTerm, out integer))
                {
                    if (Convert.ToInt32(model.maxTerm) < 0)
                    {
                        view.errMaximumTerm();
                    }
                    else
                    {
                        view.unMaximumTerm();
                        correct++;
                    }
                }
                else
                {
                    view.errMaximumTerm();
                }
            }
            //comaker
            if (comaker == 1)
            {
                view.errComaker();
            }
            else
            {
                view.unComaker();
                correct++;
            }
            //status
            if (status == 1)
            {
                view.errStatus();
            }
            else
            {
                view.unStatus();
                correct++;
            }
            //cboxNoLoanEntitlement
            if (view.getNoEntitlement())
            {
                view.unLoanEntitlement();
                view.unStatus();
            }
            else
            {
                //LoanEntitlement
                if (string.IsNullOrWhiteSpace(model.loanEntitlement))
                {
                    view.errLoanEntitlement();
                }
                else
                {
                    if (double.TryParse(model.loanEntitlement, out num))
                    {
                        if (Convert.ToDouble(model.loanEntitlement) < 0)
                        {
                            view.errLoanEntitlement();
                        }
                        else
                        {
                            view.unLoanEntitlement();
                            correct++;
                        }
                    }
                    else
                    {
                        view.errLoanEntitlement();
                    }
                }
                //collateral
                if (collateral == 1)
                {
                    view.errCollateral();
                }
                else
                {
                    view.unCollateral();
                    correct++;
                }
                //percentage
                //if (percentage == 1)
                //{
                //    mltv.errPercentage();
                //}
                //else
                //{
                //    mltv.unPercentage();
                //    correct++;
                //}
            }
            return correct;
        }

        public int LoanTypeName()
        {
            model.loanName = view.getLoanTypeName();
            model.LoanTypeName();

            return Convert.ToInt16(model.loanTypeName);            
        }


        public int LoanTypeID()
        {
            model.updateLoanTypeName = view.getLoanTypeName();
            model.UpdateLoanTypeName();

            return Convert.ToInt16(model.loanTypeID);
        }
    }
}