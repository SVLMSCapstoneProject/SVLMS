using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using SVLMS.Loaning.Model;
using SVLMS.Loaning.View;
using System.Windows.Forms;

namespace SVLMS.Loaning.Controller
{
    class ControllerShareCapitalTransaction
    {

        SVLMS.Savings.Model.ModelMember modelMember = new SVLMS.Savings.Model.ModelMember();

        ModelShareCapitalTransaction model;
        TransactionShareCapital view;

        public ControllerShareCapitalTransaction(ModelShareCapitalTransaction model, TransactionShareCapital view)
        {
            this.view = view;
            this.model = model;

            this.view.setBtnDepositClickedEvent(btnDepositClickedEvent);
            this.view.setBtnPrintStockClickedEvent(btnPrintStockClickedEvent);
            this.view.setDataGridCellClickedEvent(dataGridDoubleClickedEvent);
            this.RefreshFields();
            this.view.Show();
            this.view.searchPressed += new EventHandler(searchPressed);
        }

        public void searchPressed(object sender,EventArgs e)
        {
         
            if (view.getSearchBy() == "Account No")
            {
                modelMember.accountNo = view.getTxtSearch();
                view.setDataGridMemberInfo(modelMember.searchByAccountNo());

                       
            }

            else if (view.getSearchBy() == "Member Name")
            {
                modelMember.memberLastName = view.getTxtSearch();
                view.setDataGridMemberInfo(modelMember.searchByMemberName());
                
            }

        }
        public void dataGridDoubleClickedEvent(object sender, DataGridViewCellEventArgs e)
        {
            this.RenewFields();
        }

        public void btnDepositClickedEvent(object sender, EventArgs e)
        {
            //Set fields to model
            model.transactionType = "D";
            model.amount = view.getShareAmount();
            model.userID = ModelUser.userID;

            if (this.validateDeposit())
            {
                //Insert Transaction
                model.insertShareTransaction();

                //GetChange
                //double change = 0;
                //change = Convert.ToDouble(view.getAmountTendered()) - Convert.ToDouble(view.getShareAmount());

                MessageBox.Show("Share capital has been successfully deposited.");
                this.RenewFields();
                //view.setChange(change.ToString());
            }
        }

        public bool validateDeposit()
        {
            bool check = false;
            if (view.getAccountNo().Length != 0)
            {
                if (Validator.isValidAmount(view.getShareAmount()))
                {
                    check = true;
                    //if (Validator.isValidAmount(view.getAmountTendered()))
                    //{
                    //    double shareAmount = Convert.ToDouble(view.getShareAmount());
                    //    double amountTendered = Convert.ToDouble(view.getAmountTendered());
                    //    if (amountTendered >= shareAmount)
                    //    {
                    //        check = true;
                    //    }

                    //    else
                    //    {
                    //        MessageBox.Show("Amount tendered must be greater than or equal to the share amount.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //    }
                    //}

                    //else
                    //{
                    //    MessageBox.Show("Invalid amount for amount tendered.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //}
                }

                else
                {
                    MessageBox.Show("Invalid amount for share capital amount.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else
            {
                MessageBox.Show("Please choose a member.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return check;
        }

        public void btnPrintStockClickedEvent(object sender, EventArgs e)
        {

        }

        public void RenewFields()
        {
            DataGridView dg = view.getDataGridMemberInfo();
            int currentRow = dg.CurrentCell.RowIndex;

            //To get share capital balance
            model.accountNo = dg.Rows[currentRow].Cells[0].Value.ToString();
            model.shareID = model.getShareCapitalID();

            //Set the renewed fields
            view.setAccountNo(dg.Rows[currentRow].Cells[0].Value.ToString());
            view.setMemberName(dg.Rows[currentRow].Cells[1].Value.ToString());
            view.setTotalShares(model.getShareCapitalBalance());
            view.setShareAmount("");
            //view.setAmountTendered("");

            //Check if able to print certificate
            ModelMemberType modelMemberType = new ModelMemberType();
            if (modelMemberType.canPrintCertificate(model.getShareCapitalBalance()))
            {
                view.enableBtnPrintStock();
            }

            else
            {
                view.disableBtnPrintStock();
            }
        }

        public void RefreshFields()
        {
            view.setMemberName("");
            view.setTotalShares("");
            view.setShareAmount("");
            view.setAccountNo("");
            view.setDataGridMemberInfo(modelMember.displayMemberInfo());
            view.disableBtnPrintStock();
        }
    }
}
