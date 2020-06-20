/*
 * Project: Библиотека для расчетов в 2D
 * Version: 1.0.0.1
 * Date:    20.06.2020
 * Autor:   Никита
 */

using System;
using System.Drawing;

namespace Game2d
{
    public static class Func2D
    { 
        ///<summary>
        ///Расчет растояния между точками int
        ///</summary>
        public static  int Delta(Point point1, Point point2)
        {
            int cathetX = point1.X - point2.X;
            int cathetY = point1.Y - point2.Y;
            
            return (int)Math.Sqrt(cathetX * cathetX + cathetY * cathetY);

        }

        ///<summary>
        ///Расчет растояния между точками float
        ///</summary>
        public static float Delta(PointF point1, PointF point2)
        {
            float cathetX = point1.X - point2.X;
            float cathetY = point1.Y - point2.Y;

            return (float)Math.Sqrt(cathetX * cathetX + cathetY * cathetY);

        }
    }
}