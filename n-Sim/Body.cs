using System;
using System.Drawing;

namespace n_Sim
{
    internal class Body
    {
        public double x, y, xspeed, yspeed, mass;

        public Body(double x, double y, double xspeed, double yspeed, double mass)
        {
            this.x = x;
            this.y = y;
            this.xspeed = xspeed;
            this.yspeed = yspeed;
            this.mass = mass;
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
            Pen myPen = new Pen(Color.White);
            double radius = getRadius2D();
            g.DrawEllipse(myPen, Convert.ToInt32(x - (radius / 2)), Convert.ToInt32(y - (radius / 2)), Convert.ToInt32(radius), Convert.ToInt32(radius));
            myPen.Dispose();
        }

        public void updatePosition()
        {
            this.x += xspeed;
            this.y += yspeed;
        }
    }
}