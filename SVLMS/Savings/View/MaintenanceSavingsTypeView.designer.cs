namespace SVLMS.Savings.View
{
    partial class MaintenanceSavingsTypeView
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
            this.panelSavingsTypeTitle = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSearchBox = new System.Windows.Forms.TextBox();
            this.cboFilter = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtMaintainingBalance = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtInterest = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.statusPanel = new System.Windows.Forms.Panel();
            this.rbtnInactive = new System.Windows.Forms.RadioButton();
            this.rbtnActive = new System.Windows.Forms.RadioButton();
            this.percentagePanel = new System.Windows.Forms.Panel();
            this.rbtnPercentage = new System.Windows.Forms.RadioButton();
            this.rbtnFixed = new System.Windows.Forms.RadioButton();
            this.Duration = new System.Windows.Forms.Label();
            this.NoWithdrawalLimitPanel = new System.Windows.Forms.Panel();
            this.chkWithdrawalLimit = new System.Windows.Forms.CheckBox();
            this.error = new System.Windows.Forms.Label();
            this.txtNoAccountHolder = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cboWithdrawDuration = new System.Windows.Forms.ComboBox();
            this.txtMaxWithdrawal = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtSavingsName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgSavingsType = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panelSavingsTypeTitle.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.statusPanel.SuspendLayout();
            this.percentagePanel.SuspendLayout();
            this.NoWithdrawalLimitPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSavingsType)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panelSavingsTypeTitle);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.dgSavingsType);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(867, 533);
            this.panel1.TabIndex = 0;
            // 
            // panelSavingsTypeTitle
            // 
            this.panelSavingsTypeTitle.BackColor = System.Drawing.Color.LimeGreen;
            this.panelSavingsTypeTitle.Controls.Add(this.label2);
            this.panelSavingsTypeTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSavingsTypeTitle.Location = new System.Drawing.Point(0, 0);
            this.panelSavingsTypeTitle.Name = "panelSavingsTypeTitle";
            this.panelSavingsTypeTitle.Size = new System.Drawing.Size(867, 56);
            this.panelSavingsTypeTitle.TabIndex = 186;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.On;
            this.label2.Location = new System.Drawing.Point(7, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(236, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Savings Type Maintenance";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.txtSearchBox);
            this.panel2.Controls.Add(this.cboFilter);
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Location = new System.Drawing.Point(0, 55);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(867, 33);
            this.panel2.TabIndex = 185;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Light", 11F);
            this.label9.ImeMode = System.Windows.Forms.ImeMode.On;
            this.label9.Location = new System.Drawing.Point(572, 5);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 20);
            this.label9.TabIndex = 108;
            this.label9.Text = "Search:";
            // 
            // txtSearchBox
            // 
            this.txtSearchBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtSearchBox.Font = new System.Drawing.Font("Segoe UI Symbol", 11F);
            this.txtSearchBox.Location = new System.Drawing.Point(632, 2);
            this.txtSearchBox.Name = "txtSearchBox";
            this.txtSearchBox.Size = new System.Drawing.Size(165, 27);
            this.txtSearchBox.TabIndex = 107;
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
            this.cboFilter.Location = new System.Drawing.Point(66, 2);
            this.cboFilter.Name = "cboFilter";
            this.cboFilter.Size = new System.Drawing.Size(155, 28);
            this.cboFilter.TabIndex = 105;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSearch.BackColor = System.Drawing.Color.LimeGreen;
            this.btnSearch.BackgroundImage = global::SVLMS.Properties.Resources.find_icon;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ImeMode = System.Windows.Forms.ImeMode.On;
            this.btnSearch.Location = new System.Drawing.Point(803, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(50, 27);
            this.btnSearch.TabIndex = 106;
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Light", 11F);
            this.label10.ImeMode = System.Windows.Forms.ImeMode.On;
            this.label10.Location = new System.Drawing.Point(12, 5);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 20);
            this.label10.TabIndex = 103;
            this.label10.Text = "Filters:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.txtMaintainingBalance);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtInterest);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.statusPanel);
            this.groupBox1.Controls.Add(this.percentagePanel);
            this.groupBox1.Controls.Add(this.Duration);
            this.groupBox1.Controls.Add(this.NoWithdrawalLimitPanel);
            this.groupBox1.Controls.Add(this.error);
            this.groupBox1.Controls.Add(this.txtNoAccountHolder);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.cboWithdrawDuration);
            this.groupBox1.Controls.Add(this.txtMaxWithdrawal);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtSavingsName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(10, 301);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(850, 226);
            this.groupBox1.TabIndex = 184;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Savings Type Information";
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
            this.btnUpdate.Location = new System.Drawing.Point(384, 173);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(98, 35);
            this.btnUpdate.TabIndex = 238;
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
            this.btnClear.Location = new System.Drawing.Point(488, 173);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(98, 35);
            this.btnClear.TabIndex = 236;
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
            this.btnSave.Location = new System.Drawing.Point(280, 173);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(98, 35);
            this.btnSave.TabIndex = 237;
            this.btnSave.Text = "Add";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // txtMaintainingBalance
            // 
            this.txtMaintainingBalance.Location = new System.Drawing.Point(650, 28);
            this.txtMaintainingBalance.MaxLength = 15;
            this.txtMaintainingBalance.Name = "txtMaintainingBalance";
            this.txtMaintainingBalance.Size = new System.Drawing.Size(170, 27);
            this.txtMaintainingBalance.TabIndex = 229;
            this.txtMaintainingBalance.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaintainingBalance_KeyPress_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(497, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 20);
            this.label6.TabIndex = 235;
            this.label6.Text = "Maintaining Balance:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(497, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 20);
            this.label4.TabIndex = 233;
            this.label4.Text = "Interest:";
            // 
            // txtInterest
            // 
            this.txtInterest.Location = new System.Drawing.Point(650, 60);
            this.txtInterest.MaxLength = 15;
            this.txtInterest.Name = "txtInterest";
            this.txtInterest.Size = new System.Drawing.Size(170, 27);
            this.txtInterest.TabIndex = 230;
            this.txtInterest.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInterest_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(497, 128);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 20);
            this.label13.TabIndex = 234;
            this.label13.Text = "Status:";
            // 
            // statusPanel
            // 
            this.statusPanel.Controls.Add(this.rbtnInactive);
            this.statusPanel.Controls.Add(this.rbtnActive);
            this.statusPanel.Location = new System.Drawing.Point(650, 126);
            this.statusPanel.Name = "statusPanel";
            this.statusPanel.Size = new System.Drawing.Size(170, 31);
            this.statusPanel.TabIndex = 231;
            // 
            // rbtnInactive
            // 
            this.rbtnInactive.AutoSize = true;
            this.rbtnInactive.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnInactive.Location = new System.Drawing.Point(75, 4);
            this.rbtnInactive.Name = "rbtnInactive";
            this.rbtnInactive.Size = new System.Drawing.Size(78, 24);
            this.rbtnInactive.TabIndex = 12;
            this.rbtnInactive.TabStop = true;
            this.rbtnInactive.Text = "Inactive";
            this.rbtnInactive.UseVisualStyleBackColor = true;
            // 
            // rbtnActive
            // 
            this.rbtnActive.AutoSize = true;
            this.rbtnActive.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnActive.Location = new System.Drawing.Point(9, 4);
            this.rbtnActive.Name = "rbtnActive";
            this.rbtnActive.Size = new System.Drawing.Size(68, 24);
            this.rbtnActive.TabIndex = 11;
            this.rbtnActive.TabStop = true;
            this.rbtnActive.Text = "Active";
            this.rbtnActive.UseVisualStyleBackColor = true;
            // 
            // percentagePanel
            // 
            this.percentagePanel.Controls.Add(this.rbtnPercentage);
            this.percentagePanel.Controls.Add(this.rbtnFixed);
            this.percentagePanel.Location = new System.Drawing.Point(650, 92);
            this.percentagePanel.Name = "percentagePanel";
            this.percentagePanel.Size = new System.Drawing.Size(170, 32);
            this.percentagePanel.TabIndex = 232;
            // 
            // rbtnPercentage
            // 
            this.rbtnPercentage.AutoSize = true;
            this.rbtnPercentage.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnPercentage.Location = new System.Drawing.Point(71, 5);
            this.rbtnPercentage.Name = "rbtnPercentage";
            this.rbtnPercentage.Size = new System.Drawing.Size(101, 24);
            this.rbtnPercentage.TabIndex = 10;
            this.rbtnPercentage.TabStop = true;
            this.rbtnPercentage.Text = "Percentage";
            this.rbtnPercentage.UseVisualStyleBackColor = true;
            // 
            // rbtnFixed
            // 
            this.rbtnFixed.AutoSize = true;
            this.rbtnFixed.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnFixed.Location = new System.Drawing.Point(9, 4);
            this.rbtnFixed.Name = "rbtnFixed";
            this.rbtnFixed.Size = new System.Drawing.Size(62, 24);
            this.rbtnFixed.TabIndex = 9;
            this.rbtnFixed.TabStop = true;
            this.rbtnFixed.Text = "Fixed";
            this.rbtnFixed.UseVisualStyleBackColor = true;
            // 
            // Duration
            // 
            this.Duration.AutoSize = true;
            this.Duration.BackColor = System.Drawing.Color.Red;
            this.Duration.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Duration.ForeColor = System.Drawing.SystemColors.Window;
            this.Duration.Location = new System.Drawing.Point(478, 96);
            this.Duration.Name = "Duration";
            this.Duration.Size = new System.Drawing.Size(16, 15);
            this.Duration.TabIndex = 228;
            this.Duration.Text = "X";
            this.Duration.Visible = false;
            // 
            // NoWithdrawalLimitPanel
            // 
            this.NoWithdrawalLimitPanel.Controls.Add(this.chkWithdrawalLimit);
            this.NoWithdrawalLimitPanel.Location = new System.Drawing.Point(199, 123);
            this.NoWithdrawalLimitPanel.Name = "NoWithdrawalLimitPanel";
            this.NoWithdrawalLimitPanel.Size = new System.Drawing.Size(172, 31);
            this.NoWithdrawalLimitPanel.TabIndex = 223;
            // 
            // chkWithdrawalLimit
            // 
            this.chkWithdrawalLimit.AutoSize = true;
            this.chkWithdrawalLimit.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkWithdrawalLimit.Location = new System.Drawing.Point(5, 4);
            this.chkWithdrawalLimit.Name = "chkWithdrawalLimit";
            this.chkWithdrawalLimit.Size = new System.Drawing.Size(165, 24);
            this.chkWithdrawalLimit.TabIndex = 199;
            this.chkWithdrawalLimit.Text = "No Withdrawal Limit";
            this.chkWithdrawalLimit.UseVisualStyleBackColor = true;
            // 
            // error
            // 
            this.error.AutoSize = true;
            this.error.BackColor = System.Drawing.Color.Red;
            this.error.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.error.ForeColor = System.Drawing.SystemColors.Window;
            this.error.Location = new System.Drawing.Point(404, 114);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(0, 16);
            this.error.TabIndex = 227;
            this.error.Visible = false;
            // 
            // txtNoAccountHolder
            // 
            this.txtNoAccountHolder.Location = new System.Drawing.Point(199, 57);
            this.txtNoAccountHolder.MaxLength = 4;
            this.txtNoAccountHolder.Name = "txtNoAccountHolder";
            this.txtNoAccountHolder.Size = new System.Drawing.Size(170, 27);
            this.txtNoAccountHolder.TabIndex = 220;
            this.txtNoAccountHolder.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNoAccountHolder_KeyPress_1);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(14, 63);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(167, 20);
            this.label14.TabIndex = 226;
            this.label14.Text = "No. of Account Holders:";
            // 
            // cboWithdrawDuration
            // 
            this.cboWithdrawDuration.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboWithdrawDuration.FormattingEnabled = true;
            this.cboWithdrawDuration.Items.AddRange(new object[] {
            "per Day",
            "per Week",
            "per Month",
            "per Year"});
            this.cboWithdrawDuration.Location = new System.Drawing.Point(375, 90);
            this.cboWithdrawDuration.Name = "cboWithdrawDuration";
            this.cboWithdrawDuration.Size = new System.Drawing.Size(99, 28);
            this.cboWithdrawDuration.TabIndex = 222;
            // 
            // txtMaxWithdrawal
            // 
            this.txtMaxWithdrawal.Location = new System.Drawing.Point(199, 90);
            this.txtMaxWithdrawal.MaxLength = 15;
            this.txtMaxWithdrawal.Name = "txtMaxWithdrawal";
            this.txtMaxWithdrawal.Size = new System.Drawing.Size(170, 27);
            this.txtMaxWithdrawal.TabIndex = 221;
            this.txtMaxWithdrawal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaxWithdrawal_KeyPress_1);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(13, 95);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(177, 20);
            this.label11.TabIndex = 225;
            this.label11.Text = "Max Withdrawal Amount:";
            // 
            // txtSavingsName
            // 
            this.txtSavingsName.BackColor = System.Drawing.SystemColors.Window;
            this.txtSavingsName.Location = new System.Drawing.Point(199, 24);
            this.txtSavingsName.MaxLength = 50;
            this.txtSavingsName.Name = "txtSavingsName";
            this.txtSavingsName.Size = new System.Drawing.Size(170, 27);
            this.txtSavingsName.TabIndex = 219;
            this.txtSavingsName.Validating += new System.ComponentModel.CancelEventHandler(this.txtSavingsName_Validating_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 20);
            this.label3.TabIndex = 224;
            this.label3.Text = "Savings Type Name:";
            // 
            // dgSavingsType
            // 
            this.dgSavingsType.AllowUserToAddRows = false;
            this.dgSavingsType.AllowUserToDeleteRows = false;
            this.dgSavingsType.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgSavingsType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSavingsType.Location = new System.Drawing.Point(48, 95);
            this.dgSavingsType.Name = "dgSavingsType";
            this.dgSavingsType.Size = new System.Drawing.Size(776, 200);
            this.dgSavingsType.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 29);
            this.label1.TabIndex = 164;
            this.label1.Text = "Maintenance: Savings Type";
            // 
            // MaintenanceSavingsTypeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(871, 535);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "MaintenanceSavingsTypeView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Savings Type";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelSavingsTypeTitle.ResumeLayout(false);
            this.panelSavingsTypeTitle.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusPanel.ResumeLayout(false);
            this.statusPanel.PerformLayout();
            this.percentagePanel.ResumeLayout(false);
            this.percentagePanel.PerformLayout();
            this.NoWithdrawalLimitPanel.ResumeLayout(false);
            this.NoWithdrawalLimitPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSavingsType)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgSavingsType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMaintainingBalance;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtInterest;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel statusPanel;
        private System.Windows.Forms.RadioButton rbtnInactive;
        private System.Windows.Forms.RadioButton rbtnActive;
        private System.Windows.Forms.Panel percentagePanel;
        private System.Windows.Forms.RadioButton rbtnPercentage;
        private System.Windows.Forms.RadioButton rbtnFixed;
        private System.Windows.Forms.Label Duration;
        private System.Windows.Forms.Panel NoWithdrawalLimitPanel;
        private System.Windows.Forms.CheckBox chkWithdrawalLimit;
        private System.Windows.Forms.Label error;
        private System.Windows.Forms.TextBox txtNoAccountHolder;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cboWithdrawDuration;
        private System.Windows.Forms.TextBox txtMaxWithdrawal;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtSavingsName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panelSavingsTypeTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSearchBox;
        private System.Windows.Forms.ComboBox cboFilter;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label10;

    }
}