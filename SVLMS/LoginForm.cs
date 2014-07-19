using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace SVLMS
{
    public partial class LoginForm : Form
    {

        public LoginForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (this.accountExists())
            {
                //main_form mf = new main_form();
                splash mf = new splash();
                this.Hide();
                mf.Show();
            }

            else
            {
                System.Windows.Forms.MessageBox.Show("Account not found.");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        public bool accountExists()
        {
            bool check = false;
            DataAccessLayer dal = new DataAccessLayer(ConfigurationManager.ConnectionStrings["coopdbConnectionString"].ConnectionString);
            string sql = "select * from Users where username = @1 AND password = @2";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@1", txtUsername.Text);
            parameters.Add("@2", txtPassword.Text);

            SqlDataReader reader = dal.executeReader(sql, parameters);
            if (reader.Read())
            {
                ModelUser.userID = reader[0].ToString();
                check = true;
            }
            return check;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
