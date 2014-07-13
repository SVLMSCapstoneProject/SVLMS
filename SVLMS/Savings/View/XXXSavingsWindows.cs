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
    public partial class XXXSavingsWindows : Form
    {
        public XXXSavingsWindows()
        {
            InitializeComponent();
            tabControl1.Controls.Remove(tabPage2);
            tabControl1.Controls.Remove(tabPage3);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!tabControl1.Controls.ContainsKey(tabPage2.Name))
            {
                tabControl1.Controls.Add(tabPage2);
                tabControl1.SelectedIndex = tabControl1.Controls.Count - 1;
            }

            else
            {
                tabControl1.SelectedIndex = tabControl1.Controls.GetChildIndex(tabPage2);
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!tabControl1.Controls.ContainsKey(tabPage3.Name))
            {
                tabControl1.Controls.Add(tabPage3);
                tabControl1.SelectedIndex = tabControl1.Controls.Count - 1;
            }

            else
            {
                tabControl1.SelectedIndex = tabControl1.Controls.GetChildIndex(tabPage3);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panelAccountHolder.Visible = true;
            panelManageAccountHolder.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            panelManageAccountHolder.Visible = true;
            panelAccountHolder.Visible = false;
        }
    }
}
