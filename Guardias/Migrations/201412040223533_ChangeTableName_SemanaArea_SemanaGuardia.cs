namespace Guardias.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeTableName_SemanaArea_SemanaGuardia : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.SemanaGuardias", newName: "SemanasGuardias");
            RenameTable(name: "dbo.SemanaAreas", newName: "SemanasAreas");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.SemanasAreas", newName: "SemanaAreas");
            RenameTable(name: "dbo.SemanasGuardias", newName: "SemanaGuardias");
        }
    }
}
