using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.OOPS.PROPERTIES
{
    class Parent1
    {
      public String pname;
        int pid;
        public Parent1()
        {
            Console.WriteLine(" defualt constructor");
        }
        public Parent1(string pname, int pid)
        {
            this.pname = pname;
            this.Pid = pid;
        }

        public int Pid { get => pid; set => pid = value; }
    }
    class Child : Parent1
    {
       public string cname;
       internal int cid;
        public Child()
        {

        }
        public Child(string cname, int cid)
        {
            this.Cname = cname;
            this.Cid = cid;
        }

        public string Cname { get => cname; set => cname = value; }
        public int Cid { get => cid; set => cid = value; }
    }
    class Childtest
    {
        static void Main(string[] args)
        {
            Parent1 p = new Parent1();
            p.Pid = 1;
            p.pname = "adcd";
            Child c = new Child();
            c.cid = 1;
            c.cname = "tre";

            Console.WriteLine("Parent id is="+p.Pid);
            Console.WriteLine("Parent name is="+p.pname);
            Console.WriteLine(" child id is="+c.Cid);
            Console.WriteLine("child name is="+c.cname);
        }
    }
}


