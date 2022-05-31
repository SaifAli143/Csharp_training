using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.OOPS.PROPERTIES
{
    class Order
    {
        int ordered;
        string orderdate;
        Customer cust;
        Item item;

        public Order()
        {
            
        }
        public Order(int ordered, string orderdate, Customer cust, Item item)
        {
            this.Ordered = ordered;
            this.Orderdate = orderdate;
            this.Cust = cust;
            this.Item = item;
        }

        public int Ordered { get => ordered; set => ordered = value; }
        public string Orderdate { get => orderdate; set => orderdate = value; }
        public Customer Cust { get => cust; set => cust = value; }
        public Item Item { get => item; set => item = value; }
    }
    class Customer
    {
        int custid;
        string custname;
        Address address;

        public Customer()
        {

        }
        public Customer(int custid, string custname, Address address)
        {
            this.Custid = custid;
            this.Custname = custname;
            this.Address = address;
        }

        public int Custid { get => custid; set => custid = value; }
        public string Custname { get => custname; set => custname = value; }
        internal Address Address { get => address; set => address = value; }
    }
    class Address1
    {
        string addr1;
        string city;
        int pincode;

        public Address1()
        {

        }
        public Address1(string addr1, string city, int pincode)
        {
            this.Addr1 = addr1;
            this.City = city;
            this.Pincode = pincode;
        }

        public string Addr1 { get => addr1; set => addr1 = value; }
        public string City { get => city; set => city = value; }
        public int Pincode { get => pincode; set => pincode = value; }
    }
    class Item
    {
        int itemid;
        string itemname;
        int itemprice;

        public Item()
        { 

        }

        public Item(int itemid, string itemname, int itemprice)
        {
            this.Itemid = itemid;
            this.Itemname = itemname;
            this.Itemprice = itemprice;
        }

        public int Itemid { get => itemid; set => itemid = value; }
        public string Itemname { get => itemname; set => itemname = value; }
        public int Itemprice { get => itemprice; set => itemprice = value; }
    }
    class Ordertest
    {
        static void Main(string[] args)
        {
            Order or = new Order();
            or.Ordered = 1;
            or.Orderdate = "1 april";
            
            or.Cust.Custid = 123;
            or.Cust.Custname = " hasnain";
            or.Item.Itemname = "iphone";
            or.Item.Itemprice = 89000;

            Console.WriteLine("order customer name is="+or.Cust.Custname);
            Console.WriteLine("order number is="+or.Ordered);
            Console.WriteLine("order date is="+or.Orderdate);
        }
    }
        
}
