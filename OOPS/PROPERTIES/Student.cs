using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.OOPS.PROPERTIES
{
    class Student
    {
        int studid;
        string studname;
        int percent;
        Address addr = new Address();
        Batch batch1 = new Batch();

        public Student()
        {

        }
        public Student(int studid, string studname, int percent, Address addr, Batch batch1)
        {
            this.Studid = studid;
            this.Studname = studname;
            this.Percent = percent;
            this.Addr = addr;
            this.Batch1 = batch1;
        }

        public Batch Batch1 { get => batch1; set => batch1 = value; }
        public int Percent { get => percent; set => percent = value; }
        public Address Addr { get => addr; set => addr = value; }
        public string Studname { get => studname; set => studname = value; }
        public int Studid { get => studid; set => studid = value; }
    }
    class Address
    {
        string studadd;
        string batchadd;

        public Address()
        {

        }
        public Address(string studadd, string batchadd)
        {
            this.Studadd = studadd;
            this.Batchadd = batchadd;
        }

        public string Batchadd { get => batchadd; set => batchadd = value; }
        public string Studadd { get => studadd; set => studadd = value; }
    }
    class Batch
    {

        int batchid;
        string batchname;

        public Batch()
        {

        }
        public Batch(int batchid, string batchname)
        {
            this.Batchid = batchid;
            this.Batchname = batchname;
        }

        public string Batchname { get => batchname; set => batchname = value; }
        public int Batchid { get => batchid; set => batchid = value; }
    }
        
 class Studtest
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            s1.Studid = 12345;
            s1.Studname = "Hasnian";
            s1.Percent = 95;
            s1.Addr.Studadd = "Navi Mumbai";

            Console.WriteLine(" Student id is="+ s1.Studid);
            Console.WriteLine(" Student Name is="+s1.Studname);
            Console.WriteLine(" Student percent is="+s1.Percent);
            Console.WriteLine(" Student Address is="+s1.Addr.Studadd);
        }
    }

}
