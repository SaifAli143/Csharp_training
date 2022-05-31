using System;
using System.Collections.Generic;
using System.Linq;
using System.Text ;
using System.Threading.Tasks;

namespace ConsoleApp2.classday3
{
    class Fibonacci
    {
        static void Main(string[] args)
        {
            int maxnumber = 20;
            int previousnumber = 0;
            int nextnumber = 1;
            Console.WriteLine("fibonacci series"+ maxnumber + "number:");

            for (int i = 1; i<= maxnumber; i++)
                {
                Console.WriteLine(previousnumber+" ");

                int sum = previousnumber + nextnumber;
                previousnumber = nextnumber;
                nextnumber = sum;


            }
        }

    }
}
