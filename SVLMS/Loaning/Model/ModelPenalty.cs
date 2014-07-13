using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;


namespace SVLMS.Loaning.Model
{
    class ModelPenalty
    {
        public string penaltyID { get; set; }
        public string penaltyAmount { get; set; }
        public string gracePeriod { get; set; }
        public string graceTime { get; set; }
        public string interval { get; set; }
        public string intervalTime { get; set; }
        public string isPercentage { get; set; }
        public string isChargeToAmort { get; set; }
        public string isChargeToCurrent { get; set; }
        public string loanTypeID { get; set; }
        public string effectivityDate { get; set; }
        public string status{ get; set; }

        public DataSet getLoanTypes()
        {
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            string sql = "select loanTypeID,loanName from LoanType;";
            DataSet ds = dal.executeDataSet(sql);
            return ds;
        }

        public void insertLoanPenalty()
        {
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            string sql = "exec sp_MaintenanceAddLoanPenalty @1,@2,@3,@4,@5,@6,@7,@8,@9,@10,@11";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@1",penaltyAmount);
            parameters.Add("@2", interval);
            parameters.Add("@3", gracePeriod);
            parameters.Add("@4", graceTime);
            parameters.Add("@5", intervalTime);
            parameters.Add("@6", isPercentage);
            parameters.Add("@7", 1);
            parameters.Add("@8", 0);
            parameters.Add("@9", loanTypeID);
            parameters.Add("@10", effectivityDate);
            parameters.Add("@11",status);
            dal.executeDataSet(sql,parameters);
        }

        public void updateLoanPenalty()
        {
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            string sql = "exec sp_MaintenanceUpdateLoanPenalty @11,@1,@2,@3,@4,@5,@6,@7,@8,@9,@10,@12";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@1", penaltyAmount);
            parameters.Add("@2", interval);
            parameters.Add("@3", gracePeriod);
            parameters.Add("@4", graceTime);
            parameters.Add("@5", intervalTime);
            parameters.Add("@6", isPercentage);
            parameters.Add("@7", 1);
            parameters.Add("@8", 0);
            parameters.Add("@9", loanTypeID);
            parameters.Add("@10", effectivityDate);
            parameters.Add("@11",penaltyID);
            parameters.Add("@12", status);
            dal.executeDataSet(sql, parameters);
        }

        public void searchInformation()
        {
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            string sql = "select penaltyAmount,duration,gracePeriod,graceTime,durationTime,isPercentage,loanTypeID, effectivityDate, status from LoanPenaltySettings where penaltyID = @1";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@1", penaltyID);
            SqlDataReader reader = dal.executeReader(sql,parameters);
            if (reader.Read())
            {
                penaltyAmount = reader[0].ToString();
                interval = reader[1].ToString();
                gracePeriod = reader[2].ToString();
                graceTime = reader[3].ToString();
                intervalTime = reader[4].ToString();
                isPercentage = reader[5].ToString();
                loanTypeID = reader[6].ToString();
                effectivityDate = reader[7].ToString();
                status = reader[8].ToString();
            }
        }

        public bool penaltyRateExists()
        {
            bool check = false;
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            string sql = "select * from LoanPenaltySettings where loanTypeID = @1 and effectivityDate = @2 and status = 1 ";
            parameters.Add("@1",loanTypeID);
            parameters.Add("@2", effectivityDate);
            SqlDataReader reader = dal.executeReader(sql, parameters);
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
            string sql = "select * from LoanPenaltySettings where loanTypeID = @1 and effectivityDate = @2 and status = 1 and penaltyID != @3";
            parameters.Add("@1", loanTypeID);
            parameters.Add("@2", effectivityDate);
            parameters.Add("@3", penaltyID);
            SqlDataReader reader = dal.executeReader(sql, parameters);
            if (reader.HasRows)
            {
                check = true;
            }
            return check;
        }

        public DataSet getPenaltyInformation()
        {
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            string sql = "select A.penaltyID as PenaltyID, B.loanName as 'Loan Type', A.penaltyAmount as 'Penalty Amount', (case when isPercentage = 1 then 'Percentage' else 'Fixed Amount' end) as 'Penalty Rate', A.effectivityDate as 'EffectivityDate' from LoanPenaltySettings A inner join LoanType B on (A.loanTypeID = B.loanTypeID) where effectivityDate > CAST(GETDATE() AS DATE) ";
            DataSet ds = dal.executeDataSet(sql);
            return ds;
        }

        public DataSet searchLoanPenalty(string filter, string textSearch)
        {
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            string sql = "";
            if (filter == "No Filter")
            {
                sql = "select A.penaltyID as PenaltyID, B.loanName as 'Loan Type', A.penaltyAmount as 'Penalty Amount', (case when isPercentage = 1 then 'Percentage' else 'Fixed Amount' end) as 'Penalty Rate', A.effectivityDate as 'EffectivityDate' from LoanPenaltySettings A inner join LoanType B on (A.loanTypeID = B.loanTypeID) where B.loanName like @1";
            }

            else if (filter == "Incoming Penalty")
            {
                sql = "select A.penaltyID as PenaltyID, B.loanName as 'Loan Type', A.penaltyAmount as 'Penalty Amount', (case when isPercentage = 1 then 'Percentage' else 'Fixed Amount' end) as 'Penalty Rate', A.effectivityDate as 'EffectivityDate' from LoanPenaltySettings A inner join LoanType B on (A.loanTypeID = B.loanTypeID) where effectivityDate > CAST(GETDATE() AS DATE) and B.loanName like @1";
            }

            else
            {
                sql = "select A.penaltyID as PenaltyID, B.loanName as 'Loan Type', A.penaltyAmount as 'Penalty Amount', (case when isPercentage = 1 then 'Percentage' else 'Fixed Amount' end) as 'Penalty Rate', A.effectivityDate as 'EffectivityDate' from LoanPenaltySettings A inner join LoanType B on (A.loanTypeID = B.loanTypeID) where effectivityDate <= CAST(GETDATE() AS DATE) and B.loanName like @1";
            }
            parameters.Add("@1","%"+textSearch+"%");
            DataSet ds = dal.executeDataSet(sql, parameters);
            return ds;
        }
    }
}
