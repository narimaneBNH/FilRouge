using FilRouge.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilRouge.Services.Interfaces
{
    interface IQuizService
    {
        Dictionary<int, string> GetTechnologies();
        Dictionary<int, string> GetNiveaux();
        int AddNewBaseQuiz(Quiz model);
        bool UpdateQuizAnswer(Quiz model);
        void InitQuizQuestionList(int quizId, int techId, int nivId, int questionCount);
        Quiz GetQuizQuestions(int id);
        List<Quiz> GetQuizzes();

    }
}
