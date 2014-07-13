using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SVLMS
{
    public partial class splash : Form
    {
        Timer tmr;
        public splash()
        {
            InitializeComponent();
        }

        private void splash_Shown(object sender, EventArgs e)
        {
            tmr = new Timer();
            tmr.Interval = 1000;
            tmr.Start();
            tmr.Tick += tmr_Tick;
        }

        void tmr_Tick(object sender, EventArgs e)
        {
            tmr.Stop();
            main_form mf = new main_form();
            mf.Show();
            this.Hide();
        }
    }
}
