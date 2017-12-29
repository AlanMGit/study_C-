using Relationship_EntityFramework.Mapping;
using Relationship_EntityFramework.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relationship_EntityFramework.DataContexts
{
    public class AppDataContext : DbContext
    {

        public AppDataContext() :base("MyConnectionString")
        {
            Database.SetInitializer<AppDataContext>(new AppDataContextInitializer());
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Configurations.Add(new AuthorMap());
            modelBuilder.Configurations.Add(new BookMap());
            modelBuilder.Configurations.Add(new CategoryMap());

            base.OnModelCreating(modelBuilder);
        }

    }

    public class AppDataContextInitializer : DropCreateDatabaseAlways<AppDataContext>
    {

    }
}
