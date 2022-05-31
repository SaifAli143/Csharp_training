using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Homework
{
    class OddorEven
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" ENTER NUMBER");
            int num;
            num = Convert.ToInt32(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine ("Number is even");

            }
            else 
            {
                Console.WriteLine("Number is odd");
            }
        }
    }
    }

