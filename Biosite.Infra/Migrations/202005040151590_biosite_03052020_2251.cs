namespace Biosite.Infra.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class biosite_03052020_2251 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.biositeapp_nutraceutical", "CommonName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.biositeapp_nutraceutical", "CommonName");
        }
    }
}
