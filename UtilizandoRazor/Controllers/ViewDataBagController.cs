using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UtilizandoRazor.Models;

namespace UtilizandoRazor.Controllers
{
    public class ViewDataBagController : Controller
    {
        // GET: ViewDataBag
        public ActionResult Index()
        {
            ViewData["dataAtual"] = DateTime.Now.ToLongDateString();
            ViewBag.horaAtual = DateTime.Now.ToLongTimeString();

            return View();
        }

        /* forma de transporte de objetos com razor: viewdata e viewbag*/
        public ActionResult exemplo2()
        {
            var conta = new Conta()
            {
                idConta = 1,
                numeroConta = 001659,
                nomeCliente = "joão da silva",
                saldoAtual = 1535.0,
                limiteChequeEspecial = 500.0,
                dataEntrada = DateTime.Now.Date
            };

            ViewData["conta"] = conta;
            ViewBag.conta = conta;

            return View();
        }

        /* forma 2 de transporte de objetos com razor: strongly typed views stv*/
        public ActionResult exemplo3()
        {
            var conta = new Conta
            {
                idConta = 2,
                numeroConta = 0332,
                nomeCliente = "Maria Silva",
                saldoAtual = 2400.0,
                limiteChequeEspecial = 1400.0,
                dataEntrada = DateTime.Now.Date
            };

            return View(conta);
        }


        // GET: ViewDataBag/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ViewDataBag/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ViewDataBag/Create
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

        // GET: ViewDataBag/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ViewDataBag/Edit/5
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

        // GET: ViewDataBag/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ViewDataBag/Delete/5
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
