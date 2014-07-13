namespace SVLMS.Loaning.View
{
    partial class MaintenanceLoanTypeView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtLoanEligibility = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.LoanEntitlementPanel = new System.Windows.Forms.Panel();
            this.chkNoEntitlement = new System.Windows.Forms.CheckBox();
            this.collateraPanel = new System.Windows.Forms.Panel();
            this.rbtnNo = new System.Windows.Forms.RadioButton();
            this.rbtnYes = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.txtLoanEntitlement = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.listUnselected = new System.Windows.Forms.CheckedListBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.comakerPanel = new System.Windows.Forms.Panel();
            this.rbtnCoMakerYes = new System.Windows.Forms.RadioButton();
            this.rbtnCoMakerNo = new System.Windows.Forms.RadioButton();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtMaxAmount = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtLoanName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMinAmount = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMaxTerm = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cboFilter = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgLoantype = new System.Windows.Forms.DataGridView();
            this.statusPanel = new System.Windows.Forms.Panel();
            this.rbtnInactive = new System.Windows.Forms.RadioButton();
            this.rbtnActive = new System.Windows.Forms.RadioButton();
            this.label16 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.LoanEntitlementPanel.SuspendLayout();
            this.collateraPanel.SuspendLayout();
            this.comakerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgLoantype)).BeginInit();
            this.statusPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.statusPanel);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.txtLoanEligibility);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.LoanEntitlementPanel);
            this.panel1.Controls.Add(this.collateraPanel);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtLoanEntitlement);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.listUnselected);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.comakerPanel);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.txtMaxAmount);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.txtLoanName);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtMinAmount);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtMaxTerm);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.cboFilter);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dgLoantype);
            this.panel1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(782, 450);
            this.panel1.TabIndex = 0;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(24, 348);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(117, 16);
            this.label13.TabIndex = 156;
            this.label13.Text = "Renewal Eligibility:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(358, 350);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(191, 16);
            this.label11.TabIndex = 155;
            this.label11.Text = "% paid to apply for another loan";
            // 
            // txtLoanEligibility
            // 
            this.txtLoanEligibility.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoanEligibility.Location = new System.Drawing.Point(289, 346);
            this.txtLoanEligibility.MaxLength = 4;
            this.txtLoanEligibility.Name = "txtLoanEligibility";
            this.txtLoanEligibility.Size = new System.Drawing.Size(64, 22);
            this.txtLoanEligibility.TabIndex = 154;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(175, 349);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(115, 16);
            this.label10.TabIndex = 153;
            this.label10.Text = "This loan must be ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(565, 232);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(20, 16);
            this.label9.TabIndex = 152;
            this.label9.Text = "%";
            // 
            // LoanEntitlementPanel
            // 
            this.LoanEntitlementPanel.Controls.Add(this.chkNoEntitlement);
            this.LoanEntitlementPanel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoanEntitlementPanel.Location = new System.Drawing.Point(449, 257);
            this.LoanEntitlementPanel.Name = "LoanEntitlementPanel";
            this.LoanEntitlementPanel.Size = new System.Drawing.Size(153, 26);
            this.LoanEntitlementPanel.TabIndex = 151;
            // 
            // chkNoEntitlement
            // 
            this.chkNoEntitlement.AutoSize = true;
            this.chkNoEntitlement.Location = new System.Drawing.Point(3, 3);
            this.chkNoEntitlement.Name = "chkNoEntitlement";
            this.chkNoEntitlement.Size = new System.Drawing.Size(145, 20);
            this.chkNoEntitlement.TabIndex = 144;
            this.chkNoEntitlement.Text = "No Loan Entitlement";
            this.chkNoEntitlement.UseVisualStyleBackColor = true;
            // 
            // collateraPanel
            // 
            this.collateraPanel.Controls.Add(this.rbtnNo);
            this.collateraPanel.Controls.Add(this.rbtnYes);
            this.collateraPanel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.collateraPanel.Location = new System.Drawing.Point(460, 317);
            this.collateraPanel.Name = "collateraPanel";
            this.collateraPanel.Size = new System.Drawing.Size(131, 24);
            this.collateraPanel.TabIndex = 149;
            // 
            // rbtnNo
            // 
            this.rbtnNo.AutoSize = true;
            this.rbtnNo.Location = new System.Drawing.Point(67, 3);
            this.rbtnNo.Name = "rbtnNo";
            this.rbtnNo.Size = new System.Drawing.Size(42, 20);
            this.rbtnNo.TabIndex = 162;
            this.rbtnNo.TabStop = true;
            this.rbtnNo.Text = "No";
            this.rbtnNo.UseVisualStyleBackColor = true;
            // 
            // rbtnYes
            // 
            this.rbtnYes.AutoSize = true;
            this.rbtnYes.Location = new System.Drawing.Point(10, 3);
            this.rbtnYes.Name = "rbtnYes";
            this.rbtnYes.Size = new System.Drawing.Size(48, 20);
            this.rbtnYes.TabIndex = 162;
            this.rbtnYes.TabStop = true;
            this.rbtnYes.Text = "Yes";
            this.rbtnYes.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(349, 323);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 16);
            this.label8.TabIndex = 150;
            this.label8.Text = "Collateralized:";
            // 
            // txtLoanEntitlement
            // 
            this.txtLoanEntitlement.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoanEntitlement.Location = new System.Drawing.Point(460, 230);
            this.txtLoanEntitlement.MaxLength = 8;
            this.txtLoanEntitlement.Name = "txtLoanEntitlement";
            this.txtLoanEntitlement.Size = new System.Drawing.Size(99, 22);
            this.txtLoanEntitlement.TabIndex = 148;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(348, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 16);
            this.label5.TabIndex = 147;
            this.label5.Text = "Loan Entitlement:";
            // 
            // listUnselected
            // 
            this.listUnselected.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listUnselected.FormattingEnabled = true;
            this.listUnselected.Location = new System.Drawing.Point(630, 259);
            this.listUnselected.Name = "listUnselected";
            this.listUnselected.Size = new System.Drawing.Size(130, 89);
            this.listUnselected.TabIndex = 113;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(433, 412);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(79, 23);
            this.btnClear.TabIndex = 118;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // comakerPanel
            // 
            this.comakerPanel.Controls.Add(this.rbtnCoMakerYes);
            this.comakerPanel.Controls.Add(this.rbtnCoMakerNo);
            this.comakerPanel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comakerPanel.Location = new System.Drawing.Point(460, 289);
            this.comakerPanel.Name = "comakerPanel";
            this.comakerPanel.Size = new System.Drawing.Size(130, 28);
            this.comakerPanel.TabIndex = 104;
            // 
            // rbtnCoMakerYes
            // 
            this.rbtnCoMakerYes.AutoSize = true;
            this.rbtnCoMakerYes.Location = new System.Drawing.Point(10, 2);
            this.rbtnCoMakerYes.Name = "rbtnCoMakerYes";
            this.rbtnCoMakerYes.Size = new System.Drawing.Size(48, 20);
            this.rbtnCoMakerYes.TabIndex = 46;
            this.rbtnCoMakerYes.TabStop = true;
            this.rbtnCoMakerYes.Text = "Yes";
            this.rbtnCoMakerYes.UseVisualStyleBackColor = true;
            // 
            // rbtnCoMakerNo
            // 
            this.rbtnCoMakerNo.AutoSize = true;
            this.rbtnCoMakerNo.Location = new System.Drawing.Point(67, 2);
            this.rbtnCoMakerNo.Name = "rbtnCoMakerNo";
            this.rbtnCoMakerNo.Size = new System.Drawing.Size(42, 20);
            this.rbtnCoMakerNo.TabIndex = 45;
            this.rbtnCoMakerNo.TabStop = true;
            this.rbtnCoMakerNo.Text = "No";
            this.rbtnCoMakerNo.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(350, 412);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 117;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(269, 412);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 115;
            this.btnSave.Text = "Add";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // txtMaxAmount
            // 
            this.txtMaxAmount.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaxAmount.Location = new System.Drawing.Point(178, 287);
            this.txtMaxAmount.MaxLength = 8;
            this.txtMaxAmount.Name = "txtMaxAmount";
            this.txtMaxAmount.Size = new System.Drawing.Size(129, 22);
            this.txtMaxAmount.TabIndex = 99;
            this.txtMaxAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaxAmount_KeyPress);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(23, 288);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(117, 16);
            this.label15.TabIndex = 127;
            this.label15.Text = "Maximum Amount:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(617, 235);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(87, 16);
            this.label14.TabIndex = 126;
            this.label14.Text = "Applicable to:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(348, 293);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(99, 16);
            this.label12.TabIndex = 125;
            this.label12.Text = "With Co-Maker:";
            // 
            // txtLoanName
            // 
            this.txtLoanName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoanName.Location = new System.Drawing.Point(178, 233);
            this.txtLoanName.MaxLength = 50;
            this.txtLoanName.Name = "txtLoanName";
            this.txtLoanName.Size = new System.Drawing.Size(129, 22);
            this.txtLoanName.TabIndex = 97;
            this.txtLoanName.Validating += new System.ComponentModel.CancelEventHandler(this.txtLoanName_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 16);
            this.label4.TabIndex = 108;
            this.label4.Text = "Loan Name:";
            // 
            // txtMinAmount
            // 
            this.txtMinAmount.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMinAmount.Location = new System.Drawing.Point(178, 260);
            this.txtMinAmount.MaxLength = 8;
            this.txtMinAmount.Name = "txtMinAmount";
            this.txtMinAmount.Size = new System.Drawing.Size(129, 22);
            this.txtMinAmount.TabIndex = 98;
            this.txtMinAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMinAmount_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 259);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 16);
            this.label6.TabIndex = 114;
            this.label6.Text = "Minimum Amount:";
            // 
            // txtMaxTerm
            // 
            this.txtMaxTerm.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaxTerm.Location = new System.Drawing.Point(178, 314);
            this.txtMaxTerm.MaxLength = 4;
            this.txtMaxTerm.Name = "txtMaxTerm";
            this.txtMaxTerm.Size = new System.Drawing.Size(129, 22);
            this.txtMaxTerm.TabIndex = 100;
            this.txtMaxTerm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaxTerm_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(23, 315);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(156, 16);
            this.label7.TabIndex = 116;
            this.label7.Text = "Maximum Term (Months):";
            // 
            // cboFilter
            // 
            this.cboFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFilter.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboFilter.FormattingEnabled = true;
            this.cboFilter.Items.AddRange(new object[] {
            "No Filter",
            "Active",
            "Inactive"});
            this.cboFilter.Location = new System.Drawing.Point(83, 50);
            this.cboFilter.Name = "cboFilter";
            this.cboFilter.Size = new System.Drawing.Size(132, 24);
            this.cboFilter.TabIndex = 95;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 16);
            this.label2.TabIndex = 92;
            this.label2.Text = "Filter:";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(221, 50);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(132, 22);
            this.txtSearch.TabIndex = 93;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 29);
            this.label1.TabIndex = 91;
            this.label1.Text = "Maintenance: Loan Type";
            // 
            // dgLoantype
            // 
            this.dgLoantype.AllowUserToAddRows = false;
            this.dgLoantype.AllowUserToDeleteRows = false;
            this.dgLoantype.AllowUserToOrderColumns = true;
            this.dgLoantype.AllowUserToResizeColumns = false;
            this.dgLoantype.AllowUserToResizeRows = false;
            this.dgLoantype.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgLoantype.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgLoantype.Location = new System.Drawing.Point(17, 78);
            this.dgLoantype.Name = "dgLoantype";
            this.dgLoantype.RowHeadersVisible = false;
            this.dgLoantype.Size = new System.Drawing.Size(743, 146);
            this.dgLoantype.TabIndex = 94;
            // 
            // statusPanel
            // 
            this.statusPanel.Controls.Add(this.rbtnInactive);
            this.statusPanel.Controls.Add(this.rbtnActive);
            this.statusPanel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusPanel.Location = new System.Drawing.Point(178, 368);
            this.statusPanel.Name = "statusPanel";
            this.statusPanel.Size = new System.Drawing.Size(138, 24);
            this.statusPanel.TabIndex = 157;
            // 
            // rbtnInactive
            // 
            this.rbtnInactive.AutoSize = true;
            this.rbtnInactive.Location = new System.Drawing.Point(67, 3);
            this.rbtnInactive.Name = "rbtnInactive";
            this.rbtnInactive.Size = new System.Drawing.Size(69, 20);
            this.rbtnInactive.TabIndex = 162;
            this.rbtnInactive.TabStop = true;
            this.rbtnInactive.Text = "Inactive";
            this.rbtnInactive.UseVisualStyleBackColor = true;
            // 
            // rbtnActive
            // 
            this.rbtnActive.AutoSize = true;
            this.rbtnActive.Location = new System.Drawing.Point(10, 3);
            this.rbtnActive.Name = "rbtnActive";
            this.rbtnActive.Size = new System.Drawing.Size(61, 20);
            this.rbtnActive.TabIndex = 162;
            this.rbtnActive.TabStop = true;
            this.rbtnActive.Text = "Active";
            this.rbtnActive.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(24, 375);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(50, 16);
            this.label16.TabIndex = 158;
            this.label16.Text = "Status:";
            // 
            // MaintenanceLoanTypeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(788, 450);
            this.Controls.Add(this.panel1);
            this.Name = "MaintenanceLoanTypeView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loan Type";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.LoanEntitlementPanel.ResumeLayout(false);
            this.LoanEntitlementPanel.PerformLayout();
            this.collateraPanel.ResumeLayout(false);
            this.collateraPanel.PerformLayout();
            this.comakerPanel.ResumeLayout(false);
            this.comakerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgLoantype)).EndInit();
            this.statusPanel.ResumeLayout(false);
            this.statusPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckedListBox listUnselected;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Panel comakerPanel;
        private System.Windows.Forms.RadioButton rbtnCoMakerYes;
        private System.Windows.Forms.RadioButton rbtnCoMakerNo;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtMaxAmount;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtLoanName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMinAmount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMaxTerm;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboFilter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgLoantype;
        private System.Windows.Forms.CheckBox chkNoEntitlement;
        private System.Windows.Forms.TextBox txtLoanEntitlement;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel collateraPanel;
        private System.Windows.Forms.RadioButton rbtnNo;
        private System.Windows.Forms.RadioButton rbtnYes;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel LoanEntitlementPanel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtLoanEligibility;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel statusPanel;
        private System.Windows.Forms.RadioButton rbtnInactive;
        private System.Windows.Forms.RadioButton rbtnActive;
        private System.Windows.Forms.Label label16;

    }
}