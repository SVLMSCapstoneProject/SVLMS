using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SVLMS.Savings.View
{
    public partial class XXXSampleCreate : Form
    {
        public XXXSampleCreate()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            XXXCreateSavings s = new XXXCreateSavings();
            this.Controls.Add(s);
        }
    }
}
