using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BusinessPlayer.DTO
{
   public class HopDong_DTO
    {
        public string SoHopDong { get; set; }
        public string NgayBatDau { get; set; }
        public string NgayKetThuc { get; set; }
        public string NgayKy { get; set; }
        public string NoiDung { get; set; }
        public Nullable<int> LanKy { get; set; }
        public string ThoiHan { get; set; }
        public Nullable<double> HeSoLuong { get; set; }
        public Nullable<int> MaNV { get; set; }
        public string  HoTen { get; set; }
        public string DienThoai { get; set; }
        public string CCCD { get; set; }
        public string DiaChi { get; set; }
        public string NgaySinh { get; set; }
        public string TenTrinhDo { get; set; }


        public Nullable<int> IDTrinhDo { get; set; }
        public Nullable<int> IDCongTy { get; set; }
        public Nullable<int> Delete_By { get; set; }
        public Nullable<System.DateTime> Delete_Date { get; set; }
        public Nullable<int> Update_By { get; set; }
        public Nullable<System.DateTime> Update_Date { get; set; }
        public Nullable<int> Create_By { get; set; }
        public Nullable<System.DateTime> Create_Date { get; set; }
        
    }
}
