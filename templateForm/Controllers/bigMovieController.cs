using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using templateForm.Models;

namespace templateForm.Controllers
{
    public class bigMovieController : Controller
    {

        MovieModel2 DB;
        public bigMovieController()
        {
            DB = new MovieModel2();
            DB.Configuration.ProxyCreationEnabled = false;
        }
        // GET: BigMovie
        public ActionResult GetAll()
        {
            var list = DB.movies.ToList();
            return View(list);
        }
        public ActionResult GetById(int id)
        {
            var data = DB.movies.FirstOrDefault(ww => ww.id == id);
            return View(data);
        }
        public ActionResult GetByOne()
        {
            var mov = DB.movies.First();
            //return View(mov);
            ViewData["mov"] = mov;
            return View();
        }
        [HttpGet]
        public ActionResult create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult create([Bind(Include ="name,year,rate")]movies a)
        {
            DB.movies.Add(a);
            DB.SaveChanges();
            return RedirectToAction("GetAll");
        }
        [HttpGet]
        public ActionResult Details(int id)
        {
            var a = DB.movies.Find(id);

            return View(a);
        }
        [HttpGet]
        public ActionResult Delete(int id)
        {
            DB.movies.Remove(DB.movies.FirstOrDefault(ww => ww.id == id));
            DB.SaveChanges();
            return RedirectToAction("GetAll");
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            var a = DB.movies.Single(ww => ww.id == id);


            return View(a);
        }


        [HttpPost]
        public ActionResult Edit(movies a)
        {
            DB.Entry(a).State = System.Data.Entity.EntityState.Modified;
            DB.SaveChanges();

            return RedirectToAction("GetAll");
        }

    }
}