using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Homework
{
    class Vowels
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" ENTER ALPHABET");
            char ch;
            ch = Convert.ToChar(Console.ReadLine());

            
            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
            {
                Console.WriteLine("VOWELS");

            }
            else if (ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U')
            {
                Console.WriteLine ("VOWELS");
            }
            else
            {
                Console.WriteLine ("consonant");
            }

        }
    }
}
