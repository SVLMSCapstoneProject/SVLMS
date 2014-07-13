namespace SVLMS.Savings.View
{
    partial class XXXSavingsWindows
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
            this.dgMembers = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cboSearchBy = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtInitialDeposit = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboSavingsType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSavingsAccountNo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnOpenAccount = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panelAccountHolder = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.btnUploadJoint2 = new System.Windows.Forms.Button();
            this.pictureSignatureJoint2 = new System.Windows.Forms.PictureBox();
            this.btnUploadJoint = new System.Windows.Forms.Button();
            this.pictureSignatureJoint = new System.Windows.Forms.PictureBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtSavingsAccountNoJoint = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtAccountHolder = new System.Windows.Forms.TextBox();
            this.btnPlus = new System.Windows.Forms.Button();
            this.panelManageAccountHolder = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgAccountHolders = new System.Windows.Forms.DataGridView();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgMembers)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panelAccountHolder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSignatureJoint2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSignatureJoint)).BeginInit();
            this.panelManageAccountHolder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAccountHolders)).BeginInit();
            this.SuspendLayout();
            // 
            // dgMembers
            // 
            this.dgMembers.AllowUserToAddRows = false;
            this.dgMembers.AllowUserToDeleteRows = false;
            this.dgMembers.AllowUserToResizeColumns = false;
            this.dgMembers.AllowUserToResizeRows = false;
            this.dgMembers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMembers.Location = new System.Drawing.Point(12, 83);
            this.dgMembers.Name = "dgMembers";
            this.dgMembers.ReadOnly = true;
            this.dgMembers.Size = new System.Drawing.Size(346, 326);
            this.dgMembers.TabIndex = 102;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(203, 56);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(149, 20);
            this.txtSearch.TabIndex = 101;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 16);
            this.label6.TabIndex = 99;
            this.label6.Text = "Search By:";
            // 
            // cboSearchBy
            // 
            this.cboSearchBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSearchBy.FormattingEnabled = true;
            this.cboSearchBy.Items.AddRange(new object[] {
            "Account No",
            "Member Name"});
            this.cboSearchBy.Location = new System.Drawing.Point(88, 56);
            this.cboSearchBy.Name = "cboSearchBy";
            this.cboSearchBy.Size = new System.Drawing.Size(109, 21);
            this.cboSearchBy.TabIndex = 100;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(294, 29);
            this.label2.TabIndex = 103;
            this.label2.Text = "Manage Savings Accounts";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(364, 58);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(549, 351);
            this.tabControl1.TabIndex = 104;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(541, 325);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Savings Accounts";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(335, 208);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(164, 23);
            this.button3.TabIndex = 11;
            this.button3.Text = "Add/Update Account Holders";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(335, 239);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(164, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Close Account";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(335, 179);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Create Savings Account";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Savings Accounts:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(52, 179);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(264, 136);
            this.dataGridView1.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(52, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(447, 99);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Member Information";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(22, 59);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(46, 16);
            this.label19.TabIndex = 14;
            this.label19.Text = "Name:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(22, 59);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(0, 16);
            this.label18.TabIndex = 13;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(22, 30);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(80, 16);
            this.label17.TabIndex = 12;
            this.label17.Text = "Account No:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.textBox4);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.txtInitialDeposit);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.cboSavingsType);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.txtSavingsAccountNo);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.btnOpenAccount);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(541, 325);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Create savings account";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(332, 153);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(141, 22);
            this.textBox4.TabIndex = 135;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(141, 156);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(185, 16);
            this.label11.TabIndex = 134;
            this.label11.Text = "Maximum Withdrawal Amount:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(62, 103);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(155, 16);
            this.label9.TabIndex = 133;
            this.label9.Text = "Savings Type Information:";
            // 
            // txtInitialDeposit
            // 
            this.txtInitialDeposit.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInitialDeposit.Location = new System.Drawing.Point(211, 195);
            this.txtInitialDeposit.Name = "txtInitialDeposit";
            this.txtInitialDeposit.Size = new System.Drawing.Size(141, 22);
            this.txtInitialDeposit.TabIndex = 130;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(62, 198);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 16);
            this.label7.TabIndex = 129;
            this.label7.Text = "Initial Deposit:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(332, 125);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(141, 22);
            this.textBox1.TabIndex = 132;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(141, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 16);
            this.label4.TabIndex = 131;
            this.label4.Text = "Interest per Annum:";
            // 
            // cboSavingsType
            // 
            this.cboSavingsType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSavingsType.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSavingsType.FormattingEnabled = true;
            this.cboSavingsType.Location = new System.Drawing.Point(211, 66);
            this.cboSavingsType.Name = "cboSavingsType";
            this.cboSavingsType.Size = new System.Drawing.Size(141, 24);
            this.cboSavingsType.TabIndex = 124;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(62, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 121;
            this.label3.Text = "Savings Type:";
            // 
            // txtSavingsAccountNo
            // 
            this.txtSavingsAccountNo.BackColor = System.Drawing.Color.White;
            this.txtSavingsAccountNo.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtSavingsAccountNo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSavingsAccountNo.ForeColor = System.Drawing.Color.Black;
            this.txtSavingsAccountNo.Location = new System.Drawing.Point(211, 36);
            this.txtSavingsAccountNo.Name = "txtSavingsAccountNo";
            this.txtSavingsAccountNo.ReadOnly = true;
            this.txtSavingsAccountNo.Size = new System.Drawing.Size(141, 22);
            this.txtSavingsAccountNo.TabIndex = 126;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(61, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 16);
            this.label8.TabIndex = 125;
            this.label8.Text = "Savings Account No:";
            // 
            // btnOpenAccount
            // 
            this.btnOpenAccount.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenAccount.Location = new System.Drawing.Point(193, 250);
            this.btnOpenAccount.Name = "btnOpenAccount";
            this.btnOpenAccount.Size = new System.Drawing.Size(168, 23);
            this.btnOpenAccount.TabIndex = 120;
            this.btnOpenAccount.Text = "Create Savings Account";
            this.btnOpenAccount.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.panelManageAccountHolder);
            this.tabPage3.Controls.Add(this.panelAccountHolder);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(541, 325);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Manage Account Holders";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // panelAccountHolder
            // 
            this.panelAccountHolder.Controls.Add(this.button6);
            this.panelAccountHolder.Controls.Add(this.btnUploadJoint2);
            this.panelAccountHolder.Controls.Add(this.pictureSignatureJoint2);
            this.panelAccountHolder.Controls.Add(this.btnUploadJoint);
            this.panelAccountHolder.Controls.Add(this.pictureSignatureJoint);
            this.panelAccountHolder.Controls.Add(this.textBox5);
            this.panelAccountHolder.Controls.Add(this.label16);
            this.panelAccountHolder.Controls.Add(this.label14);
            this.panelAccountHolder.Controls.Add(this.txtSavingsAccountNoJoint);
            this.panelAccountHolder.Controls.Add(this.label13);
            this.panelAccountHolder.Controls.Add(this.label15);
            this.panelAccountHolder.Controls.Add(this.txtAccountHolder);
            this.panelAccountHolder.Controls.Add(this.btnPlus);
            this.panelAccountHolder.Location = new System.Drawing.Point(3, 6);
            this.panelAccountHolder.Name = "panelAccountHolder";
            this.panelAccountHolder.Size = new System.Drawing.Size(538, 316);
            this.panelAccountHolder.TabIndex = 105;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(462, 16);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(65, 23);
            this.button6.TabIndex = 253;
            this.button6.Text = "Back";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnUploadJoint2
            // 
            this.btnUploadJoint2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUploadJoint2.Location = new System.Drawing.Point(350, 190);
            this.btnUploadJoint2.Name = "btnUploadJoint2";
            this.btnUploadJoint2.Size = new System.Drawing.Size(65, 23);
            this.btnUploadJoint2.TabIndex = 252;
            this.btnUploadJoint2.Text = "Upload";
            this.btnUploadJoint2.UseVisualStyleBackColor = true;
            // 
            // pictureSignatureJoint2
            // 
            this.pictureSignatureJoint2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureSignatureJoint2.Location = new System.Drawing.Point(170, 190);
            this.pictureSignatureJoint2.Name = "pictureSignatureJoint2";
            this.pictureSignatureJoint2.Size = new System.Drawing.Size(171, 81);
            this.pictureSignatureJoint2.TabIndex = 251;
            this.pictureSignatureJoint2.TabStop = false;
            // 
            // btnUploadJoint
            // 
            this.btnUploadJoint.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUploadJoint.Location = new System.Drawing.Point(347, 105);
            this.btnUploadJoint.Name = "btnUploadJoint";
            this.btnUploadJoint.Size = new System.Drawing.Size(68, 23);
            this.btnUploadJoint.TabIndex = 250;
            this.btnUploadJoint.Text = "Upload";
            this.btnUploadJoint.UseVisualStyleBackColor = true;
            // 
            // pictureSignatureJoint
            // 
            this.pictureSignatureJoint.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureSignatureJoint.Location = new System.Drawing.Point(170, 105);
            this.pictureSignatureJoint.Name = "pictureSignatureJoint";
            this.pictureSignatureJoint.Size = new System.Drawing.Size(171, 79);
            this.pictureSignatureJoint.TabIndex = 249;
            this.pictureSignatureJoint.TabStop = false;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.White;
            this.textBox5.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.ForeColor = System.Drawing.Color.Black;
            this.textBox5.Location = new System.Drawing.Point(170, 48);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(171, 22);
            this.textBox5.TabIndex = 247;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(9, 48);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(88, 16);
            this.label16.TabIndex = 246;
            this.label16.Text = "Savings Type:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(9, 102);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(67, 16);
            this.label14.TabIndex = 245;
            this.label14.Text = "Signature:";
            // 
            // txtSavingsAccountNoJoint
            // 
            this.txtSavingsAccountNoJoint.BackColor = System.Drawing.Color.White;
            this.txtSavingsAccountNoJoint.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtSavingsAccountNoJoint.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSavingsAccountNoJoint.ForeColor = System.Drawing.Color.Black;
            this.txtSavingsAccountNoJoint.Location = new System.Drawing.Point(170, 20);
            this.txtSavingsAccountNoJoint.Name = "txtSavingsAccountNoJoint";
            this.txtSavingsAccountNoJoint.ReadOnly = true;
            this.txtSavingsAccountNoJoint.Size = new System.Drawing.Size(171, 22);
            this.txtSavingsAccountNoJoint.TabIndex = 244;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(9, 20);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(128, 16);
            this.label13.TabIndex = 243;
            this.label13.Text = "Savings Account No:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(9, 73);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(115, 16);
            this.label15.TabIndex = 236;
            this.label15.Text = "Secondary Holder:";
            // 
            // txtAccountHolder
            // 
            this.txtAccountHolder.BackColor = System.Drawing.Color.White;
            this.txtAccountHolder.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtAccountHolder.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccountHolder.ForeColor = System.Drawing.Color.Black;
            this.txtAccountHolder.Location = new System.Drawing.Point(170, 76);
            this.txtAccountHolder.Name = "txtAccountHolder";
            this.txtAccountHolder.ReadOnly = true;
            this.txtAccountHolder.Size = new System.Drawing.Size(171, 22);
            this.txtAccountHolder.TabIndex = 237;
            // 
            // btnPlus
            // 
            this.btnPlus.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlus.Location = new System.Drawing.Point(347, 76);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(28, 23);
            this.btnPlus.TabIndex = 238;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            // 
            // panelManageAccountHolder
            // 
            this.panelManageAccountHolder.Controls.Add(this.button5);
            this.panelManageAccountHolder.Controls.Add(this.textBox2);
            this.panelManageAccountHolder.Controls.Add(this.button4);
            this.panelManageAccountHolder.Controls.Add(this.label10);
            this.panelManageAccountHolder.Controls.Add(this.comboBox1);
            this.panelManageAccountHolder.Controls.Add(this.label5);
            this.panelManageAccountHolder.Controls.Add(this.dgAccountHolders);
            this.panelManageAccountHolder.Controls.Add(this.textBox3);
            this.panelManageAccountHolder.Controls.Add(this.label12);
            this.panelManageAccountHolder.Location = new System.Drawing.Point(6, 6);
            this.panelManageAccountHolder.Name = "panelManageAccountHolder";
            this.panelManageAccountHolder.Size = new System.Drawing.Size(535, 319);
            this.panelManageAccountHolder.TabIndex = 210;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(382, 159);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(142, 23);
            this.button5.TabIndex = 218;
            this.button5.Text = "Update Account Holder";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.White;
            this.textBox2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.Black;
            this.textBox2.Location = new System.Drawing.Point(153, 37);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(141, 22);
            this.textBox2.TabIndex = 212;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(382, 130);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(142, 23);
            this.button4.TabIndex = 217;
            this.button4.Text = "Add Account Holder";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(14, 40);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(128, 16);
            this.label10.TabIndex = 211;
            this.label10.Text = "Savings Account No:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Member",
            "Family"});
            this.comboBox1.Location = new System.Drawing.Point(153, 93);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(141, 21);
            this.comboBox1.TabIndex = 216;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 16);
            this.label5.TabIndex = 210;
            this.label5.Text = "Savings Type:";
            // 
            // dgAccountHolders
            // 
            this.dgAccountHolders.AllowUserToAddRows = false;
            this.dgAccountHolders.AllowUserToDeleteRows = false;
            this.dgAccountHolders.AllowUserToResizeColumns = false;
            this.dgAccountHolders.AllowUserToResizeRows = false;
            this.dgAccountHolders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgAccountHolders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAccountHolders.Location = new System.Drawing.Point(153, 120);
            this.dgAccountHolders.Name = "dgAccountHolders";
            this.dgAccountHolders.ReadOnly = true;
            this.dgAccountHolders.RowHeadersVisible = false;
            this.dgAccountHolders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgAccountHolders.Size = new System.Drawing.Size(223, 123);
            this.dgAccountHolders.TabIndex = 214;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.White;
            this.textBox3.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.Color.Black;
            this.textBox3.Location = new System.Drawing.Point(153, 65);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(141, 22);
            this.textBox3.TabIndex = 213;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(14, 94);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(108, 16);
            this.label12.TabIndex = 215;
            this.label12.Text = "Account Holders:";
            // 
            // XXXSavingsWindows
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 415);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgMembers);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cboSearchBy);
            this.Name = "XXXSavingsWindows";
            this.Text = "XXXSavingsWindows";
            ((System.ComponentModel.ISupportInitialize)(this.dgMembers)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.panelAccountHolder.ResumeLayout(false);
            this.panelAccountHolder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSignatureJoint2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSignatureJoint)).EndInit();
            this.panelManageAccountHolder.ResumeLayout(false);
            this.panelManageAccountHolder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAccountHolders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgMembers;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboSearchBy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboSavingsType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSavingsAccountNo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnOpenAccount;
        private System.Windows.Forms.TextBox txtInitialDeposit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Panel panelManageAccountHolder;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgAccountHolders;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panelAccountHolder;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btnUploadJoint2;
        private System.Windows.Forms.PictureBox pictureSignatureJoint2;
        private System.Windows.Forms.Button btnUploadJoint;
        private System.Windows.Forms.PictureBox pictureSignatureJoint;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtSavingsAccountNoJoint;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtAccountHolder;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
    }
}