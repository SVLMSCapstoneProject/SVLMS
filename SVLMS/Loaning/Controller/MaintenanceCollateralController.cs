using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SVLMS.Loaning.Controller;
using SVLMS.Loaning.Model;
using SVLMS.Loaning.View;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SVLMS.Loaning.Controller
{
    class MaintenanceCollateralController
    {
        MaintenanceCollaterallView view;
        ModelCollateral model;

        public MaintenanceCollateralController(ModelCollateral model, MaintenanceCollaterallView view)
        {
            this.view = view;
            this.model = model;
            view.Show();

            view.enableBtnSave();
            view.disableBtnUpdate();
   
            view.setCollateralId(model.getCollateralID());
            view.saveClicked += new EventHandler(btnSaveClicked);
            view.updateClicked += new EventHandler(btnUpdateClicked);
            view.dgClicked += new EventHandler(dgClicked);
            view.clearClicked += new EventHandler(btnClearEvent);
            view.setCollateralInfo(model.getCollateralInfo());
            this.RefreshFields();
        }

        public void btnClearEvent(object sender, EventArgs e)
        {
            this.RefreshFields();
        }

        public void btnUpdateClicked(object sender, EventArgs e)
        {
            this.setModelValues();
            int validate = Validate();

            if (validate == 4)
            {
                view.setCollateralId(model.getCollateralID());
                model.updateCollateral();
                model.deleteCollateralLoans();
                model.insertCollateralLoan();
                view.setCollateralId(model.getCollateralID());
                view.setCollateralInfo(model.getCollateralInfo());
                MessageBox.Show("The Record is Successfully Updated.");
                this.RefreshFields();
            }
            else
            {
                MessageBox.Show("Invalid Input/s", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public void btnSaveClicked(object sender, EventArgs e)
        {
            this.setModelValues();
            int validate = Validate();

            if (validate == 4)
            {
                MessageBox.Show("The Record is Successfully Inserted");
                view.setCollateralId(model.getCollateralID());
                model.insertCollateral();
                model.insertCollateralLoan();
                view.setCollateralId(model.getCollateralID());
                view.setCollateralInfo(model.getCollateralInfo());
                this.RefreshFields();
            }
            else
            {
                MessageBox.Show("Invalid Input/s", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public void dgClicked(object sender,EventArgs e)
        {
            //this.RefreshFields();

            DataGridView dgv = view.getCollateralInfo();
            int row = dgv.CurrentCell.RowIndex;
            model.collateralId = dgv.Rows[row].Cells[0].Value.ToString();
            model.searchCollateralLoan();
            view.setCollateralId(dgv.Rows[row].Cells[0].Value.ToString());
            view.setCollateralName(dgv.Rows[row].Cells[1].Value.ToString());
            view.setDesc(dgv.Rows[row].Cells[2].Value.ToString());
            view.setCollateralValue(dgv.Rows[row].Cells[3].Value.ToString());
            view.setStatus(dgv.Rows[row].Cells[4].Value.ToString());
            view.setchecklistbox(model.list);
            view.enableBtnUpdate();
            view.disableBtnSave();
        }

        public void setModelValues()
        {
            model.collateralId = view.getCollateralId();
            model.collateralName = view.getCollateralName();
            model.collateralDesc = view.getDesc();
            model.collateralValue = view.getCollateralValue();
            model.status = view.getStatus();
            model.list = view.getchecklistselected();
        }

        public void RefreshFields()
        {
            view.setCollateralId(model.getCollateralID());
            view.setCollateralName("");
            view.setDesc("");
            view.setStatus("1");
            view.setCollateralValue("");
            view.setCollateralInfo(model.getCollateralInfo());
            view.enableBtnSave();
            view.disableBtnUpdate();
            view.setListLoanType(model.getLoanTypes());
            model.list.Clear();
            view.setchecklistbox(model.list);
            view.unCollateralName();
            view.unCollateralValue();
            view.unDescription();
            view.unStatus();
        }

        public int Validate()
        {
            this.setModelValues();

            double num;
            bool error = false;
            int correct = 0;
            int status = view.status();
            //CollateralName
            if (string.IsNullOrWhiteSpace(model.collateralName))
            {
                view.errCollateralName();
            }
            else
            {
                char[] str = model.collateralName.ToCharArray();
                for (int i = 0; i < str.Length - 1; i++)
                {
                    if (char.IsLetter(str[i]) || str[i] == ' ')
                    {
                        view.unCollateralName();
                        error = false;
                    }
                    else
                    {
                        view.errCollateralName();
                        i = model.collateralName.Length;
                        error = true;
                    }
                }
                    if (error == false)
                    {
                        view.unCollateralName();
                        correct++;
                    }
            }
            //CollateralValue
            if (string.IsNullOrWhiteSpace(model.collateralValue))
            {
                view.errCollateralValue();
            }
            else
            {
                if (double.TryParse(model.collateralValue, out num))
                {
                    view.unCollateralValue();
                    correct++;
                }
                else
                {
                    view.errCollateralValue();
                }
            }
            //Description
            if (string.IsNullOrWhiteSpace(model.collateralDesc))
            {
                view.errDescription();
            }
            else
            {
                char[] str = model.collateralDesc.ToCharArray();
                for (int i = 0; i < str.Length - 1; i++)
                {
                    if (char.IsLetter(str[i]) || str[i] == ' ')
                    {
                        view.unDescription();
                        error = false;
                    }
                    else
                    {
                        view.errDescription();
                        i = model.collateralDesc.Length;
                        error = true;
                    }
                }
                if (error == false)
                {
                    view.unDescription();
                    correct++;
                }
            }
            //Status(ActiveInactive)
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
