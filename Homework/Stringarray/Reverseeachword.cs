using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Homework.Stringarray
{
    class Reverseeachword
    {
        static void Main(string[] args)
        {
            string str = "india is my country";
            string[] s = str.Split(" ");
            string word = "";
            for(int i=0;i<s.Length;i++)
            {
                string s1 = s[i];
                string str1 = "";
                for(int j=0;j<s1.Length;j++)
                {
                    str1 = s1[j] + str1;
                }
                word = word + str1 + " ";
            }
            Console.WriteLine(word);
        }
    }
}
