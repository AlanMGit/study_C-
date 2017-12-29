using Data.Contexts;
using Domain;
using Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public class UserRepository : IUserRepository
    {

        private CatalogContext context;

        public UserRepository(CatalogContext context)
        {
            this.context = context;
        }

        public void Delete(int id)
        {
            User user = context.Users.Find(id);
            context.Users.Remove(user);
            context.SaveChanges();
        }

        public void Dispose()
        {
            context.Dispose();
        }

        public User Get(string username)
        {
            return context.Users
                .Where(x => x.Username.ToLower() == username.ToLower())
                .FirstOrDefault();
        }

        public User Get(string username, string password)
        {
            throw new NotImplementedException();
        }

        public IList<User> Get()
        {
            return context.Users.ToList();
        }

        public User Get(int id)
        {
            return context.Users.Find(id);
        }

        public void Save(User entity)
        {
            context.Users.Add(entity);
            context.SaveChanges();
        }

        public void Update(int id, User entity)
        {
            entity.Id = id;
            context.Entry<User>(entity).State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}
