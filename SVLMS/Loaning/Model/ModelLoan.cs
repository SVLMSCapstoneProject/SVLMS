using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace SVLMS.Loaning.Model
{
    class ModelLoan
    {
        public string loanNo { get; set; }
        public string requestedAmount { get; set; }
        public string approvedAmount { get; set; }
        public string loanDate { get; set; }
        public string termsOfPayment { get; set; }
        public string approvalDate { get; set; }
        public string isApproved { get; set; }
        public string isReleased { get; set; }
        public string releaseCancelDatetime { get; set; }
        public string releaseType { get; set; }
        public string accountNo { get; set; }
        public string loanTypeID { get; set; }
        public string userID { get; set; }
        public string penaltyID { get; set; }
        public string shareID { get; set; }
        public string savingsAccountNo { get; set; }
        public string loanRatesID { get; set; }
        public string approvalRemarks { get; set; }

        public int paymentIntervalDays { get; set; }
        public int paymentInterval { get; set; }
        public int termsOfPaymentDays { get; set; }

        public string memberName { get; set; }

        public void loanApproval()
        {
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            string sql = "exec sp_TransactionLoanApproval @1,@2,@3,@4,@5";
            parameters.Add("@1",loanNo);
            parameters.Add("@2",approvedAmount);
            parameters.Add("@3", isApproved);
            parameters.Add("@4",termsOfPayment);
            parameters.Add("@5",approvalRemarks);
            dal.executeNonQuery(sql,parameters);
        }

        public int loanRelease()
        {
            //DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            //Dictionary<string, object> parameters = new Dictionary<string, object>();
            //string sql = "exec sp_TransactionLoanRelease @1,@2,@3,@4";
            //parameters.Add("@1",releaseType);
            //parameters.Add("@2",loanNo);
            //parameters.Add("@3",userID);
            //dal.executeNonQuery(sql,parameters);
            int transactionID = 0;
            string connectionString = ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("sp_TransactionLoanRelease",con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@releaseType",releaseType);
                    cmd.Parameters.AddWithValue("@loanNo", loanNo);
                    cmd.Parameters.AddWithValue("@userID", userID);
                    cmd.Parameters.AddWithValue("@transactionID",SqlDbType.Int);
                    cmd.Parameters["@transactionID"].Direction = ParameterDirection.Output;
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    transactionID = Convert.ToInt32(cmd.Parameters["@transactionID"].Value);
                }
            }
            return transactionID;
        }

        public DataSet getLoanApplications()
        {
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            string sql = "select A.loanNo as 'Loan No', B.loanName as 'Loan Type',(C.FName +' '+C.LName) as Name, A.requestedAmount as 'Amount' from Loan A inner join LoanType B on (A.loanTypeID = B.loanTypeID) inner join Member C on (A.accountNo = C.accountNo) where A.isReleased is null and C.isTerminated = 0";
            DataSet ds = dal.executeDataSet(sql);
            return ds;
        }

        public DataSet getLoanApplicationsRecords()
        {
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            string sql = "select A.loanNo as 'Loan No', B.loanName as 'Loan Type',(C.FName +' '+C.LName) as Name, A.requestedAmount as 'Amount' from Loan A inner join LoanType B on (A.loanTypeID = B.loanTypeID) inner join Member C on (A.accountNo = C.accountNo) where A.isReleased is null and C.isTerminated = 0";
            DataSet ds = dal.executeDataSet(sql);
            return ds;
        }

        public DataSet SearchByLoanApplication(int searchType)
        {
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            string sql = "";
            if (searchType == 1)
            {
                sql = "select A.loanNo as 'Loan No', B.loanName as 'Loan Type',(C.FName +' '+C.LName) as Name, A.requestedAmount as 'Amount' from Loan A inner join LoanType B on (A.loanTypeID = B.loanTypeID) inner join Member C on (A.accountNo = C.accountNo) where A.isReleased is null and C.accountNo LIKE @1 and C.isTerminated = 0";
                parameters.Add("@1", "%" + accountNo + "%");
            }

            else if (searchType == 2)
            {
                sql = "select loanNo as 'Loan No', B.loanName as 'Loan Type',(C.FName +' '+C.LName) as Name, A.requestedAmount as 'Amount' from Loan A inner join LoanType B on (A.loanTypeID = B.loanTypeID) inner join Member C on (A.accountNo = C.accountNo) where A.isReleased is null and (C.FName +' '+C.LName) LIKE @1 and C.isTerminated = 0";
                parameters.Add("@1", "%" + memberName + "%");
            }
            DataSet ds = dal.executeDataSet(sql, parameters);
            return ds;
        }

        public DataSet SearchByLoanApplicationUpdate(int searchType)
        {
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            string sql = "";
            if (searchType == 1)
            {
                sql = "select A.loanNo as 'Loan No', B.loanName as 'Loan Type',(C.FName +' '+C.LName) as Name, A.requestedAmount as 'Amount' from Loan A inner join LoanType B on (A.loanTypeID = B.loanTypeID) inner join Member C on (A.accountNo = C.accountNo) where A.isReleased is null and A.loanNo LIKE @1 and C.isTerminated = 0";
                parameters.Add("@1", "%" + loanNo + "%");
            }

            else if (searchType == 2)
            {
                sql = "select loanNo as 'Loan No', B.loanName as 'Loan Type',(C.FName +' '+C.LName) as Name, A.requestedAmount as 'Amount' from Loan A inner join LoanType B on (A.loanTypeID = B.loanTypeID) inner join Member C on (A.accountNo = C.accountNo) where A.isReleased is null and (C.FName +' '+C.LName) LIKE @1 and C.isTerminated= 0";
                parameters.Add("@1", "%" + memberName + "%");
            }
            DataSet ds = dal.executeDataSet(sql, parameters);
            return ds;
        }
        
        public SqlDataReader searchLoanApplicationRecord()
        {
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            string sql = "select A.loanNo, (B.FName + ' ' + B.LName) as Name, A.requestedAmount, A.loanDate, D.collateralName, A.termsOfPayment, A.approvedAmount, C.indicatorDesc, A.loanTypeID from Loan A inner join Member B on (A.accountNo = B.accountNo) inner join Indicator C on (A.paymentInterval = C.indicatorID) left join Collateral D on (A.loanNo = D.loanNo) where A.loanNo = @1";
            parameters.Add("@1",loanNo);
            SqlDataReader reader = dal.executeReader(sql,parameters);
            return reader;
        }

        public void setLoanFieldsCalculateAmort()
        {
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            string sql = "select A.loanNo, A.loanDate, A.requestedAmount, A.termsOfPayment,B.daysNo as intervalDays from Loan A inner join Indicator B on (indicatorID = paymentInterval) where A.loanNo = @1";
            parameters.Add("@1",loanNo);
            SqlDataReader reader = dal.executeReader(sql,parameters);
            if (reader.Read())
            {
                loanDate = reader[1].ToString();
                requestedAmount = reader[2].ToString();
                termsOfPaymentDays = Convert.ToInt32(reader[3]) * 30;
                termsOfPayment = Convert.ToInt32(reader[3]).ToString();
                paymentIntervalDays = Convert.ToInt32(reader[4]);
            }
        }

        public void updateLoanRates()
        {
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            string sql = "update Loan set loanRatesID = @1 where loanNo = @2";
            parameters.Add("@1",loanRatesID);
            parameters.Add("@2",loanNo);
            dal.executeNonQuery(sql,parameters);
        }

        public SqlDataReader getLoanRates()
        {
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            //string sql = "select top 1 A.loanRatesID, A.interestRate, A.isPercentageInterest, A.shareRate, A.isPercentageShare, A.changeDatetime,A.isCurrent, A.effectivityDate, A.status, A.loanTypeID from LoanRates A inner join Loan B on (A.loanRatesID = B.loanRatesID) where B.loanNo = @1 and effectivityDate <= CAST(GETDATE() AS DATE) order by effectivityDate desc";
            string sql = "select top 1 A.loanRatesID, A.interestRate, A.isPercentageInterest, A.shareRate, A.isPercentageShare, A.changeDatetime,A.isCurrent, A.effectivityDate, A.status, A.loanTypeID from LoanRates A inner join Loan B on (A.loanRatesID = B.loanRatesID) where B.loanNo = @1";
            parameters.Add("@1", loanNo);
            SqlDataReader reader = dal.executeReader(sql, parameters);
            return reader;
        }

        public DataSet getApprovedLoans()
        {
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            string sql = "select A.loanNo as 'Loan No', (B.FName + ' '+ B.LName) as 'Member Name', A.approvedAmount as 'Approved Amount', A.requestedAmount as 'Requested Amount', A.statusDate as 'Approval Date' from Loan A inner join Member B on (A.accountNo = B.accountNo) where status = 2 and isReleased is null";
            DataSet ds = dal.executeDataSet(sql);
            return ds;
        }

        public DataSet SearchByApprovedLoans(int searchType)
        {
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            string sql = "";
            if (searchType == 1)
            {
                sql = "select A.loanNo as 'Loan No', (B.FName + ' '+ B.LName) as 'Member Name', A.approvedAmount as 'Approved Amount', A.requestedAmount as 'Requested Amount', A.statusDate as 'Approval Date' from Loan A inner join Member B on (A.accountNo = B.accountNo) where status = 2 and isReleased is null and A.loanNo LIKE @1 and B.isTerminated = 0";
                parameters.Add("@1", "%" + loanNo + "%");
            }

            else if (searchType == 2)
            {
                sql = "select A.loanNo as 'Loan No', (B.FName + ' '+ B.LName) as 'Member Name', A.approvedAmount as 'Approved Amount', A.requestedAmount as 'Requested Amount', A.statusDate as 'Approval Date' from Loan A inner join Member B on (A.accountNo = B.accountNo) where status = 2 and isReleased is null and (B.FName + ' '+ B.LName) LIKE @1 and B.isTerminated = 0";
                parameters.Add("@1", "%" + memberName + "%");
            }
            DataSet ds = dal.executeDataSet(sql, parameters);
            return ds;
        }

        public DataSet getReleasedLoans()
        {
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            string sql = "select DISTINCT A.loanNo as 'Loan No', D.loanName as 'Loan Type',(B.FName + ' '+ B.LName) as 'Member Name', A.approvedAmount as 'Approved Amount', CAST(A.releaseCancelDatetime as DATE) as 'Release Date' from Loan A inner join Member B on (A.accountNo = B.accountNo) inner join Amortization C on (A.loanNo = C.loanNo) inner join LoanType D on (A.loanTypeID = D.loanTypeID) where isReleased = 1 and C.isPaid = 0 and B.isTerminated = 0 and C.isRestructured = 0";
            DataSet ds = dal.executeDataSet(sql);
            return ds;
        }

        public DataSet SearchByReleasedLoans(int searchType)
        {
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            string sql = "";
            Dictionary<string, object> parameter = new Dictionary<string, object>();
            if (searchType == 1)
            {
                sql = "select DISTINCT A.loanNo as 'Loan No', D.loanName as 'Loan Type',(B.FName + ' '+ B.LName) as 'Member Name', A.approvedAmount as 'Approved Amount', CAST(A.releaseCancelDatetime as DATE) as 'Release Date' from Loan A inner join Member B on (A.accountNo = B.accountNo) inner join Amortization C on (A.loanNo = C.loanNo) inner join LoanType D on (A.loanTypeID = D.loanTypeID) where isReleased = 1 and C.isPaid = 0 and A.LoanNo LIKE @1 and B.isTerminated = 0 and C.isRestructured = 0";
                parameter.Add("@1", "%" + loanNo + "%");
            }

            else if (searchType == 2)
            {
                sql = "select DISTINCT A.loanNo as 'Loan No',  D.loanName as 'Loan Type',(B.FName + ' '+ B.LName) as 'Member Name', A.approvedAmount as 'Approved Amount', CAST(A.releaseCancelDatetime as DATE) as 'Release Date' from Loan A inner join Member B on (A.accountNo = B.accountNo) inner join Amortization C on (A.loanNo = C.loanNo) inner join LoanType D on (A.loanTypeID = D.loanTypeID) where isReleased = 1 and C.isPaid = 0 and (B.FName + ' '+ B.LName) LIKE @1 and B.isTerminated = 0 and C.isRestructured = 0";
                parameter.Add("@1", "%" + memberName + "%");
            }
            DataSet ds = dal.executeDataSet(sql, parameter);
            return ds;
        }

        public void restructureLoan()
        {
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            string sql = "Update Amortization set isRestructured = 1 where loanNo = @1";
            parameters.Add("@1",loanNo);
            dal.executeNonQuery(sql, parameters);
            parameters.Clear();
            sql = "update Loan set paymentInterval = @2, termsOfPayment = @3 where loanNo = @1";
            parameters.Add("@2", paymentInterval);
            parameters.Add("@3", termsOfPayment);
            parameters.Add("@1", loanNo);
            dal.executeNonQuery(sql,parameters);
        }

        public DataSet getApprovedLoansCharges()
        {
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            string sql = "select A.chargeName as 'Charge', (CASE WHEN isPercentage = 1 THEN (A.amount/100)*C.approvedAmount	ELSE A.amount END) as 'Amount' from Charge A inner join LoanCharges B on (A.chargeID = B.chargeID) inner join Loan C on (B.loanTypeID = C.loanTypeID) where C.loanNo = @1 and A.status = 1";
            parameters.Add("@1",loanNo);
            DataSet ds = dal.executeDataSet(sql, parameters);
            return ds;
        }

        public double getTotalCharges()
        {
            double totalCharges = 0;
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            string sql = "select A.chargeName as 'Charge', (CASE WHEN isPercentage = 1 THEN (A.amount/100)*C.approvedAmount	ELSE A.amount END) as 'Amount' from Charge A inner join LoanCharges B on (A.chargeID = B.chargeID) inner join Loan C on (B.loanTypeID = C.loanTypeID) where C.loanNo = @1 and A.status = 1";
            parameters.Add("@1", loanNo);
            SqlDataReader reader = dal.executeReader(sql,parameters);
            while (reader.Read())
            {
                totalCharges += Convert.ToDouble(reader["Amount"]);
            }
            return totalCharges;
        }

        public string getLoanTypeID()
        {
            string loanTypeID = "";
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            string sql = "select B.loanTypeID from Loan A inner join LoanType B on (A.loanTypeID = B.loanTypeID) where loanNo = @1";
            parameters.Add("@1",loanNo);
            SqlDataReader reader = dal.executeReader(sql,parameters);
            if (reader.Read())
            {
                loanTypeID = reader[0].ToString();
            }
            return loanTypeID;
        }

        public void insertChargedFromLoans()
        {
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            string sql = "select A.chargeID from Charge A inner join LoanCharges B on (A.chargeID = B.chargeID) inner join Loan C on (B.loanTypeID = C.loanTypeID) where C.loanNo = @1";
            parameters.Add("@1",loanNo);
            SqlDataReader reader = dal.executeReader(sql,parameters);
            
            while (reader.Read())
            {
                insertChargedFromLoan(reader[0].ToString(),loanNo);
            }
        }

        private void insertChargedFromLoan(string param1, string param2)
        {
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            string sql = "insert into ChargedFromLoans(chargeID,loanNo) values (@1,@2)";
            parameters.Add("@1",param1);
            parameters.Add("@2",param2);
            dal.executeNonQuery(sql,parameters);
        }

        public double getTotalPenalties()
        {
            double penalty = 0;
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            string sql = "select SUM(penalty) as 'Total Penalty' , SUM(balanceAmount) as 'Current Balance' from Amortization where loanNo = @1 and isRestructured = 0 group by loanNo";
            parameters.Add("@1",loanNo);
            SqlDataReader reader = dal.executeReader(sql,parameters);
            if (reader.Read())
            {
                penalty = Convert.ToDouble(reader[0]);
            }
            return penalty;
        }

        public double getCurrentBalance()
        {
            double currentBalance = 0;
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            string sql = "select SUM(penalty) as 'Total Penalty' , SUM(balanceAmount) as 'Current Balance' from Amortization where loanNo = @1 and isRestructured = 0 group by loanNo";
            parameters.Add("@1", loanNo);
            SqlDataReader reader = dal.executeReader(sql, parameters);
            if (reader.Read())
            {
                currentBalance = Convert.ToDouble(reader[1]);
            }
            return currentBalance;
        }

        public double getTotalBalance()
        {
            double currentBalance = 0;
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            string sql = "select SUM(balanceAmount) as 'Total Balance' from Amortization where loanNo = @1 and isRestructured = 0 group by loanNo";
            parameters.Add("@1", loanNo);
            SqlDataReader reader = dal.executeReader(sql, parameters);
            if (reader.Read())
            {
                currentBalance = Convert.ToDouble(reader[0]);
            }
            return currentBalance;
        }

        public double getTotalLoanPrincipalBalance()
        {
            double totalPrincipal = 0;
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            string sql = "select SUM(baseAmount) from Amortization A where loanNo = @1 and isRestructured = 0";
            parameters.Add("@1", loanNo);
            SqlDataReader reader = dal.executeReader(sql, parameters);
            if (reader.Read())
            {
                totalPrincipal = Convert.ToDouble(reader[0]);
            }
            return totalPrincipal;
        }

        public double getLoanBalance()
        {
            double loanBalance = 0;
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            string sql = "select ISNULL(SUM(B.baseAmount),0) from Loan A inner join Amortization B on (A.loanNo = B.loanNo) inner join Member C on (C.accountNo = A.accountNo) where B.isPaid = 0 and B.isRestructured = 0 and C.accountNo = @1";
            parameters.Add("@1",accountNo);
            SqlDataReader reader = dal.executeReader(sql,parameters);
            if (reader.Read())
            {
                loanBalance = Convert.ToDouble(reader[0]);
            }
            return loanBalance;
        }
    }
}
