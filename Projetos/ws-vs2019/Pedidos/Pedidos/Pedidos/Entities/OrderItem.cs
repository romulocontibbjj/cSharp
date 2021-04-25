using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Pedidos.Entities
{
    class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }

        public Product Pr { get; set; }

        public OrderItem()
        {

        }

        public OrderItem(int quantity, double price, Product pr )
        {
            Quantity = quantity;
            Price = price;
            Pr = pr;
        }

        public double SubTotal()
        {
            return (Quantity * Price);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Pr.Name + ", ");
            sb.Append("R$ " + Pr.Price.ToString("F2", CultureInfo.InvariantCulture) + ", ");
            sb.Append("Quantity: " + Quantity + ", ");
            sb.Append("SubTotal: $ " + SubTotal().ToString("F2", CultureInfo.InvariantCulture));

            return sb.ToString();
        }
    }
}
