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
        private string strUsername;
        
        public LoginForm()
        {
            InitializeComponent();
            lblErrorMsg.Visible = false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            strUsername = txtUsername.Text;
            if (this.accountExists())
            {
                splash mf = new splash();
                this.Hide();
                mf.Show();
            }

            else
            {
                lblErrorMsg.Visible = true;
                txtPassword.Clear();
            }
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
                ModelUser.LName = reader[1].ToString();
                ModelUser.FName = reader[2].ToString();
                ModelUser.MName = reader[3].ToString();
                check = true;
            }
            return check;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you want to exit?", "Confirm Exit", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                Application.Exit();    
            }
        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            txtUsername.Clear();
            lblErrorMsg.Visible = false;
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                txtUsername.Text = strUsername;
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            lblErrorMsg.Visible = false;
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnLogin.PerformClick();
            }
            else if (e.KeyChar == (char)Keys.Escape)
            {
                btnCancel.PerformClick();
            }
        }

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnLogin.PerformClick();
            }
            else if (e.KeyChar == (char)Keys.Escape)
            {
                btnCancel.PerformClick();
            }
        }


    }
}
