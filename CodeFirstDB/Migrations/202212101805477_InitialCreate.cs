namespace CodeFirstDB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Candidates",
                c => new
                    {
                        CandidateNumber = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        MiddleName = c.String(),
                        LastName = c.String(),
                        Gender = c.String(),
                        NativeLanguage = c.String(),
                        CountryOfResidence = c.String(),
                        Birthdate = c.DateTime(nullable: false),
                        Email = c.String(),
                        LandLineNumber = c.String(),
                        MobileNumber = c.String(),
                        Address1 = c.String(),
                        Address2 = c.String(),
                        PostalCode = c.String(),
                        Town = c.String(),
                        Province = c.String(),
                        PhotoIdType = c.String(),
                        PhotoIdNumber = c.String(),
                        PhotoIdDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.CandidateNumber);
            
            CreateTable(
                "dbo.Certificates",
                c => new
                    {
                        TitleOfCertificate = c.String(nullable: false, maxLength: 128),
                        CandidateNumber = c.Int(nullable: false),
                        AssessmentTestCode = c.Int(nullable: false),
                        ExaminationDate = c.DateTime(nullable: false),
                        ScoreReportDate = c.DateTime(nullable: false),
                        CandidateScore = c.Int(nullable: false),
                        MaximumScore = c.Int(nullable: false),
                        AssessmentResultLabel = c.String(),
                        PercentageScore = c.String(),
                    })
                .PrimaryKey(t => t.TitleOfCertificate)
                .ForeignKey("dbo.Candidates", t => t.CandidateNumber, cascadeDelete: true)
                .Index(t => t.CandidateNumber);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Certificates", "CandidateNumber", "dbo.Candidates");
            DropIndex("dbo.Certificates", new[] { "CandidateNumber" });
            DropTable("dbo.Certificates");
            DropTable("dbo.Candidates");
        }
    }
}
