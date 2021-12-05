using DAL_DataAccessLayer.DALServices;
using DAL_DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_BussinessLayer.BUSServices
{
    public class BUSDiaDiem
    {
        DAODiaDiem _daoDiaDiem;

        public BUSDiaDiem()
        {
            _daoDiaDiem = new DAODiaDiem();
        }

        public ICollection<DiaDiem> GetAll()
        {
            return _daoDiaDiem.GetAll();
        }
        public DiaDiem GetItem(int Id)
        {
            return _daoDiaDiem.GetById(Id);
        }
        public void Create(DiaDiem diaDiem)
        {
            _daoDiaDiem.Create(diaDiem);
        }
    }
}
