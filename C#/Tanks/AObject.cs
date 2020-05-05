using System.Drawing;

namespace Tanks
{
    abstract class AObject 
    {
        public float vector; // Угол поворота корпуса
        public PointF position; // Позиция
        public float speed ; // Скорость
        public PointF target; // Цель
    }
}
