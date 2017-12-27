using Data.DataContexts;
using Domain;
using Domain.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;

namespace Data.Repositories
{
    public class BookRepository : IBookRepository
    {
        private BookStoreContext context;

        public BookRepository()
        {
            context = new BookStoreContext();
        }

        public void Create(Book entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Book> Get(int skip = 0, int take = 25)
        {
            return context.Books.OrderBy(x => x.Title)
                .Skip(skip)
                .Take(take)
                .ToList();
        }

        public Book Get(int id)
        {
            return context.Books.Find(id);
        }

        public List<Book> GetWithAuthor(int skip = 0, int take = 25)
        {
            return context.Books
                .Include(x => x.Authors)
                .OrderBy(x => x.Title)
                .Skip(skip)
                .Take(take)
                .ToList();
        }

        public Book GetWithAuthor(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Book entity)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            context.Dispose();
        }
    }
}
