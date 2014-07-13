namespace SVLMS.Savings.View
{
    partial class MaintenanceTimeDeposit
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
            this.label5 = new System.Windows.Forms.Label();
            this.cboFilter = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.txtMaximumBracket = new System.Windows.Forms.TextBox();
            this.dgTimeDeposit = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMinimumBracket = new System.Windows.Forms.TextBox();
            this.cboSortBy = new System.Windows.Forms.ComboBox();
            this.statusPanel = new System.Windows.Forms.Panel();
            this.rbtnInactive = new System.Windows.Forms.RadioButton();
            this.rbtnActive = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtInterestRate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNoOfDays = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgTimeDeposit)).BeginInit();
            this.statusPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cboFilter);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.txtMaximumBracket);
            this.panel1.Controls.Add(this.dgTimeDeposit);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtMinimumBracket);
            this.panel1.Controls.Add(this.cboSortBy);
            this.panel1.Controls.Add(this.statusPanel);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtInterestRate);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtNoOfDays);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(4, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(685, 292);
            this.panel1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 16);
            this.label5.TabIndex = 184;
            this.label5.Text = "Filter:";
            // 
            // cboFilter
            // 
            this.cboFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFilter.FormattingEnabled = true;
            this.cboFilter.Items.AddRange(new object[] {
            "No Filter",
            "Active",
            "Inactive"});
            this.cboFilter.Location = new System.Drawing.Point(89, 52);
            this.cboFilter.Name = "cboFilter";
            this.cboFilter.Size = new System.Drawing.Size(111, 24);
            this.cboFilter.TabIndex = 185;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(208, 79);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(132, 22);
            this.txtSearch.TabIndex = 183;
            // 
            // txtMaximumBracket
            // 
            this.txtMaximumBracket.Location = new System.Drawing.Point(575, 107);
            this.txtMaximumBracket.MaxLength = 8;
            this.txtMaximumBracket.Name = "txtMaximumBracket";
            this.txtMaximumBracket.Size = new System.Drawing.Size(100, 22);
            this.txtMaximumBracket.TabIndex = 170;
            this.txtMaximumBracket.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaximumBracket_KeyPress);
            // 
            // dgTimeDeposit
            // 
            this.dgTimeDeposit.AllowUserToAddRows = false;
            this.dgTimeDeposit.AllowUserToDeleteRows = false;
            this.dgTimeDeposit.AllowUserToResizeColumns = false;
            this.dgTimeDeposit.AllowUserToResizeRows = false;
            this.dgTimeDeposit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTimeDeposit.Location = new System.Drawing.Point(17, 107);
            this.dgTimeDeposit.MultiSelect = false;
            this.dgTimeDeposit.Name = "dgTimeDeposit";
            this.dgTimeDeposit.ReadOnly = true;
            this.dgTimeDeposit.Size = new System.Drawing.Size(323, 169);
            this.dgTimeDeposit.TabIndex = 164;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(355, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 16);
            this.label3.TabIndex = 167;
            this.label3.Text = "From";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 16);
            this.label6.TabIndex = 160;
            this.label6.Text = "Sort By:";
            // 
            // txtMinimumBracket
            // 
            this.txtMinimumBracket.Location = new System.Drawing.Point(446, 107);
            this.txtMinimumBracket.MaxLength = 8;
            this.txtMinimumBracket.Name = "txtMinimumBracket";
            this.txtMinimumBracket.Size = new System.Drawing.Size(100, 22);
            this.txtMinimumBracket.TabIndex = 168;
            this.txtMinimumBracket.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMinimumBracket_KeyPress);
            // 
            // cboSortBy
            // 
            this.cboSortBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSortBy.FormattingEnabled = true;
            this.cboSortBy.Items.AddRange(new object[] {
            "All",
            "Days",
            "Bracket"});
            this.cboSortBy.Location = new System.Drawing.Point(89, 79);
            this.cboSortBy.Name = "cboSortBy";
            this.cboSortBy.Size = new System.Drawing.Size(111, 24);
            this.cboSortBy.TabIndex = 161;
            // 
            // statusPanel
            // 
            this.statusPanel.Controls.Add(this.rbtnInactive);
            this.statusPanel.Controls.Add(this.rbtnActive);
            this.statusPanel.Location = new System.Drawing.Point(446, 189);
            this.statusPanel.Name = "statusPanel";
            this.statusPanel.Size = new System.Drawing.Size(144, 29);
            this.statusPanel.TabIndex = 182;
            // 
            // rbtnInactive
            // 
            this.rbtnInactive.AutoSize = true;
            this.rbtnInactive.Location = new System.Drawing.Point(64, 3);
            this.rbtnInactive.Name = "rbtnInactive";
            this.rbtnInactive.Size = new System.Drawing.Size(69, 20);
            this.rbtnInactive.TabIndex = 180;
            this.rbtnInactive.TabStop = true;
            this.rbtnInactive.Text = "Inactive";
            this.rbtnInactive.UseVisualStyleBackColor = true;
            // 
            // rbtnActive
            // 
            this.rbtnActive.AutoSize = true;
            this.rbtnActive.Location = new System.Drawing.Point(3, 3);
            this.rbtnActive.Name = "rbtnActive";
            this.rbtnActive.Size = new System.Drawing.Size(61, 20);
            this.rbtnActive.TabIndex = 179;
            this.rbtnActive.TabStop = true;
            this.rbtnActive.Text = "Active";
            this.rbtnActive.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(346, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Maintenance: Terms and Rates";
            // 
            // txtInterestRate
            // 
            this.txtInterestRate.Location = new System.Drawing.Point(446, 161);
            this.txtInterestRate.MaxLength = 4;
            this.txtInterestRate.Name = "txtInterestRate";
            this.txtInterestRate.Size = new System.Drawing.Size(100, 22);
            this.txtInterestRate.TabIndex = 175;
            this.txtInterestRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInterestRate_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(355, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 16);
            this.label2.TabIndex = 165;
            this.label2.Text = "No. Of Days:";
            // 
            // txtNoOfDays
            // 
            this.txtNoOfDays.Location = new System.Drawing.Point(446, 134);
            this.txtNoOfDays.MaxLength = 4;
            this.txtNoOfDays.Name = "txtNoOfDays";
            this.txtNoOfDays.Size = new System.Drawing.Size(100, 22);
            this.txtNoOfDays.TabIndex = 166;
            this.txtNoOfDays.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNoOfDays_KeyPress);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(471, 238);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 177;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(355, 164);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 16);
            this.label8.TabIndex = 176;
            this.label8.Text = "Interest Rate:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(355, 192);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 16);
            this.label9.TabIndex = 178;
            this.label9.Text = "Status:";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(552, 238);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 181;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(550, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 16);
            this.label4.TabIndex = 169;
            this.label4.Text = "to";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(386, 238);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 171;
            this.btnSave.Text = "Add";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // MaintenanceTimeDeposit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(693, 295);
            this.Controls.Add(this.panel1);
            this.MinimizeBox = false;
            this.Name = "MaintenanceTimeDeposit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Time Deposit Terms and Rates";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgTimeDeposit)).EndInit();
            this.statusPanel.ResumeLayout(false);
            this.statusPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgTimeDeposit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboSortBy;
        private System.Windows.Forms.TextBox txtMaximumBracket;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMinimumBracket;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNoOfDays;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtInterestRate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton rbtnActive;
        private System.Windows.Forms.RadioButton rbtnInactive;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Panel statusPanel;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboFilter;
    }
}