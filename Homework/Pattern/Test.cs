﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Homework.Pattern
{
    class Test
    {
        static void Main(string[] args)
        {
        
            int i ,s=0;
            for (i = 1; i <= 10; s = s + i,i++);
            {
                Console.WriteLine(s);
            }
            Console.ReadLine();
        }
    }
}
