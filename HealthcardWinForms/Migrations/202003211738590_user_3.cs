namespace HealthcardWinForms.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class user_3 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Users", "password", c => c.String(maxLength: 2048));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Users", "password", c => c.String());
        }
    }
}
