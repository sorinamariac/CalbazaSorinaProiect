using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalbazaSorinaProiect.Controllers
{
    public class AppointmentsController : Controller
    {
        // GET: AppoinmentsControer
        public ActionResult Index()
        {


            return View();
        }

        // GET: AppoinmentsControer/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AppoinmentsControer/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AppoinmentsControer/Create
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

        // GET: AppoinmentsControer/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AppoinmentsControer/Edit/5
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

        // GET: AppoinmentsControer/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AppoinmentsControer/Delete/5
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
