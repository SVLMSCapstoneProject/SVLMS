using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using SVLMS.Savings.View;
using SVLMS.Savings.Controller;
using SVLMS.Savings.Model;
using SVLMS.Savings;

namespace SVLMS
{
    public partial class savings_form : Form
    {
        MaintenanceSavingsTypeView mstv = new MaintenanceSavingsTypeView();
        MaintenanceDormancyView mdv = new MaintenanceDormancyView();
        MaintenanceTimeDeposit mtdv = new MaintenanceTimeDeposit();
        MaintenanceTimeDepositPenalty mtdpv = new MaintenanceTimeDepositPenalty();
        TransactionMembership tm = new TransactionMembership();
        TransactionMembershipTermination tmt = new TransactionMembershipTermination();
        XXXSavingsWindows sw = new XXXSavingsWindows();
        TransactionSavings ts = new TransactionSavings();
        TransactionCreateTimeDeposit tctd = new TransactionCreateTimeDeposit();
        TransactionTimeDeposit ttd = new TransactionTimeDeposit();

        string a;        
        public savings_form()
        {
            InitializeComponent();
            if (ModelUser.MName.Equals(""))
                lblUser.Text = ModelUser.FName + " " + ModelUser.LName;
            else
                lblUser.Text = ModelUser.FName + " " + ModelUser.MName + " " + ModelUser.LName;
            StartTimer();
            this.ControlBox = false;
        }

        System.Windows.Forms.Timer tmr = null;
        private void StartTimer()
        {
            DateTimeFormatInfo timeFormat = new DateTimeFormatInfo();
            timeFormat.ShortTimePattern = CultureInfo.CurrentCulture.DateTimeFormat.ShortTimePattern;
            timeFormat.AMDesignator = "AM";
            timeFormat.PMDesignator = "PM";

            a = DateTime.Now.ToString("t", timeFormat);

            tmr = new System.Windows.Forms.Timer();
            tmr.Interval = 1000;
            tmr.Tick += new EventHandler(tmr_Tick);
            tmr.Enabled = true;
        }

        void tmr_Tick(object sender, EventArgs e)
        {
            if (a.Contains("A"))
            {
                lblDateTime.Text = DateTime.Now.ToString("dd-MMM-yyyy") + " " + (DateTime.Now.ToString("hh:mm")) + "AM";
            }
            else
            {
                lblDateTime.Text = DateTime.Now.ToString("dd-MMM-yyyy") + " " + (DateTime.Now.ToString("hh:mm") + "PM");
            }   
        }

        private void savingsTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {  
            if ((Application.OpenForms["MaintenanceSavingsTypeView"] as MaintenanceSavingsTypeView) == null)
            {
                ControllerSavingsType c = new ControllerSavingsType(new ModelSavingsType(), mstv);
            }
            
        }

        private void dormancyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((Application.OpenForms["MaintenanceDormancyView"] as MaintenanceDormancyView) == null)
            {
                ControllerDormancy c = new ControllerDormancy(new ModelDormancy(), mdv);
            }
        }

        private void termsAndRatesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((Application.OpenForms["MaintenanceTimeDeposit"] as MaintenanceTimeDeposit) == null)
            {
                ControllerTimeDepositRates c = new ControllerTimeDepositRates(new ModelTimeDepositRates(), mtdv);
            }
        }

        private void preTerminationPenaltyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((Application.OpenForms["MaintenanceTimeDepositPenalty"] as MaintenanceTimeDepositPenalty) == null)
            {
                ControllerTimeDepositPenalty c = new ControllerTimeDepositPenalty(new ModelTimeDepositPenalty(), mtdpv);
            }
        }

        private void registrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((Application.OpenForms["TransactionMembership"] as TransactionMembership) == null)
            {
                ControllerMember c = new ControllerMember(new ModelMember(), tm);
            }
        }

        private void terminationToolStripMenuItem_Click(object sender, EventArgs e)
        {  
            if ((Application.OpenForms["TransactionMembershipTermination"] as TransactionMembershipTermination) == null)
            {
                ControllerMemberTermination c = new ControllerMemberTermination(new ModelMember(), tmt);
            }
        }

        private void createSavingsAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //TransactionCreateSavingsAccountView view = new TransactionCreateSavingsAccountView();
            //if ((Application.OpenForms["TransactionCreateSavingsAccountView"] as TransactionCreateSavingsAccountView) == null)
            //{
            //    ControllerSavingsAccount c = new ControllerSavingsAccount(new ModelSavingsAccount(), view);
            //}
            //XXXSampleCreate c = new XXXSampleCreate();
            
            sw.Show();
        }

        private void savingsTransactionToolStripMenuItem_Click(object sender, EventArgs e)
        {  
            if ((Application.OpenForms["TransactionSavings"] as TransactionSavings) == null)
            {
                ControllerSavingsTransaction c = new ControllerSavingsTransaction(new ModelSavingsTransaction(), ts);
            }
            //TransactionCreateSavingsAccountView view = new TransactionCreateSavingsAccountView();
            //if ((Application.OpenForms["TransactionCreateSavingsAccountView"] as TransactionCreateSavingsAccountView) == null)
            //{
            //    ControllerSavingsAccount c = new ControllerSavingsAccount(new ModelSavingsAccount(), view);
            //}
        }

        private void createTimeDepositToolStripMenuItem_Click(object sender, EventArgs e)
        {   
            if ((Application.OpenForms["TransactionCreateTimeDeposit"] as TransactionCreateTimeDeposit) == null)
            {
                ControllerTimeDepositAccount c = new ControllerTimeDepositAccount(new ModelTimeDepositAccount(), tctd);
            }
            
        }

        private void closureAndRenewalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((Application.OpenForms["TransactionTimeDeposit"] as TransactionTimeDeposit) == null)
            {
                ControllerTimeDepositTransaction c = new ControllerTimeDepositTransaction(new ModelTimeDepositTransaction(), ttd);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckActiveChildForms();   
        }

        private void CheckActiveChildForms()
        {
            if (mstv.Visible || mdv.Visible || mtdpv.Visible || mtdv.Visible || tm.Visible || tmt.Visible || sw.Visible || ttd.Visible || tctd.Visible)
            {
                DialogResult strExit = MessageBox.Show("Do you want to continue?.", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);

                if (strExit == DialogResult.Yes)
                {
                    mstv.Dispose();
                    mdv.Dispose();
                    mtdpv.Dispose();
                    mtdv.Dispose();
                    tm.Dispose();
                    tmt.Dispose();
                    sw.Dispose();
                    ttd.Dispose();
                    tctd.Dispose();
                    this.Close();
                    main_form main = new main_form();
                    main.Show();
                }
            }
            else 
            {
                this.Close();
                main_form main = new main_form();
                main.Show();
            }
        }

        private void btnLogout_MouseHover(object sender, EventArgs e)
        {
            btnLogout.BackgroundImage = Properties.Resources.exit_bg_hover;
        }

        private void btnLogout_MouseLeave(object sender, EventArgs e)
        {
            btnLogout.BackgroundImage = Properties.Resources.exit_bg_savings;
        }
    }
}
