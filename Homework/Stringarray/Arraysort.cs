using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Homework.Stringarray
{
    class Arraysort
    {
        static void Main(string[] args)
        {
            char[] ch= { 'r', 'y', 'a', 'A', 'i' };

            for(int i=0;i<ch.Length;i++)
            {
                for(int j=0;j<ch.Length;j++)
                {
                    if(ch[i]>ch[j])
                    {
                        char temp = ch[i];
                        ch[i] = ch[j];
                        ch[j] = temp;

                    }
                }
            }
            Console.WriteLine( );
            foreach(char c in ch)
            {
                Console.WriteLine(c+" ");
            }
        }
    }
}
