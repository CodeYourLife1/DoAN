using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataPlayer;
using BusinessPlayer.DTO;

namespace BusinessPlayer
{
   public class NhanVien_NangLuong
    {
        QuanLyNhanSuEntities db = new QuanLyNhanSuEntities();
        public tblNhanVien_NangLuong getItem(string soqd)
        {
            return db.tblNhanVien_NangLuong.FirstOrDefault(x => x.SoQuyetDinh == soqd);

        }
        public List<NangLuong_DTO> getListFull()
        {
            var LstNL =  db.tblNhanVien_NangLuong.ToList();
            List<NangLuong_DTO> LstDTO = new List<NangLuong_DTO>();
            NangLuong_DTO nlDTO;
            foreach(var item  in LstNL)
            {
                nlDTO = new NangLuong_DTO();
                nlDTO.SoQuyetDinh = item.SoQuyetDinh;
                nlDTO.SoHopDong = item.SoHopDong;
                nlDTO.HeSoLuongHienTai = item.HeSoLuongHienTai;
                nlDTO.HeSoLuogMoi = item.HeSoLuogMoi;
                nlDTO.MaNV = item.MaNV;
                nlDTO.GhiChu = item.GhiChu;
                var nv = db.tblNhanViens.FirstOrDefault(n => n.MaNV == item.MaNV);
                nlDTO.HoTen = nv.HoTen;
                nlDTO.NgayKi = item.NgayKi;
                nlDTO.NgayLenLuong = item.NgayLenLuong;
                nlDTO.Created_By = item.Created_By;
                nlDTO.Creared_Date = item.Creared_Date;
                nlDTO.Update_By = item.Update_By;
                nlDTO.Update_Date = item.Update_Date;
                nlDTO.Delete_By = item.Delete_By;
                nlDTO.Delete_Date = item.Delete_Date;
                LstDTO.Add(nlDTO);


            }
            return LstDTO;

        }
        public List<tblNhanVien_NangLuong> getLst()
        {
            return db.tblNhanVien_NangLuong.ToList();

        }
        public tblNhanVien_NangLuong Add(tblNhanVien_NangLuong nl)
        {
            try
            {
                db.tblNhanVien_NangLuong.Add(nl);
                db.SaveChanges();
                return nl;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }

        }
        public tblNhanVien_NangLuong Edit(tblNhanVien_NangLuong nl)
        {
            try
            { 
                var _nl = db.tblNhanVien_NangLuong.FirstOrDefault(x => x.SoQuyetDinh == nl.SoQuyetDinh);
                _nl.SoHopDong = nl.SoHopDong;
                _nl.HeSoLuongHienTai = nl.HeSoLuongHienTai;
                _nl.MaNV = nl.MaNV;
                _nl.HeSoLuogMoi = nl.HeSoLuogMoi;
                _nl.GhiChu = nl.GhiChu;
                _nl.NgayKi = nl.NgayKi;
                _nl.NgayLenLuong = nl.NgayLenLuong;
                _nl.Update_By = nl.Update_By;
                _nl.Update_Date = nl.Update_Date;
                db.SaveChanges();
                return nl;
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
                var _nl = db.tblNhanVien_NangLuong.FirstOrDefault(x => x.SoQuyetDinh == soQD);
                _nl.Delete_By = idUser;
                _nl.Delete_Date = DateTime.Now;
                db.tblNhanVien_NangLuong.Remove(_nl);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }

        }
        public string MaxSoQuyetDinh(int loai)
        {
            var _hd = db.tblNhanVien_NangLuong.OrderByDescending(x => x.Creared_Date).FirstOrDefault();
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
