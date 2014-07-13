using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using SVLMS.Savings;
using SVLMS.Savings.View;
using SVLMS.Savings.Controller;
using SVLMS.Savings.Model;

namespace SVLMS.Savings.Model
{
    class ModelTimeDepositPenalty
    {
        public string penaltyID { get; set; }
        public string minimum { get; set; }
        public string maximum { get; set; }
        public string rateAdjusmtment { get; set; }
        public string status { get; set; }

        public void insertTimeDepositPenalty()
        {
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            string sql = "exec sp_InsertMaintenanceTimeDepositPenalty @1, @2, @3, @4";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@1", minimum);
            parameters.Add("@2", maximum);
            parameters.Add("@3", rateAdjusmtment);
            parameters.Add("@4", status);
            dal.executeNonQuery(sql, parameters);
        }

        public DataSet filterTimeDepositPenalty(string filter)
        {
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            string sql = "";

            if (filter == "No Filter")
            {
                sql = "select * from vw_TimeDepositPenaltyInfoDisplay";
            }

            else if (filter == "Active")
            {
                sql = "select * from vw_TimeDepositPenaltyInfoDisplay where Status = 'Active'";
            }

            else
            {
                sql = "select * from vw_TimeDepositPenaltyInfoDisplay where status = 'Inactive'";
            }
            DataSet ds = dal.executeDataSet(sql, parameters);
            return ds;
        }

        public DataSet getTimeDepositPenalty()
        {
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            string sql = "select * from vw_TimeDepositPenaltyInfoDisplay";
            DataSet ds = dal.executeDataSet(sql);
            return ds;                    
        }

        public void UpdateTimeDepositPenalty()
        {
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            string sql = "exec sp_UpdateMaintenanceTimeDepositPenalty @1, @2, @3";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@1", rateAdjusmtment);
            parameters.Add("@2", penaltyID);
            parameters.Add("@3", status);
            dal.executeNonQuery(sql, parameters);
        }

        public bool penaltyRateExists()
        {
            bool check = false;
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            string sql = "select * from TimeDepositPenalty where (@1 between percentageElapsedMin and percentageElapsedMax or @2 between percentageElapsedMin and percentageElapsedMax or percentageElapsedMin between @1 and @2 or percentageElapsedMax between @1 and @2) and status = 1";
            parameters.Add("@1",minimum);
            parameters.Add("@2", maximum);
            SqlDataReader reader = dal.executeReader(sql,parameters);
            if (reader.HasRows)
            {
                check = true;
            }
            return check;
        }

        public bool penaltyRateExistsUpdate()
        {
            bool check = false;
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            string sql = "select * from TimeDepositPenalty where (@1 between percentageElapsedMin and percentageElapsedMax or @2 between percentageElapsedMin and percentageElapsedMax or percentageElapsedMin between @1 and @2 or percentageElapsedMax between @1 and @2) and status = 1 and penaltyID != @3";
            parameters.Add("@1", minimum);
            parameters.Add("@2", maximum);
            parameters.Add("@3", penaltyID);
            SqlDataReader reader = dal.executeReader(sql, parameters);
            if (reader.HasRows)
            {
                check = true;
            }
            return check;
        }

        public void searchTimeDepositPenaltyInfo()
        {
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            string sql = "select * from vw_TimeDepositPenaltyInfoDisplay where penaltyID = @1";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@1", penaltyID);
            SqlDataReader reader = dal.executeReader(sql, parameters);
            if (reader.Read())
            {
                penaltyID = reader[0].ToString();
                minimum = reader[1].ToString();
                maximum = reader[2].ToString();
                rateAdjusmtment = reader[3].ToString();
                status = reader[4].ToString();
            }
        }
    }
}
