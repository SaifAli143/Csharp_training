using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Homework.Stringarray
{
    class Sortname
    {
        // ascci value check kar k sorting hoga
        static void Main(string[] args)
        {
            string[] name = { "saif", "Hasnian", "hayat" };

            for(int i=0;i<name.Length;i++)
            {
                for(int j=0;j<name.Length;j++)
                {
                    if (name[i].CompareTo(name[j])<0);
                    {
                        string temp = name[i];
                        name[i] = name[j];
                        name[j] = temp;
                    }
                }
            }
            Console.WriteLine();

            foreach(string str in name)
            {
                Console.WriteLine(str+" ");
            }
        }
    }
}
