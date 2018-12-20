namespace FilRouge.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitDataBase : DbMigration
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
                        Question_IdQuestion = c.Int(),
                    })
                .PrimaryKey(t => t.IdQuiz)
                .ForeignKey("dbo.Candidat", t => t.IdCandidat)
                .ForeignKey("dbo.Niveau", t => t.IdNiveau)
                .ForeignKey("dbo.Question", t => t.Question_IdQuestion)
                .ForeignKey("dbo.Technologie", t => t.IdTech)
                .Index(t => t.IdCandidat)
                .Index(t => t.IdNiveau)
                .Index(t => t.IdTech)
                .Index(t => t.Question_IdQuestion);
            
            CreateTable(
                "dbo.Reponse",
                c => new
                    {
                        IdReponse = c.Int(nullable: false, identity: true),
                        TextReponse = c.String(),
                        IdQuiz = c.Int(nullable: false),
                        IdQuestion = c.Int(nullable: false),
                        IdOption = c.Int(),
                    })
                .PrimaryKey(t => t.IdReponse)
                .ForeignKey("dbo.Question", t => t.IdQuestion)
                .ForeignKey("dbo.QuestionOption", t => t.IdOption)
                .ForeignKey("dbo.Quiz", t => t.IdQuiz)
                .Index(t => t.IdQuiz)
                .Index(t => t.IdQuestion)
                .Index(t => t.IdOption);
            
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
                        IsGood = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.IdOption)
                .ForeignKey("dbo.Question", t => t.IdQuestion)
                .Index(t => t.IdQuestion);
            
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
                        RatioValeur = c.Int(nullable: false),
                        IdNiveauPrimaire = c.Int(nullable: false),
                        IdNiveauSecondaire = c.Int(nullable: false),
                        Niveau_IdNiveau = c.Int(),
                    })
                .PrimaryKey(t => t.IdRatio)
                .ForeignKey("dbo.Niveau", t => t.IdNiveauPrimaire)
                .ForeignKey("dbo.Niveau", t => t.IdNiveauSecondaire)
                .ForeignKey("dbo.Niveau", t => t.Niveau_IdNiveau)
                .Index(t => t.IdNiveauPrimaire)
                .Index(t => t.IdNiveauSecondaire)
                .Index(t => t.Niveau_IdNiveau);
            
            CreateTable(
                "dbo.AspNetRoles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true, name: "RoleNameIndex");
            
            CreateTable(
                "dbo.AspNetUserRoles",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("dbo.AspNetRoles", t => t.RoleId)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId)
                .Index(t => t.UserId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.AspNetUsers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Email = c.String(maxLength: 256),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.UserName, unique: true, name: "UserNameIndex");
            
            CreateTable(
                "dbo.AspNetUserClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(nullable: false, maxLength: 128),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUserLogins",
                c => new
                    {
                        LoginProvider = c.String(nullable: false, maxLength: 128),
                        ProviderKey = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId)
                .Index(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropForeignKey("dbo.Ratio", "Niveau_IdNiveau", "dbo.Niveau");
            DropForeignKey("dbo.Ratio", "IdNiveauSecondaire", "dbo.Niveau");
            DropForeignKey("dbo.Ratio", "IdNiveauPrimaire", "dbo.Niveau");
            DropForeignKey("dbo.Quiz", "IdTech", "dbo.Technologie");
            DropForeignKey("dbo.Reponse", "IdQuiz", "dbo.Quiz");
            DropForeignKey("dbo.Reponse", "IdOption", "dbo.QuestionOption");
            DropForeignKey("dbo.Reponse", "IdQuestion", "dbo.Question");
            DropForeignKey("dbo.Quiz", "Question_IdQuestion", "dbo.Question");
            DropForeignKey("dbo.QuestionOption", "IdQuestion", "dbo.Question");
            DropForeignKey("dbo.Question", "IdNiveau", "dbo.Niveau");
            DropForeignKey("dbo.Quiz", "IdNiveau", "dbo.Niveau");
            DropForeignKey("dbo.Quiz", "IdCandidat", "dbo.Candidat");
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            DropIndex("dbo.AspNetUsers", "UserNameIndex");
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.AspNetRoles", "RoleNameIndex");
            DropIndex("dbo.Ratio", new[] { "Niveau_IdNiveau" });
            DropIndex("dbo.Ratio", new[] { "IdNiveauSecondaire" });
            DropIndex("dbo.Ratio", new[] { "IdNiveauPrimaire" });
            DropIndex("dbo.QuestionOption", new[] { "IdQuestion" });
            DropIndex("dbo.Question", new[] { "IdNiveau" });
            DropIndex("dbo.Reponse", new[] { "IdOption" });
            DropIndex("dbo.Reponse", new[] { "IdQuestion" });
            DropIndex("dbo.Reponse", new[] { "IdQuiz" });
            DropIndex("dbo.Quiz", new[] { "Question_IdQuestion" });
            DropIndex("dbo.Quiz", new[] { "IdTech" });
            DropIndex("dbo.Quiz", new[] { "IdNiveau" });
            DropIndex("dbo.Quiz", new[] { "IdCandidat" });
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.AspNetRoles");
            DropTable("dbo.Ratio");
            DropTable("dbo.Technologie");
            DropTable("dbo.QuestionOption");
            DropTable("dbo.Question");
            DropTable("dbo.Reponse");
            DropTable("dbo.Quiz");
            DropTable("dbo.Niveau");
            DropTable("dbo.Candidat");
        }
    }
}
