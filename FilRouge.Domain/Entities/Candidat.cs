using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FilRouge.Domain.Entities
{
    public partial class Candidat
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int IdCandidat { get; set; }
        public string NomCandidat { get; set; }
        public string PrenomCandidat { get; set; }
        public string Telephone { get; set; }
        public string Mail { get; set; }
        //public string PwdCandidat { get; set; }
        //public string Fonction { get; set; }


    }
}

