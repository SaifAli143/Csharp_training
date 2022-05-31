using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Homework.Stringarray
{
    class Reverseoriginal
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" enter 6 element");
            int num = int.Parse(Console.ReadLine());
            int reverse = 0;
            while(num > 0)
            {
                int rem = num % 10;
                reverse = (reverse * 10) + rem;
                num = num / 10;

            }
            Console.WriteLine(" the reverse is = {0}",reverse);
            Console.ReadLine();
        }
    }
}
