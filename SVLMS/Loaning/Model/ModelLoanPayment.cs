using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace SVLMS.Loaning.Model
{
    class ModelLoanPayment
    {
        public string paymentAmount { get; set; }
        public string userID { get; set; }
        public string accountNo { get; set; }
        public string loanNo { get; set; }
        public string memberName { get; set; }

        public DataSet getLoanRecords()
        {
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            string sql = "select distinct D.loanNo as 'Loan No',B.loanName as 'Loan Type', (C.FName +' '+C.LName) as 'Member Name', C.accountNo from Loan A inner join LoanType B on (A.loanTypeID = B.loanTypeID) inner join Member C on (A.accountNo = C.accountNo) inner join Amortization D on (A.loanNo = D.loanNo) where A.isReleased = 1 and D.isPaid = 0 and D.isRestructured = 0 and C.isTerminated = 0";
            DataSet ds = dal.executeDataSet(sql);
            return ds;
        }

        public DataSet searchByLoanNo()
        {
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            string sql = "select distinct D.loanNo as 'Loan No',B.loanName as 'Loan Type',(C.FName +' '+C.LName) as 'Member Name', C.accountNo from Loan A inner join LoanType B on (A.loanTypeID = B.loanTypeID) inner join Member C on (A.accountNo = C.accountNo) inner join Amortization D on (A.loanNo = D.loanNo) where A.isReleased = 1 and D.isPaid = 0 and D.isRestructured = 0 and A.loanNo LIKE @1 and C.isTerminated = 0";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@1","%" + loanNo + "%");
            DataSet ds = dal.executeDataSet(sql,parameters);
            return ds;
        }

        public DataSet searchByMemberName()
        {
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            string sql = "select distinct D.loanNo as 'Loan No',B.loanName as 'Loan Type', (C.FName +' '+C.LName) as 'Member Name', C.accountNo from Loan A inner join LoanType B on (A.loanTypeID = B.loanTypeID) inner join Member C on (A.accountNo = C.accountNo) inner join Amortization D on (A.loanNo = D.loanNo) where A.isReleased = 1 and D.isPaid = 0 and D.isRestructured = 0 and  (C.FName +' '+C.LName) LIKE @1 and C.isTerminated = 0";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@1", "%" + memberName + "%");
            DataSet ds = dal.executeDataSet(sql, parameters);
            return ds;
        }

        public DataSet getAmortizationPaymentSched(int noOfPeriods)
        {
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            //string sql = "select dueDate as 'Due Date', balanceAmount as 'Amount', (CASE WHEN isPaid = 1 THEN 'Paid'	WHEN CAST(GETDATE() AS DATE) > dueDate THEN 'Overdue' ELSE '' END ) AS 'Status' from Amortization where loanNo = @1 and isRestructured = 0";
            string sql = "select dueDate as 'Due Date', balanceAmount as 'Remaining Amount', Penalty from func_GetAmortizationToBePaid(@1,@2);";
            parameters.Add("@1", loanNo);
            parameters.Add("@2",noOfPeriods);
            DataSet ds = dal.executeDataSet(sql, parameters);
            return ds;
        }

        public double insertLoanPayment(int noOfPeriod, int isChangeAdvance, string savingsAccountNo)
        {
            double change = 0;
            string connectionString = ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("sp_TransactionLoanPayment",con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@paymentAmount",paymentAmount);
                    cmd.Parameters.AddWithValue("@noOfPeriod",noOfPeriod);
                    cmd.Parameters.AddWithValue("@userID", userID);
                    cmd.Parameters.AddWithValue("@loanNo",loanNo);
                    cmd.Parameters.AddWithValue("@savingsAccountNo",savingsAccountNo);
                    cmd.Parameters.Add("@change",SqlDbType.Money);
                    cmd.Parameters["@change"].Direction = ParameterDirection.Output;
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    change = Convert.ToDouble(cmd.Parameters["@change"].Value);
                }
            }

            return change;
        }

    }
}
