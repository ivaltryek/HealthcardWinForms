namespace HealthcardWinForms.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class LaboratorianDetailsTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.LaboratorianDetails",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Laboratorian = c.String(nullable: false),
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
            
        }
        
        public override void Down()
        {
            DropTable("dbo.LaboratorianDetails");
        }
    }
}
