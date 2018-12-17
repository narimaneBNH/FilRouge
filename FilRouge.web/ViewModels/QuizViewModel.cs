using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FilRouge.web.ViewModels
{
    public class QuizViewModel
    {

        [DisplayName("Nom du Quiz ")]
        [Required(ErrorMessage = "Veuillez donner un nom pour le Quiz")]
        public string NomQuiz { get; set; }

        [DisplayName("Nombre de questions ")]
        [Required(ErrorMessage = "Veuillez saisir le nombre de questions")]
        public int NombreQuestion { get; set; }
        //public string NomTech { get; set; }


        [ForeignKey("Candidat")]
        [DisplayName("Nom du candidat ")]
        [Required(ErrorMessage = "Veuillez entrer le nom du candidat")]
        public int IdCandidat { get; set; }

        [ForeignKey("Niveau")]
        [DisplayName("Niveau du Quiz ")]
        [Required(ErrorMessage = "Veuillez sélectionner le type de réponse (unique, mutiple ou libre)")]
        public int IdNiveau { get; set; }

        [DisplayName("La technologie")]
        [Required(ErrorMessage = "Veuillez sélectionner une technologie")]
        [ForeignKey("Technologie")]
        public int IdTech { get; set; }
        
    }
}