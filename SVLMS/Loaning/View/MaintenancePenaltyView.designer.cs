namespace SVLMS.Loaning.View
{
    partial class MaintenancePenaltyView
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
            this.panelSavingsTypeTitle = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dgPenalty = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.PercentagePanel = new System.Windows.Forms.Panel();
            this.rbtnPercentage = new System.Windows.Forms.RadioButton();
            this.rbtnFixed = new System.Windows.Forms.RadioButton();
            this.StatusPanel = new System.Windows.Forms.Panel();
            this.rbtnInactive = new System.Windows.Forms.RadioButton();
            this.rbtnActive = new System.Windows.Forms.RadioButton();
            this.label16 = new System.Windows.Forms.Label();
            this.dtpEffectivityDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.cboInterval = new System.Windows.Forms.ComboBox();
            this.cboGracePeriod = new System.Windows.Forms.ComboBox();
            this.txtGracePeriod = new System.Windows.Forms.TextBox();
            this.txtInterval = new System.Windows.Forms.TextBox();
            this.txtPenaltyRate = new System.Windows.Forms.TextBox();
            this.cboLoanType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.cboFilter = new System.Windows.Forms.ComboBox();
            this.txtSearchBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panelSavingsTypeTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPenalty)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.PercentagePanel.SuspendLayout();
            this.StatusPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSavingsTypeTitle
            // 
            this.panelSavingsTypeTitle.BackColor = System.Drawing.Color.RoyalBlue;
            this.panelSavingsTypeTitle.Controls.Add(this.label1);
            this.panelSavingsTypeTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSavingsTypeTitle.Location = new System.Drawing.Point(0, 0);
            this.panelSavingsTypeTitle.Name = "panelSavingsTypeTitle";
            this.panelSavingsTypeTitle.Size = new System.Drawing.Size(685, 56);
            this.panelSavingsTypeTitle.TabIndex = 99;
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
            this.label1.Size = new System.Drawing.Size(189, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Penalty Maintenance";
            // 
            // dgPenalty
            // 
            this.dgPenalty.AllowUserToAddRows = false;
            this.dgPenalty.AllowUserToDeleteRows = false;
            this.dgPenalty.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgPenalty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPenalty.Location = new System.Drawing.Point(25, 101);
            this.dgPenalty.Name = "dgPenalty";
            this.dgPenalty.ReadOnly = true;
            this.dgPenalty.Size = new System.Drawing.Size(632, 210);
            this.dgPenalty.TabIndex = 101;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.PercentagePanel);
            this.groupBox1.Controls.Add(this.StatusPanel);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.dtpEffectivityDate);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cboInterval);
            this.groupBox1.Controls.Add(this.cboGracePeriod);
            this.groupBox1.Controls.Add(this.txtGracePeriod);
            this.groupBox1.Controls.Add(this.txtInterval);
            this.groupBox1.Controls.Add(this.txtPenaltyRate);
            this.groupBox1.Controls.Add(this.cboLoanType);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(23, 317);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(632, 294);
            this.groupBox1.TabIndex = 102;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Penalty Information";
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
            this.btnUpdate.Location = new System.Drawing.Point(278, 247);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(98, 35);
            this.btnUpdate.TabIndex = 225;
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
            this.btnClear.Location = new System.Drawing.Point(382, 247);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(98, 35);
            this.btnClear.TabIndex = 223;
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
            this.btnSave.Location = new System.Drawing.Point(174, 247);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(98, 35);
            this.btnSave.TabIndex = 224;
            this.btnSave.Text = "Add";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // PercentagePanel
            // 
            this.PercentagePanel.Controls.Add(this.rbtnPercentage);
            this.PercentagePanel.Controls.Add(this.rbtnFixed);
            this.PercentagePanel.Location = new System.Drawing.Point(394, 64);
            this.PercentagePanel.Name = "PercentagePanel";
            this.PercentagePanel.Size = new System.Drawing.Size(193, 27);
            this.PercentagePanel.TabIndex = 149;
            // 
            // rbtnPercentage
            // 
            this.rbtnPercentage.AutoSize = true;
            this.rbtnPercentage.Location = new System.Drawing.Point(72, 2);
            this.rbtnPercentage.Name = "rbtnPercentage";
            this.rbtnPercentage.Size = new System.Drawing.Size(101, 24);
            this.rbtnPercentage.TabIndex = 72;
            this.rbtnPercentage.TabStop = true;
            this.rbtnPercentage.Text = "Percentage";
            this.rbtnPercentage.UseVisualStyleBackColor = true;
            // 
            // rbtnFixed
            // 
            this.rbtnFixed.AutoSize = true;
            this.rbtnFixed.Location = new System.Drawing.Point(10, 2);
            this.rbtnFixed.Name = "rbtnFixed";
            this.rbtnFixed.Size = new System.Drawing.Size(62, 24);
            this.rbtnFixed.TabIndex = 64;
            this.rbtnFixed.TabStop = true;
            this.rbtnFixed.Text = "Fixed";
            this.rbtnFixed.UseVisualStyleBackColor = true;
            // 
            // StatusPanel
            // 
            this.StatusPanel.Controls.Add(this.rbtnInactive);
            this.StatusPanel.Controls.Add(this.rbtnActive);
            this.StatusPanel.Location = new System.Drawing.Point(190, 200);
            this.StatusPanel.Name = "StatusPanel";
            this.StatusPanel.Size = new System.Drawing.Size(192, 29);
            this.StatusPanel.TabIndex = 147;
            // 
            // rbtnInactive
            // 
            this.rbtnInactive.AutoSize = true;
            this.rbtnInactive.Location = new System.Drawing.Point(78, 3);
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
            this.rbtnActive.Location = new System.Drawing.Point(10, 3);
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
            this.label16.Location = new System.Drawing.Point(62, 202);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(52, 20);
            this.label16.TabIndex = 148;
            this.label16.Text = "Status:";
            // 
            // dtpEffectivityDate
            // 
            this.dtpEffectivityDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEffectivityDate.Location = new System.Drawing.Point(190, 166);
            this.dtpEffectivityDate.Name = "dtpEffectivityDate";
            this.dtpEffectivityDate.Size = new System.Drawing.Size(192, 27);
            this.dtpEffectivityDate.TabIndex = 146;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(61, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 20);
            this.label5.TabIndex = 145;
            this.label5.Text = "Effectivity Date:";
            // 
            // cboInterval
            // 
            this.cboInterval.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboInterval.FormattingEnabled = true;
            this.cboInterval.Items.AddRange(new object[] {
            "Days",
            "Weeks",
            "Months",
            "Years"});
            this.cboInterval.Location = new System.Drawing.Point(394, 132);
            this.cboInterval.Name = "cboInterval";
            this.cboInterval.Size = new System.Drawing.Size(193, 28);
            this.cboInterval.TabIndex = 144;
            // 
            // cboGracePeriod
            // 
            this.cboGracePeriod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGracePeriod.FormattingEnabled = true;
            this.cboGracePeriod.Items.AddRange(new object[] {
            "Days",
            "Weeks",
            "Months",
            "Years"});
            this.cboGracePeriod.Location = new System.Drawing.Point(394, 98);
            this.cboGracePeriod.Name = "cboGracePeriod";
            this.cboGracePeriod.Size = new System.Drawing.Size(193, 28);
            this.cboGracePeriod.TabIndex = 142;
            // 
            // txtGracePeriod
            // 
            this.txtGracePeriod.Location = new System.Drawing.Point(190, 98);
            this.txtGracePeriod.MaxLength = 4;
            this.txtGracePeriod.Name = "txtGracePeriod";
            this.txtGracePeriod.Size = new System.Drawing.Size(192, 27);
            this.txtGracePeriod.TabIndex = 141;
            this.txtGracePeriod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGracePeriod_KeyPress);
            // 
            // txtInterval
            // 
            this.txtInterval.Location = new System.Drawing.Point(189, 132);
            this.txtInterval.MaxLength = 4;
            this.txtInterval.Name = "txtInterval";
            this.txtInterval.Size = new System.Drawing.Size(192, 27);
            this.txtInterval.TabIndex = 143;
            this.txtInterval.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInterval_KeyPress);
            // 
            // txtPenaltyRate
            // 
            this.txtPenaltyRate.Location = new System.Drawing.Point(190, 64);
            this.txtPenaltyRate.MaxLength = 15;
            this.txtPenaltyRate.Name = "txtPenaltyRate";
            this.txtPenaltyRate.Size = new System.Drawing.Size(192, 27);
            this.txtPenaltyRate.TabIndex = 138;
            this.txtPenaltyRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPenaltyRate_KeyPress);
            // 
            // cboLoanType
            // 
            this.cboLoanType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoanType.FormattingEnabled = true;
            this.cboLoanType.Location = new System.Drawing.Point(190, 29);
            this.cboLoanType.Name = "cboLoanType";
            this.cboLoanType.Size = new System.Drawing.Size(192, 28);
            this.cboLoanType.TabIndex = 136;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 140;
            this.label4.Text = "Fine Every:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 20);
            this.label3.TabIndex = 139;
            this.label3.Text = "Grace Period:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(61, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 20);
            this.label6.TabIndex = 137;
            this.label6.Text = "Penalty Rate:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(61, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 20);
            this.label7.TabIndex = 135;
            this.label7.Text = "Loan Type:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.cboFilter);
            this.panel1.Controls.Add(this.txtSearchBox);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(0, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(685, 34);
            this.panel1.TabIndex = 103;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Light", 11F);
            this.label9.ImeMode = System.Windows.Forms.ImeMode.On;
            this.label9.Location = new System.Drawing.Point(385, 7);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 20);
            this.label9.TabIndex = 108;
            this.label9.Text = "Search:";
            // 
            // cboFilter
            // 
            this.cboFilter.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cboFilter.Font = new System.Drawing.Font("Segoe UI Symbol", 11F);
            this.cboFilter.FormattingEnabled = true;
            this.cboFilter.Items.AddRange(new object[] {
            "No Filter",
            "Archived",
            "Incoming Penalty"});
            this.cboFilter.Location = new System.Drawing.Point(61, 4);
            this.cboFilter.Name = "cboFilter";
            this.cboFilter.Size = new System.Drawing.Size(155, 28);
            this.cboFilter.TabIndex = 105;
            // 
            // txtSearchBox
            // 
            this.txtSearchBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtSearchBox.Font = new System.Drawing.Font("Segoe UI Symbol", 11F);
            this.txtSearchBox.Location = new System.Drawing.Point(445, 4);
            this.txtSearchBox.Name = "txtSearchBox";
            this.txtSearchBox.Size = new System.Drawing.Size(165, 27);
            this.txtSearchBox.TabIndex = 107;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Light", 11F);
            this.label10.ImeMode = System.Windows.Forms.ImeMode.On;
            this.label10.Location = new System.Drawing.Point(7, 7);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 20);
            this.label10.TabIndex = 104;
            this.label10.Text = "Filters:";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button1.BackColor = System.Drawing.Color.RoyalBlue;
            this.button1.BackgroundImage = global::SVLMS.Properties.Resources.find_icon;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.button1.Location = new System.Drawing.Point(616, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 27);
            this.button1.TabIndex = 106;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // MaintenancePenaltyView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(685, 585);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgPenalty);
            this.Controls.Add(this.panelSavingsTypeTitle);
            this.Name = "MaintenancePenaltyView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MaintenancePenaltyView";
            this.panelSavingsTypeTitle.ResumeLayout(false);
            this.panelSavingsTypeTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPenalty)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.PercentagePanel.ResumeLayout(false);
            this.PercentagePanel.PerformLayout();
            this.StatusPanel.ResumeLayout(false);
            this.StatusPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSavingsTypeTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgPenalty;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel PercentagePanel;
        private System.Windows.Forms.RadioButton rbtnPercentage;
        private System.Windows.Forms.RadioButton rbtnFixed;
        private System.Windows.Forms.Panel StatusPanel;
        private System.Windows.Forms.RadioButton rbtnInactive;
        private System.Windows.Forms.RadioButton rbtnActive;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DateTimePicker dtpEffectivityDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboInterval;
        private System.Windows.Forms.ComboBox cboGracePeriod;
        private System.Windows.Forms.TextBox txtGracePeriod;
        private System.Windows.Forms.TextBox txtInterval;
        private System.Windows.Forms.TextBox txtPenaltyRate;
        private System.Windows.Forms.ComboBox cboLoanType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cboFilter;
        private System.Windows.Forms.TextBox txtSearchBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
    }
}