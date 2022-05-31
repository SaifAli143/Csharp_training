using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Class1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("odd number");
            for (int i=521;i>=229;i--)
            {
                if(i%2!=0)
                    Console.WriteLine(i);
            }
        }
    }
}
