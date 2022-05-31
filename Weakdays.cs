using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
	class Weakdays
	{
		static void Main(string[] args)
		{
			Console.WriteLine(" enter weakday");
			int day;
			day = Convert.ToInt32(Console.ReadLine());

			switch (day)
			{
				case 1:
					Console.WriteLine("sunday");
					break;
				case 2:

					Console.WriteLine("monday");
					break;
				case 3:
					Console.WriteLine("tuesday");
					break;
				case 4:
					Console.WriteLine("wednesday");
					break;
				case 5:
					Console.WriteLine("thursday");
					break;
				case 6:
					Console.WriteLine("friday");
					break;
				case 7:
					Console.WriteLine("saturday");
					break;
				default:
					Console.WriteLine("invalid");
					break;
			}
		}
	}
}
