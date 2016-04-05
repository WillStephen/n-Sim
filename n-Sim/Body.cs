using System.Drawing;

namespace n_Sim
{
    internal class Body
    {
        int x, y, xspeed, yspeed, mass;
        Graphics g;

        public Body(Graphics g, int x, int y, int xspeed, int yspeed, int mass)
        {
            this.x = x;
            this.y = y;
            this.xspeed = xspeed;
            this.yspeed = yspeed;
            this.mass = mass;
            drawBody(g);
        }

        public void drawBody(Graphics g)
        {
            Pen myPen = new Pen(Color.White);
            //g.DrawEllipse(myPen, x-mass, y-mass, x+(mass*2), y+(mass*2));
            g.DrawEllipse(myPen, x-(mass/2), y-(mass/2), mass, mass);
            System.Console.WriteLine("memes");
        }
    }
}