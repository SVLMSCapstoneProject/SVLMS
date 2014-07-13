using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace SVLMS.Savings.Model
{
    class ModelSavingsTransaction
    {
        public string savingsTransactionID { get; set; }
        public string referenceID { get; set; }
        public string isSavings { get; set; }
        public string transactionType { get; set; }
        public string amount { get; set; }
        public string userID { get; set; }
        public string controlNo { get; set; }
        public string comments { get; set; }


        //Member Table
        public string accountNo { get; set; }

        //Savings Account Table
        public string savingsAccountID { get; set; }

        //Share Capital Table
        public string shareID { get; set; }

        public string insertSavingsTransaction()
        {
            string transactionID = "";
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            string sql = "exec sp_TransactionSavingsAccount @1,@2,@3,@4,@5,@6";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@1",transactionType);
            parameters.Add("@2",amount);
            parameters.Add("@3",controlNo);
            parameters.Add("@4",savingsAccountID);
            parameters.Add("@5", userID);
            parameters.Add("@6",comments);

            SqlDataReader reader = dal.executeReader(sql, parameters);
            if (reader.Read())
            {
                transactionID = reader[0].ToString();
            }
            return transactionID;
        }

        public DataSet getSavingsAccounts()
        {
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            //Sql function
            string sql = "select * from func_GetSavingsAccounts(@1)";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@1", accountNo);
            DataSet ds = dal.executeDataSet(sql, parameters);
            return ds;
        }

        public SqlDataReader searchSavingsAccounts()
        {
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            //Sql function
            string sql = "select * from func_GetSavingsAccounts(@1)";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@1", accountNo);
            SqlDataReader reader = dal.executeReader(sql, parameters);
            return reader;
        }

        public SqlDataReader searchShareCapital()
        {
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            //Sql function
            string sql = "select * from func_GetShareCapital(@1)";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@1", accountNo);
            SqlDataReader reader = dal.executeReader(sql, parameters);
            return reader;
        }

        public SqlDataReader getSavingsBalance()
        {
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            //Sql function
            string sql = "select * from func_GetSavingsAccount(@1)";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@1", savingsAccountID);
            SqlDataReader reader = dal.executeReader(sql, parameters);
            return reader;
        }

        public string getCurrentBalance(string savingsAccountNo)
        {
            string amount = "0";
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            string sql = "select currentBalance from SavingsAccount where savingsAccountNo = @1";
            parameters.Add("@1",savingsAccountNo);
            SqlDataReader reader = dal.executeReader(sql,parameters);
            if (reader.Read())
            {
                amount = reader[0].ToString();
            }
            return amount;
        }

        public string getSignatureImage(string savingsAccountNo)
        {
            string signature = "";
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            string sql = "select signatureImage from MemberAccountHolder where savingsAccountNo = @1 and isPrimary = 1 and isRemoved = 0";
            parameters.Add("@1",savingsAccountNo);
            SqlDataReader reader = dal.executeReader(sql,parameters);
            if (reader.Read())
            {
                signature = reader[0].ToString();
            }
            return signature;
        }
    }
}
