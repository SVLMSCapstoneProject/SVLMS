using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace SVLMS.Loaning.Model
{
    class ModelCheckInformation
    {
        //Check Information
        public string checkNo { get; set; }
        public string bankName { get; set; }
        public string dateIssued { get; set; }
        public string loanNo { get; set; }
        public string transactionID { get; set; }
        public string transactionTable { get; set; }

        public void insertCheckInformation()
        {
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            //string sql = "insert into CheckInformation(checkNo,bankName,dateIssued,loanNo) values (@1,@2,@3,@4)";
            string sql = "exec sp_InsertCheckInformation @1,@2,@3,@4,@5";
            parameters.Add("@1", checkNo);
            parameters.Add("@2", bankName);
            parameters.Add("@3", dateIssued);
            parameters.Add("@4", transactionID);
            parameters.Add("@5", transactionTable);
            dal.executeNonQuery(sql, parameters);
        }
    }
}
