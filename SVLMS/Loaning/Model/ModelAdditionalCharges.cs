using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace SVLMS.Loaning.Model
{
    class ModelAdditionalCharges
    {
        public string chargeID { get; set; }
        public string chargeName { get; set; }
        public string amount { get; set; }
        public string isPercentage { get; set; }
        public string status { get; set; }
        public string loanTypeID { get; set; }
        public List<int> list = new List<int>();
        public string loanChargeID { get; set; }



        public DataSet getLoanTypes()
        {
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            string sql = "select loanTypeID as 'loanTypeID', loanName as 'loanName' from LoanType";
            DataSet ds = dal.executeDataSet(sql);
            return ds;
        }

        public DataSet getChargeInformation()
        {
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            string sql = "select chargeID as 'Charge ID', chargeName as 'Charge name', amount as 'Charge Amount', CASE WHEN isPercentage = 1 THEN 'Percentage' else 'Fixed' end as 'Charge Type', (case when status = 1 then 'Active' else 'Inactive' end) as 'Status' from Charge";
            DataSet ds = dal.executeDataSet(sql);
            return ds;
        }

        public DataSet searchCharges(string filter, string textSearch)
        {
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            string sql = "";
            if (filter == "No Filter")
            {
                sql = "select chargeID as 'Charge ID', chargeName as 'Charge name', amount as 'Charge Amount', CASE WHEN isPercentage = 1 THEN 'Percentage' else 'Fixed' end as 'Charge Type', (case when status = 1 then 'Active' else 'Inactive' end) as 'Status' from Charge where chargeName like @1";
            }

            else if (filter == "Active")
            {
                sql = "select chargeID as 'Charge ID', chargeName as 'Charge name', amount as 'Charge Amount', CASE WHEN isPercentage = 1 THEN 'Percentage' else 'Fixed' end as 'Charge Type', (case when status = 1 then 'Active' else 'Inactive' end) as 'Status' from Charge where status = 1 and chargeName like @1";
            }

            else
            {
                sql = "select chargeID as 'Charge ID', chargeName as 'Charge name', amount as 'Charge Amount', CASE WHEN isPercentage = 1 THEN 'Percentage' else 'Fixed' end as 'Charge Type', (case when status = 1 then 'Active' else 'Inactive' end) as 'Status' from Charge where status = 0 and chargeName like @1";
            }
            parameters.Add("@1","%"+textSearch+"%");
            DataSet ds = dal.executeDataSet(sql,parameters);
            return ds;
        }

        public string getNextID()
        {
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            string sql = "select ISNULL(MAX(chargeID),0) from charge";
            int id = 0;
            SqlDataReader reader = dal.executeReader(sql);
            if (reader.Read())
            {
                id = Convert.ToInt32(reader[0]);
                id++;
            }
            return id.ToString();
        }

        public string[] getLoanTypeID()
        {
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            string sql = "select loanTypeID from LoanCharges where chargeID = @1";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@1",chargeID);
            SqlDataReader reader = dal.executeReader(sql,parameters);
            List<string> loanTypeID = new List<string>();
            while (reader.Read())
            {


                loanTypeID.Add(reader[0].ToString());
            }

            return loanTypeID.ToArray();
        }

        public void searchChargesInformation()
        {
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            string sql = "select * from Charge where chargeID = @1";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@1",chargeID);
            SqlDataReader reader = dal.executeReader(sql,parameters);
            if (reader.Read())
            {
   
                
                chargeID = reader[0].ToString();
                chargeName = reader[1].ToString();
                amount = reader[2].ToString();
                isPercentage = reader[3].ToString();
                status = reader[4].ToString();
            }
        }

        public void searchchargesloantyeInfo()
        {
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            string sql = "select B.loanTypeID as 'loanTypeID', B.loanName as 'loanName' from LoanCharges A inner join LoanType B on(A.loanTypeID=B.loanTypeID) where ChargeID=@1 ";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@1", chargeID);
            SqlDataReader reader = dal.executeReader(sql, parameters);
            list.Clear();
            while (reader.Read())
            {
               // System.Windows.Forms.MessageBox.Show("Test");
                list.Add(int.Parse(reader[0].ToString()));
            }
        }


        public void insertLoanCharges()
        {
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);

            for(int i=0;i<list.Count;i++)
            {
                loanChargeID = this.getNextID2();
                string sql = "insert into LoanCharges values(@1,@2,@3)";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@1", loanChargeID);
                parameters.Add("@2", chargeID);
                parameters.Add("@3", list[i]);
                dal.executeNonQuery(sql, parameters);
                parameters.Clear();
           }
        }


        public string getNextID2()
        {
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            string sql = "select ISNULL(MAX(loanChargeID),0) from LoanCharges";
            int id = 0;
            SqlDataReader reader = dal.executeReader(sql);
            if (reader.Read())
            {
                id = Convert.ToInt32(reader[0]);
                id++;
            }
            return id.ToString();
        }


        public void insertCharges()
        {
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            string sql = "exec sp_MaintenanceAddCharges @1,@2,@3,@4";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@1", chargeName);
            parameters.Add("@2", amount);
            parameters.Add("@3", isPercentage);
            parameters.Add("@4",status);
            dal.executeNonQuery(sql, parameters);
            parameters.Clear();
            
        }



        public void DelLoanCharges()
        {
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            string sql = "delete from LoanCharges where chargeID = @2";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@2", chargeID);
            dal.executeNonQuery(sql, parameters);
           
        }



        public void UpdateLoanCharges()
        {
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            this.DelLoanCharges();

            for (int i = 0; i < list.Count; i++)
            {

                loanChargeID = this.getNextID2();
                string sql = "insert into LoanCharges values(@1,@2,@3)";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@1", loanChargeID);
                parameters.Add("@2", chargeID);
                parameters.Add("@3", list[i]);
                dal.executeNonQuery(sql, parameters);
                parameters.Clear();
            }
        }

        public void updateCharges()
        {
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            string sql = "exec sp_MaintenanceUpdateCharges @4,@1,@2,@3,@5";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@4",chargeID);
            parameters.Add("@1", chargeName);
            parameters.Add("@2", amount);
            parameters.Add("@3", isPercentage);
            parameters.Add("@5", status);
            dal.executeNonQuery(sql, parameters);
            parameters.Clear();
            
 
        
        }
    }
}
