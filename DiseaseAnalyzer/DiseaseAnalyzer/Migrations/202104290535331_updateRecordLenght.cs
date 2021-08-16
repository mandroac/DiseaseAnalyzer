namespace DiseaseAnalyzer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateRecordLenght : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.MedicalRecords", "Record", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.MedicalRecords", "Record", c => c.String(nullable: false, maxLength: 512));
        }
    }
}
