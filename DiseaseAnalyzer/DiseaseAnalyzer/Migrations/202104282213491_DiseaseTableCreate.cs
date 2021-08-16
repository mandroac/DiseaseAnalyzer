namespace DiseaseAnalyzer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DiseaseTableCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Diseases",
                c => new
                    {
                        Disease_ID = c.Int(nullable: false, identity: true),
                        Disease_Name = c.String(),
                        Disease_Description = c.String(),
                        Temperature_Symptom_Value = c.Int(nullable: false),
                        Cold_Symptom_Value = c.Int(nullable: false),
                        Cough_Symptom_Value = c.Int(nullable: false),
                        Throating_Symptom_Value = c.Int(nullable: false),
                        Jaw_Gland_Symptom_Value = c.Int(nullable: false),
                        Breathlessness_Symptom_Value = c.Int(nullable: false),
                        Rash_Symptom_Value = c.Int(nullable: false),
                        Vomitting_Symptom_Value = c.Int(nullable: false),
                        Ear_Gland_Symptom_Value = c.Int(nullable: false),
                        Stomach_Ache_Symptom_Value = c.Int(nullable: false),
                        Intestine_Disorder_Symptom_Value = c.Int(nullable: false),
                        Yellolwish_Skin_Symptom_Value = c.Int(nullable: false),
                        Head_Ache_Symptom_Value = c.Int(nullable: false),
                        Chills_Symptom_Value = c.Int(nullable: false),
                        Light_Fear_Symptom_Value = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Disease_ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Diseases");
        }
    }
}
