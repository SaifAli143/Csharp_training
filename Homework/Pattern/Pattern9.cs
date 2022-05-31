using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Homework.Pattern
{
    class Pattern9
    {
		static void Main(string[] args)
		{
			int rows = 5;
			for (int i = rows; i >= 1; i--)
			{
				for (int j = 1; j < i; j++)
				{
					Console.Write(" ");
				}
				for (int k = i; k <= rows; k++)
				{
					Console.Write(k + " ");
				}
				Console.WriteLine();
			}
		}
	}
}

