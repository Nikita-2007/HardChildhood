using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace my_osu_
{
    public partial class Form1 : Form
    {
        private Bitmap target = Resource1.Kyrs;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics ctx = e.Graphics;

            ctx.DrawImage(target, 100, 100, 100, 100);
            ctx.DrawEllipse(new Pen(Color.Red, 2), 200, 200, 100, 100);
        }
    }
}