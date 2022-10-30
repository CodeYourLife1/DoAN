using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataPlayer;
using BusinessPlayer.DTO;

namespace BusinessPlayer
{
   public class NhanVien_ThoiViec
    {
        QuanLyNhanSuEntities db = new QuanLyNhanSuEntities();
        public tblThoiViec getItem(string soQD)
        {
            return db.tblThoiViecs.FirstOrDefault(x=> x.SoQuyetDinh == soQD);
        }
        public List< tblThoiViec> getList()
        {
            return db.tblThoiViecs.ToList();
        }
        public List<NhanVienThoiViec_DTO> getListFull()
        {

            var lstTV = db.tblThoiViecs.ToList();
            List<NhanVienThoiViec_DTO> lstDTO = new List<NhanVienThoiViec_DTO>();
            NhanVienThoiViec_DTO tv;

            foreach (var item in lstTV)
            {
                tv = new NhanVienThoiViec_DTO();
                tv.SoQuyetDinh = item.SoQuyetDinh;
                tv.MaNV = item.MaNV;
                tv.NgayNopDon = item.NgayNopDon;
                tv.NgayNghi = item.NgayNghi;
                var nv = db.tblNhanViens.FirstOrDefault(n => n.MaNV == item.MaNV);
                tv.HoTen = nv.HoTen;
                tv.LyDo = item.LyDo;
                tv.GhiChu = item.GhiChu;
                tv.Created_By = item.Created_By;
                tv.Created_Date = item.Created_Date;
                tv.Update_By = item.Update_By;
                tv.Update_Date = item.Update_Date;
                tv.Delete_By = item.Delete_By;
                tv.Delete_Date = item.Delete_Date;
                lstDTO.Add(tv);
            }
            return lstDTO;
        }
        public tblThoiViec Add(tblThoiViec tv)
        {
            try
            {
                db.tblThoiViecs.Add(tv);
                db.SaveChanges();
                return tv;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }

        }
        public tblThoiViec Edit(tblThoiViec tv)
        {
            try
            {
                var _tv = db.tblThoiViecs.FirstOrDefault(x => x.SoQuyetDinh == tv.SoQuyetDinh);
                _tv.NgayNopDon = tv.NgayNopDon;
                _tv.NgayNghi = tv.NgayNghi;
                _tv.MaNV = tv.MaNV;
                _tv.LyDo = tv.LyDo;
                _tv.GhiChu = tv.GhiChu;
                _tv.Update_By = tv.Update_By;
                _tv.Update_Date = tv.Update_Date;
                db.SaveChanges();
                return tv;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }

        }
        public void Delete(string soQD, int idUser)
        {
            try
            {
                var _tv = db.tblThoiViecs.FirstOrDefault(x => x.SoQuyetDinh == soQD);
                _tv.Delete_By = idUser;
                _tv.Delete_Date = DateTime.Now;
                db.tblThoiViecs.Remove(_tv);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }

        }
        public string MaxSoQuyetDinh(int loai)
        {
            var _hd = db.tblThoiViecs.OrderByDescending(x => x.Created_Date).FirstOrDefault();
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
