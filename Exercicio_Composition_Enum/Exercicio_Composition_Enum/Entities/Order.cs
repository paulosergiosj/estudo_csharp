using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercicio_Composition_Enum.Entities.Enums;

namespace Exercicio_Composition_Enum.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus OrderStatus { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> OrderItems { get; set; } = new List<OrderItem>();

        public Order() { }

        public Order(DateTime moment, OrderStatus orderStatus, Client client)
        {
            Moment = moment;
            OrderStatus = orderStatus;
            Client = client;
        }

        public void AddOrderItem(OrderItem orderItem)
        {
            OrderItems.Add(orderItem);
        }

        public void RemoveOrderItem(OrderItem orderItem)
        {
            OrderItems.Remove(orderItem);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            double Total = 0;
            sb.Append("Order Moment: ");
            sb.AppendLine(Moment.ToString("dd/MM/yyyy"));
            sb.Append("Order Status: ");
            sb.AppendLine(OrderStatus.ToString());
            sb.Append("Client: ");
            sb.AppendLine(Client.ToString());

            sb.AppendLine("Order Items: ");

            foreach(OrderItem oi in OrderItems)
            {
                sb.AppendLine(oi.ToString());
                Total += oi.Total(oi.Product.Price,oi.Product.Quantity);
            }
            sb.Append("Total: ");
            sb.Append(Total.ToString("F2",CultureInfo.InvariantCulture));

            return sb.ToString();
        }
    }
}
