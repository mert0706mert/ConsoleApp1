using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 12;
            product1.ProductName = "Marul";
            product1.UnitPrice = 0.29;
            product1.UnitsInStock = 230;
            Product product2 = new Product
            {
                Id = 2,
                CategoryId = 12,
                ProductName = "Salatalık",
                UnitPrice = 0.15,
                UnitsInStock = 270
            };
            Product product3 = new Product
            {
                Id = 3,
                CategoryId = 12,
                ProductName = "Patlıcan",
                UnitPrice = 0.07,
                UnitsInStock = 250
            };
            Product product4 = new Product
            {
                Id = 4,
                CategoryId = 12,
                ProductName = "Kabak",
                UnitPrice = 0.32,
                UnitsInStock = 240
            };
            Product product5 = new Product
            {
                Id = 5,
                CategoryId = 12,
                ProductName = "Karnıbahar",
                UnitPrice = 0.20,
                UnitsInStock = 260
            };

            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            Console.WriteLine(product1.ProductName);
        }
    }
}
