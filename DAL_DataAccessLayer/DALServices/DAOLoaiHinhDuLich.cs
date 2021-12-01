using DAL_DataAccessLayer.DatabaseContext;
using DAL_DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_DataAccessLayer.DALServices
{
    public class DAOLoaiHinhDuLich
    {
        public ICollection<LoaiHinhDuLich> GetAll()
        {
            using(QuanLiTourDbContext context = new QuanLiTourDbContext())
            {
                return context.LoaiHinhDuLichs.ToList();
            }
        }

        public LoaiHinhDuLich GetItemById(int ID)
        {
            using(QuanLiTourDbContext context = new QuanLiTourDbContext())
            {
                return context.LoaiHinhDuLichs.Find(ID);
            }
        }
    }
}
