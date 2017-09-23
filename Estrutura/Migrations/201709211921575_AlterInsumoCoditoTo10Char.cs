namespace Estrutura.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlterInsumoCoditoTo10Char : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Insumoes", "Codigo", c => c.String(maxLength: 10));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Insumoes", "Codigo", c => c.String(maxLength: 6));
        }
    }
}
