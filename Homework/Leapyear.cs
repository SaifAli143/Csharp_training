using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Homework
{
    class Leapyear
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" ENTER YEAR");
            int year;
            year = Convert.ToInt32(Console.ReadLine());
            if((year % 4) ==0)
                Console.WriteLine("is a leap year"+ year);
            else
                Console.WriteLine(" is a not leap year"+ year);

        }
    }
}
