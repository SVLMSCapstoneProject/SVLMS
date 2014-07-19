using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace SVLMS
{
    class ModelUser
    {
        public static string userID { get; set; }

        public static DataSet getIntervalOfPayments()
        {
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            string sql = "select * from Indicator";
            DataSet ds = dal.executeDataSet(sql);
            return ds;
        }

        public static int getIntervalInDays(string indicatorID)
        {
            int daysNo = 0;
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            Dictionary<string,object> parameters = new Dictionary<string,object>();
            string sql = "select daysNo from Indicator where indicatorID = @1";
            parameters.Add("@1",indicatorID);
            SqlDataReader reader = dal.executeReader(sql,parameters);
            if (reader.Read())
            {
                daysNo = Convert.ToInt32(reader[0]);
            }
            return daysNo;
        }

        public static string getIntervalInDesccription(string indicatorID)
        {
            string desc = "";
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            string sql = "select intervalDesc from Indicator where indicatorID = @1";
            parameters.Add("@1", indicatorID);
            SqlDataReader reader = dal.executeReader(sql, parameters);
            if (reader.Read())
            {
                desc = reader[0].ToString();
            }
            return desc;
        }
    }
}
