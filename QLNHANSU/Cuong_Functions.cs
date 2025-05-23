﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNHANSU
{
    public static class Cuong_Functions
    {
        //public static int demSoNgayLamViecTrongThang(int thang, int nam)
        //{
        //    int dem = 0;
        //    DateTime f = new DateTime(nam, thang, 01);
        //    int x = f.Month + 1;
        //    while (f.Month < x)
        //    {
        //        dem = dem + 1;
        //        if (f.DayOfWeek == DayOfWeek.Sunday)
        //        {
        //            dem = dem - 1;
        //        }
        //        f = f.AddDays(1);
        //    }
        //    return dem;
        //}
        public static int demSoNgayLamViecTrongThang(int thang, int nam)
        {
            int dem = 0;
            DateTime f = new DateTime(nam, thang, 1); // Ngày đầu tiên của tháng

            // Duyệt qua các ngày trong tháng
            while (f.Month == thang)
            {
                dem++; // Tăng số ngày
                if (f.DayOfWeek == DayOfWeek.Sunday) // Trừ đi nếu là Chủ nhật
                {
                    dem--;
                }
                f = f.AddDays(1); // Chuyển sang ngày tiếp theo
            }

            return dem; // Trả về số ngày làm việc
        }
        public static int laySoNgayCuaThang(int thang, int nam)
        {
            return DateTime.DaysInMonth(nam, thang);
        }
        public static string layThuTrongTuan(int nam, int thang, int ngay)
        {
            string thu = "";
            DateTime newDate = new DateTime(nam, thang, ngay);
            switch (newDate.DayOfWeek.ToString())
            {
                case "Monday":
                    thu = "Thứ Hai";
                    break;
                case "Tuesday":
                    thu = "Thứ Ba";
                    break;
                case "Wednesday":
                    thu = "Thứ Tư";
                    break;
                case "Thursday":
                    thu = "Thứ Năm";
                    break;
                case "Friday":
                    thu = "Thứ Sáu";
                    break;
                case "Saturday":
                    thu = "Thứ Bảy";
                    break;
                case "Sunday":
                    thu = "Chủ Nhật";
                    break;
            }
            return thu;
        }
        //khai báo 1 biến sqlCOnnection
        static SqlConnection con = new SqlConnection();

        public static void taoKetNoi()
        {
            con.ConnectionString = "data source=CUONGNH-ITHPG\\HUNGCUONG;initial catalog=QLNHANSU;integrated security=True;encrypt=True;trustservercertificate=True;MultipleActiveResultSets=True;App=EntityFramework&quot";
            try
            {
                con.Open();
            }
            catch
            {
                throw;
            }
        }
        public static void dongKetNoi()
        {
            con.Close();
        }
        public static DataTable getData(string query)
        {
            taoKetNoi();
            DataTable tb= new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.Fill(tb);
            dongKetNoi();
            return tb;
        }
        public static DataSet getDataSet(string query)
        {
            taoKetNoi();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(da);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
        public static void execQuery(string qr)
        {
            taoKetNoi();
            SqlCommand cmd = new SqlCommand(qr,con);
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            dongKetNoi();
        }
    }
}
