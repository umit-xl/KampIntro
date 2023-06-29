using System;

namespace OOP1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            Product product2 = new Product();

            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;

            product2.Id = 5;
            product2.CategoryId = 6;
            product2.ProductName = "Sandalye";
            product2.UnitPrice = 300;
            product2.UnitsInStock = 10;


            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            Console.WriteLine(product1.ProductName);
            productManager.Add(product2);
            Console.WriteLine(product2.ProductName);

            Product[] products = new Product[] { product1, product2 };
            
            productManager.List(products);
            

            //int double bool... = değer tip
            //array class abstract class interface = referans tip

        }
    }
}