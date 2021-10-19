
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace DAL_DataAccessLayer.Entities
{
    public class Khach
    {
        [Key]
        //[StringLength(10)]
        public int maKh { get; set; }

        [Required] //not null
        public string tenKh { get; set; }
        public string diaChi { get; set; }
        public string cnmd { get; set; }
        public string gioiTinh { get; set; }
        public string sdt { get; set; }
        public string quocTich { get; set; }
        public virtual ICollection<ChiTiet> ChiTiets { get; set; }
    }
}
