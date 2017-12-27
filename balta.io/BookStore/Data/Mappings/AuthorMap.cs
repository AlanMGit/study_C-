using Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Mappings
{
    public class AuthorMap : EntityTypeConfiguration<Author>
    {
        public AuthorMap()
        {
            ToTable("Author");

            HasKey(x => x.Id);
            Property(x => x.FirstName).HasMaxLength(60).IsRequired();
            Property(x => x.LastName).HasMaxLength(60).IsRequired();

        }

    }
}
