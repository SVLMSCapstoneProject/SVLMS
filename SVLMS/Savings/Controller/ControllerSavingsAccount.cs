using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using SVLMS.Savings.Model;
using SVLMS.Savings.View;
using System.IO;
using System.Drawing.Imaging;

namespace SVLMS.Savings.Controller
{
    class ControllerSavingsAccount
    {
        ModelSavingsAccount model;
        TransactionCreateSavingsAccountView view;

        //Popup for Family Member
        TransactionFamilyMember familyMember;
        public string familyID { get; set; }
        public string isFamily { get; set; }

        public ControllerSavingsAccount(ModelSavingsAccount model, TransactionCreateSavingsAccountView view)
        {
            this.model = model;
            this.view = view;
            this.RefreshFields();
            this.view.Show();
            

            //Add Events
            this.view.setBtnOpenAccountEvent(btnOpenAccount);
            this.view.setCboSavingsChange(cboSavingsIndexChange);
            this.view.setTextSearchChange(txtSearchKeyPressed);
            this.view.setDataGridEvent(dataGridClicked);
            this.view.setBtnPlusEvent(btnPlusClicked);
            this.view.dgAccountHoldersClickedEvent(dataGridAccountHolderClicked);
            this.view.setCboSavingsJointSelectedIndex(cboSavingsJointClicked);
            this.view.setBtnAddAccountHolderEvent(btnAddAccountHolderClicked);
            this.view.setBtnRemoveAccountHolderEvent(btnRemoveAccountHolderClicked);
            this.view.setRbtnFamilyClick(rbtnFamilyClick);
            this.view.setRbtnMemberClick(rbtnMemberClick);
            this.view.setBtnClearEvent(btnClearEvent);
            this.view.setBtnUploadJointEvent(btnUploadClickedJoint);
            this.view.setBtnUploadJoint2Event(btnUploadClickedJoint2);
            this.view.setBtnUpdateAccountHolderEvent(btnUpdateAccountHolderClicked);
        }

        public void btnUpdateAccountHolderClicked(object sender, EventArgs e)
        {
            if (isFamily == "1")
            {
                model.signatureImage = view.getSavingsAccountNoJoint() + "-" + model.familyID + ".jpeg";
            }

            if (isFamily == "0")
            {
                model.signatureImage = view.getSavingsAccountNoJoint() + "-" + model.accountNo + ".jpeg";
            }
            PictureBox pb = view.getSignatureImageJoint();
            this.saveImage(pb, "SpecimenSignatures1", model.signatureImage);
            pb = view.getSignatureImageJoint2();
            this.saveImage(pb, "SpecimenSignatures2", model.signatureImage);
            MessageBox.Show("Signatures successfully updated.");
            this.RefreshFields();
        }

        public void btnAddAccountHolderClicked(object sender, EventArgs e)
        {
            model.savingsAccountID = view.getSavingsAccountNoJoint();

            if (isFamily == "1")
            {
                model.signatureImage = view.getSavingsAccountNoJoint() + "-" + model.familyID+".jpeg";
            }

            if (isFamily == "0")
            {
                model.signatureImage = model.accountNo + ".jpeg";
            }

            if (this.validateAddAccountHolder())
            {
                //Add Account Holder
                model.addAccountHolder(isFamily);
                PictureBox pb = view.getSignatureImageJoint();
                this.saveImage(pb, "SpecimenSignatures1", model.signatureImage);
                pb = view.getSignatureImageJoint2();
                this.saveImage(pb, "SpecimenSignatures2", model.signatureImage);
                MessageBox.Show("Account Holder has been added successfully.");

                //Clearing fields
                isFamily = view.getIsFamily();
                if (view.getIsFamily() == "1")
                {
                    view.setDatagridAccountHolders(model.getFamilyAccountHolders(),isFamily);
                }

                else if (view.getIsFamily() == "0")
                {

                    model.accountNo = view.getAccountNo();
                    view.setDatagridAccountHolders(model.getMemberAccountHolders(), isFamily);
                }
                view.setAccountHolder("");
                view.setSignatureImageJoint("", "");
                view.setSignatureImageJoint2("", "");
            }
        }

        public void btnRemoveAccountHolderClicked(object sender, EventArgs e)
        {
            model.removeAccountHolder(isFamily);
            MessageBox.Show("Joint account holder successfully removed.");
            this.RefreshFields();
        }

        public void rbtnMemberClick(object sender, EventArgs e)
        {
            model.accountNo = view.getAccountNo();
            view.setDatagridAccountHolders(model.getMemberAccountHolders(),"0");
        }

        public void rbtnFamilyClick(object sender, EventArgs e)
        {
            view.setDatagridAccountHolders(model.getFamilyAccountHolders(),"1");
        }

        public void cboSavingsJointClicked(object sender, EventArgs e)
        {
            this.setManageAccountHoldersFields();
        }

