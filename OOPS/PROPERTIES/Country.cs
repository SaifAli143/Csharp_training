using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.OOPS.PROPERTIES
{
    class Country
    {
        string countryname;
        int noofstates;
        int nooflanguages;
        string capital;

        public string Countryname 
        
         {
            get { return countryname; }
            set { countryname = value; }
         }
        public int Noofstates
        {
            get { return noofstates; }
            set{ noofstates = value; }
        }
        public int Nooflanguages
        {
            get { return nooflanguages; }
            set { nooflanguages = value; }

        }
        public string Capital
        {
            get { return capital; }
            set { capital = value; }

        }
        static void Main(string[] args)
        {
            Country c = new Country();
            c.countryname = "india";
            Console.WriteLine(c.countryname);
            c.noofstates = 28;
            Console.WriteLine(c.noofstates);
            c.Nooflanguages = 100;
            Console.WriteLine(c.nooflanguages);
            c.capital = "Delhi";
            Console.WriteLine(c.capital);



        }

    }
    class Count
    {
        static void Main(string[] args)
        {
            static void Main(string[] args)
            {
                Country c = new Country();
                c.Countryname = "india";
                Console.WriteLine(c.Countryname);
                c.Noofstates = 28;
                Console.WriteLine(c.Noofstates);
                c.Nooflanguages = 100;
                Console.WriteLine(c.Nooflanguages);
                c.Capital = "Delhi";
                Console.WriteLine(c.Capital);



            }
        }
    }
 }
