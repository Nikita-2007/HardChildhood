using System.Drawing;

namespace Tanks
{
    class Tank : Unit, IDrawn
    {
        private static Size size = new Size(128, 128);
        private readonly Bitmap bitmap = new Bitmap(Properties.Resources.Танк);
        private readonly Rectangle body = new Rectangle(new Point(0, 0), size);
        private readonly Rectangle tower = new Rectangle(new Point(128, 0), size);
        private float vectorTower; // Угол поворота башни
        private Pen pen;

        //Отрисовка Танка
        public void DrawUnit(Graphics g, Point cursor)
        {           
            target = cursor;
            PositionUnit();
            vector = Vector(vector, speed);
            vectorTower = Vector(vectorTower, speed*2);

            #region **********************Отрисовка по частям**********************
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
            pen = new Pen(color, 2);
            g.DrawEllipse(pen, position.X-15, position.Y-15, 30, 30);

            DrawInfo(g);
            #endregion
        }
    }
}