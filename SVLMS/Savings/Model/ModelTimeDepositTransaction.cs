using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace SVLMS.Savings.Model
{
    class ModelTimeDepositTransaction
    {
        public string timeAccountNo { get; set; }
        public string transactionID { get; set; }
        public string amount { get; set; }
        public string transactionType { get; set; }
        public string transactionDatetime{ get; set; }
        public string userID{ get; set; }
        public string timeDayID { get; set; }
        public string memberName { get; set; }

        public DataSet getTimeDepositAccounts()
        {
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            string sql = "select timeAccountNo as 'Time Deposit No', (B.FName + ' '+ B.LName) as 'Member Name', currentBalance as 'Amount', maturityDate as 'Maturity Date', B.accountNo  from TimeDepositAccount A inner join Member B on (A.accountNo = B.accountNo) where A.isClosed = 0 and B.isTerminated = 0 order by timeAccountNo";
            DataSet ds = dal.executeDataSet(sql);
            return ds;
        }

        public SqlDataReader searchTimeDepositAccount()
        {
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            string sql = "select timeAccountNo as 'TD No', (B.FName + ' '+ B.LName) as 'Member Name', currentBalance as 'Amount', maturityDate as 'Maturity Date', B.accountNo, A.maturityInstruction, A.savingsAccountNo,C.interestRate  from TimeDepositAccount A inner join Member B on (A.accountNo = B.accountNo) inner join TimeDepositInterest C on (A.interestID = C.interestID) where A.timeAccountNo = @1";
            parameters.Add("@1",timeAccountNo);
            SqlDataReader reader = dal.executeReader(sql, parameters);
            return reader;
        }

        public DataSet searchByTimeDepositNo()
        {
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            string sql = "select timeAccountNo as 'Time Deposit No', (B.FName + ' '+ B.LName) as 'Member Name', currentBalance as 'Amount', maturityDate as 'Maturity Date', B.accountNo  from TimeDepositAccount A inner join Member B on (A.accountNo = B.accountNo) where A.timeAccountNo LIKE @1 and A.isClosed = 0 and B.isTerminated = 0";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@1", "%" + timeAccountNo + "%");
            DataSet ds = dal.executeDataSet(sql,parameters);
            return ds;
        }

        public DataSet searchByMemberName()
        {
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            string sql = "select timeAccountNo as 'Time Deposit No', (B.FName + ' '+ B.LName) as 'Member Name', currentBalance as 'Amount', maturityDate as 'Maturity Date', B.accountNo  from TimeDepositAccount A inner join Member B on (A.accountNo = B.accountNo) where (B.FName + ' '+ B.LName) LIKE @1 and A.isClosed = 0 and B.isTerminated = 0";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@1","%" + memberName + "%");
            DataSet ds = dal.executeDataSet(sql,parameters);
            return ds;
        }

        public string insertTransaction()
        {
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            string sql = "exec sp_TransactionTimeDeposit @1,@2,@3,@4";
            parameters.Add("@1",amount);
            parameters.Add("@2", transactionType);
            parameters.Add("@3", userID);
            parameters.Add("@4", timeAccountNo);
            SqlDataReader reader = dal.executeReader(sql,parameters);
            if (reader.Read())
            {
                transactionID = reader[0].ToString();
            }
            return transactionID;
        }

        public double getInterest()
        {
            double interest = 0;
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            string sql = "select (A.currentBalance*(B.interestRate/100)) as interestAmount from TimeDepositAccount A inner join TimeDepositInterest B on (A.interestID = B.interestID) where A.timeAccountNo = @1";
            parameters.Add("@1",timeAccountNo);
            SqlDataReader reader = dal.executeReader(sql,parameters);
            if (reader.Read())
            {
                interest = Convert.ToDouble(reader[0]);
            }
            return interest;
        }

        public double getPenalty()
        {
            double daysToCurrent = 0;
            double daysToMature = 0;
            double termElapsed = 0;
            double rateAdjustment = 0;
            double penalty = 0;
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            string sql = "select DATEDIFF(DAY,CAST(openingDatetime as date),maturityDate) as DaysNo from TimeDepositAccount where timeAccountNo = @1";
            string sql2 = "select DATEDIFF(DAY,CAST(openingDatetime as date), CAST(GETDATE() AS DATE))from TimeDepositAccount where timeAccountNo = @1";
            string sql3 = "select ISNULL(rateAdjustment,0) from TimeDepositPenalty where @1 between percentageElapsedMin and percentageElapsedMax and status = 1";
            parameters.Add("@1", timeAccountNo);
            SqlDataReader reader = dal.executeReader(sql, parameters);
            if (reader.Read())
            {
                daysToMature = Convert.ToInt32(reader[0]);
            }
            reader.Close();
            reader = dal.executeReader(sql2, parameters);
            if (reader.Read())
            {
                daysToCurrent = Convert.ToInt32(reader[0]);
            }
            reader.Close();
            parameters.Clear();

            termElapsed = daysToCurrent / daysToMature * 100;
            parameters.Add("@1", termElapsed);
            reader = dal.executeReader(sql3, parameters);
            if (reader.Read())
            {
                rateAdjustment = Convert.ToDouble(reader[0]);
            }
            penalty = this.getInterest() * (rateAdjustment / 100);
            return penalty;
        }
    }
}
