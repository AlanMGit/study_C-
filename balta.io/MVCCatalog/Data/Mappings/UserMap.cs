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
            Property(x => x.Name).isRequired();
            Property(x => x.Email).isRequired();
            Property(x => x.Username).isRequired();
            Property(x => x.Password).isRequired();
        }
    }
}
