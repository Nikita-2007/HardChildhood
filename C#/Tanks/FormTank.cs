using System;
using System.Drawing;
using System.Windows.Forms;

namespace Tanks
{
    public partial class FormTank : Form
    {
        Graphics g;
        ListTank listTank;

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
            listTank.DrawListTank(g);
        }

        private void FormTank_Load(object sender, EventArgs e)
        {
            listTank = new ListTank();
        }
    }
}