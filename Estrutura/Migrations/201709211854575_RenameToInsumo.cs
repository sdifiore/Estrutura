namespace Estrutura.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RenameToInsumo : DbMigration
    {
        public override void Up()
        {
            Sql("sp_rename 'Insumoes', 'Insumos'");
        }
        
        public override void Down()
        {
        }
    }
}
