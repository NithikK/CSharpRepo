using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVCEF_App.Models;

namespace MVCEF_App.Controllers
{
    public class AppointmentController : Controller
    {
        // GET: AppointmentController
        public ActionResult Index()
        {
            List<Appointment> appointment = RepositoryAppointment.GetAppointments();
            if (appointment != null && appointment.Count > 0)
            {
                return View(appointment);
            }
            else
            {
                return RedirectToAction("Create");
            }
        }

        // GET: AppointmentController/Details/5
        public ActionResult Details(int id)
        {
            Appointment doctor = RepositoryAppointment.GetAppointmentById(id);
            return View(doctor);
        }

        // GET: AppointmentController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AppointmentController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection, Appointment pappointment)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    RepositoryAppointment.AddNewAppointment(pappointment);
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AppointmentController/Edit/5
        public ActionResult Edit(int id)
        {
            Appointment doctor = RepositoryAppointment.GetAppointmentById(id);
            return View(doctor);
        }

        // POST: AppointmentController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection, Appointment doctor)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    RepositoryAppointment.ModifyAppointment(doctor);
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AppointmentController/Delete/5
        public ActionResult Delete(int id)
        {
            Appointment doctor = RepositoryAppointment.GetAppointmentById(id);
            return View(doctor);
        }

        // POST: AppointmentController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    RepositoryAppointment.RemoveAppointment(id);
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
