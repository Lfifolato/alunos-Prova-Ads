using Microsoft.EntityFrameworkCore.Migrations;

namespace alunos_Prova_Ads.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Alunos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cpf = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    curso = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    idade = table.Column<int>(type: "int", nullable: false),
                    nomeFaculdade = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alunos", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Alunos",
                columns: new[] { "Id", "cpf", "curso", "idade", "nome", "nomeFaculdade" },
                values: new object[,]
                {
                    { 1, "66565656", "ADS", 22, "Luiz Henrique", "Reges" },
                    { 2, "65656565", "ADM", 28, "Andre", "UNIP" },
                    { 3, "87454545", "CUlinaria", 30, "Danilo", "Comida Boa" },
                    { 4, "61656565", "Power Bi", 22, "Pedro", "mais mais" },
                    { 5, "988989898", "Execel", 22, "Hariel", "data" },
                    { 6, "66565656", "Web", 22, "Tiago", "Reges" },
                    { 7, "66565656", "TESTE", 22, "Lucas", "Reges" },
                    { 8, "5457485787", "jS", 22, "Guilherme", "Reges" },
                    { 9, "66565656", "TESTE", 22, "Paulo", "ffff" },
                    { 10, "66565656", "ffff", 22, "Rafael", "Reges" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Alunos");
        }
    }
}