        private void setManageAccountHoldersFields()
        {
            model.savingsAccountID = view.getCboSavingsJoint();
            view.clearDataGridJoint();
            view.setSavingsAccountNoJoint(model.savingsAccountID);
            view.setIsMemberRbtn("1");
            view.setDatagridAccountHolders(model.getMemberAccountHolders(), "0");
            if (model.noAccountHolders() > 1)
            {
                view.enableAccountHolder();
            }

            else
            {
                view.disableAccountHolder();
                view.setAccountHolder("");
            }
            view.setPrimaryAccountHolder(view.getMemberName());
            view.disableBtnUpdate();
            view.setAccountHolder("");
            view.setSignatureImageJoint("", "");
            view.setSignatureImageJoint2("", "");
            view.disableBtnRemoveAccountHolder();
            //view.setSignatureImageJoint("SpecimenSignatures1//" + model.getSignatureImage("0"), model.getSignatureImage("0"));
            //view.setSignatureImageJoint2("SpecimenSignatures2//" + model.getSignatureImage("0"), model.getSignatureImage("0"));
            
        }

        public void dataGridAccountHolderClicked(object sender, DataGridViewCellEventArgs e)
        {
            string isPrimary = "";
            view.disableBtnAddAccountHolder();
            view.enableBtnRemoveAccountHolder();
            view.enableBtnUpdate();
            DataGridView dg = view.getDatagridAccountHolders();
            int row = dg.CurrentCell.RowIndex;
            this.isFamily = view.getIsFamily();
            model.savingsAccountID = view.getSavingsAccountNoJoint();
            if (isFamily == "1")
            {
                model.familyID = dg.Rows[row].Cells[0].Value.ToString();
                view.setAccountHolder(dg.Rows[row].Cells[1].Value.ToString());
                view.enableUploadJoint();
            }

            else
            {
                model.accountNo = dg.Rows[row].Cells[0].Value.ToString();
                view.disableBtnUpdate();
                view.disableBtnAddAccountHolder();
                view.disableBtnRemoveAccountHolder();
                view.disableUploadJoint();
                isPrimary = dg.Rows[row].Cells[3].Value.ToString();
                if (isPrimary == "0")
                {
                    view.setAccountHolder(dg.Rows[row].Cells[1].Value.ToString());
                    view.enableBtnAddAccountHolder();
                    view.enableBtnRemoveAccountHolder();
                }
            }
            view.setSignatureImageJoint("SpecimenSignatures1//"+model.getSignatureImage(isFamily),model.getSignatureImage(isFamily));
            view.setSignatureImageJoint2("SpecimenSignatures2//" + model.getSignatureImage(isFamily), model.getSignatureImage(isFamily));
            view.disablePlusButton();
        }

        public void btnPlusClicked(object sender, EventArgs e)
        {
            TransactionFamilyMember t = new TransactionFamilyMember(view.getAccountNo());
            this.familyMember = t;
            this.familyMember.chooseFamily += new EventHandler(btnFamilySelect);
            this.familyMember.savingsAccountNo = view.getSavingsAccountNoJoint();
            this.familyMember.setDataGrid("1");
            this.familyMember.ShowDialog();
        }

        public void btnFamilySelect(object sender, EventArgs e)
        {
            familyMember.Close();
            DataGridView dg = familyMember.getDataGrid();
            int row = dg.CurrentCell.RowIndex;
            this.isFamily = familyMember.getIsFamily();
            if (familyMember.getIsFamily() == "1")
            {
                model.familyID = dg.Rows[row].Cells[0].Value.ToString();
                view.setAccountHolder(dg.Rows[row].Cells[1].Value.ToString());
                view.enableUploadJoint();
            }

            else
            {
                model.accountNo = dg.Rows[row].Cells[0].Value.ToString();
                view.setAccountHolder(dg.Rows[row].Cells[1].Value.ToString());
                view.disableUploadJoint();
                view.setSignatureImageJoint("SpecimenSignatures1//" + model.accountNo + ".jpeg", model.accountNo + ".jpeg");
                view.setSignatureImageJoint2("SpecimenSignatures2//" + model.accountNo + ".jpeg", model.accountNo + ".jpeg");
            }
        }

        public void btnUploadClickedJoint(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "JPG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png|GIF Files (*.gif)|*.gif";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                view.setSignatureImageJoint(ofd.FileName, ofd.SafeFileName);
            }
        }

