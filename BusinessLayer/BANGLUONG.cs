using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class BANGLUONG
    {
        QLNHANSUEntities db = new QLNHANSUEntities();
        public tb_BANGLUONG getItem(int makycong, int manv)
        {
            return db.tb_BANGLUONG.FirstOrDefault(x => x.MAKYCONG == makycong && x.MANV == manv );
        }
        public List<tb_BANGLUONG> getList(int makycong)
        {
            return db.tb_BANGLUONG.Where(x => x.MAKYCONG == makycong).ToList();
        }
        //public float luong1ngaycong(int makycong, int manv)
        //{
        //    var hd = db.tb_HOPDONG.FirstOrDefault(x => x.MANV == manv);
        //    float luong1ngay =0;
        //    if (hd != null)
        //    {
        //        var kcct = db.tb_KYCONGCHITIET.FirstOrDefault(x => x.MAKYCONG == makycong && x.MANV == manv); ;
        //        double hesoluong = Convert.ToDouble(hd.HESOLUONG);
        //        luong1ngay = (float) (hd.LUONGCOBAN * hesoluong / Convert.ToDouble(kcct.NGAYCONG));
                
        //    }
        //    return luong1ngay;

        //}
        public float luong1ngaycong(int makycong, int manv)
        {
            // Khai báo lương 1 ngày mặc định là 0
            float luong1ngay = 0;

            // Lấy thông tin hợp đồng
            var hd = db.tb_HOPDONG.FirstOrDefault(x => x.MANV == manv);
            if (hd != null)
            {
                // Lấy thông tin công chi tiết
                var kcct = db.tb_KYCONGCHITIET.FirstOrDefault(x => x.MAKYCONG == makycong && x.MANV == manv);
                if (kcct != null && kcct.NGAYCONG > 0) // Kiểm tra kcct != null và ngày công hợp lệ
                {
                    double hesoluong = Convert.ToDouble(hd.HESOLUONG);
                    luong1ngay = (float)(hd.LUONGCOBAN * hesoluong / Convert.ToDouble(kcct.NGAYCONG));
                }
            }

            // Trả về lương 1 ngày
            return luong1ngay;
        }

        public void TinhLuongNhanVien (int makycong)
        {
            remove(makycong);

            double luongngaythuong, luongphep, luongtangca, luongchunhat, luongngayle, phucap, ungluong, thuclanh, hesoluong, luongkphep;
            var lstNV = db.tb_NHANVIEN.Where(x => x.DATHOIVIEC == null).ToList();
            foreach (var item in lstNV)
            {
                var hd = db.tb_HOPDONG.FirstOrDefault(x=>x.MANV==item.MANV);
                if (hd != null)
                {
                    var kcct = db.tb_KYCONGCHITIET.FirstOrDefault(x => x.MAKYCONG == makycong && x.MANV == item.MANV); 
                    hesoluong = Convert.ToDouble(hd.HESOLUONG);
                    var luong1ngaycong = hd.LUONGCOBAN * hesoluong / Convert.ToDouble(kcct.NGAYCONG);
                    //tính lương
                    luongngaythuong = Convert.ToDouble(kcct.TONGNGAYCONG * luong1ngaycong);
                    luongphep = Convert.ToDouble(kcct.NGAYPHEP * luong1ngaycong);
                    luongkphep = Convert.ToDouble(kcct.NGHIKHONGPHEP * luong1ngaycong * 0);
                    luongchunhat = Convert.ToDouble(kcct.CONGCHUNHAT * luong1ngaycong * 2);
                    luongngayle = Convert.ToDouble(kcct.CONGNGAYLE * luong1ngaycong * 3);
                    luongtangca = Convert.ToDouble(db.tb_TANGCA.Where(x => (x.NAM * 100 + x.THANG) == makycong && x.MANV == item.MANV).Sum(x => x.SOTIEN));
                    phucap = Convert.ToDouble(db.tb_NHANVIEN_PHUCAP.Where(x => x.MANV == item.MANV).Sum(x => x.SOTIEN));
                    ungluong = Convert.ToDouble(db.tb_UNGLUONG.Where(x => x.MANV == item.MANV && (x.NAM * 100 + x.THANG) == makycong).Sum(x => x.SOTIEN));

                    thuclanh = luongngaythuong + luongphep + luongkphep + luongngayle  + luongchunhat + luongtangca + phucap - ungluong;
           
                    tb_BANGLUONG bl = new tb_BANGLUONG();
                    bl.MAKYCONG = makycong;
                    bl.MANV = item.MANV;
                    bl.HOTEN = item.HOTEN;
                    bl.NGAYCONGTRONGTHANG = int.Parse(kcct.TONGNGAYCONG.ToString());
                    bl.NGAYPHEP = luongphep;
                    bl.NGAYCHUNHAT = luongchunhat;
                    bl.NGAYLE = luongngayle;
                    bl.NGAYTHUONG = luongngaythuong;
                    bl.PHUCAP = phucap;
                    bl.TANGCA = luongtangca;
                    bl.UNGLUONG = ungluong;
                    bl.THUCLANH = thuclanh;
                    Add(bl);
                }             
            }   
        }
        public tb_BANGLUONG Add(tb_BANGLUONG bl)
        {
            try
            {
                db.tb_BANGLUONG.Add(bl);
                db.SaveChanges();
                return bl;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }

        }
        public void remove(int makycong)
        {
            // Lấy danh sách các bản ghi có MAKYCONG tương ứng
            var listToRemove = db.tb_BANGLUONG.Where(x => x.MAKYCONG == makycong).ToList();

            if (listToRemove.Any()) // Kiểm tra nếu có bản ghi để xóa
            {
                try
                {
                    db.tb_BANGLUONG.RemoveRange(listToRemove); // Xóa toàn bộ danh sách
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw new Exception("Lỗi khi xóa: " + ex.Message);
                }
            }
            else
            {
                
            }
        }

        public tb_BANGLUONG Update(tb_BANGLUONG bl)
        {
            try
            {
                tb_BANGLUONG _bl = db.tb_BANGLUONG.FirstOrDefault(x => x.MAKYCONG == bl.MAKYCONG &&  x.MANV == bl.MANV);
                _bl.MANV = bl.MANV;
                _bl.MAKYCONG = bl.MAKYCONG;
                _bl.HOTEN = bl.HOTEN;
                _bl.NGAYPHEP = bl.NGAYPHEP;
                _bl.KHONGPHEP = bl.KHONGPHEP;
                _bl.NGAYLE = bl.NGAYLE;
                _bl.UNGLUONG = bl.UNGLUONG;
                _bl.PHUCAP = bl.PHUCAP;
                _bl.TANGCA = bl.TANGCA;
                _bl.NGAYCHUNHAT = bl.NGAYCHUNHAT;
                _bl.NGAYCONGTRONGTHANG = bl.NGAYCONGTRONGTHANG;
                _bl.NGAYTHUONG = bl.NGAYTHUONG;
                _bl.THUCLANH = bl.THUCLANH;
                db.SaveChanges();
                return bl;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
        
    }
}
