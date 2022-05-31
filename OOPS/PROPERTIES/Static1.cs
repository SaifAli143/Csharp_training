using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.OOPS.PROPERTIES
{
    class Test1
    {
        static int id;
        int price;

        internal Test1()
        {
            Console.WriteLine(" its defualt");
        }
        internal Test1(int price)
        {
            Console.WriteLine(" parameterised ");
            this.price = price;
            Console.WriteLine(price);
        }

        static Test1()
        {
            Console.WriteLine(" static constructor");
            id = 4321;
            Console.WriteLine(id);

        }


         
    }
    class test2
    {
        static void Main(string[] args)
        {
            Test1 t = new Test1(150);
        }
    }
}
