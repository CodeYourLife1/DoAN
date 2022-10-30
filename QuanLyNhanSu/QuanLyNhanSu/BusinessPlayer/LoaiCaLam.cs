using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataPlayer;
namespace BusinessPlayer
{
   public class LoaiCaLam
    {
        QuanLyNhanSuEntities db = new QuanLyNhanSuEntities();
        public tblLoaiCa getItem(int id)
        {
            return db.tblLoaiCas.FirstOrDefault(x => x.IDLoaiCa == id);

        }
        public List<tblLoaiCa> getList()
        {
            return db.tblLoaiCas.ToList();
        }
        public tblLoaiCa Add(tblLoaiCa cv)
        {
            try
            {
                db.tblLoaiCas.Add(cv);
                db.SaveChanges();
                return cv;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
        public tblLoaiCa Edit(tblLoaiCa cv)
        {
            try
            {
                var _cv = db.tblLoaiCas.FirstOrDefault(x => x.IDLoaiCa == cv.IDLoaiCa);
                _cv.TenLoaiCa = cv.TenLoaiCa;
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
                var _cv = db.tblLoaiCas.FirstOrDefault(x => x.IDLoaiCa == id);
                _cv.Delete_By = iduser;
                _cv.Update_Date = DateTime.Now;
                db.tblLoaiCas.Remove(_cv);

                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
    }
}
