using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessPlayer.DTO
{
  public  class DieuChuyen_DTO
    {
        public string SoQuyetDinh { get; set; }
        public Nullable<System.DateTime> Ngay { get; set; }
        public Nullable<int> MaNV { get; set; }
        public Nullable<int> MaPB { get; set; }
        public Nullable<int> MaPB2 { get; set; }
        public string TenPhongBan2 { get; set; }
        public string HoTen { get; set; }
        public string TenPhongBan { get; set; }
        public string LyDo { get; set; }
        public string GhiChu { get; set; }
        public Nullable<System.DateTime> Created_Date { get; set; }
        public Nullable<int> Created_By { get; set; }
        public Nullable<System.DateTime> Update_Date { get; set; }
        public Nullable<int> Update_By { get; set; }
        public Nullable<System.DateTime> Delete_Date { get; set; }
        public Nullable<int> Delete_By { get; set; }
    }
}
