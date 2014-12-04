namespace Guardias.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeUnidadTableName : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Unidads", newName: "Unidades");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Unidades", newName: "Unidads");
        }
    }
}
