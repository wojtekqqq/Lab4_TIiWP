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
            Function sq = new SquareFunction();
            sq = new WriteFunction(sq);
            sq.PrintChar();
        }
    }
}
