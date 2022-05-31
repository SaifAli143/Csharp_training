using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Homework.Stringarray
{
    class Student

    {
        string name;
        int per;

        public Student(string name, int per)
        {
            this.Name = name;
            this.Per = per;
        }

        public string Name { get => name; set => name = value; }
        public int Per { get => per; set => per = value; }
    }
    class Student1
    {
        static void Main(string[] args)
        {
            Student[] sarr = new Student[5];

            string name;
            int per;


            for (int i = 0; i < sarr.Length; i++)
            {
                Console.WriteLine("enter name,per");
                name = Console.ReadLine();
                per = int.Parse(Console.ReadLine());
                sarr[i] = new Student(name,per);
            }
            for(int i=0;i<sarr.Length;i++)
            {
                Console.WriteLine(sarr[i]);
            }
        }

    }

}
