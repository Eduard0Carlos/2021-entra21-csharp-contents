using System.Collections.Generic;

namespace Domain.Interfaces
{
    public interface IEntityService<Entity>
    {
        public void Insert(Entity entity);
        public void Delete(int id);
        public void Update(Entity entity);
        public ICollection<Entity> SelectAll(Entity entity);
        public Entity SelectByID(Entity entity);
        public ICollection<Entity> SelectByPageNumber(int pageSize, int pageIndex);
    }
}
