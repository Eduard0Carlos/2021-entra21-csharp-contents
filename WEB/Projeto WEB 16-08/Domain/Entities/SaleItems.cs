using System;
namespace Domain.Entities
{
    public class SaleItems
    {
        public int SaleID { get; set; }
        public Sale Sale { get; set; }
        public int ProductID { get; set; }
        public Product Product { get; set; }
        public double Amount { get; set; }
        public double Value { get; set; }
    }
}
