namespace SVLMS.Savings.View
{
    partial class TransactionCreateTimeDeposit
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cboSavingsAccountTransfer = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cboMaturityInstruction = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTimeDepositNo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtInitialDeposit = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMemberName = new System.Windows.Forms.TextBox();
            this.txtAccountNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddDeposit = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dgMembers = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.cboSearch = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.cboTerm = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgRates = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgMembers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgRates)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.btnAddDeposit);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(357, 26);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(496, 448);
            this.panel2.TabIndex = 72;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.dgRates);
            this.groupBox2.Controls.Add(this.cboTerm);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cboSavingsAccountTransfer);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.cboMaturityInstruction);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtTimeDepositNo);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtInitialDeposit);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(12, 97);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(457, 304);
            this.groupBox2.TabIndex = 65;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Time Deposit Information";
            // 
            // cboSavingsAccountTransfer
            // 
            this.cboSavingsAccountTransfer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSavingsAccountTransfer.FormattingEnabled = true;
            this.cboSavingsAccountTransfer.Items.AddRange(new object[] {
            "Cash Deposit",
            "Transfer from savings"});
            this.cboSavingsAccountTransfer.Location = new System.Drawing.Point(145, 271);
            this.cboSavingsAccountTransfer.Name = "cboSavingsAccountTransfer";
            this.cboSavingsAccountTransfer.Size = new System.Drawing.Size(154, 24);
            this.cboSavingsAccountTransfer.TabIndex = 26;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(21, 275);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 16);
            this.label10.TabIndex = 25;
            this.label10.Text = "Transfer to:";
            // 
            // cboMaturityInstruction
            // 
            this.cboMaturityInstruction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMaturityInstruction.FormattingEnabled = true;
            this.cboMaturityInstruction.Items.AddRange(new object[] {
            "No instruction",
            "Withdraw All funds",
            "Renew principal + interest",
            "Renew principal and transfer interest to savings",
            "Transfer all funds to Savings account"});
            this.cboMaturityInstruction.Location = new System.Drawing.Point(145, 242);
            this.cboMaturityInstruction.Name = "cboMaturityInstruction";
            this.cboMaturityInstruction.Size = new System.Drawing.Size(259, 24);
            this.cboMaturityInstruction.TabIndex = 24;
            this.toolTip1.SetToolTip(this.cboMaturityInstruction, "No Instruction\r\nWithdrawl all funds\r\nRenew principal + interest\r\nTransfer all fun" +
                    "ds to Savings account\r\nRenew principal and transfer interest to savings");
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 244);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 16);
            this.label9.TabIndex = 23;
            this.label9.Text = "On Maturity:";
            // 
            // txtTimeDepositNo
            // 
            this.txtTimeDepositNo.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtTimeDepositNo.Location = new System.Drawing.Point(145, 23);
            this.txtTimeDepositNo.Name = "txtTimeDepositNo";
            this.txtTimeDepositNo.Size = new System.Drawing.Size(154, 22);
            this.txtTimeDepositNo.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Time Deposit No:";
            // 
            // txtInitialDeposit
            // 
            this.txtInitialDeposit.Location = new System.Drawing.Point(143, 81);
            this.txtInitialDeposit.Name = "txtInitialDeposit";
            this.txtInitialDeposit.Size = new System.Drawing.Size(154, 22);
            this.txtInitialDeposit.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Deposited Amount:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMemberName);
            this.groupBox1.Controls.Add(this.txtAccountNo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(307, 78);
            this.groupBox1.TabIndex = 64;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Member Information";
            // 
            // txtMemberName
            // 
            this.txtMemberName.Location = new System.Drawing.Point(143, 47);
            this.txtMemberName.Name = "txtMemberName";
            this.txtMemberName.Size = new System.Drawing.Size(154, 22);
            this.txtMemberName.TabIndex = 3;
            // 
            // txtAccountNo
            // 
            this.txtAccountNo.Location = new System.Drawing.Point(143, 21);
            this.txtAccountNo.Name = "txtAccountNo";
            this.txtAccountNo.Size = new System.Drawing.Size(154, 22);
            this.txtAccountNo.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Member Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Account No:";
            // 
            // btnAddDeposit
            // 
            this.btnAddDeposit.Location = new System.Drawing.Point(110, 412);
            this.btnAddDeposit.Name = "btnAddDeposit";
            this.btnAddDeposit.Size = new System.Drawing.Size(117, 23);
            this.btnAddDeposit.TabIndex = 62;
            this.btnAddDeposit.Text = "Open Account";
            this.btnAddDeposit.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(270, 412);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 23);
            this.button2.TabIndex = 63;
            this.button2.Text = "Print Certificate";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // dgMembers
            // 
            this.dgMembers.AllowUserToAddRows = false;
            this.dgMembers.AllowUserToDeleteRows = false;
            this.dgMembers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgMembers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dgMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMembers.Location = new System.Drawing.Point(14, 83);
            this.dgMembers.Name = "dgMembers";
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgMembers.RowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dgMembers.Size = new System.Drawing.Size(337, 391);
            this.dgMembers.TabIndex = 71;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(327, 29);
            this.label6.TabIndex = 70;
            this.label6.Text = "Create Time Deposit Account";
            // 
            // cboSearch
            // 
            this.cboSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSearch.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSearch.FormattingEnabled = true;
            this.cboSearch.Items.AddRange(new object[] {
            "Account No",
            "Member Name"});
            this.cboSearch.Location = new System.Drawing.Point(86, 57);
            this.cboSearch.Name = "cboSearch";
            this.cboSearch.Size = new System.Drawing.Size(101, 24);
            this.cboSearch.TabIndex = 69;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(192, 58);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(159, 22);
            this.txtSearch.TabIndex = 68;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(11, 60);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(73, 16);
            this.label29.TabIndex = 67;
            this.label29.Text = "Search By:";
            // 
            // cboTerm
            // 
            this.cboTerm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTerm.FormattingEnabled = true;
            this.cboTerm.Location = new System.Drawing.Point(145, 51);
            this.cboTerm.Name = "cboTerm";
            this.cboTerm.Size = new System.Drawing.Size(154, 24);
            this.cboTerm.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 16);
            this.label4.TabIndex = 27;
            this.label4.Text = "Select a Term:";
            // 
            // dgRates
            // 
            this.dgRates.AllowUserToAddRows = false;
            this.dgRates.AllowUserToDeleteRows = false;
            this.dgRates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgRates.Location = new System.Drawing.Point(143, 109);
            this.dgRates.Name = "dgRates";
            this.dgRates.ReadOnly = true;
            this.dgRates.RowHeadersVisible = false;
            this.dgRates.Size = new System.Drawing.Size(305, 127);
            this.dgRates.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 16);
            this.label7.TabIndex = 30;
            this.label7.Text = "Terms and Rate:";
            // 
            // TransactionCreateTimeDeposit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(865, 485);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgMembers);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cboSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label29);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "TransactionCreateTimeDeposit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateTimeDeposit";
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgMembers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgRates)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cboSavingsAccountTransfer;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cboMaturityInstruction;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTimeDepositNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtInitialDeposit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMemberName;
        private System.Windows.Forms.TextBox txtAccountNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddDeposit;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dgMembers;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.ComboBox cboTerm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgRates;

    }
}