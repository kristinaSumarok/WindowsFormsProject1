using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex2
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        private Point a, b;
        private int x, y;
        private bool _isGoingDown;
        public Form1()
        {
            InitializeComponent();
            _isGoingDown = true;
        }

        private void button_startLine_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Graphics graphics = CreateGraphics();
            Pen pen = new Pen(Color.FromArgb((byte)random.Next(0, 255), (byte)random.Next(0, 255),
                (byte)random.Next(0, 255)), 4);
            if (_isGoingDown)
            {
                b = new Point(x, y+=10);
                graphics.DrawLine(pen, a, b);
                CheckIfDown();
            }
            else
            {
                b = new Point(x, y -= 10);
                graphics.DrawLine(pen, a, b);
                CheckIfDown();
            }
            a = b;
        }

        private void CheckIfDown()
        {
            if (b.Y >= ClientSize.Height|| b.Y <= 0)
            {
                b = new Point(x+=4, y);
                _isGoingDown = !_isGoingDown;
            }

            if (b.X >= ClientSize.Width)
            {
                timer1.Stop();
            }
        }
    }
}
