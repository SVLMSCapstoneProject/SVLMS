namespace SVLMS.Loaning.View
{
    partial class MaintenanceMemberType
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MaintenanceMemberType));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgMemberType = new System.Windows.Forms.DataGridView();
            this.panelSearch = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearchBox = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cboFilter = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.HasCertificatepanel = new System.Windows.Forms.Panel();
            this.chkHasCertificate = new System.Windows.Forms.CheckBox();
            this.statusPanel = new System.Windows.Forms.Panel();
            this.rbtnInactive = new System.Windows.Forms.RadioButton();
            this.rbtnActive = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTypeName = new System.Windows.Forms.TextBox();
            this.txtMinimumShare = new System.Windows.Forms.TextBox();
            this.txtTypeID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panelSavingsTypeTitle = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgMemberType)).BeginInit();
            this.panelSearch.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.HasCertificatepanel.SuspendLayout();
            this.statusPanel.SuspendLayout();
            this.panelSavingsTypeTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgMemberType);
            this.panel1.Controls.Add(this.panelSearch);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.panelSavingsTypeTitle);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // dgMemberType
            // 
            this.dgMemberType.AllowUserToAddRows = false;
            this.dgMemberType.AllowUserToDeleteRows = false;
            this.dgMemberType.AllowUserToOrderColumns = true;
            this.dgMemberType.AllowUserToResizeColumns = false;
            this.dgMemberType.AllowUserToResizeRows = false;
            this.dgMemberType.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgMemberType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dgMemberType, "dgMemberType");
            this.dgMemberType.Name = "dgMemberType";
            this.dgMemberType.ReadOnly = true;
            // 
            // panelSearch
            // 
            this.panelSearch.Controls.Add(this.label10);
            this.panelSearch.Controls.Add(this.label2);
            this.panelSearch.Controls.Add(this.txtSearchBox);
            this.panelSearch.Controls.Add(this.btnSearch);
            this.panelSearch.Controls.Add(this.cboFilter);
            resources.ApplyResources(this.panelSearch, "panelSearch");
            this.panelSearch.Name = "panelSearch";
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // txtSearchBox
            // 
            resources.ApplyResources(this.txtSearchBox, "txtSearchBox");
            this.txtSearchBox.Name = "txtSearchBox";
            // 
            // btnSearch
            // 
            resources.ApplyResources(this.btnSearch, "btnSearch");
            this.btnSearch.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSearch.BackgroundImage = global::SVLMS.Properties.Resources.find_icon;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // cboFilter
            // 
            resources.ApplyResources(this.cboFilter, "cboFilter");
            this.cboFilter.FormattingEnabled = true;
            this.cboFilter.Items.AddRange(new object[] {
            resources.GetString("cboFilter.Items"),
            resources.GetString("cboFilter.Items1"),
            resources.GetString("cboFilter.Items2")});
            this.cboFilter.Name = "cboFilter";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.HasCertificatepanel);
            this.groupBox1.Controls.Add(this.statusPanel);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtTypeName);
            this.groupBox1.Controls.Add(this.txtMinimumShare);
            this.groupBox1.Controls.Add(this.txtTypeID);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // btnUpdate
            // 
            resources.ApplyResources(this.btnUpdate, "btnUpdate");
            this.btnUpdate.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnUpdate.BackgroundImage = global::SVLMS.Properties.Resources.save_icon;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            resources.ApplyResources(this.btnClear, "btnClear");
            this.btnClear.BackColor = System.Drawing.Color.Red;
            this.btnClear.BackgroundImage = global::SVLMS.Properties.Resources.cancel_icon;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnClear.Name = "btnClear";
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            resources.ApplyResources(this.btnSave, "btnSave");
            this.btnSave.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnSave.BackgroundImage = global::SVLMS.Properties.Resources.add_icon;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSave.Name = "btnSave";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // HasCertificatepanel
            // 
            this.HasCertificatepanel.Controls.Add(this.chkHasCertificate);
            resources.ApplyResources(this.HasCertificatepanel, "HasCertificatepanel");
            this.HasCertificatepanel.Name = "HasCertificatepanel";
            // 
            // chkHasCertificate
            // 
            resources.ApplyResources(this.chkHasCertificate, "chkHasCertificate");
            this.chkHasCertificate.Name = "chkHasCertificate";
            this.chkHasCertificate.UseVisualStyleBackColor = true;
            // 
            // statusPanel
            // 
            this.statusPanel.Controls.Add(this.rbtnInactive);
            this.statusPanel.Controls.Add(this.rbtnActive);
            resources.ApplyResources(this.statusPanel, "statusPanel");
            this.statusPanel.Name = "statusPanel";
            // 
            // rbtnInactive
            // 
            resources.ApplyResources(this.rbtnInactive, "rbtnInactive");
            this.rbtnInactive.Name = "rbtnInactive";
            this.rbtnInactive.TabStop = true;
            this.rbtnInactive.UseVisualStyleBackColor = true;
            // 
            // rbtnActive
            // 
            resources.ApplyResources(this.rbtnActive, "rbtnActive");
            this.rbtnActive.Name = "rbtnActive";
            this.rbtnActive.TabStop = true;
            this.rbtnActive.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // txtTypeName
            // 
            resources.ApplyResources(this.txtTypeName, "txtTypeName");
            this.txtTypeName.Name = "txtTypeName";
            this.txtTypeName.Validating += new System.ComponentModel.CancelEventHandler(this.txtTypeName_Validating_1);
            // 
            // txtMinimumShare
            // 
            resources.ApplyResources(this.txtMinimumShare, "txtMinimumShare");
            this.txtMinimumShare.Name = "txtMinimumShare";
            this.txtMinimumShare.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMinimumShare_KeyPress);
            // 
            // txtTypeID
            // 
            resources.ApplyResources(this.txtTypeID, "txtTypeID");
            this.txtTypeID.Name = "txtTypeID";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // panelSavingsTypeTitle
            // 
            this.panelSavingsTypeTitle.BackColor = System.Drawing.Color.RoyalBlue;
            this.panelSavingsTypeTitle.Controls.Add(this.label1);
            resources.ApplyResources(this.panelSavingsTypeTitle, "panelSavingsTypeTitle");
            this.panelSavingsTypeTitle.Name = "panelSavingsTypeTitle";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Name = "label1";
            // 
            // MaintenanceMemberType
            // 
            this.AllowDrop = true;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MaintenanceMemberType";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgMemberType)).EndInit();
            this.panelSearch.ResumeLayout(false);
            this.panelSearch.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.HasCertificatepanel.ResumeLayout(false);
            this.HasCertificatepanel.PerformLayout();
            this.statusPanel.ResumeLayout(false);
            this.statusPanel.PerformLayout();
            this.panelSavingsTypeTitle.ResumeLayout(false);
            this.panelSavingsTypeTitle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgMemberType;
        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSearchBox;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cboFilter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel HasCertificatepanel;
        private System.Windows.Forms.CheckBox chkHasCertificate;
        private System.Windows.Forms.Panel statusPanel;
        private System.Windows.Forms.RadioButton rbtnInactive;
        private System.Windows.Forms.RadioButton rbtnActive;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTypeName;
        private System.Windows.Forms.TextBox txtMinimumShare;
        private System.Windows.Forms.TextBox txtTypeID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panelSavingsTypeTitle;
        private System.Windows.Forms.Label label1;


    }
}