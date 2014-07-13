using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SVLMS.Loaning.View;
using SVLMS.Loaning.Controller;
using SVLMS.Loaning.Model;


namespace SVLMS.Loaning.View
{
    public partial class TransactionComakerFamily : Form
    {
        public event EventHandler dgFamilyClicked;
  
        public TransactionComakerFamily()
        {
            InitializeComponent(); 
            dgFamily.ReadOnly = true;
            dgFamily.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        public DataGridView getFamily()
        {
            return dgFamily;
        }

        public void setFamily(DataSet ds)
        {
            dgFamily.DataSource = ds.Tables[0];

        }

        private void dgFamily_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgFamilyClicked != null)
            {
                dgFamilyClicked(sender, e);
            }
        }

       

    }
}
