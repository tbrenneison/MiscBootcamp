using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using catmovieapp.Models;

namespace catmovieapp.Controllers
{
    public class CatNameToVideoURLsController : Controller
    {
        private CatVideoAppEntities db = new CatVideoAppEntities();

        // GET: CatNameToVideoURLs
        public ActionResult Index()
        {
            return View(db.CatNameToVideoURLs.ToList());
        }

        // GET: CatNameToVideoURLs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CatNameToVideoURL catNameToVideoURL = db.CatNameToVideoURLs.Find(id);
            if (catNameToVideoURL == null)
            {
                return HttpNotFound();
            }
            return View(catNameToVideoURL);
        }

        // GET: CatNameToVideoURLs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CatNameToVideoURLs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Expr1,Name,Expr2")] CatNameToVideoURL catNameToVideoURL)
        {
            if (ModelState.IsValid)
            {
                db.CatNameToVideoURLs.Add(catNameToVideoURL);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(catNameToVideoURL);
        }

        // GET: CatNameToVideoURLs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CatNameToVideoURL catNameToVideoURL = db.CatNameToVideoURLs.Find(id);
            if (catNameToVideoURL == null)
            {
                return HttpNotFound();
            }
            return View(catNameToVideoURL);
        }

        // POST: CatNameToVideoURLs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Expr1,Name,Expr2")] CatNameToVideoURL catNameToVideoURL)
        {
            if (ModelState.IsValid)
            {
                db.Entry(catNameToVideoURL).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(catNameToVideoURL);
        }

        // GET: CatNameToVideoURLs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CatNameToVideoURL catNameToVideoURL = db.CatNameToVideoURLs.Find(id);
            if (catNameToVideoURL == null)
            {
                return HttpNotFound();
            }
            return View(catNameToVideoURL);
        }

        // POST: CatNameToVideoURLs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CatNameToVideoURL catNameToVideoURL = db.CatNameToVideoURLs.Find(id);
            db.CatNameToVideoURLs.Remove(catNameToVideoURL);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
