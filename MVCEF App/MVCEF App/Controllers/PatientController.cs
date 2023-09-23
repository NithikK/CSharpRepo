using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVCEF_App.Models;

namespace MVCEF_App.Controllers
{
    public class PatientController : Controller
    {
        // GET: PatientController
        public ActionResult Index()
        {
            List<Patient> patient = RepositoryPatient.GetPatients();
            if (patient != null && patient.Count > 0)
            {
                return View(patient);
            }
            else
            {
                return RedirectToAction("Create");
            }
        }

        // GET: PatientController/Details/5
        public ActionResult Details(int id)
        {
            Patient doctor = RepositoryPatient.GetPatientById(id);
            return View(doctor);
        }

        // GET: PatientController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PatientController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection, Patient ppatient)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    RepositoryPatient.AddNewPatient(ppatient);
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PatientController/Edit/5
        public ActionResult Edit(int id)
        {
            Patient doctor = RepositoryPatient.GetPatientById(id);
            return View(doctor);
        }

        // POST: PatientController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection, Patient doctor)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    RepositoryPatient.ModifyPatient(doctor);
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PatientController/Delete/5
        public ActionResult Delete(int id)
        {
            Patient doctor = RepositoryPatient.GetPatientById(id);
            return View(doctor);
        }

        // POST: PatientController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    RepositoryPatient.RemovePatient(id);
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
