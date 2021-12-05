using DAL_DataAccessLayer;
using DAL_DataAccessLayer.DALServices;
using DAL_DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_BussinessLayer.BUSServices
{
    public class BUSGiaTour
    {
        DAOGiaTour _daoGiaTour;

        public BUSGiaTour()
        {
            _daoGiaTour = new DAOGiaTour();
        }
        public ICollection<GiaTour> GetByTourId(int ID)
        {
            var result = _daoGiaTour.GetByTourId(ID);
            return result;
        }
        
        public void Create(GiaTour giaTour)
        {
            _daoGiaTour.Create(giaTour);
        }

        public void Delete(int ID)
        {
            _daoGiaTour.Delete(ID);
        }

        public void Update(GiaTour giaTour)
        {
            _daoGiaTour.Update(giaTour);
        }
    }
}
  