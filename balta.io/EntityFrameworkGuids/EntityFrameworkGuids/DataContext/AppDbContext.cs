using EntityFrameworkGuids.Mapping;
using EntityFrameworkGuids.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkGuids.DataContext
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() : base("AppConnectionString")
        {
            Database.SetInitializer<AppDbContext>(new AppDbContextInitializer());
        }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new UserMap());
            base.OnModelCreating(modelBuilder);
        }
    }

    public class AppDbContextInitializer : DropCreateDatabaseAlways<AppDbContext>
    {

    }
}
