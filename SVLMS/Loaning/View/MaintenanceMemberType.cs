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
    public partial class MaintenanceMemberType : Form
    {

        public event EventHandler saveClicked;
        public event EventHandler updateClicked;
        public event EventHandler clearClicked;
        public event EventHandler cellClicked;

        public MaintenanceMemberType()
        {
            InitializeComponent();
            cboFilter.SelectedIndex = 0;
        }

        public string getCboFilter()
        {
            return cboFilter.SelectedItem.ToString();
        }

        public string getTextSearch()
        {
            return txtSearchBox.Text;
        }

        public void setBtnSaveEvent(EventHandler e)
        {
            btnSave.Click += e;
        }

        public void setBtnUpdateEvent(EventHandler e)
        {
            btnUpdate.Click += e;
        }

        public void setBtnClearEvent(EventHandler e)
        {
            btnClear.Click += e;
        }

        public void settxtTypeName(EventHandler e)
        {
            txtTypeName.Leave += e;
        }

        public void setDataGridEvent(DataGridViewCellEventHandler e)
        {
            dgMemberType.CellDoubleClick += e;
        }

        public void setCboFilterEvent(EventHandler e)
        {
            cboFilter.SelectedIndexChanged += e;
        }

        public void setTxtSearchEvent(EventHandler e)
        {
            txtSearchBox.TextChanged += e;
        }

        //public string getTypeID()
        //{
        //    return txtTypeID.Text;
        //}

        public void clearRadioButton()
        {
            rbtnActive.Checked = false;
            rbtnInactive.Checked = false;
        }

        public void clearCheckBox()
        {
            chkHasCertificate.Checked = false;
        }

        public string getTypeID()
        {
            return txtTypeID.Text;
        }

        public string getMemberTypeName()
        {
            string result = "";
            char[] str = txtTypeName.Text.ToCharArray();
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ' ')
                { }
                else
                    result += str[i];
            }
            return result.ToLower();            
        }

        public string getTypeName()
        {
            return txtTypeName.Text;
        }

        public string getMinimumShare()
        {
            return txtMinimumShare.Text;
        }

        public void setTypeID(string typeID)
        {
            txtTypeID.Text = typeID;
        }

        public void setTypeName(string typeName)
        {
            txtTypeName.Text = typeName;
        }

        public void setMinimumShare(string min)
        {
            txtMinimumShare.Text = min;
        }

        public DataGridView getDataGrid()
        {
            return dgMemberType;
        }

        public void setDataGrid(DataSet ds)
        {
            dgMemberType.DataSource = ds.Tables[0];
            dgMemberType.Columns[0].Visible = false;
        }

        public void setStatus(string status)
        {
            if (status == "1")
            {
                rbtnActive.Checked = true;
            }

            else if (status == "0")
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

        public void setHasCertificate(string hasCertificate)
        {
            if (hasCertificate == "1")
            {
                chkHasCertificate.Checked = true;
            }

            else
            {
                chkHasCertificate.Checked = false;
            }
        }

        public string getHasCertificate()
        {
            string hasCertificate = "0";
            if (chkHasCertificate.Checked)
            {
                hasCertificate = "1";
            }

            return hasCertificate;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (saveClicked != null)
            {
                saveClicked(sender, e);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (updateClicked != null)
            {
                updateClicked(sender, e);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (clearClicked != null)
            {
                clearClicked(sender, e);
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (cellClicked != null)
            {
                cellClicked(sender, e);
            }
        }

        public void enableUpdate()
        {
            btnUpdate.Enabled = true;
        }

        public void disableUpdate()
        {
            btnUpdate.Enabled = false;
        }

        public void enableSave()
        {
            btnSave.Enabled = true;
        }

        public void disableSave()
        {
            btnSave.Enabled = false;
        }
        //typename
        public void errTypeName()
        {
            txtTypeName.BackColor = Color.Salmon;
        }

        public void unTypeName()
        {
            txtTypeName.BackColor = Color.White;
        }
        //MinimumShare
        public void errMinimumshare()
        {
            txtMinimumShare.BackColor = Color.Salmon;
        }

        public void unMinimumShare()
        {
            txtMinimumShare.BackColor = Color.White;
        }
        //status
        public void errStatus()
        {
            statusPanel.BackColor = Color.Salmon;
        }

        public void unStatus()
        {
            statusPanel.BackColor = Color.White;
        }

        public int status()
        {
            int i = 0;
            if (rbtnActive.Checked == false && rbtnInactive.Checked == false)
            {
                i = 1;
            }
            return i;
        }
        //HasCertificate
        public void errCertificate()
        {
            HasCertificatepanel.BackColor = Color.Salmon;
        }

        public void unCertificate()
        {
            HasCertificatepanel.BackColor = Color.White;
        }

        public int certificate()
        {
            int i = 0;
            if (chkHasCertificate.Checked == false)
                i = 1;
            return i;
        }

        private void txtMinimumShare_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtTypeName_Validating_1(object sender, CancelEventArgs e)
        {
            setTypeName(txtTypeName.Text.Trim());
        }
    }
}
