namespace Biosite.Infra.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class biosite_15032020_0105 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.biositeapp_nutraceutical", "Pharmacology", c => c.String(nullable: false));
            AlterColumn("dbo.biositeapp_nutraceutical", "ActionMechanism", c => c.String(nullable: false));
            AlterColumn("dbo.biositeapp_nutraceutical", "Indications", c => c.String(nullable: false));
            AlterColumn("dbo.biositeapp_nutraceutical", "AgainstIndications", c => c.String(nullable: false));
            AlterColumn("dbo.biositeapp_nutraceutical", "AdverseReactions", c => c.String(nullable: false));
            AlterColumn("dbo.biositeapp_nutraceutical", "DrugInteractions", c => c.String(nullable: false));
            AlterColumn("dbo.biositeapp_nutraceutical", "DescriptionDosages", c => c.String(nullable: false));
            AlterColumn("dbo.biositeapp_nutraceutical", "RecomendedDosages", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.biositeapp_nutraceutical", "RecomendedDosages", c => c.String(nullable: false, maxLength: 4000));
            AlterColumn("dbo.biositeapp_nutraceutical", "DescriptionDosages", c => c.String(nullable: false, maxLength: 4000));
            AlterColumn("dbo.biositeapp_nutraceutical", "DrugInteractions", c => c.String(nullable: false, maxLength: 4000));
            AlterColumn("dbo.biositeapp_nutraceutical", "AdverseReactions", c => c.String(nullable: false, maxLength: 4000));
            AlterColumn("dbo.biositeapp_nutraceutical", "AgainstIndications", c => c.String(nullable: false, maxLength: 4000));
            AlterColumn("dbo.biositeapp_nutraceutical", "Indications", c => c.String(nullable: false, maxLength: 4000));
            AlterColumn("dbo.biositeapp_nutraceutical", "ActionMechanism", c => c.String(nullable: false, maxLength: 4000));
            AlterColumn("dbo.biositeapp_nutraceutical", "Pharmacology", c => c.String(nullable: false, maxLength: 4000));
        }
    }
}
