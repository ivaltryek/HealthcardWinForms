namespace HealthcardWinForms.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class phase_2__1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Medicines", "MedicineName", c => c.String(nullable: false));
            AddColumn("dbo.Medicines", "MorningDose", c => c.Int(nullable: false));
            AddColumn("dbo.Medicines", "AfterNoonDose", c => c.Int(nullable: false));
            AddColumn("dbo.Medicines", "NightDose", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Medicines", "NightDose");
            DropColumn("dbo.Medicines", "AfterNoonDose");
            DropColumn("dbo.Medicines", "MorningDose");
            DropColumn("dbo.Medicines", "MedicineName");
        }
    }
}
