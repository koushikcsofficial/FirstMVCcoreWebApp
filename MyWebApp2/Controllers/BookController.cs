using Microsoft.AspNetCore.Mvc;
using MyWebApp2.Models;
using MyWebApp2.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebApp2.Controllers
{
    public class BookController : Controller
    {
        private readonly BookRepository _bookrepo = null;

        public BookController()
        {
            _bookrepo = new BookRepository();
        }
        public ViewResult GetAllBooks()
        {
            //return "All books list will be shown here";
            var result =  _bookrepo.GetAllBooks();
            return View();
        }

        public Book GetBook(int id)
        {
            //return $"Book id is {id}";
            return _bookrepo.GetBook(id);
        }

        public List<Book> searchBook(string bookName, string authorName)
        {
            //return $"book name is {bookName} and the author is {authorName}";
            return _bookrepo.SearchBook(bookName, authorName);
        }
    }
}
