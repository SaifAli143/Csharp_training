using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.OOPS.PROPERTIES
{
   public class Teacher
    {
        int tid;
        String tname;
        long mobileno;

        public Teacher()
        {

        }
        public Teacher(int tid, string tname, long mobileno)
        {
            this.Tid = tid;
            this.Tname = tname;
            this.Mobileno = mobileno;
        }

        public long Mobileno { get => mobileno; set => mobileno = value; }
        public string Tname { get => tname; set => tname = value; }
        public int Tid { get => tid; set => tid = value; }
    }
}
