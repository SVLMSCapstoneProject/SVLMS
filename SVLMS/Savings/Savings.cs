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

        string a;        
        public savings_form()
        {
            InitializeComponent();
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
                time.Text = "" + (DateTime.Now.ToString("hh:mm")) + "AM";
            }
            else
            {
                time.Text = "" + (DateTime.Now.ToString("hh:mm") + "PM");
            }
            dates.Text = DateTime.Now.ToString("dd-MMM-yyyy");
        }

        private void savingsTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MaintenanceSavingsTypeView view = new MaintenanceSavingsTypeView();
            if ((Application.OpenForms["MaintenanceSavingsTypeView"] as MaintenanceSavingsTypeView) == null)
            {
                ControllerSavingsType c = new ControllerSavingsType(new ModelSavingsType(), view);
            }
            
        }

        private void dormancyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MaintenanceDormancyView view = new MaintenanceDormancyView();
            if ((Application.OpenForms["MaintenanceDormancyView"] as MaintenanceDormancyView) == null)
            {
                ControllerDormancy c = new ControllerDormancy(new ModelDormancy(), view);
            }
        }

        private void termsAndRatesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MaintenanceTimeDeposit view = new MaintenanceTimeDeposit();
            if ((Application.OpenForms["MaintenanceTimeDeposit"] as MaintenanceTimeDeposit) == null)
            {
                ControllerTimeDepositRates c = new ControllerTimeDepositRates(new ModelTimeDepositRates(), view);
            }
        }

        private void preTerminationPenaltyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MaintenanceTimeDepositPenalty view = new MaintenanceTimeDepositPenalty();
            if ((Application.OpenForms["MaintenanceTimeDepositPenalty"] as MaintenanceTimeDepositPenalty) == null)
            {
                ControllerTimeDepositPenalty c = new ControllerTimeDepositPenalty(new ModelTimeDepositPenalty(), view);
            }
        }

        private void registrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TransactionMembership view = new TransactionMembership();
            if ((Application.OpenForms["TransactionMembership"] as TransactionMembership) == null)
            {
                ControllerMember c = new ControllerMember(new ModelMember(), view);
            }
        }

        private void terminationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TransactionMembershipTermination view = new TransactionMembershipTermination();
            if ((Application.OpenForms["TransactionMembershipTermination"] as TransactionMembershipTermination) == null)
            {
                ControllerMemberTermination c = new ControllerMemberTermination(new ModelMember(), view);
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
            XXXSavingsWindows c = new XXXSavingsWindows();
            c.Show();
        }

        private void savingsTransactionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TransactionSavings view = new TransactionSavings();
            if ((Application.OpenForms["TransactionSavings"] as TransactionSavings) == null)
            {
                ControllerSavingsTransaction c = new ControllerSavingsTransaction(new ModelSavingsTransaction(), view);
            }
            //TransactionCreateSavingsAccountView view = new TransactionCreateSavingsAccountView();
            //if ((Application.OpenForms["TransactionCreateSavingsAccountView"] as TransactionCreateSavingsAccountView) == null)
            //{
            //    ControllerSavingsAccount c = new ControllerSavingsAccount(new ModelSavingsAccount(), view);
            //}
        }

        private void createTimeDepositToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TransactionCreateTimeDeposit view = new TransactionCreateTimeDeposit();
            if ((Application.OpenForms["TransactionCreateTimeDeposit"] as TransactionCreateTimeDeposit) == null)
            {
                ControllerTimeDepositAccount c = new ControllerTimeDepositAccount(new ModelTimeDepositAccount(), view);
            }
            
        }

        private void closureAndRenewalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TransactionTimeDeposit view = new TransactionTimeDeposit();
            if ((Application.OpenForms["TransactionTimeDeposit"] as TransactionTimeDeposit) == null)
            {
                ControllerTimeDepositTransaction c = new ControllerTimeDepositTransaction(new ModelTimeDepositTransaction(), view);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            main_form m = new main_form();
            m.Show();
        }
    }
}
