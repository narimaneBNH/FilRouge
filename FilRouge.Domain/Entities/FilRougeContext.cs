using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using FilRouge.Domaine.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace FilRouge.Domain.Entities
{
    public class FilRougeContext : IdentityDbContext<ApplicationUser>
    {
        public FilRougeContext() : base("name=FilRougeConnectionString")
        {
        }

        public virtual DbSet<Candidat> Candidats { get; set; }
        public virtual DbSet<Quiz> Quizzes { get; set; }
        public virtual DbSet<Niveau> Niveaux { get; set; }
        public virtual DbSet<Ratio> Ratios { get; set; }
        public virtual DbSet<Question> Questions { get; set; }
        public virtual DbSet<QuestionOption> QuestionOptions { get; set; }
        public virtual DbSet<Reponse> Reponses { get; set; }
        public virtual DbSet<Technologie> Technologies { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<OneToOneConstraintIntroductionConvention>();
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            base.OnModelCreating(modelBuilder);

        }
        public static FilRougeContext Create()
        {
            return new FilRougeContext();
        }

       
    }
}