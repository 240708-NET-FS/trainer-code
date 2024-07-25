using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AspDemoApi.Migrations
{
    /// <inheritdoc />
    public partial class TrainerNull : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pokemon_Trainers_OwnerTrainerId",
                table: "Pokemon");

            migrationBuilder.AlterColumn<int>(
                name: "OwnerTrainerId",
                table: "Pokemon",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Pokemon_Trainers_OwnerTrainerId",
                table: "Pokemon",
                column: "OwnerTrainerId",
                principalTable: "Trainers",
                principalColumn: "TrainerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pokemon_Trainers_OwnerTrainerId",
                table: "Pokemon");

            migrationBuilder.AlterColumn<int>(
                name: "OwnerTrainerId",
                table: "Pokemon",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Pokemon_Trainers_OwnerTrainerId",
                table: "Pokemon",
                column: "OwnerTrainerId",
                principalTable: "Trainers",
                principalColumn: "TrainerId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
