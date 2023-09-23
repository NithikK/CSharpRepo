﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVCAuthor.Models;

namespace MVCAuthor.Controllers
{
    public class EmpController : Controller
    {
        // GET: EmpController
        public ActionResult Index()
        {
            List<Emp> empList = EmpDbRepository.GetEmpList();
            return View(empList);
        }

        // GET: EmpController/Details/5
        public ActionResult Details(int id)
        {
            Emp empList = EmpDbRepository.GetEmpById(id);
            return View(empList);
        }

        // GET: EmpController/Create
        public ActionResult Create()
        {
            Emp emp = new Emp();
            return View(emp);
        }

        // POST: EmpController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection, Emp emp)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    EmpDbRepository.AddNewEmp(emp);
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {   
                return View();
            }
        }

        // GET: EmpController/Edit/5
        public ActionResult Edit(int id)
        {
            if(id == 0)
            {
                return RedirectToAction("Index");
            }
            Emp emp = new Emp();
            emp = EmpDbRepository.GetEmpById(id);
            return View(emp);
        }

        // POST: EmpController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection, Emp pEmp)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    EmpDbRepository.UpdateEmp(pEmp);
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EmpController/Delete/5
        public ActionResult Delete(int id)
        {
            if(id <= 0)
            {
                return RedirectToAction("Index");
            }
            Emp emp = EmpDbRepository.GetEmpById(id);
            return View(emp);
        }

        // POST: EmpController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                if(ModelState.IsValid)
                {
                    EmpDbRepository.DeleteEmp(id);
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
