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
    public partial class ViewLoginForm : Form
    {
        public ViewLoginForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ViewSwitchboard vsb = new ViewSwitchboard();
            this.Hide();
            vsb.Show();
        }
    }
}
