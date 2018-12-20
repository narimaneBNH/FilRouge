using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using FilRouge.Domain.Entities;

namespace FilRouge.web.Controllers
{
    public class RatiosController : Controller
    {
        private FilRougeContext db = new FilRougeContext();

        // GET: Ratios
        public ActionResult Index()
        {
            return View(db.Ratios.ToList());
        }

        // GET: Ratios/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ratio ratio = db.Ratios.Find(id);
            if (ratio == null)
            {
                return HttpNotFound();
            }
            return View(ratio);
        }

        // GET: Ratios/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Ratios/Create
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdRatio,NomRatio")] Ratio ratio)
        {
            if (ModelState.IsValid)
            {
                db.Ratios.Add(ratio);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(ratio);
        }

        // GET: Ratios/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ratio ratio = db.Ratios.Find(id);
            if (ratio == null)
            {
                return HttpNotFound();
            }
            return View(ratio);
        }

        // POST: Ratios/Edit/5
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdRatio,NomRatio")] Ratio ratio)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ratio).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(ratio);
        }

        // GET: Ratios/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ratio ratio = db.Ratios.Find(id);
            if (ratio == null)
            {
                return HttpNotFound();
            }
            return View(ratio);
        }

        // POST: Ratios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Ratio ratio = db.Ratios.Find(id);
            db.Ratios.Remove(ratio);
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
