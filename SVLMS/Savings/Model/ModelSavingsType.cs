using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;

namespace SVLMS.Savings.Model
{
    class ModelSavingsType
    {
        public string savingsTypeID { get; set; }
        public string savingsName { get; set; }
        public string maintainingBalance { get; set; }
        public string startingEarn { get; set; }
        public string noAccountHolders { get; set; }
        public string interest { get; set; }
        public string maxWithdrawalAmount { get; set; }
        public string maxWithdrawDuration { get; set; }
        public int maxWithdrawalTime { get; set; }
        public int isPercentage { get; set; }
        public string status { get; set; }
        public string minimumWithdrawal { get; set; }
        public string maxWithdrawDurationDays { get; set; }

        public void insertSavingsType()
        {
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            string sql = "exec sp_MaintenanceAddSavingsType @1,@2,@6,@7,@8,@9,@10,@11,@12";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@1",savingsName);
            parameters.Add("@2",maintainingBalance);
            parameters.Add("@6",maxWithdrawalAmount);
            parameters.Add("@7",maxWithdrawDuration);
            parameters.Add("@8",maxWithdrawalTime);
            parameters.Add("@9",noAccountHolders);
            parameters.Add("@10",interest);
            parameters.Add("@11",isPercentage);
            parameters.Add("@12",status);
            dal.executeNonQuery(sql,parameters);
        }

        public DataSet getSavingsTypeInformation()
        {
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            //string sql = "select * from vw_SavingsType";
            string sql = "select savingsTypeID, savingsName as 'Savings Type', interestRate as 'Interest Rate', (case when isPercentage = 1 then 'Percentage' else 'Fixed' end) as 'Rate',(case when status = 1 then 'Active' else 'Inactive' end) as 'Status' from SavingsType";
            DataSet ds = dal.executeDataSet(sql);
            return ds;
        }

        public DataSet searchSavingsType(string filter, string txtSearch)
        {
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            string sql = "";
            if (filter == "No Filter")
            {
                sql = "select savingsTypeID, savingsName as 'Savings Type', interestRate as 'Interest Rate', (case when isPercentage = 1 then 'Percentage' else 'Fixed' end) as 'Rate',(case when status = 1 then 'Active' else 'Inactive' end) as 'Status' from SavingsType where savingsName like @1";
            }

            else if (filter == "Active")
            {
                sql = "select savingsTypeID, savingsName as 'Savings Type', interestRate as 'Interest Rate', (case when isPercentage = 1 then 'Percentage' else 'Fixed' end) as 'Rate',(case when status = 1 then 'Active' else 'Inactive' end) as 'Status' from SavingsType where savingsName like @1 and status = 1";
            }

            else
            {
                sql = "select savingsTypeID, savingsName as 'Savings Type', interestRate as 'Interest Rate', (case when isPercentage = 1 then 'Percentage' else 'Fixed' end) as 'Rate',(case when status = 1 then 'Active' else 'Inactive' end) as 'Status' from SavingsType where savingsName like @1 and status = 0";
            }
            parameters.Add("@1","%"+txtSearch+"%");
            DataSet ds = dal.executeDataSet(sql, parameters);
            return ds;
        }

        public void updateSavingsType()
        {
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            string sql = "exec sp_MaintenanceUpdateSavingsType @13, @1,@2,@6,@7,@8,@9,@10,@11,@12";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@13", savingsTypeID);
            parameters.Add("@1", savingsName);
            parameters.Add("@2", maintainingBalance);
            parameters.Add("@6", maxWithdrawalAmount);
            parameters.Add("@7", maxWithdrawDuration);
            parameters.Add("@8", maxWithdrawalTime);
            parameters.Add("@9", noAccountHolders);
            parameters.Add("@10", interest);
            parameters.Add("@11", isPercentage);
            parameters.Add("@12", status);
            dal.executeNonQuery(sql, parameters);
        }

        public string getNextID()
        {
            string id = "";
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            string sql = "select ISNULL(MAX(savingsTypeID),0) from SavingsType";
            SqlDataReader reader = dal.executeReader(sql);
            if (reader.Read())
            {
                id = (Convert.ToInt32(reader[0])+1).ToString();
            }
            return id;
        }

        public void searchSavingsType()
        {
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            //string sql = "select * from SavingsType A inner join SavingsInterestHistory B ON (A.savingsTypeID = B.savingsTypeID) where A.savingsTypeID = @1 and isCurrent = 1";
            string sql = "select * from SavingsType where savingsTypeID = @1";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@1",savingsTypeID);
            SqlDataReader reader = dal.executeReader(sql,parameters);
            if (reader.Read())
            {
                savingsTypeID = reader[0].ToString();
                interest = reader[1].ToString();
                isPercentage = Convert.ToInt32(reader[2]);
                savingsName = reader[3].ToString();
                maintainingBalance = reader[4].ToString();
                maxWithdrawalAmount = reader[5].ToString();
                maxWithdrawDuration = reader[6].ToString();
                maxWithdrawalTime = Convert.ToInt32(reader[7]);
                noAccountHolders = reader[8].ToString();
                status = reader[9].ToString();
            }
        }
    }
}
