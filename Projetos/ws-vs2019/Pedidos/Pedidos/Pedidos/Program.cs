using System;
using Pedidos.Entities;
using Pedidos.Entities.Enums;
using System.Globalization;


namespace Pedidos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter client data");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("E-mail: ");
            string email = Console.ReadLine();
            Console.Write("Birth Date: ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());

            //Carrega Instância do Cliente
            Client cliente = new Client(name, email, birthDate);

            Console.WriteLine("");

            //Dados do Pedido
            Console.WriteLine("Enter order data: ");
            Console.Write("Status: ");
            OrderStatus os = Enum.Parse<OrderStatus>(Console.ReadLine());

            Order order = new Order(os, cliente);

            Console.Write("How many items to this order? ");
            int n = int.Parse(Console.ReadLine());

            //Entrando com os Itens
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Enter #{(i+1)} item data:");
                Console.Write("Product Name: ");
                string productName = Console.ReadLine();
                Console.Write("Product Price: R$ ");
                double price = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Product Pr = new Product(productName, price);
                Console.Write("Quantity: R$ ");
                int quantity = int.Parse(Console.ReadLine());

                OrderItem oi = new OrderItem(quantity, price, Pr);
                order.AddItem(oi);
                Console.WriteLine("");
            }

            Console.WriteLine("");
            Console.WriteLine("--------------------------------");
            Console.WriteLine(order.ToString());



        }
    }
}
