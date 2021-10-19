using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_DataAccessLayer.Entities
{
    public class NhanVien
    {
        [Key]
        public int maNv { get; set; }
        public string tenNv { get; set; }
        public virtual ICollection<PhanBo> PhanBos { get; set; }
    }
}
