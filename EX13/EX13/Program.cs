using System;
using System.Globalization;
using EX13.Entities.Enums;
using EX13.Entities;

namespace EX13
{
    class Program
    {
        static void Main(string[] args)
        {
            string Name;
            string Email;
            DateTime BirthDate;
            string StatusStr;
            OrderStatus Status;
            int Quantity;
            string ProductName;
            double ProductPrice;
            int ProductQtt;

            Console.WriteLine("Enter cliente data:");
            Console.Write("Name: ");
            Name = Console.ReadLine();
            Console.Write("Email: ");
            Email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            BirthDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter order data:");
            Console.Write("Status: ");
            Status = Enum.Parse<OrderStatus>(Console.ReadLine());
            Console.Write("How many items to this order?");
            Quantity = Convert.ToInt32(Console.ReadLine());

            Client ClientObj = new Client(Name, Email, BirthDate);
            Order PedidoObj = new Order(DateTime.Now, Status, ClientObj);
            Product ProductObj;
            OrderItem OrderItemObj;

            for (int i = 1; i <= Quantity; i++)
            {
                Console.WriteLine($"Enter #{i} item data:");
                Console.Write("Product name: ");
                ProductName = Console.ReadLine();
                Console.Write("Product price: ");
                ProductPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Quantity: ");
                ProductQtt = Convert.ToInt32(Console.ReadLine(), CultureInfo.InvariantCulture);

                ProductObj = new Product(ProductName, ProductPrice);
                OrderItemObj = new OrderItem(ProductQtt, ProductPrice, ProductObj);
                PedidoObj.AddItem(OrderItemObj);
            }

            Console.WriteLine(PedidoObj);

        }
    }
}