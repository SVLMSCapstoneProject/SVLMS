namespace SVLMS.Loaning.View
{
    partial class TransactionShareCapital
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
            this.mainPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnPrintStockCertificate = new System.Windows.Forms.Button();
            this.btnDepositShare = new System.Windows.Forms.Button();
            this.txtShareAmount = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txtTotalShares = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.txtMemberName = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.txtAccountNo = new System.Windows.Forms.TextBox();
            this.dgMemberInformation = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cboSearchBy = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mainPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgMemberInformation)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.AutoSize = true;
            this.mainPanel.Controls.Add(this.panel1);
            this.mainPanel.Controls.Add(this.dgMemberInformation);
            this.mainPanel.Controls.Add(this.txtSearch);
            this.mainPanel.Controls.Add(this.label6);
            this.mainPanel.Controls.Add(this.cboSearchBy);
            this.mainPanel.Controls.Add(this.label1);
            this.mainPanel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainPanel.Location = new System.Drawing.Point(2, 2);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(623, 406);
            this.mainPanel.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.groupBox5);
            this.panel1.Controls.Add(this.groupBox6);
            this.panel1.Location = new System.Drawing.Point(20, 236);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(590, 150);
            this.panel1.TabIndex = 160;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnPrintStockCertificate);
            this.groupBox5.Controls.Add(this.btnDepositShare);
            this.groupBox5.Controls.Add(this.txtShareAmount);
            this.groupBox5.Controls.Add(this.label20);
            this.groupBox5.Location = new System.Drawing.Point(298, 13);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(278, 112);
            this.groupBox5.TabIndex = 115;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Share Contribution:";
            // 
            // btnPrintStockCertificate
            // 
            this.btnPrintStockCertificate.Location = new System.Drawing.Point(123, 67);
            this.btnPrintStockCertificate.Name = "btnPrintStockCertificate";
            this.btnPrintStockCertificate.Size = new System.Drawing.Size(130, 23);
            this.btnPrintStockCertificate.TabIndex = 124;
            this.btnPrintStockCertificate.Text = "Print Stock Cert";
            this.btnPrintStockCertificate.UseVisualStyleBackColor = true;
            // 
            // btnDepositShare
            // 
            this.btnDepositShare.Location = new System.Drawing.Point(42, 67);
            this.btnDepositShare.Name = "btnDepositShare";
            this.btnDepositShare.Size = new System.Drawing.Size(75, 23);
            this.btnDepositShare.TabIndex = 123;
            this.btnDepositShare.Text = "Deposit";
            this.btnDepositShare.UseVisualStyleBackColor = true;
            // 
            // txtShareAmount
            // 
            this.txtShareAmount.Location = new System.Drawing.Point(134, 27);
            this.txtShareAmount.Name = "txtShareAmount";
            this.txtShareAmount.Size = new System.Drawing.Size(130, 22);
            this.txtShareAmount.TabIndex = 88;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(19, 30);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(94, 16);
            this.label20.TabIndex = 87;
            this.label20.Text = "Share Amount:";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.txtTotalShares);
            this.groupBox6.Controls.Add(this.label22);
            this.groupBox6.Controls.Add(this.txtMemberName);
            this.groupBox6.Controls.Add(this.label24);
            this.groupBox6.Controls.Add(this.label25);
            this.groupBox6.Controls.Add(this.txtAccountNo);
            this.groupBox6.Location = new System.Drawing.Point(10, 13);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(282, 112);
            this.groupBox6.TabIndex = 114;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Member Information:";
            // 
            // txtTotalShares
            // 
            this.txtTotalShares.BackColor = System.Drawing.Color.White;
            this.txtTotalShares.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtTotalShares.Location = new System.Drawing.Point(122, 72);
            this.txtTotalShares.Name = "txtTotalShares";
            this.txtTotalShares.ReadOnly = true;
            this.txtTotalShares.Size = new System.Drawing.Size(145, 22);
            this.txtTotalShares.TabIndex = 83;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(14, 74);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(84, 16);
            this.label22.TabIndex = 82;
            this.label22.Text = "Total Shares:";
            // 
            // txtMemberName
            // 
            this.txtMemberName.BackColor = System.Drawing.Color.White;
            this.txtMemberName.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtMemberName.Location = new System.Drawing.Point(122, 46);
            this.txtMemberName.Name = "txtMemberName";
            this.txtMemberName.ReadOnly = true;
            this.txtMemberName.Size = new System.Drawing.Size(145, 22);
            this.txtMemberName.TabIndex = 79;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(14, 48);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(97, 16);
            this.label24.TabIndex = 78;
            this.label24.Text = "Member Name:";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(14, 22);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(84, 16);
            this.label25.TabIndex = 74;
            this.label25.Text = "Account No.:";
            // 
            // txtAccountNo
            // 
            this.txtAccountNo.BackColor = System.Drawing.Color.White;
            this.txtAccountNo.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtAccountNo.Location = new System.Drawing.Point(122, 20);
            this.txtAccountNo.Name = "txtAccountNo";
            this.txtAccountNo.ReadOnly = true;
            this.txtAccountNo.Size = new System.Drawing.Size(145, 22);
            this.txtAccountNo.TabIndex = 77;
            // 
            // dgMemberInformation
            // 
            this.dgMemberInformation.AllowUserToAddRows = false;
            this.dgMemberInformation.AllowUserToDeleteRows = false;
            this.dgMemberInformation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgMemberInformation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMemberInformation.Location = new System.Drawing.Point(20, 90);
            this.dgMemberInformation.Name = "dgMemberInformation";
            this.dgMemberInformation.ReadOnly = true;
            this.dgMemberInformation.Size = new System.Drawing.Size(590, 140);
            this.dgMemberInformation.TabIndex = 159;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(210, 61);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(160, 22);
            this.txtSearch.TabIndex = 157;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 16);
            this.label6.TabIndex = 155;
            this.label6.Text = "Search By:";
            // 
            // cboSearchBy
            // 
            this.cboSearchBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSearchBy.FormattingEnabled = true;
            this.cboSearchBy.Items.AddRange(new object[] {
            "Account No",
            "Member Name"});
            this.cboSearchBy.Location = new System.Drawing.Point(92, 59);
            this.cboSearchBy.Name = "cboSearchBy";
            this.cboSearchBy.Size = new System.Drawing.Size(112, 24);
            this.cboSearchBy.TabIndex = 156;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Share Capital Transaction:";
            // 
            // TransactionShareCapital
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(626, 411);
            this.Controls.Add(this.mainPanel);
            this.Name = "TransactionShareCapital";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Share Capital";
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgMemberInformation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgMemberInformation;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboSearchBy;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnPrintStockCertificate;
        private System.Windows.Forms.Button btnDepositShare;
        private System.Windows.Forms.TextBox txtShareAmount;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox txtTotalShares;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtMemberName;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox txtAccountNo;
    }
}