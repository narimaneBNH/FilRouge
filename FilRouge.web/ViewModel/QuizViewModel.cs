using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FilRouge.web.ViewModel
{
    public class QuizViewModel
    {
        [Required]
        [DisplayName("Id du Quiz: ")]
        public int IdQuiz { get; set; }

        [DisplayName("Nom du Quiz ")]
        [Required(ErrorMessage = "Veuillez entrer le nom du Quiz")]
        public string NomQuiz { get; set; }

        [DisplayName("Nombre de questions ")]
        [Required(ErrorMessage = "Veuillez saisir le nombre de questions à créer")]
        public int NombreQuestion { get; set; }

        [DisplayName("Id du candidat ")]
        [Required(ErrorMessage = "Veuillez entrer l'Id du candidat")]
        public int IdCandidat { get; set; }

        [DisplayName("Id du Niveau")]
        [Required(ErrorMessage = "Veuillez entrer l'Id du Niveau")]
        public int IdNiveau { get; set; }

        [DisplayName("Id de la Technologie")]
        [Required(ErrorMessage = "Veuillez entrer l'Id de la Technologie")]
        public int IdTech { get; set; }

        [DisplayName("Questions")]
        public List<ReponseViewModel> Questions { get; set; }
    }
}