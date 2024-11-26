using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex1
{
    public partial class Form1 : Form
    {
        private Brush brush1;
        private Brush brush2;
        private int _diameter;
        private bool _isBlinking1;
        private bool _isBlinking2;
        private bool _isTimer1On;
        private bool _isTimer2On;
        public Form1()
        {
            InitializeComponent();
            _diameter = pictureBox1.Height;
            _isTimer1On = false;
            brush1 = new SolidBrush(Color.BlueViolet);
            brush2 = new SolidBrush(Color.Green);
            _isBlinking1 = true;
    }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (!_isTimer1On)
            {
                timer1.Start();
            }
            else if(_isTimer1On)
            {
                timer1.Stop();
            }

            _isTimer1On = !_isTimer1On;
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            int x = 0;
            int y = 0;
            Rectangle react1 = new Rectangle(x,y,_diameter,_diameter);
            graphics.FillEllipse(brush1,react1);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (_isBlinking1)
            {
                brush1 = new SolidBrush(Color.Blue);
            }
            else
            {
                brush1 = new SolidBrush(Color.BlueViolet);
            }
            _isBlinking1 =!_isBlinking1;
            pictureBox1.Invalidate();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (!_isTimer2On)
            {
                timer2.Start();
            }
            else if (_isTimer2On)
            {
                timer2.Stop();
            }

            _isTimer2On = !_isTimer2On;
        }

        private void pictureBox2_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            int x = 0;
            int y = 0;
            Rectangle react1 = new Rectangle(x, y, _diameter, _diameter);
            graphics.FillEllipse(brush2, react1);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (_isBlinking2)
            {
                brush2 = new SolidBrush(Color.DarkRed);
            }
            else
            {
                brush2 = new SolidBrush(Color.Green);
            }
            _isBlinking2 = !_isBlinking2;
            pictureBox2.Invalidate();
        }
    }
}
