using System.Collections.Generic;

namespace Domain.Entities
{
    public class Gender : EntityBase
    {
        public string Name { get; protected set; }
        public ICollection<Film> Films { get; protected set; }

        public Gender() { }

        public Gender(string name)
        {
            this.Name = name;   
        }
    }
}
