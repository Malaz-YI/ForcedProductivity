using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ForcedProductivity.Properties;
using System.Diagnostics;

namespace ForcedProductivity
{
    static class Program
    {

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // the following 3-4 lines will detect if there is at least one running instance, which will
            // return nothing to prevent having multiple instances running at the same time.
            String thisprocessname = Process.GetCurrentProcess().ProcessName;
            
            if (Process.GetProcesses().Count(p => p.ProcessName == thisprocessname) > 1)
            {
                MessageBox.Show("The app is already open, you can lauch it from the system tray.","Program Is Running In The Background", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Pending_Tasks pendingTask = new Pending_Tasks();
                pendingTask.Show();
                Application.Run();
            }
            
        }
    }
}
