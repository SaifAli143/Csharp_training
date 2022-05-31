using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Homework
{
    class Wordnumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" ENTE NUMBER");

            String a = Console.ReadLine();

            switch (a)
            {
                case "0":
                    Console.WriteLine("zero");
                    break;
                case "1":
                    Console.WriteLine("ONE");
                    break;
                case "2":
                    Console.WriteLine("TWO");
                    break;
                case "3":
                    Console.WriteLine("THREE");
                    break;
                case "4":
                    Console.WriteLine("FOUR");
                    break;
                case "5":
                    Console.WriteLine("FIVE");
                    break;
                case "6":
                    Console.WriteLine("SIX");
                    break;
                case "7":
                    Console.WriteLine("SEVEN");
                    break;
                case "8":
                    Console.WriteLine("EIGHT");
                    break;
                case "9":
                    Console.WriteLine("NINE");
                    break;
                default:
                    Console.WriteLine(" INVALID");
                        break;


            }
                
        }
    }
}
