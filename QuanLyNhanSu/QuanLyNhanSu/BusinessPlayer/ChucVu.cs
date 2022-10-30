using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataPlayer;

namespace BusinessPlayer
{
   public class ChucVu
    {
        QuanLyNhanSuEntities db = new QuanLyNhanSuEntities();
        public tblChucVu getItem(int id)
        {
            return db.tblChucVus.FirstOrDefault(x => x.IDChucVu == id);

        }
        public List<tblChucVu> getList()
        {
            return db.tblChucVus.ToList();
        }
        public tblChucVu Add(tblChucVu cv)
        {
            try
            {
                db.tblChucVus.Add(cv);
                db.SaveChanges();
                return cv;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
        public tblChucVu Edit(tblChucVu cv)
        {
            try
            {
                var _cv = db.tblChucVus.FirstOrDefault(x => x.IDChucVu == cv.IDChucVu);
                _cv.TenChucVu = cv.TenChucVu;
                db.SaveChanges();
                return cv;
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
                var _cv = db.tblChucVus.FirstOrDefault(x => x.IDChucVu == id);
                db.tblChucVus.Remove(_cv);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
    }
}
