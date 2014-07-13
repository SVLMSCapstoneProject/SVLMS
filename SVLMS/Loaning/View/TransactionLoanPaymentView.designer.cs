namespace SVLMS.Loaning.View
{
    partial class TransactionLoanPaymentView
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
            this.label10 = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtPeriod = new System.Windows.Forms.TextBox();
            this.chkAdvancePayment = new System.Windows.Forms.CheckBox();
            this.txtAmountTendered = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSavePayment = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtDueDate = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtPenalty = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAmortization = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtCurrentBalance = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtMemberName = new System.Windows.Forms.TextBox();
            this.txtLoanNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblAmountUnpaid = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.lblPenaltyAmount = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.lblRemainingAmount = new System.Windows.Forms.Label();
            this.lblAmountPaid = new System.Windows.Forms.Label();
            this.lblNoOfPayment = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.dgAmortization = new System.Windows.Forms.DataGridView();
            this.dgLoanRecords = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cboSearchBy = new System.Windows.Forms.ComboBox();
            this.btnPrintReceipt = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtChange = new System.Windows.Forms.TextBox();
            this.btnComputeTotal = new System.Windows.Forms.Button();
            this.panelMain.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAmortization)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgLoanRecords)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(555, -26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 13);
            this.label10.TabIndex = 87;
            this.label10.Text = "Amortization:";
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.tabControl1);
            this.panelMain.Controls.Add(this.dgLoanRecords);
            this.panelMain.Controls.Add(this.label1);
            this.panelMain.Controls.Add(this.txtSearch);
            this.panelMain.Controls.Add(this.label6);
            this.panelMain.Controls.Add(this.cboSearchBy);
            this.panelMain.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelMain.Location = new System.Drawing.Point(1, 1);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(971, 395);
            this.panelMain.TabIndex = 88;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(335, 69);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(620, 310);
            this.tabControl1.TabIndex = 115;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(612, 281);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Payment";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtChange);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.btnPrintReceipt);
            this.groupBox1.Controls.Add(this.btnComputeTotal);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.txtPeriod);
            this.groupBox1.Controls.Add(this.chkAdvancePayment);
            this.groupBox1.Controls.Add(this.txtAmountTendered);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.btnSavePayment);
            this.groupBox1.Location = new System.Drawing.Point(311, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(277, 215);
            this.groupBox1.TabIndex = 125;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Payment Information";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(11, 23);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(87, 16);
            this.label14.TabIndex = 117;
            this.label14.Text = "No. of Period:";
            // 
            // txtPeriod
            // 
            this.txtPeriod.Location = new System.Drawing.Point(130, 21);
            this.txtPeriod.Name = "txtPeriod";
            this.txtPeriod.Size = new System.Drawing.Size(48, 22);
            this.txtPeriod.TabIndex = 116;
            // 
            // chkAdvancePayment
            // 
            this.chkAdvancePayment.AutoSize = true;
            this.chkAdvancePayment.Location = new System.Drawing.Point(41, 81);
            this.chkAdvancePayment.Name = "chkAdvancePayment";
            this.chkAdvancePayment.Size = new System.Drawing.Size(241, 20);
            this.chkAdvancePayment.TabIndex = 103;
            this.chkAdvancePayment.Text = "Include Change on Next Amortization";
            this.chkAdvancePayment.UseVisualStyleBackColor = true;
            // 
            // txtAmountTendered
            // 
            this.txtAmountTendered.Location = new System.Drawing.Point(130, 49);
            this.txtAmountTendered.Name = "txtAmountTendered";
            this.txtAmountTendered.Size = new System.Drawing.Size(134, 22);
            this.txtAmountTendered.TabIndex = 100;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 16);
            this.label8.TabIndex = 101;
            this.label8.Text = "Amount Tendered:";
            // 
            // btnSavePayment
            // 
            this.btnSavePayment.Location = new System.Drawing.Point(48, 122);
            this.btnSavePayment.Name = "btnSavePayment";
            this.btnSavePayment.Size = new System.Drawing.Size(105, 23);
            this.btnSavePayment.TabIndex = 98;
            this.btnSavePayment.Text = "Save Payment";
            this.btnSavePayment.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtDueDate);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.txtPenalty);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtAmortization);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtTotal);
            this.groupBox3.Location = new System.Drawing.Point(6, 138);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(299, 129);
            this.groupBox3.TabIndex = 124;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Amortization";
            // 
            // txtDueDate
            // 
            this.txtDueDate.BackColor = System.Drawing.Color.White;
            this.txtDueDate.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtDueDate.ForeColor = System.Drawing.Color.Black;
            this.txtDueDate.Location = new System.Drawing.Point(132, 19);
            this.txtDueDate.Name = "txtDueDate";
            this.txtDueDate.ReadOnly = true;
            this.txtDueDate.Size = new System.Drawing.Size(159, 22);
            this.txtDueDate.TabIndex = 84;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 22);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 16);
            this.label12.TabIndex = 85;
            this.label12.Text = "Due Date:";
            // 
            // txtPenalty
            // 
            this.txtPenalty.BackColor = System.Drawing.Color.White;
            this.txtPenalty.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtPenalty.ForeColor = System.Drawing.Color.Black;
            this.txtPenalty.Location = new System.Drawing.Point(132, 71);
            this.txtPenalty.Name = "txtPenalty";
            this.txtPenalty.ReadOnly = true;
            this.txtPenalty.Size = new System.Drawing.Size(159, 22);
            this.txtPenalty.TabIndex = 82;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 16);
            this.label5.TabIndex = 77;
            this.label5.Text = "Penalty:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 16);
            this.label7.TabIndex = 78;
            this.label7.Text = "Total:";
            // 
            // txtAmortization
            // 
            this.txtAmortization.BackColor = System.Drawing.Color.White;
            this.txtAmortization.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtAmortization.ForeColor = System.Drawing.Color.Black;
            this.txtAmortization.Location = new System.Drawing.Point(132, 45);
            this.txtAmortization.Name = "txtAmortization";
            this.txtAmortization.ReadOnly = true;
            this.txtAmortization.Size = new System.Drawing.Size(159, 22);
            this.txtAmortization.TabIndex = 76;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 16);
            this.label4.TabIndex = 76;
            this.label4.Text = "Amount to be paid:";
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.Color.White;
            this.txtTotal.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.ForeColor = System.Drawing.Color.Black;
            this.txtTotal.Location = new System.Drawing.Point(132, 97);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(159, 22);
            this.txtTotal.TabIndex = 83;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtCurrentBalance);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtMemberName);
            this.groupBox2.Controls.Add(this.txtLoanNo);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(6, 16);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(299, 116);
            this.groupBox2.TabIndex = 123;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Loan Information";
            // 
            // txtCurrentBalance
            // 
            this.txtCurrentBalance.BackColor = System.Drawing.Color.White;
            this.txtCurrentBalance.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtCurrentBalance.ForeColor = System.Drawing.Color.Black;
            this.txtCurrentBalance.Location = new System.Drawing.Point(132, 78);
            this.txtCurrentBalance.Name = "txtCurrentBalance";
            this.txtCurrentBalance.ReadOnly = true;
            this.txtCurrentBalance.Size = new System.Drawing.Size(159, 22);
            this.txtCurrentBalance.TabIndex = 110;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 82);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(105, 16);
            this.label11.TabIndex = 109;
            this.label11.Text = "Current Balance:";
            // 
            // txtMemberName
            // 
            this.txtMemberName.BackColor = System.Drawing.Color.White;
            this.txtMemberName.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtMemberName.ForeColor = System.Drawing.Color.Black;
            this.txtMemberName.Location = new System.Drawing.Point(132, 50);
            this.txtMemberName.Name = "txtMemberName";
            this.txtMemberName.ReadOnly = true;
            this.txtMemberName.Size = new System.Drawing.Size(159, 22);
            this.txtMemberName.TabIndex = 106;
            // 
            // txtLoanNo
            // 
            this.txtLoanNo.BackColor = System.Drawing.Color.White;
            this.txtLoanNo.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtLoanNo.ForeColor = System.Drawing.Color.Black;
            this.txtLoanNo.Location = new System.Drawing.Point(132, 24);
            this.txtLoanNo.Name = "txtLoanNo";
            this.txtLoanNo.ReadOnly = true;
            this.txtLoanNo.Size = new System.Drawing.Size(159, 22);
            this.txtLoanNo.TabIndex = 108;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 16);
            this.label3.TabIndex = 107;
            this.label3.Text = "Member Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 105;
            this.label2.Text = "Loan No:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lblAmountUnpaid);
            this.tabPage2.Controls.Add(this.label23);
            this.tabPage2.Controls.Add(this.lblPenaltyAmount);
            this.tabPage2.Controls.Add(this.label21);
            this.tabPage2.Controls.Add(this.lblRemainingAmount);
            this.tabPage2.Controls.Add(this.lblAmountPaid);
            this.tabPage2.Controls.Add(this.lblNoOfPayment);
            this.tabPage2.Controls.Add(this.label20);
            this.tabPage2.Controls.Add(this.label19);
            this.tabPage2.Controls.Add(this.label18);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.dgAmortization);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(612, 281);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "View Amortization";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblAmountUnpaid
            // 
            this.lblAmountUnpaid.AutoSize = true;
            this.lblAmountUnpaid.ForeColor = System.Drawing.Color.Red;
            this.lblAmountUnpaid.Location = new System.Drawing.Point(193, 168);
            this.lblAmountUnpaid.Name = "lblAmountUnpaid";
            this.lblAmountUnpaid.Size = new System.Drawing.Size(20, 16);
            this.lblAmountUnpaid.TabIndex = 11;
            this.lblAmountUnpaid.Text = "---";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(17, 168);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(127, 16);
            this.label23.TabIndex = 10;
            this.label23.Text = "Total Amount Unpaid";
            // 
            // lblPenaltyAmount
            // 
            this.lblPenaltyAmount.AutoSize = true;
            this.lblPenaltyAmount.Location = new System.Drawing.Point(193, 150);
            this.lblPenaltyAmount.Name = "lblPenaltyAmount";
            this.lblPenaltyAmount.Size = new System.Drawing.Size(20, 16);
            this.lblPenaltyAmount.TabIndex = 9;
            this.lblPenaltyAmount.Text = "---";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(17, 150);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(135, 16);
            this.label21.TabIndex = 8;
            this.label21.Text = "Total Penalty Amount:";
            // 
            // lblRemainingAmount
            // 
            this.lblRemainingAmount.AutoSize = true;
            this.lblRemainingAmount.Location = new System.Drawing.Point(193, 132);
            this.lblRemainingAmount.Name = "lblRemainingAmount";
            this.lblRemainingAmount.Size = new System.Drawing.Size(20, 16);
            this.lblRemainingAmount.TabIndex = 7;
            this.lblRemainingAmount.Text = "---";
            // 
            // lblAmountPaid
            // 
            this.lblAmountPaid.AutoSize = true;
            this.lblAmountPaid.Location = new System.Drawing.Point(193, 73);
            this.lblAmountPaid.Name = "lblAmountPaid";
            this.lblAmountPaid.Size = new System.Drawing.Size(20, 16);
            this.lblAmountPaid.TabIndex = 6;
            this.lblAmountPaid.Text = "---";
            // 
            // lblNoOfPayment
            // 
            this.lblNoOfPayment.AutoSize = true;
            this.lblNoOfPayment.Location = new System.Drawing.Point(193, 54);
            this.lblNoOfPayment.Name = "lblNoOfPayment";
            this.lblNoOfPayment.Size = new System.Drawing.Size(20, 16);
            this.lblNoOfPayment.TabIndex = 5;
            this.lblNoOfPayment.Text = "---";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(17, 132);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(152, 16);
            this.label20.TabIndex = 4;
            this.label20.Text = "Total Remaining Amount:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(17, 54);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(153, 16);
            this.label19.TabIndex = 3;
            this.label19.Text = "No. Of Installments Paid:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(17, 73);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(117, 16);
            this.label18.TabIndex = 2;
            this.label18.Text = "Total Amount Paid:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(277, 29);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(143, 16);
            this.label15.TabIndex = 1;
            this.label15.Text = "Amortization Schedule:";
            // 
            // dgAmortization
            // 
            this.dgAmortization.AllowUserToAddRows = false;
            this.dgAmortization.AllowUserToDeleteRows = false;
            this.dgAmortization.AllowUserToResizeColumns = false;
            this.dgAmortization.AllowUserToResizeRows = false;
            this.dgAmortization.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgAmortization.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAmortization.Location = new System.Drawing.Point(280, 45);
            this.dgAmortization.Name = "dgAmortization";
            this.dgAmortization.ReadOnly = true;
            this.dgAmortization.RowHeadersVisible = false;
            this.dgAmortization.Size = new System.Drawing.Size(295, 212);
            this.dgAmortization.TabIndex = 0;
            // 
            // dgLoanRecords
            // 
            this.dgLoanRecords.AllowUserToAddRows = false;
            this.dgLoanRecords.AllowUserToDeleteRows = false;
            this.dgLoanRecords.AllowUserToResizeColumns = false;
            this.dgLoanRecords.AllowUserToResizeRows = false;
            this.dgLoanRecords.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgLoanRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgLoanRecords.Location = new System.Drawing.Point(21, 103);
            this.dgLoanRecords.Name = "dgLoanRecords";
            this.dgLoanRecords.ReadOnly = true;
            this.dgLoanRecords.RowHeadersVisible = false;
            this.dgLoanRecords.Size = new System.Drawing.Size(308, 276);
            this.dgLoanRecords.TabIndex = 114;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 29);
            this.label1.TabIndex = 111;
            this.label1.Text = "Loan Payment:";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(202, 75);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(127, 22);
            this.txtSearch.TabIndex = 109;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 16);
            this.label6.TabIndex = 107;
            this.label6.Text = "Search By:";
            // 
            // cboSearchBy
            // 
            this.cboSearchBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSearchBy.FormattingEnabled = true;
            this.cboSearchBy.Items.AddRange(new object[] {
            "Loan No",
            "Member Name"});
            this.cboSearchBy.Location = new System.Drawing.Point(91, 74);
            this.cboSearchBy.Name = "cboSearchBy";
            this.cboSearchBy.Size = new System.Drawing.Size(107, 24);
            this.cboSearchBy.TabIndex = 108;
            // 
            // btnPrintReceipt
            // 
            this.btnPrintReceipt.Location = new System.Drawing.Point(159, 122);
            this.btnPrintReceipt.Name = "btnPrintReceipt";
            this.btnPrintReceipt.Size = new System.Drawing.Size(105, 23);
            this.btnPrintReceipt.TabIndex = 128;
            this.btnPrintReceipt.Text = "Print Receipt";
            this.btnPrintReceipt.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 170);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 16);
            this.label9.TabIndex = 127;
            this.label9.Text = "Change:";
            // 
            // txtChange
            // 
            this.txtChange.BackColor = System.Drawing.Color.White;
            this.txtChange.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtChange.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChange.ForeColor = System.Drawing.Color.Black;
            this.txtChange.Location = new System.Drawing.Point(130, 165);
            this.txtChange.Name = "txtChange";
            this.txtChange.ReadOnly = true;
            this.txtChange.Size = new System.Drawing.Size(136, 26);
            this.txtChange.TabIndex = 126;
            // 
            // btnComputeTotal
            // 
            this.btnComputeTotal.Location = new System.Drawing.Point(184, 20);
            this.btnComputeTotal.Name = "btnComputeTotal";
            this.btnComputeTotal.Size = new System.Drawing.Size(80, 23);
            this.btnComputeTotal.TabIndex = 119;
            this.btnComputeTotal.Text = "Compute";
            this.btnComputeTotal.UseVisualStyleBackColor = true;
            // 
            // TransactionLoanPaymentView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(974, 397);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.label10);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "TransactionLoanPaymentView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loan Payment";
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAmortization)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgLoanRecords)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.DataGridView dgLoanRecords;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboSearchBy;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtDueDate;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtPenalty;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAmortization;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtCurrentBalance;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtMemberName;
        private System.Windows.Forms.TextBox txtLoanNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridView dgAmortization;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lblRemainingAmount;
        private System.Windows.Forms.Label lblAmountPaid;
        private System.Windows.Forms.Label lblNoOfPayment;
        private System.Windows.Forms.Label lblAmountUnpaid;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label lblPenaltyAmount;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtPeriod;
        private System.Windows.Forms.CheckBox chkAdvancePayment;
        private System.Windows.Forms.TextBox txtAmountTendered;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSavePayment;
        private System.Windows.Forms.Button btnPrintReceipt;
        private System.Windows.Forms.TextBox txtChange;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnComputeTotal;
    }
}