using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Greaternum
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" ENTER NUMBER ");
            int A, B, C;
            A = Convert.ToInt32(Console.ReadLine());
            B = Convert.ToInt32(Console.ReadLine());
            C = Convert.ToInt32(Console.ReadLine());

            if (A > B && A > C)
            {
                Console.WriteLine(" A number is gtreater" + " " + A);
            }
            else if (B > C)
            {
                Console.WriteLine(" B number is greater" + " " + B);
            }
            else
            {

                Console.WriteLine(" C number is greater" + " " + C);
            }

        }
    }
}
