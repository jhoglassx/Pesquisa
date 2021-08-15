using Microsoft.EntityFrameworkCore.Migrations;

namespace Pesquisa.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ConvenioList",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ConvenioNome = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConvenioList", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FaixaIdade",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FaixaIdade = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FaixaIdade", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FaixaSalario",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FaixaSalarial = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FaixaSalario", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MotivoEmprestimo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmprestimoMotivo = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MotivoEmprestimo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Enquete",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FaixaSalarioId = table.Column<int>(type: "int", nullable: false),
                    MotivoEmprestimoId = table.Column<int>(type: "int", nullable: false),
                    ConvenioListId = table.Column<int>(type: "int", nullable: false),
                    FaixaIdadeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enquete", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Enquete_ConvenioList_ConvenioListId",
                        column: x => x.ConvenioListId,
                        principalTable: "ConvenioList",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Enquete_FaixaIdade_FaixaIdadeId",
                        column: x => x.FaixaIdadeId,
                        principalTable: "FaixaIdade",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Enquete_FaixaSalario_FaixaSalarioId",
                        column: x => x.FaixaSalarioId,
                        principalTable: "FaixaSalario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Enquete_MotivoEmprestimo_MotivoEmprestimoId",
                        column: x => x.MotivoEmprestimoId,
                        principalTable: "MotivoEmprestimo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Enquete_ConvenioListId",
                table: "Enquete",
                column: "ConvenioListId");

            migrationBuilder.CreateIndex(
                name: "IX_Enquete_FaixaIdadeId",
                table: "Enquete",
                column: "FaixaIdadeId");

            migrationBuilder.CreateIndex(
                name: "IX_Enquete_FaixaSalarioId",
                table: "Enquete",
                column: "FaixaSalarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Enquete_MotivoEmprestimoId",
                table: "Enquete",
                column: "MotivoEmprestimoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Enquete");

            migrationBuilder.DropTable(
                name: "ConvenioList");

            migrationBuilder.DropTable(
                name: "FaixaIdade");

            migrationBuilder.DropTable(
                name: "FaixaSalario");

            migrationBuilder.DropTable(
                name: "MotivoEmprestimo");
        }
    }
}
