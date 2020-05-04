using System; 
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tanks
{
    public partial class FormTank : Form
    {
        public Graphics g;
        private ListUnit listUnit;
        private Point cursor;
        Shot shot = new Shot();

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
            listUnit = new ListUnit();
            listUnit.CreateListUnits();
            //SW();
            Sound();
        }

        //Обновление окна
        private void FormTank_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;
            cursor = PointToClient(Cursor.Position);
            listUnit.DrawListUnit(g, cursor);

            shot.position = new PointF(50, 50);
            shot.DrawShot(g, cursor);
        }

        //Таймер
        private void timer1_Tick(object sender, EventArgs e)
        {
            Refresh();
        }

        //Клик
        private void FormTank_Click(object sender, EventArgs e)
        {
            if (timer.Enabled == false) timer.Enabled = true;
            else timer.Enabled = false;
        }
        //Звук заставки
        private void SW()
        {
            Console.Beep(440, 500);
            Console.Beep(440, 500);
            Console.Beep(440, 500);
            Console.Beep(349, 350);
            Console.Beep(523, 150);
            Console.Beep(440, 500);
            Console.Beep(349, 350);
            Console.Beep(523, 150);
            Console.Beep(440, 1000);
            Console.Beep(659, 500);
            Console.Beep(659, 500);
            Console.Beep(659, 500);
            Console.Beep(698, 350);
            Console.Beep(523, 150);
            Console.Beep(415, 500);
            Console.Beep(349, 350);
            Console.Beep(523, 150);
            Console.Beep(440, 1000);
        }
        async private void Sound()
        {
            await Task.Run(() =>
            {
                for (int i = 100; i < 500; i += 10)
                {
                    Console.Beep(i, 100);
                }
            });
        }
    }
}