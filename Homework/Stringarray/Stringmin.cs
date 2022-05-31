using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Homework.Stringarray
{
    class Stringmax
    {
        static void Main(string[] args)
        {
			int [] a= { 11, 3, 5, 7, 8 };
			int max = a[0];
			for (int i = 0; i < 5; i++)
				if (a[i] > max)
				{
					max = a[i];
				}

            Console.WriteLine (" MAX " + max);
		}
    }
}
    class Stringmin
{
    static void Main(string[] args)
    {
		int [] a= { 11, 3, 5, 7, 8 };
		int min = a[0];
		for (int i = 0; i < 5; i++)
			if (a[i] < min)
			{
				min = a[i];
			}

        Console.WriteLine (" MIN " + min);

	}
}