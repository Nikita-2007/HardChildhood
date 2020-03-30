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
        Bitmap bitmap = new Bitmap(Properties.Resources.Танк);
        Rectangle body = new Rectangle(new Point(0,0), new Size(128, 128));
        Rectangle tower = new Rectangle(new Point(128, 0), new Size(256, 128));

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
        Point position = new Point(0, 600);
        private void FormTank_Paint(object sender, PaintEventArgs e)
        {
            x++;
            label1.Text = x.ToString();
            g = e.Graphics;           
            position.X++;
            position.Y--;

            //Танк 1
            g.DrawImage(bitmap, position.X, position.Y, body, GraphicsUnit.Pixel);
            g.DrawImage(bitmap, position.X, position.Y-15, tower, GraphicsUnit.Pixel);

            //Танк 2
            g.DrawImage(bitmap, position.X+100, position.Y + 100, body, GraphicsUnit.Pixel);
            g.DrawImage(bitmap, position.X + 100, position.Y +85, tower, GraphicsUnit.Pixel);
        }
    }
}