using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Homework.Stringarray
{
    class Stringreverse
    {
        static void Main(string[] args)
        {
            String str = " india is my country";
            string s = "";
            for(int i=0;i<str.Length;i++)
            {
                s = str[i] + s;

            }
            Console.WriteLine("Reverse string="+s);
        }
        
    }
}
