//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataPlayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblHopDong
    {
        public string SoHopDong { get; set; }
        public Nullable<System.DateTime> NgayBatDau { get; set; }
        public Nullable<System.DateTime> NgayKetThuc { get; set; }
        public Nullable<System.DateTime> NgayKy { get; set; }
        public string NoiDung { get; set; }
        public Nullable<int> LanKy { get; set; }
        public string ThoiHan { get; set; }
        public Nullable<double> HeSoLuong { get; set; }
        public Nullable<int> MaNV { get; set; }
        public Nullable<int> IDCongTy { get; set; }
        public Nullable<int> Delete_By { get; set; }
        public Nullable<System.DateTime> Delete_Date { get; set; }
        public Nullable<int> Update_By { get; set; }
        public Nullable<System.DateTime> Update_Date { get; set; }
        public Nullable<int> Create_By { get; set; }
        public Nullable<System.DateTime> Create_Date { get; set; }
    
        public virtual tblNhanVien tblNhanVien { get; set; }
    }
}
