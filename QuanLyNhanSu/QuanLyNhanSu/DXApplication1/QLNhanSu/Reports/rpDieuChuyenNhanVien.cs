using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using BusinessPlayer.DTO;
using System.Collections.Generic;

namespace QLNhanSu.Reports
{
    public partial class rpDieuChuyenNhanVien : DevExpress.XtraReports.UI.XtraReport
    {
        public rpDieuChuyenNhanVien()
        {
            InitializeComponent();
        }
        public rpDieuChuyenNhanVien(List<DieuChuyen_DTO> lstKT)
        {
            InitializeComponent();
            this._lstKT = lstKT;
            this.DataSource = _lstKT;
            LoadData();

        }
        List<DieuChuyen_DTO> _lstKT;
        void LoadData()
        {
            lblSoQD.DataBindings.Add("Text", _lstKT, "SoQuyetDinh");
        }

    }
}
