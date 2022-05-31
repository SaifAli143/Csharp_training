using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Collection
{
    class Linkedlist
    {
        static void Main(string[] args)
        {
            LinkedList<int> ll = new LinkedList<int>();
            ll.AddLast(90);
            ll.AddLast(100);
            ll.AddLast(110);
            ll.AddLast(120);
            ll.AddFirst(80);
            ll.Find(110);
            foreach(int data in ll)
                Console.WriteLine(data);
            
        }
    }
}
