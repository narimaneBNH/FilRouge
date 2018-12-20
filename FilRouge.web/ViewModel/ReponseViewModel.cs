using FilRouge.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FilRouge.web.ViewModel
{
    public class ReponseViewModel
    {
        //à faire!!!
        public List<ReponseViewModel> Reponses { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdReponse { get; set; }

        [DisplayName("Indiquez la réponse ")]
        public string TextReponse { get; set; }

        [ForeignKey("Quiz")]
        public int IdQuiz { get; set; }


        [ForeignKey("Question")]
        public int IdQuestion { get; set; }

        [ForeignKey("QuestionOption")]
        public int? IdOption { get; set; }

        public virtual Quiz Quiz { get; set; }
        public virtual Question Question { get; set; }
        public virtual QuestionOption QuestionOption { get; set; }
    }
}