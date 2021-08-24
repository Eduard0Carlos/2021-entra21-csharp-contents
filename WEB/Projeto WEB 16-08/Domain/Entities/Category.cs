using System.Collections.Generic;

namespace Domain.Entities
{
    public class Category
    {
        public int ID { get; set; }
        public string Description { get; set; }
        public ICollection<Product> Products {  get; set; }
    }
}
