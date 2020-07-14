using System;
using System.Collections.Generic;
using System.Drawing;

namespace Aquarium
{
    class Fishes
    {
        public List<object> listfish = new List<object>();
        Random random = new Random();

        public Fishes()
        {
            for (int i = 0; i < 5; i++)
            {
                NewFish(new Fish1());
                NewFish(new Fish2());
                NewFish(new Fish3());
            }
        }

        private void NewFish(dynamic fish)
        {
            listfish.Add(fish);
            fish.position = Position();
            fish.target = Position();

        }
        public PointF Position()
        {
            PointF position = new PointF();
            position.X = random.Next(0, 1800);
            position.Y = random.Next(0, 1000);

            return position;
        }

        public void DrawListFish(Graphics g)
        {
            foreach (dynamic fish in listfish)
            {
                fish.Target();
                fish.Position();                
                fish.DrawFish(g);              
            }
        }
    }
}