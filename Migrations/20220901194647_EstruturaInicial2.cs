using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VoeAirlines.Migrations
{
    public partial class EstruturaInicial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Canecelamentos");

            migrationBuilder.DropTable(
                name: "Voos");

            migrationBuilder.DropTable(
                name: "Pilotos");

            migrationBuilder.AlterColumn<string>(
                name: "Observacoes",
                table: "Manutencao",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Modelo",
                table: "Aeronaves",
                type: "nvarchar(40)",
                maxLength: 40,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Fabricante",
                table: "Aeronaves",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Codigo",
                table: "Aeronaves",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "Tipo",
                table: "Aeronaves",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Piloto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    VooId = table.Column<int>(type: "int", nullable: false),
                    Matricula = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Piloto", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Voo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Origem = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Destino = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataHoraPartida = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataHoraChegada = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AeronaveId = table.Column<int>(type: "int", nullable: false),
                    PilotoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Voo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Voo_Aeronaves_AeronaveId",
                        column: x => x.AeronaveId,
                        principalTable: "Aeronaves",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Voo_Piloto_PilotoId",
                        column: x => x.PilotoId,
                        principalTable: "Piloto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cancelamento",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Motivo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DataHoraNotificacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    VooId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cancelamento", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cancelamento_Voo_VooId",
                        column: x => x.VooId,
                        principalTable: "Voo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Manutencao_Observacoes",
                table: "Manutencao",
                column: "Observacoes",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Cancelamento_VooId",
                table: "Cancelamento",
                column: "VooId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Piloto_Matricula",
                table: "Piloto",
                column: "Matricula",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Voo_AeronaveId",
                table: "Voo",
                column: "AeronaveId");

            migrationBuilder.CreateIndex(
                name: "IX_Voo_DataHoraChegada",
                table: "Voo",
                column: "DataHoraChegada",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Voo_PilotoId",
                table: "Voo",
                column: "PilotoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cancelamento");

            migrationBuilder.DropTable(
                name: "Voo");

            migrationBuilder.DropTable(
                name: "Piloto");

            migrationBuilder.DropIndex(
                name: "IX_Manutencao_Observacoes",
                table: "Manutencao");

            migrationBuilder.DropColumn(
                name: "Tipo",
                table: "Aeronaves");

            migrationBuilder.AlterColumn<string>(
                name: "Observacoes",
                table: "Manutencao",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "Modelo",
                table: "Aeronaves",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(40)",
                oldMaxLength: 40);

            migrationBuilder.AlterColumn<string>(
                name: "Fabricante",
                table: "Aeronaves",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Codigo",
                table: "Aeronaves",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(25)",
                oldMaxLength: 25);

            migrationBuilder.CreateTable(
                name: "Pilotos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Matricula = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VooId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pilotos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Voos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AeronaveId = table.Column<int>(type: "int", nullable: false),
                    PilotoId = table.Column<int>(type: "int", nullable: false),
                    DataHoraChegada = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataHoraPartida = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Destino = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Origem = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Voos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Voos_Aeronaves_AeronaveId",
                        column: x => x.AeronaveId,
                        principalTable: "Aeronaves",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Voos_Pilotos_PilotoId",
                        column: x => x.PilotoId,
                        principalTable: "Pilotos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Canecelamentos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VooId = table.Column<int>(type: "int", nullable: false),
                    DataHoraNotificacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Motivo = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Canecelamentos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Canecelamentos_Voos_VooId",
                        column: x => x.VooId,
                        principalTable: "Voos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Canecelamentos_VooId",
                table: "Canecelamentos",
                column: "VooId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Voos_AeronaveId",
                table: "Voos",
                column: "AeronaveId");

            migrationBuilder.CreateIndex(
                name: "IX_Voos_PilotoId",
                table: "Voos",
                column: "PilotoId");
        }
    }
}
