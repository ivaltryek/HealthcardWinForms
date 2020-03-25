namespace HealthcardWinForms.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class phase_2__4 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Prescriptions", "DoctorEmail", c => c.String(nullable: false));
            AddColumn("dbo.Prescriptions", "PatientID", c => c.String(nullable: false));
            AddColumn("dbo.Prescriptions", "PatientName", c => c.String(nullable: false));
            AddColumn("dbo.Prescriptions", "DoctorHospital", c => c.String(nullable: false));
            AddColumn("dbo.Prescriptions", "DoctorName", c => c.String(nullable: false));
            AlterColumn("dbo.Prescriptions", "MedicineID", c => c.String(nullable: false));
            DropColumn("dbo.Prescriptions", "Doctor");
            DropColumn("dbo.Prescriptions", "Patient");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Prescriptions", "Patient", c => c.String(nullable: false));
            AddColumn("dbo.Prescriptions", "Doctor", c => c.String(nullable: false));
            AlterColumn("dbo.Prescriptions", "MedicineID", c => c.String());
            DropColumn("dbo.Prescriptions", "DoctorName");
            DropColumn("dbo.Prescriptions", "DoctorHospital");
            DropColumn("dbo.Prescriptions", "PatientName");
            DropColumn("dbo.Prescriptions", "PatientID");
            DropColumn("dbo.Prescriptions", "DoctorEmail");
        }
    }
}
