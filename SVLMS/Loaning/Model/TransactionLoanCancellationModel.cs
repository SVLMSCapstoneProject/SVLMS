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
    class TransactionLoanCancellationModel
    {
        public string LoanNo { get; set; }
        public string MemberName { get; set; }
        public string LoanType { get; set; }
        public string ApprovedAmount { get; set; }
        public string ReasonCancellation { get; set; }
        public string ApprovalDate { get; set; }

        public DataSet getCancelledLoans()
        {
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            string sql = "select * from vw_LoanCancellationInfoDisplay";
            DataSet ds = dal.executeDataSet(sql);
            return ds;
        }

        public DataSet searchByLoanNo()
        {
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            string sql = "SELECT a.loanNo AS 'Loan No', (b.FName + ' ' + b.LName) AS 'Member Name', c.loanName AS 'Loan Type', a.loanDate AS 'Date Of Application' FROM Loan a INNER JOIN Member b ON a.accountNo = b.accountNo INNER JOIN LoanType c ON a.loanTypeID = c.loanTypeID WHERE a.isReleased is null and (a.isApproved is null or a.isApproved = 1) and a.loanNo LIKE @1 and b.isTerminated = 0";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@1", "%" +LoanNo+ "%" );
            DataSet ds = dal.executeDataSet(sql,parameters);
            return ds;
        }

        public DataSet searchByMemberName()
        {
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            string sql = "SELECT a.loanNo AS 'Loan No', (b.FName + ' ' + b.LName) AS 'Member Name', c.loanName AS 'Loan Type', a.loanDate AS 'Date Of Application' FROM Loan a INNER JOIN Member b ON a.accountNo = b.accountNo INNER JOIN LoanType c ON a.loanTypeID = c.loanTypeID WHERE a.isReleased is null and (a.isApproved is null or a.isApproved = 1) and (b.FName + ' ' + b.LName) LIKE @1 and b.isTerminated = 0";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@1", "%" + MemberName + "%");
            DataSet ds = dal.executeDataSet(sql, parameters);
            return ds;
        }

        public void insertCancelledLoan()
        {
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            string sql = "exec sp_TransactionLoanCancellation @1, @2";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@1", LoanNo);
            parameters.Add("@2", ReasonCancellation);
            dal.executeNonQuery(sql, parameters);            
        }

        public DataSet getLoanCancelledInformation()
        {
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            string sql = "select * from vw_LoanCancellationInfo";
            DataSet ds = dal.executeDataSet(sql);
            return ds;            
        }

        public void searchLoanCancellationInfo()
        {
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            string sql = "select * from vw_LoanCancellationInfo where loanNo = @1";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@1", LoanNo); 
            SqlDataReader reader = dal.executeReader(sql, parameters);
            if (reader.Read())
            {
                LoanNo = reader[0].ToString();
                MemberName = reader[1].ToString() + ", " + reader[2].ToString() + " " + reader[3].ToString();
                LoanType = reader[4].ToString();
                ApprovedAmount = reader[5].ToString();
                ApprovalDate = reader[6].ToString();
            }
        }

    }
}
