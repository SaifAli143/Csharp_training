using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.ExceptionHandling
{
    class StudIcompare: IComparable
    {
        string sname;
        int percent;
        string city;

        public StudIcompare(string sname, int percent, string city)
        {
            this.Sname = sname;
            this.Percent = percent;
            this.City = city;
        }

        public string Sname { get => sname; set => sname = value; }
        public int Percent { get => percent; set => percent = value; }
        public string City { get => city; set => city = value; }

        public int CompareTo(object o)
        {
            StudIcompare s2 = (StudIcompare)o;
            return this.sname.CompareTo(s2.Sname);

        }
        public override string ToString()
        {
            return $"Name:{sname} City{city} Percent{percent}";
        }
    }

    class S
    {
        static void Main(string[] args)
        {
           // SortedList ss = new SortedList();
            //ss.Add(new StudIcompare("SAIF", 97, "NAVI MUMBAI"));
            //ss.Add(new StudIcompare("hasnain", 98, " MUMBAI"));
        }
    }
}
