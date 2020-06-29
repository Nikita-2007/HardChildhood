using System.Drawing;

namespace Tanks
{
    class Cratar
    {
        public PointF position;
        public ushort time;

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
            g.FillEllipse(new SolidBrush(Color.FromArgb(200-time/3, 0, 0, 0)), //(64/time +16, 32, 16, 0)),
                new RectangleF(-35, -35, 70, 70));
            g.ResetTransform();
        }
    }
}
