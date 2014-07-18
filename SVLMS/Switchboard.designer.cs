namespace SVLMS
{
    partial class main_form
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblUser = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.utilities = new System.Windows.Forms.Button();
            this.loan_form = new System.Windows.Forms.Button();
            this.savings_form = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel2.Controls.Add(this.lblUser);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 148);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(900, 39);
            this.panel2.TabIndex = 3;
            // 
            // lblUser
            // 
            this.lblUser.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblUser.Location = new System.Drawing.Point(89, 9);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(119, 21);
            this.lblUser.TabIndex = 1;
            this.lblUser.Text = "Administrator";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label2.Location = new System.Drawing.Point(14, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Welcome,";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.picLogo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 148);
            this.panel1.TabIndex = 2;
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogout.BackgroundImage = global::SVLMS.Properties.Resources.exit_bg;
            this.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Image = global::SVLMS.Properties.Resources.logout;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnLogout.Location = new System.Drawing.Point(825, 0);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 75);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.button1_Click);
            this.btnLogout.MouseLeave += new System.EventHandler(this.btnLogout_MouseLeave);
            this.btnLogout.MouseHover += new System.EventHandler(this.btnLogout_MouseHover);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(146, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(220, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "Brgy. Pinagbuhatan, Pasig City";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(146, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(256, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "Sun Sample Credit Cooperative";
            // 
            // picLogo
            // 
            this.picLogo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.picLogo.BackColor = System.Drawing.Color.Transparent;
            this.picLogo.Location = new System.Drawing.Point(12, 12);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(125, 125);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 1;
            this.picLogo.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Symbol", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(143, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(480, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Savings and Loan Management System";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel3.Controls.Add(this.lblDateTime);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 559);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(900, 41);
            this.panel3.TabIndex = 4;
            // 
            // lblDateTime
            // 
            this.lblDateTime.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateTime.ForeColor = System.Drawing.Color.White;
            this.lblDateTime.Location = new System.Drawing.Point(14, 9);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(80, 21);
            this.lblDateTime.TabIndex = 0;
            this.lblDateTime.Text = "Date Time";
            this.lblDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // utilities
            // 
            this.utilities.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.utilities.BackColor = System.Drawing.Color.Orange;
            this.utilities.FlatAppearance.BorderSize = 0;
            this.utilities.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.utilities.Font = new System.Drawing.Font("Segoe UI Symbol", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.utilities.ForeColor = System.Drawing.Color.White;
            this.utilities.Image = global::SVLMS.Properties.Resources.Gear;
            this.utilities.Location = new System.Drawing.Point(587, 214);
            this.utilities.Margin = new System.Windows.Forms.Padding(4);
            this.utilities.Name = "utilities";
            this.utilities.Padding = new System.Windows.Forms.Padding(5);
            this.utilities.Size = new System.Drawing.Size(259, 319);
            this.utilities.TabIndex = 3;
            this.utilities.Text = "Utilities";
            this.utilities.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.utilities.UseVisualStyleBackColor = false;
            this.utilities.Click += new System.EventHandler(this.utilities_Click);
            // 
            // loan_form
            // 
            this.loan_form.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loan_form.BackColor = System.Drawing.Color.DodgerBlue;
            this.loan_form.FlatAppearance.BorderSize = 0;
            this.loan_form.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loan_form.Font = new System.Drawing.Font("Segoe UI Symbol", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loan_form.ForeColor = System.Drawing.Color.White;
            this.loan_form.Image = global::SVLMS.Properties.Resources.Loan_Logo;
            this.loan_form.Location = new System.Drawing.Point(320, 214);
            this.loan_form.Margin = new System.Windows.Forms.Padding(4);
            this.loan_form.Name = "loan_form";
            this.loan_form.Padding = new System.Windows.Forms.Padding(5);
            this.loan_form.Size = new System.Drawing.Size(259, 319);
            this.loan_form.TabIndex = 2;
            this.loan_form.Text = "Loan Management";
            this.loan_form.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.loan_form.UseVisualStyleBackColor = false;
            this.loan_form.Click += new System.EventHandler(this.loan_form_Click);
            // 
            // savings_form
            // 
            this.savings_form.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.savings_form.BackColor = System.Drawing.Color.LimeGreen;
            this.savings_form.FlatAppearance.BorderSize = 0;
            this.savings_form.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.savings_form.Font = new System.Drawing.Font("Segoe UI Symbol", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savings_form.ForeColor = System.Drawing.Color.White;
            this.savings_form.Image = global::SVLMS.Properties.Resources.Savings_Logo;
            this.savings_form.Location = new System.Drawing.Point(53, 214);
            this.savings_form.Margin = new System.Windows.Forms.Padding(4);
            this.savings_form.Name = "savings_form";
            this.savings_form.Padding = new System.Windows.Forms.Padding(5);
            this.savings_form.Size = new System.Drawing.Size(259, 319);
            this.savings_form.TabIndex = 1;
            this.savings_form.Text = "Savings and Deposit";
            this.savings_form.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.savings_form.UseVisualStyleBackColor = false;
            this.savings_form.Click += new System.EventHandler(this.savings_form_Click);
            // 
            // main_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.utilities);
            this.Controls.Add(this.loan_form);
            this.Controls.Add(this.savings_form);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "main_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Switchboard";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Button loan_form;
        private System.Windows.Forms.Button savings_form;
        private System.Windows.Forms.Button utilities;

        //  private System.Windows.Forms.Timer tmr;
        
        
    }
}