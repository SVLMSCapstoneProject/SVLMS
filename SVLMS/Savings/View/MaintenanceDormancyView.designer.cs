namespace SVLMS.Savings.View
{
    partial class MaintenanceDormancyView
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
            this.percentagePanel = new System.Windows.Forms.Panel();
            this.rbtnFixed = new System.Windows.Forms.RadioButton();
            this.rbtnPercentage = new System.Windows.Forms.RadioButton();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.dgDormancy = new System.Windows.Forms.DataGridView();
            this.statusPanel = new System.Windows.Forms.Panel();
            this.rbtnInactive = new System.Windows.Forms.RadioButton();
            this.rbtnActive = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtDormancyNo = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.cboSavingsType = new System.Windows.Forms.ComboBox();
            this.cboFilter = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cboDeductionTime = new System.Windows.Forms.ComboBox();
            this.txtSearchBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtInactivity = new System.Windows.Forms.TextBox();
            this.cboInactivity = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDeductionAmount = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.percentagePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDormancy)).BeginInit();
            this.statusPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.percentagePanel);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.dgDormancy);
            this.panel1.Controls.Add(this.statusPanel);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.txtDormancyNo);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.cboSavingsType);
            this.panel1.Controls.Add(this.cboFilter);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.cboDeductionTime);
            this.panel1.Controls.Add(this.txtSearchBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtInactivity);
            this.panel1.Controls.Add(this.cboInactivity);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtDeductionAmount);
            this.panel1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(756, 321);
            this.panel1.TabIndex = 0;
            // 
            // percentagePanel
            // 
            this.percentagePanel.Controls.Add(this.rbtnFixed);
            this.percentagePanel.Controls.Add(this.rbtnPercentage);
            this.percentagePanel.Location = new System.Drawing.Point(492, 195);
            this.percentagePanel.Name = "percentagePanel";
            this.percentagePanel.Size = new System.Drawing.Size(212, 22);
            this.percentagePanel.TabIndex = 7;
            // 
            // rbtnFixed
            // 
            this.rbtnFixed.AutoSize = true;
            this.rbtnFixed.Location = new System.Drawing.Point(10, 2);
            this.rbtnFixed.Name = "rbtnFixed";
            this.rbtnFixed.Size = new System.Drawing.Size(106, 20);
            this.rbtnFixed.TabIndex = 8;
            this.rbtnFixed.TabStop = true;
            this.rbtnFixed.Text = "Fixed Amount";
            this.rbtnFixed.UseVisualStyleBackColor = true;
            // 
            // rbtnPercentage
            // 
            this.rbtnPercentage.AutoSize = true;
            this.rbtnPercentage.Location = new System.Drawing.Point(122, 1);
            this.rbtnPercentage.Name = "rbtnPercentage";
            this.rbtnPercentage.Size = new System.Drawing.Size(92, 20);
            this.rbtnPercentage.TabIndex = 9;
            this.rbtnPercentage.TabStop = true;
            this.rbtnPercentage.Text = "Percentage";
            this.rbtnPercentage.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(518, 257);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // dgDormancy
            // 
            this.dgDormancy.AllowUserToAddRows = false;
            this.dgDormancy.AllowUserToDeleteRows = false;
            this.dgDormancy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDormancy.Location = new System.Drawing.Point(20, 83);
            this.dgDormancy.Name = "dgDormancy";
            this.dgDormancy.ReadOnly = true;
            this.dgDormancy.Size = new System.Drawing.Size(337, 206);
            this.dgDormancy.TabIndex = 140;
            // 
            // statusPanel
            // 
            this.statusPanel.Controls.Add(this.rbtnInactive);
            this.statusPanel.Controls.Add(this.rbtnActive);
            this.statusPanel.Location = new System.Drawing.Point(492, 221);
            this.statusPanel.Name = "statusPanel";
            this.statusPanel.Size = new System.Drawing.Size(148, 30);
            this.statusPanel.TabIndex = 10;
            // 
            // rbtnInactive
            // 
            this.rbtnInactive.AutoSize = true;
            this.rbtnInactive.Location = new System.Drawing.Point(71, 2);
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
            this.rbtnActive.Location = new System.Drawing.Point(10, 2);
            this.rbtnActive.Name = "rbtnActive";
            this.rbtnActive.Size = new System.Drawing.Size(61, 20);
            this.rbtnActive.TabIndex = 11;
            this.rbtnActive.TabStop = true;
            this.rbtnActive.Text = "Active";
            this.rbtnActive.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 29);
            this.label1.TabIndex = 133;
            this.label1.Text = "Maintenance: Dormancy";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(372, 224);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 16);
            this.label7.TabIndex = 155;
            this.label7.Text = "Status:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(372, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 16);
            this.label2.TabIndex = 134;
            this.label2.Text = "Dormancy No:";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(599, 257);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 15;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // txtDormancyNo
            // 
            this.txtDormancyNo.BackColor = System.Drawing.SystemColors.Window;
            this.txtDormancyNo.Enabled = false;
            this.txtDormancyNo.Location = new System.Drawing.Point(492, 83);
            this.txtDormancyNo.Name = "txtDormancyNo";
            this.txtDormancyNo.Size = new System.Drawing.Size(132, 22);
            this.txtDormancyNo.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(437, 257);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Add";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // cboSavingsType
            // 
            this.cboSavingsType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSavingsType.FormattingEnabled = true;
            this.cboSavingsType.Location = new System.Drawing.Point(492, 111);
            this.cboSavingsType.Name = "cboSavingsType";
            this.cboSavingsType.Size = new System.Drawing.Size(132, 24);
            this.cboSavingsType.TabIndex = 2;
            // 
            // cboFilter
            // 
            this.cboFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFilter.FormattingEnabled = true;
            this.cboFilter.Items.AddRange(new object[] {
            "No Filter",
            "Active",
            "Inactive"});
            this.cboFilter.Location = new System.Drawing.Point(73, 53);
            this.cboFilter.Name = "cboFilter";
            this.cboFilter.Size = new System.Drawing.Size(107, 24);
            this.cboFilter.TabIndex = 137;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(372, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 16);
            this.label6.TabIndex = 151;
            this.label6.Text = "SavingsType";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 16);
            this.label8.TabIndex = 136;
            this.label8.Text = "Filter:";
            // 
            // cboDeductionTime
            // 
            this.cboDeductionTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDeductionTime.FormattingEnabled = true;
            this.cboDeductionTime.Items.AddRange(new object[] {
            "per Day",
            "per Week",
            "per Month",
            "per Year"});
            this.cboDeductionTime.Location = new System.Drawing.Point(630, 168);
            this.cboDeductionTime.Name = "cboDeductionTime";
            this.cboDeductionTime.Size = new System.Drawing.Size(96, 24);
            this.cboDeductionTime.TabIndex = 6;
            // 
            // txtSearchBox
            // 
            this.txtSearchBox.Location = new System.Drawing.Point(196, 53);
            this.txtSearchBox.Name = "txtSearchBox";
            this.txtSearchBox.Size = new System.Drawing.Size(132, 22);
            this.txtSearchBox.TabIndex = 138;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(372, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 16);
            this.label3.TabIndex = 141;
            this.label3.Text = "Inactivity Duration:";
            // 
            // txtInactivity
            // 
            this.txtInactivity.BackColor = System.Drawing.SystemColors.Window;
            this.txtInactivity.Location = new System.Drawing.Point(492, 140);
            this.txtInactivity.MaxLength = 4;
            this.txtInactivity.Name = "txtInactivity";
            this.txtInactivity.Size = new System.Drawing.Size(132, 22);
            this.txtInactivity.TabIndex = 3;
            this.txtInactivity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInactivity_KeyPress);
            // 
            // cboInactivity
            // 
            this.cboInactivity.BackColor = System.Drawing.Color.White;
            this.cboInactivity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboInactivity.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cboInactivity.FormattingEnabled = true;
            this.cboInactivity.Items.AddRange(new object[] {
            "Day/s",
            "Week/s",
            "Month/s",
            "Year/s"});
            this.cboInactivity.Location = new System.Drawing.Point(630, 140);
            this.cboInactivity.Name = "cboInactivity";
            this.cboInactivity.Size = new System.Drawing.Size(96, 24);
            this.cboInactivity.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(372, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 16);
            this.label4.TabIndex = 144;
            this.label4.Text = "Deduction Amount:";
            // 
            // txtDeductionAmount
            // 
            this.txtDeductionAmount.Location = new System.Drawing.Point(492, 168);
            this.txtDeductionAmount.MaxLength = 8;
            this.txtDeductionAmount.Name = "txtDeductionAmount";
            this.txtDeductionAmount.Size = new System.Drawing.Size(132, 22);
            this.txtDeductionAmount.TabIndex = 5;
            this.txtDeductionAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDeductionAmount_KeyPress);
            // 
            // MaintenanceDormancyView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(761, 322);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "MaintenanceDormancyView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dormancy";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.percentagePanel.ResumeLayout(false);
            this.percentagePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDormancy)).EndInit();
            this.statusPanel.ResumeLayout(false);
            this.statusPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridView dgDormancy;
        private System.Windows.Forms.Panel statusPanel;
        private System.Windows.Forms.RadioButton rbtnInactive;
        private System.Windows.Forms.RadioButton rbtnActive;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtDormancyNo;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cboSavingsType;
        private System.Windows.Forms.ComboBox cboFilter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboDeductionTime;
        private System.Windows.Forms.TextBox txtSearchBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtInactivity;
        private System.Windows.Forms.RadioButton rbtnPercentage;
        private System.Windows.Forms.ComboBox cboInactivity;
        private System.Windows.Forms.RadioButton rbtnFixed;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDeductionAmount;
        private System.Windows.Forms.Panel percentagePanel;

    }
}