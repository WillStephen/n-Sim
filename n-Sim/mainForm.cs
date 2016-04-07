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

namespace n_Sim
{
    public partial class mainForm : Form
    {
        public readonly double GRAVCONST = 0.01;

        Graphics g = null;
        List<Body> bodyList = new List<Body>();
        Body b1 = new Body(150, 200, 2.7, -1.5, 1000);
        Body b2 = new Body(100, 150, 1, 0.2, 50000);
        Body b3 = new Body(50, 100, 0, 1.5, 500);

        public mainForm()
        {
            InitializeComponent();
            bodyList.Add(b1);
            bodyList.Add(b2);
            bodyList.Add(b3);
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
            frameUpdater.Start();
            Console.WriteLine(meme(5, rad(35)));
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

        private double getDistanceX(Body body1, Body body2)
        {
            return (body2.x - body1.x);
        }

        private double getDistanceY(Body body1, Body body2)
        {
            return (body2.y - body1.y);
        }

        private double getDistance(Body body1, Body body2)
        {
            double xdiff = Math.Abs(body2.x - body1.x);
            double ydiff = Math.Abs(body2.y - body1.y);
            return Math.Pow(Math.Pow(xdiff, 2) + Math.Pow(ydiff, 2), 0.5);
        }

        private double getAngle(Body b1, Body b2)
        {
            double diffX = b2.x - b1.x;
            double diffY = b2.y - b1.y;
            double rad = Math.Atan2(diffY, diffX);
            return rad * (180 / Math.PI);
        }

        private double gravForce(Body body1, Body body2)
        {
            return GRAVCONST * ((body1.mass * body2.mass) / Math.Pow(getDistance(body1, body2), 2));
        }

        private double calcGravX(Body body1, Body body2)
        {
            double force = gravForce(body1, body2);
            double angle = getAngle(body1, body2);
            return force * Math.Cos(rad(angle));
        }

        private double calcGravY(Body body1, Body body2)
        {
            double force = gravForce(body1, body2);
            double angle = getAngle(body1, body2);
            return force * Math.Sin(rad(angle));
        }

        private void redrawBodies(List<Body> l)
        {
            foreach (Body b in l){
                b.updatePosition();
            }
            this.Refresh();
            b1.accelerate(calcGravX(b1, b2)/b1.mass, calcGravY(b1, b2)/b1.mass);
            b3.accelerate(calcGravX(b3, b2) / b3.mass, calcGravY(b3, b2) / b3.mass);
            xlab.Text = calcGravX(b1, b2).ToString();
            ylab.Text = calcGravY(b1, b2).ToString();
            ltotal.Text = gravForce(b1, b2).ToString();
        }

        private double meme(double hyp, double angle)
        {
            return hyp * Math.Cos(angle);
        }

        
    }
}
