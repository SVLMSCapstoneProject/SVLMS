﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SVLMS.Loaning.Model;
using SVLMS.Loaning.View;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SVLMS.Loaning.Controller
{
    class ControllerMemberType
    {
        ModelMemberType model;
        MaintenanceMemberType view;
        //For Validation
        bool update;
        string updateTypeName = "";

        public ControllerMemberType(ModelMemberType model, MaintenanceMemberType view)
        {
            this.view = view;
            this.model = model;
            view.Show();
            view.setBtnSaveEvent(btnSaveClicked);
            view.setDataGridEvent(dgCellClicked);
            view.setBtnClearEvent(btnClearClicked);
            view.setBtnUpdateEvent(btnUpdateClicked);
            view.setCboFilterEvent(CboFilterEvent);
            view.setTxtSearchEvent(TextSearchTextChanged);
            view.settxtTypeName(txtTypeNameLeave);
            this.refreshFields();
        }

        public void txtTypeNameLeave(object sender, EventArgs e)
        {
            int check = MemberTypeName();
            if (update == true)
            {

                int check1 = MemberTypeID();
                if (check1 == 1)
                {
                    view.unTypeName();
                }
                else
                {
                    if (check == 1)
                    {
                        view.errTypeName();
                        MessageBox.Show("There's an existing Member Type Name");
                    }
                    else
                        view.unTypeName();
                }
            }
            else
            {
                if (check == 1)
                {
                    view.errTypeName();
                    MessageBox.Show("There's an existing Member Type Name");
                }
                else
                    view.unTypeName();
            }
        }

        public void CboFilterEvent(object sender, EventArgs e)
        {
            view.setDataGrid(model.searchMemberType(view.getCboFilter(), view.getTextSearch()));
        }

        public void TextSearchTextChanged(object sender, EventArgs e)
        {
            view.setDataGrid(model.searchMemberType(view.getCboFilter(), view.getTextSearch()));
        }

        public void btnUpdateClicked(object sender, EventArgs e)
        {
            int check = MemberTypeID();
            int check1 = MemberTypeName();
            int validate = Validate();

            model.typeID = view.getTypeID();
            model.typeName = view.getTypeName();
            model.minimumShare = view.getMinimumShare();
            model.hasCertificate = view.getHasCertificate();
            model.status = view.getStatus();

            if (validate == 3)
            {
                if (check == 1)
                {
                    view.unTypeName();
                    bool perform = PerformActionCertification();

                    if (perform == true)
                    {
                        model.updateMemberType();
                        MessageBox.Show("The Record is Successfully Updated");
                        this.refreshFields();
                    }
                }
                else
                {
                    if (check1 == 1)
                    {
                        view.errTypeName();
                        MessageBox.Show("There's an existing Member Type Name");
                    }
                    else
                    {
                        bool perform = PerformActionCertification();

                        if (perform == true)
                        {
                            model.updateMemberType();
                            MessageBox.Show("The Record is Successfully Updated");
                            this.refreshFields();
                        }
                    }
                }
            }
            else
            {
                if (check == 1)
                {
                    view.errTypeName();
                }
                else
                {
                    if (check1 == 1)
                    {
                        view.errTypeName();
                    }
                }
                MessageBox.Show("Invalid Input/s", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void btnSaveClicked(object sender, EventArgs e)
        {
            int check = MemberTypeName();
            int validate = Validate();
            
            model.typeName = view.getTypeName();
            model.minimumShare = view.getMinimumShare();
            model.hasCertificate = view.getHasCertificate();
            model.status = view.getStatus();
            
            if (validate == 3)
            {
                if (check == 1)
                {
                    view.errTypeName();
                    MessageBox.Show("There's an existing Member Type Name");
                }
                else
                {
                    view.unTypeName();
                    bool perform = PerformActionCertification();

                    if (perform == true)
                    {
                        model.insertMemberType();
                        MessageBox.Show("The Record is Successfully Inserted");
                        this.refreshFields();
                    }
                }
            }
            else
            {
                if (check == 1)
                {
                    view.errTypeName();
                }
                MessageBox.Show("Invalid Input/s", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void btnClearClicked(object sender, EventArgs e)
        {
            this.refreshFields();
        }

        public void dgCellClicked(object sender, EventArgs e)
        {
            update = true;
            view.unTypeName();
            view.unStatus();
            view.unMinimumShare();
            view.unCertificate();

            DataGridView dg = view.getDataGrid();
            int row = dg.CurrentCell.RowIndex;
            SqlDataReader reader = model.getMemberTypeRecord(dg.Rows[row].Cells[0].Value.ToString());
            model.typeID = dg.Rows[row].Cells[0].Value.ToString();
            if (reader.Read())
            {
                view.setTypeID(model.typeID);
                view.setTypeName(reader[1].ToString());
                view.setMinimumShare(reader[2].ToString());
                view.setHasCertificate(reader[3].ToString());
                view.setStatus(reader[4].ToString());
                updateTypeName = reader[1].ToString();
            }
            view.enableUpdate();
            view.disableSave();
        }

        public void refreshFields()
        {
            view.setDataGrid(model.getMemberTypeInfo());
            view.setTypeName("");
            view.setMinimumShare("");
            //view.setTypeID(model.getNextID());
            view.disableUpdate();
            view.enableSave();
            view.clearCheckBox();
            view.clearRadioButton();
            view.unTypeName();
            view.unStatus();
            view.unMinimumShare();
            view.unCertificate();
            update = false;
        }

        public bool PerformActionCertification()
        {
            int certificate = view.certificate();
            bool perform = false;

            if (certificate == 1)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure of not having a certificate?", "Has Certificate", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                if (dialogResult == DialogResult.Yes)
                {
                    perform = true;
                }
                else if (dialogResult == DialogResult.No)
                {
                    view.errCertificate();
                }
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure of having a certificate?", "Has Certificate", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                if (dialogResult == DialogResult.Yes)
                {
                    perform = true;
                }
                else if (dialogResult == DialogResult.No)
                {
                    view.errCertificate();
                }
            }
            return perform;
        }

        public int Validate()
        {
            model.typeName = view.getTypeName();
            model.minimumShare = view.getMinimumShare();
            model.hasCertificate = view.getHasCertificate();
            model.status = view.getStatus();

            string special = "!@#$%^&*(){}/;:><+=_?.,1234567890";
            bool pass = true;
            bool error = false;
            double num;
            int status = view.status();
            int correct = 0;
            //typeName------------------------
            if (string.IsNullOrWhiteSpace(model.typeName))
            {
                view.errTypeName();
            }
            else
            {
                    char[] spec = special.ToCharArray();
                    char[] str = model.typeName.ToCharArray();
                    for (int x = 0; x < special.Length; x++)
                    {
                        for (int i = 0; i < str.Length; i++)
                        {
                            if (str[i] == special[x])
                            {
                                view.errTypeName();
                                pass = false;
                                error = true;
                                x = special.Length;
                                i = str.Length;
                            }
                        }
                    }

                    if (pass)
                    {
                        for (int i = 0; i < str.Length - 1; i++)
                        {
                            if (char.IsLetter(str[i]) || str[i] == ' ' || str[i] == '-' || str[i] == '\'')
                            {
                                view.unTypeName();
                                error = false;
                            }
                            else
                            {
                                view.errTypeName();
                                i = model.typeName.Length;
                                error = true;
                            }
                        }
                    }
                if (error == false)
                {
                    view.unTypeName();
                    correct++;
                }
            }
            //minimumShare-------------------------
            if (string.IsNullOrWhiteSpace(model.minimumShare))
            {
                view.errMinimumshare();
            }
            else
            {
                if (double.TryParse(model.minimumShare, out num))
                {
                    if (Convert.ToDouble(model.minimumShare) < 0)
                    {
                        view.errMinimumshare();
                    }
                    else
                    {
                        view.unMinimumShare();
                        correct++;
                    }
                }
                else
                {
                    view.errMinimumshare();
                }
            }
            //status-----------------------------
            if (status == 1)
            {
                view.errStatus();
            }
            else
            {
                view.unStatus();
                correct++;
            }

            return correct;
        }

        public int MemberTypeName()
        {
            model.typeName = view.getMemberTypeName();
            model.MemberTypeName();

            return Convert.ToInt16(model.memberTypeName);
        }

        public int MemberTypeID()
        {
            model.typeID = view.getTypeID();
            model.updateTypeName = view.getMemberTypeName();

            model.MemberTypeIDUpdate();

            return Convert.ToInt16(model.memberTypeID);
        }
    }
}
