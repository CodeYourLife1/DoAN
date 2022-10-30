using DataPlayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessPlayer
{
   public class LoaiCong
    {
        QuanLyNhanSuEntities db = new QuanLyNhanSuEntities();
        public tblLoaiCong getItem(int id)
        {
            return db.tblLoaiCongs.FirstOrDefault(x => x.IDLoaiCong == id);

        }
        public List<tblLoaiCong> getList()
        {
            return db.tblLoaiCongs.ToList();
        }
        public tblLoaiCong Add(tblLoaiCong cv)
        {
            try
            {
                db.tblLoaiCongs.Add(cv);
                db.SaveChanges();
                return cv;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
        public tblLoaiCong Edit(tblLoaiCong cv)
        {
            try
            {
                var _cv = db.tblLoaiCongs.FirstOrDefault(x => x.IDLoaiCong == cv.IDLoaiCong);
                _cv.TenLoaiCong = cv.TenLoaiCong;
                _cv.HeSo = cv.HeSo;
                _cv.Update_By = cv.Update_By;
                _cv.Update_Date = cv.Update_Date;
                db.SaveChanges();
                return cv;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
        public void Delete(int id, int iduser)
        {
            try
            {
                var _cv = db.tblLoaiCongs.FirstOrDefault(x => x.IDLoaiCong == id);
                _cv.Delete_By = iduser;
                _cv.Update_Date = DateTime.Now;
                db.tblLoaiCongs.Remove(_cv);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
    }
}
