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
        Body b1 = new Body(150, 250, 0, 0, 1000);
        Body b2 = new Body(300, 120, 0, 0, 50000);

        public mainForm()
        {
            InitializeComponent();
            bodyList.Add(b1);
            bodyList.Add(b2);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            g = this.CreateGraphics();
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
            //b1.accelerate(-0.01, 0);
        }

        private double getDistanceX(Body b1, Body b2)
        {
            return (b2.x - b1.x);
        }

        private double getDistanceY(Body b1, Body b2)
        {
            return (b2.y - b1.y);
        }

        private double getDistance(Body b1, Body b2)
        {
            double xdiff = Math.Abs(b2.x - b1.x);
            double ydiff = Math.Abs(b2.y - b1.y);
            return Math.Pow(Math.Pow(xdiff, 2) + Math.Pow(ydiff, 2), 0.5);
        }

        private double calcGravity(Body body1, Body body2)
        {
            int isNegative = 1;
            double dist = getDistance(body1, body2);
            if (dist < 0) { isNegative = -1; }
            return isNegative * GRAVCONST * ((body1.mass * body2.mass) / Math.Pow(dist, 2));
        }


        private void redrawBodies(List<Body> l)
        {
            foreach (Body b in l){
                b.updatePosition();
            }
            this.Refresh();
            Console.WriteLine(calcGravityX(b1, b2));
        }

    }
}
