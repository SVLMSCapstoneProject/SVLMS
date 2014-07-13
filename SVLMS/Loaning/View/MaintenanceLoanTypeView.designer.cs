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
            this.txtMaxAmount = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtLoanName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMinAmount = new System.Windows.Forms.TextBox();
            this.rbtnCoMakerYes = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dgLoantype = new System.Windows.Forms.DataGridView();
            this.txtMaxTerm = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rbtnCoMakerNo = new System.Windows.Forms.RadioButton();
            this.panelSavingsTypeTitle = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cboFilter = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtLoanEligibility = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.chkNoEntitlement = new System.Windows.Forms.CheckBox();
            this.collateraPanel = new System.Windows.Forms.Panel();
            this.rbtnNo = new System.Windows.Forms.RadioButton();
            this.rbtnYes = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.txtLoanEntitlement = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.statusPanel = new System.Windows.Forms.Panel();
            this.rbtnInactive = new System.Windows.Forms.RadioButton();
            this.rbtnActive = new System.Windows.Forms.RadioButton();
            this.label16 = new System.Windows.Forms.Label();
            this.listUnselected = new System.Windows.Forms.CheckedListBox();
            this.comakerPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgLoantype)).BeginInit();
            this.panelSavingsTypeTitle.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.collateraPanel.SuspendLayout();
            this.statusPanel.SuspendLayout();
            this.comakerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtMaxAmount
            // 
            this.txtMaxAmount.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F);
            this.txtMaxAmount.Location = new System.Drawing.Point(225, 98);
            this.txtMaxAmount.MaxLength = 15;
            this.txtMaxAmount.Name = "txtMaxAmount";
            this.txtMaxAmount.Size = new System.Drawing.Size(193, 27);
            this.txtMaxAmount.TabIndex = 196;
            this.txtMaxAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaxAmount_KeyPress);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI Light", 11.25F);
            this.label15.ImeMode = System.Windows.Forms.ImeMode.On;
            this.label15.Location = new System.Drawing.Point(56, 102);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(125, 20);
            this.label15.TabIndex = 208;
            this.label15.Text = "Maximum Amount:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI Light", 11.25F);
            this.label14.ImeMode = System.Windows.Forms.ImeMode.On;
            this.label14.Location = new System.Drawing.Point(441, 153);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(92, 20);
            this.label14.TabIndex = 207;
            this.label14.Text = "Applicable to:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Light", 11.25F);
            this.label12.ImeMode = System.Windows.Forms.ImeMode.On;
            this.label12.Location = new System.Drawing.Point(56, 168);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(103, 20);
            this.label12.TabIndex = 206;
            this.label12.Text = "With Co-Maker";
            // 
            // txtLoanName
            // 
            this.txtLoanName.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F);
            this.txtLoanName.Location = new System.Drawing.Point(225, 32);
            this.txtLoanName.MaxLength = 50;
            this.txtLoanName.Name = "txtLoanName";
            this.txtLoanName.Size = new System.Drawing.Size(193, 27);
            this.txtLoanName.TabIndex = 194;
            this.txtLoanName.Validating += new System.ComponentModel.CancelEventHandler(this.txtLoanName_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Light", 11.25F);
            this.label4.ImeMode = System.Windows.Forms.ImeMode.On;
            this.label4.Location = new System.Drawing.Point(56, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 20);
            this.label4.TabIndex = 201;
            this.label4.Text = "Loan Name:";
            // 
            // txtMinAmount
            // 
            this.txtMinAmount.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F);
            this.txtMinAmount.Location = new System.Drawing.Point(225, 65);
            this.txtMinAmount.MaxLength = 15;
            this.txtMinAmount.Name = "txtMinAmount";
            this.txtMinAmount.Size = new System.Drawing.Size(193, 27);
            this.txtMinAmount.TabIndex = 195;
            this.txtMinAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMinAmount_KeyPress);
            // 
            // rbtnCoMakerYes
            // 
            this.rbtnCoMakerYes.AutoSize = true;
            this.rbtnCoMakerYes.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F);
            this.rbtnCoMakerYes.ImeMode = System.Windows.Forms.ImeMode.On;
            this.rbtnCoMakerYes.Location = new System.Drawing.Point(20, 6);
            this.rbtnCoMakerYes.Name = "rbtnCoMakerYes";
            this.rbtnCoMakerYes.Size = new System.Drawing.Size(49, 24);
            this.rbtnCoMakerYes.TabIndex = 46;
            this.rbtnCoMakerYes.TabStop = true;
            this.rbtnCoMakerYes.Text = "Yes";
            this.rbtnCoMakerYes.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Light", 11.25F);
            this.label6.ImeMode = System.Windows.Forms.ImeMode.On;
            this.label6.Location = new System.Drawing.Point(56, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 20);
            this.label6.TabIndex = 203;
            this.label6.Text = "Minimum Amount:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Light", 11.25F);
            this.label7.ImeMode = System.Windows.Forms.ImeMode.On;
            this.label7.Location = new System.Drawing.Point(56, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(167, 20);
            this.label7.TabIndex = 204;
            this.label7.Text = "Maximum Term (Months):";
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
            this.dgLoantype.Location = new System.Drawing.Point(13, 101);
            this.dgLoantype.Name = "dgLoantype";
            this.dgLoantype.Size = new System.Drawing.Size(832, 223);
            this.dgLoantype.TabIndex = 99;
            // 
            // txtMaxTerm
            // 
            this.txtMaxTerm.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F);
            this.txtMaxTerm.Location = new System.Drawing.Point(225, 131);
            this.txtMaxTerm.MaxLength = 5;
            this.txtMaxTerm.Name = "txtMaxTerm";
            this.txtMaxTerm.Size = new System.Drawing.Size(193, 27);
            this.txtMaxTerm.TabIndex = 197;
            this.txtMaxTerm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaxTerm_KeyPress);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.label1.Location = new System.Drawing.Point(7, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Loan Type Maintenance";
            // 
            // rbtnCoMakerNo
            // 
            this.rbtnCoMakerNo.AutoSize = true;
            this.rbtnCoMakerNo.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F);
            this.rbtnCoMakerNo.ImeMode = System.Windows.Forms.ImeMode.On;
            this.rbtnCoMakerNo.Location = new System.Drawing.Point(77, 6);
            this.rbtnCoMakerNo.Name = "rbtnCoMakerNo";
            this.rbtnCoMakerNo.Size = new System.Drawing.Size(47, 24);
            this.rbtnCoMakerNo.TabIndex = 45;
            this.rbtnCoMakerNo.TabStop = true;
            this.rbtnCoMakerNo.Text = "No";
            this.rbtnCoMakerNo.UseVisualStyleBackColor = true;
            // 
            // panelSavingsTypeTitle
            // 
            this.panelSavingsTypeTitle.BackColor = System.Drawing.Color.RoyalBlue;
            this.panelSavingsTypeTitle.Controls.Add(this.label1);
            this.panelSavingsTypeTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSavingsTypeTitle.Location = new System.Drawing.Point(0, 0);
            this.panelSavingsTypeTitle.Name = "panelSavingsTypeTitle";
            this.panelSavingsTypeTitle.Size = new System.Drawing.Size(860, 56);
            this.panelSavingsTypeTitle.TabIndex = 97;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.dgLoantype);
            this.panel1.Controls.Add(this.panelSavingsTypeTitle);
            this.panel1.Location = new System.Drawing.Point(-2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(860, 704);
            this.panel1.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.txtSearch);
            this.panel3.Controls.Add(this.cboFilter);
            this.panel3.Controls.Add(this.btnSearch);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Location = new System.Drawing.Point(3, 57);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(854, 33);
            this.panel3.TabIndex = 101;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Light", 11F);
            this.label9.ImeMode = System.Windows.Forms.ImeMode.On;
            this.label9.Location = new System.Drawing.Point(562, 7);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 20);
            this.label9.TabIndex = 106;
            this.label9.Text = "Search:";
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI Symbol", 11F);
            this.txtSearch.Location = new System.Drawing.Point(622, 3);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(165, 27);
            this.txtSearch.TabIndex = 105;
            // 
            // cboFilter
            // 
            this.cboFilter.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cboFilter.Font = new System.Drawing.Font("Segoe UI Symbol", 11F);
            this.cboFilter.FormattingEnabled = true;
            this.cboFilter.Items.AddRange(new object[] {
            "No Filter",
            "Active",
            "Inactive"});
            this.cboFilter.Location = new System.Drawing.Point(60, 2);
            this.cboFilter.Name = "cboFilter";
            this.cboFilter.Size = new System.Drawing.Size(155, 28);
            this.cboFilter.TabIndex = 103;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSearch.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSearch.BackgroundImage = global::SVLMS.Properties.Resources.find_icon;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ImeMode = System.Windows.Forms.ImeMode.On;
            this.btnSearch.Location = new System.Drawing.Point(793, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(50, 27);
            this.btnSearch.TabIndex = 104;
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Light", 11F);
            this.label10.ImeMode = System.Windows.Forms.ImeMode.On;
            this.label10.Location = new System.Drawing.Point(6, 6);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 20);
            this.label10.TabIndex = 102;
            this.label10.Text = "Filters:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtLoanEligibility);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.chkNoEntitlement);
            this.groupBox1.Controls.Add(this.collateraPanel);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtLoanEntitlement);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.statusPanel);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.listUnselected);
            this.groupBox1.Controls.Add(this.comakerPanel);
            this.groupBox1.Controls.Add(this.txtMaxAmount);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txtLoanName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtMinAmount);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtMaxTerm);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.groupBox1.Location = new System.Drawing.Point(12, 330);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(834, 363);
            this.groupBox1.TabIndex = 100;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Loan Type Information";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(61, 256);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(134, 20);
            this.label13.TabIndex = 220;
            this.label13.Text = "Renewal Eligibility:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(447, 256);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(225, 20);
            this.label11.TabIndex = 219;
            this.label11.Text = "% paid to apply for another loan";
            // 
            // txtLoanEligibility
            // 
            this.txtLoanEligibility.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoanEligibility.Location = new System.Drawing.Point(351, 253);
            this.txtLoanEligibility.MaxLength = 4;
            this.txtLoanEligibility.Name = "txtLoanEligibility";
            this.txtLoanEligibility.Size = new System.Drawing.Size(93, 27);
            this.txtLoanEligibility.TabIndex = 218;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(221, 256);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(129, 20);
            this.label17.TabIndex = 217;
            this.label17.Text = "This loan must be ";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnUpdate.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnUpdate.BackgroundImage = global::SVLMS.Properties.Resources.save_icon;
            this.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnUpdate.ImeMode = System.Windows.Forms.ImeMode.On;
            this.btnUpdate.Location = new System.Drawing.Point(392, 315);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(98, 35);
            this.btnUpdate.TabIndex = 216;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            this.btnClear.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnClear.BackColor = System.Drawing.Color.Red;
            this.btnClear.BackgroundImage = global::SVLMS.Properties.Resources.cancel_icon;
            this.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnClear.ImeMode = System.Windows.Forms.ImeMode.On;
            this.btnClear.Location = new System.Drawing.Point(496, 315);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(98, 35);
            this.btnClear.TabIndex = 214;
            this.btnClear.Text = "Clear";
            this.btnClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSave.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnSave.BackgroundImage = global::SVLMS.Properties.Resources.add_icon;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSave.ImeMode = System.Windows.Forms.ImeMode.On;
            this.btnSave.Location = new System.Drawing.Point(288, 315);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(98, 35);
            this.btnSave.TabIndex = 215;
            this.btnSave.Text = "Add";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // chkNoEntitlement
            // 
            this.chkNoEntitlement.AutoSize = true;
            this.chkNoEntitlement.BackColor = System.Drawing.Color.White;
            this.chkNoEntitlement.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F);
            this.chkNoEntitlement.ImeMode = System.Windows.Forms.ImeMode.On;
            this.chkNoEntitlement.Location = new System.Drawing.Point(573, 68);
            this.chkNoEntitlement.Name = "chkNoEntitlement";
            this.chkNoEntitlement.Size = new System.Drawing.Size(164, 24);
            this.chkNoEntitlement.TabIndex = 193;
            this.chkNoEntitlement.Text = "No Loan Entitlement";
            this.chkNoEntitlement.UseVisualStyleBackColor = false;
            // 
            // collateraPanel
            // 
            this.collateraPanel.Controls.Add(this.rbtnNo);
            this.collateraPanel.Controls.Add(this.rbtnYes);
            this.collateraPanel.Location = new System.Drawing.Point(574, 103);
            this.collateraPanel.Name = "collateraPanel";
            this.collateraPanel.Size = new System.Drawing.Size(193, 35);
            this.collateraPanel.TabIndex = 212;
            // 
            // rbtnNo
            // 
            this.rbtnNo.AutoSize = true;
            this.rbtnNo.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F);
            this.rbtnNo.ImeMode = System.Windows.Forms.ImeMode.On;
            this.rbtnNo.Location = new System.Drawing.Point(59, 6);
            this.rbtnNo.Name = "rbtnNo";
            this.rbtnNo.Size = new System.Drawing.Size(47, 24);
            this.rbtnNo.TabIndex = 162;
            this.rbtnNo.TabStop = true;
            this.rbtnNo.Text = "No";
            this.rbtnNo.UseVisualStyleBackColor = true;
            // 
            // rbtnYes
            // 
            this.rbtnYes.AutoSize = true;
            this.rbtnYes.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F);
            this.rbtnYes.ImeMode = System.Windows.Forms.ImeMode.On;
            this.rbtnYes.Location = new System.Drawing.Point(10, 5);
            this.rbtnYes.Name = "rbtnYes";
            this.rbtnYes.Size = new System.Drawing.Size(49, 24);
            this.rbtnYes.TabIndex = 162;
            this.rbtnYes.TabStop = true;
            this.rbtnYes.Text = "Yes";
            this.rbtnYes.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Light", 11.25F);
            this.label8.ImeMode = System.Windows.Forms.ImeMode.On;
            this.label8.Location = new System.Drawing.Point(441, 103);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 20);
            this.label8.TabIndex = 213;
            this.label8.Text = "Collateralized";
            // 
            // txtLoanEntitlement
            // 
            this.txtLoanEntitlement.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F);
            this.txtLoanEntitlement.Location = new System.Drawing.Point(573, 34);
            this.txtLoanEntitlement.MaxLength = 15;
            this.txtLoanEntitlement.Name = "txtLoanEntitlement";
            this.txtLoanEntitlement.Size = new System.Drawing.Size(193, 27);
            this.txtLoanEntitlement.TabIndex = 211;
            this.txtLoanEntitlement.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLoanEntitlement_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Light", 11.25F);
            this.label5.ImeMode = System.Windows.Forms.ImeMode.On;
            this.label5.Location = new System.Drawing.Point(441, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 20);
            this.label5.TabIndex = 210;
            this.label5.Text = "Loan Entitlement:";
            // 
            // statusPanel
            // 
            this.statusPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.statusPanel.Controls.Add(this.rbtnInactive);
            this.statusPanel.Controls.Add(this.rbtnActive);
            this.statusPanel.ForeColor = System.Drawing.Color.Black;
            this.statusPanel.Location = new System.Drawing.Point(225, 197);
            this.statusPanel.Name = "statusPanel";
            this.statusPanel.Size = new System.Drawing.Size(193, 37);
            this.statusPanel.TabIndex = 205;
            // 
            // rbtnInactive
            // 
            this.rbtnInactive.AutoSize = true;
            this.rbtnInactive.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F);
            this.rbtnInactive.ImeMode = System.Windows.Forms.ImeMode.On;
            this.rbtnInactive.Location = new System.Drawing.Point(94, 6);
            this.rbtnInactive.Name = "rbtnInactive";
            this.rbtnInactive.Size = new System.Drawing.Size(78, 24);
            this.rbtnInactive.TabIndex = 162;
            this.rbtnInactive.TabStop = true;
            this.rbtnInactive.Text = "Inactive";
            this.rbtnInactive.UseVisualStyleBackColor = true;
            // 
            // rbtnActive
            // 
            this.rbtnActive.AutoSize = true;
            this.rbtnActive.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F);
            this.rbtnActive.ImeMode = System.Windows.Forms.ImeMode.On;
            this.rbtnActive.Location = new System.Drawing.Point(20, 6);
            this.rbtnActive.Name = "rbtnActive";
            this.rbtnActive.Size = new System.Drawing.Size(68, 24);
            this.rbtnActive.TabIndex = 162;
            this.rbtnActive.TabStop = true;
            this.rbtnActive.Text = "Active";
            this.rbtnActive.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI Light", 11.25F);
            this.label16.ImeMode = System.Windows.Forms.ImeMode.On;
            this.label16.Location = new System.Drawing.Point(60, 203);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(48, 20);
            this.label16.TabIndex = 209;
            this.label16.Text = "Status:";
            // 
            // listUnselected
            // 
            this.listUnselected.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F);
            this.listUnselected.FormattingEnabled = true;
            this.listUnselected.Location = new System.Drawing.Point(574, 153);
            this.listUnselected.Name = "listUnselected";
            this.listUnselected.Size = new System.Drawing.Size(192, 92);
            this.listUnselected.TabIndex = 202;
            // 
            // comakerPanel
            // 
            this.comakerPanel.Controls.Add(this.rbtnCoMakerYes);
            this.comakerPanel.Controls.Add(this.rbtnCoMakerNo);
            this.comakerPanel.Location = new System.Drawing.Point(225, 163);
            this.comakerPanel.Name = "comakerPanel";
            this.comakerPanel.Size = new System.Drawing.Size(193, 33);
            this.comakerPanel.TabIndex = 199;
            // 
            // MaintenanceLoanTypeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(856, 585);
            this.Controls.Add(this.panel1);
            this.Name = "MaintenanceLoanTypeView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MaintenanceLoanTypeView1";
            ((System.ComponentModel.ISupportInitialize)(this.dgLoantype)).EndInit();
            this.panelSavingsTypeTitle.ResumeLayout(false);
            this.panelSavingsTypeTitle.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.collateraPanel.ResumeLayout(false);
            this.collateraPanel.PerformLayout();
            this.statusPanel.ResumeLayout(false);
            this.statusPanel.PerformLayout();
            this.comakerPanel.ResumeLayout(false);
            this.comakerPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtMaxAmount;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtLoanName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMinAmount;
        private System.Windows.Forms.RadioButton rbtnCoMakerYes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgLoantype;
        private System.Windows.Forms.TextBox txtMaxTerm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbtnCoMakerNo;
        private System.Windows.Forms.Panel panelSavingsTypeTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.CheckBox chkNoEntitlement;
        private System.Windows.Forms.Panel collateraPanel;
        private System.Windows.Forms.RadioButton rbtnNo;
        private System.Windows.Forms.RadioButton rbtnYes;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtLoanEntitlement;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel statusPanel;
        private System.Windows.Forms.RadioButton rbtnInactive;
        private System.Windows.Forms.RadioButton rbtnActive;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.CheckedListBox listUnselected;
        private System.Windows.Forms.Panel comakerPanel;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtLoanEligibility;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cboFilter;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label10;
    }
}