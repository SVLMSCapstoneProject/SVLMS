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
    class ControllerPenalty
    {
        ModelPenalty model;
        MaintenancePenaltyView view;

        public ControllerPenalty(ModelPenalty model, MaintenancePenaltyView view)
        {
            this.model = model;
            this.view = view;

            view.Show();
            view.setBtnSaveEvent(btnSaveClicked);
            view.setBtnClearEvent(btnClearClicked);
            view.setBtnUpdateEvent(btnUpdateClicked);
            view.setDataGridEvent(dataGridClicked);
            view.setCboFilterEvent(CboFilterSelectedIndexChanged);
            view.setTxtSearchEvent(TextSearchTextChanged);
            view.setLoanTypes(model.getLoanTypes());
            view.setDataGrid(model.getPenaltyInformation());
            this.RefreshFields();
        }

        public void CboFilterSelectedIndexChanged(object sender, EventArgs e)
        {
            view.setDataGrid(model.searchLoanPenalty(view.getCboFilter(), view.getTextSearch()));
        }

        public void TextSearchTextChanged(object sender, EventArgs e)
        {
            view.setDataGrid(model.searchLoanPenalty(view.getCboFilter(), view.getTextSearch()));
        }

        public void btnClearClicked(object sender, EventArgs e)
        {
            this.RefreshFields();
        }

        public void dataGridClicked(object sender, EventArgs e)
        {
            view.unStatus();
            view.unPercentage();
            view.unPenaltyRate();

            DataGridView dg = view.getDataGrid();
            int row = dg.CurrentCell.RowIndex;
            model.penaltyID = dg.Rows[row].Cells[0].Value.ToString();
            model.searchInformation();
            view.enableBtnUpdate();
            view.disableBtnSave();
            view.disableCboLoanType();
            view.setLoanTypeID(model.loanTypeID);
            view.setGracePeriod(model.gracePeriod);
            view.setIsPercentage(model.isPercentage);
            view.setInterval(model.interval);
            view.setPenaltyRate(model.penaltyAmount);
            view.setCboGracePeriod(Convert.ToInt32(model.graceTime));
            view.setCboInterval(Convert.ToInt32(model.intervalTime));
            view.setEffectivityDate(model.effectivityDate);
            view.setStatus(model.status);
        }

        public void btnUpdateClicked(object sender, EventArgs e)
        {
            this.setModelValues();
            DataGridView dg = view.getDataGrid();
            int row = dg.CurrentCell.RowIndex;
            //model.loanTypeID = dg.Rows[row].Cells[0].Value.ToString();
            model.penaltyID = dg.Rows[row].Cells[0].Value.ToString();
            int validate = Validate();
            if (validate == 5)
            {
                if (!model.penaltyRateExistsUpdate())
                {
                    model.updateLoanPenalty();
                    MessageBox.Show("The Record is Successfully Updated");
                    this.RefreshFields();
                }

                else
                {
                    MessageBox.Show("Effectivity date already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Invalid Input/s", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public void btnSaveClicked(object sender, EventArgs e)
        {
            this.setModelValues();
            model.loanTypeID = view.getLoanTypeID();

            int validate = Validate();
            if (validate == 5)
            {
                if (!model.penaltyRateExists())
                {
                    model.insertLoanPenalty();
                    MessageBox.Show("The Record is Successfully Inserted");
                    this.RefreshFields();
                }

                else
                {
                    MessageBox.Show("Effectivity date already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Invalid Input/s", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public void setModelValues()
        {
            model.penaltyAmount = view.getPenaltyRate();
            model.isPercentage = view.getIsPercentage();
            model.gracePeriod = view.getGracePeriod();
            model.graceTime = view.getCboGracePeriod().ToString();
            model.interval = view.getInterval();
            model.intervalTime = view.getCboInterval().ToString();
            model.effectivityDate = view.getEffectivityDate();
            model.status = view.getStatus();
            model.loanTypeID = view.getLoanTypeID();
        }

        public void RefreshFields()
        {
            view.setPenaltyRate("");
            view.setGracePeriod("");
            view.setInterval("");
            view.setDataGrid(model.getPenaltyInformation());
            view.enableBtnSave();
            view.disableBtnUpdate();
            view.clearCBBox();
            view.setLoanTypes(model.getLoanTypes());
            view.enableCboLoanType();
            model.loanTypeID = "0";
            view.clearRadioButton();
            view.unStatus();
            view.unPercentage();
            view.unPenaltyRate();
        }

        public int Validate()
        {
            this.setModelValues();

            int correct = 0;
            int percentage = view.percentage();
            int status = view.status();

            int integer;
            double num;
            //PenaltyRate
            if (string.IsNullOrWhiteSpace(model.penaltyAmount))
            {
                view.errPenaltyRate();
            }
            else
            {
                if (double.TryParse(model.penaltyAmount, out num))
                {
                    if (Convert.ToDouble(model.penaltyAmount) < 0)
                    {
                        view.errPenaltyRate();
                    }
                    else
                    {
                        view.unPenaltyRate();
                        correct++;
                    }
                }
                else
                {
                    view.errPenaltyRate();
                }
            }
            //GracePeriod
            if (string.IsNullOrWhiteSpace(model.gracePeriod))
            {
                view.errGracePeriod();
            }
            else
            {
                if (int.TryParse(model.gracePeriod, out integer))
                {
                    if (Convert.ToInt32(model.gracePeriod) < 0)
                    {
                        view.errGracePeriod();
                    }
                    else
                    {
                        view.unGracePeriod();
                        correct++;
                    }
                }
                else
                {
                    view.errGracePeriod();
                }
            }
            //Interval
            if (string.IsNullOrWhiteSpace(model.interval))
            {
                view.errInterval();
            }
            else
            {
                if (int.TryParse(model.interval, out integer))
                {
                    if (Convert.ToInt32(model.interval) < 0)
                    {
                        view.errInterval();
                    }
                    else
                    {
                        view.unInterval();
                        correct++;
                    }
                }
                else
                {
                    view.errInterval();
                }
            }
            //Percentage
            if (percentage == 1)
            {
                view.errPercentage();
            }
            else
            {
                view.unPercentage();
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

            return correct;
        }
    }
}
