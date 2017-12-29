using Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Mappings
{
    public class UserMap : EntityTypeConfiguration<User>
    {
        public UserMap()
        {
            ToTable("User");
            HasKey(x => x.Id);
            Property(x => x.Name).IsRequired();
            Property(x => x.Email).IsRequired();
            Property(x => x.Username).IsRequired();
            Property(x => x.Password).IsRequired();
        }
    }
}
