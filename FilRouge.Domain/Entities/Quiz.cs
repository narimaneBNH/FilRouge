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
    public partial class Quiz 
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdQuiz { get; set; }

        public string NomQuiz { get; set; }
        public int NombreQuestion { get; set; }
        //public string NomTech { get; set; }
        public int IdCandidat { get; set; }

        [ForeignKey("Niveau")]
        public int IdNiveau { get; set; }

        [ForeignKey("Technologie")]
        public int IdTech { get; set; }

        public virtual Candidat Candidat { get; set; }
        public virtual Niveau Niveau { get; set; }
        public virtual Technologie Technologie { get; set; }

        public virtual ICollection<Question> Questions { get; set; }
        public virtual ICollection<Reponse> Reponses { get; set; }
    }
}

    //IdUser int ,
	//IdNiveau int ,
	