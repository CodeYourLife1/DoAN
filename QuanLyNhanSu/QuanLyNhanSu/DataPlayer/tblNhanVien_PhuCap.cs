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
    
    public partial class tblNhanVien_PhuCap
    {
        public int ID { get; set; }
        public Nullable<int> MaNV { get; set; }
        public Nullable<int> IDPhuCap { get; set; }
        public Nullable<System.DateTime> Ngay { get; set; }
        public string NoiDung { get; set; }
        public Nullable<double> SoTien { get; set; }
    
        public virtual tblNhanVien tblNhanVien { get; set; }
        public virtual tblPhuCap tblPhuCap { get; set; }
    }
}
