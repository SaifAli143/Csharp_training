using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

        
namespace ConsoleApp2.classday2 
{
    class BaseIndex
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" ENTER BASE");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" ENTER POWER");
            int p = Convert.ToInt32(Console.ReadLine());
            int power = 1;
            while (p>0)
            {
                power = power * b;
                p--;

            }
            Console.WriteLine(power);

        }
    }
}
