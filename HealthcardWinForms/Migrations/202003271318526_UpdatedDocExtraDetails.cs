namespace HealthcardWinForms.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatedDocExtraDetails : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.DocDetails", "Specialities", c => c.String(maxLength: 1024));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.DocDetails", "Specialities", c => c.String(nullable: false, maxLength: 1024));
        }
    }
}
