using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SVLMS.Utilities
{
    public partial class UtilitiesForm : Form
    {
        public UtilitiesForm()
        {
            InitializeComponent();
        }

        private void holidaysToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BatchProcessing bp = new BatchProcessing();
            bp.Show();
        }

        private void manageUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserType ut = new UserType();
            ut.Show();
        }
    }
}
