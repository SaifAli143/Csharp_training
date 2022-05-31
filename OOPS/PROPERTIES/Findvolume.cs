using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.OOPS.PROPERTIES
{
    class Findvolume
    {
        internal double Volume(double r)
        {
            double v = ((4 / 3) * (22 / 7) * (r * r * r));
            return v;

        }
        internal double Volume(double h, double r)
        {
            double v = ((22 / 7) * (r * r) * h);
            return v;
        }
        internal double Volume(double l, double b, double h)
        {
            double v = l * b * h;
            return v;
        }
    }
    class Volume
    {
        static void Main(string[] args)
        {
            Findvolume v = new Findvolume();
            double result = v.Volume(12, 11, 25);
            Console.WriteLine(result);
        }
    }
}
