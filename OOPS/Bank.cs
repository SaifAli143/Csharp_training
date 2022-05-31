using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.OOPS
{
    public class Bank
    {
        int bankid;
        string bankname;
        Account accountin = new Account();
        Branch branchin = new Branch();

        public Bank()
        {

        }
        internal Bank(int bankid, string bankname, Account accountin, Branch branchin)
        {
            this.Bankid = bankid;
            this.Bankname = bankname;
            this.Accountin = accountin;
            this.Branchin = branchin;
        }

        internal Branch Branchin { get => branchin; set => branchin = value; }
        internal Account Accountin { get => accountin; set => accountin = value; }
        public string Bankname { get => bankname; set => bankname = value; }
        public int Bankid { get => bankid; set => bankid = value; }
    }
    class Account
    {
        int accountid;
        string accounttype;

        public Account()
        {

        }
        public Account(int accountid, string accounttype)
        {
            this.Accountid = accountid;
            this.Accounttype = accounttype;
        }

        public string Accounttype { get => accounttype; set => accounttype = value; }
        public int Accountid { get => accountid; set => accountid = value; }
    }

    class Branch
    {
        string branchname;
        int branchid;

        public Branch()
        {

        }
        public Branch(string branchname, int branchid)
        {
            this.Branchname = branchname;
            this.Branchid = branchid;
        }

        public string Branchname { get => branchname; set => branchname = value; }
        public int Branchid { get => branchid; set => branchid = value; }
    }




    class Banktest
    {
        static void Main(string[] args)
        {
            Bank b1 = new Bank();
            b1.Bankname = "HDFC";
            b1.Bankid = 1234;

            Console.WriteLine(" Bank id is=" + b1.Bankid);
            Console.WriteLine(" Bank Name is =" + b1.Bankname);

        }
    }
}