using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.DTO
{
    public class TANGCA_DTO
    {
        public int ID { get; set; }
        public Nullable<int> NGAY { get; set; }
        public Nullable<int> THANG { get; set; }
        public Nullable<int> NAM { get; set; }
        public Nullable<double> SOGIO { get; set; }
        public Nullable<int> MANV { get; set; }
        public Nullable<double> SOTIEN { get; set; }
        public string HOTEN { get; set; }
        public Nullable<int> IDLOAICA { get; set; }
        public string TENLOAICA { get; set; }
        public double? HESO {  get; set; }
        public string GHICHU { get; set; }

        public virtual tb_LOAICA tb_LOAICA { get; set; }
        public virtual tb_NHANVIEN tb_NHANVIEN { get; set; }
    }
}
