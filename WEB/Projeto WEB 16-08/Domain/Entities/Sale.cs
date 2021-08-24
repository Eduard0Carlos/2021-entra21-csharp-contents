using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public class Sale
    {
        public int ID { get; set; }
        public DateTime SaleDate { get; set; }
        public double Total { get; set; }
        public ICollection<SaleItems> Items { get; set; }
    }
}
