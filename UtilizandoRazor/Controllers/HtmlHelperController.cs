using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UtilizandoRazor.Models;

namespace UtilizandoRazor.Controllers
{
    public class HtmlHelperController : Controller
    {


        public ActionResult Lista()
        {
            ViewBag.tipoDeConta = new SelectList(
                new Conta().listaTipoConta(), "idConta", "tipoDeConta"
                );

            return View();
        }

        public ActionResult Lista2()
        {
            var tipos = new Collection<string>
            {
                "conta corrente",
                "conta poupança",
                "conta salário"
            };
            ViewBag.tipoDeConta = tipos;

            return View();
        }



        // GET: HtmlHelper
        public ActionResult Index()
        {
            return View();
        }

        // GET: HtmlHelper/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: HtmlHelper/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HtmlHelper/Create
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

        // GET: HtmlHelper/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: HtmlHelper/Edit/5
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

        // GET: HtmlHelper/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: HtmlHelper/Delete/5
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
