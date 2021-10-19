using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DAL_DataAccessLayer.Entities
{
    public class LoaiHinhDuLich { 
        [Key]
        public int maLoaiHinh { get; set; }
        public string tenLoaiHinh { get; set; }
        public virtual ICollection<Tour> Tours { get; set; }

    }
}
