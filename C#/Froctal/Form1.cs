﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace Froctal
{
    public partial class Froctal : Form
    {
        //Переменные
        private Bitmap bitmap;
        private Point point;
        private Point[] angle;
        private Random random;
        private int number, rand;
        private byte count = 3;

        public Froctal()
        {
            InitializeComponent();
            bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            random = new Random();

            angle = new Point[count];
            //кординыты
            angle[0] = new Point(400, 10);
            angle[1] = new Point(790, 790);
            angle[2] = new Point(10, 790);
            //angle[3] = new Point(10, 10);

            for (byte i = 0; i < count; i++)
                bitmap.SetPixel(angle[i].X, angle[i].Y, Color.Red);
        }

        //Запуска Таймера
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            point = PointToClient(Cursor.Position); 
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < 50000; i++)
            {
                number++;
                rand = random.Next(count);
                point.X = (point.X + angle[rand].X) / 2;
                point.Y = (point.Y + angle[rand].Y) / 2;
                bitmap.SetPixel(point.X, point.Y, Color.Black);
            }
            label1.Text = number.ToString();
            pictureBox1.Image = bitmap;
        }
    }
}