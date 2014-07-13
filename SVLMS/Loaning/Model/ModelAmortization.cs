using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace SVLMS.Loaning.Model
{
    class ModelAmortization
    {
        public string amortID { get; set; }
        public string baseAmount { get; set; }
        public string interestAmount { get; set; }
        public string savingsAmount { get; set; }
        public string shareCapitalAmount { get; set; }
        public string penaltyAmount { get; set; }
        public string balanceAmount { get; set; }
        public string dueDate { get; set; }
        public string isPaid { get; set; }
        public string isBilled{ get; set; }
        public string isRestructured{ get; set; }
        public string loanNo{ get; set; }

        public SqlDataReader getAmortizationSchedule()
        {
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            string sql = "select dueDate as 'Due Date', balanceAmount as 'Remaining Balance', penalty as 'Penalty' from Amortization where isRestructured = 0 and isPaid = 0 and loanNo = @1";
            parameters.Add("@1", loanNo);
            SqlDataReader reader = dal.executeReader(sql, parameters);
            return reader;
        }

        public SqlDataReader getNextAmortization()
        {
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            string sql = "select top 1 dueDate, balanceAmount from Amortization where isRestructured = 0 and isPaid = 0  and loanNo = @1 order by dueDate";
            parameters.Add("@1",loanNo);
            SqlDataReader reader = dal.executeReader(sql,parameters);
            return reader;
        }

        public decimal getPenalty(int noOfPeriod)
        {
            decimal penalty = 0;
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            //string sql = "select (CAST(DATEDIFF(DAY,A.dueDate,CAST(GETDATE() AS DATE)) AS MONEY)/CAST((C.duration*(select I.daysNo from Indicator I where I.indicatorID = C.durationTime)) AS MONEY)*(CASE WHEN C.isPercentage = 1 THEN C.penaltyAmount/100 else C.penaltyAmount end)*A.balanceAmount) as penalty from Amortization A inner join Loan B on (A.loanNo = B.loanNo) inner join LoanPenaltySettings C on (B.penaltyID = C.penaltyID) where A.isRestructured = 0 and isPaid = 0 and A.loanNo = '0000001')";
            string sql = "select * from func_GetAmortizationToBePaid(@1,@2)";
            parameters.Add("@1",loanNo);
            parameters.Add("@2",noOfPeriod);
            SqlDataReader reader = dal.executeReader(sql, parameters);
            while (reader.Read())
            {   
                if (reader["penalty"] != DBNull.Value)
                {
                    penalty += Convert.ToDecimal(reader["penalty"]);
                }
            }
            //System.Windows.Forms.MessageBox.Show(penalty.ToString());
            return penalty;
        }

        public int countRemainingAmortization()
        {
            int ctr = 0;
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            //string sql = "select SUM(balanceAmount) from Amortization where isRestructured = 0 and isPaid = 0 and loanNo = @1";
            string sql = "select count(*) from Amortization where isPaid = 0 and isRestructured= 0 and loanNo = @1";
            parameters.Add("@1", loanNo);
            SqlDataReader reader = dal.executeReader(sql, parameters);
            while (reader.Read())
            {
                //ctr++;
                ctr = Convert.ToInt32(reader[0]);
            }
            return ctr;
        }

        public double getTotalAmount()
        {
            double totalAmount = 0;
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            string sql = "select * from Loan A inner join LoanRates B on (A.loanRatesID = B.loanRatesID) where loanNo = @1";
            parameters.Add("@1",loanNo);
            SqlDataReader reader = dal.executeReader(sql, parameters);
            if (reader.Read())
            {
                totalAmount += Convert.ToDouble(reader["approvedAmount"]);

            }
            return totalAmount;
        }

        public int getNoOfAmortization()
        {
            int ctr = 0;
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            //string sql = "select SUM(balanceAmount) from Amortization where isRestructured = 0 and isPaid = 0 and loanNo = @1";
            string sql = "select count(*) from Amortization where isRestructured= 0 and loanNo = @1";
            parameters.Add("@1", loanNo);
            SqlDataReader reader = dal.executeReader(sql, parameters);
            while (reader.Read())
            {
                ctr = Convert.ToInt32(reader[0]);
            }
            return ctr;
        }

        public void insertAmortizationSchedule(string[,] amortizationSchedule)
        {
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            string sql = "sp_InsertAmortization @1,@2,@4,@5,@6,@7,@8";
            for (int x = 0; x < amortizationSchedule.GetLength(0); x++)
            {
                parameters.Clear();
                parameters.Add("@1", amortizationSchedule[x, 1]);
                parameters.Add("@2", amortizationSchedule[x, 2]);
                parameters.Add("@4", amortizationSchedule[x, 3]);
                parameters.Add("@5", 0);
                parameters.Add("@6", amortizationSchedule[x, 4]);
                parameters.Add("@7", amortizationSchedule[x, 0]);
                parameters.Add("@8", loanNo);
                dal.executeNonQuery(sql, parameters);
            }
        }

        public decimal getLoanBalance(int noOfPeriod)
        {
            decimal loanBalance = 0;
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            //string sql = "select SUM(balanceAmount) from Amortization where isRestructured = 0 and isPaid = 0 and loanNo = @1";
            string sql = "select * from func_GetAmortizationToBePaid(@1,@2)";
            parameters.Add("@1",loanNo);
            parameters.Add("@2",noOfPeriod);
            SqlDataReader reader = dal.executeReader(sql,parameters);
            while (reader.Read())
            {
                loanBalance += Convert.ToDecimal(reader["balanceAmount"]);
                //System.Windows.Forms.MessageBox.Show(reader["balanceAmount"].ToString());
            }
            return loanBalance;
        }

        public decimal getLoanPenalty(int noOfPeriod)
        {
            decimal loanPenalty = 0;
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            //string sql = "select SUM(balanceAmount) from Amortization where isRestructured = 0 and isPaid = 0 and loanNo = @1";
            string sql = "select * from func_GetAmortizationToBePaid(@1,@2)";
            parameters.Add("@1", loanNo);
            parameters.Add("@2", noOfPeriod);
            SqlDataReader reader = dal.executeReader(sql, parameters);
            while (reader.Read())
            {
                loanPenalty += Convert.ToDecimal(reader["Penalty"]);
            }
            return loanPenalty;
        }

        public double getAmountPaid()
        {
            double totalAmount = 0;
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            string sql = "select SUM(totalAmount) - SUM(balanceAmount)  from Amortization where loanNo = @1 and isRestructured = 0";
            parameters.Add("@1", loanNo);
            SqlDataReader reader = dal.executeReader(sql, parameters);
            if (reader.Read())
            {
                totalAmount = Convert.ToDouble(reader[0]);
            }
            return totalAmount;
        }
    }
}
