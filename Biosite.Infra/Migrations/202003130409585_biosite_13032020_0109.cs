namespace Biosite.Infra.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class biosite_13032020_0109 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.biositeapp_prescription", "Description", c => c.String(nullable: false, maxLength: 4000));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.biositeapp_prescription", "Description", c => c.String(nullable: false, maxLength: 1000));
        }
    }
}
