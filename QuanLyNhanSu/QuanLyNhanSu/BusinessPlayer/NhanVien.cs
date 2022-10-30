using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataPlayer;
using BusinessPlayer.DTO;

namespace BusinessPlayer
{
   public class NhanVien
    {
        QuanLyNhanSuEntities db = new QuanLyNhanSuEntities();
        public tblNhanVien getItem(int id)
        {
            return db.tblNhanViens.FirstOrDefault(x => x.MaNV == id);

        }
        public List<tblNhanVien> getList()
        {
            return db.tblNhanViens.ToList();
        }
        
        public List<NhanVienDTO> getListFull()
        {
            var lstNV = db.tblNhanViens.ToList();
            List<NhanVienDTO> lstNVDTO = new List<NhanVienDTO>();
            NhanVienDTO nvDTO;
            foreach(var item in lstNV)
            {
                nvDTO = new NhanVienDTO();
                nvDTO.MaNV = item.MaNV;
                nvDTO.NgaySinh = item.NgaySinh;
                nvDTO.HoTen = item.HoTen;
                nvDTO.GioiTinh = item.GioiTinh;
                nvDTO.CCCD = item.CCCD;
                nvDTO.DienThoai = item.DienThoai;
                nvDTO.DiaChi = item.DiaChi;
                nvDTO.HinhAnh = item.HinhAnh;
                nvDTO.ThoiViec = item.DaThoiViec;
                nvDTO.IDBoPhan = item.IDBoPhan;
                var bp = db.tblBoPhans.FirstOrDefault(x => x.IDBoPhan == item.IDBoPhan);
                nvDTO.TenBoPhan = bp.TenBoPhan;

                nvDTO.IDChucVu = item.IDChucVu;
                var cv = db.tblChucVus.FirstOrDefault(e => e.IDChucVu == item.IDChucVu);
                nvDTO.TenChucVu = cv.TenChucVu;

                nvDTO.IDDanToc = item.IDDanToc;
                var dt = db.tblDanTocs.FirstOrDefault(d => d.ID == item.IDDanToc);
                nvDTO.TenDanToc = dt.TenDanToc;

                nvDTO.IDPhongBan = item.IDPhongBan;
                var pb = db.tblPhongBans.FirstOrDefault(c => c.IDPhongBan == item.IDPhongBan);
                nvDTO.TenPhongBan = pb.TenPhongBan;

                nvDTO.IDTrinhDo = item.IDTrinhDo;
                var td = db.tblTrinhDoes.FirstOrDefault(a => a.IDTrinhDo == item.IDTrinhDo);
                nvDTO.TenTrinhDo = td.TenTrinhDo;

                nvDTO.IDTonGiao = item.IDTonGiao;
                var tg = db.tblTonGiaos.FirstOrDefault(t => t.ID == item.IDTonGiao);
                nvDTO.TenTonGiao = tg.TenTonGiao;

                lstNVDTO.Add(nvDTO);

            }
            return lstNVDTO;
        }
        public tblNhanVien Add(tblNhanVien nv)
        {
            try
            {
                db.tblNhanViens.Add(nv);
                db.SaveChanges();
                return nv;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
        public tblNhanVien Edit(tblNhanVien nv)
        {
            try
            {
                var _nv = db.tblNhanViens.FirstOrDefault(x => x.MaNV == nv.MaNV);
                _nv.HoTen = nv.HoTen;
                _nv.GioiTinh = nv.GioiTinh;
                _nv.CCCD = nv.CCCD;
                _nv.NgaySinh = nv.NgaySinh;
                _nv.DiaChi = nv.DiaChi;
                _nv.DienThoai = nv.DienThoai;
                _nv.HinhAnh = nv.HinhAnh;
                _nv.DaThoiViec = nv.DaThoiViec;
                _nv.IDPhongBan = nv.IDPhongBan;
                _nv.IDDanToc = nv.IDDanToc;
                _nv.IDBoPhan = nv.IDBoPhan;
                _nv.IDChucVu = nv.IDChucVu;
                _nv.IDTonGiao = nv.IDTonGiao;
                _nv.IDTrinhDo = nv.IDTrinhDo;
                _nv.IDCongTy = nv.IDCongTy;
                db.SaveChanges();
                return nv;
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
                var _nv = db.tblNhanViens.FirstOrDefault(x => x.MaNV == id);
                db.tblNhanViens.Remove(_nv);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
        public List<tblNhanVien>GetSinhNhat()
        {
            return db.tblNhanViens.Where(x => x.NgaySinh.Value.Month == DateTime.Now.Month).ToList();
        }
    }
}
