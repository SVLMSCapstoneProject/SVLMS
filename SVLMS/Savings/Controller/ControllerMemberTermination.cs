using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using SVLMS.Savings.Model;
using SVLMS.Savings.View;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace SVLMS.Savings.Controller
{
    class ControllerMemberTermination
    {
        ModelMember model;
        TransactionMembershipTermination view;
        Validator validator = new Validator();

        public ControllerMemberTermination(ModelMember model, TransactionMembershipTermination view)
        {
            this.model = model;
            this.view = view;
            this.RefreshFields();
            this.view.Show();
            this.view.setBtnTerminateEvent(btnTerminateMember);
            this.view.setDataGridEvent(dgMembersClicked);
            this.view.setBtnCloseAccount(btnCloseAccountsEvent);
            this.view.setTextSearchEvent(txtSearchChanged);
            this.view.setCboOperationEvent(CboOperationSelectionChangedCommitted);
        }

        public void CboOperationSelectionChangedCommitted(object sender, EventArgs e)
        {
            if (view.getOperation() == 0)
            {
                view.showPanelTermination();
                view.setDataGrid(model.displayMemberInfo());
                view.setLblTerminationMembership("Date of Membership:");
                this.RefreshFields();
            }

            else
            {
                view.showPanelCloseAccount();
                view.setDataGrid(model.displayTerminatedMembers());
                view.setLblTerminationMembership("Date of Termination:");
                this.RefreshFields();
            }
        }

        public void txtSearchChanged(object sender,EventArgs e)
        {
            if (view.getOperation() == 0)
            {
                if (view.getSearchBy() == "Account No")
                {
                    model.accountNo = view.getTxtSearch();
                    view.setDataGrid(model.searchByAccountNo());
                
                }

                else if (view.getSearchBy() == "Member Name")
                {
                    model.memberLastName = view.getTxtSearch();
                    view.setDataGrid(model.searchByMemberName());
                
                }
            }

            else
            {
                if (view.getSearchBy() == "Account No")
                {
                    model.accountNo = view.getTxtSearch();
                    view.setDataGrid(model.searchTerminatedAccountNo());
                }

                else if (view.getSearchBy() == "Member Name")
                {
                    model.memberLastName = view.getTxtSearch();
                    view.setDataGrid(model.searchTerminatedMemberName());

                }
            }
        }

        public void btnCloseAccountsEvent(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Are you sure you want to close all accounts?", "Closing of Accounts", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                if (this.validateCloseAccount())
                {
                    ModelSavingsTransaction mss = new ModelSavingsTransaction();
                    Loaning.Model.ModelShareCapitalTransaction shareModel = new Loaning.Model.ModelShareCapitalTransaction();

                    mss.accountNo = view.getAccountNo();
                    SqlDataReader reader = model.getSavingsAccountsReader();

                    //Close Savings Accounts
                    while (reader.Read())
                    {
                        mss.savingsAccountID = reader["savingsAccountNo"].ToString();
                        mss.transactionType = "C";
                        mss.amount = reader["Current Balance"].ToString();
                        mss.userID = ModelUser.userID;
                        mss.controlNo = "";
                        mss.comments = "";
                        mss.insertSavingsTransaction();
                    }

                    SqlDataReader reader2 = mss.searchShareCapital();
                    if (reader2.Read())
                    {
                        shareModel.shareID = reader2["shareID"].ToString();
                        shareModel.transactionType = "C";
                        shareModel.amount = reader2["currentBalance"].ToString();
                        shareModel.userID = ModelUser.userID;
                        shareModel.insertShareTransaction();
                    }

                    this.RefreshFields();
                }
            }
        }

        public bool validateMemberTermination()
        {
            bool check = false;
            if (view.getAccountNo().Length != 0)
            {
                if (view.getRemarks().Length != 0)
                {
                    if (Validator.isAlphanumeric(view.getRemarks()) && view.getRemarks().Length < 50)
                    {
                        if (Convert.ToDouble(view.getTotalAmount()) >= 0)
                        {
                            check = true;
                        }

                        else
                        {
                            MessageBox.Show("The member's loan balance is greater the total amount.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                    else
                    {
                        MessageBox.Show("Invalid input/s found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                else
                {
                    MessageBox.Show("Please input your remarks.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else
            {
                MessageBox.Show("No member selected.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            return check;
        }

        public bool validateCloseAccount()
        {
            bool check = false;
            if (view.getAccountNo().Length != 0)
            {
                check = true;
            }

            else
            {
                MessageBox.Show("No member selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return check;
        }

        public void tabChangedEvent(object sender, EventArgs e)
        {
            this.RefreshFields();
        }

        public void btnTerminateMember(object sender, EventArgs e)
        {
            model.accountNo = view.getAccountNo();
            model.terminationDate = view.getDateEffective();
            model.terminationReason = view.getReason();
            model.remarks = view.getRemarks();

            //Dialog for yes or no
            DialogResult dialog = MessageBox.Show("Are you sure you want to terminate this member?", "Member Termination", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                if (this.validateMemberTermination())
                {
                    //TerminateMember
                    model.terminateMember();
                    MessageBox.Show("Termination Successful.");
                    this.RefreshFields();
                }
            }
        }

        public void dgMembersClicked(object sender, EventArgs e)
        {
            SVLMS.Loaning.Model.ModelLoan loanModel = new SVLMS.Loaning.Model.ModelLoan();
            DataGridView dg = view.getDataGrid();
            int row = dg.CurrentCell.RowIndex;
            view.setAccountNo(dg.Rows[row].Cells[0].Value.ToString());
            view.setMemberName(dg.Rows[row].Cells[1].Value.ToString());
            DateTime dt = Convert.ToDateTime(dg.Rows[row].Cells[2].Value);
            view.setMembershipDate(dt.ToString("dd/M/yyyy"));
            
            model.accountNo = view.getAccountNo();
            loanModel.accountNo = view.getAccountNo();
            //view.setDataGridSavingsAccounts(model.getSavingsAccounts());
            
            //Reuse function from another model
            ModelSavingsTransaction mss = new ModelSavingsTransaction();
            mss.accountNo = view.getAccountNo();
            SqlDataReader reader = mss.searchShareCapital();
            
            if (reader.Read())
            {
                view.setTotalShares(reader["currentBalance"].ToString());
            }
            view.setLoanBalance(loanModel.getLoanBalance().ToString());
            view.setTotalSavings(model.getTotalSavings());
            double totalAmount = Convert.ToDouble(view.getTotalSavings()) + Convert.ToDouble(view.getTotalShares()) - loanModel.getLoanBalance();
            view.setTotalAmount(totalAmount.ToString());
        }

        public void RefreshFields()
        {
            view.setAccountNo("");
            view.setMemberName("");
            view.setMembershipDate("");
            view.setRemarks("");
            view.setTotalAmount("");
            view.setLoanBalance("");
            view.setTotalSavings("");
            view.setTotalShares("");
            if (view.getOperation() == 0)
            {
                view.setDataGrid(model.displayMemberInfo());
            }

            else
            {
                view.setDataGrid(model.displayTerminatedMembers());
            }
        }
    }
}
