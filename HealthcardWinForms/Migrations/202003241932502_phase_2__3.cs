namespace HealthcardWinForms.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class phase_2__3 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Prescriptions", "PatientEmail");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Prescriptions", "PatientEmail", c => c.String(nullable: false));
        }
    }
}
