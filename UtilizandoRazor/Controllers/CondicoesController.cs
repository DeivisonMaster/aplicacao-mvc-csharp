using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UtilizandoRazor.Controllers
{
    public class CondicoesController : Controller
    {
        // GET: Condicoes
        public ActionResult Index()
        {
            return View();
        }

        // GET: Condicoes/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Condicoes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Condicoes/Create
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

        // GET: Condicoes/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Condicoes/Edit/5
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

        // GET: Condicoes/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Condicoes/Delete/5
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
