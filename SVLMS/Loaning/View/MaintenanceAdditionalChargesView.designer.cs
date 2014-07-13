namespace SVLMS.Loaning.View
{
    partial class MaintenanceAdditionalChargesView
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
            this.chkApplicableAll = new System.Windows.Forms.CheckBox();
            this.percentagePanel = new System.Windows.Forms.Panel();
            this.rbtnFixed = new System.Windows.Forms.RadioButton();
            this.rbtnPercentage = new System.Windows.Forms.RadioButton();
            this.statusPanel = new System.Windows.Forms.Panel();
            this.rbtnInactive = new System.Windows.Forms.RadioButton();
            this.rbtnActive = new System.Windows.Forms.RadioButton();
            this.label16 = new System.Windows.Forms.Label();
            this.listLoanTypes = new System.Windows.Forms.CheckedListBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtChargeName = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSearchBox = new System.Windows.Forms.TextBox();
            this.cboFilter = new System.Windows.Forms.ComboBox();
            this.dgCharges = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.percentagePanel.SuspendLayout();
            this.statusPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCharges)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.CausesValidation = false;
            this.panel1.Controls.Add(this.chkApplicableAll);
            this.panel1.Controls.Add(this.percentagePanel);
            this.panel1.Controls.Add(this.statusPanel);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.listLoanTypes);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.txtChargeName);
            this.panel1.Controls.Add(this.txtAmount);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtSearchBox);
            this.panel1.Controls.Add(this.cboFilter);
            this.panel1.Controls.Add(this.dgCharges);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(3, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(645, 339);
            this.panel1.TabIndex = 0;
            // 
            // chkApplicableAll
            // 
            this.chkApplicableAll.AutoSize = true;
            this.chkApplicableAll.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkApplicableAll.Location = new System.Drawing.Point(465, 157);
            this.chkApplicableAll.Name = "chkApplicableAll";
            this.chkApplicableAll.Size = new System.Drawing.Size(120, 20);
            this.chkApplicableAll.TabIndex = 84;
            this.chkApplicableAll.Text = "Applicable to All";
            this.chkApplicableAll.UseVisualStyleBackColor = true;
            // 
            // percentagePanel
            // 
            this.percentagePanel.Controls.Add(this.rbtnFixed);
            this.percentagePanel.Controls.Add(this.rbtnPercentage);
            this.percentagePanel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.percentagePanel.Location = new System.Drawing.Point(465, 131);
            this.percentagePanel.Name = "percentagePanel";
            this.percentagePanel.Size = new System.Drawing.Size(162, 23);
            this.percentagePanel.TabIndex = 83;
            // 
            // rbtnFixed
            // 
            this.rbtnFixed.AutoSize = true;
            this.rbtnFixed.Location = new System.Drawing.Point(3, 2);
            this.rbtnFixed.Name = "rbtnFixed";
            this.rbtnFixed.Size = new System.Drawing.Size(58, 20);
            this.rbtnFixed.TabIndex = 65;
            this.rbtnFixed.TabStop = true;
            this.rbtnFixed.Text = "Fixed";
            this.rbtnFixed.UseVisualStyleBackColor = true;
            // 
            // rbtnPercentage
            // 
            this.rbtnPercentage.AutoSize = true;
            this.rbtnPercentage.Location = new System.Drawing.Point(69, 2);
            this.rbtnPercentage.Name = "rbtnPercentage";
            this.rbtnPercentage.Size = new System.Drawing.Size(92, 20);
            this.rbtnPercentage.TabIndex = 80;
            this.rbtnPercentage.TabStop = true;
            this.rbtnPercentage.Text = "Percentage";
            this.rbtnPercentage.UseVisualStyleBackColor = true;
            // 
            // statusPanel
            // 
            this.statusPanel.Controls.Add(this.rbtnInactive);
            this.statusPanel.Controls.Add(this.rbtnActive);
            this.statusPanel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusPanel.Location = new System.Drawing.Point(465, 271);
            this.statusPanel.Name = "statusPanel";
            this.statusPanel.Size = new System.Drawing.Size(150, 24);
            this.statusPanel.TabIndex = 81;
            // 
            // rbtnInactive
            // 
            this.rbtnInactive.AutoSize = true;
            this.rbtnInactive.Location = new System.Drawing.Point(71, 3);
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
            this.label16.Location = new System.Drawing.Point(361, 271);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(50, 16);
            this.label16.TabIndex = 82;
            this.label16.Text = "Status:";
            // 
            // listLoanTypes
            // 
            this.listLoanTypes.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listLoanTypes.FormattingEnabled = true;
            this.listLoanTypes.Location = new System.Drawing.Point(463, 178);
            this.listLoanTypes.Name = "listLoanTypes";
            this.listLoanTypes.Size = new System.Drawing.Size(150, 89);
            this.listLoanTypes.TabIndex = 66;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(540, 301);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(85, 24);
            this.btnClear.TabIndex = 69;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(358, 301);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(85, 24);
            this.btnSave.TabIndex = 67;
            this.btnSave.Text = "Add";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // txtChargeName
            // 
            this.txtChargeName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChargeName.Location = new System.Drawing.Point(462, 81);
            this.txtChargeName.MaxLength = 50;
            this.txtChargeName.Name = "txtChargeName";
            this.txtChargeName.Size = new System.Drawing.Size(150, 22);
            this.txtChargeName.TabIndex = 63;
            this.txtChargeName.Validating += new System.ComponentModel.CancelEventHandler(this.txtChargeName_Validating);
            // 
            // txtAmount
            // 
            this.txtAmount.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.Location = new System.Drawing.Point(462, 107);
            this.txtAmount.MaxLength = 8;
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(150, 22);
            this.txtAmount.TabIndex = 64;
            this.txtAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmount_KeyPress);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(449, 301);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(85, 24);
            this.btnUpdate.TabIndex = 68;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(358, 158);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(87, 16);
            this.label14.TabIndex = 78;
            this.label14.Text = "Applicable to:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(357, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 16);
            this.label4.TabIndex = 77;
            this.label4.Text = "Amount:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(357, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 16);
            this.label3.TabIndex = 76;
            this.label3.Text = "Charge Name:";
            // 
            // txtSearchBox
            // 
            this.txtSearchBox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchBox.Location = new System.Drawing.Point(200, 55);
            this.txtSearchBox.Name = "txtSearchBox";
            this.txtSearchBox.Size = new System.Drawing.Size(132, 22);
            this.txtSearchBox.TabIndex = 73;
            // 
            // cboFilter
            // 
            this.cboFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFilter.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboFilter.FormattingEnabled = true;
            this.cboFilter.Items.AddRange(new object[] {
            "No Filter",
            "Active",
            "Inactive"});
            this.cboFilter.Location = new System.Drawing.Point(87, 53);
            this.cboFilter.Name = "cboFilter";
            this.cboFilter.Size = new System.Drawing.Size(107, 24);
            this.cboFilter.TabIndex = 72;
            // 
            // dgCharges
            // 
            this.dgCharges.AllowUserToAddRows = false;
            this.dgCharges.AllowUserToDeleteRows = false;
            this.dgCharges.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCharges.Location = new System.Drawing.Point(15, 82);
            this.dgCharges.Name = "dgCharges";
            this.dgCharges.Size = new System.Drawing.Size(317, 243);
            this.dgCharges.TabIndex = 71;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 16);
            this.label6.TabIndex = 70;
            this.label6.Text = "Filter:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(318, 25);
            this.label1.TabIndex = 62;
            this.label1.Text = "Maintenace: Additional Charges";
            // 
            // MaintenanceAdditionalChargesView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(651, 340);
            this.Controls.Add(this.panel1);
            this.Name = "MaintenanceAdditionalChargesView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Additional Charges";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.percentagePanel.ResumeLayout(false);
            this.percentagePanel.PerformLayout();
            this.statusPanel.ResumeLayout(false);
            this.statusPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCharges)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel statusPanel;
        private System.Windows.Forms.RadioButton rbtnInactive;
        private System.Windows.Forms.RadioButton rbtnActive;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.CheckedListBox listLoanTypes;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.RadioButton rbtnPercentage;
        private System.Windows.Forms.RadioButton rbtnFixed;
        private System.Windows.Forms.TextBox txtChargeName;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSearchBox;
        private System.Windows.Forms.ComboBox cboFilter;
        private System.Windows.Forms.DataGridView dgCharges;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel percentagePanel;
        private System.Windows.Forms.CheckBox chkApplicableAll;

    }
}