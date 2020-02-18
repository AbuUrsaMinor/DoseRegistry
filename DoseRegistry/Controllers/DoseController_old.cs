using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DoseRegistry.Controllers
{
    public class DoseController_old : Controller
    {
        // GET: Dose
        public ActionResult Index()
        {
            return View();
        }

        // GET: Dose/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Dose/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Dose/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Dose/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Dose/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Dose/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Dose/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}