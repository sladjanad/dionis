using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DionIS.DAL.Domen;
namespace Dionis.WebApp.Controllers
{
    public class JedinicaMjereController : Controller
    {
        DionisDBContext dionisContext = new DionisDBContext();

        // GET: JedinicaMjere
        public ActionResult Index()
        {
            return View(dionisContext.JedinicaMjeres.ToList());
        }

        // GET: JedinicaMjere/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: JedinicaMjere/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: JedinicaMjere/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            JedinicaMjere jedinicaMjere = new JedinicaMjere();
            try
            {
                jedinicaMjere.Oznaka = collection.Get("Oznaka").ToString();
                jedinicaMjere.Naziv = collection.Get("Naziv").ToString();
                jedinicaMjere.Broj = Int32.Parse(collection.Get("Broj"));
                jedinicaMjere.Mirko = collection.Get("Mirko").ToString();
                dionisContext.JedinicaMjeres.Add(jedinicaMjere);
                dionisContext.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: JedinicaMjere/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: JedinicaMjere/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            JedinicaMjere jedinicaMjere = new JedinicaMjere();
            try
            {
                
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: JedinicaMjere/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: JedinicaMjere/Delete/5
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
