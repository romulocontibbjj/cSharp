using System;
using System.Collections.Generic;
using System.Text;
using Pedidos.Entities.Enums;
using System.Globalization;

namespace Pedidos.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }

        public List<OrderItem> ListaItens { get; set; } = new List<OrderItem>();

        public Client Client { get; set; }
        
        public Order()
        {

        }

        public Order(OrderStatus status, Client client)
        {
            Moment = DateTime.Now;
            Status = status;
            Client = client;
        }

        public void AddItem(OrderItem oi)
        {
            ListaItens.Add(oi);
        }

        public void RemoveItem(OrderItem oi)
        {
            ListaItens.Remove(oi);
        }

        public double Total()
        {
            Double valorTotal = 0.0;
            foreach(OrderItem oi in ListaItens)
            {
                valorTotal += oi.SubTotal();
            }
            return valorTotal;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("ORDER SUMMARY:" );
            sb.AppendLine("Order Moment:" + this.Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine("Order Status: " + this.Status.ToString() );
            sb.AppendLine("Client: " + this.Client.ToString());
            sb.AppendLine("Orders Items");

            foreach(OrderItem oi in ListaItens)
            {
                sb.AppendLine(oi.ToString());
            }

            sb.AppendLine("Total Price $ " + Total().ToString("F2", CultureInfo.InvariantCulture));

            return sb.ToString();

        }


    }
}
