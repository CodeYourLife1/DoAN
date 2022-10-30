using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataPlayer;
using BusinessPlayer.DTO;

namespace BusinessPlayer
{
   public class KhenThuong
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
        public List<KhenThuong_DTO> getItemFull(string soQD)
        {
            List<tblKhenThuong_KyLuat> lstKT = db.tblKhenThuong_KyLuat.Where(x => x.SoQuyetDinh == soQD).ToList();
            List<KhenThuong_DTO> lstDTO = new List<KhenThuong_DTO>();
            KhenThuong_DTO kt;
            foreach (var item in lstKT)
            {
                kt = new KhenThuong_DTO();
                kt.SoQuyetDinh = item.SoQuyetDinh;
                kt.TuNgay = item.TuNgay;
                kt.DenNgay = item.DenNgay;
                kt.NoiDung = item.NoiDung;
                kt.LyDo = item.LyDo;
                kt.Ngay = item.Ngay;
                kt.Loai = item.Loai;
                kt.MaNV = item.MaNV;

                var nv = db.tblNhanViens.FirstOrDefault(n => n.MaNV == item.MaNV);
                kt.HoTen = nv.HoTen;
                kt.Created_By = item.Created_By;
                kt.Created_Date = item.Created_Date;
                kt.Update_By = item.Update_By;
                kt.Update_Date = item.Update_Date;
                kt.Delete_By = item.Delete_By;
                kt.Delete_Date = item.Delete_Date;
                lstDTO.Add(kt);
            }
            return lstDTO;
        }
        public List<KhenThuong_DTO> getListFull(int loai)
        {
        
            List<tblKhenThuong_KyLuat> lstKT = db.tblKhenThuong_KyLuat.Where(x => x.Loai == loai).ToList();
            List<KhenThuong_DTO> lstDTO = new List<KhenThuong_DTO>();
            KhenThuong_DTO kt;
            foreach (var item in lstKT)
            {
                kt = new KhenThuong_DTO();
                kt.SoQuyetDinh = item.SoQuyetDinh;
                kt.TuNgay = item.TuNgay;
                kt.DenNgay = item.DenNgay;
                kt.NoiDung = item.NoiDung;
                kt.LyDo = item.LyDo;
                kt.Ngay = item.Ngay;
                kt.Loai = item.Loai;
                kt.MaNV = item.MaNV;
                
                var nv = db.tblNhanViens.FirstOrDefault(n => n.MaNV == item.MaNV);
                kt.HoTen = nv.HoTen;
                kt.Created_By = item.Created_By;
                kt.Created_Date = item.Created_Date;
                kt.Update_By = item.Update_By;
                kt.Update_Date = item.Update_Date;
                kt.Delete_By = item.Delete_By;
                kt.Delete_Date = item.Delete_Date;
                lstDTO.Add(kt);
            }
            return lstDTO;

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
                throw new Exception("Lỗi: " + ex.Message);
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
        public void Delete(string soQD, int maNV)
        {
            try
            {
                tblKhenThuong_KyLuat _kt = db.tblKhenThuong_KyLuat.FirstOrDefault(x => x.SoQuyetDinh == soQD);
                _kt.Delete_By = maNV;
                _kt.Delete_Date = DateTime.Now;
                db.tblKhenThuong_KyLuat.Remove(_kt);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }

        }
        public string MaxSoQuyetDinh(int loai)
        {
            var _hd = db.tblKhenThuong_KyLuat.Where(x=>x.Loai==loai).OrderByDescending(x => x.Created_Date).FirstOrDefault();
            if (_hd != null)
            {
                return _hd.SoQuyetDinh;
            }
            else
            {
                return "00000";
            }
        }
    }
}
