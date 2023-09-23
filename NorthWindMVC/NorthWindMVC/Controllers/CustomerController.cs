using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NorthWindMVC.Models;

namespace NorthWindMVC.Controllers
{
    public class CustomerController : Controller
    {
        private RepositoryCustomer _repositoryCustomers;
        public CustomerController(RepositoryCustomer repository)
        {
            _repositoryCustomers = repository;
        }
        // GET: CustomerController
        public ActionResult Index()
        {
            List<string> customerIds = _repositoryCustomers.GetAllCustomerByID();
            CustomerIdsViewModel idsViewModel = new CustomerIdsViewModel(customerIds);
            return View(idsViewModel);
        }

        // GET: CustomerController/Details/5
        public ActionResult Details(string id)
        {
            Customer customer = _repositoryCustomers.FindCustomerByCustomerId(id);
            List<Order> orders = _repositoryCustomers.GetCustomerOrders(id);
            ViewData["Order"] = orders;
            return View(customer);
        }

        // GET: CustomerController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CustomerController/Create
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

        // GET: CustomerController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CustomerController/Edit/5
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

        // GET: CustomerController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CustomerController/Delete/5
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
