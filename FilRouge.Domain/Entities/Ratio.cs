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
        public int RatioValeur { get; set; }

        [ForeignKey("NiveauPrimaire")]
        public int IdNiveauPrimaire { get; set; }

        [ForeignKey("NiveauSecondaire")]
        public int IdNiveauSecondaire { get; set; }

        public virtual Niveau NiveauPrimaire { get; set; }
        public virtual Niveau NiveauSecondaire { get; set; }


    }
}

  //  IdNiveau int ,
	