using ChartDrawer;
using Lab4.Component;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4.ConcreteComponent
{
    class SquareFunction : Function
    {
        public int Id => 1;
        public string Name => "y=x*x";

        public override List<Point> GetY(List<Point> points)
        {
            double x = 0, y = 0;
            for (int i = 0; i < 30; i++)
            {
                x = i;
                y = i * i;
                points.Add(new Point(x, y));

            }
            return points;
        }

        public override void PrintChar()
        {

        }

    }
}
