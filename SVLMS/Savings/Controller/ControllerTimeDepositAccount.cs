using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SVLMS.Loaning;
using System.Windows.Forms;
using SVLMS.Savings.View;
using SVLMS.Savings.Controller;
using SVLMS.Savings.Model;
using System.Data;
using System.Data.SqlClient;
namespace SVLMS.Savings.Controller
{
    class ControllerTimeDepositAccount
    {
        ModelTimeDepositAccount model;
        TransactionCreateTimeDeposit view;
        ModelSavingsAccount msa = new ModelSavingsAccount();

        public ControllerTimeDepositAccount(ModelTimeDepositAccount model, TransactionCreateTimeDeposit view)
        {
            this.model = model;
            this.view = view;

            view.Show();
            view.setDgMembers(model.getMembers());
            view.setTimeDepositNo(model.getNextId());
            this.refresh();
            view.setOpenAccountEvent(btnSaveClicked);
            view.setTextSearchEvent(searchPressed);
            view.setDatagridEvent(dgClicked);
            //view.setCboDepositTypeEvent(CboDepositTypeSelectionChanged);
            view.setCboMaturityInstructionsEvent(CboMaturityInstructionSelectionChanged);
            view.setTxtInitialDepositEvent(TxtInitialDepositTextChanged);
            view.setCboDaysEvent(TxtInitialDepositTextChanged);
        }

        public void TxtInitialDepositTextChanged(object sender, EventArgs e)
        {
            double num = 0;
            if (Double.TryParse(view.getInitialDeposit(), out num))
            {
                this.setRates();
            }

            else
            {
                this.setRatesAll();
            }
        }

        private void setRates()
        {
            model.initialDeposit = view.getInitialDeposit();
            model.termDays = view.getCboTerm();
            view.setDataGridRates(model.getApplicableRates());
        }

        private void setRatesAll()
        {
            model.termDays = view.getCboTerm();
            view.setDataGridRates(model.getAllApplicableRates());
        }

        //public void CboDepositTypeSelectionChanged(object sender, EventArgs e)
        //{
        //    if (view.getCboDepositType() == 0)
        //    {
        //        view.disableCboSavings();
        //    }

        //    else
        //    {
        //        view.enableCboSavings();
        //        msa.accountNo = view.getAccountNo();
        //        view.setCboSavings(msa.getSavingsAccounts());
        //    }
        //}

        public void CboMaturityInstructionSelectionChanged(object sender, EventArgs e)
        {
            if (view.getCboMaturityInstruction() >= 3)
            {
                view.enableCboSavingsTransfer();
                msa.accountNo = view.getAccountNo();
                view.setCboSavingsTransfer(msa.getSavingsAccounts());
            }

            else
            {
                view.disableCboSavingsTransfer();
            }
        }

        public void searchPressed(object sender,EventArgs e)
        {
            if (view.getSearchBy() == "Account No")
            {
                model.accountNo = view.getTxtSearch();
                view.setDgMembers(model.searchByAccountNo());
            }

            else if (view.getSearchBy() == "Member Name")
            {
                model.memberName = view.getTxtSearch();
                view.setDgMembers(model.searchByMemberName());

            }
        }

        public void btnSaveClicked(object sender, EventArgs e)
        {
            model.accountNo = view.getAccountNo();
            model.memberName = view.getMemberName();
            model.timeDepositNo = view.getTimeDepositNo();
            model.initialDeposit = view.getInitialDeposit();
            model.termDays = view.getCboTerm();
            model.maturityInstruction = view.getCboMaturityInstruction().ToString();
            model.savingsAccountNo = view.getCboSavingsTransfer();
            model.userID = ModelUser.userID;
            DialogResult dr = MessageBox.Show("Are you sure you want to open this account?", "Time Deposit", MessageBoxButtons.YesNo);

            if (dr == DialogResult.Yes)
            {
                if (this.validateTimeDeposit()) 
                {
                    if (model.checkTimebracket())
                    {
                        //if (view.getCboDepositType() == 1)
                        //{
                        //    ModelSavingsTransaction mst = new ModelSavingsTransaction();
                        //    mst.savingsAccountID = view.getCboSavings();
                        //    mst.amount = view.getInitialDeposit();
                        //    mst.transactionType = "W";
                        //    mst.controlNo = "";
                        //    mst.userID = ModelUser.userID;
                        //    mst.comments = "Withdrawal for creation of time deposit";
                        //    mst.insertSavingsTransaction();
                        //}
                        model.addAccount(model.interestID);
                        MessageBox.Show("Time deposit successfully created.");
                        refresh();
                    }

                    else
                    {
                        MessageBox.Show("No available rates found for the initial amount.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }

        public bool validateTimeDeposit()
        {
            bool check = false;
            if (view.getAccountNo().Length != 0)
            {
                if (Validator.isValidAmount(view.getInitialDeposit()))
                {
                    check = true;

                    if (view.getCboMaturityInstruction() > 2)
                    {
                        if (view.getCboSavingsTransfer().Length != 0)
                        {
                            check = true;
                        }

                        else
                        {
                            check = false;
                            MessageBox.Show("The member has no savings account.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }

                else
                {
                    MessageBox.Show("Invalid amount for the initial deposit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else
            {
                MessageBox.Show("Please choose a member.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return check;
        }

        public void refresh()
        {
            view.setAccountNo("");
            view.setMemberName("");
            view.setInitialDeposit("");
            view.setCboTerm(model.getTerms());
            view.setTimeDepositNo(model.getNextId());
            view.setDgMembers(model.getMembers());
            //view.disableCboSavings();
            view.disableCboSavingsTransfer();
            this.setRatesAll();
        }

        public void dgClicked(object sender,DataGridViewCellEventArgs e)
        {
            DataGridView dg = view.getdgMembers();
            int row = dg.CurrentCell.RowIndex;
            model.accountNo = dg.Rows[row].Cells[0].Value.ToString();

            model.getMemberInfo();

            view.setAccountNo(model.accountNo);
            view.setMemberName(model.memberName);
            view.setTimeDepositNo(model.getNextId());
            view.setInitialDeposit("");
            //view.disableCboSavings();
            view.disableCboSavingsTransfer();
            view.refreshCombobox();
        }

    }
}
