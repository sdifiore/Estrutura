namespace Estrutura.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SequenciaInProductTreeTo2Chars : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ProductTrees", "Sequencia", c => c.String(maxLength: 2));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ProductTrees", "Sequencia", c => c.String(maxLength: 1));
        }
    }
}
