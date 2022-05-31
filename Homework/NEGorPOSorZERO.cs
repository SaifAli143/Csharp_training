using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Homework
{
    class NEGorPOSorZERO
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" ENTER NUMBER");
            int num ;
            num = Convert.ToInt32(Console.ReadLine());

            if (num < 0)
                Console.WriteLine ("number is negetive");

        else if (num > 0)
                Console.WriteLine ("number is positive");


        else
                Console.WriteLine ("number is zero");


        }
    }
}
