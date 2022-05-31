using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Homework.Stringarray
{
    class Searechelement
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 4, 5, 6, 7 };
            int index = -1;
          
            for (int i = 0; (i<5) && (index == -1); i++)
            {
                if (array[i] == 6)
                {
                    index = i;

                }
            }


            Console.WriteLine(" index position of element  is " + index );
        }
    }
}
