using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Homework.Stringarray
{
    class Stringdemo
    {
        static void Main(string[] args)
        {


            StringBuilder sbb = new StringBuilder("saif");
            sbb.Append("Ali");
            sbb.Append("Shaikh");
            Console.WriteLine(sbb);
            sbb.Insert(0, "S");
            Console.WriteLine(sbb );
            sbb.Remove(1, 1);
            Console.WriteLine(sbb);
        }
    }
}
