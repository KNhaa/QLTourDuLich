using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL_DataAccessLayer.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DiaDiems",
                columns: table => new
                {
                    maDiaDiem = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tenDiaDiem = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiaDiems", x => x.maDiaDiem);
                });

            migrationBuilder.CreateTable(
                name: "Khachs",
                columns: table => new
                {
                    maKh = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tenKh = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    diaChi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cnmd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    gioiTinh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    sdt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    quocTich = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Khachs", x => x.maKh);
                });

            migrationBuilder.CreateTable(
                name: "LoaiChiPhis",
                columns: table => new
                {
                    maLoaiCP = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tenLoaiCP = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoaiChiPhis", x => x.maLoaiCP);
                });

            migrationBuilder.CreateTable(
                name: "LoaiHinhDuLichs",
                columns: table => new
                {
                    maLoaiHinh = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tenLoaiHinh = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoaiHinhDuLichs", x => x.maLoaiHinh);
                });

            migrationBuilder.CreateTable(
                name: "NhanViens",
                columns: table => new
                {
                    maNv = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tenNv = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhanViens", x => x.maNv);
                });

            migrationBuilder.CreateTable(
                name: "ChiPhis",
                columns: table => new
                {
                    maChiPhi = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    soTien = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    maLoaiCP = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiPhis", x => x.maChiPhi);
                    table.ForeignKey(
                        name: "FK_ChiPhis_LoaiChiPhis_maLoaiCP",
                        column: x => x.maLoaiCP,
                        principalTable: "LoaiChiPhis",
                        principalColumn: "maLoaiCP",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Doans",
                columns: table => new
                {
                    maDoan = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ngayKhoiHanh = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ngayKetThuc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    doanhThu = table.Column<float>(type: "real", nullable: false),
                    maChiPhi = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doans", x => x.maDoan);
                    table.ForeignKey(
                        name: "FK_Doans_ChiPhis_maChiPhi",
                        column: x => x.maChiPhi,
                        principalTable: "ChiPhis",
                        principalColumn: "maChiPhi",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ChiTiets",
                columns: table => new
                {
                    maDoan = table.Column<int>(type: "int", nullable: false),
                    maKh = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiTiets", x => new { x.maDoan, x.maKh });
                    table.ForeignKey(
                        name: "FK_ChiTiets_Doans_maDoan",
                        column: x => x.maDoan,
                        principalTable: "Doans",
                        principalColumn: "maDoan",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChiTiets_Khachs_maKh",
                        column: x => x.maKh,
                        principalTable: "Khachs",
                        principalColumn: "maKh",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PhanBos",
                columns: table => new
                {
                    maNv = table.Column<int>(type: "int", nullable: false),
                    maDoan = table.Column<int>(type: "int", nullable: false),
                    nhiemVu = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhanBos", x => new { x.maNv, x.maDoan });
                    table.ForeignKey(
                        name: "FK_PhanBos_Doans_maDoan",
                        column: x => x.maDoan,
                        principalTable: "Doans",
                        principalColumn: "maDoan",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PhanBos_NhanViens_maNv",
                        column: x => x.maNv,
                        principalTable: "NhanViens",
                        principalColumn: "maNv",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tours",
                columns: table => new
                {
                    maTour = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tenTour = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    khachSan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    noiDungTour = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    dacDiem = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    trangThai = table.Column<bool>(type: "bit", nullable: false),
                    maDoan = table.Column<int>(type: "int", nullable: false),
                    maLoaiHinh = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tours", x => x.maTour);
                    table.ForeignKey(
                        name: "FK_Tours_Doans_maDoan",
                        column: x => x.maDoan,
                        principalTable: "Doans",
                        principalColumn: "maDoan",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tours_LoaiHinhDuLichs_maLoaiHinh",
                        column: x => x.maLoaiHinh,
                        principalTable: "LoaiHinhDuLichs",
                        principalColumn: "maLoaiHinh",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GiaTours",
                columns: table => new
                {
                    maGiaTour = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ngayKhoiHanh = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ngayKetThuc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    thanhTien = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    maTour = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GiaTours", x => x.maGiaTour);
                    table.ForeignKey(
                        name: "FK_GiaTours_Tours_maTour",
                        column: x => x.maTour,
                        principalTable: "Tours",
                        principalColumn: "maTour",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ThamQuans",
                columns: table => new
                {
                    maDiaDiem = table.Column<int>(type: "int", nullable: false),
                    maTour = table.Column<int>(type: "int", nullable: false),
                    thuTuThamQuan = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThamQuans", x => new { x.maDiaDiem, x.maTour });
                    table.ForeignKey(
                        name: "FK_ThamQuans_DiaDiems_maDiaDiem",
                        column: x => x.maDiaDiem,
                        principalTable: "DiaDiems",
                        principalColumn: "maDiaDiem",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ThamQuans_Tours_maTour",
                        column: x => x.maTour,
                        principalTable: "Tours",
                        principalColumn: "maTour",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ChiPhis_maLoaiCP",
                table: "ChiPhis",
                column: "maLoaiCP");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTiets_maKh",
                table: "ChiTiets",
                column: "maKh");

            migrationBuilder.CreateIndex(
                name: "IX_Doans_maChiPhi",
                table: "Doans",
                column: "maChiPhi");

            migrationBuilder.CreateIndex(
                name: "IX_GiaTours_maTour",
                table: "GiaTours",
                column: "maTour");

            migrationBuilder.CreateIndex(
                name: "IX_PhanBos_maDoan",
                table: "PhanBos",
                column: "maDoan");

            migrationBuilder.CreateIndex(
                name: "IX_ThamQuans_maTour",
                table: "ThamQuans",
                column: "maTour");

            migrationBuilder.CreateIndex(
                name: "IX_Tours_maDoan",
                table: "Tours",
                column: "maDoan");

            migrationBuilder.CreateIndex(
                name: "IX_Tours_maLoaiHinh",
                table: "Tours",
                column: "maLoaiHinh");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChiTiets");

            migrationBuilder.DropTable(
                name: "GiaTours");

            migrationBuilder.DropTable(
                name: "PhanBos");

            migrationBuilder.DropTable(
                name: "ThamQuans");

            migrationBuilder.DropTable(
                name: "Khachs");

            migrationBuilder.DropTable(
                name: "NhanViens");

            migrationBuilder.DropTable(
                name: "DiaDiems");

            migrationBuilder.DropTable(
                name: "Tours");

            migrationBuilder.DropTable(
                name: "Doans");

            migrationBuilder.DropTable(
                name: "LoaiHinhDuLichs");

            migrationBuilder.DropTable(
                name: "ChiPhis");

            migrationBuilder.DropTable(
                name: "LoaiChiPhis");
        }
    }
}
