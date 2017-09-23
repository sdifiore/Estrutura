namespace Estrutura.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddKeyProductKeyAsIdRemovedCodigoKey : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.ProductTrees");
            AddColumn("dbo.ProductTrees", "Id", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.ProductTrees", "Codigo", c => c.String(maxLength: 10));
            AddPrimaryKey("dbo.ProductTrees", "Id");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.ProductTrees");
            AlterColumn("dbo.ProductTrees", "Codigo", c => c.String(nullable: false, maxLength: 10));
            DropColumn("dbo.ProductTrees", "Id");
            AddPrimaryKey("dbo.ProductTrees", "Codigo");
        }
    }
}
