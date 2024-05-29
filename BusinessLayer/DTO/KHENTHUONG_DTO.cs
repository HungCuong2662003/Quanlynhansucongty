using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.DTO
{
    public class KHENTHUONG_DTO
    {
        public string SOQUYETDINH { get; set; }
        public string LYDO { get; set; }
        public string NOIDUNG { get; set; }
        public Nullable<System.DateTime> NGAY { get; set; }
        public Nullable<int> MANV { get; set; }
        public string HOTEN { get; set; }
    }
}
