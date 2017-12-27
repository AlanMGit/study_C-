using Data.Mappings;
using Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DataContexts
{
    public class BookStoreContext : DbContext
    {

        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }

        public BookStoreContext() : base("BookStoreConnectionString")
        {
            Configuration.LazyLoadingEnabled   = false;
            Configuration.ProxyCreationEnabled = false;
        }
        
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new BookMap());
            // modelBuilder.Configurations.Add(new AuthorMap());

            base.OnModelCreating(modelBuilder);
        }
    }
}
