namespace Biosite.Infra.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Biositev3 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.biositeapp_disease",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(nullable: false, maxLength: 255, fixedLength: true),
                        CID = c.String(nullable: false, maxLength: 255, fixedLength: true),
                        PrescriptionId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.biositeapp_prescription",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Description = c.String(nullable: false, maxLength: 4000, fixedLength: true),
                        Dosage = c.String(nullable: false, maxLength: 4000, fixedLength: true),
                        Note = c.String(),
                        Verified = c.Boolean(nullable: false),
                        Active = c.Boolean(nullable: false),
                        LastUpdate = c.DateTime(nullable: false),
                        DiseaseId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.biositeapp_disease", t => t.DiseaseId, cascadeDelete: true)
                .Index(t => t.DiseaseId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.biositeapp_prescription", "DiseaseId", "dbo.biositeapp_disease");
            DropIndex("dbo.biositeapp_prescription", new[] { "DiseaseId" });
            DropTable("dbo.biositeapp_prescription");
            DropTable("dbo.biositeapp_disease");
        }
    }
}
