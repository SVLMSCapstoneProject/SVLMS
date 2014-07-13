using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using SVLMS.Loaning;
using SVLMS.Loaning.View;
using SVLMS.Loaning.Controller;
using SVLMS.Loaning.Model;


namespace SVLMS.Savings.Model
{
    class ModelTimeDepositAccount
    {
        public string accountNo { get; set; }
        public string memberName { get; set; }
        public string timeDepositNo { get; set; }
        public string initialDeposit { get; set; }
        public string term { get; set; }
        public string termDays { get; set; }
        public string maturityInstruction { get; set; }
        public string savingsAccountNo { get; set; }
        public string savingsAccountNoTransfer { get; set; }
        public string preterminationPenalty { get; set; }
        public string interestID { get; set; }
        public string userID { get; set; }

        public string getNextId()
        {
            string timeAccountNo = "0000000";
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbconnectionString"].ConnectionString);
            string sql = "select ISNULL(MAX(CAST(timeAccountNo as INT)),0) from TimeDepositAccount";
            SqlDataReader reader = dal.executeReader(sql);
            if(reader.Read())
            {
                timeAccountNo += (Convert.ToInt32(reader[0])+ 1).ToString();
            }
            timeAccountNo = timeAccountNo.Substring(timeAccountNo.Length - 7);
            return timeAccountNo;
        }


        public DataSet getMembers()
        {
            
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            string sql = "select accountNo as 'Account No',(LName+', '+FName+' '+MName) as 'Member Name' from Member where isTerminated != 1 ";
            DataSet ds = dal.executeDataSet(sql);
            return ds;
            
        }

        public DataSet searchByAccountNo()
        {

            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            string sql = "select accountNo as 'Account No',(LName+' '+FName+','+MName) as 'Member Name' from Member where accountNo LIKE @1 and isTerminated != 1 ";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@1","%" + accountNo + "%");
            DataSet ds = dal.executeDataSet(sql,parameters);
            return ds;

        }

        public DataSet searchByMemberName()
        {

            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            string sql = "select accountNo as 'Account No',(LName+' '+FName+','+MName) as 'Member Name' from Member where isTerminated != 1 and (LName+' '+FName+','+MName) LIKE @1 and isTerminated = 0";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@1", "%" + memberName + "%");
            DataSet ds = dal.executeDataSet(sql,parameters);
            return ds;

        }


        public void getMemberInfo()
        {
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            string sql = "select accountNo as 'Account No',(LName+' '+FName+','+MName) as 'Member Name' from Member where accountNo = @1 and isTerminated = 0";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@1", accountNo);
            SqlDataReader reader = dal.executeReader(sql, parameters);
            if (reader.Read())
            {
                accountNo = reader[0].ToString();
                memberName = reader[1].ToString();
            }
        }

        public void insertPreterminationPenalty()
        {
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            string sql = "update TimeDepositAccount set preterminationPenalty = @1 where timeAccountNo = @2";
            parameters.Add("@1",preterminationPenalty);
            parameters.Add("@2", timeDepositNo);
            dal.executeNonQuery(sql, parameters);
        }

        public void updateMaturityOption()
        {
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            string sql = "update TimeDepositAccount set maturityInstruction = @1, savingsAccountNo = @2 where timeAccountNo = @3";
            parameters.Add("@1",maturityInstruction);
            if (savingsAccountNo.Trim().Length != 0)
            {
                parameters.Add("@2", savingsAccountNo);
            }

            else
            {
                parameters.Add("@2",System.Data.SqlTypes.SqlString.Null);
            }
            
            parameters.Add("@3",timeDepositNo);
            dal.executeNonQuery(sql, parameters);
        }

        public void addAccount(string interestID) 
        {
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            //string sql = "insert into TimeDepositAccount (timeAccountNo,openingDatetime,isClosed,currentBalance,maturityDate,accountNo,interestID,maturityInstruction,savingsAccountNo) values( @3,CURRENT_TIMESTAMP,0,@4,DATEADD(dd,@5,CURRENT_TIMESTAMP),@2,@1,@6,@7)";
            string sql = "exec sp_TransactionCreateTimeDeposit @1,@2,@3,@4,@5,@6,@7,@8";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@1", timeDepositNo);
            parameters.Add("@2", initialDeposit);
            parameters.Add("@3", termDays);
            parameters.Add("@4", maturityInstruction);
            parameters.Add("@5", accountNo);
            parameters.Add("@6", savingsAccountNo);
            parameters.Add("@7", interestID);
            parameters.Add("@8", userID);
            dal.executeNonQuery(sql,parameters);
        }

        public DataSet getTerms()
        {
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            string sql = "select distinct daysNo, (CAST(daysNo as varchar) + ' days') as daysDisplay from TimeDepositRates";
            DataSet ds = dal.executeDataSet(sql);
            return ds;
        }

        public bool checkTimebracket()
        {
            bool check = false;
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            string sql = "select * from TimeDepositInterest i where i.timeRateID=(select timeRateID from TimeDepositRates where @1 between minimumRange and maximumRange and daysNo = @2 and status = 1) and isCurrent = 1";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@1", initialDeposit);
            parameters.Add("@2", termDays);
            SqlDataReader reader = dal.executeReader(sql,parameters);
            
            if (reader.HasRows)
            {
                reader.Read();
                check = true;
                interestID = reader[0].ToString();
            }

            return check;
        }

        public DataSet getApplicableRates()
        {
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            string sql = "select A.minimumRange as 'From', A.maximumRange as 'To', B.interestRate as 'Interest' from TimeDepositRates A inner join TimeDepositInterest B on (A.timeRateID = B.timeRateID) where @1 between A.minimumRange and A.maximumRange and A.daysNo = @2 and A.status = 1 and B.isCurrent = 1 order by A.minimumRange";
            parameters.Add("@1",initialDeposit);
            parameters.Add("@2",termDays);
            DataSet ds = dal.executeDataSet(sql, parameters);
            return ds;
        }

        public DataSet getAllApplicableRates()
        {
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            string sql = "select A.minimumRange as 'From', A.maximumRange as 'To', B.interestRate as 'Interest' from TimeDepositRates A inner join TimeDepositInterest B on (A.timeRateID = B.timeRateID) where A.daysNo = @2 and A.status = 1 and B.isCurrent = 1 order by A.minimumRange";
            parameters.Add("@2", termDays);
            DataSet ds = dal.executeDataSet(sql, parameters);
            return ds;
        }
    }
}
