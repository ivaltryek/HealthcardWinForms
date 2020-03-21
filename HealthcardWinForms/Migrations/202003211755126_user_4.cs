namespace HealthcardWinForms.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class user_4 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Users", "age", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Users", "age", c => c.Int(nullable: false));
        }
    }
}
