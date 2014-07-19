using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using SVLMS.Savings.Model;
using SVLMS.Savings.View;
using System.Windows.Forms;

namespace SVLMS.Savings.Controller
{
    class ControllerSavingsType
    {
        MaintenanceSavingsTypeView view;
        ModelSavingsType model;

        bool update;
        public ControllerSavingsType(ModelSavingsType model, MaintenanceSavingsTypeView view)
        {
            this.view = view;
            this.model = model;
            
            //Set DataGrid
            view.setSavingsTypeInfo(model.getSavingsTypeInformation());
            //view.setSavingsNo(model.getNextID());
            view.disableUpdate();
            view.enableAdd();
            view.Show();
            view.setBtnSaveEvent(btnSaveClicked);
            view.setBtnUpdateEvent(btnUpdateClicked);
            view.setBtnClearEvent(btnClearClicked);
            view.setDataGridEvent(dgCellClicked);
            view.setChkWithdrawalEvent(chkNoWithdrawalClicked);
            view.setTxtSearchEvent(txtSearchTextChanged);
            view.setCboFilterEvent(cboFilterIndexChanged);
            view.setTxtSavingsName(txtSavingsNameLeave);
        }

        public void cboFilterIndexChanged(object sender, EventArgs e)
        {
            view.setSavingsTypeInfo(model.searchSavingsType(view.getCboFilter(),view.getTxtSearch()));
        }

        public void txtSearchTextChanged(object sender, EventArgs e)
        {
            view.setSavingsTypeInfo(model.searchSavingsType(view.getCboFilter(),view.getTxtSearch()));
        }

        public void txtSavingsNameLeave(object sender, EventArgs e)
        {
            int check = SavingsTypeName();
            if (update == true)
            {
                int check1 = UpdateSavingsTypeName();
                if (check1 == 1)
                {
                    view.unSavingsTypeName();
                }
                else
                {
                    if (check == 1)
                    {
                        view.errSavingsTypeName();
                        MessageBox.Show("There's an existing Savings Type Name");
                    }
                    else
                    {
                        view.unSavingsTypeName();
                    }
                }
            }
            else
            {
                if (check == 1)
                {
                    view.errSavingsTypeName();
                    MessageBox.Show("There's an existing Savings Type Name");
                }
                else
                    view.unSavingsTypeName();            
            }
        }

        public void dgCellClicked(object sender, EventArgs e)
        {
            view.unAccountHolders();
            view.unInterest();
            view.unMaintainingBalance();
            view.unMaxWithdrawalAmount();
            //view.unMinimumWithrawalAmount();
            view.unPercentage();
            view.unSavingsTypeName();
            //view.unStartEarningAt();
            view.unStatus();
            //view.unWithdrawalLimit();
            view.unDuration();
            view.unWithdrawLimit();

            view.disableAdd();
            view.enableUpdate();
            DataGridView dgv = view.getSavingsTypeInfo();
            int row = dgv.CurrentCell.RowIndex;
            model.savingsTypeID = dgv.Rows[row].Cells[0].Value.ToString();
            model.searchSavingsType();

            //Transfer the values to view
            //view.setSavingsNo(model.savingsTypeID);
            view.setSavingsTypeName(model.savingsName);
            view.setMaintainingBalance(model.maintainingBalance);
            //view.setStartEarning(model.startingEarn);
            view.setNoAccountHolders(model.noAccountHolders);
            view.setInterest(model.interest);
            view.setIsPercentage(model.isPercentage);
            view.setStatus(model.status);      
            view.setStatus(model.status);
            //view.setMinimumWithdrawal(model.minimumWithdrawal);

            //Check if there is no withdrawal amount
            if (Convert.ToDouble(model.maxWithdrawalAmount) != 0)
            {
                view.setMaxWithdrawal(model.maxWithdrawalAmount);
                //view.setWithdrawaLimit(model.maxWithdrawDuration);
                view.setWithdrawDuration(model.maxWithdrawalTime.ToString());
                view.setNoWithdrawalLimit(model.maxWithdrawalAmount);
            }

            else if (Convert.ToDouble(model.maxWithdrawalAmount) == 0)
            {
                view.setNoWithdrawalLimit(model.maxWithdrawalAmount);
                view.setMaxWithdrawal("");
                //view.setWithdrawaLimit("");
                view.setWithdrawDuration("0");
            }
            update = true;
            view.enableUpdate();
            view.disableAdd();
        }

