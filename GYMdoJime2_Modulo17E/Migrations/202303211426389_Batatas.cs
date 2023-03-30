namespace GYMdoJime2_Modulo17E.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Batatas : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Inscricoes",
                c => new
                    {
                        IdInscricoes = c.Int(nullable: false, identity: true),
                        idutilizadores = c.Int(nullable: false),
                        idmarcacoes = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdInscricoes)
                .ForeignKey("dbo.Utilizadores", t => t.idutilizadores, cascadeDelete: true)
                .ForeignKey("dbo.Marcacoes", t => t.idmarcacoes, cascadeDelete: true)
                .Index(t => t.idutilizadores)
                .Index(t => t.idmarcacoes);
            
            CreateTable(
                "dbo.Utilizadores",
                c => new
                    {
                        IDUtilizador = c.Int(nullable: false, identity: true),
                        nome = c.String(nullable: false),
                        email = c.String(nullable: false),
                        idade = c.String(nullable: false),
                        perfil = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IDUtilizador);
            
            CreateTable(
                "dbo.Marcacoes",
                c => new
                    {
                        MarcacoesID = c.Int(nullable: false, identity: true),
                        MarcacoesDataHora = c.DateTime(nullable: false),
                        Treinadores = c.Int(nullable: false),
                        Sala = c.Int(nullable: false),
                        TipoAula = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MarcacoesID)
                .ForeignKey("dbo.Salas", t => t.Sala, cascadeDelete: true)
                .ForeignKey("dbo.TipoAulas", t => t.TipoAula, cascadeDelete: true)
                .ForeignKey("dbo.Treinadores", t => t.Treinadores, cascadeDelete: true)
                .Index(t => t.Treinadores)
                .Index(t => t.Sala)
                .Index(t => t.TipoAula);
            
            CreateTable(
                "dbo.Salas",
                c => new
                    {
                        SalaID = c.Int(nullable: false, identity: true),
                        NomeSala = c.String(nullable: false),
                        EstadoSala = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.SalaID);
            
            CreateTable(
                "dbo.TipoAulas",
                c => new
                    {
                        TipoAulaID = c.Int(nullable: false, identity: true),
                        NomeAula = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.TipoAulaID);
            
            CreateTable(
                "dbo.Treinadores",
                c => new
                    {
                        TreinadoresID = c.Int(nullable: false, identity: true),
                        TreinadoresName = c.String(nullable: false, maxLength: 80),
                        TreinadoresIdade = c.String(nullable: false, maxLength: 2),
                        TreinadoresEmail = c.String(nullable: false),
                        TreinadoresTelefone = c.String(nullable: false, maxLength: 9),
                        TreinadoresEstado = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.TreinadoresID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Inscricoes", "idmarcacoes", "dbo.Marcacoes");
            DropForeignKey("dbo.Marcacoes", "Treinadores", "dbo.Treinadores");
            DropForeignKey("dbo.Marcacoes", "TipoAula", "dbo.TipoAulas");
            DropForeignKey("dbo.Marcacoes", "Sala", "dbo.Salas");
            DropForeignKey("dbo.Inscricoes", "idutilizadores", "dbo.Utilizadores");
            DropIndex("dbo.Marcacoes", new[] { "TipoAula" });
            DropIndex("dbo.Marcacoes", new[] { "Sala" });
            DropIndex("dbo.Marcacoes", new[] { "Treinadores" });
            DropIndex("dbo.Inscricoes", new[] { "idmarcacoes" });
            DropIndex("dbo.Inscricoes", new[] { "idutilizadores" });
            DropTable("dbo.Treinadores");
            DropTable("dbo.TipoAulas");
            DropTable("dbo.Salas");
            DropTable("dbo.Marcacoes");
            DropTable("dbo.Utilizadores");
            DropTable("dbo.Inscricoes");
        }
    }
}
