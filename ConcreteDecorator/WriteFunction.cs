using ChartDrawer;
using Lab4.Component;
using Lab4.Decorator;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Lab4.ConcreteDecorator
{
    class WriteFunction : FunctionDecorator
    {
        public WriteFunction(Function function)
            : base(function)
        {
        }

        public override void PrintChar()
        {
            base.PrintChar();
            WriteToFile();
        }

        /*        public override List<Point> GetY()
                {
                    base.GetY();
                    WriteToFile();
                    return base.GetY();
                }*/
        void WriteToFile()
        {
            var result = base.GetY();
            string txtFile = @".\plik.txt";
            Path.GetFileNameWithoutExtension(txtFile);
            Console.WriteLine(Path.GetFileNameWithoutExtension(txtFile));
            using (TextWriter tw = new StreamWriter(txtFile))
            {
                tw.WriteLine(Path.GetFileNameWithoutExtension(txtFile));
                tw.WriteLine("x y");
                foreach (var item in result)
                {
                    tw.WriteLine(item.X + " " + item.Y);
                }
            }
            var p = new System.Diagnostics.Process();
            p.StartInfo = new System.Diagnostics.ProcessStartInfo(txtFile)
            {
                UseShellExecute = true
            };
            p.Start();

/*            System.IO.File.WriteAllText("plik.txt", result.ToString());*/

        }
    }
    
}
