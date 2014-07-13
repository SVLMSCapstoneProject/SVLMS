using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using SVLMS.Loaning.Model;
using SVLMS.Loaning.Controller;
using SVLMS.Loaning.View;

namespace SVLMS
{
    public partial class loan_form : Form
    {
        string a;
        public loan_form()
        {
            InitializeComponent();
            StartTimer();
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

        private void shareCapitalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MaintenanceMemberType view = new MaintenanceMemberType();
            if ((Application.OpenForms["MaintenanceMemberType"] as MaintenanceMemberType) == null)
            {
                ControllerMemberType c = new ControllerMemberType(new ModelMemberType(), view);
            }
        }

        private void loanTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MaintenanceLoanTypeView view = new MaintenanceLoanTypeView();
            if ((Application.OpenForms["MaintenanceLoanTypeView"] as MaintenanceLoanTypeView) == null)
            {
                ControllerLoanType c = new ControllerLoanType(new ModelLoanType(), view);
            }
        }

        private void loanRatesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MaintenanceLoanRates view = new MaintenanceLoanRates();
            if ((Application.OpenForms["MaintenanceLoanRates"] as MaintenanceLoanRates) == null)
            {
                ControllerLoanRates c = new ControllerLoanRates(new ModelLoanRates(), view);
            }
        }

        private void additionalChargesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MaintenanceAdditionalChargesView view = new MaintenanceAdditionalChargesView();
            if ((Application.OpenForms["MaintenanceAdditionalChargesView"] as MaintenanceAdditionalChargesView) == null)
            {
                ControllerAdditionalCharges c = new ControllerAdditionalCharges(new ModelAdditionalCharges(), view);
            }
        }

        private void penaltyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MaintenancePenaltyView view = new MaintenancePenaltyView();
            if ((Application.OpenForms["MaintenancePenaltyView"] as MaintenancePenaltyView) == null)
            {
                ControllerPenalty c = new ControllerPenalty(new ModelPenalty(), view);
            }
        }

        private void shareTransactionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TransactionShareCapital view = new TransactionShareCapital();
            if ((Application.OpenForms["TransactionShareCapital"] as TransactionShareCapital) == null)
            {
                ControllerShareCapitalTransaction c = new ControllerShareCapitalTransaction(new ModelShareCapitalTransaction(), view);
            }
        }

        private void applicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TransactionLoanApplicationView view = new TransactionLoanApplicationView();
            if ((Application.OpenForms["TransactionLoanApplicationView"] as TransactionLoanApplicationView) == null)
            {
                ControllerLoanApplication c = new ControllerLoanApplication(new ModelLoanApplication(), view);
            }
        }

        private void releasingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TransactionLoanReleaseView view = new TransactionLoanReleaseView();
            if ((Application.OpenForms["TransactionLoanReleaseView"] as TransactionLoanReleaseView) == null)
            {
                ControllerLoanRelease c = new ControllerLoanRelease(new ModelLoan(), view);
            }
        }

        private void loanPaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TransactionLoanPaymentView view = new TransactionLoanPaymentView();
            if ((Application.OpenForms["TransactionLoanPaymentView"] as TransactionLoanPaymentView) == null)
            {
                ControllerLoanPayment c = new ControllerLoanPayment(new ModelLoanPayment(), view);
            }
        }

        private void loanModificationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TransactionLoanModificationView view = new TransactionLoanModificationView();
            if ((Application.OpenForms["TransactionLoanModificationView"] as TransactionLoanModificationView) == null)
            {
                ControllerLoanModification c = new ControllerLoanModification(new ModelLoan(), view);
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
