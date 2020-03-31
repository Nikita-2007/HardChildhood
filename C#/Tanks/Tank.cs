using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tanks
{
    class Tank
    {
        Bitmap bitmap = new Bitmap(Properties.Resources.Танк);
        Rectangle body = new Rectangle(new Point(0, 0), new Size(128, 128));
        Rectangle tower = new Rectangle(new Point(128, 0), new Size(256, 128));
        int x = 0;
        public void DrawTank(Graphics g, Point position)
        {
            x += 2;
            //туловище
            g.TranslateTransform(position.X, position.Y);
            g.RotateTransform(x-4);
            g.DrawImage(bitmap, -64, -75, body, GraphicsUnit.Pixel);
            g.ResetTransform();

            //Башня
            g.TranslateTransform(position.X, position.Y);
            g.RotateTransform((x-4)/2);
            g.DrawImage(bitmap, -64, -90, tower, GraphicsUnit.Pixel);
            g.ResetTransform();
        }
    }
}