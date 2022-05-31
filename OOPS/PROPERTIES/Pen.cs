using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.OOPS.PROPERTIES
{
    class Pen
    {
        int caplength;
        string brand;
        Refill refill;
         
        public Pen()
        {
            Console.WriteLine(" Defualt constructor");
        }
        
        public int Caplength
        {
            get { return caplength; }
            set { caplength = value; }
        }
        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }
    } 
    class Refill
    {
        string inkcolour;
        string reflength;
        string refnib;


       

        public Refill()
        {
            Console.WriteLine(" Defualt constructor");
        }

        public Refill(string inkcolour, string reflength, string refnib)
        {
            this.inkcolour = inkcolour;
            this.reflength = reflength;
            this.refnib = refnib;
        }

        public string Inkcolour
        {
            get { return inkcolour; }
            set { inkcolour = value; }

        }

        public string Reflength
        {
            get { return reflength; }
            set { reflength = value; }

        }

        public string Refnib
        {
            get { return refnib; }
            set { refnib = value; }

        }




    }

    class Pentest
    {
        static void Main(string[] args)
        {
            Pen p = new Pen();
            p.Caplength = 2;
            p.Brand = "cello";
            
            

        }
    }

}
