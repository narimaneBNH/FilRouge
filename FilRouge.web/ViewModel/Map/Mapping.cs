using FilRouge.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FilRouge.web.ViewModel.Map
{
    public static class Mapping
    {
        /// <summary>
        /// correspondance des propriétés de ViewModel avec les propriétés de Model
        /// </summary>
        /// <param name="quiz"></param>
        /// <returns>objet quizVM</returns>
        public static QuizViewModel MapToQuizViewModel(this Quiz quiz)
        {
            QuizViewModel quizVM = new QuizViewModel();
            //tester si le paramètre d'entrée est nul ou pas!
            if (quiz == null)
                return quizVM;
            quizVM = new QuizViewModel()
            {
                //Prop de QuizVm = Quiz.Prop
                IdQuiz = quiz.IdQuiz,
                NomQuiz = quiz.NomQuiz,
                NombreQuestion = quiz.NombreQuestion,
                IdCandidat = quiz.IdCandidat,
                IdNiveau = quiz.IdNiveau,
                IdTech = quiz.IdTech
            };
            return quizVM;
        }

        /// <summary>
        /// correspondance des propriétés de Model avec les propriétés de ViewModel
        /// </summary>
        /// <param name="quizV">méthode d'extension</param>
        /// <returns>objet quiz</returns>
        public static Quiz MapToQuiz(this Quiz quizV)
        {
            Quiz quiz = new Quiz();
            //tester si le paramètre d'entrée est nul ou pas!
            if (quizV == null)
                return quiz;
            quiz = new Quiz()
            {
                //Prop de Quiz = Quiz.Prop QuizVM
                IdQuiz = quizV.IdQuiz,
                NomQuiz = quizV.NomQuiz,
                NombreQuestion = quizV.NombreQuestion,
                IdCandidat = quizV.IdCandidat,
                IdNiveau = quizV.IdNiveau,
                IdTech = quizV.IdTech
            };
            return quiz;
        }
    }
}