using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.OOPS
{
    class Movie
    {
        string moviename;
        string directorname;
        string producername;
        string actorname;
        int rating;
        string movierating;
        public Movie()//it is a constructor
        {
            Console.WriteLine(" in movie constructer is called");
        }
        public void SetMoviename(string kgf)
        {
            moviename = kgf;
        }
        public string Getmoviename()
        {
            return moviename;
        }
        public void Setdirectorname(string dname)
        {
            directorname = dname;

        }
        public string Getdirectorname()
        {
            return directorname;

        }
        public void Setproducername(string pname)
        {
            producername = pname;

        }
        public string Getproducername()
        {
            return producername;
        }

        public void Setactorname(string aname)
        {
            actorname = aname;


        }
        public string Getactorname()
        {
            return actorname;

        }
        public void Setrating(int rate)
        {
            rating = rate;
        }
        public int Getrating()
        {
            return rating;
        }
        public void Setmovierating(string mrating)
        {
            if (rating >= 5)
                mrating = "blockbuster";
            else if (rating >= 4)
                mrating = "hit";
            else if (rating >= 3)
                mrating = "average";
            else
                mrating = "flop";
            
        }
        public string Getmovierating()
        {
            return movierating;
        }
        static void Main(string[] args)
        {
            Movie m = new Movie();
            m.SetMoviename(" KGF ");
            m.Setdirectorname(" remo d'souza ");
            m.Setproducername(" karan johar");
            m.Setactorname(" Amir khan");
            m.Setrating(3);
            m.Setmovierating("5");

            Console.WriteLine(m.Getmoviename());
            Console.WriteLine(m.Getdirectorname());
            Console.WriteLine(m.Getproducername());
            Console.WriteLine(m.Getactorname());
            Console.WriteLine(m.Getrating());
            Console.WriteLine(m.Getmovierating());

        }
    }
}
