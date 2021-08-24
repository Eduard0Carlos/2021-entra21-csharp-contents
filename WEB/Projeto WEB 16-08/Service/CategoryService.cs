using DataAccessObject;
using Domain.Entities;
using Domain.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Service
{
    public class CategoryService : IEntityService<Category>
    {
        public void Delete(int id)
        {
            using (var db = new ErpDbContext())
            {
                db.Categories.Remove(new Category { ID = id });
                db.SaveChanges();
            }
        }

        public void Insert(Category entity)
        {
            using (var db = new ErpDbContext())
            {
                db.Categories.Add(entity);
                db.SaveChanges();
            }
        }

        public ICollection<Category> SelectAll(Category entity)
        {
            using (var db = new ErpDbContext())
            {
                var categoryCollection = db.Categories.ToList();
                return categoryCollection;
            }
        }

        public Category SelectByID(Category entity)
        {
            using (var db = new ErpDbContext())
            {
                var category = db.Categories.Find(entity.ID);
                return category;
            }
        }

        public ICollection<Category> SelectByPageNumber(int pageSize, int pageIndex)
        {
            using (var db = new ErpDbContext())
            {
                var categoryCollection = db.Categories.Skip(pageSize * pageIndex).Take(pageSize).ToList();
                return categoryCollection;
            }
        }

        public void Update(Category entity)
        {
            using (var db = new ErpDbContext())
            {
                var c = db.Categories.Find(entity.ID);
                c.Description = entity.Description;
                
                db.SaveChanges();
            }
                
        }
    }
}
