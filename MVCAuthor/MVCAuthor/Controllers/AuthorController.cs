using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVCAuthor.Models;

namespace MVCAuthor.Controllers
{
    public class AuthorController : Controller
    {
        // GET: AuthorController
        public ActionResult Index()
        {
            Dictionary<int, Author> list = AuthorRepository.GetAuthorDictionary();
            if(list!= null && list.Count>0)
            {
                return View("AuthorList", list.Values.ToList());
            }
            return View();
        }

        // GET: AuthorController/Details/5
        public ActionResult Details(int id)
        {
            Author author = AuthorRepository.FindAuthorById(id);
            if(author != null)
            {
                return View(author);
            }
            return RedirectToAction("Index");
        }
        public ActionResult AuthorList()
        {
            return View(AuthorRepository.GetAuthorDictionary());
        }
        private static Author StringToAuthor(String[] data, Author author)
        {
            author.AuthorID = int.Parse(data[0]);
            author.AuthorName = data[1];
            author.TotalBooks = int.Parse(data[2]);
            author.Royalty = data[3];
            author.DOB = DateTime.Parse(data[4]);
            return author;
        }
        
        // GET: AuthorController/Create
        public ActionResult Create()
        {
            Author author = new Author();//model binding
            return View(author);
        }

        // POST: AuthorController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection, Author pAuthor)
        {
            try
            {
                AuthorRepository.SaveToFile(pAuthor);
                return RedirectToAction(nameof(Index));
            }
            catch(Exception err)
            {
                Console.WriteLine(err.Message);
                return View();
            }
        }

        // GET: AuthorController/Edit/5
        public ActionResult Edit(int id)
        {
            Author author = AuthorRepository.FindAuthorById(id);
            if(author != null)
            {
                return View(author);
            }
            return View(author);
        }

        // POST: AuthorController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection, Author pAuthor)
        {
            try
            {
                AuthorRepository.UpdateAuthorToFile(pAuthor);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AuthorController/Delete/5
        public ActionResult Delete(int id)
        {
            Author author = AuthorRepository.FindAuthorById(id);
            if(author != null)
            {
                return View(author);
            }
            return View(author);
        }

        // POST: AuthorController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection, Author author)
        {
            try
            {
                AuthorRepository.RemoveAuthor(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
