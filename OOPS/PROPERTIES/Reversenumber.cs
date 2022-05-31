using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.OOPS.PROPERTIES
{
    class Reversenumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number");
             
            int num = int.Parse(Console.ReadLine());
            int reverse = 0;
            while(num>0)
            {
                int remainder = num % 10;
                reverse = (reverse * 10)+remainder;
                num = num / 10;


            }
            Console.WriteLine("reverse no is ="+reverse);
            Console.ReadLine();
        }
    }
}
