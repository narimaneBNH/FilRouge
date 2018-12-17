using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FilRouge.Domain.Entities;
using FilRouge.Services.Interfaces;

namespace FilRouge.Services.Services
{
    class QuizServices : IQuizService
    {
       /*
        //************************ Question *******************************
        //Ajouter une question
        public void AddNewQuestion(Question model)
        {
            //connexion avec dbContext
            FilRougeContext dbContext = new FilRougeContext();
            //ajouter à la table Question une ligne via le context
            dbContext.Question.Add(model);
            dbContext.SaveChanges();
        }
        //retourne la liste des Questions
        public List<Question> GetQuestions()
        {
            //connexion avec dbContext
            FilRougeContext dbContext = new FilRougeContext();
            //retourner la lister
            return dbContext.Question.ToList();

        }
        //retourne une question dont l'id est passé en paramètre
        public Question GetQuestionById(int id)
        {
            //connexion avec dbContext
            FilRougeContext dbContext = new FilRougeContext();
            //retourner un candidat avec son id comme paramètre
            return GetQuestions().Where(c => c.IdQuestion == id).SingleOrDefault();
        }




        */


        /*
        // Création d'un quiz avec les infos du candidat
        public Guid AddNewBaseQuiz(Candidat model)
        {
            var dbEntity = new Quiz();
            //Ajout
            var Quiz = ;
            
        }

        //MAJ des réponses du candidat
        public bool UpdateQuizAnswers(Quiz model)
        {
            var nbUpdated = 0;
            var nbQuestion = model.Questions.Count();
            using (var dbEntity = new TechnicalQuizContext())
            {
                foreach (var question in model.Questions)
                {
                    var quizId = model.QuizId;
                    var questionId = question.QuestionId;
                    var quizAnswer = bdEntity.Reponses.FirstOrDefault(qa => qa.QuestionId == questionId && qa.QuizId == quizId);
                    var optionType = (DataTypeEnum)question.
                }
            }

                return nbUpdated == nbQuestion;
                
        }

        //permet d'afficher la dropDownList consernant le choix de la technologie
        public Dictionary<int, string> GetTechnologies(bool includeDisable)
        {

        }

        //permet d'afficher la dropDownList consernant le choix du niveau...
        public Dictionary<int, string> GetNiveaux(bool includeDisable)
        { }

        //Initialisation du quiz afin de récupérer une liste aléatoire de questions
        public void InitQuizQuestionList(Guid quisId, int technologieId, int nivauId, int quizQuestionCount)
        {

        }
        
        //récupération des questions du quiz
        public Quiz GetQuizQuestions(int id)
        {

        }

        //récupération de tous les quiz
        public List<QuizSummaryViewModel> GetSummaryQuizzes()
        {

        }

        //récupération de tous les quiz avec les questions
        public List<QuizViewModel> GetQuizzes()
        {

        }
        */


    }
}
