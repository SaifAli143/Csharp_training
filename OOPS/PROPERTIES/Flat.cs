using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.OOPS.PROPERTIES
{
    class Flat
    {
        
        int flatno;
        string builgingname;
        Member mem = new Member();
        public Flat()
        {

        }
        public Flat(int flatno, string builgingname, Member mem)
        {
            this.Flatno = flatno;
            this.Builgingname = builgingname;
            this.Mem = mem;
        }

        public string Builgingname { get => builgingname; set => builgingname = value; }
        public int Flatno { get => flatno; set => flatno = value; }
        internal Member Mem { get => mem; set => mem = value; }
    }
    class Member
    {
        string membername;
        char gender;
        int age;
        string profession;
        public Member()
        {

        }
        public Member(string profession)
        {
            this.Profession = profession;
        }

        public string Profession { get => profession; set => profession = value; }
        public string Membername { get => membername; set => membername = value; }
        public char Gender { get => gender; set => gender = value; }
        public int Age { get => age; set => age = value; }
    }
    class Flattest
    {
        static void Main(string[] args)
        {
            Flat f1 = new Flat();
            f1.Flatno= 02;
            f1.Builgingname= "River Dala";
            f1.Mem.Profession= "doctor";
            f1.Mem.Age = 30;
            f1.Mem.Membername = "ajay";
            Console.WriteLine("Flatno is="+f1.Flatno);
            Console.WriteLine("Building Name is= "+f1.Builgingname);
            Console.WriteLine("Member profession is="+f1.Mem.Profession);
            Console.WriteLine(" Member age is="+ f1.Mem.Age);
            Console.WriteLine(" Member name is= "+f1.Mem.Membername);

              
            
        }
    }
}
