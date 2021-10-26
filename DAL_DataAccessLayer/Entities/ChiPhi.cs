using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL_DataAccessLayer.Entities
{
    public class ChiPhi
    {
        [Key]
        public int maChiPhi { get; set; }
        public decimal soTien { get; set; }

        public int maDoan { get; set; }

        // khai bao khoa ngoai ben 1 trong moi ket hop 1-n
        [ForeignKey(nameof(maDoan))]
        public virtual Doan Doan { get; set; }

        public int maLoaiCP { get; set; }

        // khai bao khoa ngoai ben 1 trong moi ket hop 1-n
        [ForeignKey(nameof(maLoaiCP))]
        public virtual LoaiChiPhi LoaiChiPhi { get; set; }
    }
}
