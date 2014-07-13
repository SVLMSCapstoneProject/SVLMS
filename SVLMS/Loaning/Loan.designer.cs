namespace SVLMS
{
    partial class loan_form
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
            this.dates = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.maintenanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shareCapitalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loanTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loanRatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.additionalChargesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.penaltyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shareTransactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.applicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.releasingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loanPaymentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loanModificationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.queriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.underConstructionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.underConstructionToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SkyBlue;
            this.panel1.Controls.Add(this.dates);
            this.panel1.Controls.Add(this.time);
            this.panel1.Location = new System.Drawing.Point(13, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 73);
            this.panel1.TabIndex = 19;
            // 
            // dates
            // 
            this.dates.AutoSize = true;
            this.dates.BackColor = System.Drawing.Color.Transparent;
            this.dates.Font = new System.Drawing.Font("Segoe UI Symbol", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dates.ForeColor = System.Drawing.SystemColors.Highlight;
            this.dates.Location = new System.Drawing.Point(9, 44);
            this.dates.Name = "dates";
            this.dates.Size = new System.Drawing.Size(57, 28);
            this.dates.TabIndex = 9;
            this.dates.Text = "Date";
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Font = new System.Drawing.Font("Segoe UI Symbol", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time.ForeColor = System.Drawing.SystemColors.Highlight;
            this.time.Location = new System.Drawing.Point(-1, -2);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(97, 46);
            this.time.TabIndex = 0;
            this.time.Text = "Time";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::SVLMS.Properties.Resources.icon21;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(631, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(407, 84);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::SVLMS.Properties.Resources.LOANICON;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(169, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(407, 50);
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(150, 80);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.maintenanceToolStripMenuItem,
            this.transactionToolStripMenuItem,
            this.queriesToolStripMenuItem,
            this.reportsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(13, 100);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(150, 426);
            this.menuStrip1.TabIndex = 23;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // maintenanceToolStripMenuItem
            // 
            this.maintenanceToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.maintenanceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.shareCapitalToolStripMenuItem,
            this.loanTypeToolStripMenuItem,
            this.loanRatesToolStripMenuItem,
            this.additionalChargesToolStripMenuItem,
            this.penaltyToolStripMenuItem});
            this.maintenanceToolStripMenuItem.Image = global::SVLMS.Properties.Resources.MAINTENANCEV2;
            this.maintenanceToolStripMenuItem.Name = "maintenanceToolStripMenuItem";
            this.maintenanceToolStripMenuItem.Size = new System.Drawing.Size(143, 84);
            this.maintenanceToolStripMenuItem.Text = "Maintenance";
            // 
            // shareCapitalToolStripMenuItem
            // 
            this.shareCapitalToolStripMenuItem.Name = "shareCapitalToolStripMenuItem";
            this.shareCapitalToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.shareCapitalToolStripMenuItem.Text = "Share Capital";
            this.shareCapitalToolStripMenuItem.Click += new System.EventHandler(this.shareCapitalToolStripMenuItem_Click);
            // 
            // loanTypeToolStripMenuItem
            // 
            this.loanTypeToolStripMenuItem.Name = "loanTypeToolStripMenuItem";
            this.loanTypeToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.loanTypeToolStripMenuItem.Text = "Loan Type";
            this.loanTypeToolStripMenuItem.Click += new System.EventHandler(this.loanTypeToolStripMenuItem_Click);
            // 
            // loanRatesToolStripMenuItem
            // 
            this.loanRatesToolStripMenuItem.Name = "loanRatesToolStripMenuItem";
            this.loanRatesToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.loanRatesToolStripMenuItem.Text = "Loan Rates";
            this.loanRatesToolStripMenuItem.Click += new System.EventHandler(this.loanRatesToolStripMenuItem_Click);
            // 
            // additionalChargesToolStripMenuItem
            // 
            this.additionalChargesToolStripMenuItem.Name = "additionalChargesToolStripMenuItem";
            this.additionalChargesToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.additionalChargesToolStripMenuItem.Text = "Additional Charges";
            this.additionalChargesToolStripMenuItem.Click += new System.EventHandler(this.additionalChargesToolStripMenuItem_Click);
            // 
            // penaltyToolStripMenuItem
            // 
            this.penaltyToolStripMenuItem.Name = "penaltyToolStripMenuItem";
            this.penaltyToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.penaltyToolStripMenuItem.Text = "Penalty";
            this.penaltyToolStripMenuItem.Click += new System.EventHandler(this.penaltyToolStripMenuItem_Click);
            // 
            // transactionToolStripMenuItem
            // 
            this.transactionToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.transactionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.shareTransactionToolStripMenuItem,
            this.loanToolStripMenuItem,
            this.loanPaymentToolStripMenuItem,
            this.loanModificationToolStripMenuItem});
            this.transactionToolStripMenuItem.Image = global::SVLMS.Properties.Resources.TRANSACTIONV2;
            this.transactionToolStripMenuItem.Name = "transactionToolStripMenuItem";
            this.transactionToolStripMenuItem.Size = new System.Drawing.Size(143, 84);
            this.transactionToolStripMenuItem.Text = "Transaction";
            // 
            // shareTransactionToolStripMenuItem
            // 
            this.shareTransactionToolStripMenuItem.Name = "shareTransactionToolStripMenuItem";
            this.shareTransactionToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.shareTransactionToolStripMenuItem.Text = "Share Transaction";
            this.shareTransactionToolStripMenuItem.Click += new System.EventHandler(this.shareTransactionToolStripMenuItem_Click);
            // 
            // loanToolStripMenuItem
            // 
            this.loanToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.applicationToolStripMenuItem,
            this.releasingToolStripMenuItem});
            this.loanToolStripMenuItem.Name = "loanToolStripMenuItem";
            this.loanToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.loanToolStripMenuItem.Text = "Loan";
            // 
            // applicationToolStripMenuItem
            // 
            this.applicationToolStripMenuItem.Name = "applicationToolStripMenuItem";
            this.applicationToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.applicationToolStripMenuItem.Text = "Application";
            this.applicationToolStripMenuItem.Click += new System.EventHandler(this.applicationToolStripMenuItem_Click);
            // 
            // releasingToolStripMenuItem
            // 
            this.releasingToolStripMenuItem.Name = "releasingToolStripMenuItem";
            this.releasingToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.releasingToolStripMenuItem.Text = "Releasing";
            this.releasingToolStripMenuItem.Click += new System.EventHandler(this.releasingToolStripMenuItem_Click);
            // 
            // loanPaymentToolStripMenuItem
            // 
            this.loanPaymentToolStripMenuItem.Name = "loanPaymentToolStripMenuItem";
            this.loanPaymentToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.loanPaymentToolStripMenuItem.Text = "Loan Payment";
            this.loanPaymentToolStripMenuItem.Click += new System.EventHandler(this.loanPaymentToolStripMenuItem_Click);
            // 
            // loanModificationToolStripMenuItem
            // 
            this.loanModificationToolStripMenuItem.Name = "loanModificationToolStripMenuItem";
            this.loanModificationToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.loanModificationToolStripMenuItem.Text = "Loan Modification";
            this.loanModificationToolStripMenuItem.Click += new System.EventHandler(this.loanModificationToolStripMenuItem_Click);
            // 
            // queriesToolStripMenuItem
            // 
            this.queriesToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.queriesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.underConstructionToolStripMenuItem});
            this.queriesToolStripMenuItem.Image = global::SVLMS.Properties.Resources.QUERIESV2;
            this.queriesToolStripMenuItem.Name = "queriesToolStripMenuItem";
            this.queriesToolStripMenuItem.Size = new System.Drawing.Size(143, 84);
            this.queriesToolStripMenuItem.Text = "Queries";
            // 
            // underConstructionToolStripMenuItem
            // 
            this.underConstructionToolStripMenuItem.Name = "underConstructionToolStripMenuItem";
            this.underConstructionToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.underConstructionToolStripMenuItem.Text = "(Under Construction)";
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.underConstructionToolStripMenuItem1});
            this.reportsToolStripMenuItem.Image = global::SVLMS.Properties.Resources.REPORTSV2;
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(143, 84);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // underConstructionToolStripMenuItem1
            // 
            this.underConstructionToolStripMenuItem1.Name = "underConstructionToolStripMenuItem1";
            this.underConstructionToolStripMenuItem1.Size = new System.Drawing.Size(195, 22);
            this.underConstructionToolStripMenuItem1.Text = "(Under Construction)";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.exitToolStripMenuItem.Image = global::SVLMS.Properties.Resources.exit;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(143, 84);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // loan_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SVLMS.Properties.Resources.form_bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1038, 596);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "loan_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loan Management";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label dates;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem maintenanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transactionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem queriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shareCapitalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loanTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loanRatesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem additionalChargesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem penaltyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shareTransactionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem applicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem releasingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loanPaymentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loanModificationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem underConstructionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem underConstructionToolStripMenuItem1;

    }
}