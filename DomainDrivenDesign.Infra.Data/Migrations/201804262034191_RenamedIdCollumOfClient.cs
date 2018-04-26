namespace DomainDrivenDesign.Infra.Data.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class RenamedIdCollumOfClient : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Client");
            DropColumn("dbo.Client", "Id");
            AddColumn("dbo.Client", "ClientId", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Client", "ClientId");
        }

        public override void Down()
        {
            AddColumn("dbo.Client", "Id", c => c.Int(nullable: false, identity: true));
            DropPrimaryKey("dbo.Client");
            DropColumn("dbo.Client", "ClientId");
            AddPrimaryKey("dbo.Client", "Id");
        }
    }
}
