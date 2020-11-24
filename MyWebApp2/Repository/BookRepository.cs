using MyWebApp2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebApp2.Repository
{
    public class BookRepository
    {
        public List<Book> GetAllBooks()
        {
            return DataSource();
        }
        public Book GetBook(int id)
        {
            return DataSource().Where(data => data.Id == id).FirstOrDefault();
        }
        public List<Book> SearchBook(string bookName, string authorName)
        {
            return DataSource().Where(data => data.Title.Contains(bookName) || data.Author == authorName).ToList();
        }
        private List<Book> DataSource()
        {
            return new List<Book>()
            {
                new Book(){Id=1, Title="Java", Author="Koushik"},
                new Book(){Id=2, Title=".Net", Author="Koushik"},
                new Book(){Id=3, Title="php", Author="Koushik"}
            };
        }
    }
}
