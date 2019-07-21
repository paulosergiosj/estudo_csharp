using Exercicio_Composition_Enum.Entities;
using Exercicio_Composition_Enum.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Composition_Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Client Data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.WriteLine("Birth Date (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());
            Client client = new Client(name,email,birthDate);
            Console.WriteLine();

            Console.WriteLine("Enter Order Data:");
            Console.WriteLine("Status(PendingPayment,Processing,Shipped,Delivered): ");
            OrderStatus status = (OrderStatus)Enum.Parse(typeof(OrderStatus), Console.ReadLine());
            Console.WriteLine();

            Console.Write("How Many Items to this order? ");
            int QtdItem = int.Parse(Console.ReadLine());

            Order order = new Order(DateTime.Now, status, client);
            for (int i = 1; i <= QtdItem; i++)
            {
                Console.WriteLine($"Enter #{i} Item Data: ");
                Console.Write("Product Name: ");
                string pname = Console.ReadLine();
                Console.Write("Product Price: ");
                double price = double.Parse(Console.ReadLine());
                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());
                Product product = new Product(pname, price, quantity);
                OrderItem orderItem = new OrderItem(quantity,price, product);
                order.AddOrderItem(orderItem);
            }
            Console.WriteLine();
            Console.WriteLine("Order Summary: ");
            Console.WriteLine(order.ToString());

        }
    }
}
