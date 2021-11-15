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
        public int maTour { get; set; }

        // khai bao khoa ngoai ben 1 trong moi ket hop 1-n
        [ForeignKey(nameof(maTour))]
        public virtual Tour Tour { get; set; }

        public virtual ICollection<ChiPhi> ChiPhis { get; set; }

        public virtual ICollection<ChiTiet> ChiTiets { get; set; }

        public virtual ICollection<PhanBo> PhanBos { get; set; }
        
    }
}
