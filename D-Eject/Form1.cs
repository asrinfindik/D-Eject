using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Runtime.InteropServices;
using Microsoft.Win32;
using System.IO;


namespace D_Eject
{
    public partial class Form1 : Form
    {
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x80;
                return cp;
            }
        }

        RegistryKey rkApp = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

        [DllImport("winmm.dll", EntryPoint = "mciSendStringA", CharSet = CharSet.Ansi)]
        protected static extern int mciSendString(string lpstrCommand, StringBuilder lpstrReturnString, int uReturnLength, IntPtr hwndCallback);

        public Form1()
        {
            InitializeComponent();
            ProgressTimer.Start();
            rkApp.SetValue("D-Eject", Application.ExecutablePath.ToString());
            this.Resize += new EventHandler(Form1_Resize);
        }

        public bool ProcessCDTray(bool open)
        {
            int ret = 0; //do a switch of the value passed
            switch (open)
            {
                case true: //true = open the cd
                    ret = mciSendString("set cdaudio door open", null, 0, IntPtr.Zero);
                    return true;
                //break; 
                case false: //false = close the tray
                    ret = mciSendString("set cdaudio door closed", null, 0, IntPtr.Zero);
                    return true;
                //break;
                default: ret = mciSendString("set cdaudio door open", null, 0, IntPtr.Zero);
                    return true;
                //break;
            }
        }

        private void EjectButton_Click(object sender, EventArgs e)
        {
            TrayBar.ShowBalloonTip(1000, "D-Eject", "Disc ejecting.", ToolTipIcon.Warning);
            ProcessCDTray(true);
            TrayBar.ShowBalloonTip(1000, "D-Eject", "Disc ejected.", ToolTipIcon.Info);
        }

        private void MountButton_Click(object sender, EventArgs e)
        {
            TrayBar.ShowBalloonTip(1000, "D-Eject", "Disc mounting.", ToolTipIcon.Warning);
            ProcessCDTray(false);
            TrayBar.ShowBalloonTip(1000, "D-Eject", "Disc mounted.", ToolTipIcon.Info);
        }

        private void eJECTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TrayBar.ShowBalloonTip(1000, "D-Eject", "Disc ejecting.", ToolTipIcon.Warning);
            ProcessCDTray(true);
            TrayBar.ShowBalloonTip(1000, "D-Eject", "Disc ejected.", ToolTipIcon.Info);
        }

        private void mOUNTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TrayBar.ShowBalloonTip(1000, "D-Eject", "Disc mounting.", ToolTipIcon.Warning);
            ProcessCDTray(false);
            TrayBar.ShowBalloonTip(1000, "D-Eject", "Disc mounted.", ToolTipIcon.Info);
        }

        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TrayBar_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
                Hide();
        }
    }
}
