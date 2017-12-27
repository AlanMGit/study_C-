using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Contracts
{
    public interface IBookRepository : IRepository<Book>
    {

        List<Book> GetWithAuthor(int skip = 0, int take = 25);
        Book GetWithAuthor(int id);

    }
}
