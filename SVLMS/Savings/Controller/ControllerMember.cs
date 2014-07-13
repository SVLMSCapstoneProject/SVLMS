using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using SVLMS.Savings.Model;
using SVLMS.Savings.View;
using System.IO;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace SVLMS.Savings.Controller
{
    class ControllerMember
    {
        ModelMember model;
        TransactionMembership view;

        public bool isUpdating { get; set; }
        public ControllerMember(ModelMember model, TransactionMembership view)
        {
            this.model = model;
            this.view = view;

            this.view.setAccountNo(model.getNextAccountNo());
            this.view.setDataGrid(model.displayMemberInfo());
            this.view.Show();
            this.view.saveChangesClicked += new EventHandler(btnSaveClicked);
            this.view.keyPressed += new EventHandler(searchKeyPressed);
            this.view.addFamilyClicked += new EventHandler(btnAddFamily);
            this.view.updateFamilyClicked += new EventHandler(btnUpdateFamily);
            this.view.dgClicked += new EventHandler(dgClicked);
            this.view.dependentClicked += new EventHandler(dependentClicked);
            this.view.updateClicked += new EventHandler(updateClicked);
            this.view.clrClicked += new EventHandler(clrClicked);
            this.view.setBtnUploadEvent1(BtnUpload1Clicked1);
            this.view.setBtnUploadEvent2(BtnUpload1Clicked2);
            isUpdating = false;
            this.view.addFamilyDataGridColumn();
        }

        public void BtnUpload1Clicked1(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "JPG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png|GIF Files (*.gif)|*.gif";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                view.setSignatureImage(ofd.FileName, ofd.SafeFileName);
            }
        }

        public void BtnUpload1Clicked2(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "JPG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png|GIF Files (*.gif)|*.gif";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                view.setSignatureImage2(ofd.FileName, ofd.SafeFileName);
            }
        }

        public void clrClicked(object sender, EventArgs e)
        {
            this.view.setAccountNo(model.getNextAccountNo());
            this.view.refreshfields();
            this.view.refreshfieldsfamily();
            this.view.clear();

            if (!isUpdating)
            {
                this.view.clearFamilyDataGrid();
            }
            this.view.addFamilyDataGridColumn();
            //MessageBox.Show(isUpdating.ToString());
            isUpdating = false;
        }

        public void updateClicked(object sender, EventArgs e)
        {
            if (this.validateMemberRegistration())
            {
                //Member Information
                model.accountNo = view.getAccountNo();
                model.memberLastName = view.getMemberLastName();
                model.memberFirstName = view.getMemberFirstName();
                model.memberMiddleName = view.getMemberMiddleName();
                model.memberBlkNoAddress = view.getBlkNo();
                model.memberStreetAddress = view.getStreet();
                model.memberBrgyAddress = view.getBrgy();
                model.memberCityAddress = view.getCity();
                model.accountNo = view.getAccountNo();
                model.membershipDate = view.getMembershipDate();
                model.memberGender = view.getMemberGender();
                model.memberBirthDate = view.getMemberBirthDate();
                model.telephoneNo = view.getTelephoneNo();
                model.mobileNo = view.getMobileNo();
                model.civilStatus = view.getMemberCivilStatus();
                model.emailAddress = view.getMemberEmail();
                model.memberEducational = view.getEducationalAttainment();
                model.passportNo = view.getPassportNo();
                model.SSSNo = view.getSSSNo();
                model.driverLicenseNo = view.getDriverLicense();
                model.profilePicture = Path.GetFileName(view.getProfilePicture());

                //Spouse Information
                model.spouseLastName = view.getSpouseLastName();
                model.spouseFirstName = view.getSpouseFirstName();
                model.spouseMiddleName = view.getSpouseMiddleName();
                model.spouseBirthDate = view.getSpouseBirthDate();

                //Financial Information
                model.employmentStatus = view.getEmploymentStatus();
                model.employerName = view.getEmployerName();
                model.employerAddress = view.getEmployerAddress();
                model.incomeSource = view.getIncomeSource();

                model.updateMember();
                MessageBox.Show("Member Profile Updated");
                view.saveProfilePicture(model.accountNo);
                view.setAccountNo(model.getNextAccountNo());
                view.clearFamilyDataGrid();
                view.addFamilyDataGridColumn();
                PictureBox pb = view.getSignatureImage();
                this.saveImage(pb, "SpecimenSignatures1", model.accountNo + ".jpeg");
                pb = view.getSignatureImage2();
                this.saveImage(pb, "SpecimenSignatures2", model.accountNo + ".jpeg");
                view.setSignatureImage("", "");
                view.setSignatureImage2("", "");
                isUpdating = false;
                view.enableSave();
                view.refreshfields();
                this.view.setDataGrid(model.displayMemberInfo());
            }
        }

        public void dependentClicked(object sender, EventArgs e)
        {
            DataGridView dg = view.dgfamily();
            int row = dg.CurrentCell.RowIndex;
            if (isUpdating)
            {
                model.familyID = dg.Rows[row].Cells[0].Value.ToString();
                model.searchFamilyInfo();

                view.setFamilyLastName(model.familyLName);
                view.setFamilyFirstName(model.familyFName);
                view.setFamilyMiddleName(model.familyMName);
                view.setFamilyBirthDate(model.familyBirthDate);
                view.setRelationship(model.relationship);
                view.setIsDependent(model.isDependent);
                view.setFamilyGender(model.familyGender);
                view.enableUpdateFamily();
            }

        }

        public void dgClicked(object sender, EventArgs e)
        {
            DataGridView dg = view.getMemberInfo();
            int row = dg.CurrentCell.RowIndex;
            model.accountNo = dg.Rows[row].Cells[0].Value.ToString();
            model.searchMemberInfo();
            
            //transfer memberinfo to view
            view.setProfilePicture(@"UploadedImages\" + model.accountNo + ".jpg");
            view.setAccountNo(model.accountNo);
            view.setMemberLastName(model.memberLastName);
            view.setMemberFirstName(model.memberFirstName);
            view.setMemberMiddleName(model.memberMiddleName);
            view.setBlkNo(model.memberBlkNoAddress);
            view.setStreet(model.memberStreetAddress);
            view.setBrgy(model.memberBrgyAddress);
            view.setCity(model.memberCityAddress);
            view.setMembershipDate(model.membershipDate);
            view.setMemberBirthdate(model.memberBirthDate);
            view.setMemberGender(model.memberGender);
            view.setTelephoneNo(model.telephoneNo);
            view.setMobile(model.mobileNo);
            view.setMemberEmail(model.emailAddress);
            view.setPassportNo(model.passportNo);
            view.setDriverLicense(model.driverLicenseNo);
            view.setSSSNo(model.SSSNo);
            view.setMemberCivilStatus(model.civilStatus);
            view.setMemberEducationalAttainment(model.memberEducational);
            

            view.setEmploymentStatus(model.employmentStatus);
            view.setIncomeSource(model.incomeSource);
            view.setEmployerName(model.employerName);
            view.setEmployerAddress(model.employerAddress);

            view.setSpouseFirstName(model.spouseFirstName);
            view.setSpouseLastName(model.spouseLastName);
            view.setSpouseMiddleName(model.spouseMiddleName);
            view.setSpouseBirthDate(model.spouseBirthDate);
            view.clearFamilyDataGrid();
            view.setFamilyInfo(model.getFamilyInfo());
            view.setSignatureImage("SpecimenSignatures1//" + model.accountNo + ".jpeg", model.accountNo + ".jpeg");
            view.setSignatureImage2("SpecimenSignatures2//" + model.accountNo + ".jpeg", model.accountNo + ".jpeg");
            isUpdating = true;
            view.enableUpdate();
        }

        public void saveImage(PictureBox signature, string FolderName, string fileName)
        {
            if (!Directory.Exists(FolderName))
            {
                Directory.CreateDirectory(FolderName);
            }

            if (signature.Image != null)
            {
                string path = FolderName + "//" + fileName;
                signature.Image.Save(path, ImageFormat.Jpeg);
            }
            
        }

        public void btnUpdateFamily(object sender, EventArgs e)
        {
            if (this.validateFamily())
            {
                model.familyFName = view.getFamilyFirstName();
                model.familyLName = view.getFamilyLastName();
                model.familyMName = view.getFamilyMiddleName();
                model.familyBirthDate = view.getFamilyBirthDate();
                model.relationship = view.getRelationship();
                model.isDependent = view.getIsDependent();
                model.familyGender = view.getFamilyGender();
                model.updateFamilyInfo();
                view.refreshfieldsfamily();
                view.enableAddFamily();
                view.setFamilyInfo(model.getFamilyInfo());
            }
            
        }

        public void btnAddFamily(object sender, EventArgs e)
        {
            if (this.validateFamily())
            {
                string[] columns = new string[8];
                model.accountNo = view.getAccountNo();
                model.familyLName = view.getFamilyLastName();
                model.familyFName = view.getFamilyFirstName();
                model.familyMName = view.getFamilyMiddleName();
                model.familyBirthDate = view.getFamilyBirthDate();
                model.relationship = view.getRelationship();
                model.isDependent = view.getIsDependent();
                columns[0] = view.getFamilyLastName();
                columns[1] = view.getFamilyFirstName();
                columns[2] = view.getFamilyMiddleName();
                columns[3] = view.getFamilyBirthDate();
                columns[4] = view.getFamilyGender();
                columns[5] = view.getRelationshipItem();
                columns[6] = view.getIsDependentItem();
                columns[7] = view.getRelationship();
                columns[8] = view.getIsDependent();
                view.refreshfieldsfamily();
                view.enableAddFamily();
                if (isUpdating)
                {
                    model.insertFamilyMember();
                    view.setFamilyInfo(model.getFamilyInfo());
                }

                else
                {
                    view.addFamilyDataGridRow(columns);
                }
            }
        }

        public void searchKeyPressed(object sender, EventArgs e)
        {
            if (view.getSearchBy() == "Account No")
            {
                model.accountNo = view.getSearchBox();
                view.setDataGrid(model.searchByAccountNo());
            }

            else if (view.getSearchBy() == "Member Name")
            {
                model.memberLastName = view.getSearchBox();
                view.setDataGrid(model.searchByMemberName());
            }
            
        }

        public void btnSaveClicked(object sender, EventArgs e)
        {
            if (this.validateMemberRegistration())
            {
                //Member Information
                model.memberLastName = view.getMemberLastName();
                model.memberFirstName = view.getMemberFirstName();
                model.memberMiddleName = view.getMemberMiddleName();
                model.memberBlkNoAddress = view.getBlkNo();
                model.memberStreetAddress = view.getStreet();
                model.memberBrgyAddress = view.getBrgy();
                model.memberCityAddress = view.getCity();
                model.accountNo = view.getAccountNo();
                model.membershipDate = view.getMembershipDate();
                model.memberGender = view.getMemberGender();
                model.memberBirthDate = view.getMemberBirthDate();
                model.telephoneNo = view.getTelephoneNo();
                model.mobileNo = view.getMobileNo();
                model.civilStatus = view.getMemberCivilStatus();
                model.emailAddress = view.getMemberEmail();
                model.memberEducational = view.getEducationalAttainment();
                model.passportNo = view.getPassportNo();
                model.SSSNo = view.getSSSNo();
                model.driverLicenseNo = view.getDriverLicense();
                model.profilePicture = Path.GetFileName(view.getProfilePicture());

                //Spouse Information
                model.spouseLastName = view.getSpouseLastName();
                model.spouseFirstName = view.getSpouseFirstName();
                model.spouseMiddleName = view.getSpouseMiddleName();
                model.spouseBirthDate = view.getSpouseBirthDate();

                //Financial Information
                model.employmentStatus = view.getEmploymentStatus();
                model.employerName = view.getEmployerName();
                model.employerAddress = view.getEmployerAddress();
                model.incomeSource = view.getIncomeSource();
                model.userID = ModelUser.userID;
                

                //Insert into database
                model.insertMember();
                MessageBox.Show("Member Successfully Registered!");
                view.saveProfilePicture(model.accountNo);
                view.setAccountNo(model.getNextAccountNo());
                //Inserting Family Information
                this.insertFamilyMembers();
                PictureBox pb = view.getSignatureImage();
                this.saveImage(pb, "SpecimenSignatures1", model.accountNo+".jpeg");
                pb = view.getSignatureImage2();
                this.saveImage(pb, "SpecimenSignatures2", model.accountNo + ".jpeg");
                view.setDataGrid(model.displayMemberInfo());
                view.setSignatureImage("", "");
                view.setSignatureImage2("", "");
                view.enableSave();
                view.refreshfields();
                this.view.setDataGrid(model.displayMemberInfo());
            }
        }

        public void insertFamilyMembers()
        {
            DataGridView dg = view.getFamilyDataGrid();
            int totalRow = dg.Rows.Count;
            int totalColumns = dg.Columns.Count;

            for (int x = 0; x < totalRow; x++ )
            {
                model.familyLName = dg.Rows[x].Cells["LastName"].Value.ToString();
                model.familyFName = dg.Rows[x].Cells["FirstName"].Value.ToString();
                model.familyMName = dg.Rows[x].Cells["MiddleName"].Value.ToString();
                model.familyBirthDate = dg.Rows[x].Cells["BirthDate"].Value.ToString();
                model.relationship = dg.Rows[x].Cells["RelationshipIndex"].Value.ToString();
                model.isDependent = (dg.Rows[x].Cells["IsDependent"].Value.ToString()== "Yes")?"1":"0";
                model.insertFamilyMember();
            }
        }


        public bool validateMemberRegistration()
        {
            bool check = false;
            
            if (Validator.isAlphanumeric(view.getMemberFirstName()) && view.getMemberFirstName().Trim().Length != 0)
            {
                if (Validator.isAlphanumeric(view.getMemberLastName()) && view.getMemberLastName().Trim().Length != 0)
                {
                    if (Validator.isAlphanumeric(view.getBlkNo()) && view.getBlkNo().Trim().Length != 0)
                    {
                        //if (Validator.isAlphanumeric(view.getMemberBirthPlace()) && view.getMemberBirthPlace().Trim().Length != 0)
                        //{
                            if (view.getTelephoneNo().Trim().Length == 8)
                            {
                                if (!Validator.isAlphanumeric(view.getMobileNo()) && view.getMobileNo().Trim().Length == 11)
                                {
                                    if (Validator.isValidEmail(view.getMemberEmail()))
                                    {
                                        if (this.validateSpouse())
                                        {
                                            if (view.getSignatureImage().Image != null && view.getSignatureImage2().Image != null)
                                            //if (view.getSignatureImage().ImageLocation.Length != 0 && view.getSignatureImage2().ImageLocation.Length != 0)
                                            {
                                                check = true;
                                            }

                                            else
                                            {
                                                MessageBox.Show("Please upload the signatures of the member.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            }
                                        }
                                    }

                                    else
                                    {
                                        MessageBox.Show("Invalid value for email address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }

                                else
                                {
                                    MessageBox.Show("Invalid value for the member's mobile number. Please make sure that the mobile number is 11 digits.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }

                            else
                            {
                                MessageBox.Show("Invalid value for the member's telephone number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        //}

                        //else
                        //{
                            //MessageBox.Show("Invalid value for the member's birth place.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //}
                    }

                    else
                    {
                        MessageBox.Show("Invalid value for the member's address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                else
                {
                    MessageBox.Show("Invalid value for the member's last name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else
            {
                MessageBox.Show("Invalid value for the member's first name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return check;
        }

        private bool validateSpouse()
        {
            bool check = false;
            if (view.getMemberCivilStatus() == "Single")
            {
                check = true;
            }

            else
            {
                if (Validator.isAlphanumeric(view.getSpouseFirstName()) && view.getSpouseFirstName().Trim().Length != 0)
                {
                    if (Validator.isAlphanumeric(view.getSpouseMiddleName()) && view.getSpouseMiddleName().Trim().Length != 0)
                    {
                        if (Validator.isAlphanumeric(view.getSpouseLastName()) && view.getSpouseLastName().Trim().Length != 0)
                        {
                            check = true;
                        }

                        else
                        {
                            MessageBox.Show("Invalid value for spouse's last name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                    else
                    {
                        MessageBox.Show("Invalid value for spouse's middle name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                else
                {
                    MessageBox.Show("Invalid value for spouse's first name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return check;
        }

        public bool validateFamily()
        {
            bool check = false;
            if (Validator.isAlphanumeric(view.getFamilyFirstName()) && view.getFamilyFirstName().Trim().Length != 0)
            {
                if (Validator.isAlphanumeric(view.getFamilyLastName()) && view.getFamilyLastName().Trim().Length != 0)
                {
                    check = true;
                }

                else
                {
                    MessageBox.Show("Invalid value for family member's last name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else
            {
                MessageBox.Show("Invalid value for family member's first name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return check;
        }
    }
}
