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
            this.panel1 = new System.Windows.Forms.Panel();
            this.GracePeriod = new System.Windows.Forms.Label();
            this.cboGracePeriod = new System.Windows.Forms.ComboBox();
            this.txtGracePeriod = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Interval = new System.Windows.Forms.Label();
            this.PercentagePanel = new System.Windows.Forms.Panel();
            this.rbtnPercentage = new System.Windows.Forms.RadioButton();
            this.rbtnFixed = new System.Windows.Forms.RadioButton();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.StatusPanel = new System.Windows.Forms.Panel();
            this.rbtnInactive = new System.Windows.Forms.RadioButton();
            this.rbtnActive = new System.Windows.Forms.RadioButton();
            this.label16 = new System.Windows.Forms.Label();
            this.dtpEffectivityDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.cboInterval = new System.Windows.Forms.ComboBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSearchBox = new System.Windows.Forms.TextBox();
            this.cboFilter = new System.Windows.Forms.ComboBox();
            this.dgPenalty = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtInterval = new System.Windows.Forms.TextBox();
            this.txtPenaltyRate = new System.Windows.Forms.TextBox();
            this.cboLoanType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.PercentagePanel.SuspendLayout();
            this.StatusPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPenalty)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.GracePeriod);
            this.panel1.Controls.Add(this.cboGracePeriod);
            this.panel1.Controls.Add(this.txtGracePeriod);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.Interval);
            this.panel1.Controls.Add(this.PercentagePanel);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.StatusPanel);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.dtpEffectivityDate);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cboInterval);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtSearchBox);
            this.panel1.Controls.Add(this.cboFilter);
            this.panel1.Controls.Add(this.dgPenalty);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.txtInterval);
            this.panel1.Controls.Add(this.txtPenaltyRate);
            this.panel1.Controls.Add(this.cboLoanType);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(759, 307);
            this.panel1.TabIndex = 0;
            // 
            // GracePeriod
            // 
            this.GracePeriod.AutoSize = true;
            this.GracePeriod.BackColor = System.Drawing.Color.Red;
            this.GracePeriod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GracePeriod.ForeColor = System.Drawing.SystemColors.Window;
            this.GracePeriod.Location = new System.Drawing.Point(708, 181);
            this.GracePeriod.Name = "GracePeriod";
            this.GracePeriod.Size = new System.Drawing.Size(17, 16);
            this.GracePeriod.TabIndex = 140;
            this.GracePeriod.Text = "X";
            this.GracePeriod.Visible = false;
            // 
            // cboGracePeriod
            // 
            this.cboGracePeriod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGracePeriod.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboGracePeriod.FormattingEnabled = true;
            this.cboGracePeriod.Items.AddRange(new object[] {
            "Days",
            "Weeks",
            "Months",
            "Years"});
            this.cboGracePeriod.Location = new System.Drawing.Point(593, 176);
            this.cboGracePeriod.Name = "cboGracePeriod";
            this.cboGracePeriod.Size = new System.Drawing.Size(112, 24);
            this.cboGracePeriod.TabIndex = 139;
            // 
            // txtGracePeriod
            // 
            this.txtGracePeriod.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGracePeriod.Location = new System.Drawing.Point(450, 173);
            this.txtGracePeriod.MaxLength = 4;
            this.txtGracePeriod.Name = "txtGracePeriod";
            this.txtGracePeriod.Size = new System.Drawing.Size(135, 22);
            this.txtGracePeriod.TabIndex = 138;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(346, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 137;
            this.label3.Text = "Grace Period:";
            // 
            // Interval
            // 
            this.Interval.AutoSize = true;
            this.Interval.BackColor = System.Drawing.Color.Red;
            this.Interval.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Interval.ForeColor = System.Drawing.SystemColors.Window;
            this.Interval.Location = new System.Drawing.Point(708, 149);
            this.Interval.Name = "Interval";
            this.Interval.Size = new System.Drawing.Size(17, 16);
            this.Interval.TabIndex = 136;
            this.Interval.Text = "X";
            this.Interval.Visible = false;
            // 
            // PercentagePanel
            // 
            this.PercentagePanel.Controls.Add(this.rbtnPercentage);
            this.PercentagePanel.Controls.Add(this.rbtnFixed);
            this.PercentagePanel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PercentagePanel.Location = new System.Drawing.Point(587, 117);
            this.PercentagePanel.Name = "PercentagePanel";
            this.PercentagePanel.Size = new System.Drawing.Size(163, 25);
            this.PercentagePanel.TabIndex = 134;
            // 
            // rbtnPercentage
            // 
            this.rbtnPercentage.AutoSize = true;
            this.rbtnPercentage.Location = new System.Drawing.Point(69, 3);
            this.rbtnPercentage.Name = "rbtnPercentage";
            this.rbtnPercentage.Size = new System.Drawing.Size(92, 20);
            this.rbtnPercentage.TabIndex = 72;
            this.rbtnPercentage.TabStop = true;
            this.rbtnPercentage.Text = "Percentage";
            this.rbtnPercentage.UseVisualStyleBackColor = true;
            // 
            // rbtnFixed
            // 
            this.rbtnFixed.AutoSize = true;
            this.rbtnFixed.Location = new System.Drawing.Point(6, 3);
            this.rbtnFixed.Name = "rbtnFixed";
            this.rbtnFixed.Size = new System.Drawing.Size(58, 20);
            this.rbtnFixed.TabIndex = 64;
            this.rbtnFixed.TabStop = true;
            this.rbtnFixed.Text = "Fixed";
            this.rbtnFixed.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(482, 265);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 133;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // StatusPanel
            // 
            this.StatusPanel.Controls.Add(this.rbtnInactive);
            this.StatusPanel.Controls.Add(this.rbtnActive);
            this.StatusPanel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusPanel.Location = new System.Drawing.Point(450, 234);
            this.StatusPanel.Name = "StatusPanel";
            this.StatusPanel.Size = new System.Drawing.Size(149, 24);
            this.StatusPanel.TabIndex = 131;
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
            this.label16.Location = new System.Drawing.Point(348, 235);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(50, 16);
            this.label16.TabIndex = 132;
            this.label16.Text = "Status:";
            // 
            // dtpEffectivityDate
            // 
            this.dtpEffectivityDate.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEffectivityDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEffectivityDate.Location = new System.Drawing.Point(450, 201);
            this.dtpEffectivityDate.Name = "dtpEffectivityDate";
            this.dtpEffectivityDate.Size = new System.Drawing.Size(135, 22);
            this.dtpEffectivityDate.TabIndex = 81;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(347, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 16);
            this.label5.TabIndex = 80;
            this.label5.Text = "Effectivity Date:";
            // 
            // cboInterval
            // 
            this.cboInterval.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboInterval.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboInterval.FormattingEnabled = true;
            this.cboInterval.Items.AddRange(new object[] {
            "Days",
            "Weeks",
            "Months",
            "Years"});
            this.cboInterval.Location = new System.Drawing.Point(593, 145);
            this.cboInterval.Name = "cboInterval";
            this.cboInterval.Size = new System.Drawing.Size(112, 24);
            this.cboInterval.TabIndex = 69;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(563, 265);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 71;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(14, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(241, 29);
            this.label7.TabIndex = 78;
            this.label7.Text = "Maintenance: Penalty";
            // 
            // txtSearchBox
            // 
            this.txtSearchBox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchBox.Location = new System.Drawing.Point(210, 51);
            this.txtSearchBox.Name = "txtSearchBox";
            this.txtSearchBox.Size = new System.Drawing.Size(132, 22);
            this.txtSearchBox.TabIndex = 76;
            // 
            // cboFilter
            // 
            this.cboFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFilter.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboFilter.FormattingEnabled = true;
            this.cboFilter.Items.AddRange(new object[] {
            "Incoming Penalty",
            "Archived",
            "No Filter"});
            this.cboFilter.Location = new System.Drawing.Point(91, 51);
            this.cboFilter.Name = "cboFilter";
            this.cboFilter.Size = new System.Drawing.Size(113, 24);
            this.cboFilter.TabIndex = 75;
            // 
            // dgPenalty
            // 
            this.dgPenalty.AllowUserToAddRows = false;
            this.dgPenalty.AllowUserToDeleteRows = false;
            this.dgPenalty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPenalty.Location = new System.Drawing.Point(19, 81);
            this.dgPenalty.Name = "dgPenalty";
            this.dgPenalty.ReadOnly = true;
            this.dgPenalty.Size = new System.Drawing.Size(323, 207);
            this.dgPenalty.TabIndex = 74;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 16);
            this.label6.TabIndex = 73;
            this.label6.Text = "Filter:";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(398, 265);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 70;
            this.btnSave.Text = "Add";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // txtInterval
            // 
            this.txtInterval.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInterval.Location = new System.Drawing.Point(450, 146);
            this.txtInterval.MaxLength = 4;
            this.txtInterval.Name = "txtInterval";
            this.txtInterval.Size = new System.Drawing.Size(135, 22);
            this.txtInterval.TabIndex = 68;
            this.txtInterval.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInterval_KeyPress);
            // 
            // txtPenaltyRate
            // 
            this.txtPenaltyRate.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPenaltyRate.Location = new System.Drawing.Point(451, 119);
            this.txtPenaltyRate.MaxLength = 8;
            this.txtPenaltyRate.Name = "txtPenaltyRate";
            this.txtPenaltyRate.Size = new System.Drawing.Size(134, 22);
            this.txtPenaltyRate.TabIndex = 62;
            this.txtPenaltyRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPenaltyRate_KeyPress);
            // 
            // cboLoanType
            // 
            this.cboLoanType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoanType.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLoanType.FormattingEnabled = true;
            this.cboLoanType.Location = new System.Drawing.Point(450, 91);
            this.cboLoanType.Name = "cboLoanType";
            this.cboLoanType.Size = new System.Drawing.Size(135, 24);
            this.cboLoanType.TabIndex = 60;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(348, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 16);
            this.label4.TabIndex = 65;
            this.label4.Text = "Fine Every:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(347, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 61;
            this.label2.Text = "Penalty:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(348, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 59;
            this.label1.Text = "Loan Type:";
            // 
            // MaintenancePenaltyView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(757, 311);
            this.Controls.Add(this.panel1);
            this.Name = "MaintenancePenaltyView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loan Penalty";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.PercentagePanel.ResumeLayout(false);
            this.PercentagePanel.PerformLayout();
            this.StatusPanel.ResumeLayout(false);
            this.StatusPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPenalty)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cboInterval;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSearchBox;
        private System.Windows.Forms.ComboBox cboFilter;
        private System.Windows.Forms.DataGridView dgPenalty;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.RadioButton rbtnPercentage;
        private System.Windows.Forms.RadioButton rbtnFixed;
        private System.Windows.Forms.TextBox txtInterval;
        private System.Windows.Forms.TextBox txtPenaltyRate;
        private System.Windows.Forms.ComboBox cboLoanType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpEffectivityDate;
        private System.Windows.Forms.Panel StatusPanel;
        private System.Windows.Forms.RadioButton rbtnInactive;
        private System.Windows.Forms.RadioButton rbtnActive;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Panel PercentagePanel;
        private System.Windows.Forms.Label Interval;
        private System.Windows.Forms.Label GracePeriod;
        private System.Windows.Forms.ComboBox cboGracePeriod;
        private System.Windows.Forms.TextBox txtGracePeriod;
        private System.Windows.Forms.Label label3;

    }
}