using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.OOPS.PROPERTIES
{
    class Employees
    {
        int empid;
        string empname;
        double salary;

        public Employees()
        {
            Console.WriteLine(" defualt constructor");
        }
        public Employees(int empid, string empname, double salary)
        {
            this.Empid = empid;
            this.Empname = empname;
            this.Salary = salary;
        }

        public int Empid { get => empid; set => empid = value; }
        public string Empname { get => empname; set => empname = value; }
        public double Salary { get => salary; set => salary = value; }
    }
    class Emp
    {
        static void Main(string[] args)
        {
           /* Employees e = new Employees[5]
            {
                new Employees(1,"saif",45000),
                new Employees(2,"saifali",15000),
                new Employees(3,"saifshaikh",25000),
                new Employees(4,"saifa",35000),
                new Employees(5,"shaikhsaif",41000),
            };

            for (int i = 0; i < e; i++)
            {

            }*/
        }

    }
}
