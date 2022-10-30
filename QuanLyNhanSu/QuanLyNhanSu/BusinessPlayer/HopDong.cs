using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataPlayer;
using BusinessPlayer.DTO;

namespace BusinessPlayer
{
   public class HopDong
    {
        QuanLyNhanSuEntities db = new QuanLyNhanSuEntities();
        public tblHopDong getItem(string sohd)
        {
            return db.tblHopDongs.FirstOrDefault(x => x.SoHopDong == sohd);

        }
        public List<HopDong_DTO> getItemFull(string sohd)
        {
            List<tblHopDong> lstHD = db.tblHopDongs.Where(x=>x.SoHopDong==sohd).ToList();
            List<HopDong_DTO> lstDTO = new List<HopDong_DTO>();
            HopDong_DTO hd;
            foreach (var item in lstHD)
            {
                hd = new HopDong_DTO();
                hd.SoHopDong = item.SoHopDong;
                hd.NgayBatDau =  item.NgayBatDau.Value.ToString("dd/MM/yyyy");
                hd.NgayKetThuc = item.NgayKetThuc.Value.ToString("dd/MM/yyyy");
                hd.NgayKy = item.NgayKy.Value.ToString();
                hd.LanKy = item.LanKy;
                hd.HeSoLuong = item.HeSoLuong;
                hd.NoiDung = item.NoiDung;
                hd.ThoiHan = item.ThoiHan;
                hd.MaNV = item.MaNV;
                
                var nv = db.tblNhanViens.FirstOrDefault(n => n.MaNV == item.MaNV);
                hd.CCCD = nv.CCCD;
                hd.NgaySinh = nv.NgaySinh.Value.ToString("dd/MM/yyyy");
                hd.DienThoai = nv.DienThoai;
                hd.DiaChi = nv.DiaChi;              
                hd.HoTen = nv.HoTen;
                
                
                
                hd.Create_By = item.Create_By;
                hd.Create_Date = item.Create_Date;
                hd.Update_By = item.Update_By;
                hd.Update_Date = item.Update_Date;
                hd.Delete_By = item.Delete_By;
                hd.Delete_Date = item.Delete_Date;
                hd.IDCongTy = item.IDCongTy;
                
                lstDTO.Add(hd);
            }
            return lstDTO;

        }
        public List<tblHopDong> getList()
        {
            return db.tblHopDongs.ToList();
        }
        public List<HopDong_DTO> getListFull()
        {
            List<tblHopDong>lstHD = db.tblHopDongs.ToList();
            List<HopDong_DTO> lstDTO = new List<HopDong_DTO>();
            HopDong_DTO hd;
            foreach(var item in lstHD)
            {
                hd = new HopDong_DTO();
                hd.SoHopDong = item.SoHopDong;
                hd.NgayBatDau = item.NgayBatDau.ToString();
                hd.NgayKetThuc = item.NgayKetThuc.ToString();
                hd.NgayKy = item.NgayKy.ToString();
                hd.LanKy = item.LanKy;
                hd.HeSoLuong = item.HeSoLuong;
                hd.NoiDung = item.NoiDung;
                hd.ThoiHan = item.ThoiHan;
                hd.MaNV = item.MaNV;
                
                var nv = db.tblNhanViens.FirstOrDefault(n => n.MaNV == item.MaNV);
                hd.HoTen = nv.HoTen;
                hd.CCCD = nv.CCCD;
                hd.DienThoai = nv.DienThoai;
                hd.DiaChi = nv.DiaChi;
                
                
                hd.NgaySinh = nv.NgaySinh.Value.ToString("dd/MM/yyyy");
                hd.Create_By = item.Create_By;
                hd.Create_Date = item.Create_Date;
                hd.Update_By = item.Update_By;
                hd.Update_Date = item.Update_Date;
                hd.Delete_By = item.Delete_By;
                hd.Delete_Date = item.Delete_Date;
                hd.IDCongTy = item.IDCongTy;
                
                lstDTO.Add(hd);
            }
            return lstDTO;
        }
        public tblHopDong Add(tblHopDong hd)
        {
            try
            {
                db.tblHopDongs.Add(hd);
                db.SaveChanges();
                return hd;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
        public tblHopDong Edit(tblHopDong hd)
        {
            try
            {
                var _hd = db.tblHopDongs.FirstOrDefault(x => x.SoHopDong == hd.SoHopDong);
                _hd.NgayBatDau = hd.NgayBatDau;
                _hd.NgayKetThuc = hd.NgayKetThuc;
                _hd.MaNV = hd.MaNV;
                _hd.NgayKy = hd.NgayKy;
                _hd.LanKy = hd.LanKy;
                _hd.HeSoLuong = hd.HeSoLuong;
                _hd.NoiDung = hd.NoiDung;
                _hd.ThoiHan = hd.ThoiHan;
                _hd.SoHopDong = hd.SoHopDong;
                _hd.IDCongTy = hd.IDCongTy;
                _hd.Update_By = hd.Update_By;
                _hd.Update_Date = hd.Update_Date;
                db.SaveChanges();
                return hd;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
        public void Delete(string sohd,int manv)
        {
            try
            {
                var _hd = db.tblHopDongs.FirstOrDefault(x => x.SoHopDong == sohd);
                _hd.Delete_By = manv ;
                _hd.Delete_Date = DateTime.Now;
                db.tblHopDongs.Remove(_hd);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
        public string MaxSoHD()
        {
            var _hd = db.tblHopDongs.OrderByDescending(x => x.Create_Date).FirstOrDefault();
            if(_hd!=null)
            {
                return _hd.SoHopDong;
            }
            else
            {
                return "00000";
            }
        }
        public List<HopDong_DTO> getLenLuong()
        {
            List<tblHopDong> lstHD = db.tblHopDongs.Where(x=>(x.NgayBatDau.Value.Month - DateTime.Now.Month) == 0 &&  (DateTime.Now.Year - x.NgayBatDau.Value.Year) == 2).ToList();
            List<HopDong_DTO> lstDTO = new List<HopDong_DTO>();
            HopDong_DTO hd;
            foreach (var item in lstHD)
            {
                hd = new HopDong_DTO();
                hd.SoHopDong = item.SoHopDong; 
                hd.NgayBatDau = item.NgayBatDau.ToString();
                hd.NgayKetThuc = item.NgayKetThuc.ToString();
                hd.NgayKy = item.NgayKy.ToString();
                hd.LanKy = item.LanKy;
                hd.HeSoLuong = item.HeSoLuong;
                hd.NoiDung = item.NoiDung;
                hd.ThoiHan = item.ThoiHan;
                hd.MaNV = item.MaNV;

                var nv = db.tblNhanViens.FirstOrDefault(n => n.MaNV == item.MaNV);
                hd.HoTen = nv.HoTen;
                hd.CCCD = nv.CCCD;
                hd.DienThoai = nv.DienThoai;
                hd.DiaChi = nv.DiaChi;


                hd.NgaySinh = nv.NgaySinh.Value.ToString("dd/MM/yyyy");
                hd.Create_By = item.Create_By;
                hd.Create_Date = item.Create_Date;
                hd.Update_By = item.Update_By;
                hd.Update_Date = item.Update_Date;
                hd.Delete_By = item.Delete_By;
                hd.Delete_Date = item.Delete_Date;
                hd.IDCongTy = item.IDCongTy;

                lstDTO.Add(hd);
            }
            return lstDTO;
        }
    }
}
