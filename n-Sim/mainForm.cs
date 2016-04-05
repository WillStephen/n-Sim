using System;
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
        public mainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void mainForm_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Body b1 = new Body(g, 0, 0, 0, 0, 35);
        }
    }
}
