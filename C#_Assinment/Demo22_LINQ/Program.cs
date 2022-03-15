﻿using System;
using System.Linq;
using System.Collections.Generic;

namespace Demo22_LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>()
            {
                new Product { ProductID  = 3, ProductName = "Wheat", Price = 31.75M, Quantity = 50 },
                new Product { ProductID  = 2, ProductName = "Sugar", Price = 39.00M, Quantity = 20 },
                new Product { ProductID  = 1, ProductName = "Salt", Price = 12.50M, Quantity = 3 },
                new Product { ProductID  = 5, ProductName = "Rice", Price = 39.25M, Quantity = 40 },
                new Product { ProductID  = 4, ProductName = "Daal", Price = 64.00M, Quantity = 80 }
            };

            Console.WriteLine("{0:000}   {1,-15} {2,10} {3,10} {4,12}",
                    "ID", "Name", "Price", "Quantity", "Cost");
            foreach (Product p in products)
            {
                Console.WriteLine("{0:000}   {1, -15} {2,10} {3,10} {4,12}",
                    p.ProductID, p.ProductName, p.Price, p.Quantity, p.Price * p.Quantity);
            }
            Console.WriteLine();


            products.Sort();

            Console.WriteLine("after sorting (using the IComparable interface implementation");

            Console.WriteLine("{0:000}   {1,-15} {2,10} {3,10} {4,12}",
                    "ID", "Name", "Price", "Quantity", "Cost");
            foreach (Product p in products)
            {
                Console.WriteLine("{0:000}   {1, -15} {2,10} {3,10} {4,12}",
                    p.ProductID, p.ProductName, p.Price, p.Quantity, p.Price * p.Quantity);
            }
            Console.WriteLine();



            var query1 = from prod in products
                         orderby prod.ProductName descending
                         select prod;
            Console.WriteLine("{0:000}   {1,-15} {2,10} {3,10} {4,12}",
                    "ID", "Name", "Price", "Quantity", "Cost");
            foreach (Product p in query1)
            {
                Console.WriteLine("{0:000}   {1, -15} {2,10} {3,10} {4,12}",
                    p.ProductID, p.ProductName, p.Price, p.Quantity, p.Price * p.Quantity);
            }
            Console.WriteLine();

            var query2 = from prod in products
                         orderby prod.ProductName descending
                         where prod.ProductID >= 3
                         select new
                         {
                             ID = prod.ProductID,
                             Name = prod.ProductName,
                             Qty = prod.Quantity,
                             prod.Price,
                             Cost = prod.Quantity * prod.Price
                         };
            Console.WriteLine("{0:000}   {1,-15} {2,10} {3,10} {4,12}",
                    "ID", "Name", "Price", "Quantity", "Cost");
            foreach (var p in query2)
            {
                Console.WriteLine("{0:000}   {1, -15} {2,10} {3,10} {4,12}",
                    p.ID, p.Name, p.Price, p.Qty, p.Cost);
            }
            Console.WriteLine();

            var query3 = products
                         .Where(p => p.ProductID >= 3)
                         .OrderByDescending(p => p.ProductName)
                         .Skip(1)
                         .Take(2);

            var isFound = products.Any(p => p.ProductID == 3);
            if (isFound)
            {
                Console.WriteLine("Product with ID == 3 was found");
            }

            var prod4 = products.SingleOrDefault(p => p.ProductID == 4);
            if (prod4 != null)
            {
                Console.WriteLine("Product with ID 4 was found!");
                Console.WriteLine("{0} {1}", prod4.ProductID, prod4.ProductName);
            }
        }
    }
}
