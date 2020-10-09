namespace Biosite.Infra.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class biosite_15032020_0101 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.biositeapp_nutraceutical", "NutraceuticalReferences", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.biositeapp_nutraceutical", "NutraceuticalReferences", c => c.String(nullable: false, maxLength: 4000));
        }
    }
}
