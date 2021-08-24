using Entities.Enums;

namespace Domain.Entities
{
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public UnitMeasure UnitMeasure { get; set; }
        public double Amount { get; set; }
        public double Total { get; set; }
        public int CategoryID { get; set; }
        public Category Category { get; set; }
    }
}
