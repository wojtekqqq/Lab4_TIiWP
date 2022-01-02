using ChartDrawer;
using Lab4.Component;
using Lab4.Decorator;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4.ConcreteDecorator
{
    class WriteFunction : FunctionDecorator
    {
        public WriteFunction(Function function)
            : base(function)
        {
        }
        public override List<Point> GetY(List<Point> points)
        {
            base.GetY(points);
            WriteToFile();
            return base.GetY(points);
        }
        void WriteToFile()
        {
        }
    }
    
}
