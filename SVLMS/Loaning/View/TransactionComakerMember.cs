using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SVLMS.Loaning.View
{
    public partial class TransactionComakerMember : Form
    {
        public event EventHandler dgMemberClicked;
        


        public TransactionComakerMember()
        {
            InitializeComponent();
            dgmember.ReadOnly = true;
            dgmember.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        
        }

        public DataGridView getMember()
        {
            return dgmember;
        }

        public void setMember(DataSet ds)
        {
            dgmember.DataSource = ds.Tables[0];

        }

        private void dgmember_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgmember != null)
            {
                dgMemberClicked(sender, e);
            }
        }
    }
}
