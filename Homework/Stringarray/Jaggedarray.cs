using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Homework.Stringarray
{
    class Jaggedarray
    {
        static void Main(string[] args)
        {
            int[][] jarr = new int[3][];
            jarr[0] = new int[3];
            jarr[1] = new int[4];
            jarr[2] = new int[5];

            for(int i=0;i<jarr.GetLength(0);i++)
            {
                for(int j=0;j<jarr[i].Length;j++)
                {
                    jarr[i][j] = int.Parse(Console.ReadLine());

                }
            }

        }
    }
}
