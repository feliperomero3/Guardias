namespace Guardias.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Areas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Apodo = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Guardias",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Fecha = c.DateTime(nullable: false),
                        UnidadId = c.Int(nullable: false),
                        AreaId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Areas", t => t.AreaId, cascadeDelete: true)
                .ForeignKey("dbo.Unidads", t => t.UnidadId, cascadeDelete: true)
                .Index(t => t.UnidadId)
                .Index(t => t.AreaId);
            
            CreateTable(
                "dbo.Unidads",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Numero = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Guardias", "UnidadId", "dbo.Unidads");
            DropForeignKey("dbo.Guardias", "AreaId", "dbo.Areas");
            DropIndex("dbo.Guardias", new[] { "AreaId" });
            DropIndex("dbo.Guardias", new[] { "UnidadId" });
            DropTable("dbo.Unidads");
            DropTable("dbo.Guardias");
            DropTable("dbo.Areas");
        }
    }
}
