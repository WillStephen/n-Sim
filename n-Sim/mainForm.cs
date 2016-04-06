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
        Graphics g = null;
        List<Body> bodyList = new List<Body>();
        Body b1 = new Body(120, 120, 0.5, 0.5, 1000);
        Body b2 = new Body(239, 120, 2, 1, 2000);
        
        public mainForm()
        {
            InitializeComponent();
            bodyList.Add(b1);
            bodyList.Add(b2);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            frameUpdater.Start();
            g = this.CreateGraphics();
        }
        private void mainForm_Paint(object sender, PaintEventArgs e)
        {
            foreach (Body b in bodyList)
            {
                b.drawBody(g);
            }
            redrawBodies(bodyList);
        }
        
        private void frameUpdater_Tick(object sender, EventArgs e)
        {
            //redrawBodies(bodyList);
            b1.accelerate(-0.01, -0.01);
            b2.accelerate(-0.01, -0.01);
        }

        private void redrawBodies(List<Body> l)
        {
            foreach (Body b in l){
                b.updatePosition();
            }
            this.Refresh();
        }

    }
}
