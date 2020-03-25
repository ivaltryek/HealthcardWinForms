namespace HealthcardWinForms.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class phase_2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Medicines",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Days = c.Int(nullable: false),
                        PrescriptionID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Prescriptions",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Doctor = c.String(nullable: false),
                        Patient = c.String(nullable: false),
                        PatientEmail = c.String(nullable: false),
                        Medicine_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Medicines", t => t.Medicine_ID)
                .Index(t => t.Medicine_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Prescriptions", "Medicine_ID", "dbo.Medicines");
            DropIndex("dbo.Prescriptions", new[] { "Medicine_ID" });
            DropTable("dbo.Prescriptions");
            DropTable("dbo.Medicines");
        }
    }
}
