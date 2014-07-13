using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;



namespace SVLMS.Loaning.Model
{
    class ModelCollateral
    {
        public string collateralId { get; set; }
        public string collateralName { get; set; }
        public string collateralDesc { get; set; }
        public string collateralValue { get; set; }
        public string status { get; set; }
        public string loanTypeID { get; set; }
        public string loanNo { get; set; }
        public List<int> list = new List<int>();

        public void insertCollateral()
        { 
        
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            string sql = "exec sp_InsertCollateral @1,@2,@3";
            Dictionary<string,object> parameters = new Dictionary<string,object>();
            parameters.Add("@1",collateralName);
            parameters.Add("@2", collateralDesc);
            parameters.Add("@3", loanNo);
            dal.executeNonQuery(sql, parameters);
        }

        public void updateCollateral()
        {

            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            string sql = "exec sp_UpdateCollateral @4,@1,@2,@3";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@1", collateralName);
            parameters.Add("@2", collateralDesc);
            parameters.Add("@3", loanNo);
            parameters.Add("@4",collateralId);
            dal.executeNonQuery(sql, parameters);
        }

        public void deleteCollateral()
        {
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            string sql = "delete from collateral where collateralID = @1";
            parameters.Add("@1", collateralId);
            dal.executeNonQuery(sql, parameters);
        }

        public DataSet getLoanTypes()
        {
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            string sql = "select loanTypeID as 'loanTypeID', loanName as 'loanName' from LoanType";
            DataSet ds = dal.executeDataSet(sql);
            return ds;
        }

        //public void updateCollateral()
        //{
        //    DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
        //    string sql = "update Collateral set collateralName = @1, collateralDesc = @2, collateralValue = @4, status = @5 where collateralID = @3";
        //    Dictionary<string, object> parameters = new Dictionary<string, object>();
        //    parameters.Add("@3", collateralId);
        //    parameters.Add("@1", collateralName);
        //    parameters.Add("@2", collateralDesc);
        //    parameters.Add("@4", collateralValue);
        //    parameters.Add("@5", status);
        //    dal.executeNonQuery(sql, parameters);       
        //}

        public void deleteCollateralLoans()
        {
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            string sql = "delete from CollateralLoan where collateralID = @1";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@1",collateralId);
            dal.executeNonQuery(sql,parameters);
        }

        public void searchCollateralLoan()
        {
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            string sql = "select B.loanTypeID as 'loanTypeID', B.loanName as 'loanName' from CollateralLoan A inner join LoanType B on(A.loanTypeID=B.loanTypeID) where collateralID=@1 ";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@1", collateralId);
            SqlDataReader reader = dal.executeReader(sql, parameters);
            list.Clear();
            while (reader.Read())
            {
                list.Add(int.Parse(reader[0].ToString()));
            }
        }

        public void insertCollateralLoan()
        {
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            for (int i = 0; i < list.Count; i++)
            {
                string sql = "insert into CollateralLoan values(@1,@2)";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@1", collateralId);
                parameters.Add("@2", list[i]);
                dal.executeNonQuery(sql, parameters);
                parameters.Clear();
            }
        }


        public DataSet getCollateralInfo()
        {
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            string sql = "select collateralID as CollateralID, collateralName as Collateral, collateralDesc as Description, collateralValue as Value, status from Collateral";
            DataSet ds = dal.executeDataSet(sql);
            return ds;
        }

        public string getCollateralID()
        {
            string id = "";
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            string sql = "select ISNULL(MAX(CollateralID),0) from Collateral";
            SqlDataReader reader = dal.executeReader(sql);
            if (reader.Read())
            {
                id = (Convert.ToInt32(reader[0]) + 1).ToString();
            }
            return id;
        }



    }
}
