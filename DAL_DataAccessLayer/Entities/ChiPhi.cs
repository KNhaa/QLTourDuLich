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

        // khai bao khoa ngoai ben n trong moi ket hop 1-n
        public virtual ICollection<Doan> Doans { get; set; }

        public int maLoaiCP { get; set; }

        // khai bao khoa ngoai ben 1 trong moi ket hop 1-n
        [ForeignKey(nameof(maLoaiCP))]
        public virtual LoaiChiPhi LoaiChiPhi { get; set; }
    }
}
