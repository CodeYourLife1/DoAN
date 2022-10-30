using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessPlayer.DTO
{
    public class KhenThuong_DTO
    {
        public string SoQuyetDinh { get; set; }
        public string LyDo { get; set; }
        public string NoiDung { get; set; }
        public Nullable<System.DateTime> Ngay { get; set; }
        public Nullable<int> MaNV { get; set; }
        public string HoTen { set; get; }
        public Nullable<int> Loai { get; set; }
        public Nullable<System.DateTime> TuNgay { get; set; }
        public Nullable<System.DateTime> DenNgay { get; set; }
        public Nullable<int> Created_By { get; set; }
        public Nullable<System.DateTime> Created_Date { get; set; }
        public Nullable<int> Update_By { get; set; }
        public Nullable<System.DateTime> Update_Date { get; set; }
        public Nullable<int> Delete_By { get; set; }
        public Nullable<System.DateTime> Delete_Date { get; set; }
    }
}
