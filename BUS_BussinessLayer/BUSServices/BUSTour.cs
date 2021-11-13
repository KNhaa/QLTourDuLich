using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_DataAccessLayer;
using DAL_DataAccessLayer.DALServices;
using DAL_DataAccessLayer.Entities;

namespace BUS_BussinessLayer.BUSServices
{
    public class BUSTour
    {
        public static  ICollection<Tour> GetTours()
        {
            return DAOTour.GetTours().ToList();
        }

        public static Tour GetTour(int ID)
        {
            return DAOTour.GetTour(ID);
        }

        public static void Create(Tour tour)
        {
            DAOTour.Create(tour);
        }

        public static void Update(Tour tour)
        {
            DAOTour.Update(tour);
            
        }

        public static void UpdateData(Tour tour)
        {
            var DSThamQuan = DAOThamQuan.GetDSThamQuan(tour);
            foreach (var item in tour.ThamQuans)
            {
                if (DSThamQuan.Any(x => x.maDiaDiem == item.maDiaDiem))
                {
                    var tmp = DSThamQuan.FirstOrDefault(x => x.maDiaDiem == item.maDiaDiem);
                    tmp.thuTuThamQuan = item.thuTuThamQuan;
                    DAOThamQuan.UpdateDSThamQuan(tmp);
                }
            }
            foreach (var item in DSThamQuan)
            {
                if (DSThamQuan.Any(x => x.maDiaDiem == item.maDiaDiem) && !tour.ThamQuans.Any(x => x.maDiaDiem == item.maDiaDiem))
                {
                    DAOThamQuan.RemoveItemDSThamQuan(item);
                }
            }
        }
    }
}
