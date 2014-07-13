using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace SVLMS.Savings.Model
{
    class ModelSavingsAccount
    {
        public string savingsAccountID { get; set; }
        public string accountNo { get; set; }
        public string familyID { get; set; }
        public string initialDeposit { get; set; }
        public string userID { get; set; }
        public string savingsTypeID { get; set; }
        public string signatureImage { get; set; }
        public string currentBalance { get; set; }

        public void createSavingsAccount()
        {
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            string sql = "exec sp_CreateSavingsAccount @1,@2,@3,@4,@5";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@1",accountNo);
            parameters.Add("@2",savingsTypeID);
            parameters.Add("@3", initialDeposit);
            parameters.Add("@4",userID);
            parameters.Add("@5",signatureImage);
            dal.executeNonQuery(sql,parameters);
        }

        public string getNextSavingsAccountNo()
        {
            long nextID = 0;
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            string sql = "select ISNULL(MAX(savingsAccountNo),'0000000000') as SavingsNo from SavingsAccount";
            SqlDataReader reader = dal.executeReader(sql);            
            if (reader.Read())
            {
                savingsAccountID = reader[0].ToString();
            }
            nextID = Convert.ToInt64(savingsAccountID) + 1;
            savingsAccountID = "0000000000" + nextID.ToString();
            savingsAccountID = savingsAccountID.Substring(savingsAccountID.Length - 10);
            return savingsAccountID;
        }

        public DataSet displayDormantAccounts()
        {
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            string sql = "select * from vw_DormantAccounts";
            DataSet ds = dal.executeDataSet(sql);
            return ds;
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

        public DataSet getSavingsType()
        {
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            string sql = "select savingsTypeID, savingsName from SavingsType";
            //string sql = "select savingsTypeID, savingsName from SavingsType where savingsTypeID NOT IN (select savingsTypeID from SavingsAccount B inner join AccountHolders C on (B.savingsAccountID = C.savingsAccountID) where C.accountNo = @1 and B.isClosed = 0)";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@1", accountNo);
            DataSet ds = dal.executeDataSet(sql, parameters);
            return ds;
        }

        public DataSet getFamilyAccountHolders()
        {
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            string sql = "select B.familyID as 'Family ID', (B.LName + ', '+ B.FName + ' '+ B.MName) as Name, 'Secondary Holder' as 'Type' from FamilyAccountHolder A inner join Family B on (A.familyID = B.familyID) where A.savingsAccountNo = @1 and isRemoved != 1";
            //string sql = "select B.familyID as 'Family ID', (B.LName + ', '+ B.FName + ' '+ B.MName) as Name, A.isPrimary, (CASE WHEN isPrimary = 1 then 'Primary Holder' else 'Joint Account Holder' end) as 'Account Holder Type' from FamilyAccountHolder A inner join Family B on (A.familyID = B.familyID) where A.savingsAccountNo = @1 and isRemoved != 1";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@1", savingsAccountID);
            DataSet ds = dal.executeDataSet(sql,parameters);
            return ds;
        }

        public DataSet getMemberSecondaryHolders()
        {
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            //string sql = "select B.accountNo as 'Account No', (B.LName + ', '+ B.FName + ' '+ B.MName) as Name from MemberAccountHolder A inner join Member B on (A.accountNo = B.accountNo) where A.savingsAccountNo = @1 and A.accountNo != @2 and isRemoved != 1";
            string sql = "select B.accountNo as 'Account No', (B.LName + ', '+ B.FName + ' '+ B.MName)  as Name, (case when A.isPrimary = 1 then 'Primary Holder' else 'Secondary Holder' end) as 'Type' from MemberAccountHolder A inner join Member B on (A.accountNo = B.accountNo) where A.savingsAccountNo = @1 and isRemoved != 1 and B.accountNo != @2";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@1", savingsAccountID);
            parameters.Add("@2",accountNo);
            DataSet ds = dal.executeDataSet(sql,parameters);
            return ds;
        }

        public DataSet getMemberAccountHolders()
        {
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            //string sql = "select B.accountNo as 'Account No', (B.LName + ', '+ B.FName + ' '+ B.MName) as Name from MemberAccountHolder A inner join Member B on (A.accountNo = B.accountNo) where A.savingsAccountNo = @1 and A.accountNo != @2 and isRemoved != 1";
            string sql = "select B.accountNo as 'Account No', (B.LName + ', '+ B.FName + ' '+ B.MName) as Name, (case when A.isPrimary = 1 then 'Primary Holder' else 'Secondary Holder' end) as 'Type', A.isPrimary from MemberAccountHolder A inner join Member B on (A.accountNo = B.accountNo) where A.savingsAccountNo = @1 and isRemoved != 1";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@1", savingsAccountID);
            DataSet ds = dal.executeDataSet(sql, parameters);
            return ds;
        }

        public int noAccountHolders()
        {
            int number = 0;
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            string sql = "select A.noAccountHolders from SavingsType A inner join SavingsAccount B on (A.savingsTypeID = B.savingsTypeID) where B.savingsAccountNo = @1";
            parameters.Add("@1",savingsAccountID);
            SqlDataReader reader = dal.executeReader(sql,parameters);
            if (reader.Read())
            {
                number = Convert.ToInt32(reader[0]);
            }
            return number;
        }

        public int getNoOfAccountHolders()
        {
            int num1 = 0;
            int num2 = 0;
            int number = 0;
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            string sql = "select ISNULL(COUNT(B.accountNo),0) from SavingsAccount A inner join MemberAccountHolder B on (A.savingsAccountNo = B.savingsAccountNo) where A.savingsAccountNo = @1 and B.isRemoved = 0";
            string sql2 = "select ISNULL(COUNT(B.familyID),0) from SavingsAccount A inner join FamilyAccountHolder B on (A.savingsAccountNo = B.savingsAccountNo) where A.savingsAccountNo = @1 and B.isRemoved = 0";
            parameters.Add("@1",savingsAccountID);
            SqlDataReader reader1 = dal.executeReader(sql,parameters);
            if (reader1.Read())
            {
                num1 = Convert.ToInt32(reader1[0]);
                reader1.Close();
            }

            SqlDataReader reader2 = dal.executeReader(sql2, parameters);
            if (reader2.Read())
            {
                num2 =  Convert.ToInt32(reader2[0]);
            }
            reader2.Close();
            number = num1 + num2;
            return number;
        }

        public void addAccountHolder(string isFamily)
        {
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            string sql = "";
            if (isFamily == "1")
            {
                //sql = "insert into AccountHolders(familyID,savingsAccountNo,isPrimary) values (@1,@2,@3)";
                sql = "insert into FamilyAccountHolder(familyID, savingsAccountNo, isRemoved, signatureImage) values(@1,@2,@3,@4)";
                parameters.Add("@1",familyID);
                parameters.Add("@2", savingsAccountID);
                parameters.Add("@3", 0);
                parameters.Add("@4", signatureImage);
            }

            else
            {
                sql = "insert into MemberAccountHolder(accountNo, savingsAccountNo, isPrimary, isRemoved, signatureImage) values (@1,@2,@3,@4,@5)";
                parameters.Add("@1",accountNo);
                parameters.Add("@2", savingsAccountID);
                parameters.Add("@3", 0);
                parameters.Add("@4", 0);
                parameters.Add("@5",signatureImage);
            }
            dal.executeNonQuery(sql,parameters);
        }

        public void removeAccountHolder(string isFamily)
        {
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            string sql = "";
            if (isFamily == "1")
            {
                sql = "update FamilyAccountHolder set isRemoved = 1, removalDatetime = CURRENT_TIMESTAMP where familyID = @1";
                parameters.Add("@1",familyID);
            }

            else
            {
                sql = "update MemberAccountHolder set isRemoved = 1, removalDatetime = CURRENT_TIMESTAMP where accountNo = @1";
                parameters.Add("@1",accountNo);
            }
            dal.executeNonQuery(sql,parameters);
        }

        public DataSet getAllSavingsAccounts()
        {
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            string sql = "select A.savingsAccountNo as 'Savings Account No', (D.FName+ ' '+D.LName) as 'Account Name', B.savingsName as 'Savings Type',A.currentBalance as 'Balance' from SavingsAccount A inner join SavingsType B on (A.savingsTypeID = B.savingsTypeID) inner join MemberAccountHolder C on (A.savingsAccountNo = C.savingsAccountNo) inner join Member D on (D.accountNo = C.accountNo) where A.isClosed = 0 and C.isPrimary = 1 and D.isTerminated = 0";
            DataSet ds = dal.executeDataSet(sql);
            return ds;
        }

        public DataSet searchAllSavingsAccount(int searchType, string text)
        {
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            string sql = "";
            if (searchType == 0)
            {
                sql = "select A.savingsAccountNo as 'Savings Account No', (D.FName+ ' '+D.LName) as 'Account Name', B.savingsName as 'Savings Type',A.currentBalance as 'Balance' from SavingsAccount A inner join SavingsType B on (A.savingsTypeID = B.savingsTypeID) inner join MemberAccountHolder C on (A.savingsAccountNo = C.savingsAccountNo) inner join Member D on (D.accountNo = C.accountNo) where A.isClosed = 0 and C.isPrimary = 1 and A.savingsAccountNo like @1 and D.isTerminated = 0";
                parameters.Add("@1", "%" + text + "%");
            }

            else if (searchType == 1)
            {
                sql = "select A.savingsAccountNo as 'Savings Account No', (D.FName+ ' '+D.LName) as 'Account Name', B.savingsName as 'Savings Type',A.currentBalance as 'Balance' from SavingsAccount A inner join SavingsType B on (A.savingsTypeID = B.savingsTypeID) inner join MemberAccountHolder C on (A.savingsAccountNo = C.savingsAccountNo) inner join Member D on (D.accountNo = C.accountNo) where A.isClosed = 0 and C.isPrimary = 1 and (D.FName+ ' '+D.LName) like @1 and D.isTerminated = 0";
                parameters.Add("@1", "%" + text + "%");
            }
            DataSet ds = dal.executeDataSet(sql, parameters);
            return ds;
        }

        public string getSignatureImage(string isFamily)
        {
            string signature = "";
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            string sql = "";
            if (isFamily == "1")
            {
                sql = "select signatureImage from FamilyAccountHolder where savingsAccountNo = @1 and familyID = @2";
                parameters.Add("@1",savingsAccountID);
                parameters.Add("@2",familyID);
            }

            else
            {
                sql = "select signatureImage from MemberAccountHolder where savingsAccountNo = @1 and accountNo = @2";
                parameters.Add("@1", savingsAccountID);
                parameters.Add("@2", accountNo);
            }
            SqlDataReader reader = dal.executeReader(sql,parameters);
            if (reader.Read())
            {
                signature = reader[0].ToString();
            }
            return signature;
        }

        public double getAccountWithdrawalAmount(int days)
        {
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            string sql = "select ISNULL(SUM(amount),0) from SavingsTransaction where transactionDatetime > DATEADD(DD,@1,GETDATE()) and transactionType = 'W' and savingsAccountNo = @2";
            double amount = 0;
            parameters.Add("@1",-1*days);
            parameters.Add("@2",savingsAccountID);
            SqlDataReader reader = dal.executeReader(sql,parameters);
            if (reader.Read())
            {
                amount = Convert.ToDouble(reader[0]);
            }
            return amount;
        }

        public void searchSavingsAccount()
        {
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            string sql = "select * from SavingsAccount where savingsAccountNo = @1";
            parameters.Add("@1",savingsAccountID);
            SqlDataReader reader = dal.executeReader(sql,parameters);
            if (reader.Read())
            {
                savingsAccountID = reader["savingsAccountNo"].ToString();
                savingsTypeID = reader["savingsTypeID"].ToString();
                currentBalance = reader["currentBalance"].ToString();
            }
        }
    }
}
