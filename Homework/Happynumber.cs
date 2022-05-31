using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Homework
{
    class Happynumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" ENTER HAPPY NUMBER");
            int num = Convert.ToInt32(Console.ReadLine());
            int rem;
            int flag = 1;

            while (num > 0)
            {
                rem = num % 10;
                if (rem%2!=0)
                {
                    flag = 0;
                    break;
                }
                 
                num = num / 10;

            }
            if (flag==1)
            {
                Console.WriteLine("HAPPY NUMBER");
            }
            else 
            {
                Console.WriteLine("NOT HAPPY NUMBER");
            }
           

        }
    }
}
