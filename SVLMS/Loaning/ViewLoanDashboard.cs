using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SVLMS.Loaning.Controller;
using SVLMS.Loaning.Model;
using SVLMS.Loaning.View;

namespace SVLMS.Loaning
{
    public partial class ViewLoanDashboard : Form
    {
        public ViewLoanDashboard()
        {
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            ViewSwitchboard vs = new ViewSwitchboard();
            this.Close();
            vs.Show();
        }

        private void btnLogout_MouseHover(object sender, EventArgs e)
        {
            btnLogout.BackgroundImage = global::SVLMS.Properties.Resources.exit_bg_hover;
        }

        private void btnLogout_MouseLeave(object sender, EventArgs e)
        {
            btnLogout.BackgroundImage = global::SVLMS.Properties.Resources.exit_bg;
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
            if((Application.OpenForms["MaintenanceLoanTypeView"] as MaintenanceLoanTypeView )==null)
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
            if((Application.OpenForms["MaintenancePenaltyView"] as MaintenancePenaltyView) == null)
            {
                ControllerPenalty c = new ControllerPenalty(new ModelPenalty(), view);
            }
        }






    }
}
