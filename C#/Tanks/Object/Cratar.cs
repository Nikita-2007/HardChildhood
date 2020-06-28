using System.Drawing;

namespace Tanks
{
    class Cratar
    {
        public PointF position;
        public byte time;

        /// <summary>
        /// 
        /// </summary>
        public Cratar(PointF position)
        {
            this.position = position;
        }

        public void DrawCratar(Graphics g)
        {
            g.TranslateTransform(position.X, position.Y);
            g.FillEllipse(new SolidBrush(Color.FromArgb(200, 0, 0, 0)),
                new RectangleF(-35, -35, 70, 70));
            g.ResetTransform();
        }
    }
}
