namespace Estrutura.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemovedLineFromProductTree : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.ProductTrees", "UnConsComp");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ProductTrees", "UnConsComp", c => c.String(maxLength: 2));
        }
    }
}
