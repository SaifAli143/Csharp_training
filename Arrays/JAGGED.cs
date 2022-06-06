using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Arrays
{
    class JAGGED
    {
        static void Main(string[] args)
        {
            int[][] ja = new int[4][]
            {
                new int [2] {1,2},
            new int[3] { 1, 2, 3 },
            new int[1] { 5 },
            new int[4] { 1,2,3,4 },

        };
            for(int i=0;i<ja.GetLength(0);i++)
            {
                for (int j = 0; j < ja.GetLength(1); j++)
                {
                    Console.Write(ja[i][j] +" ");

                }
                Console.WriteLine();
            }
        }
    }
}
