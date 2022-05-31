using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Gcd
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number");
            int num1, num2, hcf, lcm;
            Console.WriteLine("find the gcd  and lcm ofgiven number");
            Console.WriteLine("------------------");

            Console.WriteLine("enter the first number");
            num1 = (int)Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("enter the second number");
            num2 = (int)Convert.ToInt64(Console.ReadLine());


            hcf = gcd(num1, num2);
            lcm = (num1 * num2) / hcf;

            Console.WriteLine(" the gcd of {0} and {1}| = {2}", num1, num2, hcf);
            Console.WriteLine(" the gcd of {0} and {1}| = {2}", num1, num2, lcm);
        }
        static int gcd(int n1,int n2)
        {

            if (n2 == 0)
            {
                return n1;
            }
            else
            {
                return gcd(n2, n1 % n2);
            }    


            }
           

        }
    }

