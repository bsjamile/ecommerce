using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JuntosSomosMais.Ecommerce.Infra.Migrations
{
    public partial class CriarBancoDeDados : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "enderecos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Rua = table.Column<string>(type: "VARCHAR(70)", nullable: false),
                    Bairro = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    Numero = table.Column<string>(type: "VARCHAR(10)", nullable: false),
                    Cep = table.Column<string>(type: "VARCHAR(15)", nullable: false),
                    Complemento = table.Column<string>(type: "VARCHAR(50)", nullable: true),
                    PontoDeReferencia = table.Column<string>(type: "VARCHAR(100)", nullable: true),
                    Cidade = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    Estado = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    Pais = table.Column<string>(type: "VARCHAR(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_enderecos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "produtos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    Preco = table.Column<double>(type: "FLOAT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_produtos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "clientes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "VARCHAR(70)", nullable: false),
                    DataNasc = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    CPF = table.Column<string>(type: "VARCHAR(20)", nullable: false),
                    Telefone = table.Column<string>(type: "VARCHAR(20)", nullable: false),
                    Email = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    Senha = table.Column<string>(type: "VARCHAR(20)", nullable: false),
                    IdEndereco = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_clientes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_clientes_enderecos_IdEndereco",
                        column: x => x.IdEndereco,
                        principalTable: "enderecos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "pedidos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DataPedido = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    IdCliente = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pedidos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_pedidos_clientes_IdCliente",
                        column: x => x.IdCliente,
                        principalTable: "clientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "pedidos_produtos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    IdPedido = table.Column<int>(type: "INTEGER", nullable: false),
                    IdProduto = table.Column<int>(type: "INTEGER", nullable: false),
                    Quantidade = table.Column<int>(type: "INT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pedidos_produtos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_pedidos_produtos_pedidos_IdPedido",
                        column: x => x.IdPedido,
                        principalTable: "pedidos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_pedidos_produtos_produtos_IdProduto",
                        column: x => x.IdProduto,
                        principalTable: "produtos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_clientes_IdEndereco",
                table: "clientes",
                column: "IdEndereco",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_pedidos_IdCliente",
                table: "pedidos",
                column: "IdCliente");

            migrationBuilder.CreateIndex(
                name: "IX_pedidos_produtos_IdPedido",
                table: "pedidos_produtos",
                column: "IdPedido");

            migrationBuilder.CreateIndex(
                name: "IX_pedidos_produtos_IdProduto",
                table: "pedidos_produtos",
                column: "IdProduto");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "pedidos_produtos");

            migrationBuilder.DropTable(
                name: "pedidos");

            migrationBuilder.DropTable(
                name: "produtos");

            migrationBuilder.DropTable(
                name: "clientes");

            migrationBuilder.DropTable(
                name: "enderecos");
        }
    }
}
