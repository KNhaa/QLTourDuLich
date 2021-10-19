using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL_DataAccessLayer.Entities
{
    public class ChiTiet {
        [Key]
        [Column(Order=1)]
        public int maDoan { get; set; }

        [Key]
        [Column(Order = 2)]
        public int maKh { get; set; }
        
        public virtual Doan Doan { get; set; }
        public virtual Khach Khach { get; set; }
    }
}
