using Fidelitas.NoSql.PrimerEjemplo.Collections;
using Fidelitas.NoSql.PrimerEjemplo.Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fidelitas.NoSql.PrimerEjemplo.Controllers
{
    public class PeliculasController : Controller
    {
        /*
         try
            {
                var peliculas = elContexto.LasPeliculas;
                peliculas.InsertOne(laPelicula);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
             */


        private ContextoMongo elContexto = new ContextoMongo();

        // GET: Peliculas
        public ActionResult Index()
        {
            var peliculas = elContexto.LasPeliculas;
            var lasPeliculas = peliculas.AsQueryable().ToList();
            return View(lasPeliculas);
        }

        // GET: Peliculas/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Peliculas/Create
        public ActionResult Insertar()
        {
            return View();
        }

        // POST: Peliculas/Create
        [HttpPost]
        public ActionResult Insertar(Peliculas laPelicula)
        {
            try
            {
                var peliculas = elContexto.LasPeliculas;
                peliculas.InsertOne(laPelicula);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Peliculas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Peliculas/Create
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

        // GET: Peliculas/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Peliculas/Edit/5
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

        // GET: Peliculas/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Peliculas/Delete/5
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
