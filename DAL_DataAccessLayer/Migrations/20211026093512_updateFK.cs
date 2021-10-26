using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL_DataAccessLayer.Migrations
{
    public partial class updateFK : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Doans_ChiPhis_maChiPhi",
                table: "Doans");

            migrationBuilder.DropIndex(
                name: "IX_Doans_maChiPhi",
                table: "Doans");

            migrationBuilder.DropColumn(
                name: "maChiPhi",
                table: "Doans");

            migrationBuilder.AddColumn<int>(
                name: "maDoan",
                table: "ChiPhis",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_ChiPhis_maDoan",
                table: "ChiPhis",
                column: "maDoan");

            migrationBuilder.AddForeignKey(
                name: "FK_ChiPhis_Doans_maDoan",
                table: "ChiPhis",
                column: "maDoan",
                principalTable: "Doans",
                principalColumn: "maDoan",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ChiPhis_Doans_maDoan",
                table: "ChiPhis");

            migrationBuilder.DropIndex(
                name: "IX_ChiPhis_maDoan",
                table: "ChiPhis");

            migrationBuilder.DropColumn(
                name: "maDoan",
                table: "ChiPhis");

            migrationBuilder.AddColumn<int>(
                name: "maChiPhi",
                table: "Doans",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Doans_maChiPhi",
                table: "Doans",
                column: "maChiPhi");

            migrationBuilder.AddForeignKey(
                name: "FK_Doans_ChiPhis_maChiPhi",
                table: "Doans",
                column: "maChiPhi",
                principalTable: "ChiPhis",
                principalColumn: "maChiPhi",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
