using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL_DataAccessLayer.Entities
{
    public class PhanBo {
        [Key]
        [Column(Order = 1)]
        public int maNv { get; set; }

        [Key]
        [Column(Order = 2)]
        public int maDoan { get; set; }

        public string nhiemVu { get; set; }

        public virtual Doan Doan { get; set; }
        public virtual NhanVien NhanVien { get; set; }
    }
}
