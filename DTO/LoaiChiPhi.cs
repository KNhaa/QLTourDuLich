using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DAL_DataAccessLayer
{
    public class LoaiChiPhi
    {
        [Key]
        public int maLoaiCP { get; set; }
        public string tenLoaiCP { get; set; }
        public virtual ICollection<ChiPhi> ChiPhis { get; set; }
    }
}
