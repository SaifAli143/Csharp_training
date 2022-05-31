using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Homework.Stringarray
{
    class Alternatearray
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 4, 5 };
            int[] b = { 6, 7, 8, 9 };
            int[] c = new int[a.Length + b.Length];
            int j = 0;
            for (int i = 0; i < a.Length; i++)
            {
                c[j] = a[i];
                j = j + 2;
            }
            foreach(int x in c)
            {
                Console.WriteLine(x+" ");
            }
            j = 1;
            for(int i = 0; i < b.Length; i++) 
            { 
                if(j != b.Length)
                {
                    
                    c[j] = b[i];
                    j = j + 2;

                }
            
            }
            Console.WriteLine();
            Console.WriteLine("///////////");
            foreach(int x in c)
            {
                Console.WriteLine(x+" ");
            }
        }
    }
}
