using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relationship_EntityFramework.Model
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int CategoryId { get; set; }

        public virtual ICollection<Author> Authors { get; set; }
        public virtual Category Category { get; set; }

        public Book()
        {
            Authors = new List<Author>();
        }
    }
}
