using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using BusinessPlayer.DTO;
using System.Collections.Generic;

namespace QLNhanSu.Reports
{
    public partial class rpHopDongLaoDong : DevExpress.XtraReports.UI.XtraReport
    {
        public rpHopDongLaoDong()
        {
            InitializeComponent();
        }
        public rpHopDongLaoDong(List<HopDong_DTO> lstHD)
        {
            InitializeComponent();
            this._lstHD = lstHD;
            this.DataSource = _lstHD;
            LoadData();
        }
        List<HopDong_DTO> _lstHD;
        void LoadData()
        {
            lblHDLD.DataBindings.Add("Text", _lstHD, "SoHopDong");
        }

    }
}
