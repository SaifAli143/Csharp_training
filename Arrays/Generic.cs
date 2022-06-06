using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Arrays
{
    class Generic
    {
       public void Display<Typeofvalue>(string msg,Typeofvalue value)
        {
            Console.WriteLine("{0}:{1}",msg ,value);
        }
    }
    class Test1
    {
        static void Main(string[] args)
        {
            Generic p = new Generic();
            p.Display<int>("Integer", 12);
            p.Display<char>("character", 's');
            p.Display<double>("Double", 255.67);
            
        }
    }
}
