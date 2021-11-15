
using DAL_DataAccessLayer.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_DataAccessLayer.DatabaseContext
{
    public class QuanLiTourDbContext : DbContext
    {
       protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            //thay đổi thành .\SQLEXPRESS để có thể tạo database trong SQL Server của mình
            options.UseSqlServer(@"Data Source=localhost ;Initial Catalog=EFExample; Integrated Security=True");

           
        }
        protected override void OnModelCreating(ModelBuilder builder)
        { 

            builder.Entity<ChiTiet>().HasKey(table => new {
                table.maDoan,
                table.maKh
            });

            builder.Entity<PhanBo>().HasKey(table => new {
                table.maNv,
                table.maDoan
            });
            builder.Entity<ThamQuan>().HasKey(table => new {
                table.maDiaDiem,
                table.maTour
            });

            //seed data
            builder.Entity<DiaDiem>().HasData(
                new DiaDiem { maDiaDiem = 1, tenDiaDiem = "Địa Điểm 1"},
                new DiaDiem { maDiaDiem = 2, tenDiaDiem = "Địa Điểm 2" },
                new DiaDiem { maDiaDiem = 3, tenDiaDiem = "Địa Điểm 3" },
                new DiaDiem { maDiaDiem = 4, tenDiaDiem = "Địa Điểm 4" },
                new DiaDiem { maDiaDiem = 5, tenDiaDiem = "Địa Điểm 5" },
                new DiaDiem { maDiaDiem = 6, tenDiaDiem = "Địa Điểm 6" }
            );

            builder.Entity<Doan>().HasData(
                new Doan { maDoan = 1, ngayKhoiHanh = new DateTime(2021,11,1), ngayKetThuc = new DateTime(2021,11,6), maTour = 4 },
                new Doan { maDoan = 2, ngayKhoiHanh = new DateTime(2021, 11, 1), ngayKetThuc = new DateTime(2021, 11, 6), maTour = 1 },
                new Doan { maDoan = 3, ngayKhoiHanh = new DateTime(2021, 11, 1), ngayKetThuc = new DateTime(2021, 11, 6), maTour = 2 },
                new Doan { maDoan = 4, ngayKhoiHanh = new DateTime(2021, 11, 1), ngayKetThuc = new DateTime(2021, 11, 6), maTour = 3 }

            );

            builder.Entity<LoaiHinhDuLich>().HasData(
                    new LoaiHinhDuLich { maLoaiHinh = 1, tenLoaiHinh = "Du lịch tham quan" },
                    new LoaiHinhDuLich { maLoaiHinh = 2, tenLoaiHinh = "Du lịch văn hóa" },
                    new LoaiHinhDuLich { maLoaiHinh = 3, tenLoaiHinh = "Du lịch ẩm thực" },
                    new LoaiHinhDuLich { maLoaiHinh = 4, tenLoaiHinh = "Du lịch xanh" }
            );

            builder.Entity<Tour>().HasData(
                    new Tour
                    {
                        maTour = 1,
                        tenTour = "Tên Tour 1",
                        khachSan = "Khách Sạn 1",
                        noiDungTour = "Nội dung tour",
                        dacDiem = "Đặc điểm 1",
                        maLoaiHinh = 1,
                        trangThai = true
                    },
                    new Tour
                    {
                        maTour = 2,
                        tenTour = "Tên Tour 2",
                        khachSan = "Khách Sạn 2",
                        noiDungTour = "Nội dung tour",
                        dacDiem = "Đặc điểm 1",
                        maLoaiHinh = 2,
                        trangThai = true

                    },
                    new Tour
                    {
                        maTour = 3,
                        tenTour = "Tên Tour 3",
                        khachSan = "Khách Sạn 3",
                        noiDungTour = "Nội dung tour",
                        dacDiem = "Đặc điểm 3",
                        maLoaiHinh = 2,
                        trangThai = true

                    },
                    new Tour
                    {
                        maTour = 4,
                        tenTour = "Tên Tour 2",
                        khachSan = "Khách Sạn 2",
                        noiDungTour = "Nội dung tour",
                        dacDiem = "Đặc điểm 1",
                        maLoaiHinh = 2,
                        trangThai = true

                    }

            ); ;
        }


        public DbSet<Doan> Doans { get; set; }
        public DbSet<Khach> Khachs { get; set; }
        public DbSet<ChiTiet> ChiTiets { get; set; }
        public DbSet<ChiPhi> ChiPhis { get; set; }
        public DbSet<LoaiChiPhi> LoaiChiPhis { get; set; }
        public DbSet<DiaDiem> DiaDiems { get; set; }
        public DbSet<GiaTour> GiaTours { get; set; }
        public DbSet<LoaiHinhDuLich> LoaiHinhDuLichs { get; set; }
        public DbSet<NhanVien> NhanViens { get; set; }
        public DbSet<PhanBo> PhanBos { get; set; }
        public DbSet<ThamQuan> ThamQuans { get; set; }
        public DbSet<Tour> Tours { get; set; }
    }
}
