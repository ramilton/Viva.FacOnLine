namespace Viva.FacOnLine.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Inicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.FichaAtendimentoModels",
                c => new
                    {
                        NumeroFicha = c.Int(nullable: false, identity: true),
                        NomeCorretor = c.String(nullable: false),
                        Data = c.DateTime(nullable: false),
                        NomeCliente = c.String(nullable: false),
                        EmailCliente = c.String(),
                        TelRes = c.String(),
                        TelCom = c.String(),
                        Celular = c.String(nullable: false),
                        Imovel = c.String(nullable: false),
                        Endereco = c.String(nullable: false),
                        Bairro = c.String(),
                        Cidade = c.String(),
                        FonteInformacao = c.String(),
                        Contato = c.String(),
                        Agendamento = c.Boolean(nullable: false),
                        AgendamentoData = c.DateTime(nullable: false),
                        AgendamentoHora = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.NumeroFicha);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.FichaAtendimentoModels");
        }
    }
}
