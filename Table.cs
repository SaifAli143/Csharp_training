using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Table
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" ENTER TABLE NUMBER");
            int table;
             table = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {



                Console.WriteLine (table + " * " + i + " = " + table * i);
            }
        }
    }
}
