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
using System.Threading;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace KeySpammer
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll", SetLastError = true)]
        public static extern void keybd_event(int bVk, byte bScan, uint dwFlags, UIntPtr dwExtraInfo);

        [DllImport("user32.dll")]
        private static extern void SwitchToThisWindow(IntPtr hWnd, bool fAltTab);

        private const int WM_SETREDRAW = 0x000B;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int wMsg, bool wParam, int lParam);

        [DllImport("user32.dll", SetLastError = false)]
        static extern IntPtr GetDesktopWindow();

        private const int KEYEVENTF_EXTENDEDKEY = 0x0001;
        private const int KEYEVENTF_KEYUP = 0x0002;
        const uint WM_KEYDOWN = 0x0100;
        const uint WM_KEYUP = 0x0101;

        // Constants for key codes and flags
        private const byte VK_MENU = 0x12; // Alt key
        private const byte VK_F4 = 0x73;   // F4 key
        private const byte VK_SLEEP = 0x5F;   // Sleep key


        [DllImport("USER32.DLL")]
        public static extern bool SetForegroundWindow(IntPtr hWnd);

        [System.Runtime.InteropServices.DllImport("User32.dll")]
        public static extern bool ShowWindow(IntPtr handle, int nCmdShow);

        KeySpam keySpam;

        public Form1()
        {
            InitializeComponent();
            this.FormClosing += Form1_FormClosing;

            keySpam = new KeySpam(30);

            intervalBar.Value = 30;

            updateInterval();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            keySpam.Dispose();
        }

        private void spamAltF4Btn_Click(object sender, EventArgs e)
        {
            spamAltF4Btn.Enabled = false;
            keySpam.AltF4(this);
        }

        private void spamSetDrawBtn_Click(object sender, EventArgs e)
        {
            spamSetDrawBtn.Enabled = false;
            keySpam.SetDraw();
        }

        private void volMaxBtn_Click(object sender, EventArgs e)
        {
            volMaxBtn.Enabled = false;
            keySpam.LockVolumeAtMax();
        }

        private void volMinBtn_Click(object sender, EventArgs e)
        {
            volMinBtn.Enabled = false;
            keySpam.LockVolumeAtMin();
        }

        private void spamMuteKeyBtn_Click(object sender, EventArgs e)
        {
            spamMuteKeyBtn.Enabled = false;
            keySpam.SpamVolumeMuteKey();
        }

        private void spamSleepKeyBtn_Click(object sender, EventArgs e)
        {
            spamSleepKeyBtn.Enabled = false;
            keySpam.SleepKey();
        }

        private void spamControlKeyBtn_Click(object sender, EventArgs e)
        {
            spamControlKeyBtn.Enabled = false;
            keySpam.ControlKey();
        }

        private void spamEscapeKeyBtn_Click(object sender, EventArgs e)
        {
            spamEscapeKeyBtn.Enabled = false;
            keySpam.EscapeKey();
        }

        private void spamBackKeyBtn_Click(object sender, EventArgs e)
        {
            spamBackKeyBtn.Enabled = false;
            keySpam.BackKey();
        }

        private void spamDeleteKeyBtn_Click(object sender, EventArgs e)
        {
            spamDeleteKeyBtn.Enabled = false;
            keySpam.DeleteKey();
        }

        private void updateInterval()
        {
            intervalLbl.Text = "Spamming Interval: " + intervalBar.Value + " ms";
            keySpam.interval = intervalBar.Value;
        }

        private void intervalBar_Scroll(object sender, EventArgs e)
        {
            updateInterval();
        }

        private void killSpammersBtn_Click(object sender, EventArgs e)
        {
            keySpam.Dispose();
            keySpam = new KeySpam(intervalBar.Value);

            spamAltF4Btn.Enabled = true;
            spamSetDrawBtn.Enabled = true;
            volMaxBtn.Enabled = true;
            volMinBtn.Enabled = true;
            spamMuteKeyBtn.Enabled = true;
            spamSleepKeyBtn.Enabled = true;
            spamControlKeyBtn.Enabled = true;
            spamEscapeKeyBtn.Enabled = true;
            spamBackKeyBtn.Enabled = true;
            spamDeleteKeyBtn.Enabled = true;
        }
    }
}
