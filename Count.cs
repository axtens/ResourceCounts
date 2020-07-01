using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Resources
{
    public static class Count
    {
        [DllImport("user32.dll")]
        static extern uint GetGuiResources(IntPtr hProcess, uint uiFlags);

        public static uint GDI(IntPtr procPtr)
        {
            return GetGuiResources(procPtr, 0); // Process.GetCurrentProcess().Handle
        }

        public static uint User(IntPtr procPtr)
        {
            return GetGuiResources(procPtr, 1);
        }

        public static uint GDI(Process proc)
        {
            return GetGuiResources(proc.Handle, 0); // Process.GetCurrentProcess().Handle
        }

        public static uint User(Process proc)
        {
            return GetGuiResources(proc.Handle, 1);
        }
    }
}
