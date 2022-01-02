using ChartDrawer;
using Lab4.Component;
using Lab4.ConcreteComponent;
using Lab4.ConcreteDecorator;
using System;
using System.Collections.Generic;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*            List<Point> points = new List<Point>();
                        double x = 0, y = 0;

                        for (int i = 0; i < 30; i++)
                        {
                            x = i;
                            y = i * i;
                            points.Add(new Point(x, y));

                        }

                        Charts chr = new Charts();
                        *//*            chr.GenerateChart("T", "X", "Y", new List<Point> { new Point(1, 2), new Point(5, 6) }, "aaa.jpg");*//*
                        chr.GenerateChart("T", "X", "Y", points, "aaa.jpg");*/

            SquareFunction sq = new SquareFunction();
            WriteFunction wf = new WriteFunction(function: Function);
        }

    }
}
