using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataPlayer;
namespace BusinessPlayer.DTO
{
   public class NhanVienDTO
    {
        public int MaNV { get; set; }
        public string HoTen { get; set; }
        public Nullable<bool> GioiTinh { get; set; }
        public Nullable<System.DateTime> NgaySinh { get; set; }
        public string DienThoai { get; set; }
        public string CCCD { get; set; }
        public string DiaChi { get; set; }
        public byte[] HinhAnh { get; set; }
        public bool? ThoiViec { set; get; }
        public Nullable<int> IDPhongBan { get; set; }
        public string TenPhongBan { get; set; }
        public Nullable<int> IDBoPhan { get; set; }
        public string TenBoPhan { get; set; }
        public Nullable<int> IDChucVu { get; set; }
        public string TenChucVu { get; set; }
        public Nullable<int> IDTrinhDo { get; set; }
        public string TenTrinhDo { get; set; }
        public Nullable<int> IDDanToc { get; set; }
        public string TenDanToc { get; set; }
        public Nullable<int> IDTonGiao { get; set; }
        public string TenTonGiao { get; set; }
        public Nullable<int> IDCongTy { get; set; }
        


    }
}
