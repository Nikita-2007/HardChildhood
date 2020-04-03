using System; 
using System.Drawing;
using System.Windows.Forms;

namespace Tanks
{
    public partial class FormTank : Form
    {
        public Graphics g;
        private ListTank listTank;
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
            listTank = new ListTank();
            listTank.CreateListTank();
        }

        //Обновление окна
        private void FormTank_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;
            cursor = PointToClient(Cursor.Position);
            listTank.DrawListTank(g, cursor);        }

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
    }
}