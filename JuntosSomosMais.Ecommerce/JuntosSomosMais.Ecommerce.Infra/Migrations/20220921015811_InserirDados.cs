using Microsoft.EntityFrameworkCore.Migrations;

namespace JuntosSomosMais.Ecommerce.Infra.Migrations
{
    public partial class InserirDados : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO ENDERECOS VALUES(1, 'TRAVESSA ATLANTIDA', 'REMEDIOS', '788', '68927-060', '1 ANDAR', 'AO LADO DA PREFEITURA', 'SANTANA', 'AP', 'BRASIL');");
            migrationBuilder.Sql("INSERT INTO ENDERECOS VALUES(2, 'PROFESSOR DOUTOR MAX KAUFMANN','JARDIM COLONIAL','453','13087-690','TERREO','PERTO DA PADARIA','CAMPINAS','SP','BRASIL');");

            migrationBuilder.Sql("INSERT INTO CLIENTES VALUES(1, 'JAMILE DAMASCENO BRANDAO','1995-06-22','099.016.041-61','99134-3899','JAMJAM@GMAIL.COM','123456SJ$$',1);");
            migrationBuilder.Sql("INSERT INTO CLIENTES VALUES(2, 'RODRIGO ARAUJO SANTOS','2002-02-13','123.011.432-66','99935-0890','DIGODIGO@GMAIL.COM','87845454SS$',2);");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
