using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL_DataAccessLayer.Entities
{
    public class Tour { 
        [Key]
        public int maTour { get; set; }
        [Required(ErrorMessage = "Tên Tour không được bỏ trống")]
        
        public string tenTour { get; set; }
        [Required(ErrorMessage = "Tên khách sạn không được bỏ trống")]
        public string khachSan { get; set; }
        [Required(ErrorMessage = "Nội dung không được bỏ trống")]
        public string noiDungTour { get; set; }
        public string dacDiem { get; set; }
        public bool trangThai { get; set; }

        public virtual ICollection<Doan> Doans { get; set; }

        public virtual ICollection<GiaTour> GiaTours { get; set; }

        public int maLoaiHinh { get; set; }

       

        // khai bao khoa ngoai ben 1 trong moi ket hop 1-n
        [ForeignKey(nameof(maLoaiHinh))]
        public virtual LoaiHinhDuLich LoaiHinhDuLich { get; set; }

        public virtual ICollection<ThamQuan> ThamQuans  { get; set; }
    }
}
