using Relationship_EntityFramework.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relationship_EntityFramework.Mapping
{
    class CategoryMap : EntityTypeConfiguration<Category>
    {

        public CategoryMap()
        {

            ToTable("Categories");

            HasKey(x => x.Id);
            Property(x => x.Title).HasMaxLength(80).IsRequired();

            HasMany(x => x.Books);

        }
    }
}
