namespace SVLMS.Savings.View
{
    partial class TransactionMembershipTermination
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
            this.label11 = new System.Windows.Forms.Label();
            this.cboOperation = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboSearchBy = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgMembers = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtLoanBalance = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtTotalSavings = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTotalShares = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMembershipDate = new System.Windows.Forms.TextBox();
            this.txtMemberName = new System.Windows.Forms.TextBox();
            this.txtAccountNo = new System.Windows.Forms.TextBox();
            this.lblTerminationMembership = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelTermination = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cboReason = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnTerminate = new System.Windows.Forms.Button();
            this.dtpEffectivityDate = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.panelCloseAccount = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgSavingsAccounts = new System.Windows.Forms.DataGridView();
            this.btnCloseAccount = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgMembers)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panelTermination.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panelCloseAccount.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSavingsAccounts)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.cboOperation);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cboSearchBy);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.dgMembers);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(2, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(669, 556);
            this.panel1.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(5, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(405, 29);
            this.label11.TabIndex = 138;
            this.label11.Text = "Termination and Closing of Accounts";
            // 
            // cboOperation
            // 
            this.cboOperation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOperation.FormattingEnabled = true;
            this.cboOperation.Items.AddRange(new object[] {
            "Terminate Member",
            "Closing of Accounts"});
            this.cboOperation.Location = new System.Drawing.Point(114, 62);
            this.cboOperation.Name = "cboOperation";
            this.cboOperation.Size = new System.Drawing.Size(160, 24);
            this.cboOperation.TabIndex = 137;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 16);
            this.label4.TabIndex = 136;
            this.label4.Text = "Transaction:";
            // 
            // cboSearchBy
            // 
            this.cboSearchBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSearchBy.FormattingEnabled = true;
            this.cboSearchBy.Items.AddRange(new object[] {
            "Account No",
            "Member Name"});
            this.cboSearchBy.Location = new System.Drawing.Point(114, 92);
            this.cboSearchBy.Name = "cboSearchBy";
            this.cboSearchBy.Size = new System.Drawing.Size(108, 24);
            this.cboSearchBy.TabIndex = 135;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 133;
            this.label1.Text = "Search By:";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(230, 94);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(171, 22);
            this.txtSearch.TabIndex = 134;
            // 
            // dgMembers
            // 
            this.dgMembers.AllowUserToAddRows = false;
            this.dgMembers.AllowUserToDeleteRows = false;
            this.dgMembers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMembers.Location = new System.Drawing.Point(12, 122);
            this.dgMembers.Name = "dgMembers";
            this.dgMembers.ReadOnly = true;
            this.dgMembers.Size = new System.Drawing.Size(643, 138);
            this.dgMembers.TabIndex = 132;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.groupBox5);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.panelTermination);
            this.panel2.Controls.Add(this.panelCloseAccount);
            this.panel2.Location = new System.Drawing.Point(10, 266);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(645, 282);
            this.panel2.TabIndex = 108;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtLoanBalance);
            this.groupBox5.Controls.Add(this.label15);
            this.groupBox5.Controls.Add(this.txtTotalSavings);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.txtTotalShares);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.txtTotalAmount);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Location = new System.Drawing.Point(14, 135);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(311, 139);
            this.groupBox5.TabIndex = 110;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Summary";
            // 
            // txtLoanBalance
            // 
            this.txtLoanBalance.BackColor = System.Drawing.Color.White;
            this.txtLoanBalance.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtLoanBalance.ForeColor = System.Drawing.Color.Black;
            this.txtLoanBalance.Location = new System.Drawing.Point(142, 74);
            this.txtLoanBalance.Name = "txtLoanBalance";
            this.txtLoanBalance.ReadOnly = true;
            this.txtLoanBalance.Size = new System.Drawing.Size(160, 22);
            this.txtLoanBalance.TabIndex = 103;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(18, 74);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(91, 16);
            this.label15.TabIndex = 102;
            this.label15.Text = "Loan Balance:";
            // 
            // txtTotalSavings
            // 
            this.txtTotalSavings.BackColor = System.Drawing.Color.White;
            this.txtTotalSavings.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtTotalSavings.ForeColor = System.Drawing.Color.Black;
            this.txtTotalSavings.Location = new System.Drawing.Point(142, 20);
            this.txtTotalSavings.Name = "txtTotalSavings";
            this.txtTotalSavings.ReadOnly = true;
            this.txtTotalSavings.Size = new System.Drawing.Size(160, 22);
            this.txtTotalSavings.TabIndex = 101;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 16);
            this.label7.TabIndex = 100;
            this.label7.Text = "Total Savings:";
            // 
            // txtTotalShares
            // 
            this.txtTotalShares.BackColor = System.Drawing.Color.White;
            this.txtTotalShares.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtTotalShares.ForeColor = System.Drawing.Color.Black;
            this.txtTotalShares.Location = new System.Drawing.Point(142, 47);
            this.txtTotalShares.Name = "txtTotalShares";
            this.txtTotalShares.ReadOnly = true;
            this.txtTotalShares.Size = new System.Drawing.Size(160, 22);
            this.txtTotalShares.TabIndex = 99;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(18, 49);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(84, 16);
            this.label12.TabIndex = 98;
            this.label12.Text = "Total Shares:";
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.BackColor = System.Drawing.Color.White;
            this.txtTotalAmount.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtTotalAmount.ForeColor = System.Drawing.Color.Black;
            this.txtTotalAmount.Location = new System.Drawing.Point(142, 101);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.ReadOnly = true;
            this.txtTotalAmount.Size = new System.Drawing.Size(160, 22);
            this.txtTotalAmount.TabIndex = 97;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 16);
            this.label6.TabIndex = 96;
            this.label6.Text = "Total Amount:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMembershipDate);
            this.groupBox1.Controls.Add(this.txtMemberName);
            this.groupBox1.Controls.Add(this.txtAccountNo);
            this.groupBox1.Controls.Add(this.lblTerminationMembership);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(10, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(315, 116);
            this.groupBox1.TabIndex = 107;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Member Information";
            // 
            // txtMembershipDate
            // 
            this.txtMembershipDate.BackColor = System.Drawing.Color.White;
            this.txtMembershipDate.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtMembershipDate.ForeColor = System.Drawing.Color.Black;
            this.txtMembershipDate.Location = new System.Drawing.Point(146, 79);
            this.txtMembershipDate.Name = "txtMembershipDate";
            this.txtMembershipDate.ReadOnly = true;
            this.txtMembershipDate.Size = new System.Drawing.Size(160, 22);
            this.txtMembershipDate.TabIndex = 10;
            // 
            // txtMemberName
            // 
            this.txtMemberName.BackColor = System.Drawing.Color.White;
            this.txtMemberName.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtMemberName.ForeColor = System.Drawing.Color.Black;
            this.txtMemberName.Location = new System.Drawing.Point(146, 51);
            this.txtMemberName.Name = "txtMemberName";
            this.txtMemberName.ReadOnly = true;
            this.txtMemberName.Size = new System.Drawing.Size(160, 22);
            this.txtMemberName.TabIndex = 9;
            // 
            // txtAccountNo
            // 
            this.txtAccountNo.BackColor = System.Drawing.Color.White;
            this.txtAccountNo.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtAccountNo.ForeColor = System.Drawing.Color.Black;
            this.txtAccountNo.Location = new System.Drawing.Point(146, 23);
            this.txtAccountNo.Name = "txtAccountNo";
            this.txtAccountNo.ReadOnly = true;
            this.txtAccountNo.Size = new System.Drawing.Size(160, 22);
            this.txtAccountNo.TabIndex = 8;
            // 
            // lblTerminationMembership
            // 
            this.lblTerminationMembership.AutoSize = true;
            this.lblTerminationMembership.Location = new System.Drawing.Point(12, 80);
            this.lblTerminationMembership.Name = "lblTerminationMembership";
            this.lblTerminationMembership.Size = new System.Drawing.Size(128, 16);
            this.lblTerminationMembership.TabIndex = 6;
            this.lblTerminationMembership.Text = "Date of Membership:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Member Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Account No:";
            // 
            // panelTermination
            // 
            this.panelTermination.Controls.Add(this.groupBox3);
            this.panelTermination.Location = new System.Drawing.Point(343, 13);
            this.panelTermination.Name = "panelTermination";
            this.panelTermination.Size = new System.Drawing.Size(286, 186);
            this.panelTermination.TabIndex = 108;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtRemarks);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.cboReason);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.btnTerminate);
            this.groupBox3.Controls.Add(this.dtpEffectivityDate);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(7, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(262, 168);
            this.groupBox3.TabIndex = 64;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Termination";
            // 
            // txtRemarks
            // 
            this.txtRemarks.Location = new System.Drawing.Point(105, 76);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(145, 56);
            this.txtRemarks.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 76);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 16);
            this.label10.TabIndex = 15;
            this.label10.Text = "Remarks";
            // 
            // cboReason
            // 
            this.cboReason.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboReason.FormattingEnabled = true;
            this.cboReason.Items.AddRange(new object[] {
            "Voluntary",
            "Involuntary",
            "Automatic"});
            this.cboReason.Location = new System.Drawing.Point(105, 49);
            this.cboReason.Name = "cboReason";
            this.cboReason.Size = new System.Drawing.Size(145, 24);
            this.cboReason.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 49);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 16);
            this.label9.TabIndex = 13;
            this.label9.Text = "Reason:";
            // 
            // btnTerminate
            // 
            this.btnTerminate.Location = new System.Drawing.Point(64, 138);
            this.btnTerminate.Name = "btnTerminate";
            this.btnTerminate.Size = new System.Drawing.Size(132, 23);
            this.btnTerminate.TabIndex = 23;
            this.btnTerminate.Text = "Terminate Member";
            this.btnTerminate.UseVisualStyleBackColor = true;
            // 
            // dtpEffectivityDate
            // 
            this.dtpEffectivityDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEffectivityDate.Location = new System.Drawing.Point(105, 21);
            this.dtpEffectivityDate.Name = "dtpEffectivityDate";
            this.dtpEffectivityDate.Size = new System.Drawing.Size(145, 22);
            this.dtpEffectivityDate.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 16);
            this.label8.TabIndex = 11;
            this.label8.Text = "Date Effective:";
            // 
            // panelCloseAccount
            // 
            this.panelCloseAccount.Controls.Add(this.button1);
            this.panelCloseAccount.Controls.Add(this.groupBox4);
            this.panelCloseAccount.Controls.Add(this.btnCloseAccount);
            this.panelCloseAccount.Location = new System.Drawing.Point(344, 13);
            this.panelCloseAccount.Name = "panelCloseAccount";
            this.panelCloseAccount.Size = new System.Drawing.Size(285, 186);
            this.panelCloseAccount.TabIndex = 109;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(170, 150);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 23);
            this.button1.TabIndex = 93;
            this.button1.Text = "Print Voucher";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgSavingsAccounts);
            this.groupBox4.Location = new System.Drawing.Point(2, 8);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(278, 136);
            this.groupBox4.TabIndex = 92;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Accounts Information";
            // 
            // dgSavingsAccounts
            // 
            this.dgSavingsAccounts.AllowUserToAddRows = false;
            this.dgSavingsAccounts.AllowUserToDeleteRows = false;
            this.dgSavingsAccounts.AllowUserToOrderColumns = true;
            this.dgSavingsAccounts.AllowUserToResizeColumns = false;
            this.dgSavingsAccounts.AllowUserToResizeRows = false;
            this.dgSavingsAccounts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgSavingsAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSavingsAccounts.Location = new System.Drawing.Point(12, 18);
            this.dgSavingsAccounts.Name = "dgSavingsAccounts";
            this.dgSavingsAccounts.RowHeadersVisible = false;
            this.dgSavingsAccounts.Size = new System.Drawing.Size(260, 107);
            this.dgSavingsAccounts.TabIndex = 89;
            // 
            // btnCloseAccount
            // 
            this.btnCloseAccount.Location = new System.Drawing.Point(25, 150);
            this.btnCloseAccount.Name = "btnCloseAccount";
            this.btnCloseAccount.Size = new System.Drawing.Size(136, 23);
            this.btnCloseAccount.TabIndex = 91;
            this.btnCloseAccount.Text = "Close All Accounts";
            this.btnCloseAccount.UseVisualStyleBackColor = true;
            // 
            // TransactionMembershipTermination
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(671, 559);
            this.Controls.Add(this.panel1);
            this.Name = "TransactionMembershipTermination";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Termination and Closing of Accounts";
            this.Load += new System.EventHandler(this.TransactionMembershipTermination_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgMembers)).EndInit();
            this.panel2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panelTermination.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panelCloseAccount.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgSavingsAccounts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtLoanBalance;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtTotalSavings;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTotalShares;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtTotalAmount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMembershipDate;
        private System.Windows.Forms.TextBox txtMemberName;
        private System.Windows.Forms.TextBox txtAccountNo;
        private System.Windows.Forms.Label lblTerminationMembership;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelCloseAccount;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgSavingsAccounts;
        private System.Windows.Forms.Button btnCloseAccount;
        private System.Windows.Forms.Panel panelTermination;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cboReason;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnTerminate;
        private System.Windows.Forms.DateTimePicker dtpEffectivityDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cboOperation;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboSearchBy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgMembers;


    }
}