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
        /// <summary>
        /// permet d'afficher la dropDownList consernant le choix de la technologie
        /// </summary>
        /// <returns></returns>
        public Dictionary<int, string> GetTechnologies()
        {
            Dictionary<int, string> techDatas = new Dictionary<int, string>();
            try
            {
                using (FilRougeContext dbContext = new FilRougeContext())
                {
                    foreach(var tech in dbContext.Technologies)
                    {
                        techDatas.Add(tech.IdTech, tech.NomTech);
                    }
                    //dbContext.Technologies.ToList().ForEach(x => techDatas.Add(x.IdTech, x.NomTech));
                    
                }

            }
            catch (Exception ex)
            {

            }
            return techDatas;
        }

        /// <summary>
        /// permet d'afficher la dropDownList consernant le choix du niveau...
        /// </summary>
        /// <returns></returns>
        public Dictionary<int, string> GetNiveaux()
        {
            Dictionary<int, string> nivDatas = new Dictionary<int, string>();
            try
            {
                using (FilRougeContext dbContext = new FilRougeContext())
                {
                    dbContext.Niveaux.ToList().ForEach(x => nivDatas.Add(x.IdNiveau, x.NomNiveau));

                }

            }
            catch (Exception ex)
            {

            }
            return nivDatas;
        }

        /// <summary>
        /// Création d'un quiz avec les infos du candidat
        /// </summary>
        /// <param name="model"> Quiz à créer</param>
        /// <returns>return id ou -1 si erreur</returns>
        public int AddNewBaseQuiz(Quiz model)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// MAJ des réponses du candidat
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool UpdateQuizAnswer(Quiz model)
        {
            try
            {
                using (FilRougeContext dbContext = new FilRougeContext())
                {
                    //MAJ le quiz avec les propriétés model
                    Quiz quizToUpdate = dbContext.Quizzes.Find(model.IdQuiz);
                    //sauvegarde de modification
                    dbContext.SaveChanges();

                    return true;

                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        /// <summary>
        /// Initialisation du quiz afin de récupérer une liste aléatoire de questions
        /// </summary>
        /// <param name="quizId"></param>
        /// <param name="techId"></param>
        /// <param name="nivId"></param>
        /// <param name="questionCount"></param>
        public void InitQuizQuestionList(int quizId, int techId, int nivId, int questionCount)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// récupération des questions du quiz
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Quiz GetQuizQuestions(int id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// récupération de tous les quiz
        /// </summary>
        /// <returns> liste des quiz</returns>
        public List<Quiz> GetQuizzes()
        {
            try
            {
                using (FilRougeContext dbContext = new FilRougeContext())
                {
                    return dbContext.Quizzes.ToList();
                }
            }
            catch (Exception e)
            {
                return new List<Quiz>();
            }
        }
    }
}



#region sheet
/*
        // Création d'un quiz avec les infos du candidat
        public Guid AddNewBaseQuiz(Candidat model)
{
    var dbEntity = new Quiz();
    //Ajout
    var quiz = (Quiz)model;
    //set quiz Name
    var dbTechnologie = dbEntity.Technologie.FirstOrDefault(t => t.Id == model.IdTech);
    var dbNiveau = dbEntity.Niveau.FirstOrDefault(t => t.Id == model.IdNiveau);
    if (dbNiveau != null && dbTechnologie != null)
    {
        var nameTech = dbTechnologie.Nametech;
        var nameNiveau = dbNiveau.NameNiveau;
        quiz.NomQuiz = string.Format("{0} - {1} {2}", model.NomCandidat, nameTech, nameNiveau);
    }
    dbEntity.Quiz.Add(quiz);
    dbEntity.Quiz.SaveChanges();
    InitQuizQuestionList(quiz.IdCandidat, quiz.IdTech, quiz.IdNiveau, model.NbrQuestion);
    return quiz.Id;

}




public void GetTechnology()
{
    //connexion à la Bd
    FilRougeContext db = new FilRougeContext();
    //récupérer Id de technologie


}



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
#endregion
