using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace SVLMS.Loaning.Model
{
    class ModelLoanRates
    {

        public string loanRatesID { get; set; }
        public string interestRate { get; set; }
        public string isPercentageInterest{ get; set; }
        public string shareRate { get; set; }
        public string isPercentageShare { get; set; }
        public string savingsRate { get; set; }
        public string isPercentageSavings{ get; set; }
        public string effectivityDate { get; set; }
        public string status { get; set; }
        public string loanTypeID{ get; set; }

        public void insertLoanRates()
        {
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            string sql = "exec sp_MaintenanceAddLoanRates @2,@3,@6,@7,@8,@9,@10";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@2",interestRate);
            parameters.Add("@3", isPercentageInterest);
            parameters.Add("@6", shareRate);
            parameters.Add("@7", isPercentageShare);
            parameters.Add("@8", effectivityDate);
            parameters.Add("@9", status);
            parameters.Add("@10", loanTypeID);
            dal.executeNonQuery(sql, parameters);
        }

        public void updateLoanRates()
        {
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            string sql = "exec sp_MaintenanceUpdateLoanRates @1,@2,@3,@6,@7,@8,@9,@10";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@1", loanRatesID);
            parameters.Add("@2", interestRate);
            parameters.Add("@3", isPercentageInterest);
            parameters.Add("@6", shareRate);
            parameters.Add("@7", isPercentageShare);
            parameters.Add("@8", effectivityDate);
            parameters.Add("@9", status);
            parameters.Add("@10", loanTypeID);
            dal.executeNonQuery(sql, parameters);
        }

        public string getNextRateID()
        {
            string nextID = "";
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            string sql = "select ISNULL(MAX(loanRatesID),0) + 1 from LoanRates";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            SqlDataReader reader = dal.executeReader(sql);
            if (reader.Read())
            {
                nextID = reader[0].ToString();
            }
            return nextID;
        }

        public bool rateExists()
        {
            bool check = false;
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            string sql = "select * from LoanRates where loanTypeID = @1 and effectivityDate = @2 and status = 1";
            parameters.Add("@1",loanTypeID);
            parameters.Add("@2", effectivityDate);
            SqlDataReader reader = dal.executeReader(sql, parameters);
            if (reader.HasRows)
            {
                check = true;
            }
            return check;
        }

        public bool rateExistsUpdate()
        {
            bool check = false;
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            string sql = "select * from LoanRates where loanTypeID = @1 and effectivityDate = @2 and status = 1 and loanRatesID != @3";
            parameters.Add("@1", loanTypeID);
            parameters.Add("@2", effectivityDate);
            parameters.Add("@3", loanRatesID);
            SqlDataReader reader = dal.executeReader(sql, parameters);
            if (reader.HasRows)
            {
                check = true;
            }
            return check;
        }

        public void searchRate()
        {
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            string sql = "select * from LoanRates where loanRatesID = @1";
            parameters.Add("@1", loanRatesID);
            SqlDataReader reader = dal.executeReader(sql, parameters);
            if (reader.Read())
            {
                loanRatesID = reader[0].ToString();
                interestRate = reader[1].ToString();
                isPercentageInterest = reader[2].ToString();
                shareRate = reader[3].ToString();
                isPercentageShare = reader[4].ToString();
                effectivityDate = reader[7].ToString();
                status = reader[8].ToString();
                loanTypeID = reader[9].ToString();
            }
        }

        public void setLoanRatesValuesByLoanType()
        {
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            string sql = "select top 1 * from LoanRates B where loanTypeID = @1 and effectivityDate <= CAST(GETDATE() AS DATE) and status = 1 order by effectivityDate desc";
            parameters.Add("@1",loanTypeID);
            SqlDataReader reader = dal.executeReader(sql,parameters);
            if (reader.Read())
            {
                loanRatesID = reader[0].ToString();
                interestRate = reader[1].ToString();
                isPercentageInterest = reader[2].ToString();
                shareRate = reader[3].ToString();
                isPercentageShare = reader[4].ToString();
                effectivityDate = reader[7].ToString();
                status = reader[8].ToString();
                loanTypeID = reader[9].ToString();
            }
        }

        public DataSet getRatesInfo()
        {
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            string sql = "select A.loanRatesID as RatesID, B.loanName as 'LoanType',A.interestRate as 'Interest Rate', A.shareRate as 'Share Capital Rate', A.effectivityDate as 'Effectivity Date' from LoanRates A inner join LoanType B on (A.loanTypeID = B.loanTypeID) where A.effectivityDate > CAST(GETDATE() AS DATE)";
            DataSet ds = dal.executeDataSet(sql, parameters);
            return ds;
        }

        public DataSet searchLoanRates(string filter, string textSearch)
        {
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            string sql = "";
            if (filter == "No Filter")
            {
                sql = "select A.loanRatesID as RatesID, B.loanName as 'LoanType',A.interestRate as 'Interest Rate', A.shareRate as 'Share Capital Rate', A.effectivityDate as 'Effectivity Date' from LoanRates A inner join LoanType B on (A.loanTypeID = B.loanTypeID) where B.loanName LIKE @1";
            }
            
            else if (filter == "Archived")
            {
                sql = "select A.loanRatesID as RatesID, B.loanName as 'LoanType',A.interestRate as 'Interest Rate', A.shareRate as 'Share Capital Rate', A.effectivityDate as 'Effectivity Date' from LoanRates A inner join LoanType B on (A.loanTypeID = B.loanTypeID) where A.effectivityDate <= CAST(GETDATE() AS DATE) and B.loanName LIKE @1";
            }

            else
            {
                sql = "select A.loanRatesID as RatesID, B.loanName as 'LoanType',A.interestRate as 'Interest Rate', A.shareRate as 'Share Capital Rate', A.effectivityDate as 'Effectivity Date' from LoanRates A inner join LoanType B on (A.loanTypeID = B.loanTypeID) where A.effectivityDate > CAST(GETDATE() AS DATE) and B.loanName LIKE @1";
            }
            parameters.Add("@1","%"+textSearch+"%");
            DataSet ds = dal.executeDataSet(sql, parameters);
            return ds;
        }
    }
}
