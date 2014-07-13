using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace SVLMS.Loaning.Model
{
    class ModelShareCapitalTransaction
    {
        //Share Transaction Table
        public string transactionID { get; set; }
        public string transactionDatetime { get; set;}
        public string transactionType { get; set; }
        public string amount { get; set; }
        public string comments { get; set; }
        public string shareID { get; set; }
        public string userID { get; set; }

        //Share Capital Table
        public string accountNo { get; set; }

        public void insertShareTransaction()
        {
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            string sql = "exec sp_TransactionShare @1,@2,@3,@4,@5";
            parameters.Add("@1",shareID);
            parameters.Add("@2",transactionType);
            parameters.Add("@3",amount);
            parameters.Add("@4","");
            parameters.Add("@5",userID);
            dal.executeNonQuery(sql,parameters);
        }


        public string getShareCapitalBalance()
        {
            string totalCapital = "0";
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            string sql = "select ISNULL(currentBalance,0) from ShareCapital where accountNo = @1";
            parameters.Add("@1",accountNo);
            SqlDataReader reader = dal.executeReader(sql,parameters);
            if (reader.Read())
            {
                totalCapital = reader[0].ToString();
            }
            return totalCapital;
        }

        public string getShareCapitalID()
        {
            string id = "";
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            string sql = "select shareID from ShareCapital where accountNo = @1";
            parameters.Add("@1", accountNo);
            SqlDataReader reader = dal.executeReader(sql, parameters);
            if (reader.Read())
            {
                id = reader[0].ToString();
            }
            return id;
        }
    }
}
