namespace SVLMS.Savings.View
{
    partial class TransactionFamilyMember
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
            this.rbtnMember = new System.Windows.Forms.RadioButton();
            this.rbtnFamilyMember = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dgFamilyMember = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgFamilyMember)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.rbtnMember);
            this.panel1.Controls.Add(this.rbtnFamilyMember);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.dgFamilyMember);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(471, 308);
            this.panel1.TabIndex = 0;
            // 
            // rbtnMember
            // 
            this.rbtnMember.AutoSize = true;
            this.rbtnMember.Location = new System.Drawing.Point(207, 82);
            this.rbtnMember.Name = "rbtnMember";
            this.rbtnMember.Size = new System.Drawing.Size(73, 20);
            this.rbtnMember.TabIndex = 12;
            this.rbtnMember.Text = "Member";
            this.rbtnMember.UseVisualStyleBackColor = true;
            this.rbtnMember.Click += new System.EventHandler(this.rbtnMember_Click);
            // 
            // rbtnFamilyMember
            // 
            this.rbtnFamilyMember.AutoSize = true;
            this.rbtnFamilyMember.Checked = true;
            this.rbtnFamilyMember.Location = new System.Drawing.Point(77, 82);
            this.rbtnFamilyMember.Name = "rbtnFamilyMember";
            this.rbtnFamilyMember.Size = new System.Drawing.Size(116, 20);
            this.rbtnFamilyMember.TabIndex = 11;
            this.rbtnFamilyMember.TabStop = true;
            this.rbtnFamilyMember.Text = "Family Member";
            this.rbtnFamilyMember.UseVisualStyleBackColor = true;
            this.rbtnFamilyMember.Click += new System.EventHandler(this.rbtnFamilyMember_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Select:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(170, 273);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Select Account Holder";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.TextChanged += new System.EventHandler(this.button1_Click);
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgFamilyMember
            // 
            this.dgFamilyMember.AllowUserToAddRows = false;
            this.dgFamilyMember.AllowUserToDeleteRows = false;
            this.dgFamilyMember.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgFamilyMember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgFamilyMember.Location = new System.Drawing.Point(21, 105);
            this.dgFamilyMember.Name = "dgFamilyMember";
            this.dgFamilyMember.ReadOnly = true;
            this.dgFamilyMember.Size = new System.Drawing.Size(440, 157);
            this.dgFamilyMember.TabIndex = 8;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(135, 54);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(145, 22);
            this.txtSearch.TabIndex = 7;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Search By Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Select Joint Account Holder";
            // 
            // TransactionFamilyMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(475, 311);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "TransactionFamilyMember";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Account Holders";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgFamilyMember)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgFamilyMember;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbtnFamilyMember;
        private System.Windows.Forms.RadioButton rbtnMember;

    }
}