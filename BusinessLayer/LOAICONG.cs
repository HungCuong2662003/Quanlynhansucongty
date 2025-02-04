﻿using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class LOAICONG
    {
        QLNHANSUEntities db = new QLNHANSUEntities();
        public tb_LOAICONG getItem(int id)
        {
            return db.tb_LOAICONG.FirstOrDefault(x => x.IDLOAICONG == id);
        }
        public List<tb_LOAICONG> getList()
        {
            return db.tb_LOAICONG.ToList();
        }
        public tb_LOAICONG Add(tb_LOAICONG lc)
        {
            try
            {
                db.tb_LOAICONG.Add(lc);
                db.SaveChanges();
                return lc;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
        public tb_LOAICONG Update(tb_LOAICONG lc)
        {
            try
            {
                var _lc = db.tb_LOAICONG.FirstOrDefault(x => x.IDLOAICONG == lc.IDLOAICONG);
                _lc.TENLOAICONG = lc.TENLOAICONG;
                _lc.HESO = lc.HESO;
                db.SaveChanges();
                return lc;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
        public void Delete(int id)
        {

            try
            {
                var _lc = db.tb_LOAICONG.FirstOrDefault(x => x.IDLOAICONG == id);
                db.tb_LOAICONG.Remove(_lc);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
    }
}
