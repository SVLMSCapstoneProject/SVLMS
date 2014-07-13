namespace SVLMS.Loaning.View
{
    partial class TransactionLoanApprovalView
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtPaymentInterval = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCollateral = new System.Windows.Forms.TextBox();
            this.txtDateApplied = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtRequestedAmount = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMemberName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtLoanNo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnApprove = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtApprovedAmount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTermsOfPayment = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCompute = new System.Windows.Forms.Button();
            this.btnReject = new System.Windows.Forms.Button();
            this.tabPageAmortization = new System.Windows.Forms.TabPage();
            this.panelAmortization = new System.Windows.Forms.Panel();
            this.dgLoanAmortization = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblTotalInterest = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblLoanAmount = new System.Windows.Forms.Label();
            this.lblShareCapital = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.dgLoanApplications = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cboSearchBy = new System.Windows.Forms.ComboBox();
            this.panelMain.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPageAmortization.SuspendLayout();
            this.panelAmortization.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgLoanAmortization)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgLoanApplications)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelMain.Controls.Add(this.tabControl1);
            this.panelMain.Controls.Add(this.dgLoanApplications);
            this.panelMain.Controls.Add(this.label1);
            this.panelMain.Controls.Add(this.txtSearch);
            this.panelMain.Controls.Add(this.label6);
            this.panelMain.Controls.Add(this.cboSearchBy);
            this.panelMain.Location = new System.Drawing.Point(2, 1);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(598, 536);
            this.panelMain.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPageAmortization);
            this.tabControl1.Location = new System.Drawing.Point(16, 256);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(568, 254);
            this.tabControl1.TabIndex = 99;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.btnApprove);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.btnReject);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(560, 228);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Loan Information";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.txtPaymentInterval);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtCollateral);
            this.groupBox2.Controls.Add(this.txtDateApplied);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtRequestedAmount);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtMemberName);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtLoanNo);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(10, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(268, 165);
            this.groupBox2.TabIndex = 104;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Loan Information";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(14, 139);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(89, 13);
            this.label13.TabIndex = 83;
            this.label13.Text = "Payment Interval:";
            // 
            // txtPaymentInterval
            // 
            this.txtPaymentInterval.BackColor = System.Drawing.Color.White;
            this.txtPaymentInterval.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtPaymentInterval.ForeColor = System.Drawing.Color.Black;
            this.txtPaymentInterval.Location = new System.Drawing.Point(119, 139);
            this.txtPaymentInterval.Name = "txtPaymentInterval";
            this.txtPaymentInterval.ReadOnly = true;
            this.txtPaymentInterval.Size = new System.Drawing.Size(132, 20);
            this.txtPaymentInterval.TabIndex = 82;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 81;
            this.label3.Text = "Collateral";
            // 
            // txtCollateral
            // 
            this.txtCollateral.BackColor = System.Drawing.Color.White;
            this.txtCollateral.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtCollateral.ForeColor = System.Drawing.Color.Black;
            this.txtCollateral.Location = new System.Drawing.Point(119, 115);
            this.txtCollateral.Name = "txtCollateral";
            this.txtCollateral.ReadOnly = true;
            this.txtCollateral.Size = new System.Drawing.Size(132, 20);
            this.txtCollateral.TabIndex = 80;
            // 
            // txtDateApplied
            // 
            this.txtDateApplied.BackColor = System.Drawing.Color.White;
            this.txtDateApplied.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtDateApplied.ForeColor = System.Drawing.Color.Black;
            this.txtDateApplied.Location = new System.Drawing.Point(119, 89);
            this.txtDateApplied.Name = "txtDateApplied";
            this.txtDateApplied.ReadOnly = true;
            this.txtDateApplied.Size = new System.Drawing.Size(132, 20);
            this.txtDateApplied.TabIndex = 79;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 89);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 13);
            this.label10.TabIndex = 78;
            this.label10.Text = "Date Applied:";
            // 
            // txtRequestedAmount
            // 
            this.txtRequestedAmount.BackColor = System.Drawing.Color.White;
            this.txtRequestedAmount.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtRequestedAmount.ForeColor = System.Drawing.Color.Black;
            this.txtRequestedAmount.Location = new System.Drawing.Point(119, 63);
            this.txtRequestedAmount.Name = "txtRequestedAmount";
            this.txtRequestedAmount.ReadOnly = true;
            this.txtRequestedAmount.Size = new System.Drawing.Size(132, 20);
            this.txtRequestedAmount.TabIndex = 77;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 66);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 13);
            this.label9.TabIndex = 76;
            this.label9.Text = "Requested Amount:";
            // 
            // txtMemberName
            // 
            this.txtMemberName.BackColor = System.Drawing.Color.White;
            this.txtMemberName.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtMemberName.ForeColor = System.Drawing.Color.Black;
            this.txtMemberName.Location = new System.Drawing.Point(119, 37);
            this.txtMemberName.Name = "txtMemberName";
            this.txtMemberName.ReadOnly = true;
            this.txtMemberName.Size = new System.Drawing.Size(132, 20);
            this.txtMemberName.TabIndex = 75;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 13);
            this.label8.TabIndex = 74;
            this.label8.Text = "Member Name:";
            // 
            // txtLoanNo
            // 
            this.txtLoanNo.BackColor = System.Drawing.Color.White;
            this.txtLoanNo.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtLoanNo.ForeColor = System.Drawing.Color.Black;
            this.txtLoanNo.Location = new System.Drawing.Point(119, 15);
            this.txtLoanNo.Name = "txtLoanNo";
            this.txtLoanNo.ReadOnly = true;
            this.txtLoanNo.Size = new System.Drawing.Size(132, 20);
            this.txtLoanNo.TabIndex = 73;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 72;
            this.label7.Text = "Loan No:";
            // 
            // btnApprove
            // 
            this.btnApprove.Location = new System.Drawing.Point(191, 202);
            this.btnApprove.Name = "btnApprove";
            this.btnApprove.Size = new System.Drawing.Size(85, 20);
            this.btnApprove.TabIndex = 97;
            this.btnApprove.Text = "Approve";
            this.btnApprove.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtRemarks);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtApprovedAmount);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtTermsOfPayment);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnCompute);
            this.groupBox1.Location = new System.Drawing.Point(284, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(259, 165);
            this.groupBox1.TabIndex = 103;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Approval";
            // 
            // txtRemarks
            // 
            this.txtRemarks.Location = new System.Drawing.Point(118, 62);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(123, 65);
            this.txtRemarks.TabIndex = 86;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 85;
            this.label5.Text = "Remarks:";
            // 
            // txtApprovedAmount
            // 
            this.txtApprovedAmount.Location = new System.Drawing.Point(118, 40);
            this.txtApprovedAmount.Name = "txtApprovedAmount";
            this.txtApprovedAmount.Size = new System.Drawing.Size(123, 20);
            this.txtApprovedAmount.TabIndex = 84;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 83;
            this.label2.Text = "Approved Amount:";
            // 
            // txtTermsOfPayment
            // 
            this.txtTermsOfPayment.Location = new System.Drawing.Point(118, 18);
            this.txtTermsOfPayment.Name = "txtTermsOfPayment";
            this.txtTermsOfPayment.Size = new System.Drawing.Size(123, 20);
            this.txtTermsOfPayment.TabIndex = 82;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 81;
            this.label4.Text = "Terms of Payment:";
            // 
            // btnCompute
            // 
            this.btnCompute.Location = new System.Drawing.Point(61, 133);
            this.btnCompute.Name = "btnCompute";
            this.btnCompute.Size = new System.Drawing.Size(140, 23);
            this.btnCompute.TabIndex = 80;
            this.btnCompute.Text = "Compute Amortization";
            this.btnCompute.UseVisualStyleBackColor = true;
            // 
            // btnReject
            // 
            this.btnReject.Location = new System.Drawing.Point(284, 202);
            this.btnReject.Name = "btnReject";
            this.btnReject.Size = new System.Drawing.Size(85, 20);
            this.btnReject.TabIndex = 96;
            this.btnReject.Text = "Reject";
            this.btnReject.UseVisualStyleBackColor = true;
            // 
            // tabPageAmortization
            // 
            this.tabPageAmortization.Controls.Add(this.panelAmortization);
            this.tabPageAmortization.Location = new System.Drawing.Point(4, 22);
            this.tabPageAmortization.Name = "tabPageAmortization";
            this.tabPageAmortization.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAmortization.Size = new System.Drawing.Size(560, 228);
            this.tabPageAmortization.TabIndex = 1;
            this.tabPageAmortization.Text = "Amortization";
            this.tabPageAmortization.UseVisualStyleBackColor = true;
            // 
            // panelAmortization
            // 
            this.panelAmortization.Controls.Add(this.dgLoanAmortization);
            this.panelAmortization.Controls.Add(this.groupBox4);
            this.panelAmortization.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAmortization.Location = new System.Drawing.Point(3, 3);
            this.panelAmortization.Name = "panelAmortization";
            this.panelAmortization.Size = new System.Drawing.Size(554, 222);
            this.panelAmortization.TabIndex = 0;
            // 
            // dgLoanAmortization
            // 
            this.dgLoanAmortization.AllowUserToAddRows = false;
            this.dgLoanAmortization.AllowUserToDeleteRows = false;
            this.dgLoanAmortization.AllowUserToResizeColumns = false;
            this.dgLoanAmortization.AllowUserToResizeRows = false;
            this.dgLoanAmortization.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgLoanAmortization.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgLoanAmortization.Location = new System.Drawing.Point(280, 12);
            this.dgLoanAmortization.Name = "dgLoanAmortization";
            this.dgLoanAmortization.RowHeadersVisible = false;
            this.dgLoanAmortization.Size = new System.Drawing.Size(267, 194);
            this.dgLoanAmortization.TabIndex = 57;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblTotalAmount);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.lblTotalInterest);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.lblLoanAmount);
            this.groupBox4.Controls.Add(this.lblShareCapital);
            this.groupBox4.Controls.Add(this.label19);
            this.groupBox4.Controls.Add(this.label20);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(3, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(267, 154);
            this.groupBox4.TabIndex = 56;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Amortization Information";
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmount.Location = new System.Drawing.Point(188, 95);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(52, 16);
            this.lblTotalAmount.TabIndex = 66;
            this.lblTotalAmount.Text = "label21";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(14, 94);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(90, 16);
            this.label12.TabIndex = 65;
            this.label12.Text = "Total Amount:";
            // 
            // lblTotalInterest
            // 
            this.lblTotalInterest.AutoSize = true;
            this.lblTotalInterest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalInterest.Location = new System.Drawing.Point(188, 62);
            this.lblTotalInterest.Name = "lblTotalInterest";
            this.lblTotalInterest.Size = new System.Drawing.Size(52, 16);
            this.lblTotalInterest.TabIndex = 64;
            this.lblTotalInterest.Text = "label21";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(14, 61);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 16);
            this.label11.TabIndex = 63;
            this.label11.Text = "Total Interest:";
            // 
            // lblLoanAmount
            // 
            this.lblLoanAmount.AutoSize = true;
            this.lblLoanAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoanAmount.Location = new System.Drawing.Point(188, 26);
            this.lblLoanAmount.Name = "lblLoanAmount";
            this.lblLoanAmount.Size = new System.Drawing.Size(52, 16);
            this.lblLoanAmount.TabIndex = 62;
            this.lblLoanAmount.Text = "label21";
            // 
            // lblShareCapital
            // 
            this.lblShareCapital.AutoSize = true;
            this.lblShareCapital.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShareCapital.Location = new System.Drawing.Point(188, 43);
            this.lblShareCapital.Name = "lblShareCapital";
            this.lblShareCapital.Size = new System.Drawing.Size(52, 16);
            this.lblShareCapital.TabIndex = 61;
            this.lblShareCapital.Text = "label21";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(14, 43);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(128, 16);
            this.label19.TabIndex = 55;
            this.label19.Text = "Share Accumulated:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(14, 26);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(89, 16);
            this.label20.TabIndex = 56;
            this.label20.Text = "Loan Amount:";
            // 
            // dgLoanApplications
            // 
            this.dgLoanApplications.AllowUserToAddRows = false;
            this.dgLoanApplications.AllowUserToDeleteRows = false;
            this.dgLoanApplications.AllowUserToResizeColumns = false;
            this.dgLoanApplications.AllowUserToResizeRows = false;
            this.dgLoanApplications.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgLoanApplications.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgLoanApplications.Location = new System.Drawing.Point(16, 98);
            this.dgLoanApplications.Name = "dgLoanApplications";
            this.dgLoanApplications.ReadOnly = true;
            this.dgLoanApplications.Size = new System.Drawing.Size(559, 152);
            this.dgLoanApplications.TabIndex = 95;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 25);
            this.label1.TabIndex = 98;
            this.label1.Text = "Loan Approval:";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(174, 72);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(177, 20);
            this.txtSearch.TabIndex = 93;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 91;
            this.label6.Text = "Search By:";
            // 
            // cboSearchBy
            // 
            this.cboSearchBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSearchBy.FormattingEnabled = true;
            this.cboSearchBy.Items.AddRange(new object[] {
            "Loan No",
            "Member Name"});
            this.cboSearchBy.Location = new System.Drawing.Point(88, 72);
            this.cboSearchBy.Name = "cboSearchBy";
            this.cboSearchBy.Size = new System.Drawing.Size(80, 21);
            this.cboSearchBy.TabIndex = 92;
            // 
            // TransactionLoanApprovalView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(603, 539);
            this.Controls.Add(this.panelMain);
            this.Name = "TransactionLoanApprovalView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loan Approval";
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPageAmortization.ResumeLayout(false);
            this.panelAmortization.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgLoanAmortization)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgLoanApplications)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Button btnApprove;
        private System.Windows.Forms.Button btnReject;
        private System.Windows.Forms.DataGridView dgLoanApplications;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboSearchBy;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtDateApplied;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtRequestedAmount;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMemberName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtLoanNo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCompute;
        private System.Windows.Forms.TabPage tabPageAmortization;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCollateral;
        private System.Windows.Forms.TextBox txtApprovedAmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTermsOfPayment;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panelAmortization;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblLoanAmount;
        private System.Windows.Forms.Label lblShareCapital;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.DataGridView dgLoanAmortization;
        private System.Windows.Forms.Label lblTotalInterest;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtPaymentInterval;

    }
}