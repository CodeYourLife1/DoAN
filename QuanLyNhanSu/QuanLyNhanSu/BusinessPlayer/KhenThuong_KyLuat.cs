using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataPlayer;
namespace BusinessPlayer
{
   public class KhenThuong_KyLuat
    {
        QuanLyNhanSuEntities db = new QuanLyNhanSuEntities();
        public tblKhenThuong_KyLuat getItem(string soQD)
        {
            return db.tblKhenThuong_KyLuat.FirstOrDefault(x => x.SoQuyetDinh == soQD);
        }

        public List<tblKhenThuong_KyLuat> getList(int loai)
        {
            return db.tblKhenThuong_KyLuat.Where(x => x.Loai == loai).ToList();
        }

        public tblKhenThuong_KyLuat Add(tblKhenThuong_KyLuat kt)
        {
            try
            {
                db.tblKhenThuong_KyLuat.Add(kt);
                db.SaveChanges();
                return kt;
            }
            catch(Exception ex)
            {
                throw new Exception("Lỗi: "+ex.Message);
            }
            
        }
        public tblKhenThuong_KyLuat Edit(tblKhenThuong_KyLuat kt)
        {
            try
            {
                tblKhenThuong_KyLuat _kt = db.tblKhenThuong_KyLuat.FirstOrDefault(x => x.SoQuyetDinh == kt.SoQuyetDinh);
                _kt.Ngay = kt.Ngay;
                _kt.TuNgay = kt.TuNgay;
                _kt.DenNgay = kt.DenNgay;
                _kt.LyDo = kt.LyDo;
                _kt.NoiDung = kt.NoiDung;
                _kt.Loai = kt.Loai;
                _kt.MaNV = kt.MaNV;
                _kt.Update_By = kt.Update_By;
                _kt.Update_Date = kt.Update_Date;
                db.SaveChanges();
                return kt;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }

        }
        public void Delete(string soQD)
        {
            try
            {
                tblKhenThuong_KyLuat _kt = db.tblKhenThuong_KyLuat.FirstOrDefault(x => x.SoQuyetDinh == soQD);
                _kt.Delete_By = _kt.Delete_By;
                _kt.Delete_Date = _kt.Delete_Date;
                db.SaveChanges();
                
            }
            catch (Exception ex)
            {
                 throw new Exception("Lỗi: " + ex.Message);
            }

        }
        public string MaxSoQD(int loai)
        {
            var _kt = db.tblKhenThuong_KyLuat.Where(x=>x.Loai==loai).OrderByDescending(x => x.Created_Date).FirstOrDefault();
            if (_kt != null)
            {
                return _kt.SoQuyetDinh;
            }
            else
            {
                return "00000";
            }
        }
    }
}
