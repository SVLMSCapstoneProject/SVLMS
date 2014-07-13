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
    class ControllerUnfreezeAccount
    {
        ModelSavingsAccount model;
        TransactionUnfreezeAccount view;

        public ControllerUnfreezeAccount(ModelSavingsAccount model, TransactionUnfreezeAccount view)
        {
            this.view = view;
            this.model = model;

            this.RefreshFields();
            this.view.Show();
            this.view.dgClicked += new EventHandler(dgDoubleClick);
            this.view.unfreezeClicked += new EventHandler(btnUnfreeze);
        }

        public void btnUnfreeze(object sender, EventArgs e)
        {
            ModelSavingsTransaction m = new ModelSavingsTransaction();
            m.referenceID = model.savingsAccountID;
            m.isSavings = "1";
            m.transactionType = "D";
            m.amount = view.getAmount();
            m.userID = ModelUser.userID;

            //Insert Transaction
            m.insertSavingsTransaction();
            this.RefreshFields();
        }

        public void dgDoubleClick(object sender, EventArgs e)
        {
            DataGridView dg = view.getDataGrid();
            int row = dg.CurrentCell.RowIndex;
            view.setAccountNo(dg.Rows[row].Cells["AccountNo"].Value.ToString());
            view.setMemberName(dg.Rows[row].Cells["MemberName"].Value.ToString());
            view.setSavingsAccount(dg.Rows[row].Cells["SavingsType"].Value.ToString());
            view.setCurrentBalance(dg.Rows[row].Cells["currentBalance"].Value.ToString());
            view.setLastTransaction(dg.Rows[row].Cells["LastTransaction"].Value.ToString());
            model.savingsAccountID = dg.Rows[row].Cells["SavingsAccountID"].Value.ToString();

        }

        public void RefreshFields()
        {
            view.setDataGrid(model.displayDormantAccounts());
            view.setAccountNo("");
            view.setMemberName("");
            view.setLastTransaction("");
            view.setSavingsAccount("");
            view.setCurrentBalance("");
        }
    }
}
