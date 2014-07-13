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
    public partial class TransactionMembership : Form
    {

        public event EventHandler saveChangesClicked;
        public event EventHandler updateClicked;
        public event EventHandler keyPressed;
        public event EventHandler addFamilyClicked; 
        public event EventHandler updateFamilyClicked;
        public event EventHandler dgClicked;
        public event EventHandler dependentClicked;
        public event EventHandler clrClicked;

        public TransactionMembership()
        {
            InitializeComponent();
            dgDependent.ReadOnly =true;
            dgDependent.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            btnUpdate.Enabled = false;
            btnUpdateFamily.Enabled = false;
            cboCivilStatus.SelectedIndex = 0;
            cboEducational.SelectedIndex = 0;
            cboEmploymentStatus.SelectedIndex = 0;
            cboGender.SelectedIndex = 0;
            cboIncomeSource.SelectedIndex = 0;
            cboRelationship.SelectedIndex = 0;
            cboSearchBy.SelectedIndex = 0;
            cboGenderFamily.SelectedIndex = 0;
            profilePicture.Image = Properties.Resources.Default;
        }

        /*
         *  Member Information 
         * 
         */

        public void setFamilyGender(string text)
        {
            if (text == "M")
            {
                cboGenderFamily.SelectedIndex = 0;
            }

            else if (text == "F")
            {
                cboGenderFamily.SelectedIndex = 1;
            }
        }

        public string getFamilyGender()
        {
            return cboGenderFamily.SelectedItem.ToString()[0].ToString();
        }

        public void setMemberLastName(string text)
        {
            txtLastName.Text = text;
        }

        public void setMemberFirstName(string text)
        {
            txtFirstName.Text = text;
        }

        public void setMemberMiddleName(string text)
        {
            txtMiddleName.Text = text;
        }

        public void setBlkNo(string text)
        {
            txtBlkNo.Text = text;
        }

        public void setStreet(string text)
        {
            txtStreet.Text = text;
        }

        public void setBrgy(string text)
        {
            txtBrgy.Text = text;
        }

        public void setCity(string text)
        {
            txtCity.Text = text;
        }

        public void setMemberGender(string gender)
        {
            if (gender == "M")
            {
                cboGender.SelectedItem = "Male";
            }

            else
            {
                cboGender.SelectedItem = "Female";
            }
        }

        public void setMemberBirthdate(string text)
        {
            dtpBirthdate.Value = Convert.ToDateTime(text);
        }

        //public void setMemberBirthPlace(string text)
        //{
        //    txtBirthPlace.Text = text;
        //}

        //public string getMemberBirthPlace()
        //{
        //    return txtBirthPlace.Text;
        //}

        public void setTelephoneNo(string text)
        {
            txtTelephone.Text = text;
        }

        public void setMobile(string text)
        {
            txtMobile.Text = text;
        }

        public void setMemberCivilStatus(string text)
        {
            cboCivilStatus.SelectedItem = text;
        }

        public void setMemberEmail(string text)
        {
            txtEmail.Text = text;
        }

        public void setMemberEducationalAttainment(string text)
        {
            cboEducational.SelectedItem = text;
        }

        public void setPassportNo(string text)
        {
            txtPassport.Text = text;
        }

        public void setSSSNo(string text)
        {
            txtSSS.Text = text;
        }

        public void setDriverLicense(string text)
        {
            txtDriverLicense.Text = text;
        }

        public void setMembershipDate(string text)
        {
            dtpMembershipDate.Value = Convert.ToDateTime(text);
        }

        public void setProfilePicture(string path)
        {
            profilePicture.ImageLocation = path;
        }

        public void setAccountNo(string text)
        {
            txtAccountNo.Text = text;
        }

        public void setDataGrid(DataSet ds)
        {
            dgMembers.DataSource = ds.Tables[0];
        }

        public void setFamilyInfo(DataSet ds)
        {
            dgDependent.DataSource = ds.Tables[0];
            dgDependent.Columns[0].Visible = false;
        }

        public string getSearchBy()
        {
            return cboSearchBy.SelectedItem.ToString();
        }

        public string getSearchBox()
        {
            return txtSearchBox.Text;
        }

        public string getAccountNo()
        {
            return txtAccountNo.Text;
        }

        public string getProfilePicture()
        {
            string location = "";

            if (profilePicture.ImageLocation != null)
            {
                location = profilePicture.ImageLocation.ToString();
            }
            return location;
        }

        public string getMemberBirthDate()
        {
            return dtpBirthdate.Value.ToString();
        }
        
        public string getMembershipDate()
        {
            return dtpMembershipDate.Value.ToString();
        }

        public string getMemberLastName()
        {
            return txtLastName.Text;
        }

        public string getMemberFirstName()
        {
            return txtFirstName.Text;
        }

        public string getMemberMiddleName()
        {
            return txtMiddleName.Text;
        }

        public string getSSSNo()
        {
            return txtSSS.Text;
        }

        public string getDriverLicense()
        {
            return txtDriverLicense.Text;
        }

        public string getMobileNo()
        {
            return txtMobile.Text;
        }

        public string getTelephoneNo()
        {
            return txtTelephone.Text;
        }

        public string getBlkNo()
        {
            return txtBlkNo.Text;
        }

        public string getBrgy()
        {
            return txtBrgy.Text;
        }

        public string getStreet()
        {
            return txtStreet.Text;
        }

        public string getCity()
        {
            return txtCity.Text;
        }

        public string getMemberEmail()
        {
            return txtEmail.Text;
        }

        public string getMemberGender()
        {
            string gender = "";
            if (cboGender.SelectedItem.ToString() == "Female")
            {
                gender = "F";
            }

            else
            {
                gender = "M";
            }
            return gender;
        }

        public string getMemberCivilStatus()
        {
            return cboCivilStatus.SelectedItem.ToString();
        }

        public string getEducationalAttainment()
        {
            return cboEducational.SelectedItem.ToString();
        }

        public string getPassportNo()
        {
            return txtPassport.Text;
        }

        /***
         * Spouse Informations
         * 
         * ***/

        public void setSpouseLastName(string text)
        {
            txtSpouseLastName.Text = text;
        }

        public void setSpouseFirstName(string text)
        {
            txtSpouseFirstName.Text = text;
        }

        public void setSpouseMiddleName(string text)
        {
            txtSpouseMiddleName.Text = text;
        }

        public void setSpouseBirthDate(string text)
        {
            if (text != null)
            {
                if (text.Length != 0)
                {
                    dtpSpouseBirthDate.Value = Convert.ToDateTime(text);
                }
            }
        }

        public string getSpouseLastName()
        {
            return txtSpouseLastName.Text;
        }

        public string getSpouseFirstName()
        {
            return txtSpouseFirstName.Text;
        }

        public string getSpouseMiddleName()
        {
            return txtSpouseMiddleName.Text;
        }

        public string getSpouseBirthDate()
        {
            return dtpSpouseBirthDate.Value.ToString();
        }

        public DataGridView getMemberInfo()
        {
            return dgMembers;
        }


        /*************************************
         * 
         * Financial Information Group box
         * 
         ************************************/

        public void setEmploymentStatus(string text)
        {
            cboEmploymentStatus.SelectedIndex = Convert.ToInt16(text)-1;
        }

        public void setIncomeSource(string text)
        {
            cboIncomeSource.SelectedIndex = Convert.ToInt16(text)-1;
        }

        public void setEmployerName(string text)
        {
            txtEmployerName.Text = text;
        }

        public void setEmployerAddress(string text)
        {
            txtEmployerAddress.Text = text;
        }

        public string getEmploymentStatus()
        {
            return (cboEmploymentStatus.SelectedIndex + 1).ToString();
        }

        public string getIncomeSource()
        {
            return (cboIncomeSource.SelectedIndex + 1).ToString();
        }

        public string getEmployerName()
        {
            return txtEmployerName.Text;
        }

        public string getEmployerAddress()
        {
            return txtEmployerAddress.Text;
        }

        /***************************
         * 
         * Family Information Tab
         * 
         ***************************/

        public DataGridView dgfamily()
        {
            return dgDependent;
        }

        public void setFamilyLastName(string text)
        {
            txtFamilyLastName.Text = text;
        }

        public void setFamilyFirstName(string text)
        {
            txtFamilyFirstName.Text = text;
        }

        public void setFamilyMiddleName(string text)
        {
            txtFamilyMiddleName.Text = text;
        }

        public void setFamilyBirthDate(string text)
        {
            dtpFamilyBirthDate.Value = Convert.ToDateTime(text);
        }

        public void setRelationship(string text)
        {
            cboRelationship.SelectedIndex = Convert.ToInt16(text)-1;
        }

        public void setIsDependent(string text)
        {
            if (text == "1")
            {
                chkDependent.Checked = true;
            }

            else if (text == "0")
            {
                chkDependent.Checked = false;
            }
        }

        public string getFamilyLastName()
        {
            return txtFamilyLastName.Text;
        }

        public string getFamilyFirstName()
        {
            return txtFamilyFirstName.Text;
        }

        public string getFamilyMiddleName()
        {
            return txtFamilyMiddleName.Text;
        }

        public string getFamilyBirthDate()
        {
            return dtpFamilyBirthDate.Value.ToShortDateString();
        }

        public string getRelationship()
        {
            return (cboRelationship.SelectedIndex + 1).ToString();
            
        }

        public string getRelationshipItem()
        {
            return cboRelationship.SelectedItem.ToString();
        }

        public void setRelationshipItem(string text)
        {
            cboRelationship.SelectedItem = text;
        }

        public string getIsDependent()
        {
            string isDependent = "";
            if (chkDependent.Checked)
            {
                isDependent = "1";
            }

            else
            {
                isDependent = "0";
            }
            return isDependent;
        }

        public string getIsDependentItem()
        {
            string isDependent = "";
            if (chkDependent.Checked)
            {
                isDependent = "Yes";
            }

            else
            {
                isDependent = "No";
            }
            return isDependent;
        }

        public DataGridView getFamilyDataGrid()
        {
            return dgDependent;
        }

        private void btnUploadPicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "JPG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png|GIF Files (*.gif)|*.gif";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                profilePicture.SizeMode = PictureBoxSizeMode.StretchImage;
                profilePicture.ImageLocation = ofd.FileName;
                profilePicture.Tag = ofd.SafeFileName;
                //pictureBox.Image.Save(@"Path",ImageFormat.Jpeg);
            }
        }

        public void saveProfilePicture(string accountNo)
        {
            string fileName = accountNo+".jpg";
            string directory = "UploadedImages";
            if (!System.IO.Directory.Exists(directory))
            {
                System.IO.Directory.CreateDirectory(directory);
            }

            if (profilePicture.Image != null)
            {
                profilePicture.Image.Save(@"UploadedImages\" + fileName, System.Drawing.Imaging.ImageFormat.Jpeg);
            }
        }

        public void addFamilyDataGridRow(string[] columns)
        {
            dgDependent.Rows.Add(columns);
            dgDependent.Columns[6].Visible = false;
            dgDependent.Columns[7].Visible = false;
        }

        public void addFamilyDataGridColumn()
        {
            dgDependent.Columns.Add("LastName","Last Name");
            dgDependent.Columns.Add("FirstName", "First Name");
            dgDependent.Columns.Add("MiddleName", "Middle Name");
            dgDependent.Columns.Add("Birthdate", "Birthdate");
            dgDependent.Columns.Add("Relationship", "Relationship");
            dgDependent.Columns.Add("Dependent","Dependent");
            dgDependent.Columns.Add("IsDependent", "IsDependent");
            dgDependent.Columns.Add("RelationshipIndex", "RelationshipIndex");
            dgDependent.Columns[6].Visible = false;
            dgDependent.Columns[7].Visible = false;
        }

        public void clearFamilyDataGrid()
        {
            dgDependent.Columns.Clear();
            //dgDependent.Rows.Clear();
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            if (saveChangesClicked != null)
            {
                saveChangesClicked(sender, e);
            }
        }

        private void txtSearchBox_TextChanged(object sender, EventArgs e)
        {
            if (keyPressed != null)
            {
                keyPressed(sender, e);
            }
        }

        private void btnAddFamily_Click(object sender, EventArgs e)
        {
            if (addFamilyClicked != null)
            {
                addFamilyClicked(sender, e);
                //this.refreshfieldsfamily();
            }
        }

        private void btnUpdateFamily_Click(object sender, EventArgs e)
        {
            if (updateFamilyClicked != null)
            {
                updateFamilyClicked(sender, e);
                //btnAddFamily.Enabled = true;
                //btnUpdateFamily.Enabled = false;
                //this.refreshfieldsfamily();
            }
        }
        
        public void refreshfieldsfamily()
        {
            this.setFamilyFirstName("");
            this.setFamilyLastName("");
            this.setFamilyMiddleName("");
            //this.setRelationship("");
            this.setIsDependent("0");

        }

        public void refreshfields()
        {

            this.setMemberFirstName("");
            this.setMemberLastName("");
            this.setMemberMiddleName("");
            this.setMemberGender("0");
            this.setBlkNo("");
            this.setTelephoneNo("");
            this.setMobile("");
            this.setMemberEmail("");
            this.setPassportNo("");
            this.setSSSNo("");
            this.setDriverLicense("");
            this.setProfilePicture("");
            this.setStreet("");
            this.setBrgy("");
            this.setCity("");
            //this.setMemberBirthPlace("");
            this.setMemberEducationalAttainment("0");
           
            this.setSpouseFirstName("");
            this.setSpouseLastName("");
            this.setSpouseMiddleName("");

            this.setEmployerName("");
            this.setEmployerAddress("");
            this.setEmploymentStatus("0");
            this.setIncomeSource("0");

            this.refreshfieldsfamily();
            this.dgDependent.DataSource = null;
            this.dgDependent.Rows.Clear();
            profilePicture.Image = Properties.Resources.Default;
        }
        

        private void dgMembers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgClicked != null)
            {
                dgClicked(sender, e);
                //btnUpdate.Enabled = true;
                //btnSaveChanges.Enabled = false;
            }
        }

        private void dgDependent_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dependentClicked != null)
            {
                dependentClicked(sender,e);
                //btnUpdateFamily.Enabled = true;
                //btnAddFamily.Enabled = false;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(updateClicked != null)
            {
                updateClicked(sender,e);
                
                //this.refreshfieldsfamily();
                //this.refreshfields();
            }
        }

        public void enableUpdate()
        {
            btnUpdate.Enabled = true;
            btnSaveChanges.Enabled = false;
        }

        public void enableSave()
        {
            btnUpdate.Enabled = false;
            btnSaveChanges.Enabled = true;
        }

        public void enableAddFamily()
        {
            btnAddFamily.Enabled = true;
            btnUpdateFamily.Enabled = false;
        }

        public void enableUpdateFamily()
        {
            btnUpdateFamily.Enabled = true;
            btnAddFamily.Enabled = false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if(clrClicked != null)
            {
                clrClicked(sender, e);
            }

        }

        public void setSignatureImage(string imagePath, string tag)
        {
            pictureSignature.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureSignature.ImageLocation = imagePath;
            pictureSignature.Tag = tag;
        }

        public PictureBox getSignatureImage()
        {
            return pictureSignature;
        }

        public void setSignatureImage2(string imagePath, string tag)
        {
            pictureSignature2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureSignature2.ImageLocation = imagePath;
            pictureSignature2.Tag = tag;
        }

        public PictureBox getSignatureImage2()
        {
            return pictureSignature2;
        }

        public void setBtnUploadEvent1(EventHandler e)
        {
            btnUpload.Click += e;
        }

        public void setBtnUploadEvent2(EventHandler e)
        {
            btnUpload2.Click += e;
        }

        public void clear()
        {
            btnUpdate.Enabled = false;
            btnSaveChanges.Enabled = true;
            this.dgDependent.DataSource = null;
            this.dgDependent.Rows.Clear();
            cboCivilStatus.SelectedIndex = 0;
            cboEducational.SelectedIndex = 0;
            cboEmploymentStatus.SelectedIndex = 0;
            cboGender.SelectedIndex = 0;
            cboIncomeSource.SelectedIndex = 0;
            cboRelationship.SelectedIndex = 0;
            cboSearchBy.SelectedIndex = 0;
            btnAddFamily.Enabled = true;
            btnUpdateFamily.Enabled = false;
            this.setSignatureImage("", "");
            this.setSignatureImage2("", "");
        }


    }
}
