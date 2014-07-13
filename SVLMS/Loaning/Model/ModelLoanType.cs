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

namespace SVLMS.Loaning.Model
{
    class ModelLoanType
    {
        public string loanId { get; set; }
        public string loanName { get; set; }
        public string loanCeiling { get; set; }
        public string minAmount { get; set; }
        public string maxAmount { get; set; }
        public string maxTerm { get; set; }
        //public int hasmaxTerm { get; set; }
        public string loanEntitlement { get; set; }
        public string loanEligibility { get; set; }
        public int isPercentageEntitlement { get; set; }
        public int hasCoMaker { get; set; }
        public int hasCollateral{ get; set; }
        public string[] memberTypeID { get; set; }
        public List<int> list = new List<int>();
        public string status { get; set; }
        public string loanTypeName { get; set; }

        public void insertLoanType()
        {

            
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);   
            string sql = "exec sp_MaintenanceAddLoanType @1,@2,@3,@4,@8,@9,@7,@14,@15,@16";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@1", loanName);
            parameters.Add("@2", minAmount);
            parameters.Add("@3", maxAmount);
            parameters.Add("@4", maxTerm);
            parameters.Add("@7", hasCoMaker);
            parameters.Add("@8", loanEntitlement);
            parameters.Add("@9", isPercentageEntitlement);
            parameters.Add("@14",hasCollateral);
            parameters.Add("@15",status);
            parameters.Add("@16", loanEligibility);
            dal.executeNonQuery(sql, parameters);

            //Insert Applicable MemberType
            parameters.Clear();
            for (int i = 0; i < memberTypeID.Length; i++)
            {
                sql = "insert into ApplicableLoans values (@1,@2)";
                parameters.Add("@1", memberTypeID[i]);
                parameters.Add("@2", loanId);
                dal.executeNonQuery(sql, parameters);
                parameters.Clear();
            }
        }

        public void setApplicableLoanInfo()
        {
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            string sql = "select A.memberTypeID as MemberID, A.memberTypeName as MemberType, B.loanTypeID as LoanType from ApplicableLoans B inner join MemberType A on (A.memberTypeID = B.memberTypeID) where loanTypeID = @1";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@1",loanId);
            SqlDataReader r = dal.executeReader(sql, parameters);
            list.Clear();
            while (r.Read())
            {   
                list.Add(Convert.ToInt32(r[0]));
                       
            }
            
        }

        public DataSet getLoanTypeInfo()
        {
            DataSet ds = new DataSet();
            string sql = "select A.loanTypeID as 'Loan Type ID',loanName as 'Loan Name', minAmount as 'Min Amount', maxAmount as 'Max Amount',CAST(maxTerm AS VARCHAR)+' month/s' as 'Maximum Term', (case when status = 1 then 'Active' else 'Inactive' end) as Status from LoanType A";
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            ds = dal.executeDataSet(sql);
            return ds;
            
        }

        public DataSet getMemberType()
        {
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            string sql = "select memberTypeID as 'TypeID', memberTypeName as 'MemberType', minimumNoOfShare as 'MinimumShare' from MemberType";
            DataSet ds = dal.executeDataSet(sql);
            return ds;
        }

        public DataSet getLoanTypes()
        {
            DataSet ds = new DataSet();
            string sql = "select loanTypeID,loanName from LoanType";
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            ds = dal.executeDataSet(sql);
            return ds;
            
        }

