namespace FilRouge.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FilRougeDataBase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Candidat",
                c => new
                    {
                        IdCandidat = c.Int(nullable: false, identity: true),
                        NomCandidat = c.String(),
                        PrenomCandidat = c.String(),
                        Telephone = c.String(),
                        Mail = c.String(),
                    })
                .PrimaryKey(t => t.IdCandidat);
            
            CreateTable(
                "dbo.Niveau",
                c => new
                    {
                        IdNiveau = c.Int(nullable: false, identity: true),
                        NomNiveau = c.String(),
                    })
                .PrimaryKey(t => t.IdNiveau);
            
            CreateTable(
                "dbo.Quiz",
                c => new
                    {
                        IdQuiz = c.Int(nullable: false, identity: true),
                        NomQuiz = c.String(),
                        NombreQuestion = c.Int(nullable: false),
                        IdCandidat = c.Int(nullable: false),
                        IdNiveau = c.Int(nullable: false),
                        IdTech = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdQuiz)
                .ForeignKey("dbo.Candidat", t => t.IdCandidat)
                .ForeignKey("dbo.Niveau", t => t.IdNiveau)
                .ForeignKey("dbo.Technologie", t => t.IdTech)
                .Index(t => t.IdCandidat)
                .Index(t => t.IdNiveau)
                .Index(t => t.IdTech);
            
            CreateTable(
                "dbo.Question",
                c => new
                    {
                        IdQuestion = c.Int(nullable: false, identity: true),
                        LibelleQuestion = c.String(),
                        ReponseType = c.Int(nullable: false),
                        IdNiveau = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdQuestion)
                .ForeignKey("dbo.Niveau", t => t.IdNiveau)
                .Index(t => t.IdNiveau);
            
            CreateTable(
                "dbo.QuestionOption",
                c => new
                    {
                        IdOption = c.Int(nullable: false, identity: true),
                        NomOption = c.String(),
                        NomChoix = c.String(),
                        IdQuestion = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdOption)
                .ForeignKey("dbo.Question", t => t.IdQuestion)
                .Index(t => t.IdQuestion);
            
            CreateTable(
                "dbo.Reponse",
                c => new
                    {
                        IdReponse = c.Int(nullable: false, identity: true),
                        LibelleReponse = c.String(),
                        IdQuestion = c.Int(nullable: false),
                        Quiz_IdQuiz = c.Int(),
                    })
                .PrimaryKey(t => t.IdReponse)
                .ForeignKey("dbo.Question", t => t.IdQuestion)
                .ForeignKey("dbo.Quiz", t => t.Quiz_IdQuiz)
                .Index(t => t.IdQuestion)
                .Index(t => t.Quiz_IdQuiz);
            
            CreateTable(
                "dbo.Technologie",
                c => new
                    {
                        IdTech = c.Int(nullable: false, identity: true),
                        NomTech = c.String(),
                    })
                .PrimaryKey(t => t.IdTech);
            
            CreateTable(
                "dbo.Ratio",
                c => new
                    {
                        IdRatio = c.Int(nullable: false, identity: true),
                        NomRatio = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdRatio);
            
            CreateTable(
                "dbo.ReponseQuestionOption",
                c => new
                    {
                        Reponse_IdReponse = c.Int(nullable: false),
                        QuestionOption_IdOption = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Reponse_IdReponse, t.QuestionOption_IdOption })
                .ForeignKey("dbo.Reponse", t => t.Reponse_IdReponse)
                .ForeignKey("dbo.QuestionOption", t => t.QuestionOption_IdOption)
                .Index(t => t.Reponse_IdReponse)
                .Index(t => t.QuestionOption_IdOption);
            
            CreateTable(
                "dbo.QuestionQuiz",
                c => new
                    {
                        Question_IdQuestion = c.Int(nullable: false),
                        Quiz_IdQuiz = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Question_IdQuestion, t.Quiz_IdQuiz })
                .ForeignKey("dbo.Question", t => t.Question_IdQuestion)
                .ForeignKey("dbo.Quiz", t => t.Quiz_IdQuiz)
                .Index(t => t.Question_IdQuestion)
                .Index(t => t.Quiz_IdQuiz);
            
            CreateTable(
                "dbo.RatioNiveau",
                c => new
                    {
                        Ratio_IdRatio = c.Int(nullable: false),
                        Niveau_IdNiveau = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Ratio_IdRatio, t.Niveau_IdNiveau })
                .ForeignKey("dbo.Ratio", t => t.Ratio_IdRatio)
                .ForeignKey("dbo.Niveau", t => t.Niveau_IdNiveau)
                .Index(t => t.Ratio_IdRatio)
                .Index(t => t.Niveau_IdNiveau);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.RatioNiveau", "Niveau_IdNiveau", "dbo.Niveau");
            DropForeignKey("dbo.RatioNiveau", "Ratio_IdRatio", "dbo.Ratio");
            DropForeignKey("dbo.Quiz", "IdTech", "dbo.Technologie");
            DropForeignKey("dbo.Reponse", "Quiz_IdQuiz", "dbo.Quiz");
            DropForeignKey("dbo.QuestionQuiz", "Quiz_IdQuiz", "dbo.Quiz");
            DropForeignKey("dbo.QuestionQuiz", "Question_IdQuestion", "dbo.Question");
            DropForeignKey("dbo.ReponseQuestionOption", "QuestionOption_IdOption", "dbo.QuestionOption");
            DropForeignKey("dbo.ReponseQuestionOption", "Reponse_IdReponse", "dbo.Reponse");
            DropForeignKey("dbo.Reponse", "IdQuestion", "dbo.Question");
            DropForeignKey("dbo.QuestionOption", "IdQuestion", "dbo.Question");
            DropForeignKey("dbo.Question", "IdNiveau", "dbo.Niveau");
            DropForeignKey("dbo.Quiz", "IdNiveau", "dbo.Niveau");
            DropForeignKey("dbo.Quiz", "IdCandidat", "dbo.Candidat");
            DropIndex("dbo.RatioNiveau", new[] { "Niveau_IdNiveau" });
            DropIndex("dbo.RatioNiveau", new[] { "Ratio_IdRatio" });
            DropIndex("dbo.QuestionQuiz", new[] { "Quiz_IdQuiz" });
            DropIndex("dbo.QuestionQuiz", new[] { "Question_IdQuestion" });
            DropIndex("dbo.ReponseQuestionOption", new[] { "QuestionOption_IdOption" });
            DropIndex("dbo.ReponseQuestionOption", new[] { "Reponse_IdReponse" });
            DropIndex("dbo.Reponse", new[] { "Quiz_IdQuiz" });
            DropIndex("dbo.Reponse", new[] { "IdQuestion" });
            DropIndex("dbo.QuestionOption", new[] { "IdQuestion" });
            DropIndex("dbo.Question", new[] { "IdNiveau" });
            DropIndex("dbo.Quiz", new[] { "IdTech" });
            DropIndex("dbo.Quiz", new[] { "IdNiveau" });
            DropIndex("dbo.Quiz", new[] { "IdCandidat" });
            DropTable("dbo.RatioNiveau");
            DropTable("dbo.QuestionQuiz");
            DropTable("dbo.ReponseQuestionOption");
            DropTable("dbo.Ratio");
            DropTable("dbo.Technologie");
            DropTable("dbo.Reponse");
            DropTable("dbo.QuestionOption");
            DropTable("dbo.Question");
            DropTable("dbo.Quiz");
            DropTable("dbo.Niveau");
            DropTable("dbo.Candidat");
        }
    }
}
