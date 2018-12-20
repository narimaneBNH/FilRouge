using FilRouge.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FilRouge.Services.Services;

namespace FilRouge.web.Controllers
{
    public class QuizController : Controller
    {
        private FilRougeContext db = new FilRougeContext();

        // GET: Quiz
        public ActionResult Index()
        {
            return View();
        }

        //create Quiz
        public ActionResult CreateQuiz()
        {
            ViewBag.IdTech = new SelectList(db.Technologies, "IdTech", "NomTech");
            ViewBag.IdNiveau = new SelectList(db.Niveaux, "IdNiveau", "NomTech");
            
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateQuiz([Bind(Include = "IdQuiz,IdTech,IdNiveau,NbrQuestion")] Quiz quiz)
        {
            if (ModelState.IsValid)
            {
                db.Quizzes.Add(quiz);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.IdTech = new SelectList(db.Technologies, "IdTech", "NomTech");
            ViewBag.IdNiveau = new SelectList(db.Niveaux, "IdNiveau", "NomTech");

            return View();
        }
    }
}