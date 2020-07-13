using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Aquarium
{
    public partial class Form1 : Form
    {
        public static Size window;
        public Graphics g;
        int x;
        private Fishes fishes = new Fishes();

        Fish1 fishone = new Fish1();
        Fish2 fishtwo = new Fish2();
        Fish3 fishthree = new Fish3();

        //Окно приложения
        public Form1()
        {
            window = ClientSize;
            InitializeComponent();
            SetStyle(ControlStyles.OptimizedDoubleBuffer |
                     ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.UserPaint, true);
            UpdateStyles();
        }

        //Таймер
        private void timer1_Tick(object sender, EventArgs e)
        {
            Refresh();
            x++;
            label1.Text = (x.ToString());
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            fishone.DrawFishs1(g);
            fishtwo.DrawFishs2(g);
            fishthree.DrawFishs3(g);
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = !timer1.Enabled;
        }
    }
}