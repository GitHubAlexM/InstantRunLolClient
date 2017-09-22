using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Threading;
using System.Windows.Input;
namespace AutoLOLWFA
{
    public partial class Form1 : Form
    {

        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(long dwFlags, long dx, long dy, long cButtons, long dwExtraInfo);

        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;
        private const int MOUSEEVENTF_RIGHTDOWN = 0x08;
        private const int MOUSEEVENTF_RIGHTUP = 0x10;


        public Form1()
        {
            InitializeComponent();

        }
        private void button1_Click(object sender, EventArgs e)
        {

            //to activate an application
            //run lol
            object newProcess = Process.Start(@"C:\Riot Games\League of Legends\lol.launcher.exe");
            //MessageBox.Show(newProcess.ToString());

            //cursor

            this.Cursor = new Cursor(Cursor.Current.Handle);
            Cursor.Position = new Point(Cursor.Position.X, Cursor.Position.Y);

            Cursor.Position = new Point(680, 120);

            //MessageBox.Show(Cursor.Position.ToString());

            System.Threading.Timer timer = null;
            timer = new System.Threading.Timer((obj) =>
            {
                bar();//mouse event

           

            },
                                //timer here
                        null,   3500, System.Threading.Timeout.Infinite);
        }



        public void bar()//method for mouse event
            {
                //Call the imported function with the cursor's current position
                int X = Cursor.Position.X;
                int Y = Cursor.Position.Y;
                mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, X, Y, 0, 0);            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }


    }
    


