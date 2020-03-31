using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tanks
{
    public partial class FormTank : Form
    {
        Graphics g;
        Tank tank = new Tank();
        Random random = new Random();
        Point position = Point.Empty;

        public FormTank()
        {
            InitializeComponent();
            SetStyle(ControlStyles.OptimizedDoubleBuffer |
                     ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.UserPaint, true);
            UpdateStyles();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Refresh();

        }
        int x = 0;
        private void FormTank_Click(object sender, EventArgs e)
        {
            if (timer.Enabled == false) timer.Enabled = true;
            else timer.Enabled = false;
        }

        private void FormTank_Paint(object sender, PaintEventArgs e)
        {
            x++;
            label1.Text = x.ToString();
            g = e.Graphics;
            //for (byte i = 0; i < 10; i++)
           //{
                position.X = random.Next(-0, 0)+500;
                position.Y = random.Next(-0, 0)+300;
                tank.DrawTank(g, position);
            //}
        }

    }
}