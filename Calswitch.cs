using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
	class Calswitch
	{
		static void Main(string[] args)
		{
            Console.WriteLine(" enter number");
			int choice = 1;
			int num1 = Convert.ToInt32(Console.ReadLine());
			int num2 = Convert.ToInt32(Console.ReadLine());
			switch (choice)
			{
				case 1:
					Console.WriteLine("ADDITION=" + " " + (num1 + num2));
					break;
				case 2:
					Console.WriteLine("DIVISION=" + " " + (num1 / num2));
					break;
				case 3:
					Console.WriteLine("multiplication=" + "  " + (num1 * num2));
					break;
				case 4:
					Console.WriteLine("substraction=" + "  " + (num1 - num2));
					break;
				default:
					Console.WriteLine(" Invalid ");
					break;
			}


		}
	}
}