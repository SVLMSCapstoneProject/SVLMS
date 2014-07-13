namespace SVLMS.Loaning.View
{
    partial class MaintenanceLoanRates
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
            this.LoanRates = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.GracePeriod = new System.Windows.Forms.Label();
            this.Interval = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cboLoanType = new System.Windows.Forms.ComboBox();
            this.cboIsPercentageShare = new System.Windows.Forms.ComboBox();
            this.cboIsPercentageInterest = new System.Windows.Forms.ComboBox();
            this.txtShareRate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.statusPanel = new System.Windows.Forms.Panel();
            this.rbtnInactive = new System.Windows.Forms.RadioButton();
            this.rbtnActive = new System.Windows.Forms.RadioButton();
            this.label16 = new System.Windows.Forms.Label();
            this.dtpEffectivity = new System.Windows.Forms.DateTimePicker();
            this.label17 = new System.Windows.Forms.Label();
            this.txtInterestRate = new System.Windows.Forms.TextBox();
            this.lblRate = new System.Windows.Forms.Label();
            this.dgLoanRates = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearchBox = new System.Windows.Forms.TextBox();
            this.cboFilter = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.panelSavingsTypeTitle.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.statusPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgLoanRates)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSavingsTypeTitle
            // 
            this.panelSavingsTypeTitle.BackColor = System.Drawing.Color.RoyalBlue;
            this.panelSavingsTypeTitle.Controls.Add(this.LoanRates);
            this.panelSavingsTypeTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSavingsTypeTitle.Location = new System.Drawing.Point(0, 0);
            this.panelSavingsTypeTitle.Name = "panelSavingsTypeTitle";
            this.panelSavingsTypeTitle.Size = new System.Drawing.Size(685, 56);
            this.panelSavingsTypeTitle.TabIndex = 187;
            // 
            // LoanRates
            // 
            this.LoanRates.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LoanRates.AutoSize = true;
            this.LoanRates.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoanRates.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.LoanRates.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LoanRates.ImeMode = System.Windows.Forms.ImeMode.On;
            this.LoanRates.Location = new System.Drawing.Point(7, 9);
            this.LoanRates.Name = "LoanRates";
            this.LoanRates.Size = new System.Drawing.Size(218, 25);
            this.LoanRates.TabIndex = 0;
            this.LoanRates.Text = "Loan Rates Maintenance";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.GracePeriod);
            this.groupBox1.Controls.Add(this.Interval);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cboLoanType);
            this.groupBox1.Controls.Add(this.cboIsPercentageShare);
            this.groupBox1.Controls.Add(this.cboIsPercentageInterest);
            this.groupBox1.Controls.Add(this.txtShareRate);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.statusPanel);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.dtpEffectivity);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.txtInterestRate);
            this.groupBox1.Controls.Add(this.lblRate);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.groupBox1.Location = new System.Drawing.Point(12, 329);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(660, 266);
            this.groupBox1.TabIndex = 192;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Loan Rate Information";
            // 
            // GracePeriod
            // 
            this.GracePeriod.AutoSize = true;
            this.GracePeriod.BackColor = System.Drawing.Color.Red;
            this.GracePeriod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GracePeriod.ForeColor = System.Drawing.SystemColors.Window;
            this.GracePeriod.Location = new System.Drawing.Point(615, 99);
            this.GracePeriod.Name = "GracePeriod";
            this.GracePeriod.Size = new System.Drawing.Size(17, 16);
            this.GracePeriod.TabIndex = 196;
            this.GracePeriod.Text = "X";
            this.GracePeriod.Visible = false;
            // 
            // Interval
            // 
            this.Interval.AutoSize = true;
            this.Interval.BackColor = System.Drawing.Color.Red;
            this.Interval.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Interval.ForeColor = System.Drawing.SystemColors.Window;
            this.Interval.Location = new System.Drawing.Point(615, 67);
            this.Interval.Name = "Interval";
            this.Interval.Size = new System.Drawing.Size(17, 16);
            this.Interval.TabIndex = 195;
            this.Interval.Text = "X";
            this.Interval.Visible = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnUpdate.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnUpdate.ImeMode = System.Windows.Forms.ImeMode.On;
            this.btnUpdate.Location = new System.Drawing.Point(289, 209);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(98, 35);
            this.btnUpdate.TabIndex = 219;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            this.btnClear.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnClear.BackColor = System.Drawing.Color.Red;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnClear.ImeMode = System.Windows.Forms.ImeMode.On;
            this.btnClear.Location = new System.Drawing.Point(393, 209);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(98, 35);
            this.btnClear.TabIndex = 217;
            this.btnClear.Text = "Clear";
            this.btnClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSave.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSave.ImeMode = System.Windows.Forms.ImeMode.On;
            this.btnSave.Location = new System.Drawing.Point(185, 209);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(98, 35);
            this.btnSave.TabIndex = 218;
            this.btnSave.Text = "Add";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Light", 11.25F);
            this.label4.ImeMode = System.Windows.Forms.ImeMode.On;
            this.label4.Location = new System.Drawing.Point(84, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 20);
            this.label4.TabIndex = 198;
            this.label4.Text = "Loan Type:";
            // 
            // cboLoanType
            // 
            this.cboLoanType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoanType.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F);
            this.cboLoanType.FormattingEnabled = true;
            this.cboLoanType.Items.AddRange(new object[] {
            "Fixed",
            "Percentage"});
            this.cboLoanType.Location = new System.Drawing.Point(214, 29);
            this.cboLoanType.Name = "cboLoanType";
            this.cboLoanType.Size = new System.Drawing.Size(190, 28);
            this.cboLoanType.TabIndex = 197;
            // 
            // cboIsPercentageShare
            // 
            this.cboIsPercentageShare.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboIsPercentageShare.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F);
            this.cboIsPercentageShare.FormattingEnabled = true;
            this.cboIsPercentageShare.Items.AddRange(new object[] {
            "Fixed",
            "Percentage"});
            this.cboIsPercentageShare.Location = new System.Drawing.Point(416, 93);
            this.cboIsPercentageShare.Name = "cboIsPercentageShare";
            this.cboIsPercentageShare.Size = new System.Drawing.Size(193, 28);
            this.cboIsPercentageShare.TabIndex = 196;
            // 
            // cboIsPercentageInterest
            // 
            this.cboIsPercentageInterest.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboIsPercentageInterest.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F);
            this.cboIsPercentageInterest.FormattingEnabled = true;
            this.cboIsPercentageInterest.Items.AddRange(new object[] {
            "Fixed",
            "Percentage"});
            this.cboIsPercentageInterest.Location = new System.Drawing.Point(416, 61);
            this.cboIsPercentageInterest.Name = "cboIsPercentageInterest";
            this.cboIsPercentageInterest.Size = new System.Drawing.Size(193, 28);
            this.cboIsPercentageInterest.TabIndex = 195;
            // 
            // txtShareRate
            // 
            this.txtShareRate.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F);
            this.txtShareRate.Location = new System.Drawing.Point(214, 93);
            this.txtShareRate.MaxLength = 8;
            this.txtShareRate.Name = "txtShareRate";
            this.txtShareRate.Size = new System.Drawing.Size(190, 27);
            this.txtShareRate.TabIndex = 193;
            this.txtShareRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtShareRate_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Light", 11.25F);
            this.label3.ImeMode = System.Windows.Forms.ImeMode.On;
            this.label3.Location = new System.Drawing.Point(84, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 20);
            this.label3.TabIndex = 194;
            this.label3.Text = "Share Capital Rate:";
            // 
            // statusPanel
            // 
            this.statusPanel.Controls.Add(this.rbtnInactive);
            this.statusPanel.Controls.Add(this.rbtnActive);
            this.statusPanel.Location = new System.Drawing.Point(213, 158);
            this.statusPanel.Name = "statusPanel";
            this.statusPanel.Size = new System.Drawing.Size(193, 37);
            this.statusPanel.TabIndex = 191;
            // 
            // rbtnInactive
            // 
            this.rbtnInactive.AutoSize = true;
            this.rbtnInactive.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F);
            this.rbtnInactive.ImeMode = System.Windows.Forms.ImeMode.On;
            this.rbtnInactive.Location = new System.Drawing.Point(79, 4);
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
            this.rbtnActive.Location = new System.Drawing.Point(11, 4);
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
            this.label16.Location = new System.Drawing.Point(84, 164);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(48, 20);
            this.label16.TabIndex = 192;
            this.label16.Text = "Status:";
            // 
            // dtpEffectivity
            // 
            this.dtpEffectivity.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F);
            this.dtpEffectivity.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEffectivity.Location = new System.Drawing.Point(213, 126);
            this.dtpEffectivity.Name = "dtpEffectivity";
            this.dtpEffectivity.Size = new System.Drawing.Size(193, 27);
            this.dtpEffectivity.TabIndex = 188;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI Light", 11.25F);
            this.label17.ImeMode = System.Windows.Forms.ImeMode.On;
            this.label17.Location = new System.Drawing.Point(84, 132);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(104, 20);
            this.label17.TabIndex = 187;
            this.label17.Text = "Effectivity Date:";
            // 
            // txtInterestRate
            // 
            this.txtInterestRate.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F);
            this.txtInterestRate.Location = new System.Drawing.Point(214, 61);
            this.txtInterestRate.MaxLength = 8;
            this.txtInterestRate.Name = "txtInterestRate";
            this.txtInterestRate.Size = new System.Drawing.Size(190, 27);
            this.txtInterestRate.TabIndex = 185;
            this.txtInterestRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInterestRate_KeyPress);
            // 
            // lblRate
            // 
            this.lblRate.AutoSize = true;
            this.lblRate.Font = new System.Drawing.Font("Segoe UI Light", 11.25F);
            this.lblRate.ImeMode = System.Windows.Forms.ImeMode.On;
            this.lblRate.Location = new System.Drawing.Point(84, 68);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(89, 20);
            this.lblRate.TabIndex = 186;
            this.lblRate.Text = "Interest Rate:";
            // 
            // dgLoanRates
            // 
            this.dgLoanRates.AllowUserToAddRows = false;
            this.dgLoanRates.AllowUserToDeleteRows = false;
            this.dgLoanRates.AllowUserToResizeColumns = false;
            this.dgLoanRates.AllowUserToResizeRows = false;
            this.dgLoanRates.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgLoanRates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgLoanRates.Location = new System.Drawing.Point(49, 103);
            this.dgLoanRates.Name = "dgLoanRates";
            this.dgLoanRates.ReadOnly = true;
            this.dgLoanRates.RowHeadersVisible = false;
            this.dgLoanRates.Size = new System.Drawing.Size(581, 220);
            this.dgLoanRates.TabIndex = 190;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panelSavingsTypeTitle);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.dgLoanRates);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(685, 596);
            this.panel1.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.txtSearchBox);
            this.panel3.Controls.Add(this.cboFilter);
            this.panel3.Controls.Add(this.btnSearch);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Location = new System.Drawing.Point(0, 56);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(685, 33);
            this.panel3.TabIndex = 194;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 11F);
            this.label2.ImeMode = System.Windows.Forms.ImeMode.On;
            this.label2.Location = new System.Drawing.Point(390, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 108;
            this.label2.Text = "Search:";
            // 
            // txtSearchBox
            // 
            this.txtSearchBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtSearchBox.Font = new System.Drawing.Font("Segoe UI Symbol", 11F);
            this.txtSearchBox.Location = new System.Drawing.Point(450, 2);
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
            "Incoming Penalty",
            "Archived",
            "No Filter"});
            this.cboFilter.Location = new System.Drawing.Point(66, 2);
            this.cboFilter.Name = "cboFilter";
            this.cboFilter.Size = new System.Drawing.Size(155, 28);
            this.cboFilter.TabIndex = 105;
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
            this.btnSearch.Location = new System.Drawing.Point(621, 2);
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
            // MaintenanceLoanRates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(684, 585);
            this.Controls.Add(this.panel1);
            this.Name = "MaintenanceLoanRates";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MaintenanceLoanRates1";
            this.panelSavingsTypeTitle.ResumeLayout(false);
            this.panelSavingsTypeTitle.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusPanel.ResumeLayout(false);
            this.statusPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgLoanRates)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSavingsTypeTitle;
        private System.Windows.Forms.Label LoanRates;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboLoanType;
        private System.Windows.Forms.ComboBox cboIsPercentageShare;
        private System.Windows.Forms.ComboBox cboIsPercentageInterest;
        private System.Windows.Forms.TextBox txtShareRate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel statusPanel;
        private System.Windows.Forms.RadioButton rbtnInactive;
        private System.Windows.Forms.RadioButton rbtnActive;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DateTimePicker dtpEffectivity;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtInterestRate;
        private System.Windows.Forms.Label lblRate;
        private System.Windows.Forms.DataGridView dgLoanRates;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSearchBox;
        private System.Windows.Forms.ComboBox cboFilter;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label GracePeriod;
        private System.Windows.Forms.Label Interval;
    }
}