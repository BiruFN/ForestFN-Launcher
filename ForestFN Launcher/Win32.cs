using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ForestFN_Launcher
{
    public class Win32
    {
        [DllImport("kernel32.dll")]
        public static extern Int32 SuspendThread(IntPtr hThread);

        [DllImport("kernel32.dll")]
        public static extern IntPtr OpenThread(int dwDesiredAccess, bool bInheritHandle, int dwThreadId);
    }
}
