using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32.TaskScheduler;


namespace SVLMS
{
    public partial class BatchProcessing : Form
    {
        public BatchProcessing()
        {
            InitializeComponent();
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            using (TaskService ts = new TaskService())
            {
                //For batch interest computation
                string taskNameInterest = "SVLMSInterestComputation";
                TaskDefinition tdInterest = ts.NewTask();
                tdInterest.RegistrationInfo.Description = "SVLMS Batch Interest Computation";
                tdInterest.Principal.LogonType = TaskLogonType.InteractiveToken;

                MonthlyTrigger mt = new MonthlyTrigger();
                mt.StartBoundary = dtpInterestSchedule.Value;
                mt.MonthsOfYear = MonthsOfTheYear.AllMonths;
                tdInterest.Actions.Add(new ExecAction(@"C:\Users\Pablo\Desktop\Capstone Project\SVLMS\SVLMS\bin\Debug\InterestBatch.bat"));
                tdInterest.Triggers.Add(mt);

                //For Batch dormancy fee computation
                string taskNameDormancy = "SVLMSDormancyComputation";
                TaskDefinition tdDormancy = ts.NewTask();
                tdDormancy.RegistrationInfo.Description = "SVLMS Batch Dormancy Computation";
                tdDormancy.Principal.LogonType = TaskLogonType.InteractiveToken;
                tdDormancy.Actions.Add(new ExecAction(@"C:\Users\Pablo\Desktop\Capstone Project\SVLMS\SVLMS\bin\Debug\DormancyBatch.bat"));
                //tdDormancy.Actions.Add(new ExecAction("notepad.exe"));

                DailyTrigger dt = new DailyTrigger();
                dt.DaysInterval = 1;
                dt.StartBoundary = dtpDormancySchedule.Value;
                tdDormancy.Triggers.Add(dt);

                try
                {
                    foreach (RunningTask rt in ts.GetRunningTasks())
                    {
                        if (rt != null)
                        {
                            if (rt.Name == taskNameInterest)
                            {
                                ts.RootFolder.DeleteTask(taskNameInterest);
                            }

                            if (rt.Name == taskNameDormancy)
                            {
                                ts.RootFolder.DeleteTask(taskNameDormancy);
                            }
                        }
                    }
                    ts.RootFolder.RegisterTaskDefinition(taskNameInterest, tdInterest);
                    ts.RootFolder.RegisterTaskDefinition(taskNameDormancy,tdDormancy);
                    MessageBox.Show("Schedule successfully saved.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                Console.ReadLine();
            }
        }
    }
}
