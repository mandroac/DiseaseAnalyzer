namespace DiseaseAnalyzer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PatientsAndMedicalRecordsTables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MedicalRecords",
                c => new
                    {
                        MedicalRecord_ID = c.Int(nullable: false, identity: true),
                        Record = c.String(nullable: false, maxLength: 512),
                        Patient_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MedicalRecord_ID)
                .ForeignKey("dbo.Patients", t => t.Patient_ID, cascadeDelete: true)
                .Index(t => t.Patient_ID);
            
            CreateTable(
                "dbo.Patients",
                c => new
                    {
                        Patient_ID = c.Int(nullable: false, identity: true),
                        FullName = c.String(),
                        Email = c.String(nullable: false),
                        Password = c.String(nullable: false, maxLength: 255),
                    })
                .PrimaryKey(t => t.Patient_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MedicalRecords", "Patient_ID", "dbo.Patients");
            DropIndex("dbo.MedicalRecords", new[] { "Patient_ID" });
            DropTable("dbo.Patients");
            DropTable("dbo.MedicalRecords");
        }
    }
}
