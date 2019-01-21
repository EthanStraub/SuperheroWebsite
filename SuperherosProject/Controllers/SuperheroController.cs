using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SuperherosProject.Models;
using System.Data;
using System.Data.Entity;
using System.Net;

namespace SuperherosProject.Controllers
{
    public class SuperheroController : Controller
    {
        private ApplicationDbContext _context;

        public SuperheroController()
        {
            _context = new ApplicationDbContext();
        }

        // GET: Superhero
        public ActionResult Index()
        {
            var HerosList = _context.Superhero.ToList();
            return View(HerosList);
        }

        // GET: Superhero/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Superhero hero = _context.Superhero.Find(id);
            if (hero == null)
            {
                return HttpNotFound();
            }
            return View(hero);
        }

        // GET: Superhero/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Superhero/Create
        [HttpPost]
        public ActionResult Create([Bind(Include = "ID,Name,AlterEgo,PrimaryAbility,SecondaryAbility,Catchphrase")] Superhero hero)
        {
            if (ModelState.IsValid)
            {
                _context.Superhero.Add(hero);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(hero);
        }

        // GET: Superhero/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Superhero hero = _context.Superhero.Find(id);
            if (hero == null)
            {
                return HttpNotFound();
            }
            return View(hero);
        }

        // POST: Superhero/Edit/5
        [HttpPost]
        public ActionResult Edit([Bind(Include = "ID,Name,AlterEgo,PrimaryAbility,SecondaryAbility,Catchphrase")] Superhero hero)
        {
            if (ModelState.IsValid)
            {
                _context.Entry(hero).State = EntityState.Modified;
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(hero);
        }

        // GET: Superhero/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Superhero hero = _context.Superhero.Find(id);
            if (hero == null)
            {
                return HttpNotFound();
            }
            return View(hero);
        }

        // POST: Superhero/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Superhero hero = _context.Superhero.Find(id);
            _context.Superhero.Remove(hero);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
