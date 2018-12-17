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
    public partial class Reponse
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdReponse { get; set; }

        [DisplayName("Indiquez la réponse ")]
        public string TextReponse { get; set; }

        //[ForeignKey("Quiz")]
        //public int IdQuiz { get; set; }


        [ForeignKey("Question")]
        public int IdQuestion { get; set; }

        [ForeignKey("QuestionOption")]
        public int IdOption { get; set; }

        //public virtual Quiz Quiz { get; set; }
        public virtual Question Question { get; set; }
        public virtual ICollection<QuestionOption> QuestionOptions { get; set; }
        public virtual QuestionOption QuestionOption {get; set;}
    }
}
//IdQuiz
//IDQuestion
//IdUsers