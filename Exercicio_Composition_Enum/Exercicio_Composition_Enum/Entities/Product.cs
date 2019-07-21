using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Composition_Enum.Entities
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public int Quantity { get; set; }

        public Product() {}

        public Product(string name, double price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public override string ToString()
        {
            return Name +", "+ Price.ToString(CultureInfo.InvariantCulture)+",Quantity: "+Quantity.ToString();
        }
    }
}
