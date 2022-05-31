using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.OOPS
{
    class Calculator
    {
        public void add(int a, int b, int c)
        {
            int d = a + b + c;
            Console.WriteLine("sum" + d);
        }
        public int factorial(int n)
        {
            int i, fact = 1;
            for (i = 1; i <= n; i++)
            {
                fact = fact * i;
            }
            return fact;
        }
        public bool isprime(int n)
        {
            int flag = 0;
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    flag = 1;
                    break;
                }

            }
            if (flag == 0)

                return true;
            else
                return false;


        }
        public string greet(string nm)
        {
            return " Good Afternoon " + nm;

        }

        static void Main(string[] args)
        {
            Calculator c = new Calculator();
            c.add(35, 56, 2);
            int fc = c.factorial(5);
            bool bl = c.isprime(4);
            string s = c.greet("Hello saif");
            Console.WriteLine($" factorial={fc}");
            Console.WriteLine($" isprime={bl}");
            Console.WriteLine( $" greet={s}");



        }
    }
}
