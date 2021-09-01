using System;
using System.Collections;
using System.Collections.Generic;

namespace GuestsShouldLeave
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<Product> products = new Queue<Product>();

            /*products.Enqueue(new Product() { ExpireDate = 020921, Name = "Milk", Price = 10 });
            products.Enqueue(new Product() { ExpireDate = 090921, Name = "Meat oks", Price = 30 });
            products.Enqueue(new Product() { ExpireDate = 090921, Name = "Meat pork", Price = 28 });
            products.Enqueue(new Product() { ExpireDate = 120921, Name = "Bananas", Price = 12});
            products.Enqueue(new Product() { ExpireDate = 200921, Name = "Apples", Price = 24 });
            products.Enqueue(new Product() { ExpireDate = 150921, Name = "peanuts", Price = 8});*/

            products.Enqueue(new Product(020921, "Milk", 10));
            products.Enqueue(new Product(090921, "Meat oks", 30));
            products.Enqueue(new Product(90921, "Meat Pork", 28));
            products.Enqueue(new Product(20921, "bananas", 12));
            products.Enqueue(new Product(200921,"Apples" , 24));
            products.Enqueue(new Product(150921, "Peanuts", 8));

            Console.WriteLine("\nAmount of products in storage {0}", products.Count);

            foreach (Product product in products)
            {
                product.Print();
            }

            products.Dequeue();

            Console.WriteLine("\nAmount of products in storage {0}", products.Count);

            foreach (Product product in products)
            {
                product.Print();
            }

            //sry for temp variables
            int priceMax = 0;
            int priceMin = 100;

            //a loop to find price max and min price
            foreach (Product product in products)
            {
                if (product.Price > priceMax)
                {
                    priceMax = product.Price;
                }
                if (product.Price < priceMin)
                {
                    priceMin = product.Price;
                }
            }

            //prints max and min price
            Console.WriteLine($"\nThe most expensive product is: {priceMax}");
            Console.WriteLine($"\nThe cheapest product is: {priceMin}");
            
            //find and item in my queue
            Product soldFirst = products.Dequeue();
            Console.WriteLine($"\nSold first: {soldFirst.Name} ");


            Console.WriteLine("");

            Console.ReadKey();
        }
    }
}
