using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace n_Sim
{
    public partial class mainForm : Form
    {
        public readonly double GRAVCONST = 0.01;

        Graphics g = null;
        List<Body> bodyList = new List<Body>();
        //Body b1 = new Body(900, 600, 0, -1.87, 70000);
        //Body b2 = new Body(800, 600, 0, 1.87, 70000);
        //Body b3 = new Body(1400, 150, -2, 1, 1000);
        //Body b4 = new Body(100, 100, 0, 0, 100000);

        int dragStartX, dragStartY;


        public mainForm()
        {
            InitializeComponent();
            Random r = new Random();
            for (int i = 0; i < 50; i++)
            {
                bodyList.Add(new Body(r.Next(10, 1910), r.Next(10, 1000), r.Next(0, 0), r.Next(0, 0), 10000));
            }
            for (int i = 0; i < 2; i++)
            {
                bodyList.Add(new Body(r.Next(10, 1910), r.Next(10, 1000), r.Next(0, 0), r.Next(0, 0), 1000000));
            }

            //bodyList.Add(b1);
            //bodyList.Add(b2);
            //bodyList.Add(b3);
            //bodyList.Add(b4);
        }

        public double deg(double rad)
        {
            return rad * (180 / Math.PI);
        }

        public double rad(double deg)
        {
            return deg * (Math.PI / 180);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            g = this.CreateGraphics();
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            frameUpdater.Start();
        }
        private void mainForm_Paint(object sender, PaintEventArgs e)
        {
            foreach (Body b in bodyList)
            {
                b.drawBody(g);
            }
        }
        
        private void frameUpdater_Tick(object sender, EventArgs e)
        {
            
            redrawBodies(bodyList);
        }

        private double getDistance(Body body1, Body body2)
        {
            int minDist = Convert.ToInt32(body2.radius);
            double xdiff = Math.Abs(body2.x - body1.x);
            if (xdiff < minDist)
            {
                xdiff = minDist;
            }
            double ydiff = Math.Abs(body2.y - body1.y);
            if (ydiff < minDist)
            {
                ydiff = minDist;
            }
            return Math.Pow(Math.Pow(xdiff, 2) + Math.Pow(ydiff, 2), 0.5);
        }

        private double getAngle(Body b1, Body b2)
        {
            double diffX = b2.x - b1.x;
            double diffY = b2.y - b1.y;
            double rad = Math.Atan2(diffY, diffX);
            return rad * (180 / Math.PI);
        }

        private double totalGravForce(Body body1, Body body2)
        {
            return GRAVCONST * ((body1.mass * body2.mass) / Math.Pow(getDistance(body1, body2), 2));
        }

        private double calcGravX(Body body1, Body body2)
        {
            double force = totalGravForce(body1, body2);
            double angle = getAngle(body1, body2);
            return force * Math.Cos(rad(angle));
        }

        private double calcGravY(Body body1, Body body2)
        {
            double force = totalGravForce(body1, body2);
            double angle = getAngle(body1, body2);
            return force * Math.Sin(rad(angle));
        }

        private void redrawBodies(List<Body> l)
        {
            foreach (Body b in l){
                b.updatePosition();
            }
            this.Refresh();
            calcAllBodiesAccel(bodyList);
            Console.WriteLine(MouseButtons);
            if (MouseButtons == MouseButtons.Left)
            {
                Pen p = new Pen(Color.White);
                g.DrawLine(p, dragStartX, dragStartY, Cursor.Position.X, Cursor.Position.Y);
            }
        }  

        private void calcAllBodiesAccel(List<Body> l)
        {
            foreach (Body b in l)
            {
                foreach (Body c in l)
                {
                    if (c != b)
                    {
                        b.accelerate(calcGravX(b, c) / b.mass, calcGravY(b, c) / b.mass);
                    }
                }
            }
        }

        private void mainForm_MouseDown(object sender, MouseEventArgs e)
        {
            dragStartX = Cursor.Position.X;
            dragStartY = Cursor.Position.Y;
        }

        private void mainForm_MouseUp(object sender, MouseEventArgs e)
        {
            double speedFactor = 0.05;
            double xspeed = speedFactor * (dragStartX - Cursor.Position.X);
            double yspeed = speedFactor * (dragStartY - Cursor.Position.Y);
            Random r = new Random();
            int m = r.Next(10, 10);
            bodyList.Add(new Body(dragStartX, dragStartY, xspeed, yspeed, m*m*m));
        }

    }
}
