﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace SVLMS.Loaning.Model
{
    class ModelMemberType
    {
        public string typeID { get; set; }
        public string typeName { get; set; }
        public string minimumShare { get; set; }
        public string hasCertificate { get; set; }
        public string status { get; set; }
        public string memberTypeName { get; set; }
        public string memberTypeID { get; set; }
        public string updateTypeName { get; set; }

        public void insertMemberType()
        {
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            string sql = "exec sp_AddMemberType @1,@2,@3,@4";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@1",typeName);
            parameters.Add("@2",minimumShare);
            parameters.Add("@3",hasCertificate);
            parameters.Add("@4",status);
            dal.executeNonQuery(sql,parameters);
        }

        public void updateMemberType()
        {
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            string sql = "exec sp_UpdateMemberType @1,@2,@3,@4,@5";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@1",typeID);
            parameters.Add("@2", typeName);
            parameters.Add("@3", minimumShare);
            parameters.Add("@4",hasCertificate);
            parameters.Add("@5",status);
            dal.executeNonQuery(sql, parameters);
        }

        public DataSet getMemberTypeInfo()
        {
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            string sql = "select memberTypeID as TypeID, memberTypeName as 'Member Type', minimumNoOfShare as 'Minimum Share', (case when status = 1 then 'Active' else 'Inactive' end) as 'Status' from MemberType";
            DataSet ds = dal.executeDataSet(sql);
            return ds;
        }

        public DataSet searchMemberType(string filter, string textSearch)
        {
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            string sql = "";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            if (filter == "No Filter")
            {
                sql = "select memberTypeID as TypeID, memberTypeName as 'Member Type', minimumNoOfShare as 'Minimum Share', (case when status = 1 then 'Active' else 'Inactive' end) as 'Status' from MemberType where memberTypeName like @1";
            }

            else if (filter == "Active")
            {
                sql = "select memberTypeID as TypeID, memberTypeName as 'Member Type', minimumNoOfShare as 'Minimum Share', (case when status = 1 then 'Active' else 'Inactive' end) as 'Status' from MemberType where status = 1 and memberTypeName like @1";
            }

            else
            {
                sql = "select memberTypeID as TypeID, memberTypeName as 'Member Type', minimumNoOfShare as 'Minimum Share', (case when status = 1 then 'Active' else 'Inactive' end) as 'Status' from MemberType where status = 0 and memberTypeName like @1";
            }
            parameters.Add("@1","%"+textSearch+"%");
            DataSet ds = dal.executeDataSet(sql,parameters);
            return ds;
        }

        public SqlDataReader getMemberTypeRecord(string memberTypeID)
        {
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            string sql = "Select * from MemberType where memberTypeID = @1";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@1",memberTypeID);
            SqlDataReader reader = dal.executeReader(sql,parameters);
            return reader;
        }

        public string getNextID()
        {
            string id = "";
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            string sql = "select ISNULL(MAX(memberTypeID),0) + 1 from MemberType";
            SqlDataReader reader = dal.executeReader(sql);
            if (reader.Read())
            {
                id = reader[0].ToString();
            }
            return id;
        }

        public bool canPrintCertificate(string totalShareCapital)
        {
            bool check = false;
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            string sql = "select top 1 minimumNoOfShare from MemberType where hasCertificate = 1 order by minimumNoOfShare desc";
            SqlDataReader reader = dal.executeReader(sql);
            if (reader.Read())
            {
                double shareAmount = Convert.ToDouble(reader[0]);
                double totalShare = Convert.ToDouble(totalShareCapital);
                if (totalShare >= shareAmount)
                {
                    check = true;
                }
            }
            return check;
        }

        public void MemberTypeName()
        {
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            string sql = "select COUNT(memberTypeName) from vw_memberType where memberTypeName = @1";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@1", typeName);
            SqlDataReader reader = dal.executeReader(sql, parameters);
            if (reader.Read())
            {
                memberTypeName = reader[0].ToString();
            }
        }

        public void MemberTypeIDUpdate()
        {
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            string sql = "select COUNT(memberTypeID) from vw_memberType where memberTypeID = @1 AND memberTypeName = @2";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@1", typeID);
            parameters.Add("@2", updateTypeName);
            SqlDataReader reader = dal.executeReader(sql, parameters);
            if (reader.Read())
            {
                memberTypeID = reader[0].ToString();
            }        
        }
    }
}
