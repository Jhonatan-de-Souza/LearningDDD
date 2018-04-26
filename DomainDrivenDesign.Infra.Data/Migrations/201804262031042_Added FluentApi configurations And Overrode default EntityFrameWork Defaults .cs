namespace DomainDrivenDesign.Infra.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedFluentApiconfigurationsAndOverrodedefaultEntityFrameWorkDefaults : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Clients", newName: "Client");
            AlterColumn("dbo.Client", "Name", c => c.String(nullable: false, maxLength: 150, unicode: false));
            AlterColumn("dbo.Client", "Surname", c => c.String(nullable: false, maxLength: 150, unicode: false));
            AlterColumn("dbo.Client", "Email", c => c.String(nullable: false, maxLength: 249, unicode: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Client", "Email", c => c.String());
            AlterColumn("dbo.Client", "Surname", c => c.String());
            AlterColumn("dbo.Client", "Name", c => c.String());
            RenameTable(name: "dbo.Client", newName: "Clients");
        }
    }
}
