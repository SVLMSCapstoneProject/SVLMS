using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SVLMS.Loaning.Controller;
using SVLMS.Loaning.Model;
using SVLMS.Loaning.View;

namespace SVLMS.Loaning.View
{
    public partial class MaintenanceCollaterallView : Form
    {
        public event EventHandler saveClicked;
        public event EventHandler updateClicked;
        public event EventHandler dgClicked;
        public event EventHandler clearClicked;
        
        public MaintenanceCollaterallView()
        {
            InitializeComponent();
            dgCollateral.ReadOnly = true;
            dgCollateral.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }

        private void MaintenanceIntervalView_Load(object sender, EventArgs e)
        {

        }

        public void enableBtnSave()
        {
            btnSave.Enabled = true;
        }

        public void disableBtnSave()
        {
            btnSave.Enabled = false;
        }

        public void enableBtnUpdate()
        {
            btnUpdate.Enabled = true;
        }

        public void disableBtnUpdate()
        {
            btnUpdate.Enabled = false;
        }

        public void setCollateralInfo(DataSet ds)
        {
            dgCollateral.DataSource = ds.Tables[0];
        }

        public DataGridView getCollateralInfo()
        {
            return dgCollateral;
        }
        
        public string getCollateralId()
        {
            return txtCollateralId.Text;
        }

        public string getCollateralName()
        {
            return txtCollateralName.Text;
        }
        public string getDesc()
        {
            return txtDesc.Text;
        }

        public void setCollateralId(string id)
        {
            this.txtCollateralId.Text = id;
        }
        public void setCollateralName(string name)
        {
            this.txtCollateralName.Text = name;
        }
        public void setDesc(string desc) 
        {
            this.txtDesc.Text = desc;
        }

        public void setStatus(string status)
        {
            if (status == "1")
            {
                rbtnActive.Checked = true;
            }

            else 
            {
                rbtnInactive.Checked = true;
            }
        }

        public string getStatus()
        {
            string status = "";
            if (rbtnActive.Checked)
            {
                status = "1";
            }

            else if (rbtnInactive.Checked)
            {
                status = "0";
            }
            return status;
        }

        public string amountFormatter(string text)
        {
            double deduction = Convert.ToDouble(text);
            double truncated = Math.Truncate(deduction * 100) / 100;
            text = String.Format("{0:0.00}", truncated);
            return text;
        }

        public void setCollateralValue(string text)
        {
            if (text.Length != 0)
            {
                text = this.amountFormatter(text);
            }
            txtCollateralValue.Text = text;
        }

        public string getCollateralValue()
        {
            return txtCollateralValue.Text;
        }

        public void setListLoanType(DataSet ds)
        {
            listLoanType.DataSource = ds.Tables[0];
            listLoanType.DisplayMember = "loanName";
            listLoanType.ValueMember = "loanTypeID";
        }

        public void setchecklistbox(List<int> list)
        {


            int value = 0;

            for (int i = 0; i < listLoanType.Items.Count; i++)
            {

                DataRowView view = listLoanType.Items[i] as DataRowView;
                value = (int)view["loanTypeID"];
                if (list.Contains(value))
                {
                    listLoanType.SetItemChecked(i, true);
                }
                else
                {
                    listLoanType.SetItemChecked(i, false);
                }
            }
        }

        public List<int> getchecklistselected()
        {

            List<int> a = new List<int>();


            //MessageBox.Show("" + a.Count);


            foreach (DataRowView checkedItem in listLoanType.CheckedItems)
            {
                a.Add(int.Parse(checkedItem[listLoanType.ValueMember].ToString()));
                //MessageBox.Show("Checked item: "     + checkedItem[listBox1.ValueMember].ToString() + "."+a.Count);
            }

            return a;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
         //   MessageBox.Show("Test");
            if (saveClicked != null)
            {
           //     MessageBox.Show("Test");
                saveClicked(sender, e);
            }
        }

        private void dgCollateral_CellContentClick(object sender, EventArgs e)
        {
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(updateClicked != null)
            {
                updateClicked(sender, e);
            }
        }

        private void dgCollateral_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgClicked != null)
            {
                dgClicked(sender, e);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (clearClicked != null)
            {
                clearClicked(sender,e);
            }
        }
        //-----------------VALIDATIONS--------------------------
        //CollateralName
        public void errCollateralName()
        {
            txtCollateralName.BackColor = Color.Salmon;
        }

        public void unCollateralName()
        {
            txtCollateralName.BackColor = Color.White;
        }
        //CollateralValue
        public void errCollateralValue()
        {
            txtCollateralValue.BackColor = Color.Salmon;
        }

        public void unCollateralValue()
        {
            txtCollateralValue.BackColor = Color.White;
        }
        //Description
        public void errDescription()
        {
            txtDesc.BackColor = Color.Salmon;
        }

        public void unDescription()
        {
            txtDesc.BackColor = Color.White;
        }
        //status
        public void errStatus()
        {
            statusPanel.BackColor = Color.Salmon;
        }

        public void unStatus()
        {
            statusPanel.BackColor = Color.CornflowerBlue;
        }

        public int status()
        {
            int i = 0;
            if (rbtnActive.Checked == false && rbtnInactive.Checked == false)
                i = 1;
            return i;
        }

        private void txtCollateralName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsControl(e.KeyChar) || char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || char.IsWhiteSpace(e.KeyChar));
        }

        private void txtDesc_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsControl(e.KeyChar) || char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || char.IsWhiteSpace(e.KeyChar));
        }

        private void txtCollateralValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }
    }
}
