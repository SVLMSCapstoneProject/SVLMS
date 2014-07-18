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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelSavingsTypeTitle = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelSearch = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.cboFilter = new System.Windows.Forms.ComboBox();
            this.txtSearchBox = new System.Windows.Forms.TextBox();
            this.panelDataGridView = new System.Windows.Forms.Panel();
            this.dgSavingsType = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chkWithdrawalLimit = new System.Windows.Forms.CheckBox();
            this.rbtnInactive = new System.Windows.Forms.RadioButton();
            this.rbtnPercentage = new System.Windows.Forms.RadioButton();
            this.rbtnActive = new System.Windows.Forms.RadioButton();
            this.rbtnFixed = new System.Windows.Forms.RadioButton();
            this.cboWithdrawDuration = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaxWithdrawal = new System.Windows.Forms.TextBox();
            this.txtNoAccountHolder = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtInterest = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaintainingBalance = new System.Windows.Forms.TextBox();
            this.txtSavingsName = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.panelSavingsTypeTitle.SuspendLayout();
            this.panelSearch.SuspendLayout();
            this.panelDataGridView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSavingsType)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSavingsTypeTitle
            // 
            this.panelSavingsTypeTitle.BackColor = System.Drawing.Color.LimeGreen;
            this.panelSavingsTypeTitle.Controls.Add(this.label1);
            this.panelSavingsTypeTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSavingsTypeTitle.Location = new System.Drawing.Point(0, 0);
            this.panelSavingsTypeTitle.Name = "panelSavingsTypeTitle";
            this.panelSavingsTypeTitle.Size = new System.Drawing.Size(834, 50);
            this.panelSavingsTypeTitle.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(7, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Savings Type Maintenance";
            // 
            // panelSearch
            // 
            this.panelSearch.Controls.Add(this.label10);
            this.panelSearch.Controls.Add(this.cboFilter);
            this.panelSearch.Controls.Add(this.txtSearchBox);
            this.panelSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSearch.Location = new System.Drawing.Point(0, 50);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(834, 39);
            this.panelSearch.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Light", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(430, 8);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 20);
            this.label10.TabIndex = 5;
            this.label10.Text = "Filters:";
            // 
            // cboFilter
            // 
            this.cboFilter.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cboFilter.Font = new System.Drawing.Font("Segoe UI Symbol", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboFilter.FormattingEnabled = true;
            this.cboFilter.Location = new System.Drawing.Point(484, 5);
            this.cboFilter.Name = "cboFilter";
            this.cboFilter.Size = new System.Drawing.Size(155, 28);
            this.cboFilter.TabIndex = 21;
            // 
            // txtSearchBox
            // 
            this.txtSearchBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSearchBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtSearchBox.Font = new System.Drawing.Font("Segoe UI Symbol", 11.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchBox.Location = new System.Drawing.Point(645, 5);
            this.txtSearchBox.Name = "txtSearchBox";
            this.txtSearchBox.Size = new System.Drawing.Size(177, 28);
            this.txtSearchBox.TabIndex = 13;
            // 
            // panelDataGridView
            // 
            this.panelDataGridView.AutoScroll = true;
            this.panelDataGridView.Controls.Add(this.dgSavingsType);
            this.panelDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDataGridView.Location = new System.Drawing.Point(0, 89);
            this.panelDataGridView.Name = "panelDataGridView";
            this.panelDataGridView.Size = new System.Drawing.Size(834, 202);
            this.panelDataGridView.TabIndex = 3;
            // 
            // dgSavingsType
            // 
            this.dgSavingsType.AllowUserToAddRows = false;
            this.dgSavingsType.AllowUserToDeleteRows = false;
            this.dgSavingsType.AllowUserToResizeColumns = false;
            this.dgSavingsType.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgSavingsType.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgSavingsType.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.dgSavingsType.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgSavingsType.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgSavingsType.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgSavingsType.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgSavingsType.ColumnHeadersHeight = 28;
            this.dgSavingsType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgSavingsType.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgSavingsType.Location = new System.Drawing.Point(12, 0);
            this.dgSavingsType.Name = "dgSavingsType";
            this.dgSavingsType.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgSavingsType.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgSavingsType.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgSavingsType.RowTemplate.Height = 25;
            this.dgSavingsType.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgSavingsType.Size = new System.Drawing.Size(810, 199);
            this.dgSavingsType.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 291);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(834, 270);
            this.panel1.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(810, 252);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Savings Type Information";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.chkWithdrawalLimit);
            this.panel2.Controls.Add(this.rbtnInactive);
            this.panel2.Controls.Add(this.rbtnPercentage);
            this.panel2.Controls.Add(this.rbtnActive);
            this.panel2.Controls.Add(this.rbtnFixed);
            this.panel2.Controls.Add(this.cboWithdrawDuration);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtMaxWithdrawal);
            this.panel2.Controls.Add(this.txtNoAccountHolder);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txtInterest);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtMaintainingBalance);
            this.panel2.Controls.Add(this.txtSavingsName);
            this.panel2.Controls.Add(this.btnClear);
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Controls.Add(this.btnUpdate);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(804, 221);
            this.panel2.TabIndex = 11;
            // 
            // chkWithdrawalLimit
            // 
            this.chkWithdrawalLimit.AutoSize = true;
            this.chkWithdrawalLimit.Location = new System.Drawing.Point(234, 141);
            this.chkWithdrawalLimit.Name = "chkWithdrawalLimit";
            this.chkWithdrawalLimit.Size = new System.Drawing.Size(173, 25);
            this.chkWithdrawalLimit.TabIndex = 29;
            this.chkWithdrawalLimit.Text = "No Withdrawal Limit";
            this.chkWithdrawalLimit.UseVisualStyleBackColor = true;
            // 
            // rbtnInactive
            // 
            this.rbtnInactive.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rbtnInactive.AutoSize = true;
            this.rbtnInactive.Font = new System.Drawing.Font("Segoe UI Symbol", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnInactive.Location = new System.Drawing.Point(658, 104);
            this.rbtnInactive.Name = "rbtnInactive";
            this.rbtnInactive.Size = new System.Drawing.Size(78, 24);
            this.rbtnInactive.TabIndex = 23;
            this.rbtnInactive.TabStop = true;
            this.rbtnInactive.Text = "Inactive";
            this.rbtnInactive.UseVisualStyleBackColor = true;
            // 
            // rbtnPercentage
            // 
            this.rbtnPercentage.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rbtnPercentage.AutoSize = true;
            this.rbtnPercentage.Font = new System.Drawing.Font("Segoe UI Symbol", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnPercentage.Location = new System.Drawing.Point(658, 74);
            this.rbtnPercentage.Name = "rbtnPercentage";
            this.rbtnPercentage.Size = new System.Drawing.Size(101, 24);
            this.rbtnPercentage.TabIndex = 23;
            this.rbtnPercentage.TabStop = true;
            this.rbtnPercentage.Text = "Percentage";
            this.rbtnPercentage.UseVisualStyleBackColor = true;
            // 
            // rbtnActive
            // 
            this.rbtnActive.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rbtnActive.AutoSize = true;
            this.rbtnActive.Font = new System.Drawing.Font("Segoe UI Symbol", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnActive.Location = new System.Drawing.Point(584, 104);
            this.rbtnActive.Name = "rbtnActive";
            this.rbtnActive.Size = new System.Drawing.Size(68, 24);
            this.rbtnActive.TabIndex = 24;
            this.rbtnActive.TabStop = true;
            this.rbtnActive.Text = "Active";
            this.rbtnActive.UseVisualStyleBackColor = true;
            // 
            // rbtnFixed
            // 
            this.rbtnFixed.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rbtnFixed.AutoSize = true;
            this.rbtnFixed.Font = new System.Drawing.Font("Segoe UI Symbol", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnFixed.Location = new System.Drawing.Point(584, 74);
            this.rbtnFixed.Name = "rbtnFixed";
            this.rbtnFixed.Size = new System.Drawing.Size(62, 24);
            this.rbtnFixed.TabIndex = 24;
            this.rbtnFixed.TabStop = true;
            this.rbtnFixed.Text = "Fixed";
            this.rbtnFixed.UseVisualStyleBackColor = true;
            // 
            // cboWithdrawDuration
            // 
            this.cboWithdrawDuration.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboWithdrawDuration.Font = new System.Drawing.Font("Segoe UI Symbol", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboWithdrawDuration.FormattingEnabled = true;
            this.cboWithdrawDuration.Location = new System.Drawing.Point(237, 106);
            this.cboWithdrawDuration.Name = "cboWithdrawDuration";
            this.cboWithdrawDuration.Size = new System.Drawing.Size(177, 28);
            this.cboWithdrawDuration.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Light", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(52, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(176, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Withdraw Transaction Limit:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Light", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(66, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Max. Withdrawal Amount:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Light", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(74, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "No. of Account Holders:";
            // 
            // txtMaxWithdrawal
            // 
            this.txtMaxWithdrawal.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtMaxWithdrawal.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtMaxWithdrawal.Font = new System.Drawing.Font("Segoe UI Symbol", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaxWithdrawal.Location = new System.Drawing.Point(237, 73);
            this.txtMaxWithdrawal.Name = "txtMaxWithdrawal";
            this.txtMaxWithdrawal.Size = new System.Drawing.Size(177, 27);
            this.txtMaxWithdrawal.TabIndex = 9;
            // 
            // txtNoAccountHolder
            // 
            this.txtNoAccountHolder.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNoAccountHolder.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtNoAccountHolder.Font = new System.Drawing.Font("Segoe UI Symbol", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoAccountHolder.Location = new System.Drawing.Point(237, 40);
            this.txtNoAccountHolder.Name = "txtNoAccountHolder";
            this.txtNoAccountHolder.Size = new System.Drawing.Size(177, 27);
            this.txtNoAccountHolder.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(530, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Status:";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Light", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(489, 43);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "Interest Rate:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Light", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(443, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 20);
            this.label7.TabIndex = 19;
            this.label7.Text = "Maintaining Balance:";
            // 
            // txtInterest
            // 
            this.txtInterest.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtInterest.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtInterest.Font = new System.Drawing.Font("Segoe UI Symbol", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInterest.Location = new System.Drawing.Point(584, 40);
            this.txtInterest.Name = "txtInterest";
            this.txtInterest.Size = new System.Drawing.Size(177, 27);
            this.txtInterest.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Light", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(97, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "Savings Type Name:";
            // 
            // txtMaintainingBalance
            // 
            this.txtMaintainingBalance.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtMaintainingBalance.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtMaintainingBalance.Font = new System.Drawing.Font("Segoe UI Symbol", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaintainingBalance.Location = new System.Drawing.Point(584, 7);
            this.txtMaintainingBalance.Name = "txtMaintainingBalance";
            this.txtMaintainingBalance.Size = new System.Drawing.Size(177, 27);
            this.txtMaintainingBalance.TabIndex = 12;
            // 
            // txtSavingsName
            // 
            this.txtSavingsName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSavingsName.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtSavingsName.Font = new System.Drawing.Font("Segoe UI Symbol", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSavingsName.Location = new System.Drawing.Point(237, 7);
            this.txtSavingsName.Name = "txtSavingsName";
            this.txtSavingsName.Size = new System.Drawing.Size(177, 27);
            this.txtSavingsName.TabIndex = 13;
            // 
            // btnClear
            // 
            this.btnClear.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnClear.BackColor = System.Drawing.Color.Red;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnClear.Location = new System.Drawing.Point(466, 174);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(98, 35);
            this.btnClear.TabIndex = 25;
            this.btnClear.Text = "Clear";
            this.btnClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAdd.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAdd.Location = new System.Drawing.Point(258, 174);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(98, 35);
            this.btnAdd.TabIndex = 26;
            this.btnAdd.Text = "Add";
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnUpdate.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnUpdate.Location = new System.Drawing.Point(362, 174);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(98, 35);
            this.btnUpdate.TabIndex = 27;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // MaintenanceSavingsTypeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(834, 561);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelDataGridView);
            this.Controls.Add(this.panelSearch);
            this.Controls.Add(this.panelSavingsTypeTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MaintenanceSavingsTypeView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Savings Type";
            this.panelSavingsTypeTitle.ResumeLayout(false);
            this.panelSavingsTypeTitle.PerformLayout();
            this.panelSearch.ResumeLayout(false);
            this.panelSearch.PerformLayout();
            this.panelDataGridView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgSavingsType)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSavingsTypeTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cboFilter;
        private System.Windows.Forms.TextBox txtSearchBox;
        private System.Windows.Forms.Panel panelDataGridView;
        private System.Windows.Forms.DataGridView dgSavingsType;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox chkWithdrawalLimit;
        private System.Windows.Forms.RadioButton rbtnPercentage;
        private System.Windows.Forms.RadioButton rbtnFixed;
        private System.Windows.Forms.ComboBox cboWithdrawDuration;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaxWithdrawal;
        private System.Windows.Forms.TextBox txtNoAccountHolder;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtInterest;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaintainingBalance;
        private System.Windows.Forms.TextBox txtSavingsName;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.RadioButton rbtnInactive;
        private System.Windows.Forms.RadioButton rbtnActive;
        private System.Windows.Forms.Label label2;


    }
}