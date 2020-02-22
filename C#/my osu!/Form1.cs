using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace my_osu_
{
    public partial class Form1 : Form
    {
        //Переменые и объекты
        private Random random = new Random();
        private Bitmap target = Resource1.cursor;
        private Point point = Point.Empty;
        private int score;

        //Запуск окна
        public Form1()
        {
            InitializeComponent();
            SetStyle(ControlStyles.OptimizedDoubleBuffer | 
                     ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.UserPaint, true);
            UpdateStyles();
            randomTarget();
        }

        //Отрисовка окна
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics ctx = e.Graphics;
            ctx.SmoothingMode = SmoothingMode.AntiAlias;
            Cursor.Hide();
            label1.Text = score.ToString();

            Point position = this.PointToClient(Cursor.Position);



            Rectangle krugPosition = new Rectangle(point.X, point.Y, 100, 100);
            Rectangle cursorPosition = new Rectangle(position.X - 50, position.Y - 50, 100, 100);

            ctx.DrawEllipse(new Pen(Color.Red, 2), krugPosition);
            ctx.DrawImage(target, cursorPosition); 
        }

        //Обновления
        private void timer1_Tick(object sender, EventArgs e)
        {
            score++;
            Refresh();
        }
        //Движение Круга
        private void randomTarget()
        {
            point.X = 600 + random.Next(-4, 4) * 100;
            point.Y = 400 + random.Next(-3, 3) * 100;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            randomTarget();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            randomTarget();
        }
    }
}