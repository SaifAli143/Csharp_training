using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.SandQ_TRAINIG
{
    public delegate void Mydel();

    public  class BANK1
    {
        public int balance;
        public event Mydel BALANCE_ZERO;
        public event Mydel BALANCE_INCEFICEINT;

         
        public BANK1(int balance)
        {
            balance = 0;
        }
      

        public void Credit(int n)
        {
            
            balance = balance + n;


        }
        public void BALANCE(int balance)
        {
            if (balance==0)
            {
                BALANCE_ZERO();
            }
            else if (balance<5000)
            {
                BALANCE_INCEFICEINT();
            }
            Console.WriteLine($"your Balance is {balance}");

            
        }
        class Banktest
        {
            static void BALANCE_ZEROMSG()
            {
                Console.WriteLine("Your Balnce IS Zero !");

            }
            static void BALANCE_INCEFICENTMsg()
            {
                Console.WriteLine(" Your Balance IS Inceficeint !");

            }
            static void Main(string[] args)
            {
                BANK1 B1 = new BANk1();
                B1.BALANCE_ZERO += new Mydel(BALANCE_ZEROMSG);
                B1.BALANCE_INCEFICEINT += new Mydel(BALANCE_INCEFICENTMsg);
                B1.BALANCE(4500);

            }
        }
    }
}
