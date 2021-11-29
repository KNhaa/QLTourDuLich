using DAL_DataAccessLayer.DALServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DAL_DataAccessLayer.DALServices.DAOThongKeNhanVien;

namespace BUS_BussinessLayer.BUSServices
{
    public class BUSThongKeNhanVien
    {
        //DAOThongKeNhanVien daoTKNV = new DAOThongKeNhanVien();
        List<DataThongKe> dataThongKeNV;
        DAOThongKeNhanVien _daoThongKeNhanVien;
        
        public BUSThongKeNhanVien()
        {
            _daoThongKeNhanVien = new DAOThongKeNhanVien();
            dataThongKeNV = _daoThongKeNhanVien.layDuLieuThongKe().ToList();
        }

        
        //nhóm theo ID và tên của nhân viên, đếm số lần tham gia
        public List<KetQuaTKNV> thongkeTatCaNgay()
        {
            var groupResult = from j in dataThongKeNV
                              group j by new { j.maNv, j.tenNv } into gr
                              select new KetQuaTKNV
                              {
                                  MaNV = gr.Key.maNv,
                                  TenNV = gr.Key.tenNv,
                                  SoLuong = gr.Count()
                              };
            return groupResult.ToList();
        }

        //như hàm trên, thêm điều kiện ngày bắt đầu - kết thúc
        public List<KetQuaTKNV> thongkeTheoNgay(DateTime dateStart, DateTime dateEnd)
        {
            var groupResult = from j in dataThongKeNV
                              where j.ngayBatDau.Date >= dateStart && j.ngayKetThuc.Date <= dateEnd
                              group j by new { j.maNv, j.tenNv } into gr
                              select new KetQuaTKNV 
                              { 
                                MaNV = gr.Key.maNv, 
                                TenNV = gr.Key.tenNv, 
                                SoLuong = gr.Count() 
                              };

            /*List<KetQuaTKNV> list = new List<KetQuaTKNV>();
            foreach (var item in groupResult)
            {
                KetQuaTKNV result = new KetQuaTKNV() { MaNV = item.MaNV, TenNV = item.TenNV, SoLuong = item.SoLuong };

                list.Add(result);
            }*/
            return groupResult.ToList();
        }
    }
}
