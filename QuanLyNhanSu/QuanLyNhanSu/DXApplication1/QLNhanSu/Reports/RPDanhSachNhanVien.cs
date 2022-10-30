using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;
using BusinessPlayer.DTO;

namespace QLNhanSu.Reports
{
    public partial class RPDanhSachNhanVien : DevExpress.XtraReports.UI.XtraReport
    {
        public RPDanhSachNhanVien()
        {
            InitializeComponent();
        }
        List<NhanVienDTO> _lstNV;
        public RPDanhSachNhanVien(List<NhanVienDTO>lstNV)
        {
            InitializeComponent();
            this._lstNV = lstNV;
            this.DataSource = _lstNV;
            LoadData();
        }
        void LoadData()
        {
            tblID.DataBindings.Add("Text", _lstNV,"MaNV");
            tblHoTen.DataBindings.Add("Text", _lstNV, "HoTen");
            tblGioiTinh.DataBindings.Add("Text", _lstNV, "GioiTinh");
            tblDienThoai.DataBindings.Add("Text", _lstNV, "DienThoai");
            tblDiaChi.DataBindings.Add("Text", _lstNV, "DiaChi");
            tblDanToc.DataBindings.Add("Text", _lstNV, "TenDanToc");
            tblTonGiao.DataBindings.Add("Text", _lstNV, "TenTonGiao");
            tblNgaySinh.DataBindings.Add("Text", _lstNV, "NgaySinh");
            tblPhongBan.DataBindings.Add("Text", _lstNV, "TenPhongBan");
            tblTrinhDo.DataBindings.Add("Text", _lstNV, "TenTrinhDo");
            tblChucVu.DataBindings.Add("Text", _lstNV, "TenChucVu");
            tblCCCD.DataBindings.Add("Text", _lstNV, "CCCD");
            tblBoPhan.DataBindings.Add("Text", _lstNV, "TenBoPhan");


        }
    }
}
