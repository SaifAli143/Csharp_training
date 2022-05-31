using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class datatypes
    {
        static void Main(string[] args)
        {


            Console.WriteLine(" enter name");
            string name = Console.ReadLine();
            Console.WriteLine("enter age");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" enter gender");
            char gender = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("mobile number");
            long mobile = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("persentage");
            float per = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("double data type");
            double db = Convert.ToDouble(Console.ReadLine());




        } 
    }
}
