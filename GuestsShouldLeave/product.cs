using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuestsShouldLeave
{
    class Product
    {
        public int Price { get; set; }
        public string Name { get; set; }
        public int ExpireDate { get; set; }

        public Product(int ExpireDate_, string Name_, int price_) 
        {
            Price = price_;
            Name = Name_;
            ExpireDate = ExpireDate_;

        }
        public void Print()
        {
            Console.WriteLine("Name: "+ Name);
            Console.WriteLine("Expiretion date: " + ExpireDate);
            Console.WriteLine("Price: " + Price);
        }
    }
}
