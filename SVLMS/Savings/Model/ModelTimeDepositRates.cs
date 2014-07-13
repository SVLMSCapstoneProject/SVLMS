using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace SVLMS.Savings.Model
{
    class ModelTimeDepositRates
    {
        public string timeRateID { get; set; }
        public string numberOfDays { get; set; }
        public string minimumBracket { get; set; }
        public string maximumBracket { get; set; }
        public string interestRate { get; set; }
        public string status { get; set; }
        public string bracketRate { get; set; }
        public string daysRate { get; set; }
        public string from { get; set; }
        public string to { get; set; }
        public string error { get; set; }

        public void insertTimeDepositRate()
        {
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            string sql = "exec sp_MaintenanceAddTimeDepositRates @1,@2,@3,@4,@5";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@1", numberOfDays);
            parameters.Add("@2", minimumBracket);
            parameters.Add("@3", maximumBracket);
            parameters.Add("@4", interestRate);
            parameters.Add("@5",status);
            dal.executeNonQuery(sql, parameters);            
        }

        public DataSet getTimeDepositInfoDisplay()
        {
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            //string sql = "select timeRateID as 'TimeRateID', CAST(a.daysNo as VARCHAR(10)) + ' days' as NumberOfDays, minimumRange as 'From', maximumRange as 'To', InterestRate, Status from vw_TimeDepositInfoDisplay a where changeDatetime = (select MAX(changeDateTime) from vw_TimeDepositInfoDisplay where TimeRateID = a.TimeRateID)";
            string sql = "select A.timeRateID, CAST(A.daysNo as VARCHAR(10)) + ' days' as 'Number of Days',A.minimumRange as 'From ',A.maximumRange as 'To',B.interestRate as 'Interest Rate',(case when status = 1 then 'Active' else 'Inactive' end) as 'Status' from TimeDepositRates A inner join TimeDepositInterest B on (A.timeRateID = B.timeRateID) where B.isCurrent = 1 order by minimumRange,daysNo";
            DataSet ds = dal.executeDataSet(sql);
            return ds;
        }

        public void searchTimeDepositInfo()
        {
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            //string sql = "select timeRateID, a.daysNo, minimumRange, maximumRange, InterestRate, Status from vw_TimeDepositInfoDisplay a where changeDatetime = (select MAX(changeDateTime) from vw_TimeDepositInfoDisplay where TimeRateID = a.TimeRateID) and TimeRateID = @1";
            string sql = "select A.timeRateID, A.daysNo ,A.minimumRange,A.maximumRange,B.interestRate as 'Interest Rate',Status from TimeDepositRates A inner join TimeDepositInterest B on (A.timeRateID = B.timeRateID) where B.isCurrent = 1 and A.TimeRateID = @1";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@1", timeRateID);
            SqlDataReader reader = dal.executeReader(sql, parameters);
            if (reader.Read())
            {
                numberOfDays = reader[1].ToString();
                minimumBracket = reader[2].ToString();
                maximumBracket = reader[3].ToString();
                interestRate = reader[4].ToString();
                status = reader[5].ToString();
            }
        }

        public void updateTimeDepositRate()
        {
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            string sql = "exec sp_MaintenanceUpdateTimeDepositRate @1,@2,@3,@4,@5,@6";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@1", numberOfDays);
            parameters.Add("@2", minimumBracket);
            parameters.Add("@3", maximumBracket);
            parameters.Add("@4", interestRate);
            parameters.Add("@5", status);
            parameters.Add("@6", timeRateID);
            dal.executeNonQuery(sql, parameters);                    
        }

        public DataSet getFilter(int sortBy, string filter)
        {
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            string sql = "";
            if (sortBy == 0)
            {
                if (filter == "No Filter")
                {
                    sql = "select A.timeRateID, CAST(A.daysNo as VARCHAR(10)) + ' days' as 'Number of Days',A.minimumRange as 'From',A.maximumRange as 'To',B.interestRate as 'Interest Rate',Status from TimeDepositRates A inner join TimeDepositInterest B on (A.timeRateID = B.timeRateID) where B.isCurrent = 1";
                }

                else if (filter == "Active")
                {
                    sql = "select A.timeRateID, CAST(A.daysNo as VARCHAR(10)) + ' days' as 'Number of Days',A.minimumRange as 'From',A.maximumRange as 'To',B.interestRate as 'Interest Rate',Status from TimeDepositRates A inner join TimeDepositInterest B on (A.timeRateID = B.timeRateID) where B.isCurrent = 1 and A.status = 1";
                }

                else
                {
                    sql = "select A.timeRateID, CAST(A.daysNo as VARCHAR(10)) + ' days' as 'Number of Days',A.minimumRange as 'From',A.maximumRange as 'To',B.interestRate as 'Interest Rate',Status from TimeDepositRates A inner join TimeDepositInterest B on (A.timeRateID = B.timeRateID) where B.isCurrent = 1 and A.status = 0";
                }
                
            }
            
            else if (sortBy == 1)
            {
                if (filter == "No Filter")
                {
                    sql = "select A.timeRateID, CAST(A.daysNo as VARCHAR(10)) + ' days' as 'Number of Days',A.minimumRange as 'From ',A.maximumRange as 'To',B.interestRate as 'Interest Rate' from TimeDepositRates A inner join TimeDepositInterest B on (A.timeRateID = B.timeRateID) where B.isCurrent = 1 and daysNo LIKE @1 order by daysNo,minimumRange";
                }

                else if (filter == "Active")
                {
                    sql = "select A.timeRateID, CAST(A.daysNo as VARCHAR(10)) + ' days' as 'Number of Days',A.minimumRange as 'From ',A.maximumRange as 'To',B.interestRate as 'Interest Rate' from TimeDepositRates A inner join TimeDepositInterest B on (A.timeRateID = B.timeRateID) where B.isCurrent = 1 and daysNo LIKE @1 and A.status = 1 order by daysNo,minimumRange";
                }

                else
                {
                    sql = "select A.timeRateID, CAST(A.daysNo as VARCHAR(10)) + ' days' as 'Number of Days',A.minimumRange as 'From ',A.maximumRange as 'To',B.interestRate as 'Interest Rate' from TimeDepositRates A inner join TimeDepositInterest B on (A.timeRateID = B.timeRateID) where B.isCurrent = 1 and daysNo LIKE @1 and A.status = 0 order by daysNo,minimumRange";
                }
                parameters.Add("@1", "%"+daysRate + "%");
            }

            else if (sortBy == 2)
            {
                if (filter == "No Filter")
                {
                    sql = "select A.timeRateID, CAST(A.daysNo as VARCHAR(10)) + ' days' as 'Number of Days',A.minimumRange as 'From ',A.maximumRange as 'To',B.interestRate as 'Interest Rate' from TimeDepositRates A inner join TimeDepositInterest B on (A.timeRateID = B.timeRateID) where B.isCurrent = 1 and (minimumRange LIKE @1 or maximumRange LIKE @2) order by minimumRange,daysNo";
                }

                else if (filter == "Active")
                {
                    sql = "select A.timeRateID, CAST(A.daysNo as VARCHAR(10)) + ' days' as 'Number of Days',A.minimumRange as 'From ',A.maximumRange as 'To',B.interestRate as 'Interest Rate' from TimeDepositRates A inner join TimeDepositInterest B on (A.timeRateID = B.timeRateID) where B.isCurrent = 1 and (minimumRange LIKE @1 or maximumRange LIKE @2) and A.status = 1 order by minimumRange,daysNo";
                }

                else
                {
                    sql = "select A.timeRateID, CAST(A.daysNo as VARCHAR(10)) + ' days' as 'Number of Days',A.minimumRange as 'From ',A.maximumRange as 'To',B.interestRate as 'Interest Rate' from TimeDepositRates A inner join TimeDepositInterest B on (A.timeRateID = B.timeRateID) where B.isCurrent = 1 and (minimumRange LIKE @1 or maximumRange LIKE @2) and A.status = 0 order by minimumRange,daysNo";
                }
                parameters.Add("@1","%"+minimumBracket+"%");
                parameters.Add("@2", "%" + maximumBracket + "%");
            }
            DataSet ds = dal.executeDataSet(sql, parameters);
            parameters.Clear();
            return ds;
        }

        public bool bracketExists()
        {
            bool check = false;
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            //string sql = "select top 1 cast(case when ((minimumRange <= @1 and maximumRange >= @1) or (minimumRange <= @2 and maximumRange >= @2))then 1 else 0 end as int) as Error from TimeDepositRates where status = 1  AND timeRateID != @3 order by Error desc";
            string sql = "select * from TimeDepositRates where (@1 between minimumRange and maximumRange or @2 between minimumRange and maximumRange or minimumRange between @1 and @2 or maximumRange between @1 and @2) and daysNo = @3 and status = 1";
            parameters.Add("@1", from);
            parameters.Add("@2", to);
            parameters.Add("@3",numberOfDays);
            //parameters.Add("@3", timeRateID);
            SqlDataReader reader = dal.executeReader(sql, parameters);
            if (reader.HasRows)
            {
                check = true;
            }
            return check;
        }

        public bool bracketExistsUpdate()
        {
            bool check = false;
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            //string sql = "select top 1 cast(case when ((minimumRange <= @1 and maximumRange >= @1) or (minimumRange <= @2 and maximumRange >= @2))then 1 else 0 end as int) as Error from TimeDepositRates where status = 1  AND timeRateID != @3 order by Error desc";
            string sql = "select * from TimeDepositRates where (@1 between minimumRange and maximumRange or @2 between minimumRange and maximumRange or minimumRange between @1 and @2 or maximumRange between @1 and @2) and daysNo = @3 and status = 1 and timeRateID != @4";
            parameters.Add("@1", from);
            parameters.Add("@2", to);
            parameters.Add("@3", numberOfDays);
            parameters.Add("@4", timeRateID);
            //parameters.Add("@3", timeRateID);
            SqlDataReader reader = dal.executeReader(sql, parameters);
            if (reader.HasRows)
            {
                check = true;
            }
            return check;
        }
    }
}
