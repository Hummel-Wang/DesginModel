using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class Color
    {
        public string color;
    }

    class Red : Color
    {
        public Red()
        {
            this.color = "red";
        }
    }

    class Green : Color
    {
        public Green()
        {
            this.color = "green";
        }
    }

    class Blue : Color
    {
        public Blue()
        {
            this.color = "blue";
        }
    }

    abstract class BrushHelper
    {
        protected Color c;
        public abstract void Paint();
        public void SetColor(Color c)
        {
            { this.c = c; }
        }
    }

    class BigBrush : BrushHelper
    {
        public override void Paint()
        {
            Console.WriteLine("Using big brush and color {0} painting", c.color);
        }
    }

    class SmallBrush : BrushHelper
    {
        public override void Paint()
        {
            Console.WriteLine("Using small brush and color {0} painting", c.color);
        }
    }
}
