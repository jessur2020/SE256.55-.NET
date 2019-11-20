using MovieList.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MovieList.Controllers
{
    public class MovieController : Controller
    {
        private MovieDbEntities _db = new MovieDbEntities();
        // GET: Movie
        public ActionResult Index()
        {
            return View(_db.Movies.ToList());
        }

        // GET: Movie/Details/5
        public ActionResult Details(int id)
        {
            var movieDetails = _db.Movies.Find(id);
            return View(movieDetails);
        }

        // GET: Movie/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Movie/Create
        [HttpPost]
        public ActionResult Create(Movie movieToCreate)
        {
            try
            {
                _db.Movies.Add(movieToCreate);
                _db.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Movie/Edit/5
        public ActionResult Edit(int id)
        {
            var movieToEdit = _db.Movies.Find(id);
            return View(movieToEdit);
        }

        // POST: Movie/Edit/5
        [HttpPost]
        public ActionResult Edit(Movie movieToEdit)
        {
            try
            {
                // TODO: Add update logic here
                _db.Entry(movieToEdit).State = System.Data.Entity.EntityState.Modified;
                _db.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Movie/Delete/5
        public ActionResult Delete(int id)
        {
            var movieToDelete = _db.Movies.Find(id);
            return View(movieToDelete);
        }

        // POST: Movie/Delete/5
        [HttpPost]
        public ActionResult Delete(Movie movieToDelete)
        {
            try
            {
                // TODO: Add delete logic here

                _db.Entry(movieToDelete).State = EntityState.Deleted;
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
