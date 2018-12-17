using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using System.ComponentModel;

namespace FilRouge.Domain.Entities
{
    public partial class Technologie
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdTech { get; set; }

        [DisplayName("Sélectionnez la technologie ")]
        public string NomTech { get; set; }

        public virtual ICollection<Quiz> Quizzes { get; set; }
    }
}