        public void btnSaveClicked(object sender, EventArgs e)
        {
            int check = SavingsTypeName();

            if (check == 1)
            {
                MessageBox.Show("There's an existing Savings Type Name");
                bool perform = PerformAction();
                view.errSavingsTypeName();
            }
            else
            {
                view.unSavingsTypeName();
                bool perform = PerformAction();
                if (perform == true)
                {
                    if (view.getNoWithdrawalLimit())
                    {
                        DialogResult dialogResult = MessageBox.Show("Are you sure of not having a withdrawal limit?", "No Withdrawal Limit", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                        if (dialogResult == DialogResult.Yes)
                        {
                            this.setValuesToModel();
                            view.unWithdrawLimit();
                            model.insertSavingsType();
                            MessageBox.Show("The Record is Successfully Inserted");
                            this.RefreshFields();
                        }
                        else if (dialogResult == DialogResult.No)
                        {
                            view.errWithdrawLimit();
                        }
                    }
                    else
                    {
                        DialogResult dialogResult = MessageBox.Show("Are you sure of not having a withdrawal limit?", "No Withdrawal Limit", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                        if (dialogResult == DialogResult.Yes)
                        {
                            this.setValuesToModel();
                            view.unWithdrawLimit();
                            model.insertSavingsType();
                            MessageBox.Show("The Record is Successfully Inserted");
                            this.RefreshFields();
                        }
                        else if (dialogResult == DialogResult.No)
                        {
                            view.errWithdrawLimit();
                        }
                    }
                }
            }
        }

        public void btnUpdateClicked(object sender, EventArgs e)
        {
            int check = UpdateSavingsTypeName();
            int check1 = SavingsTypeName();

            if (check1 == 1)
            {
                view.unSavingsTypeName();
                Update();
            }
            else
            {
                if (check == 1)
                {
                    MessageBox.Show("There's an existing Savings Type Name");
                    Update();
                    view.errSavingsTypeName();
                }
                else
                {
                    Update();
                }
            }
        }

        public void setValuesToModel()
        {
            model.savingsName = view.getSavingsTypeName();
            model.maintainingBalance = view.getMaintainingBalance();
            //model.startingEarn = view.getStartEarning();
            model.noAccountHolders = view.getNoAccountHolders();
            model.interest = view.getInterest();
            model.isPercentage = view.getIsPercentage();
            model.status = view.getStatus();
            //model.minimumWithdrawal = view.getMinimumWithdrawal();

            //Check if No Withdrawal limit is checked
            if (view.getNoWithdrawalLimit() == false) //if there is withdrawal limit
            {
                model.maxWithdrawalAmount = view.getMaxWithdrawal();
                //model.maxWithdrawDuration = view.getWithdrawalLimit();
                model.maxWithdrawDuration = "1";
                model.maxWithdrawalTime = view.getWithdrawDuration();
            }

            else if (view.getNoWithdrawalLimit() == true) //if no withdrawal limit
            {
                model.maxWithdrawalAmount = "0";
                model.maxWithdrawDuration = "0";
                model.maxWithdrawalTime = 0;
            }
        }

        public void chkNoWithdrawalClicked(object sender, EventArgs e)
        {
            if (view.getNoWithdrawalLimit())
            {
                view.disableMaxWithdrawal();
                //view.unWithdrawalLimit();
                view.unMaxWithdrawalAmount();
                view.unDuration();
            }

            else
            {
                view.enableMaxWithdrawal();
            }
        }

        public void btnClearClicked(object sender, EventArgs e)
        {
            this.RefreshFields();
        }

        public void RefreshFields()
        {
            update = false;
            //view.setSavingsNo(model.getNextID());
            view.setSavingsTypeName("");
            view.setInterest("");
            //view.setStartEarning("");
            view.setMaintainingBalance("");
            view.setMaxWithdrawal("");
            view.enableAdd();
            view.disableUpdate();
            //view.setWithdrawaLimit("");
            view.setNoAccountHolders("");
            view.setSavingsTypeInfo(model.getSavingsTypeInformation());
            view.clearRadioButton();
            //view.setMinimumWithdrawal("");
            view.enableMaxWithdrawal();
            view.unAccountHolders();
            view.unInterest();
            view.unMaintainingBalance();
            view.unMaxWithdrawalAmount();
            //view.unMinimumWithrawalAmount();
            view.unPercentage();
            view.unSavingsTypeName();
            //view.unStartEarningAt();
            view.unStatus();
            //view.unWithdrawalLimit();
            view.unDuration();
            view.unWithdrawLimit();
        }
        //---------------------------------------------------------------
        public bool PerformAction()
        {
            bool perform = false;
            int validate = Validate();

            //if No Withdrawal Limit is checked
            if (view.getNoWithdrawalLimit() == true)
            {
                if (validate == 6)
                {
                    perform = true;
                }
                else
                {
                    MessageBox.Show("Invalid Input/s", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            //if No Withdrawal Limit is not checked
            else if (view.getNoWithdrawalLimit() == false)
            {
                if (validate == 8)
                {
                    if ((Convert.ToDouble(model.minimumWithdrawal)) > (Convert.ToDouble(model.maxWithdrawalAmount)))
                    {
                        MessageBox.Show("Invalid Input/s", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        MessageBox.Show("Maximum Withdrawal Amount must be greater than the Minimum Withdrawal Amount.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        view.errMaxWithdrawalAmount();
                        //view.errMinimumWithdrawalAmount();
                    }
                    else
                    {
                        view.unMaxWithdrawalAmount();
                        //view.unMinimumWithrawalAmount();
                        perform = true;
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
            this.setValuesToModel();

            string special = "!@#$%^&*(){}/;:><+=_?.,1234567890";
            bool pass = true;
            int integer;
            double num;
            bool error = false ;
            int correct = 0;
            int percentage = view.percentage();
            int status = view.status();
            //SavingsTypeName-------------------------------------
            if (string.IsNullOrWhiteSpace(model.savingsName))
            {
                view.errSavingsTypeName();
            }
            else
            {
                    char[] spec = special.ToCharArray();
                    char[] str = model.savingsName.ToCharArray();
                    for (int x = 0; x < special.Length; x++)
                    {
                        for (int i = 0; i < str.Length; i++)
                        {
                            if (str[i] == special[x])
                            {
                                view.errSavingsTypeName();
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
                            if (char.IsLetter(str[i]) || str[i] == ' ' || str[i] == '-' || str[i] == '\'')
                            {
                                view.unSavingsTypeName();
                                error = false;
                            }
                            else
                            {
                                view.errSavingsTypeName();
                                i = model.savingsName.Length;
                                error = true;
                            }
                        }
                    }
                if (error == false)
                {
                   view.unSavingsTypeName();
                   correct++;
                }
            }
            //AccountHolders------------------------------------------
            if (string.IsNullOrWhiteSpace(model.noAccountHolders))
            {
                view.errAccountHolders();
            }
            else
            {
                if (int.TryParse(model.noAccountHolders, out integer))
                {
                    if (Convert.ToInt32(model.noAccountHolders) < 0)
                    {
                        view.errAccountHolders();
                    }
                    else
                    {
                        view.unAccountHolders();
                        correct++;
                    }
                }
                else
                {
                    view.errAccountHolders();
                }
            }
            //WithdrawalLimit-------------------------------------------
            if (view.getNoWithdrawalLimit())
            {
                view.unMaxWithdrawalAmount();
                //view.unWithdrawalLimit();
                view.unDuration();
            }
            else
            {
                //Duration(DropDown)-------------------------------------
                if (model.maxWithdrawalTime == 0 && view.getNoWithdrawalLimit() == false)
                {
                    view.errDuration();
                }
                else
                {
                    view.unDuration();
                    correct++;
                }
                //MaximumWithdrawalAmount-------------------------------
                if (string.IsNullOrWhiteSpace(model.maxWithdrawalAmount))
                {
                    view.errMaxWithdrawalAmount();
                }
                else
                {
                    if (double.TryParse(model.maxWithdrawalAmount, out num))
                    {
                        if (Convert.ToDouble(model.maxWithdrawalAmount) < 0)
                        {
                            view.errMaxWithdrawalAmount();
                        }
                        else
                        {
                            view.unMaxWithdrawalAmount();
                            correct++;
                        }
                    }
                    else
                    {
                        view.errMaxWithdrawalAmount();
                    }
                }
            //    //WithdrawalLimit-------------------------------------
            //    if (string.IsNullOrWhiteSpace(mod/el.maxWithdrawDuration))
            //    {
            //        view.errWithdrawalLimit();
            //    }
            //    else
            //    {
            //        if (int.TryParse(model.maxWithdrawDuration, out integer))
            //        {
            //            view.unWithdrawalLimit();
            //            correct++;
            //        }
            //        else
            //        {
            //            view.errWithdrawalLimit();
            //        }
            //    }
            }
            ////MinimumWithdrawal----------------------------------
            //if (string.IsNullOrWhiteSpace(model.minimumWithdrawal))
            //{
            //    view.errMinimumWithdrawalAmount();
            //}
            //else
            //{
            //    if (double.TryParse(model.minimumWithdrawal, out num))
            //    {
            //        view.unMinimumWithrawalAmount();
            //        correct++;
            //    }
            //    else
            //    {
            //        view.errMinimumWithdrawalAmount();
            //    }
            //}
            //MaintainingBalance------------------------------------
            if (string.IsNullOrWhiteSpace(model.maintainingBalance))
            {
                view.errMaintainingBalance();
            }
            else
            {
                if (double.TryParse(model.maintainingBalance, out num))
                {
                    if (Convert.ToDouble(model.maintainingBalance) < 0)
                    {
                        view.errMaintainingBalance();
                    }
                    else
                    {
                        view.unMaintainingBalance();
                        correct++;
                    }
                }
                else
                {
                    view.errMaintainingBalance();
                }
            }
            //Interest-------------------------------------------
            if (string.IsNullOrWhiteSpace(model.interest))
            {
                view.errInterest();
            }
            else
            {
                if (double.TryParse(model.interest, out num))
                {
                    if (Convert.ToDouble(model.interest) < 0)
                    {
                        view.errInterest();
                    }
                    else
                    {
                        view.unInterest();
                        correct++;
                    }
                }
                else
                {
                    view.errInterest();
                }
            }
            ////StartEarningAt---------------------------------------
            //if (string.IsNullOrWhiteSpace(model.startingEarn))
            //{
            //    view.errStartEarningAt();
            //}
            //else
            //{
            //    if (double.TryParse(model.startingEarn, out num))
            //    {
            //        view.unStartEarningAt();
            //        correct++;
            //    }
            //    else
            //    {
            //        view.errStartEarningAt();
            //    }
            //}
            //FixedOrPercentage------------------------------
            if (percentage == 1)
            {
                view.errPercentage();
            }
            else
            {
                view.unPercentage();
                correct++;
            }
            //StatusActiveInactve-----------------------------------
            if (status == 1)
            {
                view.errStatus();
            }
            else
            {
                view.unStatus();
                correct++;
            }
            return correct;
        }

        public int SavingsTypeName()
        {
            model.savingsName = view.getName();
            model.searchSavingsName();

            return Convert.ToInt16(model.checkSavingsName);
        }

        public int UpdateSavingsTypeName()
        {
            model.updateSavingsName = view.getName();
            model.SavingsNameUpdate();

            return Convert.ToInt16(model.savingsNameID);
        }

        public void Update()
        {
            bool perform = PerformAction();

            if (perform == true)
            {
                if (view.getNoWithdrawalLimit())
                {
                    DialogResult dialogResult = MessageBox.Show("Are you sure of not having a withdrawal limit?", "No Withdrawal Limit", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                    if (dialogResult == DialogResult.Yes)
                    {
                        view.unWithdrawLimit();
                        this.setValuesToModel();
                        model.updateSavingsType();
                        MessageBox.Show("The Record is Successfully Updated");
                        this.RefreshFields();
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        view.errWithdrawLimit();
                    }
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Are you sure of not having a withdrawal limit?", "No Withdrawal Limit", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                    if (dialogResult == DialogResult.Yes)
                    {
                        view.unWithdrawLimit();
                        this.setValuesToModel();
                        model.updateSavingsType();
                        MessageBox.Show("The Record is Successfully Updated");
                        this.RefreshFields();
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        view.errWithdrawLimit();
                    }
                }
            }
        }
    }
}
