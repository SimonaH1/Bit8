using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Bit8Assignment.Models;

namespace Bit8Assignment.Controllers
{
    public class SemesterController : Controller
    {
        // GET: Semester
        public ActionResult Index()
        {
            Bit8Entities entities = new Bit8Entities();
            List<SemesterDiscipline> sd = entities.SemesterDisciplines.ToList();
            List<Semester> semesters = entities.Semesters.ToList();
            if (semesters.Count == 0)
            {
                semesters.Add(new Semester());
            }

            return View(semesters);
        }
        // GET: Semester/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Semester/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Semester/Create
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

        // GET: Semester/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Semester/Edit/5
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

        // GET: Semester/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Semester/Delete/5
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
