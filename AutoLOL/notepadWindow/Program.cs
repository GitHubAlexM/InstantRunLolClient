using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace notepadWindow
{
    class Program
    {

        [DllImport("user32.dll", SetLastError = true)]
        static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        // Disables or enables window!!!
        [DllImport("user32.dll")]
        static extern bool EnableWindow(IntPtr hWnd, bool bEnable);

        static void Main(string[] args)
        {
            IntPtr hWnd = FindWindow("Notepad", null); // Notepad - class name of Windows Notepad
            EnableWindow(hWnd, false);
        }
    }
}
