using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SVLMS
{
    class DataAccessLayer
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataReader reader;
        SqlDataAdapter adapter;
        DataSet ds;

        public DataAccessLayer(string connString)
        {
            try
            {
                conn = new SqlConnection(connString);
                conn.Open();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        public void executeNonQuery(string sql, Dictionary<String, Object> parameters)
        {
            try
            {
                cmd = new SqlCommand(sql, conn);
                foreach(KeyValuePair<String, Object> row in parameters)
                {
                    cmd.Parameters.AddWithValue(row.Key,row.Value);
                }
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }   
        }

        public DataSet executeDataSet(string sql, Dictionary<String, Object> parameters)
        {
            try
            {
                cmd = new SqlCommand(sql,conn);
                foreach(KeyValuePair<String,Object> row in parameters)
                {
                    cmd.Parameters.AddWithValue(row.Key,row.Value);
                }
                adapter = new SqlDataAdapter(cmd);
                ds = new DataSet();
                adapter.Fill(ds);
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

            return ds;
        }

        public DataSet executeDataSet(string sql)
        {
            try
            {
                cmd = new SqlCommand(sql, conn);
                adapter = new SqlDataAdapter(cmd);
                ds = new DataSet();
                adapter.Fill(ds);
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            return ds;
        }

        public SqlDataReader executeReader(string sql)
        {
            cmd = new SqlCommand(sql, conn);
            reader = cmd.ExecuteReader();
            return reader;
        }

        public SqlDataReader executeReader(string sql, Dictionary<String, Object> parameters)
        {
            try
            {
                cmd = new SqlCommand(sql, conn);
                foreach (KeyValuePair<String, Object> row in parameters)
                {
                    cmd.Parameters.AddWithValue(row.Key, row.Value);
                }
                reader = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return reader;
        }


      /*  ~DataAccessLayer()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }*/
    }
}
