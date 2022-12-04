using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Train1.Migrations
{
    /// <inheritdoc />
    public partial class AddFrKey : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ThongTinPhim",
                table: "ThongTinPhim");

            migrationBuilder.AddColumn<Guid>(
                name: "MaKhachHang",
                table: "Ve",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "MaNhanVien",
                table: "Ve",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "MaCTPhim",
                table: "ThongTinPhim",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddPrimaryKey(
                name: "PK_ThongTinPhim",
                table: "ThongTinPhim",
                column: "MaCTPhim");

            migrationBuilder.CreateIndex(
                name: "IX_Ve_MaKhachHang",
                table: "Ve",
                column: "MaKhachHang");

            migrationBuilder.CreateIndex(
                name: "IX_Ve_MaNhanVien",
                table: "Ve",
                column: "MaNhanVien");

            migrationBuilder.CreateIndex(
                name: "IX_ThongTinPhim_MaPhim",
                table: "ThongTinPhim",
                column: "MaPhim");

            migrationBuilder.AddForeignKey(
                name: "FK_ThongTinPhim_Phim_MaPhim",
                table: "ThongTinPhim",
                column: "MaPhim",
                principalTable: "Phim",
                principalColumn: "MaPhim",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Ve_KhachHang_MaKhachHang",
                table: "Ve",
                column: "MaKhachHang",
                principalTable: "KhachHang",
                principalColumn: "MaKhachHang",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Ve_NhanVien_MaNhanVien",
                table: "Ve",
                column: "MaNhanVien",
                principalTable: "NhanVien",
                principalColumn: "MaNhanVien",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ThongTinPhim_Phim_MaPhim",
                table: "ThongTinPhim");

            migrationBuilder.DropForeignKey(
                name: "FK_Ve_KhachHang_MaKhachHang",
                table: "Ve");

            migrationBuilder.DropForeignKey(
                name: "FK_Ve_NhanVien_MaNhanVien",
                table: "Ve");

            migrationBuilder.DropIndex(
                name: "IX_Ve_MaKhachHang",
                table: "Ve");

            migrationBuilder.DropIndex(
                name: "IX_Ve_MaNhanVien",
                table: "Ve");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ThongTinPhim",
                table: "ThongTinPhim");

            migrationBuilder.DropIndex(
                name: "IX_ThongTinPhim_MaPhim",
                table: "ThongTinPhim");

            migrationBuilder.DropColumn(
                name: "MaKhachHang",
                table: "Ve");

            migrationBuilder.DropColumn(
                name: "MaNhanVien",
                table: "Ve");

            migrationBuilder.DropColumn(
                name: "MaCTPhim",
                table: "ThongTinPhim");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ThongTinPhim",
                table: "ThongTinPhim",
                column: "MaPhim");
        }
    }
}
