using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.ExceptionHandling
{
   public class Thread
    {
        public static object CurrentThread { get; private set; }

        static void m1()
        {
            Console.WriteLine("in m1");
            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine("CUrrent Thread "+Thread.CurrentThread.Name + i);
            //}

            Console.WriteLine("m1 ends");
        }
        //static void Main(string[] args)
        //{
        //    Console.WriteLine(" Main Starts");
        //    Thread.CurrentThread.Name = "Main";
        //    Console.WriteLine("Name="+Thread.CurrentThread.Name);
        //    Thread t1 = new Thread(m1);
        //    t1.Name = "child";
        //    t1.start();

        //    for (int i = 1; i <= 10; i = i + 2)
        //    {
        //        Console.WriteLine("main " + i);
        //        Console.WriteLine("main ends");

        //    }



        }
    }

