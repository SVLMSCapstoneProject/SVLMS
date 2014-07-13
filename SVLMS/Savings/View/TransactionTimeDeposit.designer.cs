namespace SVLMS.Savings.View
{
    partial class TransactionTimeDeposit
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cboMaturityOption = new System.Windows.Forms.ComboBox();
            this.btnSaveMaturity = new System.Windows.Forms.Button();
            this.cboSavingsAccountTransfer = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMaturityDate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMemberName = new System.Windows.Forms.TextBox();
            this.txtTimeDepositNo = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtInterestRate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.cboSavings = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cboTransactionType = new System.Windows.Forms.ComboBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtInterest = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPenalty = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.picSignature2 = new System.Windows.Forms.PictureBox();
            this.picSignature = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgTimeDeposits = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cboSearchBy = new System.Windows.Forms.ComboBox();
            this.toolTipMaturity = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSignature2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSignature)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgTimeDeposits)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dgTimeDeposits);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.cboSearchBy);
            this.panel1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(647, 509);
            this.panel1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(16, 244);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(612, 249);
            this.tabControl1.TabIndex = 203;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox5);
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(604, 220);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Time Deposit Renewal";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.cboMaturityOption);
            this.groupBox5.Controls.Add(this.btnSaveMaturity);
            this.groupBox5.Controls.Add(this.cboSavingsAccountTransfer);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Location = new System.Drawing.Point(6, 94);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(579, 117);
            this.groupBox5.TabIndex = 215;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Renewal Instruction";
            // 
            // cboMaturityOption
            // 
            this.cboMaturityOption.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMaturityOption.FormattingEnabled = true;
            this.cboMaturityOption.Items.AddRange(new object[] {
            "No Instruction",
            "Withdrawl all funds",
            "Renew principal + interest",
            "Transfer all funds to Savings account",
            "Renew principal and transfer interest to savings"});
            this.cboMaturityOption.Location = new System.Drawing.Point(140, 25);
            this.cboMaturityOption.Name = "cboMaturityOption";
            this.cboMaturityOption.Size = new System.Drawing.Size(268, 24);
            this.cboMaturityOption.TabIndex = 218;
            this.toolTipMaturity.SetToolTip(this.cboMaturityOption, "No Instruction\r\nWithdrawl all funds\r\nRenew principal + interest\r\nTransfer all fun" +
                    "ds to Savings account\r\nRenew principal and transfer interest to savings");
            // 
            // btnSaveMaturity
            // 
            this.btnSaveMaturity.Location = new System.Drawing.Point(227, 87);
            this.btnSaveMaturity.Name = "btnSaveMaturity";
            this.btnSaveMaturity.Size = new System.Drawing.Size(127, 23);
            this.btnSaveMaturity.TabIndex = 217;
            this.btnSaveMaturity.Text = "Save";
            this.btnSaveMaturity.UseVisualStyleBackColor = true;
            // 
            // cboSavingsAccountTransfer
            // 
            this.cboSavingsAccountTransfer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSavingsAccountTransfer.FormattingEnabled = true;
            this.cboSavingsAccountTransfer.Location = new System.Drawing.Point(140, 52);
            this.cboSavingsAccountTransfer.Name = "cboSavingsAccountTransfer";
            this.cboSavingsAccountTransfer.Size = new System.Drawing.Size(127, 24);
            this.cboSavingsAccountTransfer.TabIndex = 216;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(26, 52);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(73, 16);
            this.label13.TabIndex = 215;
            this.label13.Text = "Transfer to:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 16);
            this.label5.TabIndex = 214;
            this.label5.Text = "Maturity Option:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtBalance);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtMaturityDate);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtMemberName);
            this.groupBox1.Controls.Add(this.txtTimeDepositNo);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(579, 82);
            this.groupBox1.TabIndex = 214;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Time Deposit Information";
            // 
            // txtBalance
            // 
            this.txtBalance.BackColor = System.Drawing.Color.White;
            this.txtBalance.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtBalance.ForeColor = System.Drawing.Color.Black;
            this.txtBalance.Location = new System.Drawing.Point(416, 21);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.ReadOnly = true;
            this.txtBalance.Size = new System.Drawing.Size(151, 22);
            this.txtBalance.TabIndex = 205;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(296, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 16);
            this.label7.TabIndex = 204;
            this.label7.Text = "Deposited Amount:";
            // 
            // txtMaturityDate
            // 
            this.txtMaturityDate.BackColor = System.Drawing.Color.White;
            this.txtMaturityDate.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtMaturityDate.ForeColor = System.Drawing.Color.Black;
            this.txtMaturityDate.Location = new System.Drawing.Point(416, 48);
            this.txtMaturityDate.Name = "txtMaturityDate";
            this.txtMaturityDate.ReadOnly = true;
            this.txtMaturityDate.Size = new System.Drawing.Size(151, 22);
            this.txtMaturityDate.TabIndex = 201;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(297, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 16);
            this.label2.TabIndex = 200;
            this.label2.Text = "Maturity Date:";
            // 
            // txtMemberName
            // 
            this.txtMemberName.BackColor = System.Drawing.Color.White;
            this.txtMemberName.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtMemberName.ForeColor = System.Drawing.Color.Black;
            this.txtMemberName.Location = new System.Drawing.Point(140, 48);
            this.txtMemberName.Name = "txtMemberName";
            this.txtMemberName.ReadOnly = true;
            this.txtMemberName.Size = new System.Drawing.Size(141, 22);
            this.txtMemberName.TabIndex = 199;
            // 
            // txtTimeDepositNo
            // 
            this.txtTimeDepositNo.BackColor = System.Drawing.Color.White;
            this.txtTimeDepositNo.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtTimeDepositNo.ForeColor = System.Drawing.Color.Black;
            this.txtTimeDepositNo.Location = new System.Drawing.Point(140, 21);
            this.txtTimeDepositNo.Name = "txtTimeDepositNo";
            this.txtTimeDepositNo.ReadOnly = true;
            this.txtTimeDepositNo.Size = new System.Drawing.Size(141, 22);
            this.txtTimeDepositNo.TabIndex = 197;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(31, 49);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 16);
            this.label11.TabIndex = 198;
            this.label11.Text = "Member Name:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(30, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(108, 16);
            this.label10.TabIndex = 196;
            this.label10.Text = "Time Deposit No:";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtInterestRate);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label15);
            this.tabPage1.Controls.Add(this.cboSavings);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.cboTransactionType);
            this.tabPage1.Controls.Add(this.txtTotal);
            this.tabPage1.Controls.Add(this.txtInterest);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txtPenalty);
            this.tabPage1.Controls.Add(this.txtAmount);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.btnClose);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(604, 220);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Closing of Account";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtInterestRate
            // 
            this.txtInterestRate.BackColor = System.Drawing.Color.White;
            this.txtInterestRate.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtInterestRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInterestRate.ForeColor = System.Drawing.Color.Black;
            this.txtInterestRate.Location = new System.Drawing.Point(142, 89);
            this.txtInterestRate.Name = "txtInterestRate";
            this.txtInterestRate.ReadOnly = true;
            this.txtInterestRate.Size = new System.Drawing.Size(132, 22);
            this.txtInterestRate.TabIndex = 245;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 16);
            this.label3.TabIndex = 244;
            this.label3.Text = "Interest Rate:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(11, 62);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(75, 16);
            this.label15.TabIndex = 243;
            this.label15.Text = "Transfer To:";
            // 
            // cboSavings
            // 
            this.cboSavings.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSavings.FormattingEnabled = true;
            this.cboSavings.Items.AddRange(new object[] {
            "Withdraw amount",
            "Transfer to savings"});
            this.cboSavings.Location = new System.Drawing.Point(142, 59);
            this.cboSavings.Name = "cboSavings";
            this.cboSavings.Size = new System.Drawing.Size(132, 24);
            this.cboSavings.TabIndex = 242;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(10, 32);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(110, 16);
            this.label14.TabIndex = 241;
            this.label14.Text = "Transaction Type:";
            // 
            // cboTransactionType
            // 
            this.cboTransactionType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTransactionType.FormattingEnabled = true;
            this.cboTransactionType.Items.AddRange(new object[] {
            "Withdraw amount",
            "Transfer to savings"});
            this.cboTransactionType.Location = new System.Drawing.Point(142, 29);
            this.cboTransactionType.Name = "cboTransactionType";
            this.cboTransactionType.Size = new System.Drawing.Size(132, 24);
            this.cboTransactionType.TabIndex = 240;
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.Color.White;
            this.txtTotal.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.ForeColor = System.Drawing.Color.Black;
            this.txtTotal.Location = new System.Drawing.Point(453, 115);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(132, 22);
            this.txtTotal.TabIndex = 239;
            // 
            // txtInterest
            // 
            this.txtInterest.BackColor = System.Drawing.Color.White;
            this.txtInterest.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtInterest.ForeColor = System.Drawing.Color.Black;
            this.txtInterest.Location = new System.Drawing.Point(453, 60);
            this.txtInterest.Name = "txtInterest";
            this.txtInterest.ReadOnly = true;
            this.txtInterest.Size = new System.Drawing.Size(132, 22);
            this.txtInterest.TabIndex = 235;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(299, 118);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 16);
            this.label12.TabIndex = 238;
            this.label12.Text = "Total:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(299, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 16);
            this.label4.TabIndex = 232;
            this.label4.Text = "Amount:";
            // 
            // txtPenalty
            // 
            this.txtPenalty.BackColor = System.Drawing.Color.White;
            this.txtPenalty.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtPenalty.ForeColor = System.Drawing.Color.Black;
            this.txtPenalty.Location = new System.Drawing.Point(453, 87);
            this.txtPenalty.Name = "txtPenalty";
            this.txtPenalty.ReadOnly = true;
            this.txtPenalty.Size = new System.Drawing.Size(132, 22);
            this.txtPenalty.TabIndex = 237;
            // 
            // txtAmount
            // 
            this.txtAmount.BackColor = System.Drawing.Color.White;
            this.txtAmount.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtAmount.ForeColor = System.Drawing.Color.Black;
            this.txtAmount.Location = new System.Drawing.Point(453, 29);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.ReadOnly = true;
            this.txtAmount.Size = new System.Drawing.Size(132, 22);
            this.txtAmount.TabIndex = 233;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(300, 90);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(148, 16);
            this.label9.TabIndex = 236;
            this.label9.Text = "Pre termination Penalty:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(299, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 16);
            this.label8.TabIndex = 234;
            this.label8.Text = "Interest Earned:";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(187, 176);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(192, 23);
            this.btnClose.TabIndex = 209;
            this.btnClose.Text = "Close Account";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(604, 220);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Signature";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.picSignature2);
            this.groupBox3.Controls.Add(this.picSignature);
            this.groupBox3.Location = new System.Drawing.Point(17, 18);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(581, 181);
            this.groupBox3.TabIndex = 199;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Signature";
            // 
            // picSignature2
            // 
            this.picSignature2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picSignature2.Location = new System.Drawing.Point(297, 21);
            this.picSignature2.Name = "picSignature2";
            this.picSignature2.Size = new System.Drawing.Size(274, 154);
            this.picSignature2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSignature2.TabIndex = 1;
            this.picSignature2.TabStop = false;
            // 
            // picSignature
            // 
            this.picSignature.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picSignature.Location = new System.Drawing.Point(9, 21);
            this.picSignature.Name = "picSignature";
            this.picSignature.Size = new System.Drawing.Size(274, 154);
            this.picSignature.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSignature.TabIndex = 0;
            this.picSignature.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 29);
            this.label1.TabIndex = 160;
            this.label1.Text = "Closure and Renewal";
            // 
            // dgTimeDeposits
            // 
            this.dgTimeDeposits.AllowUserToAddRows = false;
            this.dgTimeDeposits.AllowUserToDeleteRows = false;
            this.dgTimeDeposits.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgTimeDeposits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTimeDeposits.Location = new System.Drawing.Point(16, 89);
            this.dgTimeDeposits.MultiSelect = false;
            this.dgTimeDeposits.Name = "dgTimeDeposits";
            this.dgTimeDeposits.ReadOnly = true;
            this.dgTimeDeposits.Size = new System.Drawing.Size(608, 151);
            this.dgTimeDeposits.TabIndex = 159;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(207, 58);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(173, 22);
            this.txtSearch.TabIndex = 157;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 61);
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
            "Time Deposit No",
            "Member Name"});
            this.cboSearchBy.Location = new System.Drawing.Point(94, 58);
            this.cboSearchBy.Name = "cboSearchBy";
            this.cboSearchBy.Size = new System.Drawing.Size(107, 24);
            this.cboSearchBy.TabIndex = 156;
            // 
            // toolTipMaturity
            // 
            this.toolTipMaturity.ToolTipTitle = "Maturity";
            // 
            // TransactionTimeDeposit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(651, 512);
            this.Controls.Add(this.panel1);
            this.Name = "TransactionTimeDeposit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Time Deposit Closure and Renewal";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picSignature2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSignature)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgTimeDeposits)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgTimeDeposits;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboSearchBy;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox picSignature2;
        private System.Windows.Forms.PictureBox picSignature;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox cboMaturityOption;
        private System.Windows.Forms.Button btnSaveMaturity;
        private System.Windows.Forms.ComboBox cboSavingsAccountTransfer;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMaturityDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMemberName;
        private System.Windows.Forms.TextBox txtTimeDepositNo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ToolTip toolTipMaturity;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cboSavings;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cboTransactionType;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtInterest;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPenalty;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtInterestRate;
        private System.Windows.Forms.Label label3;

    }
}