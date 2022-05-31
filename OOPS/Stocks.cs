using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.OOPS
{
    class Stocks
    {
        float  openingprice;
        string stocksname;
        float closingprice;
        public Stocks()
        {
            Console.WriteLine(" Enter Stocks Name ");
            stocksname = "upstocks";
            openingprice = 150.0f;
        }
        public void Setopeningprice(float stockopeningprice)
        {
            this.openingprice = stockopeningprice;
        }
        public float Getopeningprice()
        {
            return openingprice;
        }
        public void Setstocksname(string name)
        {
            stocksname = name;
        }
        public string Getstockname()
        {
            return stocksname;
        }
        public void Setclosingprice(float price)
        {
            closingprice = price;
        }
        public float Getclosingprice()
        {
            return closingprice;
        }
        static void Main(string[] args)
        {
            Stocks s = new Stocks();
            Console.WriteLine("Enter openingprice, Enter stocksname, Enter closingprice");
            float stockopeningprice = Convert.ToSingle(Console.ReadLine());
            s.Setopeningprice(stockopeningprice);
            string name = Console.ReadLine();
            s.Setstocksname(name);
            float price = Convert.ToSingle(Console.ReadLine());
            s.Setclosingprice(price);

            Console.WriteLine(s.Getopeningprice());
            Console.WriteLine(s.Getstockname());
            Console.WriteLine(s.Getclosingprice());

        }
    }
}

