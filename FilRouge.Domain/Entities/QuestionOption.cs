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
    public partial class QuestionOption
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdOption { get; set; }

        [DisplayName("Type de réponse à la question ")]
        public string NomOption { get; set; }
        public string NomChoix { get; set; }

        [ForeignKey("Question")]
        public int IdQuestion { get; set; }

        public bool IsGood { get; set; } 

        public virtual Question Question { get; set; }
        public virtual ICollection<Reponse> Reponses { get; set; }
    }
}
 
  
	