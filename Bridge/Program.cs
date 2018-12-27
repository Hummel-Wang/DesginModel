using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            BrushHelper b = new BigBrush();
            b.SetColor(new Red());
            b.Paint();
            b.SetColor(new Green());
            b.Paint();
            b.SetColor(new Blue());
            b.Paint();

            b = new SmallBrush();
            b.SetColor(new Red());
            b.Paint();
            b.SetColor(new Green());
            b.Paint();
            b.SetColor(new Blue());
            b.Paint();

            Console.ReadLine();
        }
    }
}
