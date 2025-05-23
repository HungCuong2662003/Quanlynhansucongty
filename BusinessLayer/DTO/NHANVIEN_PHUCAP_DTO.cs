﻿using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.DTO
{
    public class NHANVIEN_PHUCAP_DTO
    {
        public int ID { get; set; }
        public Nullable<int> MANV { get; set; }
        public string HOTEN { get; set; }
        public string TENCV { get; set; }
        public Nullable<int> IDPC { get; set; }
        public string TENPC { get; set; }
        public Nullable<System.DateTime> NGAY { get; set; }
        public string NOIDUNG { get; set; }
        public Nullable<double> SOTIEN { get; set; }

        public virtual tb_NHANVIEN tb_NHANVIEN { get; set; }
        public virtual tb_PHUCAP tb_PHUCAP { get; set; }
    }
}
