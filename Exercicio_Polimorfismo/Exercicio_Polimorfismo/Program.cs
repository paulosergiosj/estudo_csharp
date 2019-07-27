using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Exercicio_Polimorfismo.Entities;

namespace Exercicio_Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            Console.WriteLine("Enter the number of products");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Product #{i} data: ");
                Console.Write("Common,used or imported (c/u/i)?");
                char type = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine());
                if (type == 'i')
                {
                    Console.Write("Custom fee: ");
                    double customFee = double.Parse(Console.ReadLine());
                    list.Add(new ImportedProduct(name, price, customFee));
                }
                else if(type == 'u')
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime manufactureDate = DateTime.Parse(Console.ReadLine());
                    list.Add(new UsedProduct(name, price, manufactureDate));
                }
                else
                {
                    list.Add(new Product(name, price));
                }
            }
            Console.WriteLine("");
            Console.WriteLine("PRICE TAGS:");
            foreach (Product product in list)
            {
                Console.WriteLine(product.PriceTag()); 
                
            }
        }
    }
}