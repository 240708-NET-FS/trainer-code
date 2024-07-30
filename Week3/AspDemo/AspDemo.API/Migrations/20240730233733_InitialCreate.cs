using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AspDemo.API.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Trainers",
                columns: table => new
                {
                    TrainerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trainers", x => x.TrainerId);
                });

            migrationBuilder.CreateTable(
                name: "Pokemon",
                columns: table => new
                {
                    PokemonId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DexId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OwnerTrainerId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pokemon", x => x.PokemonId);
                    table.ForeignKey(
                        name: "FK_Pokemon_Trainers_OwnerTrainerId",
                        column: x => x.OwnerTrainerId,
                        principalTable: "Trainers",
                        principalColumn: "TrainerId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pokemon_OwnerTrainerId",
                table: "Pokemon",
                column: "OwnerTrainerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pokemon");

            migrationBuilder.DropTable(
                name: "Trainers");
        }
    }
}
