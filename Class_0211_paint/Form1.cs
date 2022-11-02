using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Class_0211_paint
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen pn = new Pen(Brushes.Blue, 5);
            g.DrawEllipse(pn, new Rectangle(300, 300, 100, 100));
            g.DrawEllipse(pn, new Rectangle(470, 470, 50, 50));
            g.DrawEllipse(pn, new Rectangle(460, 460, 20, 20));
            g.DrawEllipse(pn, new Rectangle(488, 450, 20, 20));
            g.DrawEllipse(pn, new Rectangle(510, 460, 20, 20));
            g.DrawEllipse(pn, new Rectangle(455, 480, 20, 20));
            g.DrawEllipse(pn, new Rectangle(523, 475, 20, 20));
            g.DrawLine(pn,350,400,350,550);
            g.DrawLine(pn,350,440,150,250);
            g.DrawLine(pn,350,440,488,526);
            g.DrawLine(pn, 490, 520,490,600);
            g.DrawLine(pn,350,550,550,750);
            g.DrawLine(pn,350,550,150,750);
            g.DrawArc(new Pen(Brushes.Aqua,10),new Rectangle(220,210,40,40),0,180);
            g.DrawArc(new Pen(Brushes.Aqua,10),new Rectangle(180,200,40,40),30,180);
            g.DrawArc(new Pen(Brushes.Aqua,10),new Rectangle(180,180,40,40),144,180);
            g.DrawArc(new Pen(Brushes.Aqua,10),new Rectangle(210,180,40,40),216,135);
            g.DrawArc(new Pen(Brushes.Aqua,10),new Rectangle(230,195,40,40),270,150);
            GraphicsPath path = new GraphicsPath();
            /*path.StartFigure();
            path.AddArc(20, 30, 40, 40, 0, -100);
            path.AddArc(120, 30, 60, 60, 0, -120);
            path.AddArc(220, 30, 80, 80, 0, -120);
            path.AddArc(320, 30, 40, 40, 0, -120);
            path.CloseFigure();
            g.DrawPath(new Pen(Color.Blue, 3), path);*/
            pn.Dispose();
            g.Dispose();

        }
    }
}
