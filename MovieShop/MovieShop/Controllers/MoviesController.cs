using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MovieShopDAL;
using MovieStore.Models;
using MovieShopDAL.Repositories;

namespace MovieShopUI.Controllers
{
    public class MoviesController : Controller
    {
        //private MovieShopDBContext db = new MovieShopDBContext();
        IRepository<Movie> MovieRepo = new MovieRepository();
        IRepository<Genre> GenreRepo = new GenreRepository();
        // GET: Movies
        public ActionResult Index(string GenreList)
        {
            //var movies = db.Movies.Include(m => m.Genre);
            var movies = MovieRepo.GetAll();
            ViewBag.GenreList = new SelectList(GenreRepo.GetAll().OrderBy(g => g.Name).Select(g =>g.Name));
            if (string.IsNullOrEmpty(GenreList))
            {
                return View(movies.ToList());
            }
            else
            {
                return View(movies.Where(a => a.Genre.Name == GenreList));
            }
            
        }

        // GET: Movies/Details/5
        public ActionResult Details(int id)
        {
            //if (id == null)
            //{
            //    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            //}
            Movie movie = MovieRepo.Get(id);
            if (movie == null)
            {
                return HttpNotFound();
            }
            return View(movie);
        }


        // GET: Movies/Create
        public ActionResult Create()
        {
            ViewBag.GenreId = new SelectList(GenreRepo.GetAll(), "GenreId", "Name");
            return View();
        }

        // POST: Movies/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MovieId,GenreId,Title,Year,Price,ImageUrl,TrailerUrl")] Movie movie)
        {
            if (ModelState.IsValid)
            {
                MovieRepo.Add(movie);
                return RedirectToAction("Index");
            }

            ViewBag.GenreId = new SelectList(GenreRepo.GetAll(), "GenreId", "Name", movie.Genre.GenreId);
            return View(movie);
        }

        // GET: Movies/Edit/5
        public ActionResult Edit(int id)
        {
          
            Movie movie = MovieRepo.Get(id);
            if (movie == null)
            {
                return HttpNotFound();
            }
            ViewBag.GenreId = new SelectList(GenreRepo.GetAll(), "GenreId", "Name", movie.Genre.GenreId);
            return View(movie);
        }

        // POST: Movies/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MovieId,GenreId,Title,Year,Price,ImageUrl,TrailerUrl")] Movie movie)
        {
            if (ModelState.IsValid)
            {
                MovieRepo.Edit(movie);
                return RedirectToAction("Index");
            }
            ViewBag.GenreId = new SelectList(GenreRepo.GetAll(), "GenreId", "Name", movie.Genre.GenreId);
            return View(movie);
        }

        // GET: Movies/Delete/5
        public ActionResult Delete(int id)
        {
            //if (id == null)
            //{
            //    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            //}
            Movie movie = MovieRepo.Get(id);
            if (movie == null)
            {
                return HttpNotFound();
            }
            return View(movie);
        }

        // POST: Movies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            MovieRepo.Remove(id);
          
            return RedirectToAction("Index");
        }

        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing)
        //    {
        //        db.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}
    }
}
