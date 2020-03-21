namespace HealthcardWinForms.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class user_2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "Mobile", c => c.String());
            AlterColumn("dbo.Users", "Email", c => c.String(maxLength: 40));
            CreateIndex("dbo.Users", "Email", unique: true);
            DropColumn("dbo.Users", "Number");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "Number", c => c.String());
            DropIndex("dbo.Users", new[] { "Email" });
            AlterColumn("dbo.Users", "Email", c => c.String());
            DropColumn("dbo.Users", "Mobile");
        }
    }
}
