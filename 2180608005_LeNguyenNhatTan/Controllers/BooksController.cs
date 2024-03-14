using _2180608005_LeNguyenNhatTan.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _2180608005_LeNguyenNhatTan.Controllers
{
    public class BooksController : Controller
    {
        private List<Book> listBook;
        public BooksController()
        {
            listBook = new List<Book>();
            listBook.Add(new Book()
            {
                Id = 1,
                Title = "Đi tìm lẽ sống",
                Author = "dont know",
                PublicYear = 2011,
                Price = 100000,
                Cover = "/Content/images/book1.jpg"
            });
            listBook.Add(new Book()
            {
                Id = 2,
                Title = "7 thói quen hiểu quả",
                Author = "dont know",
                PublicYear = 2000,
                Price = 300000,
                Cover = "/Content/images/book2.jpg"
            });
            listBook.Add(new Book()
            {
                Id = 3,
                Title = "Hạt giống tâm hồn",
                Author = "dont know",
                PublicYear = 1985,
                Price = 400000,
                Cover = "/Content/images/book3.jpg"
            });
        }
        // GET: All Books
        public ActionResult listBooks()
        {
            ViewBag.TitlePageName = "HUTECH BOOKS";
            return View(listBook);
        }

        // GET: detail
        public ActionResult Detail(int?id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }
            Book book = listBook.Find(x => x.Id == id);
            if (book == null)
            {
                return HttpNotFound();   
            }
            return View(book);
        }

        // GET: edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Book book)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var editBook = listBook.Find(b => b.Id == book.Id);
                    editBook.Title = book.Title;
                    editBook.Author = book.Author;
                    editBook.Cover = book.Cover;
                    editBook.Price = book.Price;
                    editBook.PublicYear = book.PublicYear;
                    return View("ListBooks", listBook);
                }
                catch (Exception ex)
                {
                    return HttpNotFound();
                }
            }
            else
            {
                ModelState.AddModelError("", "Input Model Not Valide!");
                return View(book);
            }
        }

    }
}