using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineGift.Models
{
    public class OrderItem
    {
        public int Id { get; set; }

        public int Amount { get; set; }
        public double Price { get; set; }

        public int ProductId { get; set; }
        [ForeignKey("ProductId")]
        public Product Product { get; set; }

        [ForeignKey("OrderId")]
        public int OrderId { get; set; }
    }
}
