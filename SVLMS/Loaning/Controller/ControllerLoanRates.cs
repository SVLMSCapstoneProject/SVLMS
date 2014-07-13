using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using SVLMS.Loaning.Model;
using SVLMS.Loaning.View;

namespace SVLMS.Loaning.Controller
{
    class ControllerLoanRates
    {
        ModelLoanRates model;
        MaintenanceLoanRates view;

        public ControllerLoanRates(ModelLoanRates model, MaintenanceLoanRates view)
        {
            this.model = model;
            this.view = view;
            this.view.setBtnAddEvent(addClicked);
            this.view.setBtnUpdateEvent(updateClicked);
            this.view.setDataGridDoubleClickEvent(dgClicked);
            this.view.setClearEvent(clearClicked);
            this.view.setCboFilterEvent(CboFilterSelectedIndexChanged);
            this.view.setTxtSearchEvent(TextSearchTextChanged);
            this.RefreshFields();
            view.setDataGrid(model.getRatesInfo());
            this.view.Show();
        }

        public void CboFilterSelectedIndexChanged(object sender, EventArgs e)
        {
            view.setDataGrid(model.searchLoanRates(view.getCboFilter(),view.getTextSearch()));
        }

        public void TextSearchTextChanged(object sender, EventArgs e)
        {
            view.setDataGrid(model.searchLoanRates(view.getCboFilter(),view.getTextSearch()));
        }

        public void dgClicked(object sender, EventArgs e)
        {
            DataGridView dg = view.getDataGrid();
            int row = dg.CurrentCell.RowIndex;
            model.loanRatesID = dg.Rows[row].Cells[0].Value.ToString();
            model.searchRate();
            this.RefreshFields();
            //view.setRateID(model.loanRatesID);
            view.setInterestRate(model.interestRate);
            view.setIsPercentageInterest(model.isPercentageInterest);
            //view.setSavingsRate(model.savingsRate);
            //view.setIsPercentageSavings(model.isPercentageSavings);
            view.setShareRate(model.shareRate);
            view.setIsPercentageShare(model.isPercentageShare);
            view.setEffectivityDate(model.effectivityDate);
            view.setStatus(model.status);
            view.setCboLoanTypeSelectedValue(model.loanTypeID);
            view.enableUpdate();
            view.disableAdd();
        }

        public void clearClicked(object sender, EventArgs e)
        {
            this.RefreshFields();
        }

        public void addClicked(object sender, EventArgs e)
        {
            int validate = Validate();
            this.setModelValues();

            if (validate == 3)
            {
                if (!model.rateExists())
                {
                    model.insertLoanRates();
                    MessageBox.Show("Loan Rates has been successfully added.");
                    this.RefreshFields();
                    view.setDataGrid(model.getRatesInfo());
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

        public void updateClicked(object sender, EventArgs e)
        {
            int validate = Validate();
            this.setModelValues();

            if (validate == 3)
            {
                if (!model.rateExistsUpdate())
                {
                    model.updateLoanRates();
                    MessageBox.Show("Rates has been successfully updated.");
                    this.RefreshFields();
                    view.setDataGrid(model.getRatesInfo());
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

        public void RefreshFields()
        {
            //view.setRateID(model.getNextRateID());
            view.setInterestRate("");
            //view.setSavingsRate("");
            view.setShareRate("");
            view.clearRadioButton();
            view.setCboLoanType(new ModelLoanType().getLoanTypes());
            view.enableAdd();
            view.disableUpdate();
            view.unInterestRate();
            view.unShareCapital();
            view.unStatus();
        }

        public void setModelValues()
        {
            model.interestRate = view.getInterestRate();
            model.isPercentageInterest = view.getIsPercentageInterest();
            //model.savingsRate = view.getSavingsRate();
            //model.isPercentageSavings = view.getIsPercentageSavings();
            model.shareRate = view.getShareRate();
            model.isPercentageShare = view.getIsPercentageShare();
            model.effectivityDate = view.getEffectivity();
            model.status = view.getStatus();
            model.loanTypeID = view.getLoanTypeID();
        }

        public int Validate()
        {
            double num;
            int correct = 0;

            int status = view.status();

            this.setModelValues();
            //InterestRate------------------------
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
            //ShareRate-------------------------------------
            if (string.IsNullOrWhiteSpace(model.shareRate))
            {
                view.errShareCapital();
            }
            else
            {
                if (double.TryParse(model.shareRate, out num))
                {
                    if (Convert.ToDouble(model.shareRate) < 0)
                    {
                        view.errShareCapital();
                    }
                    else
                    {
                        view.unShareCapital();
                        correct++;
                    }
                }
                else
                {
                    view.errShareCapital();
                }
            }
            //Status---------------------------------------
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
