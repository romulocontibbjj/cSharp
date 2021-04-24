using System;
using System.Collections.Generic;
using System.Text;
using Pedidos.Entities.Enums;

namespace Pedidos.Entities
{
    class Order
    {
        public int Id { get; set; }
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }


    }
}
