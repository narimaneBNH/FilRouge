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
    public class QuestionOptionsController : Controller
    {
        private FilRougeContext db = new FilRougeContext();

        // GET: QuestionOptions
        public ActionResult Index()
        {
            var questionOption = db.QuestionOptions.Include(q => q.Question);
            return View(questionOption.ToList());
        }

        // GET: QuestionOptions/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            QuestionOption questionOption = db.QuestionOptions.Find(id);
            if (questionOption == null)
            {
                return HttpNotFound();
            }
            return View(questionOption);
        }

        // GET: QuestionOptions/Create
        public ActionResult Create()
        {
            ViewBag.IdQuestion = new SelectList(db.Questions, "IdQuestion", "LibelleQuestion");
            return View();
        }

        // POST: QuestionOptions/Create
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdOption,NomOption,NomChoix,IdQuestion,IsGood")] QuestionOption questionOption)
        {
            if (ModelState.IsValid)
            {
                db.QuestionOptions.Add(questionOption);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.IdQuestion = new SelectList(db.Questions, "IdQuestion", "LibelleQuestion", questionOption.IdQuestion);
            return View(questionOption);
        }

        // GET: QuestionOptions/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            QuestionOption questionOption = db.QuestionOptions.Find(id);
            if (questionOption == null)
            {
                return HttpNotFound();
            }
            ViewBag.IdQuestion = new SelectList(db.Questions, "IdQuestion", "LibelleQuestion", questionOption.IdQuestion);
            return View(questionOption);
        }

        // POST: QuestionOptions/Edit/5
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdOption,NomOption,NomChoix,IdQuestion,IsGood")] QuestionOption questionOption)
        {
            if (ModelState.IsValid)
            {
                db.Entry(questionOption).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.IdQuestion = new SelectList(db.Questions, "IdQuestion", "LibelleQuestion", questionOption.IdQuestion);
            return View(questionOption);
        }

        // GET: QuestionOptions/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            QuestionOption questionOption = db.QuestionOptions.Find(id);
            if (questionOption == null)
            {
                return HttpNotFound();
            }
            return View(questionOption);
        }

        // POST: QuestionOptions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            QuestionOption questionOption = db.QuestionOptions.Find(id);
            db.QuestionOptions.Remove(questionOption);
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
