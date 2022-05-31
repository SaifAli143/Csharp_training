using System;

namespace ConsoleApp2.OOPS
{
    class Pen
    {
        string penbrand;
        String pencolour;
        int penprice;
        public Pen()
        {
            Console.WriteLine(" Enter Pen Nameb ");
        }
        public void Setpenbrand(string penbrand)
        {
          this.penbrand = penbrand;
        }
        public string Getpenbrand()
        {
            return penbrand;
        }
        public void Setpencolour(string colour)
        {
            pencolour = colour;
        }
        public string Getpencolour()
        {
            return pencolour;
        }
        public void Setpenprice(int price)
        {
            penprice = price;
        }
        public int Getpenprice()
        {
            return penprice;
        }
        static void Main(string[] args)
        {
            Pen p = new Pen();
            Console.WriteLine("Enter Penbrand, Enter Pencolour, Enter Penprice");
            string brand = Console.ReadLine();
            p.Setpenbrand(brand);
            string colour = Console.ReadLine();
            p.Setpencolour(colour);
            int price = Convert.ToInt32(Console.ReadLine());
            p.Setpenprice(price);

            Console.WriteLine(p.Getpenbrand());
            Console.WriteLine(p.Getpencolour());           
            Console.WriteLine(p.Getpenprice());

        }
    }
}
