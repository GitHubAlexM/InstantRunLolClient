using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace AutoLOL
{
    class Program
    {
        [DllImportAttribute("User32.dll")]
        private static extern int FindWindow(String ClassName, String
    WindowName);

        [DllImportAttribute("User32.dll")]
        private static extern int SetForegroundWindow(int hWnd);

        static void Main(string[] args)
        {
            //run lol
            Process.Start(@"C:\Riot Games\League of Legends\lol.launcher.exe");
            int launcherHandle = FindWindow(null, "lol.launcher.exe");
            if (launcherHandle > 0)
            {
                Console.WriteLine("lol is launched.");
            }
            SetForegroundWindow(launcherHandle);
            SendKeys.Send("{ TAB} ");

            //Console.WriteLine("Entering Password");
            //Console.WriteLine("Logging in");
        }
        //Console.WriteLine("Clicking Start");
    }
}
