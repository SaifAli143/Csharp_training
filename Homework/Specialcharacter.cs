using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Homework
{
    class Specialcharacter
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" ENTER CHARACTER");
            char ch;
            ch = Convert.ToChar(Console.ReadLine());

			

			if ((ch >= 'a' && ch <= 'z') || (ch >= 'A' && ch <= 'Z'))
			{
                Console.WriteLine ("Alphabet");
			}
			else if (ch >= '0' && ch <= '9')
			{
                Console.WriteLine ("digit");
			}
			else
			{
                Console.WriteLine ("special character");
			}

		}
	}
}
