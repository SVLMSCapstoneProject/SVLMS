using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace SVLMS.Savings.View
{
    public partial class TransactionFamilyMember : Form
    {
        public string accountNo{ get; set; }
        public string savingsAccountNo { get; set; }
        public event EventHandler chooseFamily;

        public TransactionFamilyMember(string accountNo)
        {
            InitializeComponent();
            this.accountNo = accountNo;
        }

        public DataGridView getDataGrid()
        {
            return dgFamilyMember;            
        }

        public void setDataGrid(DataSet ds)
        {
            
            dgFamilyMember.DataSource = ds.Tables[0];
        }

        private void dgFamilyMember_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (chooseFamily != null)
            {
                chooseFamily(sender, e);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (chooseFamily != null)
            {
                chooseFamily(sender,e);
            }
        }

        public void setIsFamily(string text)
        {
            if (text == "0")
            {
                rbtnMember.Checked = true;
            }

            if (text == "1")
            {
                rbtnFamilyMember.Checked = true;
            }
        }

        public string getIsFamily()
        {
            string isFamily = "0";
            if (rbtnFamilyMember.Checked)
            {
                isFamily = "1";
            }

            if (rbtnMember.Checked)
            {
                isFamily = "0";
            }
            return isFamily;
        }

        private void rbtnFamilyMember_Click(object sender, EventArgs e)
        {
            this.setDataGrid("1");
        }

        private void rbtnMember_Click(object sender, EventArgs e)
        {
            this.setDataGrid("0");
        }

        public void setDataGrid(string isFamily)
        {
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@1",accountNo);
            parameters.Add("@2",savingsAccountNo);
            string sql = "";
            if (isFamily == "1")
            {
                //sql = "select familyID as FamilyID, (LName + ', '+FName+' '+MName) as Name, (case when relationship = 1 then 'Son' when relationship = 2 then 'Daughter' when relationship = 3 then 'Cousin' when relationship = 4 then 'Mother' when relationship = 5 then 'Father' when relationship = 6 then 'Grand Father'	when relationship = 7 then 'Grand Mother' else 'Spouse' end ) as Relationship from Family where accountNo = '0000005' and isDependent = 1";
                sql = "select familyID as FamilyID, (LName + ', '+FName+' '+MName) as Name, (case when relationship = 1 then 'Son' when relationship = 2 then 'Daughter' when relationship = 3 then 'Cousin' when relationship = 4 then 'Mother' when relationship = 5 then 'Father' when relationship = 6 then 'Grand Father'	when relationship = 7 then 'Grand Mother' else 'Spouse' end ) as Relationship from Family where accountNo = @1 and familyID not in (select B.familyID from FamilyAccountHolder B where savingsAccountNo = @2)";
            }

            else
            {
                //sql = "select accountNo as AccountNo, (LName + ', '+FName+' '+MName) as 'Member Name' from Member where accountNo != @1 and isTerminated = 0";
                sql = "select A.accountNo as AccountNo, (A.LName + ', '+A.FName+' '+A.MName) as 'Member Name' from Member A where A.accountNo != @1 and A.isTerminated = 0 and A.accountNo not in (select B.accountNo from MemberAccountHolder B where B.savingsAccountNo = @2) ";
            }
            DataSet ds = dal.executeDataSet(sql,parameters);
            dgFamilyMember.DataSource = ds.Tables[0];
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            string isFamily = this.getIsFamily();
            string sql = "";
            if (isFamily == "1")
            {
                //sql = "select familyID as FamilyID, (LName + ', '+FName+' '+MName) as Name, (case when relationship = 1 then 'Son' when relationship = 2 then 'Daughter' when relationship = 3 then 'Cousin' when relationship = 4 then 'Mother' when relationship = 5 then 'Father' when relationship = 6 then 'Grand Father'	when relationship = 7 then 'Grand Mother' else 'Spouse' end ) as Relationship from Family where accountNo = @1 and isDependent = 1 and (LName + ', '+FName+' '+MName) LIKE @2";
                sql = "select familyID as FamilyID, (LName + ', '+FName+' '+MName) as Name, (case when relationship = 1 then 'Son' when relationship = 2 then 'Daughter' when relationship = 3 then 'Cousin' when relationship = 4 then 'Mother' when relationship = 5 then 'Father' when relationship = 6 then 'Grand Father'	when relationship = 7 then 'Grand Mother' else 'Spouse' end ) as Relationship from Family where accountNo = @1 and familyID not in (select B.familyID from FamilyAccountHolder B where savingsAccountNo = @2) and (LName + ', '+FName+' '+MName) LIKE @3";
            }

            else
            {
                //sql = "select accountNo as AccountNo, (LName + ', '+FName+' '+MName) as 'Member Name' from Member where accountNo != @1 and isTerminated = 0 and (LName + ', '+FName+' '+MName) like @2";
                sql = "select A.accountNo as AccountNo, (A.LName + ', '+A.FName+' '+A.MName) as 'Member Name' from Member A where A.accountNo != @1 and A.isTerminated = 0 and A.accountNo not in (select B.accountNo from MemberAccountHolder B where B.savingsAccountNo = @2) and (LName + ', '+FName+' '+MName) LIKE @3";
            }
            parameters.Add("@1", accountNo);
            parameters.Add("@2", savingsAccountNo);
            parameters.Add("@3", "%" + txtSearch.Text + "%");
            DataSet ds = dal.executeDataSet(sql, parameters);
            dgFamilyMember.DataSource = ds.Tables[0];
        }
    }
}
