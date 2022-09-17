using Microsoft.EntityFrameworkCore.Migrations;

namespace JuntosSomosMais.Ecommerce.Infra.Migrations
{
    public partial class InserirDados : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO ENDERECO VALUES('ALDEBIADES', 'RIBEIRA', '54', '40420-021', '1 ANDAR', 'AO LADO DA PREFEITURA', 'SALVADOR', 'BA', 'BRASIL'); ");
            migrationBuilder.Sql("INSERT INTO ENDERECO VALUES('JORGE LEAO','MASSARANDUBA','99','13221-000','TERREO','PERTO DA PADARIA','FEIRA DE SANTANA','BA','BRASIL'); ");
            migrationBuilder.Sql("INSERT INTO ENDERECO VALUES('AGUAS CRISTALINAS', 'PITUBA', '33', '44433-022', 'ULTIMO ANDAR', 'AZULEJO ROSA', 'RIO DE JANEIRO', 'RJ', 'BRASIL'); ");

            migrationBuilder.Sql("INSERT INTO CLIENTE VALUES('JAMILE','1995-06-22','099.016.041-61','99134-3899','JAMJAM@GMAIL.COM','123456SJ$$',1);");
            migrationBuilder.Sql("INSERT INTO CLIENTE VALUES('RODRIGO','2002-02-13','123.011.432-66','99935-0890','DIGODIGO@GMAIL.COM','87845454SS$',2);");
            migrationBuilder.Sql("INSERT INTO CLIENTE VALUES('PAMELA','1987-05-10','155.022.99-36','98875-0369','PAMPAM@GMAIL.COM','878784541XX&',3);");

            migrationBuilder.Sql("INSERT INTO PRODUTO VALUES('CIMENTO',32.50);");
            migrationBuilder.Sql("INSERT INTO PRODUTO VALUES('ARGAMASSA',50.00);");
            migrationBuilder.Sql("INSERT INTO PRODUTO VALUES('VERGALHAO',60.00);");
            migrationBuilder.Sql("INSERT INTO PRODUTO VALUES('TUBO',25.00);");
            migrationBuilder.Sql("INSERT INTO PRODUTO VALUES('TRELICA',66.00);");
            migrationBuilder.Sql("INSERT INTO PRODUTO VALUES('IMPERMEABILIZANTE',170);");
            migrationBuilder.Sql("INSERT INTO PRODUTO VALUES('MADEIRA',80);");
            migrationBuilder.Sql("INSERT INTO PRODUTO VALUES('CAL',15);");
            migrationBuilder.Sql("INSERT INTO PRODUTO VALUES('AÇO',10);");
            migrationBuilder.Sql("INSERT INTO PRODUTO VALUES('GESSO',20);");
            migrationBuilder.Sql("INSERT INTO PRODUTO VALUES('TINTA',200);");
            migrationBuilder.Sql("INSERT INTO PRODUTO VALUES('PISO', 82);");

            migrationBuilder.Sql("INSERT INTO PEDIDO VALUES('2022-09-01',1);");
            migrationBuilder.Sql("INSERT INTO PEDIDO VALUES('2022-09-01',1);");
            migrationBuilder.Sql("INSERT INTO PEDIDO VALUES('2022-09-01',1);");

            migrationBuilder.Sql("INSERT INTO PEDIDO_PRODUTO VALUES(1,1,5);");
            migrationBuilder.Sql("INSERT INTO PEDIDO_PRODUTO VALUES(1,2,10);");
            migrationBuilder.Sql("INSERT INTO PEDIDO_PRODUTO VALUES(1,3,15);");
            migrationBuilder.Sql("INSERT INTO PEDIDO_PRODUTO VALUES(2,1,11);");
            migrationBuilder.Sql("INSERT INTO PEDIDO_PRODUTO VALUES(2,5,4);");
            migrationBuilder.Sql("INSERT INTO PEDIDO_PRODUTO VALUES(2,3,8);");
            migrationBuilder.Sql("INSERT INTO PEDIDO_PRODUTO VALUES(3,4,7);");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
