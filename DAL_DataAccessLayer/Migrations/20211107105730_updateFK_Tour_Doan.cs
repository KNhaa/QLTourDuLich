using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL_DataAccessLayer.Migrations
{
    public partial class updateFK_Tour_Doan : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tours_Doans_maDoan",
                table: "Tours");

            migrationBuilder.DropIndex(
                name: "IX_Tours_maDoan",
                table: "Tours");

            migrationBuilder.DropColumn(
                name: "maDoan",
                table: "Tours");

            migrationBuilder.AddColumn<int>(
                name: "maTour",
                table: "Doans",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Doans_maTour",
                table: "Doans",
                column: "maTour");

            migrationBuilder.AddForeignKey(
                name: "FK_Doans_Tours_maTour",
                table: "Doans",
                column: "maTour",
                principalTable: "Tours",
                principalColumn: "maTour",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Doans_Tours_maTour",
                table: "Doans");

            migrationBuilder.DropIndex(
                name: "IX_Doans_maTour",
                table: "Doans");

            migrationBuilder.DropColumn(
                name: "maTour",
                table: "Doans");

            migrationBuilder.AddColumn<int>(
                name: "maDoan",
                table: "Tours",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Tours_maDoan",
                table: "Tours",
                column: "maDoan");

            migrationBuilder.AddForeignKey(
                name: "FK_Tours_Doans_maDoan",
                table: "Tours",
                column: "maDoan",
                principalTable: "Doans",
                principalColumn: "maDoan",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
