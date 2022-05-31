using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Homework.Pattern
{
    class Pattern1
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                }
            }
            Console.WriteLine();
            
        }
    }
}
class Pattern8
{
    static void Main(string[] args)
    {
        int rows = 5;
        for (int i = 1; i <= rows; i++)
        {
            for (int j = rows; j > i; j--)
            {
                Console.Write(" ");

                for (int k = 1; k <= i; k++)
                {
                    Console.Write(k + " ");
                }
                Console.WriteLine();
            }
        }
    }
}