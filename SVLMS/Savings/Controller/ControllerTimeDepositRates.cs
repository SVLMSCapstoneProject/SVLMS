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
    class ControllerTimeDepositRates
    {
        MaintenanceTimeDeposit view;
        ModelTimeDepositRates model;

        public ControllerTimeDepositRates(ModelTimeDepositRates model, MaintenanceTimeDeposit view)
        {
            this.view = view;
            this.model = model;
            this.view.Show();

            this.RefreshFields();
            //view.setDataGrid(model.getTimeDepositInfoDisplay());
            this.search();
            view.setBtnSaveEvent(addRateClicked);
            view.setBtnClearEvent(ClearClicked);
            view.setDataGridEvent(dgClicked);
            view.setBtnUpdateEvent(updateClicked);
            view.setCboSortByEvent(CboSortByEvent);
            view.setTextSearchEvent(TextSearchChanged);
            view.setCboFilter(CboFilterEvent);
        }

        public void CboFilterEvent(object sender, EventArgs e)
        {
            this.search();
        }

        public void CboSortByEvent(object sender, EventArgs e)
        {
            this.search();
        }

        public void TextSearchChanged(object sender, EventArgs e)
        {
            this.search();
        }

        private void search()
        {
            if (view.getCboSortBy() == 1)
            {
                model.daysRate = view.getTextSearch();
            }

            else if (view.getCboSortBy() == 2)
            {
                model.minimumBracket = view.getTextSearch();
                model.maximumBracket = view.getTextSearch();
            }
            view.setDataGrid(model.getFilter(view.getCboSortBy(), view.getCboFilter()));
        }

        public void dgClicked(object sender, EventArgs e)
        {
            view.unInterestRate();
            view.unMaxBracket();
            view.unMinBracket();
            view.unNoDays();
            view.unStatus();

            DataGridView dg = view.getDataGrid();
            int row = dg.CurrentCell.RowIndex;
            model.timeRateID = dg.Rows[row].Cells[0].Value.ToString();

            model.searchTimeDepositInfo();
            view.setInterestRate(model.interestRate);
            view.setStatus(model.status);
            view.setMinimumBracket(model.minimumBracket);
            view.setMaximumBracket(model.maximumBracket);
            view.setNumberOfDays(model.numberOfDays);
            view.enableUpdate();
        }

        public void addRateClicked(object sender, EventArgs e)
        {
            int validate = ValidateRates();

            if (validate == 5)
            {
                if (Convert.ToDouble(model.minimumBracket) > Convert.ToDouble(model.maximumBracket))
                {
                    view.errMaxBracket();
                    view.errMinBracket();
                    MessageBox.Show("Error in values!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    this.setModelValues();
                    if (model.bracketExists() && view.getStatus() == "1")
                    {
                        MessageBox.Show("Brackets are included in database", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        view.errMaxBracket();
                        view.errMinBracket();
                    }
                    else
                    {
                        view.unMaxBracket();
                        view.unMinBracket();
                        model.insertTimeDepositRate();
                        MessageBox.Show("Time deposit rate is succesfully added.");
                        view.setDataGrid(model.getTimeDepositInfoDisplay());
                        //this.RefreshFields();
                        this.search();
                    }
                }
            }
            else
            {
                MessageBox.Show("Invalid Input/s", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public void ClearClicked(object sender, EventArgs e)
        {
            this.RefreshFields();
        }

        public void updateClicked(object sender, EventArgs e)
        {
            int validate = ValidateRates();

            if (validate == 5)
            {
                if (Convert.ToDouble(model.minimumBracket) > Convert.ToDouble(model.maximumBracket))
                {
                    view.errMaxBracket();
                    view.errMinBracket();
                    MessageBox.Show("Error in values!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    //model.updateTimeDepositRate();
                    //this.setModelValues();
                    //model.errorRates();
                    //int integer;
                    //int.TryParse(model.error, out integer);
                    this.setModelValues();
                    if (model.bracketExistsUpdate() && view.getStatus() == "1")
                    {
                        MessageBox.Show("Brackets are included in database", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        view.errMaxBracket();
                        view.errMinBracket();
                    }
                    else
                    {
                        view.unMaxBracket();
                        view.unMinBracket();
                        model.updateTimeDepositRate();
                        MessageBox.Show("Successfully Updated.");
                        view.setDataGrid(model.getTimeDepositInfoDisplay());
                        //this.RefreshFields();
                        this.search();
                    }
                }
            }
            else
            {
                MessageBox.Show("Invalid Input/s", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public void setModelValues()
        {
            model.from = view.getMinimumBracket();
            model.to = view.getMaximumBracket();
            model.numberOfDays = view.getNumberOfDays();
            model.maximumBracket = view.getMaximumBracket();
            model.minimumBracket = view.getMinimumBracket();
            model.interestRate = view.getInterestRate();
            model.status = view.getStatus();
            //model.daysRate = view.getCboDays();
            //model.bracketRate = view.getCboBracket();
        }

        public void RefreshFields()
        {
            view.setInterestRate("");
            view.setMaximumBracket("");
            view.setMinimumBracket("");
            view.setNumberOfDays("");
            view.resetRadioButton();
            view.setNumberOfDays("");
            view.setMaximumBracket("");
            view.setMinimumBracket("");
            view.enableAdd();
            view.unInterestRate();
            view.unMaxBracket();
            view.unMinBracket();
            view.unNoDays();
            view.unStatus();
        }

        public int ValidateRates()
        {
            this.setModelValues();

            int integer;
            int correct = 0;
            int status = view.status();
            double num;

            //InterestRate
            if (string.IsNullOrWhiteSpace(model.interestRate))
            {
                view.errInterestRate();
            }
            else
            {
                if (double.TryParse(model.interestRate, out num))
                {
                    if (Convert.ToDouble(model.interestRate) < 0)
                    {
                        view.errInterestRate();
                    }
                    else
                    {
                        view.unInterestRate();
                        correct++;
                    }
                }
                else
                {
                    view.errInterestRate();
                }
            }
            //Status
            if (status == 1)
            {
                view.errStatus();
            }
            else
            {
                view.unStatus();
                correct++;
            }

            //NumberOfDays
            if (string.IsNullOrWhiteSpace(model.numberOfDays))
            {
                view.errNoDays();
            }
            else
            {
                if (int.TryParse(model.numberOfDays, out integer))
                {
                    if (Convert.ToDouble(model.numberOfDays) < 0)
                    {
                        view.errNoDays();
                    }
                    else
                    {
                        view.unNoDays();
                        correct++;
                    }
                }
                else
                {
                    view.errNoDays();
                }
            }
            //MinimumBracket
            if (string.IsNullOrWhiteSpace(model.minimumBracket))
            {
                view.errMinBracket();
            }
            else
            {
                if (double.TryParse(model.minimumBracket, out num))
                {
                    if (Convert.ToDouble(model.minimumBracket) < 0)
                    {
                        view.errMinBracket();
                    }
                    else
                    {
                        view.unMinBracket();
                        correct++;
                    }
                }
                else
                {
                    view.errMinBracket();
                }
            }
            //MaximumBracket
            if (string.IsNullOrWhiteSpace(model.maximumBracket))
            {
                view.errMaxBracket();
            }
            else
            {
                if (double.TryParse(model.maximumBracket, out num))
                {
                    if (Convert.ToDouble(model.maximumBracket) < 0)
                    {
                        view.errMaxBracket();
                    }
                    else
                    {
                        view.unMaxBracket();
                        correct++;
                    }
                }
                else
                {
                    view.errMaxBracket();
                }
            }
            return correct;
        }
    }
}
