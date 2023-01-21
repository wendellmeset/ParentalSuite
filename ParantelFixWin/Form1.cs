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
            IntPtr wow64Value = IntPtr.Zero;

            try
            {
                // 1. Disable initially the Wow64FSRedirection
                Wow64Interop.DisableWow64FSRedirection(ref wow64Value);

                // 2. Prepare the code that starts another executable
                // Run the application from the system32 directory
                // In this case we will run the dfrgui.exe app
                //
                // C:\Windows\system32\dfrgui.exe
                Process processToStart = new Process
                {
                    StartInfo =
                    {
                    FileName = @"WpcMon.exe",
                    WorkingDirectory = Environment.GetFolderPath(Environment.SpecialFolder.System)
                    }
                };

                // Start the application
                processToStart.Start();
            }
            catch (Exception exc)
            {
                Console.WriteLine("Unabled to disable/enable WOW64 File System Redirection");
                Console.WriteLine(exc.Message);
            }
            finally
            {
                // 3. Let the Wow64FSRedirection with its initially state
                Wow64Interop.Wow64RevertWow64FsRedirection(wow64Value);
            }

            string message = "Our application successfully repaired the parantel controls application on your PC!";
            string title = "Problems Solved.";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.OK)
            {
                this.Close();
            }
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
