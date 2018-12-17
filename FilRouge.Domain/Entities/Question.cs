using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace FilRouge.Domain.Entities
{
    public partial class Question
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdQuestion { get; set; }

        [DisplayName("Insérez la Question ")]
        public string LibelleQuestion { get; set; }

        //cette valeur à gérer depuis un enum
        [DisplayName("Type de réponse ")]
        public int ReponseType { get; set; }
        

        [ForeignKey("Niveau")]
        public int IdNiveau { get; set; }

        [DisplayName("Niveau du Quiz ")]
        public virtual Niveau Niveau { get; set; }

        public virtual ICollection<QuestionOption> QuestionOptions { get; set; }
        public virtual ICollection<Quiz> Quizzes { get; set; }


    }
}
  // IdQuiz int ,
	//IdNiveau int ,
	