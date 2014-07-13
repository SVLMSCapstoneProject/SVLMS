namespace SVLMS.Loaning.View
{
    partial class TransactionLoanReleaseView
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtpDateIssued = new System.Windows.Forms.DateTimePicker();
            this.txtBankName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtCheckNo = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPrintVoucher = new System.Windows.Forms.Button();
            this.dgCharges = new System.Windows.Forms.DataGridView();
            this.btnRelease = new System.Windows.Forms.Button();
            this.rbtnCheck = new System.Windows.Forms.RadioButton();
            this.rbtnCash = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNetAmount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtApprovedRelease = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtApprovalDate = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtApprovedAmount = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtRequestedAmount = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMemberName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtLoanNo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgApprovedLoans = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cboSearchBy = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCharges)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgApprovedLoans)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dgApprovedLoans);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.cboSearchBy);
            this.panel1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(1, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(687, 540);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.groupBox3);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Location = new System.Drawing.Point(18, 230);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(659, 301);
            this.panel2.TabIndex = 82;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtpDateIssued);
            this.groupBox3.Controls.Add(this.txtBankName);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.txtCheckNo);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Location = new System.Drawing.Point(11, 181);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(293, 108);
            this.groupBox3.TabIndex = 84;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Check Information";
            // 
            // dtpDateIssued
            // 
            this.dtpDateIssued.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateIssued.Location = new System.Drawing.Point(131, 73);
            this.dtpDateIssued.Name = "dtpDateIssued";
            this.dtpDateIssued.Size = new System.Drawing.Size(148, 22);
            this.dtpDateIssued.TabIndex = 88;
            // 
            // txtBankName
            // 
            this.txtBankName.Location = new System.Drawing.Point(131, 47);
            this.txtBankName.Name = "txtBankName";
            this.txtBankName.Size = new System.Drawing.Size(148, 22);
            this.txtBankName.TabIndex = 87;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 77);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 16);
            this.label10.TabIndex = 84;
            this.label10.Text = "Date Issued:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(14, 24);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(69, 16);
            this.label14.TabIndex = 82;
            this.label14.Text = "Check No:";
            // 
            // txtCheckNo
            // 
            this.txtCheckNo.Location = new System.Drawing.Point(131, 21);
            this.txtCheckNo.Name = "txtCheckNo";
            this.txtCheckNo.Size = new System.Drawing.Size(148, 22);
            this.txtCheckNo.TabIndex = 83;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(14, 50);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(80, 16);
            this.label13.TabIndex = 86;
            this.label13.Text = "Bank Name:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnPrintVoucher);
            this.groupBox1.Controls.Add(this.dgCharges);
            this.groupBox1.Controls.Add(this.btnRelease);
            this.groupBox1.Controls.Add(this.rbtnCheck);
            this.groupBox1.Controls.Add(this.rbtnCash);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtNetAmount);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtApprovedRelease);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(310, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(333, 277);
            this.groupBox1.TabIndex = 83;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Release Information";
            // 
            // btnPrintVoucher
            // 
            this.btnPrintVoucher.Location = new System.Drawing.Point(165, 236);
            this.btnPrintVoucher.Name = "btnPrintVoucher";
            this.btnPrintVoucher.Size = new System.Drawing.Size(102, 23);
            this.btnPrintVoucher.TabIndex = 85;
            this.btnPrintVoucher.Text = "Print Voucher";
            this.btnPrintVoucher.UseVisualStyleBackColor = true;
            // 
            // dgCharges
            // 
            this.dgCharges.AllowUserToAddRows = false;
            this.dgCharges.AllowUserToDeleteRows = false;
            this.dgCharges.AllowUserToResizeColumns = false;
            this.dgCharges.AllowUserToResizeRows = false;
            this.dgCharges.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgCharges.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCharges.Location = new System.Drawing.Point(127, 59);
            this.dgCharges.Name = "dgCharges";
            this.dgCharges.ReadOnly = true;
            this.dgCharges.RowHeadersVisible = false;
            this.dgCharges.Size = new System.Drawing.Size(191, 114);
            this.dgCharges.TabIndex = 84;
            // 
            // btnRelease
            // 
            this.btnRelease.Location = new System.Drawing.Point(51, 236);
            this.btnRelease.Name = "btnRelease";
            this.btnRelease.Size = new System.Drawing.Size(102, 23);
            this.btnRelease.TabIndex = 83;
            this.btnRelease.Text = "Release Loan";
            this.btnRelease.UseVisualStyleBackColor = true;
            // 
            // rbtnCheck
            // 
            this.rbtnCheck.AutoSize = true;
            this.rbtnCheck.Location = new System.Drawing.Point(248, 205);
            this.rbtnCheck.Name = "rbtnCheck";
            this.rbtnCheck.Size = new System.Drawing.Size(63, 20);
            this.rbtnCheck.TabIndex = 82;
            this.rbtnCheck.TabStop = true;
            this.rbtnCheck.Text = "Check";
            this.rbtnCheck.UseVisualStyleBackColor = true;
            // 
            // rbtnCash
            // 
            this.rbtnCash.AutoSize = true;
            this.rbtnCash.Location = new System.Drawing.Point(186, 205);
            this.rbtnCash.Name = "rbtnCash";
            this.rbtnCash.Size = new System.Drawing.Size(56, 20);
            this.rbtnCash.TabIndex = 81;
            this.rbtnCash.TabStop = true;
            this.rbtnCash.Text = "Cash";
            this.rbtnCash.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 16);
            this.label4.TabIndex = 80;
            this.label4.Text = "Release Through:";
            // 
            // txtNetAmount
            // 
            this.txtNetAmount.BackColor = System.Drawing.Color.White;
            this.txtNetAmount.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtNetAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNetAmount.ForeColor = System.Drawing.Color.Black;
            this.txtNetAmount.Location = new System.Drawing.Point(186, 179);
            this.txtNetAmount.Name = "txtNetAmount";
            this.txtNetAmount.ReadOnly = true;
            this.txtNetAmount.Size = new System.Drawing.Size(132, 22);
            this.txtNetAmount.TabIndex = 79;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 78;
            this.label3.Text = "Net Amount:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 16);
            this.label5.TabIndex = 76;
            this.label5.Text = "Less: Charges";
            // 
            // txtApprovedRelease
            // 
            this.txtApprovedRelease.BackColor = System.Drawing.Color.White;
            this.txtApprovedRelease.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtApprovedRelease.ForeColor = System.Drawing.Color.Black;
            this.txtApprovedRelease.Location = new System.Drawing.Point(186, 32);
            this.txtApprovedRelease.Name = "txtApprovedRelease";
            this.txtApprovedRelease.ReadOnly = true;
            this.txtApprovedRelease.Size = new System.Drawing.Size(132, 22);
            this.txtApprovedRelease.TabIndex = 69;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 16);
            this.label2.TabIndex = 68;
            this.label2.Text = "Approved Amount:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtApprovalDate);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txtApprovedAmount);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtRequestedAmount);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtMemberName);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtLoanNo);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(11, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(293, 163);
            this.groupBox2.TabIndex = 82;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Loan Information";
            // 
            // txtApprovalDate
            // 
            this.txtApprovalDate.BackColor = System.Drawing.Color.White;
            this.txtApprovalDate.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtApprovalDate.ForeColor = System.Drawing.Color.Black;
            this.txtApprovalDate.Location = new System.Drawing.Point(131, 124);
            this.txtApprovalDate.Name = "txtApprovalDate";
            this.txtApprovalDate.ReadOnly = true;
            this.txtApprovalDate.Size = new System.Drawing.Size(148, 22);
            this.txtApprovalDate.TabIndex = 79;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 126);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(92, 16);
            this.label12.TabIndex = 78;
            this.label12.Text = "Approval Date:";
            // 
            // txtApprovedAmount
            // 
            this.txtApprovedAmount.BackColor = System.Drawing.Color.White;
            this.txtApprovedAmount.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtApprovedAmount.ForeColor = System.Drawing.Color.Black;
            this.txtApprovedAmount.Location = new System.Drawing.Point(131, 98);
            this.txtApprovedAmount.Name = "txtApprovedAmount";
            this.txtApprovedAmount.ReadOnly = true;
            this.txtApprovedAmount.Size = new System.Drawing.Size(148, 22);
            this.txtApprovedAmount.TabIndex = 81;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 99);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(113, 16);
            this.label11.TabIndex = 80;
            this.label11.Text = "Approved Amount:";
            // 
            // txtRequestedAmount
            // 
            this.txtRequestedAmount.BackColor = System.Drawing.Color.White;
            this.txtRequestedAmount.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtRequestedAmount.ForeColor = System.Drawing.Color.Black;
            this.txtRequestedAmount.Location = new System.Drawing.Point(131, 72);
            this.txtRequestedAmount.Name = "txtRequestedAmount";
            this.txtRequestedAmount.ReadOnly = true;
            this.txtRequestedAmount.Size = new System.Drawing.Size(148, 22);
            this.txtRequestedAmount.TabIndex = 77;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 73);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 16);
            this.label9.TabIndex = 76;
            this.label9.Text = "Requested Amount:";
            // 
            // txtMemberName
            // 
            this.txtMemberName.BackColor = System.Drawing.Color.White;
            this.txtMemberName.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtMemberName.ForeColor = System.Drawing.Color.Black;
            this.txtMemberName.Location = new System.Drawing.Point(131, 47);
            this.txtMemberName.Name = "txtMemberName";
            this.txtMemberName.ReadOnly = true;
            this.txtMemberName.Size = new System.Drawing.Size(148, 22);
            this.txtMemberName.TabIndex = 75;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 16);
            this.label8.TabIndex = 74;
            this.label8.Text = "Member Name:";
            // 
            // txtLoanNo
            // 
            this.txtLoanNo.BackColor = System.Drawing.Color.White;
            this.txtLoanNo.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtLoanNo.ForeColor = System.Drawing.Color.Black;
            this.txtLoanNo.Location = new System.Drawing.Point(131, 21);
            this.txtLoanNo.Name = "txtLoanNo";
            this.txtLoanNo.ReadOnly = true;
            this.txtLoanNo.Size = new System.Drawing.Size(148, 22);
            this.txtLoanNo.TabIndex = 73;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 16);
            this.label7.TabIndex = 72;
            this.label7.Text = "Loan No:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 29);
            this.label1.TabIndex = 77;
            this.label1.Text = "Loan Releasing:";
            // 
            // dgApprovedLoans
            // 
            this.dgApprovedLoans.AllowUserToAddRows = false;
            this.dgApprovedLoans.AllowUserToDeleteRows = false;
            this.dgApprovedLoans.AllowUserToResizeColumns = false;
            this.dgApprovedLoans.AllowUserToResizeRows = false;
            this.dgApprovedLoans.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgApprovedLoans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgApprovedLoans.Location = new System.Drawing.Point(18, 83);
            this.dgApprovedLoans.Name = "dgApprovedLoans";
            this.dgApprovedLoans.ReadOnly = true;
            this.dgApprovedLoans.Size = new System.Drawing.Size(659, 141);
            this.dgApprovedLoans.TabIndex = 76;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(197, 56);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(172, 22);
            this.txtSearch.TabIndex = 74;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 16);
            this.label6.TabIndex = 72;
            this.label6.Text = "Search By:";
            // 
            // cboSearchBy
            // 
            this.cboSearchBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSearchBy.FormattingEnabled = true;
            this.cboSearchBy.Items.AddRange(new object[] {
            "Loan No",
            "Member Name"});
            this.cboSearchBy.Location = new System.Drawing.Point(90, 54);
            this.cboSearchBy.Name = "cboSearchBy";
            this.cboSearchBy.Size = new System.Drawing.Size(101, 24);
            this.cboSearchBy.TabIndex = 73;
            // 
            // TransactionLoanReleaseView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(690, 544);
            this.Controls.Add(this.panel1);
            this.Name = "TransactionLoanReleaseView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loan Release";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCharges)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgApprovedLoans)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgApprovedLoans;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboSearchBy;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker dtpDateIssued;
        private System.Windows.Forms.TextBox txtBankName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtCheckNo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnPrintVoucher;
        private System.Windows.Forms.DataGridView dgCharges;
        private System.Windows.Forms.Button btnRelease;
        private System.Windows.Forms.RadioButton rbtnCheck;
        private System.Windows.Forms.RadioButton rbtnCash;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNetAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtApprovedRelease;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtApprovalDate;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtApprovedAmount;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtRequestedAmount;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMemberName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtLoanNo;
        private System.Windows.Forms.Label label7;

    }
}