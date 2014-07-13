using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SVLMS;
using Microsoft.Win32;
using SVLMS.Savings.Controller;
using SVLMS.Savings.Model;
using SVLMS.Savings.View;

namespace SVLMS.Savings
{
    public partial class ViewSavingsDashboard : Form
    {
        public ViewSavingsDashboard()
        {
            InitializeComponent();
        }

        public int width = Screen.PrimaryScreen.WorkingArea.Width;
        //public int height = 600;
        public int height = Screen.PrimaryScreen.WorkingArea.Height;

        private void btnLogout_Click(object sender, EventArgs e)
        {
            ViewSwitchboard vs = new ViewSwitchboard();
            this.Close();
            vs.Show();
        }

        private void btnLogout_MouseHover(object sender, EventArgs e)
        {
            btnLogout.BackgroundImage = Properties.Resources.exit_bg_hover;
        }

        private void btnLogout_MouseLeave(object sender, EventArgs e)
        {
            btnLogout.BackgroundImage = Properties.Resources.exit_bg_savings;
        }

        private void savingsTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MaintenanceSavingsTypeView view = new MaintenanceSavingsTypeView();
            if((Application.OpenForms["MaintenanceSavingsTypeView"] as MaintenanceSavingsTypeView)==null)
            {
                ControllerSavingsType c = new ControllerSavingsType(new ModelSavingsType(),view);
            }
        }

        private void dormancyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MaintenanceDormancyView view = new MaintenanceDormancyView();
            if((Application.OpenForms["MaintenanceDormancyView"] as MaintenanceDormancyView ) == null)
            {
                ControllerDormancy c = new ControllerDormancy(new ModelDormancy(), view);
            }
        }

        private void termsAndRatesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MaintenanceTimeDeposit view = new MaintenanceTimeDeposit();
            if((Application.OpenForms["MaintenanceTimeDeposit"] as MaintenanceTimeDeposit) == null)
            {
                ControllerTimeDepositRates c = new ControllerTimeDepositRates(new ModelTimeDepositRates(),view);
            }
        }

        private void preTerminationPenaltyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MaintenanceTimeDepositPenalty view = new MaintenanceTimeDepositPenalty();
            if((Application.OpenForms["MaintenanceTimeDepositPenalty"] as MaintenanceTimeDepositPenalty) == null)
            {
                ControllerTimeDepositPenalty c = new ControllerTimeDepositPenalty(new ModelTimeDepositPenalty(), view);
            }
        }

        private void ViewSavingsDashboard_Load(object sender, EventArgs e)
        {
            

            if (height < 728)
            {
                panel4.Size = new System.Drawing.Size(300, 392);
                mAINTENANCEToolStripMenuItem.TextImageRelation = TextImageRelation.ImageBeforeText;
                tRANSACTIONSToolStripMenuItem.TextImageRelation = TextImageRelation.ImageBeforeText;
                toolStripMenuItem3.TextImageRelation = TextImageRelation.ImageBeforeText;
                toolStripMenuItem15.TextImageRelation = TextImageRelation.ImageBeforeText;
            }
        }

       




        

    }
}
