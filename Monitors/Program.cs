using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.IO;
class Program
{
    [StructLayout(LayoutKind.Sequential)]
    public struct RECT
    {
        public int Left;
        public int Top;
        public int Right;
        public int Bottom;
    }

    [DllImport("user32.dll")]
    public static extern bool EnumDisplayMonitors(IntPtr hdc, IntPtr lprcClip, MonitorEnumProc lpfnEnum, IntPtr dwData);

    public delegate bool MonitorEnumProc(IntPtr hMonitor, IntPtr hdcMonitor, ref RECT lprcMonitor, IntPtr dwData);

    static void Main()
    {
        byte[] d = File.ReadAllBytes(".\\56K Modem sound.wav");

        string b64 = Convert.ToBase64String(d);
        File.WriteAllText(".\\56K Modem sound.txt", b64);

        Console.ReadLine();
    }

    static Point PointGetRandFullspacePoint()
    {
        Screen[] screens = Screen.AllScreens;

        if (screens.Length > 0)
        {
            Console.Clear();

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

            Console.WriteLine("Spanning Rectangle: " + spanningRectangle.ToString());

            return GetRandomPointInBounds(spanningRectangle);
        }

        return Point.Empty;
    }

    static Point GetRandomPointInBounds(Rectangle bounds)
    {
        Random random = new Random();
        int randomX = random.Next(bounds.Left, bounds.Right);
        int randomY = random.Next(bounds.Top, bounds.Bottom);
        return new Point(randomX, randomY);
    }



    static Rectangle GetCombinedMonitorBounds()
    {
        EnumDisplayMonitors(IntPtr.Zero, IntPtr.Zero, EnumMonitorsCallback, IntPtr.Zero);

        return new Rectangle(combinedRect.Left, combinedRect.Top, combinedRect.Right - combinedRect.Left, combinedRect.Bottom - combinedRect.Top);
    }

    

    static RECT combinedRect;

    static int idx;

    static bool EnumMonitorsCallback(IntPtr hMonitor, IntPtr hdcMonitor, ref RECT lprcMonitor, IntPtr dwData)
    {
        if (idx + 1 >= System.Windows.Forms.Screen.AllScreens.Length)
        {
            Rectangle rect = new Rectangle(combinedRect.Left, combinedRect.Top, combinedRect.Right - combinedRect.Left, combinedRect.Bottom - combinedRect.Top);
            Point p = GetRandomPointInBounds(rect);
            Console.WriteLine($"Random Coordinates (X, Y): ({p.X}, {p.Y})");
        }
        else
        {
            combinedRect = new RECT { Left = int.MaxValue, Top = int.MaxValue, Right = int.MinValue, Bottom = int.MinValue };
            combinedRect.Left = Math.Min(combinedRect.Left, lprcMonitor.Left);
            combinedRect.Top = Math.Min(combinedRect.Top, lprcMonitor.Top);
            combinedRect.Right = Math.Max(combinedRect.Right, lprcMonitor.Right);
            combinedRect.Bottom = Math.Max(combinedRect.Bottom, lprcMonitor.Bottom);

            Console.WriteLine($"Monitor Coordinates (X, Y): ({lprcMonitor.Left}, {lprcMonitor.Top})");
            idx++;
        }
        return true;
    }
}
