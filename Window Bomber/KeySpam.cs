using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using Plugins.Nedry;
using System.Drawing;

namespace Window_Bomber
{
    public static class WindowMover
    {
        static WindowMover()
        {
            rnd = new Random();
        }
        // Define the necessary Windows API functions
        [DllImport("user32.dll")]
        static extern bool EnumWindows(EnumWindowsProc enumProc, IntPtr lParam);

        [DllImport("user32.dll")]
        static extern bool GetWindowRect(IntPtr hWnd, out RECT lpRect);

        [DllImport("user32.dll")]
        static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);

        const int SWP_NOSIZE = 0x0001;
        const int SWP_NOZORDER = 0x0004;
        const int SW_RESTORE = 9; // Restore the window


        delegate bool EnumWindowsProc(IntPtr hWnd, IntPtr lParam);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        static extern int GetWindowText(IntPtr hWnd, StringBuilder lpString, int nMaxCount);

        [DllImport("user32.dll")]
        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        [DllImport("user32.dll")]
        static extern bool EnumChildWindows(IntPtr hWndParent, EnumWindowsProc enumProc, IntPtr lParam);

        private const int WM_SETREDRAW = 0x000B;
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int wMsg, bool wParam, int lParam);

        [DllImport("user32.dll", SetLastError = false)]
        static extern IntPtr GetDesktopWindow();

        [DllImport("user32.dll", SetLastError = true)]
        public static extern bool MoveWindow(IntPtr hWnd, int X, int Y, int nWidth, int nHeight, bool bRepaint);

        [StructLayout(LayoutKind.Sequential)]
        public struct RECT
        {
            public int Left;
            public int Top;
            public int Right;
            public int Bottom;
        }

        // Helper function to get the window title
        static string GetWindowTitle(IntPtr hWnd)
        {
            const int nChars = 256;
            var buff = new System.Text.StringBuilder(nChars);
            if (GetWindowText(hWnd, buff, nChars) > 0)
            {
                return buff.ToString();
            }
            return null;
        }

        static Random rnd;

        static Point PointGetRandFullspacePoint()
        {
            Screen[] screens = Screen.AllScreens;

            if (screens.Length > 0)
            {
                int minX = screens[0].Bounds.Left;
                int minY = screens[0].Bounds.Top;
                int maxX = screens[0].Bounds.Right;
                int maxY = screens[0].Bounds.Bottom;

                // Iterate through all screens to find the minimum and maximum bounds
                foreach (Screen screen in screens)
                {
                    if (screen.Bounds.Left < minX)
                        minX = screen.Bounds.Left;
                    if (screen.Bounds.Top < minY)
                        minY = screen.Bounds.Top;
                    if (screen.Bounds.Right > maxX)
                        maxX = screen.Bounds.Right;
                    if (screen.Bounds.Bottom > maxY)
                        maxY = screen.Bounds.Bottom;
                }

                // Create a rectangle that spans all screens
                Rectangle spanningRectangle = new Rectangle(minX, minY, maxX - minX, maxY - minY);

                return GetRandomPointInBounds(spanningRectangle);
            }

            return Point.Empty;
        }

        static Point GetRandomPointInBounds(Rectangle bounds)
        {
            int randomX = rnd.Next(bounds.Left, bounds.Right);
            int randomY = rnd.Next(bounds.Top, bounds.Bottom);
            return new Point(randomX, randomY);
        }

        public static void RandomizeWindows()
        {
            // Enumerate all top-level windows
            EnumWindows((topLevelHwnd, lParam) =>
            {
                Point randPoint = PointGetRandFullspacePoint();

                if (topLevelHwnd == GetDesktopWindow())
                {
                    return true;
                }

                // Skip windows without a title (comment out these lines to break the task bar and hide it forever)
                //if (string.IsNullOrEmpty(GetWindowTitle(topLevelHwnd)))
                //    return true;

                try
                {

                    if (GetWindowRect(topLevelHwnd, out RECT rect))
                    {
                        MoveWindow(topLevelHwnd, randPoint.X, randPoint.Y, rect.Right - rect.Left, rect.Bottom - rect.Top, true);
                    }
                    //});

                    // Enumerate child windows for the top-level window
                    EnumChildWindows(topLevelHwnd, (childHwnd, childLParam) =>
                    {
                        randPoint = PointGetRandFullspacePoint();

                        if (childHwnd == GetDesktopWindow())
                        {
                            return true;
                        }

                        if (GetWindowRect(childHwnd, out RECT childRect))
                        {
                            MoveWindow(childHwnd, randPoint.X, randPoint.Y, childRect.Right - childRect.Left, childRect.Bottom - childRect.Top, true);
                        }

                        return true;
                    }, IntPtr.Zero);
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                }

                return true;
            }, IntPtr.Zero);
        }

        public static void ShowAllWindows()
        {
            // Enumerate all top-level windows
            EnumWindows((topLevelHwnd, lParam) =>
            {
                Point randPoint = PointGetRandFullspacePoint();

                if (topLevelHwnd == GetDesktopWindow())
                {
                    return true;
                }

                // Skip windows without a title (comment out these lines to break the task bar and hide it forever)
                //if (string.IsNullOrEmpty(GetWindowTitle(topLevelHwnd)))
                //    return true;

                try
                {
                    ShowWindow(topLevelHwnd, SW_RESTORE);

                    // Enumerate child windows for the top-level window
                    EnumChildWindows(topLevelHwnd, (childHwnd, childLParam) =>
                    {
                        randPoint = PointGetRandFullspacePoint();

                        if (childHwnd == GetDesktopWindow())
                        {
                            return true;
                        }

                        ShowWindow(childHwnd, SW_RESTORE);

                        return true;
                    }, IntPtr.Zero);
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                }

                return true;
            }, IntPtr.Zero);
        }

        public static void DecimateAllWindows()
        {
            // Enumerate all top-level windows
            EnumWindows((topLevelHwnd, lParam) =>
            {
                Point randPoint = PointGetRandFullspacePoint();

                if (topLevelHwnd == GetDesktopWindow())
                {
                    return true;
                }

                // Skip windows without a title (comment out these lines to break the task bar and hide it forever)
                //if (string.IsNullOrEmpty(GetWindowTitle(topLevelHwnd)))
                //    return true;

                try
                {
                    // Take the top-level window out of fullscreen mode if necessary
                    ShowWindow(topLevelHwnd, SW_RESTORE);

                    if (GetWindowRect(topLevelHwnd, out RECT rect))
                    {
                        MoveWindow(topLevelHwnd, randPoint.X, randPoint.Y, rect.Right - rect.Left, rect.Bottom - rect.Top, true);

                        // Set the new position for the child window relative to the top-level window
                        //SetWindowPos(topLevelHwnd, IntPtr.Zero, randPoint.X, randPoint.Y, rect.Right - rect.Left, rect.Bottom - rect.Top, SWP_NOSIZE | SWP_NOZORDER);
                    }

                    SendMessage(topLevelHwnd, WM_SETREDRAW, false, 0);

                    // Enumerate child windows for the top-level window
                    EnumChildWindows(topLevelHwnd, (childHwnd, childLParam) =>
                    {
                        randPoint = PointGetRandFullspacePoint();

                        if (childHwnd == GetDesktopWindow())
                        {
                            return true;
                        }

                        // Take each child window out of fullscreen mode if necessary
                        ShowWindow(childHwnd, SW_RESTORE);

                        if (GetWindowRect(childHwnd, out RECT childRect))
                        {
                            MoveWindow(childHwnd, randPoint.X, randPoint.Y, childRect.Right - childRect.Left, childRect.Bottom - childRect.Top, true);

                            // Set the new position for the child window relative to the top-level window
                            //SetWindowPos(childHwnd, IntPtr.Zero, randPoint.X, randPoint.Y, childRect.Right - childRect.Left, childRect.Bottom - childRect.Top, SWP_NOSIZE | SWP_NOZORDER);
                        }

                        SendMessage(childHwnd, WM_SETREDRAW, false, 0);

                        return true;
                    }, IntPtr.Zero);
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                }

                return true;
            }, IntPtr.Zero);
        }

        public static void FreezeAllWindows()
        {
            // Enumerate all top-level windows
            EnumWindows((topLevelHwnd, lParam) =>
            {
                Point randPoint = PointGetRandFullspacePoint();

                if (topLevelHwnd == GetDesktopWindow())
                {
                    return true;
                }
                // Skip windows without a title
                //if (string.IsNullOrEmpty(GetWindowTitle(topLevelHwnd)))
                //    return true;

                try
                {
                    // Take the top-level window out of fullscreen mode if necessary
                    ShowWindow(topLevelHwnd, SW_RESTORE);

                    SendMessage(topLevelHwnd, WM_SETREDRAW, false, 0);

                    // Enumerate child windows for the top-level window
                    EnumChildWindows(topLevelHwnd, (childHwnd, childLParam) =>
                    {
                        randPoint = PointGetRandFullspacePoint();

                        if (childHwnd == GetDesktopWindow())
                        {
                            return true;
                        }
                        // Take each child window out of fullscreen mode if necessary
                        ShowWindow(childHwnd, SW_RESTORE);

                        SendMessage(childHwnd, WM_SETREDRAW, false, 0);

                        return true;
                    }, IntPtr.Zero);
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                }

                return true;
            }, IntPtr.Zero);
        }

        public static void UnfreezeAllWindows()
        {
            // Enumerate all top-level windows
            EnumWindows((topLevelHwnd, lParam) =>
            {
                Point randPoint = PointGetRandFullspacePoint();

                if (topLevelHwnd == GetDesktopWindow())
                {
                    return true;
                }
                // Skip windows without a title
                //if (string.IsNullOrEmpty(GetWindowTitle(topLevelHwnd)))
                //    return true;

                try
                {
                    SendMessage(topLevelHwnd, WM_SETREDRAW, true, 0);

                    // Enumerate child windows for the top-level window
                    EnumChildWindows(topLevelHwnd, (childHwnd, childLParam) =>
                    {
                        randPoint = PointGetRandFullspacePoint();

                        if (childHwnd == GetDesktopWindow())
                        {
                            return true;
                        }

                        SendMessage(childHwnd, WM_SETREDRAW, true, 0);

                        return true;
                    }, IntPtr.Zero);
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                }

                return true;
            }, IntPtr.Zero);
        }


        public static void MoveAllWindowsToPredefinedLocation(int x, int y)
        {
            // Define your predefined position here (e.g., top-left corner)
            int newX = x;
            int newY = y;

            // Enumerate all top-level windows
            EnumWindows((topLevelHwnd, lParam) =>
            {
                // Skip windows without a title
                //if (string.IsNullOrEmpty(GetWindowTitle(topLevelHwnd)))
                //    return true;

                try
                {
                    // Take the top-level window out of fullscreen mode if necessary
                    ShowWindow(topLevelHwnd, SW_RESTORE);

                    // Get the window's current position
                    if (GetWindowRect(topLevelHwnd, out RECT rect))
                    {
                        // Set the new position for the top-level window
                        SetWindowPos(topLevelHwnd, IntPtr.Zero, newX, newY, rect.Right - rect.Left, rect.Bottom - rect.Top, SWP_NOSIZE | SWP_NOZORDER);
                    }

                    // Enumerate child windows for the top-level window
                    EnumChildWindows(topLevelHwnd, (childHwnd, childLParam) =>
                    {
                        // Take each child window out of fullscreen mode if necessary
                        ShowWindow(childHwnd, SW_RESTORE);

                        // Get the child window's current position
                        if (GetWindowRect(childHwnd, out RECT childRect))
                        {
                            // Set the new position for the child window relative to the top-level window
                            SetWindowPos(childHwnd, IntPtr.Zero, newX, newY, childRect.Right - childRect.Left, childRect.Bottom - childRect.Top, SWP_NOSIZE | SWP_NOZORDER);
                        }

                        return true;
                    }, IntPtr.Zero);
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                }

                return true;
            }, IntPtr.Zero);
        }
    }

    public class KeySpam
    {
        [DllImport("user32.dll", SetLastError = true)]
        public static extern void keybd_event(int bVk, byte bScan, uint dwFlags, UIntPtr dwExtraInfo);


        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int wMsg, bool wParam, int lParam);

        [DllImport("user32.dll", SetLastError = false)]
        static extern IntPtr GetDesktopWindow();

        private const int KEYEVENTF_EXTENDEDKEY = 0x0001;
        private const int KEYEVENTF_KEYUP = 0x0002;
        private const uint WM_KEYDOWN = 0x0100;
        private const uint WM_KEYUP = 0x0101;
        private const int WM_SETREDRAW = 0x000B;

        // Constants for key codes and flags
        private const byte VK_MENU = 0x12; // Alt key
        private const byte VK_F4 = 0x73;   // F4 key
        private const byte VK_SLEEP = 0x5F;   // Sleep key

        private const byte VK_VOLUME_MUTE = 0xAD;   // Volume Mute key
        private const byte VK_VOLUME_DOWN = 0xAE;   // Volume Down key
        private const byte VK_VOLUME_UP = 0xAF;   // Volume Up key

        public int interval = 100;
        private bool ShuttingDown = false;
        GlobalKeyboardHook hook;

        public KeySpam(int interval)
        {
            this.interval = interval;

            hook = new GlobalKeyboardHook();
            hook.InstallHook();
            hook.KeyCombinationDetected += Hook_KeyCombinationDetected;
        }

        private void Hook_KeyCombinationDetected(object sender, EventArgs e)
        {
            WindowMover.UnfreezeAllWindows();
            Dispose();
        }

        public void Dispose()
        {
            ShuttingDown = true;

            Nedry.KillNedrys();

            hook.UninstallHook();
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

        public void ModemBomb()
        {
            Nedry.RunAndInstall(true);

            Thread.Sleep(1500);

            Task.Run(() =>
            {
                while (ShuttingDown == false)
                {
                    WindowMover.DecimateAllWindows();

                    Thread.Sleep(this.interval);
                }
            });
        }

        public void NedryBomb()
        {
            Nedry.RunAndInstall(false);

            //Thread.Sleep(1500);

            Task.Run(() =>
            {
                while (ShuttingDown == false)
                {
                    WindowMover.DecimateAllWindows();

                    Thread.Sleep(this.interval);
                }
            });
        }
    }
}