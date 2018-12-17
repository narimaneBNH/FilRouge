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
    public partial class Ratio
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdRatio { get; set; }

        [DisplayName("Indiquez le ratio ")]
        public int NomRatio { get; set; }

        //[ForeignKey("Niveau")]
        //public int IdNiveau { get; set; }

        //public virtual Niveau Niveau { get; set; }

        public virtual ICollection<Niveau> Niveaux { get; set; }
    }
}

  //  IdNiveau int ,
	