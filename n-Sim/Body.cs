using System;
using System.Drawing;
using System.Windows.Forms;

namespace n_Sim
{
    internal class Body
    {
        public double x, y, xspeed, yspeed, mass, radius;
        public string name;
        Color colour;

        public Body(double x, double y, double xspeed, double yspeed, double mass)
        {
            this.x = x;
            this.y = y;
            this.xspeed = xspeed;
            this.yspeed = yspeed;
            this.mass = mass;
            this.radius = getRadius();
            this.colour = getColour();
        }

        private Color getColour()
        {
            if (this.mass > 1000000)
            {
                return Color.Aquamarine;
            }
            if (this.mass > 100000)
            {
                return Color.OrangeRed;
            }
            if (this.mass > 10000)
            {
                return Color.Blue;
            }
            else
            {
                return Color.Green;
            }
        }

        public void accelerate(double xacc, double yacc)
        {
            this.xspeed += xacc;
            this.yspeed += yacc;
        }

        public double getRadius2D()
        {
            double r = Math.Pow((mass / Math.PI), 0.5);
            return r;
        }

        public double getRadius()
        {
            double r = Math.Pow(((this.mass * 0.75) / Math.PI), 1.0 / 3);
            return r;
        }

        public void drawBody(Graphics g)
        {
            SolidBrush myPen = new SolidBrush(colour);
            g.FillEllipse(myPen, Convert.ToInt32(x - (radius / 2)), Convert.ToInt32(y - (radius / 2)), Convert.ToInt32(radius), Convert.ToInt32(radius));
            //g.DrawEllipse(myPen, Convert.ToInt32(x - (radius / 2)), Convert.ToInt32(y - (radius / 2)), Convert.ToInt32(radius), Convert.ToInt32(radius));
            myPen.Dispose();
        }

        public void updatePosition()
        {
            this.x += xspeed;
            this.y += yspeed;
        }
    }
}