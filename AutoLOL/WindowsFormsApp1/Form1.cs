using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int x=0, y=0;
        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            Graphics g = CreateGraphics();
            Pen p = new Pen(Color.Navy);
            Pen erase = new Pen(Color.White);
            g.DrawLine(erase, 0, 0, x, y);
            x = e.X; y = e.Y;
            g.DrawLine(p, 0, 0, x, y);
            label1.Location = new Point(x - label1.Width, y);
            label2.Location = new Point(x , y- label2.Height);
            label1.Text = x.ToString();
            label2.Text = y.ToString();
        }
    }
}
