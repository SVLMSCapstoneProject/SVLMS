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
            this.Duration = new System.Windows.Forms.Label();
            this.NoWithdrawalLimitPanel = new System.Windows.Forms.Panel();
            this.chkWithdrawalLimit = new System.Windows.Forms.CheckBox();
            this.error = new System.Windows.Forms.Label();
            this.txtMaintainingBalance = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNoAccountHolder = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.statusPanel = new System.Windows.Forms.Panel();
            this.rbtnInactive = new System.Windows.Forms.RadioButton();
            this.rbtnActive = new System.Windows.Forms.RadioButton();
            this.percentagePanel = new System.Windows.Forms.Panel();
            this.rbtnPercentage = new System.Windows.Forms.RadioButton();
            this.rbtnFixed = new System.Windows.Forms.RadioButton();
            this.label13 = new System.Windows.Forms.Label();
            this.cboWithdrawDuration = new System.Windows.Forms.ComboBox();
            this.txtMaxWithdrawal = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtInterest = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtSavingsName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgSavingsType = new System.Windows.Forms.DataGridView();
            this.txtSearchBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cboFilter = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.NoWithdrawalLimitPanel.SuspendLayout();
            this.statusPanel.SuspendLayout();
            this.percentagePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSavingsType)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Duration);
            this.panel1.Controls.Add(this.NoWithdrawalLimitPanel);
            this.panel1.Controls.Add(this.error);
            this.panel1.Controls.Add(this.txtMaintainingBalance);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtNoAccountHolder);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.statusPanel);
            this.panel1.Controls.Add(this.percentagePanel);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.cboWithdrawDuration);
            this.panel1.Controls.Add(this.txtMaxWithdrawal);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtInterest);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.txtSavingsName);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dgSavingsType);
            this.panel1.Controls.Add(this.txtSearchBox);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.cboFilter);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(719, 428);
            this.panel1.TabIndex = 0;
            // 
            // Duration
            // 
            this.Duration.AutoSize = true;
            this.Duration.BackColor = System.Drawing.Color.Red;
            this.Duration.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Duration.ForeColor = System.Drawing.SystemColors.Window;
            this.Duration.Location = new System.Drawing.Point(400, 323);
            this.Duration.Name = "Duration";
            this.Duration.Size = new System.Drawing.Size(16, 15);
            this.Duration.TabIndex = 210;
            this.Duration.Text = "X";
            this.Duration.Visible = false;
            // 
            // NoWithdrawalLimitPanel
            // 
            this.NoWithdrawalLimitPanel.Controls.Add(this.chkWithdrawalLimit);
            this.NoWithdrawalLimitPanel.Location = new System.Drawing.Point(177, 346);
            this.NoWithdrawalLimitPanel.Name = "NoWithdrawalLimitPanel";
            this.NoWithdrawalLimitPanel.Size = new System.Drawing.Size(153, 28);
            this.NoWithdrawalLimitPanel.TabIndex = 6;
            // 
            // chkWithdrawalLimit
            // 
            this.chkWithdrawalLimit.AutoSize = true;
            this.chkWithdrawalLimit.Location = new System.Drawing.Point(3, 3);
            this.chkWithdrawalLimit.Name = "chkWithdrawalLimit";
            this.chkWithdrawalLimit.Size = new System.Drawing.Size(143, 20);
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
            this.error.Location = new System.Drawing.Point(382, 347);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(0, 16);
            this.error.TabIndex = 208;
            this.error.Visible = false;
            // 
            // txtMaintainingBalance
            // 
            this.txtMaintainingBalance.Location = new System.Drawing.Point(561, 263);
            this.txtMaintainingBalance.MaxLength = 8;
            this.txtMaintainingBalance.Name = "txtMaintainingBalance";
            this.txtMaintainingBalance.Size = new System.Drawing.Size(128, 22);
            this.txtMaintainingBalance.TabIndex = 7;
            this.txtMaintainingBalance.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaintainingBalance_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(426, 269);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 16);
            this.label6.TabIndex = 205;
            this.label6.Text = "Maintaining Balance:";
            // 
            // txtNoAccountHolder
            // 
            this.txtNoAccountHolder.Location = new System.Drawing.Point(177, 292);
            this.txtNoAccountHolder.MaxLength = 4;
            this.txtNoAccountHolder.Name = "txtNoAccountHolder";
            this.txtNoAccountHolder.Size = new System.Drawing.Size(114, 22);
            this.txtNoAccountHolder.TabIndex = 3;
            this.txtNoAccountHolder.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNoAccountHolder_KeyPress);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(27, 293);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(145, 16);
            this.label14.TabIndex = 197;
            this.label14.Text = "No. of Account Holders:";
            // 
            // statusPanel
            // 
            this.statusPanel.Controls.Add(this.rbtnInactive);
            this.statusPanel.Controls.Add(this.rbtnActive);
            this.statusPanel.Location = new System.Drawing.Point(561, 343);
            this.statusPanel.Name = "statusPanel";
            this.statusPanel.Size = new System.Drawing.Size(142, 31);
            this.statusPanel.TabIndex = 172;
            // 
            // rbtnInactive
            // 
            this.rbtnInactive.AutoSize = true;
            this.rbtnInactive.Location = new System.Drawing.Point(59, 3);
            this.rbtnInactive.Name = "rbtnInactive";
            this.rbtnInactive.Size = new System.Drawing.Size(69, 20);
            this.rbtnInactive.TabIndex = 12;
            this.rbtnInactive.TabStop = true;
            this.rbtnInactive.Text = "Inactive";
            this.rbtnInactive.UseVisualStyleBackColor = true;
            // 
            // rbtnActive
            // 
            this.rbtnActive.AutoSize = true;
            this.rbtnActive.Location = new System.Drawing.Point(3, 4);
            this.rbtnActive.Name = "rbtnActive";
            this.rbtnActive.Size = new System.Drawing.Size(61, 20);
            this.rbtnActive.TabIndex = 11;
            this.rbtnActive.TabStop = true;
            this.rbtnActive.Text = "Active";
            this.rbtnActive.UseVisualStyleBackColor = true;
            // 
            // percentagePanel
            // 
            this.percentagePanel.Controls.Add(this.rbtnPercentage);
            this.percentagePanel.Controls.Add(this.rbtnFixed);
            this.percentagePanel.Location = new System.Drawing.Point(561, 315);
            this.percentagePanel.Name = "percentagePanel";
            this.percentagePanel.Size = new System.Drawing.Size(151, 22);
            this.percentagePanel.TabIndex = 177;
            // 
            // rbtnPercentage
            // 
            this.rbtnPercentage.AutoSize = true;
            this.rbtnPercentage.Location = new System.Drawing.Point(59, 3);
            this.rbtnPercentage.Name = "rbtnPercentage";
            this.rbtnPercentage.Size = new System.Drawing.Size(92, 20);
            this.rbtnPercentage.TabIndex = 10;
            this.rbtnPercentage.TabStop = true;
            this.rbtnPercentage.Text = "Percentage";
            this.rbtnPercentage.UseVisualStyleBackColor = true;
            // 
            // rbtnFixed
            // 
            this.rbtnFixed.AutoSize = true;
            this.rbtnFixed.Location = new System.Drawing.Point(3, 3);
            this.rbtnFixed.Name = "rbtnFixed";
            this.rbtnFixed.Size = new System.Drawing.Size(58, 20);
            this.rbtnFixed.TabIndex = 9;
            this.rbtnFixed.TabStop = true;
            this.rbtnFixed.Text = "Fixed";
            this.rbtnFixed.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(426, 348);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(50, 16);
            this.label13.TabIndex = 196;
            this.label13.Text = "Status:";
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
            this.cboWithdrawDuration.Location = new System.Drawing.Point(296, 318);
            this.cboWithdrawDuration.Name = "cboWithdrawDuration";
            this.cboWithdrawDuration.Size = new System.Drawing.Size(99, 24);
            this.cboWithdrawDuration.TabIndex = 5;
            // 
            // txtMaxWithdrawal
            // 
            this.txtMaxWithdrawal.Location = new System.Drawing.Point(177, 319);
            this.txtMaxWithdrawal.MaxLength = 8;
            this.txtMaxWithdrawal.Name = "txtMaxWithdrawal";
            this.txtMaxWithdrawal.Size = new System.Drawing.Size(114, 22);
            this.txtMaxWithdrawal.TabIndex = 4;
            this.txtMaxWithdrawal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaxWithdrawal_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(26, 322);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(153, 16);
            this.label11.TabIndex = 194;
            this.label11.Text = "Max Withdrawal Amount:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(426, 296);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 192;
            this.label4.Text = "Interest:";
            // 
            // txtInterest
            // 
            this.txtInterest.Location = new System.Drawing.Point(561, 289);
            this.txtInterest.MaxLength = 8;
            this.txtInterest.Name = "txtInterest";
            this.txtInterest.Size = new System.Drawing.Size(128, 22);
            this.txtInterest.TabIndex = 8;
            this.txtInterest.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInterest_KeyPress);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(401, 394);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 15;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(320, 394);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(239, 394);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // txtSavingsName
            // 
            this.txtSavingsName.BackColor = System.Drawing.SystemColors.Window;
            this.txtSavingsName.Location = new System.Drawing.Point(177, 266);
            this.txtSavingsName.MaxLength = 50;
            this.txtSavingsName.Name = "txtSavingsName";
            this.txtSavingsName.Size = new System.Drawing.Size(114, 22);
            this.txtSavingsName.TabIndex = 2;
            this.txtSavingsName.Validating += new System.ComponentModel.CancelEventHandler(this.txtSavingsName_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 270);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 16);
            this.label3.TabIndex = 187;
            this.label3.Text = "Savings Type Name:";
            // 
            // dgSavingsType
            // 
            this.dgSavingsType.AllowUserToAddRows = false;
            this.dgSavingsType.AllowUserToDeleteRows = false;
            this.dgSavingsType.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgSavingsType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSavingsType.Location = new System.Drawing.Point(20, 94);
            this.dgSavingsType.Name = "dgSavingsType";
            this.dgSavingsType.Size = new System.Drawing.Size(671, 159);
            this.dgSavingsType.TabIndex = 16;
            // 
            // txtSearchBox
            // 
            this.txtSearchBox.Location = new System.Drawing.Point(186, 65);
            this.txtSearchBox.Name = "txtSearchBox";
            this.txtSearchBox.Size = new System.Drawing.Size(188, 22);
            this.txtSearchBox.TabIndex = 183;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 66);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 16);
            this.label8.TabIndex = 181;
            this.label8.Text = "Filter:";
            // 
            // cboFilter
            // 
            this.cboFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFilter.FormattingEnabled = true;
            this.cboFilter.Items.AddRange(new object[] {
            "No Filter",
            "Active",
            "Inactive"});
            this.cboFilter.Location = new System.Drawing.Point(65, 63);
            this.cboFilter.Name = "cboFilter";
            this.cboFilter.Size = new System.Drawing.Size(115, 24);
            this.cboFilter.TabIndex = 182;
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
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(723, 430);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "MaintenanceSavingsTypeView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Savings Type";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.NoWithdrawalLimitPanel.ResumeLayout(false);
            this.NoWithdrawalLimitPanel.PerformLayout();
            this.statusPanel.ResumeLayout(false);
            this.statusPanel.PerformLayout();
            this.percentagePanel.ResumeLayout(false);
            this.percentagePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSavingsType)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtNoAccountHolder;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtSavingsName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgSavingsType;
        private System.Windows.Forms.TextBox txtSearchBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaintainingBalance;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chkWithdrawalLimit;
        private System.Windows.Forms.Panel statusPanel;
        private System.Windows.Forms.RadioButton rbtnInactive;
        private System.Windows.Forms.RadioButton rbtnActive;
        private System.Windows.Forms.Panel percentagePanel;
        private System.Windows.Forms.RadioButton rbtnPercentage;
        private System.Windows.Forms.RadioButton rbtnFixed;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cboWithdrawDuration;
        private System.Windows.Forms.TextBox txtMaxWithdrawal;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtInterest;
        private System.Windows.Forms.Label error;
        private System.Windows.Forms.Panel NoWithdrawalLimitPanel;
        private System.Windows.Forms.Label Duration;

    }
}