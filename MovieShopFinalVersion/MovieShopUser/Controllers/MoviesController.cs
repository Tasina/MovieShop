﻿using MovieShopDAL;
using MovieShopDAL.BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MovieShopUser.Controllers
{
    public class MoviesController : Controller
    {
        //private MovieShopDBContext db = new MovieShopDBContext();

        DALFacade DF = new DALFacade();


        // GET: Movies
        public ActionResult Index(string GenreList)
        {
            //var movies = db.Movies.Include(m => m.Genre);
            var movies = DF.MovieRepository.GetAll();

            ViewBag.GenreList = new SelectList(
                DF.GenreRepository.GetAll().OrderBy(g => g.Name).Select(g => g.Name));

            if (string.IsNullOrEmpty(GenreList))
            {
                return View(movies.ToList());
            }
            else
            {
                return View(movies.Where(m => m.Genre.Name == GenreList));
            }

            //return View(movies.ToList());
        }

        // GET: Movies/Details/5
        public ActionResult Details(int id)
        {
            //if (id == null)
            //{
            //    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            //}
            Movie movie = DF.MovieRepository.Get(id);
            if (movie == null)
            {
                return HttpNotFound();
            }
            return View(movie);
        }


        // GET: Movies/Create
        public ActionResult Create()
        {
            ViewBag.GenreId = new SelectList(DF.GenreRepository.GetAll(), "GenreId", "Name");
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
                DF.MovieRepository.Add(movie);
                return RedirectToAction("Index");
            }

            ViewBag.GenreId = new SelectList(DF.GenreRepository.GetAll(), "GenreId", "Name", movie.Genre.GenreId);
            return View(movie);
        }

        // GET: Movies/Edit/5
        public ActionResult Edit(int id)
        {

            Movie movie = DF.MovieRepository.Get(id);
            if (movie == null)
            {
                return HttpNotFound();
            }
            ViewBag.GenreId = new SelectList(DF.GenreRepository.GetAll(), "GenreId", "Name", movie.Genre.GenreId);
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
                DF.MovieRepository.Edit(movie);
                return RedirectToAction("Index");
            }
            ViewBag.GenreId = new SelectList(DF.GenreRepository.GetAll(), "GenreId", "Name", movie.Genre.GenreId);
            return View(movie);
        }

        // GET: Movies/Delete/5
        public ActionResult Delete(int id)
        {
            //if (id == null)
            //{
            //    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            //}
            Movie movie = DF.MovieRepository.Get(id);
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
            DF.MovieRepository.Remove(id);

            return RedirectToAction("Index");
        }


        public ActionResult MovieCount()
        {
            var noOfAlbums = (DF.MovieRepository.GetAll() as List<Movie>).Count;
            return Content("Total number of movies: " + noOfAlbums);
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