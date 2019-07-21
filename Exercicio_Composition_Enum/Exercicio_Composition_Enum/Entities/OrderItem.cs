using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Composition_Enum.Entities
{
    class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }

        public OrderItem()
        {
            
        }

        public OrderItem(int quantity, double price,Product product)
        {
            Quantity = quantity;
            Price = price;
            Product = product;
        }

        public double Total(double value,int quantity)
        {
            return value * quantity;
        }

        public override string ToString()
        {
            StringBuilder sb1 = new StringBuilder();
            sb1.Append(Product.ToString());
            sb1.Append(", Subtotal: ");
            sb1.Append("$"+Total(Price, Quantity).ToString(CultureInfo.InvariantCulture));
            
            return sb1.ToString();
        }
    }
}
