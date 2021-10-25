﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL_DataAccessLayer
{
    public class Tour { 
        [Key]
        public int maTour { get; set; }
        public string tenTour { get; set; }
        public string khachSan { get; set; }
        public string noiDungTour { get; set; }
        public string dacDiem { get; set; }
        public bool trangThai { get; set; }

        public int maDoan { get; set; }

        // khai bao khoa ngoai ben 1 trong moi ket hop 1-n
        [ForeignKey(nameof(maDoan))]
        public virtual Doan Doan { get; set; }

        public virtual ICollection<GiaTour> GiaTours { get; set; }

        public int maLoaiHinh { get; set; }

        // khai bao khoa ngoai ben 1 trong moi ket hop 1-n
        [ForeignKey(nameof(maLoaiHinh))]
        public virtual LoaiHinhDuLich LoaiHinhDuLich { get; set; }

        public virtual ICollection<ThamQuan> ThamQuans { get; set; }
    }
}