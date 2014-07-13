using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;

namespace SVLMS
{
    public partial class main_form : Form
    {

        string a;
        public main_form()
        {
            InitializeComponent();
            StartTimer();
            this.ControlBox = false;
        }


        System.Windows.Forms.Timer tmr = null;
        private void StartTimer()
        {
            DateTimeFormatInfo timeFormat = new DateTimeFormatInfo();
            timeFormat.ShortTimePattern = CultureInfo.CurrentCulture.DateTimeFormat.ShortTimePattern;
            timeFormat.AMDesignator = "AM";
            timeFormat.PMDesignator = "PM";

            a = DateTime.Now.ToString("t", timeFormat);

            tmr = new System.Windows.Forms.Timer();
            tmr.Interval = 1000;
            tmr.Tick += new EventHandler(tmr_Tick);
            tmr.Enabled = true;
        }

        void tmr_Tick(object sender, EventArgs e)
        {
            if (a.Contains("A"))
            {
                time.Text = "" + (DateTime.Now.ToString("hh:mm")) + "AM";
            }
            else
            {
                time.Text = "" + (DateTime.Now.ToString("hh:mm") + "PM");
            }
            date.Text = DateTime.Now.ToString("dd-MMM-yyyy");
        }     
 
        private void savings_form_Click(object sender, EventArgs e)
        {
            savings_form save = new savings_form();
            this.Hide();
            save.Show();
        }

        private void loan_form_Click(object sender, EventArgs e)
        {
            loan_form loan = new loan_form();
            this.Hide();
            loan.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm lf = new LoginForm();
            lf.Show();
        }

        private void utilities_Click(object sender, EventArgs e)
        {
            this.Close();
            Utilities.UtilitiesForm uf = new Utilities.UtilitiesForm();
            uf.Show();
        }
    }
}