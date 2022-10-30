﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessPlayer.DTO
{
   public class NhanVienThoiViec_DTO
    {
        public string SoQuyetDinh { get; set; }
        public Nullable<int> MaNV { get; set; }
        public string HoTen { set; get; }
        public Nullable<System.DateTime> NgayNopDon { get; set; }
        public Nullable<System.DateTime> NgayNghi { get; set; }
        public string LyDo { get; set; }
        public string GhiChu { get; set; }
        public Nullable<int> Created_By { get; set; }
        public Nullable<System.DateTime> Created_Date { get; set; }
        public Nullable<int> Update_By { get; set; }
        public Nullable<System.DateTime> Update_Date { get; set; }
        public Nullable<int> Delete_By { get; set; }
        public Nullable<System.DateTime> Delete_Date { get; set; }
    }
}
