namespace SVLMS.Loaning.View
{
    partial class TransactionLoanModificationView
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
            this.panelMain = new System.Windows.Forms.Panel();
            this.tabLoan = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtLoanAmount = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rbtnShareFixed = new System.Windows.Forms.RadioButton();
            this.rbtnSharePercentage = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbtnInterestFixed = new System.Windows.Forms.RadioButton();
            this.rbtnInterestPercentage = new System.Windows.Forms.RadioButton();
            this.txtShareCapitalRates = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.chkIncludePenalty = new System.Windows.Forms.CheckBox();
            this.txtTermsOfPayment = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtInterest = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cboPaymentInterval = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtRemainingPrincipal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTotalBalance = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtPenalty = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtMemberName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtLoanNo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSaveModification = new System.Windows.Forms.Button();
            this.btnComputeAmortization = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblTotalInterest = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblLoanAmount = new System.Windows.Forms.Label();
            this.lblShareCapital = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.dgLoanAmortization = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cboSearchBy = new System.Windows.Forms.ComboBox();
            this.dgLoanRecords = new System.Windows.Forms.DataGridView();
            this.panelMain.SuspendLayout();
            this.tabLoan.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgLoanAmortization)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgLoanRecords)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.tabLoan);
            this.panelMain.Controls.Add(this.label7);
            this.panelMain.Controls.Add(this.txtSearch);
            this.panelMain.Controls.Add(this.label6);
            this.panelMain.Controls.Add(this.cboSearchBy);
            this.panelMain.Controls.Add(this.dgLoanRecords);
            this.panelMain.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelMain.Location = new System.Drawing.Point(3, 3);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(691, 559);
            this.panelMain.TabIndex = 0;
            // 
            // tabLoan
            // 
            this.tabLoan.Controls.Add(this.tabPage1);
            this.tabLoan.Controls.Add(this.tabPage2);
            this.tabLoan.Location = new System.Drawing.Point(21, 242);
            this.tabLoan.Name = "tabLoan";
            this.tabLoan.SelectedIndex = 0;
            this.tabLoan.Size = new System.Drawing.Size(652, 301);
            this.tabLoan.TabIndex = 103;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtLoanAmount);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.btnSaveModification);
            this.tabPage1.Controls.Add(this.btnComputeAmortization);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(644, 272);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Loan Modification";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtLoanAmount
            // 
            this.txtLoanAmount.BackColor = System.Drawing.Color.White;
            this.txtLoanAmount.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtLoanAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoanAmount.ForeColor = System.Drawing.Color.Black;
            this.txtLoanAmount.Location = new System.Drawing.Point(144, 184);
            this.txtLoanAmount.Name = "txtLoanAmount";
            this.txtLoanAmount.ReadOnly = true;
            this.txtLoanAmount.Size = new System.Drawing.Size(132, 29);
            this.txtLoanAmount.TabIndex = 110;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(20, 192);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(117, 16);
            this.label11.TabIndex = 109;
            this.label11.Text = "New Loan Amount:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel3);
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Controls.Add(this.txtShareCapitalRates);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.chkIncludePenalty);
            this.groupBox2.Controls.Add(this.txtTermsOfPayment);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtInterest);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cboPaymentInterval);
            this.groupBox2.Location = new System.Drawing.Point(299, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(339, 212);
            this.groupBox2.TabIndex = 101;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Loan Modification Information";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.rbtnShareFixed);
            this.panel3.Controls.Add(this.rbtnSharePercentage);
            this.panel3.Location = new System.Drawing.Point(163, 96);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(162, 24);
            this.panel3.TabIndex = 117;
            // 
            // rbtnShareFixed
            // 
            this.rbtnShareFixed.AutoSize = true;
            this.rbtnShareFixed.Location = new System.Drawing.Point(2, 3);
            this.rbtnShareFixed.Name = "rbtnShareFixed";
            this.rbtnShareFixed.Size = new System.Drawing.Size(58, 20);
            this.rbtnShareFixed.TabIndex = 109;
            this.rbtnShareFixed.TabStop = true;
            this.rbtnShareFixed.Text = "Fixed";
            this.rbtnShareFixed.UseVisualStyleBackColor = true;
            // 
            // rbtnSharePercentage
            // 
            this.rbtnSharePercentage.AutoSize = true;
            this.rbtnSharePercentage.Location = new System.Drawing.Point(70, 3);
            this.rbtnSharePercentage.Name = "rbtnSharePercentage";
            this.rbtnSharePercentage.Size = new System.Drawing.Size(92, 20);
            this.rbtnSharePercentage.TabIndex = 110;
            this.rbtnSharePercentage.TabStop = true;
            this.rbtnSharePercentage.Text = "Percentage";
            this.rbtnSharePercentage.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbtnInterestFixed);
            this.panel1.Controls.Add(this.rbtnInterestPercentage);
            this.panel1.Location = new System.Drawing.Point(160, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(168, 23);
            this.panel1.TabIndex = 115;
            // 
            // rbtnInterestFixed
            // 
            this.rbtnInterestFixed.AutoSize = true;
            this.rbtnInterestFixed.Location = new System.Drawing.Point(3, 2);
            this.rbtnInterestFixed.Name = "rbtnInterestFixed";
            this.rbtnInterestFixed.Size = new System.Drawing.Size(58, 20);
            this.rbtnInterestFixed.TabIndex = 88;
            this.rbtnInterestFixed.TabStop = true;
            this.rbtnInterestFixed.Text = "Fixed";
            this.rbtnInterestFixed.UseVisualStyleBackColor = true;
            // 
            // rbtnInterestPercentage
            // 
            this.rbtnInterestPercentage.AutoSize = true;
            this.rbtnInterestPercentage.Location = new System.Drawing.Point(73, 2);
            this.rbtnInterestPercentage.Name = "rbtnInterestPercentage";
            this.rbtnInterestPercentage.Size = new System.Drawing.Size(92, 20);
            this.rbtnInterestPercentage.TabIndex = 89;
            this.rbtnInterestPercentage.TabStop = true;
            this.rbtnInterestPercentage.Text = "Percentage";
            this.rbtnInterestPercentage.UseVisualStyleBackColor = true;
            // 
            // txtShareCapitalRates
            // 
            this.txtShareCapitalRates.Location = new System.Drawing.Point(183, 72);
            this.txtShareCapitalRates.Name = "txtShareCapitalRates";
            this.txtShareCapitalRates.Size = new System.Drawing.Size(120, 22);
            this.txtShareCapitalRates.TabIndex = 112;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(14, 75);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(121, 16);
            this.label13.TabIndex = 111;
            this.label13.Text = "Share Capital Rate:";
            // 
            // chkIncludePenalty
            // 
            this.chkIncludePenalty.AutoSize = true;
            this.chkIncludePenalty.Location = new System.Drawing.Point(180, 186);
            this.chkIncludePenalty.Name = "chkIncludePenalty";
            this.chkIncludePenalty.Size = new System.Drawing.Size(116, 20);
            this.chkIncludePenalty.TabIndex = 104;
            this.chkIncludePenalty.Text = "Include Penalty";
            this.chkIncludePenalty.UseVisualStyleBackColor = true;
            // 
            // txtTermsOfPayment
            // 
            this.txtTermsOfPayment.Location = new System.Drawing.Point(182, 155);
            this.txtTermsOfPayment.Name = "txtTermsOfPayment";
            this.txtTermsOfPayment.Size = new System.Drawing.Size(121, 22);
            this.txtTermsOfPayment.TabIndex = 91;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 16);
            this.label1.TabIndex = 90;
            this.label1.Text = "Terms of Payment:(Months)";
            // 
            // txtInterest
            // 
            this.txtInterest.Location = new System.Drawing.Point(180, 19);
            this.txtInterest.Name = "txtInterest";
            this.txtInterest.Size = new System.Drawing.Size(123, 22);
            this.txtInterest.TabIndex = 80;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Interest:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Payment Interval:";
            // 
            // cboPaymentInterval
            // 
            this.cboPaymentInterval.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPaymentInterval.FormattingEnabled = true;
            this.cboPaymentInterval.Items.AddRange(new object[] {
            "Weekly",
            "Semi-monthly",
            "Monthly"});
            this.cboPaymentInterval.Location = new System.Drawing.Point(182, 126);
            this.cboPaymentInterval.Name = "cboPaymentInterval";
            this.cboPaymentInterval.Size = new System.Drawing.Size(121, 24);
            this.cboPaymentInterval.TabIndex = 83;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtRemainingPrincipal);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtTotalBalance);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.txtPenalty);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtMemberName);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtLoanNo);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(287, 167);
            this.groupBox1.TabIndex = 98;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Old Loan Information";
            // 
            // txtRemainingPrincipal
            // 
            this.txtRemainingPrincipal.BackColor = System.Drawing.Color.White;
            this.txtRemainingPrincipal.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtRemainingPrincipal.ForeColor = System.Drawing.Color.Black;
            this.txtRemainingPrincipal.Location = new System.Drawing.Point(138, 68);
            this.txtRemainingPrincipal.Name = "txtRemainingPrincipal";
            this.txtRemainingPrincipal.ReadOnly = true;
            this.txtRemainingPrincipal.Size = new System.Drawing.Size(132, 22);
            this.txtRemainingPrincipal.TabIndex = 94;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 16);
            this.label2.TabIndex = 93;
            this.label2.Text = "Remaining Principal:";
            // 
            // txtTotalBalance
            // 
            this.txtTotalBalance.BackColor = System.Drawing.Color.White;
            this.txtTotalBalance.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtTotalBalance.ForeColor = System.Drawing.Color.Black;
            this.txtTotalBalance.Location = new System.Drawing.Point(138, 119);
            this.txtTotalBalance.Name = "txtTotalBalance";
            this.txtTotalBalance.ReadOnly = true;
            this.txtTotalBalance.Size = new System.Drawing.Size(132, 22);
            this.txtTotalBalance.TabIndex = 92;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(16, 121);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(124, 16);
            this.label14.TabIndex = 91;
            this.label14.Text = "Remaining Balance:";
            // 
            // txtPenalty
            // 
            this.txtPenalty.BackColor = System.Drawing.Color.White;
            this.txtPenalty.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtPenalty.ForeColor = System.Drawing.Color.Black;
            this.txtPenalty.Location = new System.Drawing.Point(138, 93);
            this.txtPenalty.Name = "txtPenalty";
            this.txtPenalty.ReadOnly = true;
            this.txtPenalty.Size = new System.Drawing.Size(132, 22);
            this.txtPenalty.TabIndex = 90;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 95);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 16);
            this.label10.TabIndex = 89;
            this.label10.Text = "Penalties:";
            // 
            // txtMemberName
            // 
            this.txtMemberName.BackColor = System.Drawing.Color.White;
            this.txtMemberName.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtMemberName.ForeColor = System.Drawing.Color.Black;
            this.txtMemberName.Location = new System.Drawing.Point(138, 16);
            this.txtMemberName.Name = "txtMemberName";
            this.txtMemberName.ReadOnly = true;
            this.txtMemberName.Size = new System.Drawing.Size(132, 22);
            this.txtMemberName.TabIndex = 88;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 16);
            this.label9.TabIndex = 87;
            this.label9.Text = "Member Name:";
            // 
            // txtLoanNo
            // 
            this.txtLoanNo.BackColor = System.Drawing.Color.White;
            this.txtLoanNo.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtLoanNo.ForeColor = System.Drawing.Color.Black;
            this.txtLoanNo.Location = new System.Drawing.Point(138, 42);
            this.txtLoanNo.Name = "txtLoanNo";
            this.txtLoanNo.ReadOnly = true;
            this.txtLoanNo.Size = new System.Drawing.Size(132, 22);
            this.txtLoanNo.TabIndex = 86;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 16);
            this.label5.TabIndex = 85;
            this.label5.Text = "Loan No:";
            // 
            // btnSaveModification
            // 
            this.btnSaveModification.Location = new System.Drawing.Point(153, 242);
            this.btnSaveModification.Name = "btnSaveModification";
            this.btnSaveModification.Size = new System.Drawing.Size(149, 24);
            this.btnSaveModification.TabIndex = 78;
            this.btnSaveModification.Text = "Save Modification";
            this.btnSaveModification.UseVisualStyleBackColor = true;
            // 
            // btnComputeAmortization
            // 
            this.btnComputeAmortization.Location = new System.Drawing.Point(308, 242);
            this.btnComputeAmortization.Name = "btnComputeAmortization";
            this.btnComputeAmortization.Size = new System.Drawing.Size(167, 24);
            this.btnComputeAmortization.TabIndex = 77;
            this.btnComputeAmortization.Text = "Compute Amortization";
            this.btnComputeAmortization.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.dgLoanAmortization);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(644, 272);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Amortization";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblTotalAmount);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.lblTotalInterest);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.lblLoanAmount);
            this.groupBox4.Controls.Add(this.lblShareCapital);
            this.groupBox4.Controls.Add(this.label19);
            this.groupBox4.Controls.Add(this.label20);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(19, 32);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(282, 152);
            this.groupBox4.TabIndex = 103;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Amortization Information";
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmount.Location = new System.Drawing.Point(208, 116);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(20, 16);
            this.lblTotalAmount.TabIndex = 76;
            this.lblTotalAmount.Text = "---";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(33, 115);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(90, 16);
            this.label12.TabIndex = 75;
            this.label12.Text = "Total Amount:";
            // 
            // lblTotalInterest
            // 
            this.lblTotalInterest.AutoSize = true;
            this.lblTotalInterest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalInterest.Location = new System.Drawing.Point(207, 73);
            this.lblTotalInterest.Name = "lblTotalInterest";
            this.lblTotalInterest.Size = new System.Drawing.Size(20, 16);
            this.lblTotalInterest.TabIndex = 74;
            this.lblTotalInterest.Text = "---";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(33, 72);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(88, 16);
            this.label15.TabIndex = 73;
            this.label15.Text = "Total Interest:";
            // 
            // lblLoanAmount
            // 
            this.lblLoanAmount.AutoSize = true;
            this.lblLoanAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoanAmount.Location = new System.Drawing.Point(207, 27);
            this.lblLoanAmount.Name = "lblLoanAmount";
            this.lblLoanAmount.Size = new System.Drawing.Size(20, 16);
            this.lblLoanAmount.TabIndex = 72;
            this.lblLoanAmount.Text = "---";
            // 
            // lblShareCapital
            // 
            this.lblShareCapital.AutoSize = true;
            this.lblShareCapital.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShareCapital.Location = new System.Drawing.Point(207, 48);
            this.lblShareCapital.Name = "lblShareCapital";
            this.lblShareCapital.Size = new System.Drawing.Size(20, 16);
            this.lblShareCapital.TabIndex = 71;
            this.lblShareCapital.Text = "---";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(33, 48);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(92, 16);
            this.label19.TabIndex = 68;
            this.label19.Text = "Share Capital:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(33, 27);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(89, 16);
            this.label20.TabIndex = 69;
            this.label20.Text = "Loan Amount:";
            // 
            // dgLoanAmortization
            // 
            this.dgLoanAmortization.AllowUserToAddRows = false;
            this.dgLoanAmortization.AllowUserToDeleteRows = false;
            this.dgLoanAmortization.AllowUserToResizeColumns = false;
            this.dgLoanAmortization.AllowUserToResizeRows = false;
            this.dgLoanAmortization.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgLoanAmortization.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgLoanAmortization.Location = new System.Drawing.Point(320, 32);
            this.dgLoanAmortization.Name = "dgLoanAmortization";
            this.dgLoanAmortization.ReadOnly = true;
            this.dgLoanAmortization.RowHeadersVisible = false;
            this.dgLoanAmortization.Size = new System.Drawing.Size(283, 234);
            this.dgLoanAmortization.TabIndex = 101;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(317, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(171, 16);
            this.label8.TabIndex = 102;
            this.label8.Text = "New Amortization Schedule:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(208, 29);
            this.label7.TabIndex = 99;
            this.label7.Text = "Loan Modification:";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(214, 61);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(193, 22);
            this.txtSearch.TabIndex = 96;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 16);
            this.label6.TabIndex = 94;
            this.label6.Text = "Search By:";
            // 
            // cboSearchBy
            // 
            this.cboSearchBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSearchBy.FormattingEnabled = true;
            this.cboSearchBy.Items.AddRange(new object[] {
            "Loan No",
            "Member Name"});
            this.cboSearchBy.Location = new System.Drawing.Point(93, 58);
            this.cboSearchBy.Name = "cboSearchBy";
            this.cboSearchBy.Size = new System.Drawing.Size(115, 24);
            this.cboSearchBy.TabIndex = 95;
            // 
            // dgLoanRecords
            // 
            this.dgLoanRecords.AllowUserToAddRows = false;
            this.dgLoanRecords.AllowUserToDeleteRows = false;
            this.dgLoanRecords.AllowUserToResizeColumns = false;
            this.dgLoanRecords.AllowUserToResizeRows = false;
            this.dgLoanRecords.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgLoanRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgLoanRecords.Location = new System.Drawing.Point(21, 86);
            this.dgLoanRecords.Name = "dgLoanRecords";
            this.dgLoanRecords.ReadOnly = true;
            this.dgLoanRecords.Size = new System.Drawing.Size(642, 151);
            this.dgLoanRecords.TabIndex = 93;
            // 
            // TransactionLoanModificationView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(694, 562);
            this.Controls.Add(this.panelMain);
            this.Name = "TransactionLoanModificationView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loan Modification";
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.tabLoan.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgLoanAmortization)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgLoanRecords)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgLoanAmortization;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMemberName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtLoanNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboSearchBy;
        private System.Windows.Forms.DataGridView dgLoanRecords;
        private System.Windows.Forms.TextBox txtPenalty;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtRemainingPrincipal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTotalBalance;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TabControl tabLoan;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton rbtnShareFixed;
        private System.Windows.Forms.RadioButton rbtnSharePercentage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbtnInterestFixed;
        private System.Windows.Forms.RadioButton rbtnInterestPercentage;
        private System.Windows.Forms.TextBox txtShareCapitalRates;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckBox chkIncludePenalty;
        private System.Windows.Forms.TextBox txtTermsOfPayment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInterest;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSaveModification;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnComputeAmortization;
        private System.Windows.Forms.ComboBox cboPaymentInterval;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtLoanAmount;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblTotalInterest;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblLoanAmount;
        private System.Windows.Forms.Label lblShareCapital;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;

    }
}