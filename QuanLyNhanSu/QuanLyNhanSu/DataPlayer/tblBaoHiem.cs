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
    
    public partial class tblBaoHiem
    {
        public int IDBaoHiem { get; set; }
        public string SoBaoHiem { get; set; }
        public Nullable<System.DateTime> NgayCap { get; set; }
        public string NoiCap { get; set; }
        public string NoiKhamBenh { get; set; }
        public Nullable<int> MaNV { get; set; }
    
        public virtual tblNhanVien tblNhanVien { get; set; }
    }
}