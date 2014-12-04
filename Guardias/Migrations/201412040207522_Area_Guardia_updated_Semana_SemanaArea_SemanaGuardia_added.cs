namespace Guardias.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Area_Guardia_updated_Semana_SemanaArea_SemanaGuardia_added : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SemanaGuardias",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SemanaId = c.Int(nullable: false),
                        GuardiaId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Guardias", t => t.GuardiaId, cascadeDelete: true)
                .ForeignKey("dbo.Semanas", t => t.SemanaId, cascadeDelete: true)
                .Index(t => t.SemanaId)
                .Index(t => t.GuardiaId);
            
            CreateTable(
                "dbo.Semanas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Numero = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SemanaAreas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Posicion = c.Int(nullable: false),
                        SemanaId = c.Int(nullable: false),
                        AreaId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Areas", t => t.AreaId, cascadeDelete: true)
                .ForeignKey("dbo.Semanas", t => t.SemanaId, cascadeDelete: true)
                .Index(t => t.SemanaId)
                .Index(t => t.AreaId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SemanaGuardias", "SemanaId", "dbo.Semanas");
            DropForeignKey("dbo.SemanaAreas", "SemanaId", "dbo.Semanas");
            DropForeignKey("dbo.SemanaAreas", "AreaId", "dbo.Areas");
            DropForeignKey("dbo.SemanaGuardias", "GuardiaId", "dbo.Guardias");
            DropIndex("dbo.SemanaAreas", new[] { "AreaId" });
            DropIndex("dbo.SemanaAreas", new[] { "SemanaId" });
            DropIndex("dbo.SemanaGuardias", new[] { "GuardiaId" });
            DropIndex("dbo.SemanaGuardias", new[] { "SemanaId" });
            DropTable("dbo.SemanaAreas");
            DropTable("dbo.Semanas");
            DropTable("dbo.SemanaGuardias");
        }
    }
}