        public DataSet searchLoanTypeInfo(string filter, string textSearch)
        {
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            string sql = "";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            if (filter == "No Filter")
            {
                sql = "select A.loanTypeID as 'Loan Type ID',loanName as 'Loan Name', minAmount as 'Min Amount', maxAmount as 'Max Amount',CAST(maxTerm AS VARCHAR)+' month/s' as 'Maximum Term', (case when status = 1 then 'Active' else 'Inactive' end) as Status from LoanType A where loanName LIKE @1";
            }

            else if (filter == "Active")
            {
                sql = "select A.loanTypeID as 'Loan Type ID',loanName as 'Loan Name', minAmount as 'Min Amount', maxAmount as 'Max Amount',CAST(maxTerm AS VARCHAR)+' month/s' as 'Maximum Term', (case when status = 1 then 'Active' else 'Inactive' end) as Status from LoanType A where A.status = 1 and loanName LIKE @1";
            }

            else
            {
                sql = "select A.loanTypeID as 'Loan Type ID',loanName as 'Loan Name', minAmount as 'Min Amount', maxAmount as 'Max Amount',CAST(maxTerm AS VARCHAR)+' month/s' as 'Maximum Term', (case when status = 1 then 'Active' else 'Inactive' end) as Status from LoanType A where A.status = 0 and loanName LIKE @1";
            }
            parameters.Add("@1", "%"+textSearch+"%");
            DataSet ds = dal.executeDataSet(sql,parameters);
            return ds;
        }

        public string getLoanId()
        {
            string id = "";
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            string sql = "select ISNULL(MAX(loanTypeID),0) from LoanType";
            SqlDataReader reader = dal.executeReader(sql);
            if (reader.Read())
            {
                id = (Convert.ToInt32(reader[0]) + 1).ToString();
            }
            return id;
        }

        public void searchLoanType() 
        {
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            string sql = "select A.loanTypeID as 'Loan Type ID',loanName as 'Loan Name', minAmount as 'Minimum Amount',maxAmount as 'Maximum Amount',maxTerm as 'Maximum Term',hasComaker as 'With Co-Maker', loanEntitlement, isPercentageEntitlement, status, hasCollateral,loanEligibility from LoanType A where A.loanTypeID = @1";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@1",loanId);
            SqlDataReader r = dal.executeReader(sql,parameters);
            if(r.Read())
            {
                loanId = r[0].ToString();
                loanName = r[1].ToString();
                minAmount = r[2].ToString();
                maxAmount = r[3].ToString();
                maxTerm = r[4].ToString();
                //hasmaxTerm = Convert.ToInt32(r[5]);
                hasCoMaker = Convert.ToInt32(r[5]);
                loanEntitlement = r[6].ToString();
                isPercentageEntitlement = Convert.ToInt32(r[7]);
                status = r[8].ToString();
                hasCollateral = Convert.ToInt32(r[9]);
                loanEligibility = r[10].ToString();
                //maxTermMonth = (hasmaxTerm == 1) ? Convert.ToInt32(maxTerm) : Convert.ToInt32(maxTerm) * 12;
            }
            
            
        }

        public void updateLoanType() 
        {
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            string sql = "exec sp_MaintenanceUpdateLoanType @0,@1,@2,@3,@4,@8,@9,@7,@14,@15,@16";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@0", loanId);
            parameters.Add("@1", loanName);
            parameters.Add("@2", minAmount);
            parameters.Add("@3", maxAmount);
            parameters.Add("@4", maxTerm);
            parameters.Add("@8", loanEntitlement);
            parameters.Add("@9", isPercentageEntitlement);
            parameters.Add("@7", hasCoMaker);
            parameters.Add("@14", hasCollateral);
            parameters.Add("@15", status);
            parameters.Add("@16", loanEligibility);
            dal.executeNonQuery(sql, parameters);

            this.deleteLoanApplicableLoans();

            parameters.Clear();
            for (int i = 0; i < memberTypeID.Length; i++)
            {
                sql = "insert into ApplicableLoans values (@1,@2)";
                parameters.Add("@1", memberTypeID[i]);
                parameters.Add("@2", loanId);
                dal.executeNonQuery(sql, parameters);
                parameters.Clear();
            }
        }

        public void deleteLoanApplicableLoans()
        {
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            string sql = "delete from ApplicableLoans where loanTypeID = @1";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@1", loanId);
            dal.executeNonQuery(sql, parameters);
        }

        public void LoanTypeName()
        {
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            string sql = "select COUNT(*) from vw_loanName where loanName = @1";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@1", loanName);
            SqlDataReader reader = dal.executeReader(sql, parameters);
            if (reader.Read())
            {
                loanTypeName = reader[0].ToString();
            }
        }
    
    }
}


