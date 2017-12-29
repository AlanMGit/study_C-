using Relationship_EntityFramework.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relationship_EntityFramework.Mapping
{
    public class AuthorMap : EntityTypeConfiguration<Author>
    {

        public AuthorMap()
        {

            ToTable("Authors");

            HasKey(x => x.Id);
            Property(x => x.Name).HasMaxLength(80).IsRequired();

            HasMany(x => x.Books)
                .WithMany(x => x.Authors)
                .Map(x => x.ToTable("BooksAuthors"));
        }

    }
}
