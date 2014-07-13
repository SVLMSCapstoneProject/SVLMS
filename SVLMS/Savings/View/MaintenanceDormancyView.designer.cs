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
            this.panelSavingsTypeTitle = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
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
            this.percentagePanel = new System.Windows.Forms.Panel();
            this.rbtnFixed = new System.Windows.Forms.RadioButton();
            this.rbtnPercentage = new System.Windows.Forms.RadioButton();
            this.statusPanel = new System.Windows.Forms.Panel();
            this.rbtnInactive = new System.Windows.Forms.RadioButton();
            this.rbtnActive = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDormancyNo = new System.Windows.Forms.TextBox();
            this.cboSavingsType = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cboDeductionTime = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtInactivity = new System.Windows.Forms.TextBox();
            this.cboInactivity = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDeductionAmount = new System.Windows.Forms.TextBox();
            this.dgDormancy = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panelSavingsTypeTitle.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.percentagePanel.SuspendLayout();
            this.statusPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDormancy)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panelSavingsTypeTitle);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.dgDormancy);
            this.panel1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(706, 660);
            this.panel1.TabIndex = 0;
            // 
            // panelSavingsTypeTitle
            // 
            this.panelSavingsTypeTitle.BackColor = System.Drawing.Color.LimeGreen;
            this.panelSavingsTypeTitle.Controls.Add(this.label1);
            this.panelSavingsTypeTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSavingsTypeTitle.Location = new System.Drawing.Point(0, 0);
            this.panelSavingsTypeTitle.Name = "panelSavingsTypeTitle";
            this.panelSavingsTypeTitle.Size = new System.Drawing.Size(706, 56);
            this.panelSavingsTypeTitle.TabIndex = 143;
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
            this.label1.Size = new System.Drawing.Size(288, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Additional Charges Maintenance";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.txtSearchBox);
            this.panel2.Controls.Add(this.cboFilter);
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Location = new System.Drawing.Point(3, 57);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(699, 33);
            this.panel2.TabIndex = 142;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Light", 11F);
            this.label9.ImeMode = System.Windows.Forms.ImeMode.On;
            this.label9.Location = new System.Drawing.Point(404, 5);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 20);
            this.label9.TabIndex = 108;
            this.label9.Text = "Search:";
            // 
            // txtSearchBox
            // 
            this.txtSearchBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtSearchBox.Font = new System.Drawing.Font("Segoe UI Symbol", 11F);
            this.txtSearchBox.Location = new System.Drawing.Point(464, 2);
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
            this.cboFilter.Location = new System.Drawing.Point(66, 3);
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
            this.btnSearch.Location = new System.Drawing.Point(635, 2);
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
            this.groupBox1.Controls.Add(this.percentagePanel);
            this.groupBox1.Controls.Add(this.statusPanel);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtDormancyNo);
            this.groupBox1.Controls.Add(this.cboSavingsType);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cboDeductionTime);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtInactivity);
            this.groupBox1.Controls.Add(this.cboInactivity);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtDeductionAmount);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(32, 308);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(637, 333);
            this.groupBox1.TabIndex = 141;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dormancy Maintenance";
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
            this.btnUpdate.Location = new System.Drawing.Point(261, 271);
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
            this.btnClear.Location = new System.Drawing.Point(365, 271);
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
            this.btnSave.Location = new System.Drawing.Point(157, 271);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(98, 35);
            this.btnSave.TabIndex = 224;
            this.btnSave.Text = "Add";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // percentagePanel
            // 
            this.percentagePanel.Controls.Add(this.rbtnFixed);
            this.percentagePanel.Controls.Add(this.rbtnPercentage);
            this.percentagePanel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.percentagePanel.Location = new System.Drawing.Point(209, 185);
            this.percentagePanel.Name = "percentagePanel";
            this.percentagePanel.Size = new System.Drawing.Size(254, 29);
            this.percentagePanel.TabIndex = 162;
            // 
            // rbtnFixed
            // 
            this.rbtnFixed.AutoSize = true;
            this.rbtnFixed.Location = new System.Drawing.Point(10, 2);
            this.rbtnFixed.Name = "rbtnFixed";
            this.rbtnFixed.Size = new System.Drawing.Size(119, 24);
            this.rbtnFixed.TabIndex = 8;
            this.rbtnFixed.TabStop = true;
            this.rbtnFixed.Text = "Fixed Amount";
            this.rbtnFixed.UseVisualStyleBackColor = true;
            // 
            // rbtnPercentage
            // 
            this.rbtnPercentage.AutoSize = true;
            this.rbtnPercentage.Location = new System.Drawing.Point(136, 2);
            this.rbtnPercentage.Name = "rbtnPercentage";
            this.rbtnPercentage.Size = new System.Drawing.Size(101, 24);
            this.rbtnPercentage.TabIndex = 9;
            this.rbtnPercentage.TabStop = true;
            this.rbtnPercentage.Text = "Percentage";
            this.rbtnPercentage.UseVisualStyleBackColor = true;
            // 
            // statusPanel
            // 
            this.statusPanel.Controls.Add(this.rbtnInactive);
            this.statusPanel.Controls.Add(this.rbtnActive);
            this.statusPanel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusPanel.Location = new System.Drawing.Point(209, 218);
            this.statusPanel.Name = "statusPanel";
            this.statusPanel.Size = new System.Drawing.Size(162, 30);
            this.statusPanel.TabIndex = 163;
            // 
            // rbtnInactive
            // 
            this.rbtnInactive.AutoSize = true;
            this.rbtnInactive.Location = new System.Drawing.Point(78, 3);
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
            this.rbtnActive.Location = new System.Drawing.Point(10, 3);
            this.rbtnActive.Name = "rbtnActive";
            this.rbtnActive.Size = new System.Drawing.Size(68, 24);
            this.rbtnActive.TabIndex = 11;
            this.rbtnActive.TabStop = true;
            this.rbtnActive.Text = "Active";
            this.rbtnActive.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(71, 221);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 20);
            this.label7.TabIndex = 171;
            this.label7.Text = "Status:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(66, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 20);
            this.label2.TabIndex = 167;
            this.label2.Text = "Dormancy No:";
            // 
            // txtDormancyNo
            // 
            this.txtDormancyNo.BackColor = System.Drawing.SystemColors.Window;
            this.txtDormancyNo.Enabled = false;
            this.txtDormancyNo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDormancyNo.Location = new System.Drawing.Point(209, 32);
            this.txtDormancyNo.Name = "txtDormancyNo";
            this.txtDormancyNo.Size = new System.Drawing.Size(193, 27);
            this.txtDormancyNo.TabIndex = 156;
            // 
            // cboSavingsType
            // 
            this.cboSavingsType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSavingsType.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSavingsType.FormattingEnabled = true;
            this.cboSavingsType.Location = new System.Drawing.Point(209, 70);
            this.cboSavingsType.Name = "cboSavingsType";
            this.cboSavingsType.Size = new System.Drawing.Size(193, 28);
            this.cboSavingsType.TabIndex = 157;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(66, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 20);
            this.label6.TabIndex = 170;
            this.label6.Text = "SavingsType";
            // 
            // cboDeductionTime
            // 
            this.cboDeductionTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDeductionTime.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDeductionTime.FormattingEnabled = true;
            this.cboDeductionTime.Items.AddRange(new object[] {
            "per Day",
            "per Week",
            "per Month",
            "per Year"});
            this.cboDeductionTime.Location = new System.Drawing.Point(408, 146);
            this.cboDeductionTime.Name = "cboDeductionTime";
            this.cboDeductionTime.Size = new System.Drawing.Size(193, 28);
            this.cboDeductionTime.TabIndex = 161;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(66, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 20);
            this.label3.TabIndex = 168;
            this.label3.Text = "Inactivity Duration:";
            // 
            // txtInactivity
            // 
            this.txtInactivity.BackColor = System.Drawing.SystemColors.Window;
            this.txtInactivity.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInactivity.Location = new System.Drawing.Point(209, 109);
            this.txtInactivity.MaxLength = 4;
            this.txtInactivity.Name = "txtInactivity";
            this.txtInactivity.Size = new System.Drawing.Size(193, 27);
            this.txtInactivity.TabIndex = 158;
            this.txtInactivity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInactivity_KeyPress_1);
            // 
            // cboInactivity
            // 
            this.cboInactivity.BackColor = System.Drawing.Color.White;
            this.cboInactivity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboInactivity.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboInactivity.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cboInactivity.FormattingEnabled = true;
            this.cboInactivity.Items.AddRange(new object[] {
            "Day/s",
            "Week/s",
            "Month/s",
            "Year/s"});
            this.cboInactivity.Location = new System.Drawing.Point(408, 109);
            this.cboInactivity.Name = "cboInactivity";
            this.cboInactivity.Size = new System.Drawing.Size(193, 28);
            this.cboInactivity.TabIndex = 159;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(66, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 20);
            this.label4.TabIndex = 169;
            this.label4.Text = "Deduction Amount:";
            // 
            // txtDeductionAmount
            // 
            this.txtDeductionAmount.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDeductionAmount.Location = new System.Drawing.Point(209, 147);
            this.txtDeductionAmount.MaxLength = 15;
            this.txtDeductionAmount.Name = "txtDeductionAmount";
            this.txtDeductionAmount.Size = new System.Drawing.Size(193, 27);
            this.txtDeductionAmount.TabIndex = 160;
            this.txtDeductionAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDeductionAmount_KeyPress_1);
            // 
            // dgDormancy
            // 
            this.dgDormancy.AllowUserToAddRows = false;
            this.dgDormancy.AllowUserToDeleteRows = false;
            this.dgDormancy.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgDormancy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDormancy.Location = new System.Drawing.Point(32, 97);
            this.dgDormancy.Name = "dgDormancy";
            this.dgDormancy.ReadOnly = true;
            this.dgDormancy.Size = new System.Drawing.Size(640, 200);
            this.dgDormancy.TabIndex = 140;
            // 
            // MaintenanceDormancyView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(704, 585);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "MaintenanceDormancyView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dormancy";
            this.panel1.ResumeLayout(false);
            this.panelSavingsTypeTitle.ResumeLayout(false);
            this.panelSavingsTypeTitle.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.percentagePanel.ResumeLayout(false);
            this.percentagePanel.PerformLayout();
            this.statusPanel.ResumeLayout(false);
            this.statusPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDormancy)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgDormancy;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel percentagePanel;
        private System.Windows.Forms.RadioButton rbtnFixed;
        private System.Windows.Forms.RadioButton rbtnPercentage;
        private System.Windows.Forms.Panel statusPanel;
        private System.Windows.Forms.RadioButton rbtnInactive;
        private System.Windows.Forms.RadioButton rbtnActive;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDormancyNo;
        private System.Windows.Forms.ComboBox cboSavingsType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboDeductionTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtInactivity;
        private System.Windows.Forms.ComboBox cboInactivity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDeductionAmount;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSearchBox;
        private System.Windows.Forms.ComboBox cboFilter;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panelSavingsTypeTitle;
        private System.Windows.Forms.Label label1;

    }
}