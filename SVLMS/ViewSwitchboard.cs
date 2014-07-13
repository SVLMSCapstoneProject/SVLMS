using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Globalization;
using SVLMS;

namespace SVLMS
{
    public partial class ViewSwitchboard : Form
    {
        public String time;
        public String date;
        public ViewSwitchboard()
        {
            LaunchTime();
            InitializeComponent();
        }
        
        //
        // lblDateTime Events
        //
        public void LaunchTime()
        {
            DateTimeFormatInfo dateTimeFormat = new DateTimeFormatInfo();
            dateTimeFormat.ShortTimePattern = CultureInfo.CurrentCulture.DateTimeFormat.ShortTimePattern;
            dateTimeFormat.AMDesignator = "AM";
            dateTimeFormat.PMDesignator = "PM";

            time = DateTime.Now.ToString("t", dateTimeFormat);

            Timer tmr = new Timer();
            tmr.Interval = 1000;
            tmr.Tick += new EventHandler(TimerTick);
            tmr.Enabled = true;
        }

        public void TimerTick(object sender, EventArgs e)
        {
            if(time.Contains("A"))
                time = DateTime.Now.ToString(("hh:mm")) + " AM";
            else
                time = DateTime.Now.ToString("hh:mm") + " PM";
            date = DateTime.Now.ToString("MMMMMMMMM dd ,yyyy");
            lblDateTime.Text = date + " - " + time;
        }
        //
        // btnLogout Events
        //
        private void btnLogout_MouseHover(object sender, EventArgs e)
        {
            btnSettings.BackgroundImage = SVLMS.Properties.Resources.exit_bg_hover;
        }

        private void btnLogout_MouseLeave(object sender, EventArgs e)
        {
            btnSettings.BackgroundImage = SVLMS.Properties.Resources.exit_bg;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            ViewLoginForm vlf = new ViewLoginForm();            
            this.Close();
            vlf.Show();
        }
        //
        // btnSavingsAndDeposit Events
        //
        private void btnSavingsAndDeposit_Click(object sender, EventArgs e)
        {
            Savings.ViewSavingsDashboard s = new Savings.ViewSavingsDashboard();
            this.Close();
            s.Show();
        }
        
        private void btnSavingsAndDeposit_MouseHover(object sender, EventArgs e)
        {
            btnSavingsAndDeposit.Font = new Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }

        private void btnSavingsAndDeposit_MouseLeave(object sender, EventArgs e)
        {
            btnSavingsAndDeposit.Font = new Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }
        //
        // btnLoanManagement Events
        //
        private void btnLoanManagement_MouseHover(object sender, EventArgs e)
        {
            btnLoanManagement.Font = new Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }

        private void btnLoanManagement_MouseLeave(object sender, EventArgs e)
        {
            btnLoanManagement.Font = new Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }

        private void btnLoanManagement_Click(object sender, EventArgs e)
        {
            Loaning.ViewLoanDashboard s = new Loaning.ViewLoanDashboard();
            s.Show();
            this.Close();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            ViewLoginForm vl = new ViewLoginForm();
            this.Dispose();
            vl.Show();

        }

        

    }

    
}
