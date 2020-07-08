using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Tanks
{
    public partial class FormTank : Form
    {
        public static Size window;
        private Game game;
        public Graphics g;
        private Point cursor;

        //Окно приложения
        public FormTank()
        {
            InitializeComponent();
            SetStyle(ControlStyles.OptimizedDoubleBuffer |
                     ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.UserPaint, true);
            UpdateStyles();
        }

        //Загрузка окна
        private void FormTank_Load(object sender, EventArgs e)
        {
            window = ClientSize;
            game = new Game();
            game.StartGame();
        }

        //Обновление окна
        private void FormTank_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            cursor = PointToClient(Cursor.Position);
            game.StepGame(g);
        }

        //Таймер
        private void timer1_Tick(object sender, EventArgs e)
        {
            Refresh();
        }

        //Клик
        private void FormTank_Click(object sender, EventArgs e)
        {
            timer.Enabled = !timer.Enabled;
        }

        //Двойной клик
        private void FormTank_DoubleClick(object sender, EventArgs e)
        {
            if ( FormBorderStyle == FormBorderStyle.Sizable)
                 FormBorderStyle = FormBorderStyle.None;
            else FormBorderStyle = FormBorderStyle.Sizable;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            game = new Game();
            game.StartGame();
            Refresh();
        }
    }
}