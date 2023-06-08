using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FootballLeagueApp.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class init6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Standings_TeamId",
                table: "Standings");

            migrationBuilder.AlterColumn<int>(
                name: "TeamId",
                table: "Standings",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Standings_TeamId",
                table: "Standings",
                column: "TeamId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Standings_TeamId",
                table: "Standings");

            migrationBuilder.AlterColumn<int>(
                name: "TeamId",
                table: "Standings",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Standings_TeamId",
                table: "Standings",
                column: "TeamId",
                unique: true,
                filter: "[TeamId] IS NOT NULL");
        }
    }
}
