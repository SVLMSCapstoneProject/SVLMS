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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main_form));
            this.time = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.date = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.utilities = new System.Windows.Forms.Button();
            this.loan_form = new System.Windows.Forms.Button();
            this.savings_form = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Font = new System.Drawing.Font("Segoe UI Symbol", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time.ForeColor = System.Drawing.SystemColors.Highlight;
            this.time.Location = new System.Drawing.Point(-3, -4);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(132, 62);
            this.time.TabIndex = 0;
            this.time.Text = "Time";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SkyBlue;
            this.panel2.Controls.Add(this.date);
            this.panel2.Location = new System.Drawing.Point(15, 453);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(158, 29);
            this.panel2.TabIndex = 13;
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Font = new System.Drawing.Font("Segoe UI Symbol", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.ForeColor = System.Drawing.SystemColors.Highlight;
            this.date.Location = new System.Drawing.Point(5, -1);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(62, 30);
            this.date.TabIndex = 5;
            this.date.Text = "Date";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SkyBlue;
            this.panel1.Controls.Add(this.time);
            this.panel1.Location = new System.Drawing.Point(15, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(207, 59);
            this.panel1.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::SVLMS.Properties.Resources.icon21;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(604, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(409, 86);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(908, 423);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 77);
            this.button1.TabIndex = 14;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // utilities
            // 
            this.utilities.BackColor = System.Drawing.Color.Transparent;
            this.utilities.BackgroundImage = global::SVLMS.Properties.Resources.new_icon;
            this.utilities.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.utilities.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.utilities.Location = new System.Drawing.Point(652, 190);
            this.utilities.Name = "utilities";
            this.utilities.Size = new System.Drawing.Size(209, 195);
            this.utilities.TabIndex = 12;
            this.utilities.UseVisualStyleBackColor = false;
            this.utilities.Click += new System.EventHandler(this.utilities_Click);
            // 
            // loan_form
            // 
            this.loan_form.BackColor = System.Drawing.Color.Transparent;
            this.loan_form.BackgroundImage = global::SVLMS.Properties.Resources.new_icon_3;
            this.loan_form.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.loan_form.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.loan_form.Location = new System.Drawing.Point(404, 190);
            this.loan_form.Name = "loan_form";
            this.loan_form.Size = new System.Drawing.Size(221, 195);
            this.loan_form.TabIndex = 11;
            this.loan_form.UseVisualStyleBackColor = false;
            this.loan_form.Click += new System.EventHandler(this.loan_form_Click);
            // 
            // savings_form
            // 
            this.savings_form.BackColor = System.Drawing.Color.Transparent;
            this.savings_form.BackgroundImage = global::SVLMS.Properties.Resources.new_icon_2;
            this.savings_form.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.savings_form.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.savings_form.Location = new System.Drawing.Point(150, 190);
            this.savings_form.Name = "savings_form";
            this.savings_form.Size = new System.Drawing.Size(230, 195);
            this.savings_form.TabIndex = 10;
            this.savings_form.UseVisualStyleBackColor = false;
            this.savings_form.Click += new System.EventHandler(this.savings_form_Click);
            // 
            // main_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SVLMS.Properties.Resources.new_bg21;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1019, 504);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.utilities);
            this.Controls.Add(this.loan_form);
            this.Controls.Add(this.savings_form);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.Button utilities;
        private System.Windows.Forms.Button loan_form;
        private System.Windows.Forms.Button savings_form;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
      //  private System.Windows.Forms.Timer tmr;
        
        
    }
}