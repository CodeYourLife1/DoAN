using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataPlayer;
using BusinessPlayer;
using BusinessPlayer.DTO;

namespace BusinessPlayer
{
   public class NhanVien_DieuChuyen
    {
        QuanLyNhanSuEntities db = new QuanLyNhanSuEntities();
        public tblDieuChuyen getItem(string soQD)
        {
            return db.tblDieuChuyens.FirstOrDefault(x => x.SoQuyetDinh == soQD);
        }
        public List<tblDieuChuyen> getList()
        {
            return db.tblDieuChuyens.ToList();
        }
        public List<DieuChuyen_DTO> getListFull()
        {

            var lstDC = db.tblDieuChuyens.ToList();
            List<DieuChuyen_DTO> lstDTO = new List<DieuChuyen_DTO>();
            DieuChuyen_DTO dc;
           
            foreach (var item in lstDC)
            {
                dc = new DieuChuyen_DTO();
                dc.SoQuyetDinh = item.SoQuyetDinh;
                dc.MaNV = item.MaNV;
                dc.Ngay = item.Ngay;
                var nv = db.tblNhanViens.FirstOrDefault(n => n.MaNV == item.MaNV);
                dc.HoTen = nv.HoTen;
                dc.MaPB = item.MaPB;
                var pb = db.tblPhongBans.FirstOrDefault(p=>p.IDPhongBan ==item.MaPB);
                dc.TenPhongBan = pb.TenPhongBan;
                dc.MaPB2 = item.MaPB2;
                var pb2 = db.tblPhongBans.FirstOrDefault(p2 => p2.IDPhongBan == item.MaPB2);
                dc.TenPhongBan2 = pb2.TenPhongBan;
                dc.LyDo = item.LyDo;
                dc.GhiChu = item.GhiChu;
                dc.Created_By = item.Created_By;
                dc.Created_Date = item.Created_Date;
                dc.Update_By = item.Update_By;
                dc.Update_Date = item.Update_Date;
                dc.Delete_By = item.Delete_By;
                dc.Delete_Date = item.Delete_Date;
                lstDTO.Add(dc);
            }
            return lstDTO;

        }
        public List<DieuChuyen_DTO> getItemFull(string soQD)
        {
            List<tblDieuChuyen> lstKT = db.tblDieuChuyens.Where(x => x.SoQuyetDinh == soQD).ToList();
            List<DieuChuyen_DTO> lstDTO = new List<DieuChuyen_DTO>();
            DieuChuyen_DTO dc;
            foreach (var item in lstKT)
            {
                dc = new DieuChuyen_DTO();
                dc.SoQuyetDinh = item.SoQuyetDinh;
                dc.MaNV = item.MaNV;
                dc.Ngay = item.Ngay;
                var nv = db.tblNhanViens.FirstOrDefault(n => n.MaNV == item.MaNV);
                dc.HoTen = nv.HoTen;
                dc.MaPB = item.MaPB;
                var pb = db.tblPhongBans.FirstOrDefault(p => p.IDPhongBan == item.MaPB);
                dc.TenPhongBan = pb.TenPhongBan;
                dc.MaPB2 = item.MaPB2;
                var pb2 = db.tblPhongBans.FirstOrDefault(p2 => p2.IDPhongBan == item.MaPB2);
                dc.TenPhongBan2 = pb2.TenPhongBan;
                dc.LyDo = item.LyDo;
                dc.GhiChu = item.GhiChu;
                dc.Created_By = item.Created_By;
                dc.Created_Date = item.Created_Date;
                dc.Update_By = item.Update_By;
                dc.Update_Date = item.Update_Date;
                dc.Delete_By = item.Delete_By;
                dc.Delete_Date = item.Delete_Date;
                lstDTO.Add(dc);
                
            }
            return lstDTO;
        }
        public tblDieuChuyen Add(tblDieuChuyen kt)
        {
            try
            {
                db.tblDieuChuyens.Add(kt);
                db.SaveChanges();
                return kt;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }

        }
        public tblDieuChuyen Edit(tblDieuChuyen kt)
        {
            try
            {
                var _dc = db.tblDieuChuyens.FirstOrDefault(x => x.SoQuyetDinh == kt.SoQuyetDinh);
                _dc.MaPB2 = kt.MaPB2;
                _dc.Ngay = kt.Ngay;
                _dc.LyDo = kt.LyDo;
                _dc.GhiChu = kt.GhiChu;
                _dc.Update_By = kt.Update_By;
                _dc.Update_Date = kt.Update_Date;
                db.SaveChanges();
                return kt;
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
                var _dc = db.tblDieuChuyens.FirstOrDefault(x => x.SoQuyetDinh == soQD);
                _dc.Delete_By = idUser;
                _dc.Delete_Date = DateTime.Now;
                db.tblDieuChuyens.Remove(_dc);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }

        }
        public string MaxSoQuyetDinh(int loai)
        {
            var _hd = db.tblDieuChuyens.OrderByDescending(x => x.Created_Date).FirstOrDefault();
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
