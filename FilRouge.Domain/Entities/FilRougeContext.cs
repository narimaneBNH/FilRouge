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

        public virtual DbSet<Candidat> Candidat { get; set; }
        public virtual DbSet<Quiz> Quiz { get; set; }
        public virtual DbSet<Niveau> Niveau { get; set; }
        public virtual DbSet<Ratio> Ratio { get; set; }
        public virtual DbSet<Question> Question { get; set; }
        public virtual DbSet<QuestionOption> QuestionOption { get; set; }
        public virtual DbSet<Reponse> Reponse { get; set; }

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

        public System.Data.Entity.DbSet<FilRouge.Domain.Entities.Technologie> Technologies { get; set; }
    }
}