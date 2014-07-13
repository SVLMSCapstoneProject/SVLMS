using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace SVLMS.Savings.Model
{
    class ModelDormancy
    {
        public string dormancyID { get; set; }
        public string inactivityDuration { get; set; }
        public string inactivityTime { get; set; }
        public string deductionAmount { get; set; }
        public string isPercentage { get; set; }
        public string deductionEvery { get; set; }
        public string deductionTime { get; set; }
        public string savingsTypeID { get; set; }
        public string status { get; set; }
        public string isCurrent { get; set; }
        public string effectivityDate { get; set; }

        public DataSet getSavingsTypes()
        {
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            string sql = "select savingsTypeID, savingsName from SavingsType";
            DataSet ds = dal.executeDataSet(sql);
            return ds;
        }

        public DataSet getDormancyInfo(string savingsTypeID)
        {
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            string sql = "select A.savingsTypeID as 'Savings Type ID', A.savingsName as 'Savings Type', B.interestRate as 'Interest', CASE WHEN isPercentage = 1 THEN 'Percentage' else 'Fixed' end as 'Amount' from SavingsType A inner join SavingsInterestHistory B on (A.savingsTypeID = B.savingsTypeID) where B.isCurrent = 1 AND A.savingsName = @1";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            DataSet ds = dal.executeDataSet(sql,parameters);
            return ds;
        }

        public string getNextID()
        {
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            string sql = "select ISNULL(MAX(dormancyID),0) from Dormancy";
            int nextID = 0;
            SqlDataReader reader = dal.executeReader(sql);
            if (reader.Read())
            {
                nextID = Convert.ToInt32(reader[0]);
            }
            nextID++;
            return nextID.ToString();
        }

        public DataSet searchDormancy(string filter, string txtSearch)
        {
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            string sql = "";
            if (filter == "No Filter")
            {
                sql = "select A.savingsTypeID as 'Savings Type ID', A.savingsName as 'Savings Type', B.deductionAmount as 'DeductionAmount', CASE WHEN B.isPercentage = 1 THEN 'Percentage' else 'Fixed' end as 'Amount',(case when A.status = 1 then 'Active' else 'Inactive' end) as 'Status' from SavingsType A inner join Dormancy B on (A.savingsTypeID = B.savingsTypeID) where A.savingsName like @1 order by A.savingsTypeID";
            }

            else if (filter == "Active")
            {
                sql = "select A.savingsTypeID as 'Savings Type ID', A.savingsName as 'Savings Type', B.deductionAmount as 'DeductionAmount', CASE WHEN B.isPercentage = 1 THEN 'Percentage' else 'Fixed' end as 'Amount',(case when A.status = 1 then 'Active' else 'Inactive' end) as 'Status' from SavingsType A inner join Dormancy B on (A.savingsTypeID = B.savingsTypeID) where A.savingsName like @1 and B.status = 1 order by A.savingsTypeID";
            }

            else
            {
                sql = "select A.savingsTypeID as 'Savings Type ID', A.savingsName as 'Savings Type', B.deductionAmount as 'DeductionAmount', CASE WHEN B.isPercentage = 1 THEN 'Percentage' else 'Fixed' end as 'Amount',(case when A.status = 1 then 'Active' else 'Inactive' end) as 'Status' from SavingsType A inner join Dormancy B on (A.savingsTypeID = B.savingsTypeID) where A.savingsName like @1 and B.status = 0 order by A.savingsTypeID";
            }
            parameters.Add("@1","%"+txtSearch+"%");
            DataSet ds = dal.executeDataSet(sql, parameters);
            return ds;
        }

        public void insertDormancy()
        {
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            string sql = "exec sp_MaintenanceAddDormancy @1,@2,@3,@4,@5,@6,@7,@8";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@1",inactivityDuration);
            parameters.Add("@2",inactivityTime);
            parameters.Add("@3",deductionAmount);
            parameters.Add("@4",isPercentage);
            parameters.Add("@5",deductionEvery);
            parameters.Add("@6",deductionTime);
            parameters.Add("@7",savingsTypeID);
            parameters.Add("@8",status);
            dal.executeNonQuery(sql,parameters);
        }

        public void updateDormancy()
        {
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            string sql = "exec sp_MaintenanceUpdateDormancy @1,@2,@3,@4,@5,@6,@7,@8";
            parameters.Add("@1",inactivityDuration);
            parameters.Add("@2",inactivityTime);
            parameters.Add("@3",deductionAmount);
            parameters.Add("@4",isPercentage);
            parameters.Add("@5",deductionEvery);
            parameters.Add("@6",deductionTime);
            parameters.Add("@7",savingsTypeID);
            parameters.Add("@8",status);
            dal.executeNonQuery(sql,parameters);
        }

        public void searchDormancyInfo()
        {
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            string sql = "select * from Dormancy where savingsTypeID = @1 ";//and effectivityDate > CAST(GETDATE() AS DATE)";
            Dictionary<string,object> parameters = new Dictionary<string,object>();
            parameters.Add("@1",savingsTypeID);
            SqlDataReader reader = dal.executeReader(sql,parameters);
            if (reader.Read())
            {
                dormancyID = reader[0].ToString();
                inactivityDuration = reader[1].ToString();
                inactivityTime = reader[2].ToString();
                deductionAmount = reader[3].ToString();
                isPercentage = reader[4].ToString();
                deductionEvery = reader[5].ToString();
                deductionTime = reader[6].ToString();
                status = reader[7].ToString();
                isCurrent = reader[8].ToString();
                savingsTypeID = reader[9].ToString();
            }
        }

        public DataSet getDormancyInfo()
        {
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            string sql = "select A.savingsTypeID as 'Savings Type ID', A.savingsName as 'Savings Type', B.deductionAmount as 'DeductionAmount', CASE WHEN B.isPercentage = 1 THEN 'Percentage' else 'Fixed' end as 'Amount',(case when A.status = 1 then 'Active' else 'Inactive' end) as 'Status' from SavingsType A inner join Dormancy B on (A.savingsTypeID = B.savingsTypeID) order by A.savingsTypeID";
            DataSet ds = dal.executeDataSet(sql);
            return ds;
        }
    }
}
