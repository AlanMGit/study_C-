using Relationship_EntityFramework.DataContexts;
using Relationship_EntityFramework.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relationship_EntityFramework
{
    class Program
    {
        static void Main(string[] args)
        {

            var computing = new Category { Id = 1, Title = "Informática" };
            var sciences  = new Category { Id = 2, Title = "Ciências" };

            Author andre = new Author { Id = 1, Name = "André Baltieri" };
            Author bruce = new Author { Id = 2, Name = "Bruce Wayne" };
            Author peter = new Author { Id = 3, Name = "Peter Parker" };
            Author tony  = new Author { Id = 4, Name = "Tony Stark" };

            Book devapi = new Book { Id = 1, Title = "Desenvolvendo APIs com WebApi", CategoryId = 1 };
            Book ninjitsu = new Book { Id = 2, Title = "Os segredos do Ninjitsu", CategoryId = 2 };

            using (AppDataContext db = new AppDataContext())
            {
                db.Categories.Add(computing);
                db.Categories.Add(sciences);

                db.Books.Add(devapi);
                db.Books.Add(ninjitsu);

                db.Authors.Add(andre);
                db.Authors.Add(bruce);
                db.Authors.Add(peter);
                db.Authors.Add(tony);

                devapi.Authors.Add(andre);
                devapi.Authors.Add(bruce);
                devapi.Authors.Add(peter);
                devapi.Authors.Add(tony);

                db.SaveChanges();
            }

            #region Categorias
            using (AppDataContext db = new AppDataContext())
            {
                Console.WriteLine("Categories");
                foreach (Category category in db.Categories)
                {
                    Console.WriteLine(
                        String.Format("{0} - {1}",
                            category.Id,
                            category.Title));
                }
            }
            #endregion

            Console.WriteLine(Environment.NewLine);

            #region Autores
            using (AppDataContext db = new AppDataContext())
            {
                Console.WriteLine("Authors");
                foreach (Author author in db.Authors)
                {
                    Console.WriteLine(
                        String.Format("{0} - {1}",
                            author.Id,
                            author.Name));
                }
            }
            #endregion

            Console.WriteLine(Environment.NewLine);

            #region Livros
            using (AppDataContext db = new AppDataContext())
            {
                Console.WriteLine("Books");
                foreach (Book book in db.Books)
                {
                    Console.WriteLine(
                        String.Format("{0} - {1}",
                            book.Id,
                            book.Title));
                }
            }
            #endregion

            Console.WriteLine(Environment.NewLine);

            #region Tudo
            using (AppDataContext db = new AppDataContext())
            {
                Console.WriteLine("Tudo");
                foreach (Category category in
                    db.Categories.Include("Book")
                                 .Include("Book.Authors")
                                 .ToList())
                {
                    Console.WriteLine("Categoria: " + category.Title);
                    foreach (Book book in category.Books)
                    {
                        Console.WriteLine("\tLivro: " + book.Title);
                        foreach (Author author in book.Authors)
                        {
                            Console.WriteLine("\t\tAutor: " + author.Name);
                        }
                    }
                    Console.WriteLine(Environment.NewLine);
                }
            }
            #endregion

            Console.ReadKey();

        }
    }
}
