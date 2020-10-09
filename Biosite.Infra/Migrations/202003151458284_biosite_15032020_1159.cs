namespace Biosite.Infra.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class biosite_15032020_1159 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.biositeapp_nutraceutical", "MedicalOnly", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.biositeapp_nutraceutical", "MedicalOnly");
        }
    }
}
