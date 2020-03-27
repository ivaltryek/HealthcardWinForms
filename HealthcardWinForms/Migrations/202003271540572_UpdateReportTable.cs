namespace HealthcardWinForms.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateReportTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Reports", "Content", c => c.Binary(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Reports", "Content");
        }
    }
}
