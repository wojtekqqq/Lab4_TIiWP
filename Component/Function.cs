using ChartDrawer;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4.Component
{
    public abstract class Function
    {
        int Id { get; }
        string Name { get; }
        public abstract List<Point> GetY();
        public abstract void PrintChar();    

    }
}
