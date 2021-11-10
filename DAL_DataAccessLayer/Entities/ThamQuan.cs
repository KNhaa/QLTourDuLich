using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL_DataAccessLayer.Entities
{
    public class ThamQuan {
        [Key]
        [Column(Order = 1)]
        public int maDiaDiem { get; set; }

        [Key]
        [Column(Order = 2)]
        public int maTour { get; set; }
        public int thuTuThamQuan { get; set; }
        public virtual DiaDiem DiaDiem { get; set; }
        public virtual Tour Tour { get; set; }

        
    }
}
