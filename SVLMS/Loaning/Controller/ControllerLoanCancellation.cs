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
    class ControllerLoanCancellation
    {
        TransactionLoanCancellation view;
        TransactionLoanCancellationModel model;

        public ControllerLoanCancellation(TransactionLoanCancellationModel model, TransactionLoanCancellation view)
        {
            this.view = view;
            this.model = model;
            this.view.Show();

            view.setDataGrid(model.getCancelledLoans());
            view.cancelLoanClicked += new EventHandler(cancelLoanEvent);
            view.dgClicked += new EventHandler(dgClicked);
            view.searchPressed += new EventHandler(searchPressed);
        }

        public void searchPressed(object sender, EventArgs e)
        {
            if (view.getSearchBy() == "Loan No")
            {
                model.LoanNo = view.getTxtSearch();
                view.setDataGrid(model.searchByLoanNo());
            }

            else if (view.getSearchBy() == "Member Name")
            {
                model.MemberName = view.getTxtSearch();
                view.setDataGrid(model.searchByMemberName());

            }

        }

        public void cancelLoanEvent(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to cancel this loan?","Loan Cancellation",MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                if (this.validateLoanCancellation())
                {
                    this.setModelValues();
                    model.insertCancelledLoan();
                    MessageBox.Show("Loan is successfully canceled.");
                    view.setDataGrid(model.getCancelledLoans());
                    this.refreshFields();
                }
            }
        }

        public void dgClicked(object sender, EventArgs e)
        {
            DataGridView dg = view.getDataGrid();
            int row = dg.CurrentCell.RowIndex;
            model.LoanNo = dg.Rows[row].Cells[0].Value.ToString();

            model.searchLoanCancellationInfo();

            view.setLoanNo(model.LoanNo);
            view.setMemberName(model.MemberName);
            view.setLoanType(model.LoanType);
            view.setApprovedAmount(model.ApprovedAmount);
            view.setApprovalDate(model.ApprovalDate);
        }

        public void setModelValues()
        {
            model.ApprovalDate = view.getApprovalDate();
            model.ApprovedAmount = view.getApprovedAmount();
            model.LoanNo = view.getLoanNo();
            model.LoanType = view.getLoanType();
            model.MemberName = view.getMemberName();
            model.ReasonCancellation = view.getReasonCancellation();
        }

        public bool validateLoanCancellation()
        {
            bool check = false;
            if (view.getLoanNo().Length != 0)
            {
                if (Validator.isAlphanumeric(view.getReasonCancellation()) && view.getReasonCancellation().Length > 0 && view.getReasonCancellation().Length <= 100)
                {
                    check = true;
                }

                else
                {
                    MessageBox.Show("Invalid value in reason for cancellation.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else
            {
                MessageBox.Show("Please select a loan application first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return check;
        }

        public void refreshFields()
        {
            view.setReasonCancellation("");
            view.setMemberName("");
            view.setLoanType("");
            view.setLoanNo("");
            view.setApprovedAmount("");
        }
    }
}
