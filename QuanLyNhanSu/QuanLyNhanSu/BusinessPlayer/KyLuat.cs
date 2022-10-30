using BusinessPlayer.DTO;
using DataPlayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessPlayer
{
   public class KyLuat
    {
        QuanLyNhanSuEntities db = new QuanLyNhanSuEntities();
        public tblKyLuat_NV getItem(string soQD)
        {
            return db.tblKyLuat_NV.FirstOrDefault(x => x.SoQuyetDinh == soQD);
        }
        public List<tblKyLuat_NV> getList(int loai)
        {
            return db.tblKyLuat_NV.Where(x => x.Loai == loai).ToList();
        }
        public List<KyLuat_DTO> getItemFull(string soQD)
        {
            List<tblKyLuat_NV> lstKT = db.tblKyLuat_NV.Where(x => x.SoQuyetDinh == soQD).ToList();
            List<KyLuat_DTO> lstDTO = new List<KyLuat_DTO>();
            KyLuat_DTO kt;
            foreach (var item in lstKT)
            {
                kt = new KyLuat_DTO();
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
                kt.Create_Date = item.Create_Date;
                kt.Update_By = item.Update_By;
                kt.Update_Date = item.Update_Date;
                kt.Delete_By = item.Delete_By;
                kt.Delete_Date = item.Delete_Date;
                lstDTO.Add(kt);
            }
            return lstDTO;
        }
        public List<KyLuat_DTO> getListFull(int loai)
        {

            List<tblKyLuat_NV> lstKT = db.tblKyLuat_NV.Where(x => x.Loai == loai).ToList();
            List<KyLuat_DTO> lstDTO = new List<KyLuat_DTO>();
            KyLuat_DTO kt;
            foreach (var item in lstKT)
            {
                kt = new KyLuat_DTO();
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
                kt.Create_Date = item.Create_Date;
                kt.Update_By = item.Update_By;
                kt.Update_Date = item.Update_Date;
                kt.Delete_By = item.Delete_By;
                kt.Delete_Date = item.Delete_Date;
                lstDTO.Add(kt);
            }
            return lstDTO;

        }

        public tblKyLuat_NV Add(tblKyLuat_NV kt)
        {
            try
            {
                db.tblKyLuat_NV.Add(kt);
                db.SaveChanges();
                return kt;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }

        }
        public tblKyLuat_NV Edit(tblKyLuat_NV kt)
        {
            try
            {
                tblKyLuat_NV _kt = db.tblKyLuat_NV.FirstOrDefault(x => x.SoQuyetDinh == kt.SoQuyetDinh);
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
                tblKyLuat_NV _kt = db.tblKyLuat_NV.FirstOrDefault(x => x.SoQuyetDinh == soQD);
                _kt.Delete_By = maNV;
                _kt.Delete_Date = DateTime.Now;
                db.tblKyLuat_NV.Remove(_kt);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }

        }
        public string MaxSoQuyetDinh(int loai)
        {
            var _hd = db.tblKyLuat_NV.Where(x => x.Loai == loai).OrderByDescending(x => x.Create_Date).FirstOrDefault();
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

