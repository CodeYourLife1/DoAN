using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessPlayer.DTO
{
   public class NangLuong_DTO
    {
        public string SoQuyetDinh { get; set; }
        public string SoHopDong { get; set; }
        public Nullable<int> MaNV { get; set; }
        public string HoTen { get; set; }
        public Nullable<double> HeSoLuongHienTai { get; set; }
        public Nullable<double> HeSoLuogMoi { get; set; }
        public Nullable<System.DateTime> NgayLenLuong { get; set; }
        public Nullable<System.DateTime> NgayKi { get; set; }
        public string GhiChu { get; set; }
        public Nullable<int> Created_By { get; set; }
        public Nullable<System.DateTime> Creared_Date { get; set; }
        public Nullable<int> Update_By { get; set; }
        public Nullable<System.DateTime> Update_Date { get; set; }
        public Nullable<int> Delete_By { get; set; }
        public Nullable<System.DateTime> Delete_Date { get; set; }
    }
}
