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
    class ControllerTimeDepositPenalty
    {
        ModelTimeDepositPenalty model;
        MaintenanceTimeDepositPenalty view;

        public ControllerTimeDepositPenalty(ModelTimeDepositPenalty model, MaintenanceTimeDepositPenalty view)
        {
            this.model = model;
            this.view = view;

            view.Show();

            view.setdgPenalty(model.getTimeDepositPenalty());
            view.setDataGridEvent(dgClicked);
            view.setBtnSaveEvent(btnAddClicked);
            view.setBtnClearEvent(btnclearClicked);
            view.setBtnUpdateEvent(btnUpdateClicked);
            view.setCboFilterEvent(CboFilterSelectedIndexChanged);
            view.enableWhenupdate();
        }

        public void CboFilterSelectedIndexChanged(object sender, EventArgs e)
        {
            view.setdgPenalty(model.filterTimeDepositPenalty(view.getCboFilter()));
        }

        public void btnAddClicked(object sender, EventArgs e)
        {
            int validate = Validate();

            if (validate == 4)
            {
                if (Convert.ToDouble(model.minimum) > Convert.ToDouble(model.maximum))
                {
                    MessageBox.Show("Invalid value in percentage of term elapsed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    view.errMaxTerm();
                    view.errMinTerm();
                }
                else
                {
                    this.setModelValues();
                    if (model.penaltyRateExists() && view.getStatus() == "1")
                    {
                        view.errMaxTerm();
                        view.errMinTerm();
                        MessageBox.Show("Percentage of term elapsed overlapped with existing values.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                    else
                    {
                        view.unMinTerm();
                        view.unMaxTerm();
                        model.insertTimeDepositPenalty();
                        MessageBox.Show("Inserted!");
                        view.setdgPenalty(model.getTimeDepositPenalty());
                        this.RefreshFields();
                    }
                }
            }
            else
            {
                MessageBox.Show("Invalid Input/s.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public void btnUpdateClicked(object sender, EventArgs e)
        {
            int validate = Validate();

            if (validate == 4)
            {
                this.setModelValues();
                //MessageBox.Show(model.penaltyID);
                if (model.penaltyRateExistsUpdate() && view.getStatus()=="1")
                {
                    view.errMaxTerm();
                    view.errMinTerm();
                    MessageBox.Show("Percentage of term elapsed overlapped with existing values.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                else
                {
                    model.UpdateTimeDepositPenalty();
                    MessageBox.Show("Updated!");
                    view.enableWhenupdate();
                    view.setdgPenalty(model.getTimeDepositPenalty());
                    this.RefreshFields();
                }

            }
            else
            {
                MessageBox.Show("Invalid Input/s.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public void dgClicked(object sender, EventArgs e)
        {
            this.RefreshFields();
            DataGridView dg = view.getdgPenalty();
            int row = dg.CurrentCell.RowIndex;

            model.penaltyID = dg.Rows[row].Cells[0].Value.ToString();

            model.searchTimeDepositPenaltyInfo();
            //view.disableTextboxes();
            view.disableWhenupdate();

            view.setRateAdjustment(model.rateAdjusmtment);
            view.setTermElapsedMaximum(model.maximum);
            view.setTermElapsedMinimum(model.minimum);
            view.setStatus(model.status);
        }

        public void btnclearClicked(object sender, EventArgs e)
        {
            this.RefreshFields();
        }

        public void setModelValues()
        {
            model.status = view.getStatus();
            model.maximum = view.getTermElapsedMaximum();
            model.minimum = view.getTermElapsedMinimum();
            model.rateAdjusmtment = view.getRateAdjustment();
        }

        public void RefreshFields()
        {
            view.enableTextboxes();
            view.enableWhenupdate();
            view.setTermElapsedMaximum("");
            view.setTermElapsedMinimum("");
            view.setRateAdjustment("");
            view.resetRadioButton();
            view.unMaxTerm();
            view.unMinTerm();
            view.unRate();
            view.unStatus();
        }

        public int Validate()
        {
            this.setModelValues();

            int correct = 0;
            int status = view.status();
            double num;

            //TermElapsedMinimum
            if (string.IsNullOrWhiteSpace(model.minimum))
            {
                view.errMinTerm();
            }
            else
            {
                if (double.TryParse(model.minimum, out num))
                {
                    if (Convert.ToDouble(model.minimum) < 0 && Convert.ToDouble(model.minimum) >= 100)
                    {
                        view.errMinTerm();
                    }
                    else
                    {
                        view.unMinTerm();
                        correct++;
                    }
                }
                else
                {
                    view.errMinTerm();
                }
            }
            //TermElapsedMaximum
            if (string.IsNullOrWhiteSpace(model.maximum))
            {
                view.errMaxTerm();
            }
            else
            {
                if (double.TryParse(model.maximum, out num))
                {
                    if (Convert.ToDouble(model.maximum) < 0 && Convert.ToDouble(model.maximum) >= 100)
                    {
                        view.errMaxTerm();
                    }
                    else
                    {
                        view.unMaxTerm();
                        correct++;
                    }
                }
                else
                {
                    view.errMaxTerm();
                }
            }
            //RateAdjustment
            if (string.IsNullOrWhiteSpace(model.rateAdjusmtment))
            {
                view.errRate();
            }
            else
            {
                if (double.TryParse(model.rateAdjusmtment, out num))
                {
                    if (Convert.ToDouble(model.rateAdjusmtment) < 0)
                    {
                        view.errRate();
                    }
                    else
                    {
                        view.unRate();
                        correct++;
                    }
                }
                else
                {
                    view.errRate();
                }
            }
            //Status
            if (status == 1)
            {
                view.errStatus();
            }
            if (status == 0)
            {
                view.unStatus();
                correct++;
            }

            return correct;
        }
    }
}
