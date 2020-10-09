namespace Biosite.Infra.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class biosite_03052020_2253 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.biositeapp_nutraceutical", "CommonName", c => c.String(maxLength: 250));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.biositeapp_nutraceutical", "CommonName", c => c.String());
        }
    }
}
