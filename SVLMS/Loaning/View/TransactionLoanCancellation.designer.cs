namespace SVLMS.Loaning.View
{
    partial class TransactionLoanCancellation
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCancelLoan = new System.Windows.Forms.Button();
            this.txtReasonCancellation = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtApprovalDate = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtApprovedAmount = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtLoanType = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLoanNo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMemberName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgCancelledLoan = new System.Windows.Forms.DataGridView();
            this.cboSearchBy = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCancelledLoan)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.dgCancelledLoan);
            this.panel1.Controls.Add(this.cboSearchBy);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(581, 500);
            this.panel1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCancelLoan);
            this.groupBox2.Controls.Add(this.txtReasonCancellation);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(307, 313);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(256, 172);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cancellation Information:";
            // 
            // btnCancelLoan
            // 
            this.btnCancelLoan.Location = new System.Drawing.Point(88, 142);
            this.btnCancelLoan.Name = "btnCancelLoan";
            this.btnCancelLoan.Size = new System.Drawing.Size(75, 23);
            this.btnCancelLoan.TabIndex = 2;
            this.btnCancelLoan.Text = "Cancel Loan";
            this.btnCancelLoan.UseVisualStyleBackColor = true;
            this.btnCancelLoan.Click += new System.EventHandler(this.btnCancelLoan_Click);
            // 
            // txtReasonCancellation
            // 
            this.txtReasonCancellation.Location = new System.Drawing.Point(30, 45);
            this.txtReasonCancellation.Multiline = true;
            this.txtReasonCancellation.Name = "txtReasonCancellation";
            this.txtReasonCancellation.Size = new System.Drawing.Size(196, 91);
            this.txtReasonCancellation.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Reason for Cancellation:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtApprovalDate);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtApprovedAmount);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtLoanType);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtLoanNo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtMemberName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(14, 313);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(277, 172);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Loan Information:";
            // 
            // txtApprovalDate
            // 
            this.txtApprovalDate.BackColor = System.Drawing.Color.White;
            this.txtApprovalDate.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtApprovalDate.ForeColor = System.Drawing.Color.Black;
            this.txtApprovalDate.Location = new System.Drawing.Point(126, 120);
            this.txtApprovalDate.Name = "txtApprovalDate";
            this.txtApprovalDate.ReadOnly = true;
            this.txtApprovalDate.Size = new System.Drawing.Size(145, 20);
            this.txtApprovalDate.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Approval Date:";
            // 
            // txtApprovedAmount
            // 
            this.txtApprovedAmount.BackColor = System.Drawing.Color.White;
            this.txtApprovedAmount.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtApprovedAmount.ForeColor = System.Drawing.Color.Black;
            this.txtApprovedAmount.Location = new System.Drawing.Point(126, 94);
            this.txtApprovedAmount.Name = "txtApprovedAmount";
            this.txtApprovedAmount.ReadOnly = true;
            this.txtApprovedAmount.Size = new System.Drawing.Size(145, 20);
            this.txtApprovedAmount.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Approved Amount:";
            // 
            // txtLoanType
            // 
            this.txtLoanType.BackColor = System.Drawing.Color.White;
            this.txtLoanType.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtLoanType.ForeColor = System.Drawing.Color.Black;
            this.txtLoanType.Location = new System.Drawing.Point(126, 68);
            this.txtLoanType.Name = "txtLoanType";
            this.txtLoanType.ReadOnly = true;
            this.txtLoanType.Size = new System.Drawing.Size(145, 20);
            this.txtLoanType.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Loan Type:";
            // 
            // txtLoanNo
            // 
            this.txtLoanNo.BackColor = System.Drawing.Color.White;
            this.txtLoanNo.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtLoanNo.ForeColor = System.Drawing.Color.Black;
            this.txtLoanNo.Location = new System.Drawing.Point(126, 16);
            this.txtLoanNo.Name = "txtLoanNo";
            this.txtLoanNo.ReadOnly = true;
            this.txtLoanNo.Size = new System.Drawing.Size(145, 20);
            this.txtLoanNo.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Loan No:";
            // 
            // txtMemberName
            // 
            this.txtMemberName.BackColor = System.Drawing.Color.White;
            this.txtMemberName.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtMemberName.ForeColor = System.Drawing.Color.Black;
            this.txtMemberName.Location = new System.Drawing.Point(126, 42);
            this.txtMemberName.Name = "txtMemberName";
            this.txtMemberName.ReadOnly = true;
            this.txtMemberName.Size = new System.Drawing.Size(145, 20);
            this.txtMemberName.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Member Name:";
            // 
            // dgCancelledLoan
            // 
            this.dgCancelledLoan.AllowUserToAddRows = false;
            this.dgCancelledLoan.AllowUserToDeleteRows = false;
            this.dgCancelledLoan.AllowUserToResizeColumns = false;
            this.dgCancelledLoan.AllowUserToResizeRows = false;
            this.dgCancelledLoan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgCancelledLoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCancelledLoan.Location = new System.Drawing.Point(14, 116);
            this.dgCancelledLoan.Name = "dgCancelledLoan";
            this.dgCancelledLoan.ReadOnly = true;
            this.dgCancelledLoan.Size = new System.Drawing.Size(549, 187);
            this.dgCancelledLoan.TabIndex = 11;
            this.dgCancelledLoan.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCancelledLoan_CellDoubleClick);
            // 
            // cboSearchBy
            // 
            this.cboSearchBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSearchBy.FormattingEnabled = true;
            this.cboSearchBy.Items.AddRange(new object[] {
            "Loan No",
            "Member Name"});
            this.cboSearchBy.Location = new System.Drawing.Point(73, 55);
            this.cboSearchBy.Name = "cboSearchBy";
            this.cboSearchBy.Size = new System.Drawing.Size(123, 21);
            this.cboSearchBy.TabIndex = 10;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(73, 78);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(123, 20);
            this.txtSearch.TabIndex = 9;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Search By:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "Loan Cancellation";
            // 
            // TransactionLoanCancellation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(582, 504);
            this.Controls.Add(this.panel1);
            this.Name = "TransactionLoanCancellation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loan Cancellation";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCancelledLoan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCancelLoan;
        private System.Windows.Forms.TextBox txtReasonCancellation;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtApprovedAmount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtLoanType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtLoanNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMemberName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgCancelledLoan;
        private System.Windows.Forms.ComboBox cboSearchBy;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtApprovalDate;

    }
}