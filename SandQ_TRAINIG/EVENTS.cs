using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.SandQ_TRAINIG
{
    public delegate void del();
    public class Student
    {
        public event del Fail;
        public event del Distinction;
        public void AcceptMarks(int marks)
        {
            if(marks<40)
            {
                Fail();

            }
             else if (marks>=75)
            {
                Distinction();
            }
            Console.WriteLine($"Your score is {marks}");
        }
         class program
        {
            static void Failmsg()
            {
                Console.WriteLine("you are fail !");
            }
            static void Distinctiomsg()
            {
                Console.WriteLine("you are pass with Distinction !");
            }
            static void Main(string[] args)
            {
                Student s1 = new Student();
                s1.Fail += new del(Failmsg);
                s1.Distinction += new del(Distinctiomsg);
                s1.AcceptMarks(75);


            }
        }
            
    }


   
}
