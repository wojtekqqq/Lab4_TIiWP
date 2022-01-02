using ChartDrawer;
using Lab4.Component;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4.Decorator
{
    public class FunctionDecorator : Function
    {
        //obiekt, który będzie dekorowany
        protected Function _funkcja;

        public FunctionDecorator(Function function)
        {
            _funkcja = function;
        }

        public override List<Point> GetY()
        {
            return _funkcja.GetY();
        }

        public override void PrintChar()
        {
            _funkcja.PrintChar();
        }


    }
}
