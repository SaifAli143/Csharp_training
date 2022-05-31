using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Homework
{
    class Bouncy
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" ENTER NUMBER");
            int a = Convert.ToInt32(Console.ReadLine());

            bool isincrease = true;
            bool isdecrease = true;

            int next = a % 10;
            a = a / 10;
             
            while (a>0)
            {
                int prev = a % 10;

                if (prev>next)
                {
                    isincrease = false;

                }
                if (prev<next)
                {
                    isdecrease = false;
                }

                a = a / 10;
                next = prev;

            }
            if (isincrease)
                Console.WriteLine(" number is increase");
            else if (isdecrease)
                Console.WriteLine(" number is decrease");
            else
                Console.WriteLine(" number is bouncy");

        }
    }
}
