using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace KeySpammer
{
    public partial class Form1 : Form
    {
        BrightnessController ctl;
        int externalMonValue = 0;
        bool phyMon = false;

        private KeySpam keySpam;

        public Form1()
        {
            InitializeComponent();

            this.FormClosing += Form1_FormClosing;

            keySpam = new KeySpam(1);

            intervalBar.Value = 1;

            updateInterval();


            //phyMon = externMonitorsBtn.Checked;
            //ctl = new BrightnessController(this.Handle);
            //externalMonValue = ctl.

            if (!phyMon)
            {
                //trackBar1.Value = LaptopBrightness.Get();
                //brightnessLbl.Text = "Brightness: " + trackBar1.Value.ToString();
            }
            else
            {
                //trackBar1.Value = ctl.Get();
                //brightnessLbl.Text = "Brightness: " + trackBar1.Value.ToString();
            }

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

        private void monitorOffBtn_Click(object sender, EventArgs e)
        {
            MonitorHelper.TurnOff();
        }

        private void moveAllWindowsBtn_Click(object sender, EventArgs e)
        {
            keySpam.SpamWindowsLocation();
        }

        private void bombBtn_Click(object sender, EventArgs e)
        {
            keySpam.NedryBomb();
        }

        private void monitorSpamBtn_Click(object sender, EventArgs e)
        {
            keySpam.SpamMonitorOff();
        }

        private void freezeAllWindowsBtn_Click(object sender, EventArgs e)
        {
            keySpam.SpamDecimateAllWindows();
        }

        private void modemBombBtn_Click(object sender, EventArgs e)
        {
            keySpam.ModemBomb();
        }

        private void bsodCrashBtn_Click(object sender, EventArgs e)
        {
            SystemCrasher.Crash();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            keySpam.SpamBrightnessUpLaptop();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            keySpam.SpamBrightnessDownLaptop();
        }
    }
}