using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Media;
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
        private Pen pen = new Pen(Color.Red, 2);
        private SoundPlayer soundPlayer = new SoundPlayer(Resource1.click);

        //Запуск окна
        public Form1()
        {
            InitializeComponent();
            SetStyle(ControlStyles.OptimizedDoubleBuffer | 
                     ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.UserPaint, true);
            UpdateStyles();
            Cursor.Hide();
            randomTarget();
        }

        //Отрисовка окна
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics ctx = e.Graphics;
            ctx.SmoothingMode = SmoothingMode.AntiAlias;

            Point position = this.PointToClient(Cursor.Position);

            Rectangle krugPosition = new Rectangle(point.X, point.Y, 100, 100);
            Rectangle cursorPosition = new Rectangle(position.X - 50, position.Y - 50, 100, 100);

            ctx.DrawEllipse(pen, krugPosition);
            ctx.DrawImage(target, cursorPosition);

            int katetY = cursorPosition.Y - krugPosition.Y;
            int katetX = cursorPosition.X - krugPosition.X;
            int gepatenyza = (int) Math.Sqrt( katetX * katetX + katetY * katetY);

            label1.Text = gepatenyza.ToString();
        }

        //Обновления
        private void timer1_Tick(object sender, EventArgs e)
        {
            Refresh();
        }
        //Движение Круга
        private void randomTarget()
        {
            point.X = Width/2 + random.Next(-4, 4) * 100;
            point.Y = Height/2 + random.Next(-3, 3) * 100;
            
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            StepGame();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            StepGame();
        }

        //Ход игры
        private void StepGame()
        {
            score++;
            soundPlayer.Play();
            randomTarget();
        }

    }
}