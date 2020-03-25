namespace HealthcardWinForms.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class phase_2__2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Prescriptions", "Medicine_ID", "dbo.Medicines");
            DropIndex("dbo.Prescriptions", new[] { "Medicine_ID" });
            AddColumn("dbo.Medicines", "UniqueMedicineID", c => c.String());
            AddColumn("dbo.Prescriptions", "MedicineID", c => c.String());
            AddColumn("dbo.Users", "UniqueID", c => c.String(nullable: false));
            DropColumn("dbo.Medicines", "PrescriptionID");
            DropColumn("dbo.Prescriptions", "Medicine_ID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Prescriptions", "Medicine_ID", c => c.Int());
            AddColumn("dbo.Medicines", "PrescriptionID", c => c.Int(nullable: false));
            DropColumn("dbo.Users", "UniqueID");
            DropColumn("dbo.Prescriptions", "MedicineID");
            DropColumn("dbo.Medicines", "UniqueMedicineID");
            CreateIndex("dbo.Prescriptions", "Medicine_ID");
            AddForeignKey("dbo.Prescriptions", "Medicine_ID", "dbo.Medicines", "ID");
        }
    }
}
