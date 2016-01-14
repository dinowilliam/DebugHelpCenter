using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Net.Mime;
using System.Threading.Tasks;
using System.Windows.Forms;
using DebugHelpCenter.Business;

namespace DebugHelpCenter
{
    static class Program
    {        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var formDebugHelpCenter = new frmDebugHelpCenter();

            ApplicationContext applicationContext = new DhcApplicationContext();
            applicationContext.MainForm = formDebugHelpCenter;

            formDebugHelpCenter.WindowState = FormWindowState.Minimized;
            formDebugHelpCenter.ShowInTaskbar = false;

            Application.Run(applicationContext);            
        }
        
    }
    
}
