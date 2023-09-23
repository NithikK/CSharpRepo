using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MVCTagHelpers.Controllers
{
    public class PartialViewController : Controller
    {
        // GET: PartialViewController
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Tabs()
        {
            ViewData["data1"] = "Tom and Jerry are Good friends";
            return View();
        }

        // GET: PartialViewController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PartialViewController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PartialViewController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PartialViewController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PartialViewController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PartialViewController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PartialViewController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
