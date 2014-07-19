using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SVLMS.Loaning.Model;
using SVLMS.Loaning.View;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SVLMS.Loaning.Controller
{
    class ControllerAdditionalCharges
    {
        MaintenanceAdditionalChargesView view;
        ModelAdditionalCharges model;

        bool update;
        public ControllerAdditionalCharges(ModelAdditionalCharges model, MaintenanceAdditionalChargesView view)
        {
            this.view = view;
            this.model = model;
            this.view.Show();
            view.enableAdd();
            view.disableUpdate();
            

            view.setDataGrid(model.getChargeInformation());
            //view.setChargeID(model.getNextID());
            view.setlistbox(model.getLoanTypes());
            view.setChkApplicableAllEvent(ChkAllClicked);
            view.setBtnSaveEvent(btnSaveClicked);
            view.setBtnClearEvent(btnClearClicked);
            view.setBtnUpdateEvent(btnUpdateClicked);
            view.setDataGridEvent(dgClicked);
            view.setCboFilterEvent(CboFilterSelectedIndexChanged);
            view.setTxtSearchEvent(TextSearchTextChanged);
            view.settxtChargeName(txtChargeNameLeave);
        }

        public void txtChargeNameLeave(object sender, EventArgs e)
        {
            int check = ChargeName();
            if (update == true)
            {
                int check1 = ChargeNameID();
                if (check1 == 1)
                {
                    view.unChargeName();
                }
                else
                {
                    if (check == 1)
                    {
                        view.errChargeName();
                        MessageBox.Show("There's an existing Charge Name");
                    }
                    else
                    {
                        view.unChargeName();
                    }
                }
            }
            else 
            {
                if (check == 1)
                {
                    view.errChargeName();
                    MessageBox.Show("There's an existing Charge Name");
                }
                else
                {
                    view.unChargeName();
                }            
            }
        }

        public void TextSearchTextChanged(object sender, EventArgs e)
        {
            view.setDataGrid(model.searchCharges(view.getCboFilter(),view.getTextSearch()));
        }

        public void CboFilterSelectedIndexChanged(object sender, EventArgs e)
        {
            view.setDataGrid(model.searchCharges(view.getCboFilter(),view.getTextSearch()));
        }

        public void ChkAllClicked(object sender, EventArgs e)
        {
            bool isApplicable = view.isApplicableToAll();

            CheckedListBox clb = view.getCheckListBox();
            for (int x = 0; x < clb.Items.Count; x++ )
            {
                clb.SetItemChecked(x,isApplicable);
            }
            view.setCheckListBox(clb);
        }

        public void btnUpdateClicked(object sender, EventArgs e)
        {
            int check = ChargeNameID();
            int check1 = ChargeName();
            int validate = Validate();

            this.setmodelValues();

            if (validate == 4)
            {
                if (check == 1)
                {
                    view.unChargeName();
                    model.updateCharges();
                    model.UpdateLoanCharges();
                    MessageBox.Show("The Record is Successfully Updated");
                    this.RefreshFields();                
                }
                else
                {
                    if (check1 == 1)
                    {
                        view.errChargeName();
                        MessageBox.Show("There's an existing Charge Name");
                    }
                    else
                    {
                        view.unChargeName();
                        model.updateCharges();
                        model.UpdateLoanCharges();
                        MessageBox.Show("The Record is Successfully Updated");
                        this.RefreshFields();
                    }
                }
            }
            else
            {
                if (check == 1)
                {
                    view.errChargeName();
                }
                else
                {
                    if (check1 == 1)
                    {
                        view.errChargeName();
                    }
                }
                MessageBox.Show("Invalid Input/s", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);            
            }
        }

        public void btnClearClicked(object sender, EventArgs e)
        {
            this.RefreshFields();
        }

        public void dgClicked(object sender, EventArgs e)
        {
            this.refresh();
            DataGridView dg = view.getDataGrid();
            int row = dg.CurrentCell.RowIndex;
            model.chargeID = dg.Rows[row].Cells[0].Value.ToString();
            string[] loanTypeID = model.getLoanTypeID();
            model.searchChargesInformation();
            model.searchchargesloantyeInfo();

            view.setChargeID(model.chargeID);
            view.setChargeName(model.chargeName);
            view.setIsPercentage(model.isPercentage);
            view.setAmount(model.amount);
            view.setchecklistbox(model.list);
            view.setStatus(model.status);

            view.disableAdd();
            view.enableUpdate();
            update = true;
        }

        public void btnSaveClicked(object sender, EventArgs e)
        {
            int check = ChargeName();
            int validate = Validate();

            this.setmodelValues();

            if (validate == 4)
            {
                if (check == 1)
                {
                    view.errChargeName();
                    MessageBox.Show("There's an existing Charge Name");
                }
                else
                {
                    view.unChargeName();
                    model.insertCharges();
                    model.insertLoanCharges();
                    MessageBox.Show("The Record is Successfully Inserted");
                    this.RefreshFields();
                }
            }
            else
            {
                if (check == 1)
                {
                    view.errChargeName();
                }
                MessageBox.Show("Invalid Input/s", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public void setmodelValues()
        {
            model.loanTypeID = view.getlistbox();
            //model.chargeID = view.getChargeID();
            model.chargeName = view.getChargeName();
            model.amount = view.getAmount();
            model.isPercentage = view.getIsPercentage();
            model.list = view.getchecklistselected();
            model.status = view.getStatus();
        }

        public void RefreshFields()
        {
            view.setChargeID(model.getNextID());
            view.setChargeName("");
            view.setAmount("");
            view.setDataGrid(model.getChargeInformation());
            model.list.Clear();
            view.setchecklistbox(model.list);

            view.enableAdd();
            view.disableUpdate();
            view.resetRadioButton();

            this.refresh();
        }

        public void refresh()
        {
            update = false;
            view.unAmount();
            view.unChargeName();
            view.unPercentage();
            view.unStatus();        
        }

        public int Validate()
        {
            this.setmodelValues();

            string special = "!@#$%^&*(){}/;:><+=_?.,1234567890";
            double num;
            bool error = false;
            int correct = 0;
            int status = view.status();
            int percentage = view.percentage();
            bool pass = true;
            //ChargeName
            if (string.IsNullOrWhiteSpace(model.chargeName))
            {
                view.errChargeName();
            }
            else
            {
                char[] spec = special.ToCharArray();                
                char[] str = model.chargeName.ToCharArray();
                for (int x = 0; x < special.Length; x++)
                {
                    for (int i = 0; i < str.Length; i++)
                    {
                        if (str[i] == special[x])
                        {
                            view.errChargeName();
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
                            view.unChargeName();
                            error = false;
                        }
                        else
                        {
                            i = str.Length;
                            view.errChargeName();
                            error = true;
                        }
                    }
                }
                if (error == false)
                {
                    view.unChargeName();
                    correct++;
                }
            }
            //Amount
            if (string.IsNullOrWhiteSpace(model.amount))
            {
                view.errAmount();
            }
            else
            {
                if (double.TryParse(model.amount, out num))
                {
                    if (Convert.ToDouble(model.amount) < 0)
                    {
                        view.errAmount();
                    }
                    else
                    {
                        view.unAmount();
                        correct++;
                    }
                }
                else
                {
                    view.errAmount();
                }
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
            //percentage
            if (percentage == 1)
            {
                view.errPercentage();
            }
            else
            {
                view.unPercentage();
                correct++;
            }

            return correct;
        }

        public int ChargeName()
        {
            model.chargeName = view.getNameCharge();
            model.ChargeName();

            return Convert.ToInt16(model.nameCharge);
        }

        public int ChargeNameID()
        {
            model.updateNameCharge = view.getNameCharge();
            model.UpdateChargeName();

            return Convert.ToInt16(model.nameChargeID);
        }
    }
}
