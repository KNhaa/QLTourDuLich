
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
            // thay đổi thành .\SQLEXPRESS để có thể tạo database trong SQL Server của mình
            options.UseSqlServer(@"Data Source=.\SQLEXPRESS;Initial Catalog=EFExample; Integrated Security=True");
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
        }

        public void SeedData(QuanLiTourDbContext context)
        {
            if (!context.LoaiHinhDuLichs.Any())
            {
                var dsloaihinh = new List<LoaiHinhDuLich>
                {
                    new LoaiHinhDuLich{tenLoaiHinh="Du lịch tham quan"},
                    new LoaiHinhDuLich{tenLoaiHinh="Du lịch văn hóa"},
                    new LoaiHinhDuLich{tenLoaiHinh="Du lịch ẩm thực"},
                    new LoaiHinhDuLich{tenLoaiHinh="Du lịch xanh"}
                };
            }

            

            if (!context.Tours.Any())
            {
                var tours = new List<Tour>
                {
                    new Tour {tenTour="Tên Tour 1",khachSan="Khách Sạn 1", noiDungTour="Nội dung tour",dacDiem="Đặc điểm",maLoaiHinh=1,maDoan=1}
                };
            }
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
