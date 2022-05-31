using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.OOPS             
{
    class Car
    {
       public int carno, carmodel;
        public string carname, carcolour;
        public long carprice;

        public void display()
        {
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Car c = new Car();
            string co= c.carcolour = "white";
            int m =c.carmodel = 123456;
            string na= c.carname = "carens";
            int n= c.carno = 4;
            long cp = c.carprice = 1140500;
            Console.WriteLine($" carprice={cp}");
            Console.WriteLine($" carcolour={co}");
            Console.WriteLine($" carmodel={m}");
            Console.WriteLine($" carname={na}");
            Console.WriteLine($" carno={n}");



        }

    }
    
}
