using System;
using System.Drawing;

namespace n_Sim
{
    internal class Body
    {
        int x, y, xspeed, yspeed;
        double mass;

        public Body(Graphics g, int x, int y, int xspeed, int yspeed, double mass)
        {
            this.x = x;
            this.y = y;
            this.xspeed = xspeed;
            this.yspeed = yspeed;
            this.mass = mass;
            drawBody(g);
        }

        public double getRadius()
        {
            //m = 4(pir^3)/3
            //3m = 4(pi*r^3)
            //3/4m = pi*r^3
            //cbrt(3/4m/pi) = r
            double r = Math.Pow(((this.mass * 0.75) / Math.PI), 1.0 / 3);
            return r;
        }

        public void drawBody(Graphics g)
        {
            Pen myPen = new Pen(Color.White);
            double radius = getRadius();
            g.DrawEllipse(myPen, x - Convert.ToInt32(radius / 2), y - Convert.ToInt32(radius / 2), Convert.ToInt32(radius), Convert.ToInt32(radius));
            myPen.Dispose();
        }

        public void updatePosition()
        {
            this.x += xspeed;
            this.y += yspeed;
        }
    }
}