﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Homework.Pattern
{
    class Pattern16
    {
        static void Main(string[] args)
        {
            int rows = 5;
            for (int i = 1; i <= rows; i++)
            {
                for (int j = rows; j >= i; j--)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
        }
    }
}