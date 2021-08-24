using DataAccessObject;
using Domain.Entities;
using Domain.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace BusinessLogical
{
    public class ClientService : IEntityService<Client>
    {
        public void Delete(int id)
        {
            using (var db = new ErpDbContext())
            {
                db.Clients.Remove(new Client { ID = id });
                db.SaveChanges();
            }
        }

        public void Insert(Client entity)
        {
            using (var db = new ErpDbContext())
            {
                db.Clients.Add(entity);
                db.SaveChanges();
            }
        }

        public ICollection<Client> SelectAll(Client entity)
        {
            using (var db = new ErpDbContext())
            {
                ICollection<Client> clientCollection = db.Clients.ToList();
                return clientCollection;
            }
        }

        public Client SelectByID(Client entity)
        {
            using (var db = new ErpDbContext())
            {
                var client = db.Clients.Find(entity.ID);
                return client;
            }
        }

        public ICollection<Client> SelectByPageNumber(int pageSize, int pageIndex)
        {
            using (var db = new ErpDbContext())
            {
                ICollection<Client> clientCollection = db.Clients.Skip(pageSize * pageIndex).Take(pageSize).ToList();
                return clientCollection;
            }
        }

        public void Update(Client entity)
        {
            using (var db = new ErpDbContext())
            {
                var c = db.Clients.Find(entity.ID);
                c.Name = entity.Name;
                c.Email = entity.Email;
                c.PhoneNumber = entity.PhoneNumber;

                db.SaveChanges();
            }
        }
    }
}
