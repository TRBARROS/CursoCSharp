using System;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using EX13.Entities.Enums;

namespace EX13.Entities
{
    class Order
    {
        public DateTime Date { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();

        public Order() 
        {
        }

        public Order(DateTime date, OrderStatus status, Client client)
        {
            Date = date;
            Status = status;
            Client = client;
        }

        public void AddItem(OrderItem item)
        {
            Items.Add(item);
        }

        public void RemoveItem(OrderItem item)
        {
            Items.Remove(item);
        }

        public double Total()
        {
            double TotalValue = 0;

            foreach (OrderItem i in Items)
            {
                TotalValue += i.SubTotal();
            }

            return TotalValue;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("ORDER SUMARY: ");
            sb.AppendLine("Order moment: ");
            sb.Append(Date);
            sb.AppendLine("Order status: ");
            sb.Append(Status);
            sb.AppendLine("Client: ");
            sb.Append(Client.Name);
            sb.Append($" ({Client.BirthDate}) ");
            sb.Append($"- {Client.Email}");
            sb.AppendLine("Order items");

            foreach (OrderItem i in Items)
            {
                sb.AppendLine($"{i.Product.Name}, {i.Product.Price}, Quantity: {i.Quantity}, Subtotal: ${i.SubTotal()}");
            }

            sb.AppendLine($"Total price: ${Total()}");
            return sb.ToString();
        }
    }
}
