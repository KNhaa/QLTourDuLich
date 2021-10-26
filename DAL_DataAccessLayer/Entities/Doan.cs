using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL_DataAccessLayer.Entities
{
    public class Doan
    {
        [Key]
        public int maDoan { get; set; }
        public DateTime ngayKhoiHanh { get; set; }
        public DateTime ngayKetThuc { get; set; }
        public float doanhThu { get; set; }

        public virtual ICollection<ChiPhi> ChiPhis { get; set; }

        public virtual ICollection<ChiTiet> ChiTiets { get; set; }

        public virtual ICollection<PhanBo> PhanBos { get; set; }
        
        public virtual ICollection<Tour> Tours { get; set; }
    }
}
