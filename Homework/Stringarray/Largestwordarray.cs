using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Homework.Stringarray
{
    class Largestwordarray
    {
        static void Main(string[] args)
        {
            string[] s = {"hello" ,"saif" ,"Goodmorning" };
            string s1 = s[0];
            for( int i=0;i<s.Length;i++)
            {
                s1 = s[i];
            }
            Console.WriteLine(s1);
        }
    }
}
