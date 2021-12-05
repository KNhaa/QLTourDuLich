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
        DAOTour _daoTour;
        DAOThamQuan _daoThamQuan;
        public BUSTour()
        {
            _daoTour = new DAOTour();
            _daoThamQuan = new DAOThamQuan();
        }
        public   ICollection<Tour> GetTours()
        {
            return _daoTour.GetTours().ToList();
        }

        public  Tour GetTour(int ID)
        {
            return _daoTour.GetTour(ID);
        }

        public  void Create(Tour tour)
        {
            _daoTour.Create(tour);
        }

        public  void Update(Tour tour)
        {
            _daoTour.Update(tour);
            
        }

        public  void UpdateData(Tour tour)
        {
            var DSThamQuan = _daoThamQuan.GetDSThamQuan(tour);
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
