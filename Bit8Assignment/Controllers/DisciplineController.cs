using Bit8Assignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bit8Assignment.Controllers
{
    public class DisciplineController : Controller
    {
        public ActionResult Index()
        {
            Bit8Entities entities = new Bit8Entities();
            List<Discipline> discipline = entities.Disciplines.ToList();
            if (discipline.Count == 0)
            {
                discipline.Add(new Discipline());
            }

            return View(discipline);
        }

        // GET: Discipline/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Discipline/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Discipline/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Discipline/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Discipline/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Discipline/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Discipline/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
