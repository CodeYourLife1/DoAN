using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataPlayer;
namespace BusinessPlayer
{
   public class KyCong
    {
        QuanLyNhanSuEntities db = new QuanLyNhanSuEntities();
        public tblKYCONG getItem(int id)
        {
            return db.tblKYCONGs.FirstOrDefault(x => x.ID == id);

        }
        public List<tblKYCONG> getList()
        {
            return db.tblKYCONGs.ToList();

        }
        public tblKYCONG Add(tblKYCONG cv)
        {
            try
            {
                db.tblKYCONGs.Add(cv);
                db.SaveChanges();
                return cv;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
        public tblKYCONG Edit(tblKYCONG cv)
        {
            try
            {
                var _cv = db.tblKYCONGs.FirstOrDefault(x => x.ID == cv.ID);
                _cv.MAKYCONG = cv.MAKYCONG;
                _cv.NAM = cv.NAM;
                _cv.THANG = cv.THANG;
                _cv.KHOA = cv.KHOA;
                _cv.NGAYCONGTRONGTHANG = cv.NGAYCONGTRONGTHANG;
                _cv.NGAYTINHCONG = cv.NGAYTINHCONG;
                _cv.TRANGTHAI = cv.TRANGTHAI;
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
                var _cv = db.tblKYCONGs.FirstOrDefault(x => x.ID == id);
                _cv.Delete_By = iduser;
                _cv.Update_Date = DateTime.Now;
                db.tblKYCONGs.Remove(_cv);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
    }
}
