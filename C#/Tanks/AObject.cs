using System.Drawing;

namespace Tanks
{
    abstract class AObject 
    {
        public Color color; // Цвет
        public PointF position; // Позиция
        public PointF target; // Цель
        public float vector; // Угол поворота корпуса
        public float speed ; // Скорость
    }
}