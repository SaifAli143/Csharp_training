using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Homework.Pattern
{
    class Pattern
    {
        static void Main(string[] args)
        {
            for (int i = 'A'; i <= 'D'; i++)
            {
                for (int j = 'A'; j <= i; j++)
                    Console.Write(j);
            }
            Console.WriteLine();


            }
        }
    }

