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
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.btnClear = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.dtpEffectivity = new System.Windows.Forms.DateTimePicker();
            this.label17 = new System.Windows.Forms.Label();
            this.txtInterestRate = new System.Windows.Forms.TextBox();
            this.lblRate = new System.Windows.Forms.Label();
            this.dgLoanRates = new System.Windows.Forms.DataGridView();
            this.lblTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboFilter = new System.Windows.Forms.ComboBox();
            this.txtSearchBox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.statusPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgLoanRates)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtSearchBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cboFilter);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cboLoanType);
            this.panel1.Controls.Add(this.cboIsPercentageShare);
            this.panel1.Controls.Add(this.cboIsPercentageInterest);
            this.panel1.Controls.Add(this.txtShareRate);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.statusPanel);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.dtpEffectivity);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.txtInterestRate);
            this.panel1.Controls.Add(this.lblRate);
            this.panel1.Controls.Add(this.dgLoanRates);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(659, 295);
            this.panel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(302, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 16);
            this.label4.TabIndex = 170;
            this.label4.Text = "Loan Type:";
            // 
            // cboLoanType
            // 
            this.cboLoanType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoanType.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLoanType.FormattingEnabled = true;
            this.cboLoanType.Items.AddRange(new object[] {
            "Fixed",
            "Percentage"});
            this.cboLoanType.Location = new System.Drawing.Point(423, 85);
            this.cboLoanType.Name = "cboLoanType";
            this.cboLoanType.Size = new System.Drawing.Size(112, 24);
            this.cboLoanType.TabIndex = 169;
            // 
            // cboIsPercentageShare
            // 
            this.cboIsPercentageShare.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboIsPercentageShare.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboIsPercentageShare.FormattingEnabled = true;
            this.cboIsPercentageShare.Items.AddRange(new object[] {
            "Fixed",
            "Percentage"});
            this.cboIsPercentageShare.Location = new System.Drawing.Point(542, 138);
            this.cboIsPercentageShare.Name = "cboIsPercentageShare";
            this.cboIsPercentageShare.Size = new System.Drawing.Size(102, 24);
            this.cboIsPercentageShare.TabIndex = 168;
            // 
            // cboIsPercentageInterest
            // 
            this.cboIsPercentageInterest.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboIsPercentageInterest.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboIsPercentageInterest.FormattingEnabled = true;
            this.cboIsPercentageInterest.Items.AddRange(new object[] {
            "Fixed",
            "Percentage"});
            this.cboIsPercentageInterest.Location = new System.Drawing.Point(542, 112);
            this.cboIsPercentageInterest.Name = "cboIsPercentageInterest";
            this.cboIsPercentageInterest.Size = new System.Drawing.Size(102, 24);
            this.cboIsPercentageInterest.TabIndex = 166;
            // 
            // txtShareRate
            // 
            this.txtShareRate.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtShareRate.Location = new System.Drawing.Point(423, 140);
            this.txtShareRate.MaxLength = 8;
            this.txtShareRate.Name = "txtShareRate";
            this.txtShareRate.Size = new System.Drawing.Size(112, 22);
            this.txtShareRate.TabIndex = 163;
            this.txtShareRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtShareRate_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(302, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 16);
            this.label3.TabIndex = 165;
            this.label3.Text = "Share Capital Rate:";
            // 
            // statusPanel
            // 
            this.statusPanel.Controls.Add(this.rbtnInactive);
            this.statusPanel.Controls.Add(this.rbtnActive);
            this.statusPanel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusPanel.Location = new System.Drawing.Point(420, 191);
            this.statusPanel.Name = "statusPanel";
            this.statusPanel.Size = new System.Drawing.Size(149, 24);
            this.statusPanel.TabIndex = 158;
            // 
            // rbtnInactive
            // 
            this.rbtnInactive.AutoSize = true;
            this.rbtnInactive.Location = new System.Drawing.Point(78, 3);
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
            this.label16.Location = new System.Drawing.Point(302, 196);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(50, 16);
            this.label16.TabIndex = 159;
            this.label16.Text = "Status:";
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(494, 227);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 157;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(413, 227);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 154;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(332, 227);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 153;
            this.btnSave.Text = "Add";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // dtpEffectivity
            // 
            this.dtpEffectivity.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEffectivity.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEffectivity.Location = new System.Drawing.Point(423, 166);
            this.dtpEffectivity.Name = "dtpEffectivity";
            this.dtpEffectivity.Size = new System.Drawing.Size(112, 22);
            this.dtpEffectivity.TabIndex = 152;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(302, 171);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(98, 16);
            this.label17.TabIndex = 151;
            this.label17.Text = "Effectivity Date:";
            // 
            // txtInterestRate
            // 
            this.txtInterestRate.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInterestRate.Location = new System.Drawing.Point(423, 114);
            this.txtInterestRate.MaxLength = 8;
            this.txtInterestRate.Name = "txtInterestRate";
            this.txtInterestRate.Size = new System.Drawing.Size(112, 22);
            this.txtInterestRate.TabIndex = 148;
            this.txtInterestRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInterestRate_KeyPress);
            // 
            // lblRate
            // 
            this.lblRate.AutoSize = true;
            this.lblRate.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRate.Location = new System.Drawing.Point(302, 115);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(86, 16);
            this.lblRate.TabIndex = 150;
            this.lblRate.Text = "Interest Rate:";
            // 
            // dgLoanRates
            // 
            this.dgLoanRates.AllowUserToAddRows = false;
            this.dgLoanRates.AllowUserToDeleteRows = false;
            this.dgLoanRates.AllowUserToResizeColumns = false;
            this.dgLoanRates.AllowUserToResizeRows = false;
            this.dgLoanRates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgLoanRates.Location = new System.Drawing.Point(11, 85);
            this.dgLoanRates.Name = "dgLoanRates";
            this.dgLoanRates.ReadOnly = true;
            this.dgLoanRates.Size = new System.Drawing.Size(289, 190);
            this.dgLoanRates.TabIndex = 147;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(11, 22);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(283, 29);
            this.lblTitle.TabIndex = 146;
            this.lblTitle.Text = "Maintenance: Loan Rates";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 172;
            this.label1.Text = "Filter:";
            // 
            // cboFilter
            // 
            this.cboFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFilter.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboFilter.FormattingEnabled = true;
            this.cboFilter.Items.AddRange(new object[] {
            "Incoming Rates",
            "Archived",
            "No Filter"});
            this.cboFilter.Location = new System.Drawing.Point(70, 56);
            this.cboFilter.Name = "cboFilter";
            this.cboFilter.Size = new System.Drawing.Size(112, 24);
            this.cboFilter.TabIndex = 171;
            // 
            // txtSearchBox
            // 
            this.txtSearchBox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchBox.Location = new System.Drawing.Point(188, 57);
            this.txtSearchBox.MaxLength = 8;
            this.txtSearchBox.Name = "txtSearchBox";
            this.txtSearchBox.Size = new System.Drawing.Size(112, 22);
            this.txtSearchBox.TabIndex = 173;
            // 
            // MaintenanceLoanRates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(659, 298);
            this.Controls.Add(this.panel1);
            this.Name = "MaintenanceLoanRates";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loan Rates";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.statusPanel.ResumeLayout(false);
            this.statusPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgLoanRates)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DateTimePicker dtpEffectivity;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtInterestRate;
        private System.Windows.Forms.Label lblRate;
        private System.Windows.Forms.DataGridView dgLoanRates;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Panel statusPanel;
        private System.Windows.Forms.RadioButton rbtnInactive;
        private System.Windows.Forms.RadioButton rbtnActive;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtShareRate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboIsPercentageInterest;
        private System.Windows.Forms.ComboBox cboIsPercentageShare;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboLoanType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboFilter;
        private System.Windows.Forms.TextBox txtSearchBox;

    }
}