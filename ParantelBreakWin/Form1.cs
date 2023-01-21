using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Windows.Forms;
using System.ServiceProcess;
using System.Security.Principal;

namespace ParantelFixWin
{
    public partial class ParantelFixWin : Form
    {
        public ParantelFixWin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (!IsAdmin())
            {
                MessageBox.Show("This application must be run as an administrator. Please re-run the application as an administrator.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // 1. Terminate the WpcMon.exe process if it is running
                Process process = Process.GetProcessesByName("WpcMon").FirstOrDefault();
                if (process != null)
                    process.Kill();

                // 2. Stop the WpcMonSvc service if it is running
                using (var serviceController = new ServiceController("WpcMonSvc"))
                {
                    if (serviceController.Status == ServiceControllerStatus.Running)
                    {
                        serviceController.Stop();
                    }
                }

                string message = "Our application successfully terminated the WpcMon.exe process and stopped the WpcMonSvc service!!";
                string title = "Problems Broken.";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show(message, title, buttons);
                string amessage = "Our application successfully disabled the Parental Controls Software on your device!!";
                string atitle = "Problems Broken.";
                MessageBoxButtons mybuttons = MessageBoxButtons.OK;
                DialogResult myresult = MessageBox.Show(amessage, atitle, mybuttons);
                if (myresult == DialogResult.OK)
                {
                    this.Close();
                }
            }
            catch (Exception exc)
            {
                Console.WriteLine("Unabled to stop WpcMon.exe process or WpcMonSvc service.");
                Console.WriteLine(exc.Message);
            }
        }

        private bool IsAdmin()
        {
            WindowsIdentity identity = WindowsIdentity.GetCurrent();
            WindowsPrincipal principal = new WindowsPrincipal(identity);
            return principal.IsInRole(WindowsBuiltInRole.Administrator);
        }
    }
    public class Wow64Interop
    {
        const string Kernel32dll = "Kernel32.Dll";

        [DllImport(Kernel32dll, EntryPoint = "Wow64DisableWow64FsRedirection")]
        public static extern bool DisableWow64FSRedirection(ref IntPtr ptr);

        [DllImport(Kernel32dll, EntryPoint = "Wow64RevertWow64FsRedirection")]
        public static extern bool Wow64RevertWow64FsRedirection(IntPtr ptr);
    }
}
