using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DAL_DataAccessLayer.Entities
{
    public class DiaDiem {

        [Key]
        public int maDiaDiem { get; set; }
        public string tenDiaDiem { get; set; }
        public virtual ICollection<ThamQuan> ThamQuans { get; set; }

    }
}
