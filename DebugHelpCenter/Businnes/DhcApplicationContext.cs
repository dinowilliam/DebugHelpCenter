using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace DebugHelpCenter.Business
{
    public class DhcApplicationContext : ApplicationContext
    {
        private NotifyIcon notifyIcon;
        private Container components;

        public DhcApplicationContext()
        {
            InitializeContext();           
        }

        private void InitializeContext()
        {
            components = new System.ComponentModel.Container();

            notifyIcon = new NotifyIcon(components)
            {
                ContextMenu = new ContextMenu(new MenuItem[] { new MenuItem("Exit", Exit) }),
                Icon = new Icon(@"D:\William\repository\DebugHelpCenter\DebugHelpCenter\Resources\debug.ico"),
                Text = "Help Debug Center",
                Visible = true
            };

            //MainForm.WindowState = FormWindowState.Minimized;
            //MainForm.ShowInTaskbar = false;
            //notifyIcon.ContextMenuStrip.Opening += ContextMenuStrip_Opening;

            //notifyIcon.DoubleClick += notifyIcon_DoubleClick;

        }

        void Exit(object sender, EventArgs e)
        {
            // Hide tray icon, otherwise it will remain shown until user mouses over it
            notifyIcon.Visible = false;

            Application.Exit();
        }
    }
}
