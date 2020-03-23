namespace HealthcardWinForms.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DocDetails",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Doctor = c.String(nullable: false),
                        Specialities = c.String(nullable: false, maxLength: 1024),
                        LicenceNo = c.String(nullable: false),
                        WorkPlace = c.String(nullable: false),
                        AddressLine1 = c.String(nullable: false),
                        AddressLine2 = c.String(),
                        AddressLine3 = c.String(),
                        ZipCode = c.String(nullable: false, maxLength: 6),
                        WorkPlaceContact = c.String(nullable: false),
                        Degree = c.String(nullable: false),
                        State = c.String(nullable: false),
                        IsVerified = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Firstname = c.String(nullable: false),
                        Lastname = c.String(nullable: false),
                        UserType = c.String(nullable: false),
                        Email = c.String(nullable: false, maxLength: 40),
                        Mobile = c.String(nullable: false),
                        Gender = c.String(nullable: false),
                        Password = c.String(nullable: false, maxLength: 2048),
                        Age = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .Index(t => t.Email, unique: true);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.Users", new[] { "Email" });
            DropTable("dbo.Users");
            DropTable("dbo.DocDetails");
        }
    }
}
