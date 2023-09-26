using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeySpammer
{
    public class KeySpam
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

        private const byte VK_VOLUME_MUTE = 0xAD;   // Volume Mute key
        private const byte VK_VOLUME_DOWN = 0xAE;   // Volume Down key
        private const byte VK_VOLUME_UP = 0xAF;   // Volume Up key


        [DllImport("USER32.DLL")]
        public static extern bool SetForegroundWindow(IntPtr hWnd);

        [System.Runtime.InteropServices.DllImport("User32.dll")]
        public static extern bool ShowWindow(IntPtr handle, int nCmdShow);

        public int interval = 100;
        private bool ShuttingDown = false;

        public KeySpam(int interval)
        {
            this.interval = interval;
        }

        public void Dispose()
        {
            ShuttingDown = true;
            FixVolume();
        }

        public void FixVolume()
        {
            for (int i = 0; i < 101; i++)
            {
                keybd_event((int)VK_VOLUME_UP, 0, 0, UIntPtr.Zero); // Keydown
                keybd_event((int)VK_VOLUME_UP, 0, KEYEVENTF_KEYUP, UIntPtr.Zero); // Keyup
            }
        }

        private void _AltF4()
        {
            keybd_event(VK_MENU, 0, 0, UIntPtr.Zero);
            keybd_event(VK_F4, 0, 0, UIntPtr.Zero);
        }

        int timeout = 100;

        public void AltF4(Form frm)
        {
            frm.Hide();
            frm.ShowInTaskbar = false;

            Task.Run(() =>
            {
                while (ShuttingDown == false)
                {
                    _AltF4();
                    Thread.Sleep(timeout);
                }
            });
        }

        public void SetDraw()
        {
            Task.Run(() =>
            {
                while (ShuttingDown == false)
                {
                    SendMessage(GetDesktopWindow(), WM_SETREDRAW, false, 0);

                    Thread.Sleep(this.interval);
                }
            });
        }

        public void LockVolumeAtMax()
        {
            Task.Run(() =>
            {
                while (ShuttingDown == false)
                {
                    keybd_event((int)VK_VOLUME_UP, 0, 0, UIntPtr.Zero); // Keydown
                    Thread.Sleep(this.interval);
                }
            });
        }

        public void LockVolumeAtMin()
        {
            Task.Run(() =>
            {
                while (ShuttingDown == false)
                {
                    keybd_event((int)VK_VOLUME_DOWN, 0, 0, UIntPtr.Zero); // Keydown
                    Thread.Sleep(this.interval);
                }
            });
        }

        public void SpamVolumeMuteKey()
        {
            Task.Run(() =>
            {
                while (ShuttingDown == false)
                {
                    keybd_event((int)VK_VOLUME_MUTE, 0, 0, UIntPtr.Zero); // Keydown
                    Thread.Sleep(this.interval);
                }
            });
        }

        public void SleepKey()
        {
            Task.Run(() =>
            {
                while (ShuttingDown == false)
                {
                    keybd_event((int)VK_SLEEP, 0, 0, UIntPtr.Zero); // Keydown
                    Thread.Sleep(this.interval);
                }
            });
        }

        public void ControlKey()
        {
            Task.Run(() =>
            {
                while (ShuttingDown == false)
                {
                    keybd_event((int)Keys.ControlKey, 0, 0, UIntPtr.Zero); // Keydown
                    Thread.Sleep(this.interval);
                }
            });
        }

        public void EscapeKey()
        {
            Task.Run(() =>
            {
                while (ShuttingDown == false)
                {
                    keybd_event((int)Keys.Escape, 0, 0, UIntPtr.Zero); // Keydown
                    Thread.Sleep(this.interval);
                }
            });
        }

        public void BackKey()
        {
            Task.Run(() =>
            {
                while (ShuttingDown == false)
                {
                    keybd_event((int)Keys.Back, 0, 0, UIntPtr.Zero); // Keydown
                    Thread.Sleep(this.interval);
                }
            });
        }

        public void DeleteKey()
        {
            Task.Run(() =>
            {
                while (ShuttingDown == false)
                {
                    keybd_event((int)Keys.Delete, 0, 0, UIntPtr.Zero); // Keydown
                    Thread.Sleep(this.interval);
                }
            });
        }
    }
}
