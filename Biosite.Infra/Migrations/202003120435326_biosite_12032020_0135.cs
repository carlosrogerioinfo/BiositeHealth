namespace Biosite.Infra.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class biosite_12032020_0135 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.biositeapp_prescription_detail", "Posology", c => c.String(nullable: false, maxLength: 4000));
            AddColumn("dbo.biositeapp_prescription_detail", "Information", c => c.String(nullable: false, maxLength: 4000));
            AddColumn("dbo.biositeapp_prescription_detail", "Note", c => c.String(nullable: false, maxLength: 4000));
            AlterColumn("dbo.biositeapp_disease", "Description", c => c.String(nullable: false, maxLength: 1000));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.biositeapp_disease", "Description", c => c.String());
            DropColumn("dbo.biositeapp_prescription_detail", "Note");
            DropColumn("dbo.biositeapp_prescription_detail", "Information");
            DropColumn("dbo.biositeapp_prescription_detail", "Posology");
        }
    }
}
