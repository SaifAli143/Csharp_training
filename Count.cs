using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Count
    {
         static void Main(string[] args)
        {
            int count = 0;
            for (int i=0; i<=10;i++)
            {
                if(i%2!=0)
                {
                    Console.WriteLine(i);
                    count++;
                }
            }
            Console.WriteLine(" number of odd" + " " + count);
        }
    }
}
