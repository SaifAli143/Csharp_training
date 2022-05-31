using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Homework.Pattern
{
    class Pattren16
    {
        static void Main(string[] args)
        {
            for ( int i=5; i<=1;i++)
            {
                for ( int j=i;j<=1;j--)
                    Console.Write(j);
            }
            Console.WriteLine();

        }
    }
}
