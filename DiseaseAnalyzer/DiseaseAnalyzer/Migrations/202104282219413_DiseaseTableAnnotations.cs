namespace DiseaseAnalyzer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DiseaseTableAnnotations : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Diseases", "Temperature_Symptom_Value", c => c.Int());
            AlterColumn("dbo.Diseases", "Cold_Symptom_Value", c => c.Int());
            AlterColumn("dbo.Diseases", "Cough_Symptom_Value", c => c.Int());
            AlterColumn("dbo.Diseases", "Throating_Symptom_Value", c => c.Int());
            AlterColumn("dbo.Diseases", "Jaw_Gland_Symptom_Value", c => c.Int());
            AlterColumn("dbo.Diseases", "Breathlessness_Symptom_Value", c => c.Int());
            AlterColumn("dbo.Diseases", "Rash_Symptom_Value", c => c.Int());
            AlterColumn("dbo.Diseases", "Vomitting_Symptom_Value", c => c.Int());
            AlterColumn("dbo.Diseases", "Ear_Gland_Symptom_Value", c => c.Int());
            AlterColumn("dbo.Diseases", "Stomach_Ache_Symptom_Value", c => c.Int());
            AlterColumn("dbo.Diseases", "Intestine_Disorder_Symptom_Value", c => c.Int());
            AlterColumn("dbo.Diseases", "Yellolwish_Skin_Symptom_Value", c => c.Int());
            AlterColumn("dbo.Diseases", "Head_Ache_Symptom_Value", c => c.Int());
            AlterColumn("dbo.Diseases", "Chills_Symptom_Value", c => c.Int());
            AlterColumn("dbo.Diseases", "Light_Fear_Symptom_Value", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Diseases", "Light_Fear_Symptom_Value", c => c.Int(nullable: false));
            AlterColumn("dbo.Diseases", "Chills_Symptom_Value", c => c.Int(nullable: false));
            AlterColumn("dbo.Diseases", "Head_Ache_Symptom_Value", c => c.Int(nullable: false));
            AlterColumn("dbo.Diseases", "Yellolwish_Skin_Symptom_Value", c => c.Int(nullable: false));
            AlterColumn("dbo.Diseases", "Intestine_Disorder_Symptom_Value", c => c.Int(nullable: false));
            AlterColumn("dbo.Diseases", "Stomach_Ache_Symptom_Value", c => c.Int(nullable: false));
            AlterColumn("dbo.Diseases", "Ear_Gland_Symptom_Value", c => c.Int(nullable: false));
            AlterColumn("dbo.Diseases", "Vomitting_Symptom_Value", c => c.Int(nullable: false));
            AlterColumn("dbo.Diseases", "Rash_Symptom_Value", c => c.Int(nullable: false));
            AlterColumn("dbo.Diseases", "Breathlessness_Symptom_Value", c => c.Int(nullable: false));
            AlterColumn("dbo.Diseases", "Jaw_Gland_Symptom_Value", c => c.Int(nullable: false));
            AlterColumn("dbo.Diseases", "Throating_Symptom_Value", c => c.Int(nullable: false));
            AlterColumn("dbo.Diseases", "Cough_Symptom_Value", c => c.Int(nullable: false));
            AlterColumn("dbo.Diseases", "Cold_Symptom_Value", c => c.Int(nullable: false));
            AlterColumn("dbo.Diseases", "Temperature_Symptom_Value", c => c.Int(nullable: false));
        }
    }
}
