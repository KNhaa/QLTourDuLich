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
                name: "Tours",
                columns: table => new
                {
                    maTour = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tenTour = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    khachSan = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    noiDungTour = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    dacDiem = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    trangThai = table.Column<bool>(type: "bit", nullable: false),
                    maLoaiHinh = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tours", x => x.maTour);
                    table.ForeignKey(
                        name: "FK_Tours_LoaiHinhDuLichs_maLoaiHinh",
                        column: x => x.maLoaiHinh,
                        principalTable: "LoaiHinhDuLichs",
                        principalColumn: "maLoaiHinh",
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
                    maTour = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doans", x => x.maDoan);
                    table.ForeignKey(
                        name: "FK_Doans_Tours_maTour",
                        column: x => x.maTour,
                        principalTable: "Tours",
                        principalColumn: "maTour",
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

            migrationBuilder.CreateTable(
                name: "ChiPhis",
                columns: table => new
                {
                    maChiPhi = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    soTien = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    maDoan = table.Column<int>(type: "int", nullable: false),
                    maLoaiCP = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiPhis", x => x.maChiPhi);
                    table.ForeignKey(
                        name: "FK_ChiPhis_Doans_maDoan",
                        column: x => x.maDoan,
                        principalTable: "Doans",
                        principalColumn: "maDoan",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChiPhis_LoaiChiPhis_maLoaiCP",
                        column: x => x.maLoaiCP,
                        principalTable: "LoaiChiPhis",
                        principalColumn: "maLoaiCP",
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

            migrationBuilder.InsertData(
                table: "DiaDiems",
                columns: new[] { "maDiaDiem", "tenDiaDiem" },
                values: new object[,]
                {
                    { 1, "Địa Điểm 1" },
                    { 2, "Địa Điểm 2" },
                    { 3, "Địa Điểm 3" },
                    { 4, "Địa Điểm 4" },
                    { 5, "Địa Điểm 5" },
                    { 6, "Địa Điểm 6" }
                });

            migrationBuilder.InsertData(
                table: "LoaiHinhDuLichs",
                columns: new[] { "maLoaiHinh", "tenLoaiHinh" },
                values: new object[,]
                {
                    { 1, "Du lịch tham quan" },
                    { 2, "Du lịch văn hóa" },
                    { 3, "Du lịch ẩm thực" },
                    { 4, "Du lịch xanh" }
                });

            migrationBuilder.InsertData(
                table: "Tours",
                columns: new[] { "maTour", "dacDiem", "khachSan", "maLoaiHinh", "noiDungTour", "tenTour", "trangThai" },
                values: new object[,]
                {
                    { 1, "Đặc điểm 1", "Khách Sạn 1", 1, "Nội dung tour", "Tên Tour 1", true },
                    { 2, "Đặc điểm 1", "Khách Sạn 2", 2, "Nội dung tour", "Tên Tour 2", true },
                    { 3, "Đặc điểm 3", "Khách Sạn 3", 2, "Nội dung tour", "Tên Tour 3", true },
                    { 4, "Đặc điểm 1", "Khách Sạn 2", 2, "Nội dung tour", "Tên Tour 2", true }
                });

            migrationBuilder.InsertData(
                table: "Doans",
                columns: new[] { "maDoan", "doanhThu", "maTour", "ngayKetThuc", "ngayKhoiHanh" },
                values: new object[,]
                {
                    { 2, 0f, 1, new DateTime(2021, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 0f, 2, new DateTime(2021, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, 0f, 3, new DateTime(2021, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1, 0f, 4, new DateTime(2021, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ChiPhis_maDoan",
                table: "ChiPhis",
                column: "maDoan");

            migrationBuilder.CreateIndex(
                name: "IX_ChiPhis_maLoaiCP",
                table: "ChiPhis",
                column: "maLoaiCP");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTiets_maKh",
                table: "ChiTiets",
                column: "maKh");

            migrationBuilder.CreateIndex(
                name: "IX_Doans_maTour",
                table: "Doans",
                column: "maTour");

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
                name: "IX_Tours_maLoaiHinh",
                table: "Tours",
                column: "maLoaiHinh");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChiPhis");

            migrationBuilder.DropTable(
                name: "ChiTiets");

            migrationBuilder.DropTable(
                name: "GiaTours");

            migrationBuilder.DropTable(
                name: "PhanBos");

            migrationBuilder.DropTable(
                name: "ThamQuans");

            migrationBuilder.DropTable(
                name: "LoaiChiPhis");

            migrationBuilder.DropTable(
                name: "Khachs");

            migrationBuilder.DropTable(
                name: "Doans");

            migrationBuilder.DropTable(
                name: "NhanViens");

            migrationBuilder.DropTable(
                name: "DiaDiems");

            migrationBuilder.DropTable(
                name: "Tours");

            migrationBuilder.DropTable(
                name: "LoaiHinhDuLichs");
        }
    }
}
