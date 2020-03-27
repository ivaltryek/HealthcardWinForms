namespace HealthcardWinForms.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Report : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Reports",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        PatientID = c.String(nullable: false),
                        PatientName = c.String(nullable: false),
                        LaboratorianID = c.String(nullable: false),
                        LaboratorianName = c.String(nullable: false),
                        PathTOReport = c.String(nullable: false),
                        ReportDescription = c.String(nullable: false),
                        UploadDate = c.String(nullable: false),
                        LabName = c.String(nullable: false),
                        ReportName = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Reports");
        }
    }
}
