using System;
using System.Drawing;

namespace Tanks
{
    class Tank
    {
        public int id; // Я тепя по ID вычеслю
        float vector; // Угол поворота корпуса
        float vectorTower; // Угол поворота башни

        Bitmap bitmap = new Bitmap(Properties.Resources.Танк);
        Rectangle body = new Rectangle(new Point(0, 0), new Size(128, 128));
        Rectangle tower = new Rectangle(new Point(128, 0), new Size(256, 128));
        public Point position; //Местоположение Танк
        Point target; //Метка                               
        Random random = new Random();                       
                                                            
        //Отрисовка Танка                                   
        public void DrawTank(Graphics g)                    
        {                                                                            
                                                            
            //Корпус                                        
            g.TranslateTransform(position.X, position.Y);   
            g.RotateTransform(vector);                      
            g.DrawImage(bitmap, -64, -75, body, GraphicsUnit.Pixel);
            g.ResetTransform();

            //Башня
            g.TranslateTransform(position.X, position.Y);
            g.RotateTransform(vectorTower);
            g.DrawImage(bitmap, -64, -90, tower, GraphicsUnit.Pixel);
            g.ResetTransform();
        }

        //Позиция танка
        public Point Position()
        {
            position.X = random.Next(1280);
            position.Y = random.Next(720);
            return position;
        }
    }
}      