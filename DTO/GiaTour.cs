﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL_DataAccessLayer
{
    public class GiaTour { 
        [Key]
        public int maGiaTour { get; set; }
        public DateTime ngayKhoiHanh { get; set; }
        public DateTime ngayKetThuc { get; set; }
        public decimal thanhTien { get; set; }

        public int maTour { get; set; }

        // khai bao khoa ngoai ben 1 trong moi ket hop 1-n
        [ForeignKey(nameof(maTour))]
        public virtual Tour Tour { get; set; }
    }
}
