using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using SVLMS.Savings.Model;
using SVLMS.Savings.View;

namespace SVLMS.Savings.Controller
{
    class ControllerDormancy
    {
        ModelDormancy model;
        MaintenanceDormancyView view;

        public ControllerDormancy(ModelDormancy model, MaintenanceDormancyView view)
        {
            this.model = model;
            this.view = view;

            view.Show();
            view.setSavingsType(model.getSavingsTypes());
            view.setDormancyNo(model.getNextID());
            view.setDormancyInfo(model.getDormancyInfo());
            view.setBtnSaveEvent(btnSaveClicked);
            view.setBtnUpdateEvent(btnUpdateClicked);
            view.setBtnClearEvent(clearClickedEvent);
            view.setDataGridEvent(dgClickedEvent);
            view.setTxtSearchEvent(txtSearchTextChanged);
            view.setCboFilterEvent(cboFilterSelectedIndexChanged);
            this.refreshFields();
        }

        public void cboFilterSelectedIndexChanged(object sender, EventArgs e)
        {
            view.setDormancyInfo(model.searchDormancy(view.getCboFilter(),view.getTxtSearch()));
        }

        public void txtSearchTextChanged(object sender, EventArgs e)
        {
            view.setDormancyInfo(model.searchDormancy(view.getCboFilter(), view.getTxtSearch()));
        }

        public void clearClickedEvent(object sender, EventArgs e)
        {
            this.refreshFields();
        }

        public void dgClickedEvent(object sender, EventArgs e)
        {
            view.unInactivityDuration();
            view.unStatus();
            view.unDeductAmount();
            //view.unDeductEvery();
            view.unPercentage();
            view.unDeductionAmount();

            DataGridView dg = view.getDormancyInfo();
            int currentCell = dg.CurrentCell.RowIndex;
            model.savingsTypeID = dg.Rows[currentCell].Cells[0].Value.ToString();

            //Search Dormancy Info
            model.searchDormancyInfo();

            view.setDormancyNo(model.dormancyID);
            view.setInactivityDuration(model.inactivityDuration);
            view.setInactivityTime(model.inactivityTime);
            view.setDeductionAmount(model.deductionAmount);
            view.setIsPercentage(model.isPercentage);
            //view.setDeductEvery(model.deductionEvery);
            view.setDeductionTime(model.deductionTime);
            view.setStatus(model.status);
            view.setSavingsType(Convert.ToInt32(model.savingsTypeID));
            //view.setEffectivityDate(model.effectivityDate);

            view.disableSaveBtn();
            view.enableUpdateBtn();
            view.disableCboSavingsType();
        }

        public void btnUpdateClicked(object sender, EventArgs e)
        {
            int validate = Validate();
            if (validate == 4)
            {
                this.setModelValues();
                model.updateDormancy();
                MessageBox.Show("The Record is Successfully Updated.");
                this.refreshFields();
            }
            else
            {
                MessageBox.Show("Invalid Input/s", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }            

        public void btnSaveClicked(object sender, EventArgs e)
        {
            int validate = Validate();
            if (validate == 4)
            {
                this.setModelValues();
                model.insertDormancy();
                MessageBox.Show("The Record is Successfully Saved.");
                this.refreshFields();
            }
            else
            {
                MessageBox.Show("Invalid Input/s", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public void setModelValues()
        {
            model.inactivityDuration = view.getInactivityDuration();
            model.inactivityTime = view.getInactivityTime();
            model.deductionAmount = view.getDeductionAmount();
            model.isPercentage = view.getIsPercentage();
            //model.deductionEvery = view.getDeductEvery();
            model.deductionEvery = "1";
            model.deductionTime = view.getDeductionTime();
            model.savingsTypeID = view.getSavingsType();
            model.status = view.getStatus();
            //model.effectivityDate = view.getEffectivityDate();
        }

        public void refreshFields()
        {
            view.setDormancyNo(model.getNextID());
            view.setInactivityDuration("");
            view.setDeductionAmount("");
            //view.setDeductEvery("");
            view.setDormancyInfo(model.getDormancyInfo());
            view.enableSaveBtn();
            view.disableUpdateBtn();
            view.enableCboSavingsType();
            view.clearRadioButton();
            view.unInactivityDuration();
            view.unStatus();
            view.unDeductAmount();
            //view.unDeductEvery();
            view.unPercentage();
            view.unDeductionAmount();
        }

        public int Validate()
        {
            double num;
            int integer;
            int correct = 0;
            
            this.setModelValues();

            int status = view.status();
            int percentage = view.percentage();
            //InactivityDuration---------------------------------
            if (string.IsNullOrWhiteSpace(model.inactivityDuration))
            {
                view.errInactivityDuration();
            }
            else
            {
                if (int.TryParse(model.inactivityDuration, out integer))
                {
                    if (Convert.ToInt32(model.inactivityDuration) < 0)
                    {
                        view.errInactivityDuration();
                    }
                    else
                    {
                        view.unInactivityDuration();
                        correct++;
                    }
                }
                else
                {
                    view.errInactivityDuration();
                }
            }
            //ActiveInactive----------------------------------
            if (status == 1)
            {
                view.errStatus();
            }
            else
            {
                view.unStatus();
                correct++;
            }
            //FixedPercentege----------------------------------
            if (percentage == 1)
            {
                view.errPercentage();
            }
            else
            {
                view.unPercentage();
                correct++;
            }
            //DeductAmount----------------------------------
            if (string.IsNullOrWhiteSpace(model.deductionAmount))
            {
                view.errDeductAmount();
            }
            else
            {
                if (double.TryParse(model.deductionAmount, out num))
                {
                    if (Convert.ToDouble(model.deductionAmount) < 0)
                    {
                        view.errDeductAmount();
                    }
                    else
                    {
                        view.unDeductAmount();
                        correct++;
                    }
                }
                else
                {
                    view.errDeductAmount();
                }
            }
            //DeductEvery
            //if (string.IsNullOrWhiteSpace(model.deductionEvery))
            //{
            //    view.errDeductEvery();
            //}
            //else
            //{
            //    if (int.TryParse(model.deductionEvery, out integer))
            //    {
            //        view.unDeductEvery();
            //        correct++;
            //    }
            //    else
            //    {
            //        view.errDeductEvery();
            //    }
            //}

            return correct;
        }
    }
}
