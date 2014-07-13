using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace SVLMS.Savings.Model
{
    class ModelMember
    {
        //Member Information
        public string accountNo { get; set; }
        public string memberLastName { get; set; }
        public string memberFirstName { get; set; }
        public string memberMiddleName { get; set; }
        public string memberBlkNoAddress { get; set; }
        public string memberStreetAddress { get;set; }
        public string memberBrgyAddress { get; set; }
        public string memberCityAddress { get; set; }
        public string membershipDate { get; set; }
        public string memberBirthDate { get; set; }
        public string memberGender { get; set; }
        public string memberBirthPlace { get; set; }
        public string telephoneNo { get; set; }
        public string mobileNo { get; set; }
        public string civilStatus { get; set; }
        public string emailAddress { get; set; }
        public string memberEducational { get; set; }
        public string passportNo { get; set; }
        public string SSSNo { get; set; }
        public string driverLicenseNo { get; set; }
        public string profilePicture { get; set; }

        //Spouse Information
        public string spouseLastName { get; set; }
        public string spouseFirstName { get; set; }
        public string spouseMiddleName { get; set; }
        public string spouseBirthDate { get; set; }

        //Financial Information
        public string employmentStatus { get; set; }
        public string incomeSource { get; set; }
        public string employerName { get; set; }
        public string employerAddress { get; set; }

        //Family Member
        public string familyID { get; set; }
        public string familyLName { get; set; }
        public string familyMName { get; set; }
        public string familyFName { get; set; }
        public string familyBirthDate { get; set; }
        public string familyGender { get; set; }
        public string relationship { get; set; }
        public string isDependent { get; set; }


        //Termination
        public string terminationDate { get; set; }
        public string terminationReason { get; set; }
        public string remarks { get; set; }

        public string userID { get; set; }

        public void updateMember() 
        {
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            string sql = "exec sp_TransactionUpdateMember @1,@2,@3,@4,@5,@6,@7,@8,@9,@10,@11,@12,@13,@14,@15,@16,@17,@18,@19,@20,@21,@22,@23,@24,@25,@26,@27,@28";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            
            //Member Information
            parameters.Add("@1",accountNo);
            parameters.Add("@2",memberLastName);
            parameters.Add("@3",memberFirstName);
            parameters.Add("@4",memberMiddleName);
            parameters.Add("@5",memberBlkNoAddress);
            parameters.Add("@6", memberStreetAddress);
            parameters.Add("@7", memberBrgyAddress);
            parameters.Add("@8", memberCityAddress);
            parameters.Add("@9",membershipDate);
            parameters.Add("@10",memberBirthDate);
            parameters.Add("@11",memberGender);
            parameters.Add("@12",telephoneNo);
            parameters.Add("@13",mobileNo);
            parameters.Add("@14",emailAddress);
            parameters.Add("@15",passportNo);
            parameters.Add("@16",driverLicenseNo);
            parameters.Add("@17",SSSNo);
            parameters.Add("@18",civilStatus);
            parameters.Add("@19",memberEducational);
            parameters.Add("@20",profilePicture);

            //SpouseInformation
            parameters.Add("@21",spouseLastName);
            parameters.Add("@22", spouseFirstName);
            parameters.Add("@23", spouseMiddleName);
            parameters.Add("@24", spouseBirthDate);

            //Financial Information
            parameters.Add("@25",employmentStatus);
            parameters.Add("@26",incomeSource);
            parameters.Add("@27",employerName);
            parameters.Add("@28",employerAddress);
            dal.executeNonQuery(sql,parameters);
        }
        
        public void updateFamilyInfo()
        {
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            string sql = "update family set LName = @1, FName = @2, MName = @3, birthDate = @4, relationship = @5, isDependent = @6, accountNo = @7, gender = @9 where familyID = @8";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@1", familyLName);
            parameters.Add("@2", familyFName);
            parameters.Add("@3", familyMName);
            parameters.Add("@4", familyBirthDate);
            parameters.Add("@5", relationship);
            parameters.Add("@6", isDependent);
            parameters.Add("@7", accountNo);
            parameters.Add("@8", familyID);
            parameters.Add("@9", familyGender);
            dal.executeNonQuery(sql, parameters);
            
        }

        public void searchFamilyInfo()
        {
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            string sql = "select * from family where familyID = @1";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@1",familyID);
            SqlDataReader reader = dal.executeReader(sql,parameters);
            if (reader.Read())
            {
                familyLName = reader[1].ToString();
                familyFName = reader[2].ToString();
                familyMName = reader[3].ToString();
                familyBirthDate = reader[4].ToString();
                familyGender = reader[5].ToString();
                relationship = reader[6].ToString();
                isDependent = reader[7].ToString();
            }

        }
        public void searchMemberInfo()
        {
        
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            string sql = "select * from Member where accountNo = @1";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@1", accountNo);
            SqlDataReader reader = dal.executeReader(sql,parameters);
            if(reader.Read())
            {
                accountNo = reader[0].ToString();
                memberLastName = reader[1].ToString();
                memberFirstName = reader[2].ToString();
                memberMiddleName = reader[3].ToString();
                memberBlkNoAddress = reader[4].ToString();
                memberStreetAddress = reader[5].ToString();
                memberBrgyAddress = reader[6].ToString();
                memberCityAddress = reader[7].ToString();
                membershipDate = reader[8].ToString();
                memberBirthDate = reader[9].ToString();
                memberGender = reader[10].ToString();
                telephoneNo = reader[11].ToString();
                mobileNo = reader[12].ToString();
                emailAddress = reader[13].ToString();
                passportNo = reader[14].ToString();
                driverLicenseNo = reader[15].ToString();
                SSSNo = reader[16].ToString();
                civilStatus = reader[17].ToString();
                memberEducational = reader[18].ToString();
                profilePicture = reader[23].ToString();
            }

            reader.Close();
            sql = "select * from MemberFinancial where accountNo = @1";
            reader = dal.executeReader(sql,parameters);
            if (reader.Read())
            {
                employmentStatus = reader[1].ToString();
                incomeSource = reader[2].ToString();
                employerName = reader[3].ToString();
                employerAddress = reader[4].ToString();
            }

            reader.Close();
            sql = "select * from Family where relationship = 8 and accountNo = @1";
            parameters.Clear();
            parameters.Add("@1",accountNo);
            reader = dal.executeReader(sql,parameters);
            if(reader.Read())
            {
                spouseLastName = reader[1].ToString();
                spouseMiddleName = reader[3].ToString();
                spouseFirstName = reader[2].ToString();
                spouseBirthDate = reader[4].ToString();
            }

        }

        public DataSet getFamilyInfo()
        {
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            string sql = "select familyID,LName as 'Last Name',FName as 'First Name',MName as 'Middle Name',birthDate as 'Birthdate' from Family where accountNo = @1 and relationship != 8";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@1",accountNo);
            DataSet ds = dal.executeDataSet(sql, parameters);
            return ds;
        }
        
        public string getNextAccountNo()
        {
            string accountNo = "0000000";
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            string sql = "select ISNULL(MAX(accountNo),0)+1 from Member";
            SqlDataReader reader = dal.executeReader(sql);
            reader.Read();
            accountNo += reader[0].ToString();
            accountNo = accountNo.Substring(accountNo.Length - 7);
            return accountNo;
        }

        public DataSet displayMemberInfo()
        {
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            string sql = "select accountNo as AccountNo, (LName+', '+ FName +' '+MName) as MemberName, membershipDate as MembershipDate from Member where isTerminated != 1";
            DataSet ds = dal.executeDataSet(sql);
            return ds;
        }

        public DataSet displayTerminatedMembers()
        {
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            string sql = "select A.accountNo as AccountNo, (A.LName+', '+ A.FName +' '+A.MName) as MemberName, A.terminationDate as 'Date of Termination' from Member A inner join ShareCapital B on (A.accountNo = B.accountNo) where isTerminated = 1 and B.isClosed != 1";
            DataSet ds = dal.executeDataSet(sql);
            return ds;
        }


        public DataSet searchTerminatedAccountNo()
        {
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);

            string sql = "select A.accountNo as AccountNo, (A.LName+', '+ A.FName +' '+A.MName) as MemberName, A.terminationDate as 'Date of Termination' from Member A inner join ShareCapital B on (A.accountNo = B.accountNo) where A.accountNo LIKE @1 and isTerminated = 1 and B.isClosed != 1";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@1", "%" + accountNo + "%");
            DataSet ds = dal.executeDataSet(sql, parameters);
            return ds;
        }

        public DataSet searchTerminatedMemberName()
        {
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            string sql = "select A.accountNo as AccountNo, (A.LName+', '+ A.FName +' '+A.MName) as MemberName, A.terminationDate as 'Date of Termination' from Member A inner join ShareCapital B on (A.accountNo = B.accountNo) where (A.LName+', '+ A.FName +' '+A.MName) LIKE @1 and isTerminated = 1 and B.isClosed != 1";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@1", "%" + memberLastName + "%");
            DataSet ds = dal.executeDataSet(sql, parameters);
            return ds;
        }

        public DataSet searchByAccountNo()
        {
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            
            string sql = "select accountNo as AccountNo, (LName+', '+ FName +' '+MName) as MemberName, membershipDate as MembershipDate from Member where accountNo LIKE @1 and isTerminated != 1";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@1","%"+accountNo+"%");
            DataSet ds = dal.executeDataSet(sql,parameters);
            return ds;
        }

        public DataSet searchByMemberName()
        {
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            string sql = "select accountNo as AccountNo, (LName+', '+ FName +' '+MName) as MemberName, membershipDate as MembershipDate from Member where (LName+', '+ FName +' '+MName) LIKE @1 and isTerminated != 1";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@1", "%" + memberLastName + "%");
            DataSet ds = dal.executeDataSet(sql, parameters);
            return ds;
        }



        public void insertMember()
        {
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            string sql = "exec sp_TransactionInsertMember @1,@2,@3,@4,@5,@6,@7,@8,@9,@10,@11,@12,@13,@14,@15,@16,@17,@18,@19,@20,@21,@22,@23,@24,@25,@26,@27,@28,@29";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            
            //Member Information
            parameters.Add("@1",accountNo);
            parameters.Add("@2",memberLastName);
            parameters.Add("@3",memberFirstName);
            parameters.Add("@4",memberMiddleName);
            parameters.Add("@5", memberBlkNoAddress);
            parameters.Add("@6", memberStreetAddress);
            parameters.Add("@7", memberBrgyAddress);
            parameters.Add("@8", memberCityAddress);
            parameters.Add("@9",membershipDate);
            parameters.Add("@10",memberBirthDate);
            parameters.Add("@11",memberGender);
            parameters.Add("@12",telephoneNo);
            parameters.Add("@13",mobileNo);
            parameters.Add("@14",emailAddress);
            parameters.Add("@15",passportNo);
            parameters.Add("@16",driverLicenseNo);
            parameters.Add("@17",SSSNo);
            parameters.Add("@18",civilStatus);
            parameters.Add("@19",memberEducational);
            parameters.Add("@20",profilePicture);

            //SpouseInformation
            parameters.Add("@21",spouseLastName);
            parameters.Add("@22", spouseFirstName);
            parameters.Add("@23", spouseMiddleName);
            parameters.Add("@24", spouseBirthDate);

            //Financial Information
            parameters.Add("@25",employmentStatus);
            parameters.Add("@26",incomeSource);
            parameters.Add("@27",employerName);
            parameters.Add("@28",employerAddress);
            parameters.Add("@29", userID);
            dal.executeNonQuery(sql,parameters);
        }

        public void insertFamilyMember()
        {
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            string sql = "exec sp_InsertFamily @1,@2,@3,@4,@5,@6,@7,@8";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@1",familyLName);
            parameters.Add("@2",familyFName);
            parameters.Add("@3", familyMName);
            parameters.Add("@4", familyBirthDate);
            parameters.Add("@5", relationship);
            parameters.Add("@6", isDependent);
            parameters.Add("@7", familyGender);
            parameters.Add("@8", accountNo);
            dal.executeNonQuery(sql,parameters);
        }

        public void terminateMember()
        {
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            string sql = "exec sp_TransactionTerminateMember @1,@2,@3,@4";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@1",accountNo);
            parameters.Add("@2",terminationDate);
            parameters.Add("@3",terminationReason);
            parameters.Add("@4",remarks);
            dal.executeNonQuery(sql,parameters);
        }

        public DataSet getSavingsAccounts()
        {
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            string sql = "select * from func_GetSavingsAccounts(@1)";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@1", accountNo);
            DataSet ds = dal.executeDataSet(sql,parameters);
            return ds;
        }

        public SqlDataReader getSavingsAccountsReader()
        {
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            string sql = "select * from func_GetSavingsAccounts(@1)";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@1", accountNo);
            SqlDataReader reader = dal.executeReader(sql, parameters);
            return reader;
        }

        public string getTotalSavings()
        {
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            string sql = "select * from func_GetSavingsAccounts(@1)";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@1", accountNo);
            SqlDataReader reader = dal.executeReader(sql,parameters);
            double total = 0;
            while (reader.Read())
            {
                total += Convert.ToDouble(reader["Current Balance"]);
            }
            return total.ToString();
        }
    }
}