        public void btnUploadClickedJoint2(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "JPG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png|GIF Files (*.gif)|*.gif";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                view.setSignatureImageJoint2(ofd.FileName, ofd.SafeFileName);
            }
        }

        public void dataGridClicked(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dg = view.getDataGrid();
            int row = dg.CurrentCell.RowIndex;
            view.clearDataGridJoint();
            view.clearCboJoint();
            view.setSavingsAccountNoJoint("");
            view.setPrimaryAccountHolder("");
            
            //Create new Account tab
            view.setAccountNo(dg.Rows[row].Cells[0].Value.ToString());
            view.setMemberName(dg.Rows[row].Cells[1].Value.ToString());
            model.accountNo = dg.Rows[row].Cells[0].Value.ToString();
            view.setCboSavingsType(model.getSavingsType());            
            view.disableAccountHolder();

            //Manage Joint Accounts tab
            model.accountNo = dg.Rows[row].Cells[0].Value.ToString();
            view.setCboSavingsJoint(model.getSavingsAccounts());
            model.savingsAccountID = view.getCboSavingsJoint();

            this.setManageAccountHoldersFields();
        }

        public void btnOpenAccount(object sender, EventArgs e)
        {
            if (this.validateOpenAccount())
            {
                model.accountNo = view.getAccountNo();
                model.savingsTypeID = view.getCboSavingsType().Row["savingsTypeID"].ToString();
                model.initialDeposit = view.getInitialDeposit();
                model.userID = ModelUser.userID;
                model.signatureImage = view.getAccountNo() + ".jpeg";

                //Create Savings Account
                model.createSavingsAccount();
                MessageBox.Show("Savings Account Created.");
                model.accountNo = view.getAccountNo();
                view.setCboSavingsJoint(model.getSavingsAccounts());
                this.RefreshFields();
            }
        }

        public bool validateAddAccountHolder()
        {
            bool check = false;
            PictureBox pb1 = view.getSignatureImageJoint();
            PictureBox pb2 = view.getSignatureImageJoint2();
            if (view.getAccountHolder().Length != 0)
            {
                if (pb1.Image != null && pb2.Image != null)
                {
                    model.savingsAccountID = view.getSavingsAccountNoJoint();
                    int noCurrentHolders = model.getNoOfAccountHolders() + 1;
                    int noAccountHolders = Convert.ToInt32(model.noAccountHolders());

                    if (noCurrentHolders <= noAccountHolders)
                    {
                        check = true;
                    }

                    else
                    {
                        MessageBox.Show("The maximum number of account holders for this account is "+noAccountHolders+".", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                else
                {
                    MessageBox.Show("To add an account holder, please upload the signatures.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else
            {
                MessageBox.Show("Please choose a secondary holder first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return check;
        }

        public bool validateOpenAccount()
        {
            bool check = false;
            if (view.getAccountNo().Length != 0)
            {
                if (!Validator.isAlphanumeric(view.getInitialDeposit()))
                {
                    ModelSavingsType m = new ModelSavingsType();
                    m.savingsTypeID = view.getCboSavingsType().Row["savingsTypeID"].ToString();
                    m.searchSavingsType();
                    double maintainingBalance = Convert.ToDouble(m.maintainingBalance);
                    double amount = Convert.ToDouble(view.getInitialDeposit());
                    if (amount >= maintainingBalance)
                    {
                        check = true;
                        if (view.getInitialDeposit().Length < 16)
                        {
                            check = true;
                        }

                        else
                        {
                            MessageBox.Show("The number must have less than 15 digits.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                    else
                    {
                        MessageBox.Show("The amount required to open the account is P "+Validator.amountFormatter(m.maintainingBalance)+".", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                else
                {
                    MessageBox.Show("Invalid value for initial deposit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else
            {
                MessageBox.Show("Please choose a member.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return check;
        }

        public void cboSavingsIndexChange(object sender, EventArgs e)
        {
            DataRowView drv = view.getCboSavingsType();
            DataRow dr = drv.Row;
            //view.enableAccountHolder();
        }

        public void txtSearchKeyPressed(object sender, EventArgs e)
        {
            ModelMember m = new ModelMember();
            if (view.getCboSearchBy() == "Account No")
            {
                m.accountNo = view.getSearchValue();
                view.setDataGrid(m.searchByAccountNo());
            }

            else if (view.getCboSearchBy() == "Member Name")
            {
                m.memberLastName = view.getSearchValue();
                view.setDataGrid(m.searchByMemberName());
            }
        }

        public void btnClearEvent(object sender, EventArgs e)
        {
            view.setSignatureImageJoint("", "");
            view.setSignatureImageJoint2("", "");
            view.setAccountHolder("");
            view.disableBtnRemoveAccountHolder();
            view.disableBtnUpdate();
            view.enableAccountHolder();
            view.enablePlusButton();
            view.enableUploadJoint();
            this.setManageAccountHoldersFields();
        }

        public void saveImage(PictureBox signature, string FolderName, string fileName)
        {
            if (!Directory.Exists(FolderName))
            {
                Directory.CreateDirectory(FolderName);
            }
            string path = FolderName + "//" + fileName;
            signature.Image.Save(path,ImageFormat.Jpeg);
        }

        public void RefreshFields()
        {
            view.setDataGrid(new ModelMember().displayMemberInfo());
            view.setAccountHolder("");
            view.setInitialDeposit("");
            view.setCboSavingsType(null);
            view.setSavingsAccountNo(model.getNextSavingsAccountNo());

            //Clear
            view.enableBtnAddAccountHolder();
            view.disableBtnRemoveAccountHolder();
            view.disableBtnRemoveAccountHolder();
            view.disableAccountHolder();
            view.setAccountHolder("");
            view.setPrimaryAccountHolder("");
            view.setSavingsAccountNoJoint("");
            view.clearDataGridJoint();
            view.setSignatureImageJoint("", "");
            view.setSignatureImageJoint2("", "");
            this.setManageAccountHoldersFields();
            model.accountNo = "";
            model.familyID = "";
            model.savingsAccountID = "";
        }
    }
}
