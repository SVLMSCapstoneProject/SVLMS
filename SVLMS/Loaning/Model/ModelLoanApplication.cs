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
    class ModelLoanApplication
    {
        public string loanNo { get; set; }
        public string memberType { get; set; }
        public string accountNo { get; set; }
        public string memberName { get; set; }
        public string collateralID { get; set; }
        public string dateOfApplication { get; set; }
        public string loanTypeID { get; set; }
        public string requestedAmount { get; set; }
        public string termsofPayment { get; set; }
        public string savingsAccountNo { get; set; }
        public string intervalPayment { get; set; }
        public string userID { get; set; }
        public string status { get; set; }
        public string remarks { get; set; }
        public string approvedAmount { get; set; }

        public string comakerID { get; set; }

        public string familyID { get; set; }
        public string familyName { get; set; }
        public string blkNoAddressFamily { get; set; }
        public string streetAddressFamily { get; set; }
        public string brgyAddressFamily { get; set; }
        public string cityAddressFamily { get; set; }

        public string comemberID { get; set; }
        public string comemberName { get; set; }

        public void insertLoanApplication()
        {
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            string sql = "exec sp_TransactionLoanApplicationInsert @1,@2,@3,@4,@5,@6,@7,@8,@9,@10";
            parameters.Add("@1", requestedAmount);
            parameters.Add("@2", dateOfApplication);
            parameters.Add("@3", termsofPayment);
            parameters.Add("@4", intervalPayment);
            parameters.Add("@5", accountNo);
            parameters.Add("@6", loanTypeID);
            parameters.Add("@7", status);
            parameters.Add("@8", remarks);
            parameters.Add("@9", approvedAmount);
            parameters.Add("@10",userID);
            dal.executeNonQuery(sql,parameters);
        }

        public void updateLoanApplication()
        {
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            string sql = "exec sp_TransactionLoanApplicationUpdate @11,@1,@2,@3,@4,@5,@6,@7,@8,@9,@10";
            parameters.Add("@1", requestedAmount);
            parameters.Add("@2", dateOfApplication);
            parameters.Add("@3", termsofPayment);
            parameters.Add("@4", intervalPayment);
            parameters.Add("@5", accountNo);
            parameters.Add("@6", loanTypeID);
            parameters.Add("@7", status);
            parameters.Add("@8", remarks);
            parameters.Add("@9", approvedAmount);
            parameters.Add("@10", userID);
            parameters.Add("@11",loanNo);
            dal.executeNonQuery(sql, parameters);
        }

        public DataSet getLoanApplicationRecords()
        {
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            string sql = "select A.loanNo as 'Loan No', B.loanName as 'Loan Type', (C.FName + ' '+ C.LName) as 'Member Name',A.requestedAmount as 'Requested Amount' from Loan A inner join LoanType B on (A.loanTypeID = B.loanTypeID) inner join Member  C on (A.accountNo = C.accountNo) where A.isReleased is null";
            DataSet ds = dal.executeDataSet(sql);
            return ds;
        }

        public void deleteComakers()
        {
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            string sql = "delete from Comakers where comakerID = @1";
            parameters.Add("@1", comakerID);
            dal.executeNonQuery(sql, parameters);
        }

        public void insertComakers()
        {
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            string sql = "exec sp_InsertComakers @1,@2,@3,@4,@5,@6,@7";
            parameters.Add("@1", loanNo);
            parameters.Add("@2", comemberID);
            parameters.Add("@3", familyID);
            parameters.Add("@4", blkNoAddressFamily);
            parameters.Add("@5", streetAddressFamily);
            parameters.Add("@6", brgyAddressFamily);
            parameters.Add("@7", cityAddressFamily);
            dal.executeNonQuery(sql, parameters);
        }

        public void updateComakers()
        {
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            string sql = "exec sp_UpdateComakers @8,@1,@2,@3,@4,@5,@6,@7";
            parameters.Add("@8", comakerID);
            parameters.Add("@1", loanNo);
            parameters.Add("@2", comemberID);
            parameters.Add("@3", familyID);
            parameters.Add("@4", blkNoAddressFamily);
            parameters.Add("@5", streetAddressFamily);
            parameters.Add("@6", brgyAddressFamily);
            parameters.Add("@7", cityAddressFamily);
            dal.executeNonQuery(sql, parameters);
        }

        public string getNextLoanNumber()
        {
            int nextNum = 0;
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            string sql = "select ISNULL(MAX(CAST(loanNo as INT)),0) from Loan";
            SqlDataReader reader = dal.executeReader(sql);
            if (reader.Read())
            {
                nextNum = Convert.ToInt32(reader[0])+1;
            }
            loanNo = "0000000" + nextNum;
            loanNo = loanNo.Substring(loanNo.Length - 7);
            return loanNo;
        }

        //model comaker-member
        public DataSet getcoMembers()
        {
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            string sql = "select B.accountNo as 'Account No',(B.LName+' '+B.FName+','+B.MName) as 'Member Name', Case when A.currentBalance >= '5000' then 'Regular' else 'Associate' END 'MemberType' from ShareCapital A inner join Member B on (A.accountNo = B.accountNo) where B.isTerminated != 1 and A.accountNo != @1 ";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@1", accountNo);
            DataSet ds = dal.executeDataSet(sql, parameters);
            return ds;
        }   

        //model comaker-family
        public DataSet getFamily()
        {
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            string sql = "select familyID as 'Family ID',(LName+','+FName+' '+MName) as Name, case when relationship = 1 then 'Son' when relationship = 2 then 'Daughter' when relationship = 3 then 'Cousin' when relationship = 4 then 'Mother' when relationship = 5 then 'Father'when relationship = 6 then 'Grandfather' when relationship = 7 then 'Grandmother' when relationship = 8 then 'Spouse' END 'Relationship' from Family where accountNo = @1 and isDependent != 1";
            //with legal age
            //string sql = "select familyID as 'Family ID',(LName+','+FName+' '+MName) as Name, case when relationship = 1 then 'Son' when relationship = 2 then 'Daughter' when relationship = 3 then 'Cousin' when relationship = 4 then 'Mother' when relationship = 5 then 'Father'when relationship = 6 then 'Grandfather' when relationship = 7 then 'Grandmother' when relationship = 8 then 'Spouse' END 'Relationship' from Family where accountNo = '0000001' and isDependent != 1 and DATEDIFF(year,birthDate,CAST(GETDATE() AS DATE)) >= 18";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@1", accountNo);
            DataSet ds = dal.executeDataSet(sql, parameters);
            return ds;

        }
        
        //model loan application
        public DataSet getMembers()
        {
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            string sql = "select B.accountNo as 'Account No',(B.LName+' '+B.FName+','+B.MName) as 'Member Name', C.memberTypeName as 'Member Type', C.memberTypeID from ShareCapital A inner join Member B on (A.accountNo = B.accountNo) inner join MemberType C on (B.memberTypeID = C.memberTypeID) where B.isTerminated != 1";
            DataSet ds = dal.executeDataSet(sql);
            return ds;
            
        }

        public DataSet searchByAccountNo()
        {
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            string sql = "select B.accountNo as 'Account No',(B.LName+' '+B.FName+','+B.MName) as 'Member Name', C.memberTypeName as 'Member Type', C.memberTypeID from ShareCapital A inner join Member B on (A.accountNo = B.accountNo) inner join MemberType C on (B.memberTypeID = C.memberTypeID) where B.isTerminated != 1 and B.accountNo LIKE @1";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@1", "%"+ accountNo + "%");
            DataSet ds = dal.executeDataSet(sql,parameters);
            return ds;

        }

        public DataSet searchByMemberName()
        {
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            string sql = "select B.accountNo as 'Account No',(B.LName+' '+B.FName+','+B.MName) as 'Member Name', C.memberTypeName as 'Member Type', C.memberTypeID from ShareCapital A inner join Member B on (A.accountNo = B.accountNo) inner join MemberType C on (B.memberTypeID = C.memberTypeID) where B.isTerminated != 1 and (B.LName+' '+B.FName+','+B.MName) LIKE @1";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@1", "%" + memberName + "%");
            DataSet ds = dal.executeDataSet(sql,parameters);
            return ds;

        }

        public DataSet getSavingsAccount()
        {
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            string sql = "select A.savingsAccountNo, C.savingsName from SavingsAccount A inner join MemberAccountHolder B on (A.savingsAccountNo = B.savingsAccountNo) inner join SavingsType C on (A.savingsTypeID = C.savingsTypeID) where B.accountNo = @1 and A.isClosed = 0";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@1",accountNo);
            DataSet ds = dal.executeDataSet(sql, parameters);
            return ds;
        }

        public DataSet getCboCollateral()
        {
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            string sql = "select A.collateralID,A.collateralName,C.loanName from Collateral A inner join CollateralLoan B on (A.collateralID = b.collateralID) inner join LoanType C on (B.loanTypeID = C.loanTypeID) where A.status !=0 and B.loanTypeID = @1";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@1", loanTypeID);
            DataSet ds = dal.executeDataSet(sql, parameters);
            return ds;
        }

        public DataSet getCboLoanType()
        {
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            string sql = "select A.loanTypeID,A.loanName from LoanType A inner join ApplicableLoans B on (A.loanTypeID = B.loanTypeID) where A.status != 0 and B.memberTypeID = @1 order by A.loanTypeID";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@1", memberType);
            DataSet ds = dal.executeDataSet(sql, parameters);
            return ds;
        }

        public SqlDataReader searchLoanApplication()
        {
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            string sql = "select B.accountNo, (B.LName+ ', '+B.FName + ' '+B.MName) as MemberName, C.comakerID, C.familyComaker, (E.LName + ',' + E.FName + ' '+E.MName) as FamilyComakerName, C.memberComaker, (F.LName+ ', '+F.FName + ' '+F.MName) as MemberComakerName, D.collateralID, D.collateralName, D.collateralDesc, A.loanNo, A.loanDate, A.loanTypeID, A.requestedAmount, A.termsOfPayment, A.paymentInterval, G.memberTypeID,A.status,A.approvedAmount,A.remarks,C.blkNoAddressFamily,C.streetAddressFamily,C.brgyAddressFamily,C.cityAddressFamily from Loan A inner join Member B on (A.accountNo = B.accountNo) left join Comakers C on (A.loanNo = C.loanNo) left join Collateral D on (A.loanNo = D.loanNo) left join Family E on (C.familyComaker = E.familyID) left join Member F on (C.memberComaker = F.accountNo) inner join MemberType G on (B.memberTypeID = G.memberTypeID) where A.loanNo = @1";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@1",loanNo);
            SqlDataReader reader = dal.executeReader(sql,parameters);
            return reader;
        }

        public void getMemberInfo()
        {
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            string sql = " select B.accountNo,(B.LName+' '+B.FName+','+B.MName) as memberName from ShareCapital A inner join Member B on (A.accountNo = B.accountNo) where A.accountNo = @1 ";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@1",accountNo);
            SqlDataReader reader = dal.executeReader(sql, parameters);
            if(reader.Read())
            {
                accountNo = reader[0].ToString();
                memberName = reader[1].ToString();
            }
        }

        public bool hasCollateral()
        {
            bool check = false;
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            string sql = "select hasCollateral from LoanType where loanTypeID = @1";
            parameters.Add("@1", loanTypeID);
            SqlDataReader reader = dal.executeReader(sql, parameters);
            if (reader.Read())
            {
                check = Convert.ToBoolean(reader[0]);
            }
            return check;
        }

        public bool hasComaker()
        {
            bool check = false;
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            string sql = "select hasComaker from LoanType where loanTypeID = @1";
            parameters.Add("@1",loanTypeID);
            SqlDataReader reader = dal.executeReader(sql,parameters);
            if (reader.Read())
            {
                if (Convert.ToInt32(reader[0]) == 1)
                {
                    check = true;
                }
            }
            return check;
        }

        public double getLoanBalance()
        {
            double loanBalance = 0;
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            string sql = "select SUM(C.balanceAmount) from Member A inner join Loan B on (A.accountNo = B.accountNo) inner join Amortization C on (B.loanNo = C.loanNo) where accountNo = @1";
            parameters.Add("@1",accountNo);
            SqlDataReader reader = dal.executeReader(sql, parameters);
            if (reader.Read())
            {
                loanBalance = Convert.ToDouble(reader[0]);
            }
            return loanBalance;
        }
    }
}
