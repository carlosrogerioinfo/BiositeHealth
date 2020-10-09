namespace Biosite.Infra.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class biosite_13032020_1555 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.biositeapp_nutraceutical", "Unity", c => c.String(nullable: false, maxLength: 20));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.biositeapp_nutraceutical", "Unity", c => c.String());
        }
    }
}
