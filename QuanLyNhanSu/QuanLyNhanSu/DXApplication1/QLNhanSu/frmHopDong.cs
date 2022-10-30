using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DataPlayer;
using BusinessPlayer;
using QLNhanSu.Reports;
using DevExpress.XtraReports.UI;
using BusinessPlayer.DTO;

namespace QLNhanSu
{
    public partial class frmHopDong : DevExpress.XtraEditors.XtraForm
    {
        public frmHopDong()
        {
            InitializeComponent();
        }
        HopDong _hd;
        NhanVien _nhanvien;
        bool _them;
        string _sohd;
        string _MaxSoHD;
        List<HopDong_DTO> _lstHD;
        

        void _ShowHide(bool kt)
        {
            btnLuu.Enabled = !kt;
            btnHuy.Enabled = !kt;
            btnThem.Enabled = kt;
            btnSua.Enabled = kt;
            btnXoa.Enabled = kt;
            btnDong.Enabled = kt;
            btnPrint.Enabled = kt;
            gcHopDong.Enabled = kt;
            txtSoHopDong.Enabled =! kt;
            dtNgayBatDau.Enabled = !kt;
            dtNgayKetThuc.Enabled = !kt;
            dtNgayKi.Enabled = !kt;
            spHeSoLuong.Enabled = !kt;
            spLanKi.Enabled = !kt;
            seNhanVien.Enabled = !kt;
           
        }
        void LoadData()
        {
            gcHopDong.DataSource = _hd.getListFull();
            gvHopDong.OptionsBehavior.Editable = false;
           
        }
        void ReSet()
        {
            txtSoHopDong.Text = string.Empty;
            dtNgayBatDau.Value = DateTime.Now;
            dtNgayKetThuc.Value = dtNgayBatDau.Value.AddMonths(6);
            dtNgayKi.Value = DateTime.Now;
            spLanKi.Text = "1";
            spHeSoLuong.Text = "1";

        }
        void LoadNV()
        {
            seNhanVien.Properties.DataSource = _nhanvien.getList();
            seNhanVien.Properties.ValueMember = "MaNV";
            seNhanVien.Properties.DisplayMember = "HoTen";
        }
        void SaveData()
        {
            if (_them)
            {
                //số hd có dạng: 00001/2022/HĐLĐ
                var maxSoHD = _hd.MaxSoHD();
                int so = int.Parse(maxSoHD.Substring(0, 5)) + 1;
                tblHopDong hd = new tblHopDong();
                hd.SoHopDong = so.ToString("00000") + @"/2022/HĐLĐ";
                hd.NgayBatDau = dtNgayBatDau.Value;
                hd.NgayKetThuc = dtNgayKetThuc.Value;
                hd.NgayKy = dtNgayKi.Value;
                hd.ThoiHan = cbbThoiHan.Text;
                hd.HeSoLuong =double.Parse( spHeSoLuong.EditValue.ToString());
                hd.LanKy = int.Parse(spLanKi.EditValue.ToString());
                hd.MaNV =int.Parse (seNhanVien.EditValue.ToString());
                hd.IDCongTy = 1;
                hd.Create_By = 1;
                hd.Create_Date = DateTime.Now;
                hd.NoiDung = txtNoiDung.RtfText;
                _hd.Add(hd);

            }
            else
            {
                var hd = _hd.getItem(_sohd);
                hd.NgayBatDau = dtNgayBatDau.Value;
                hd.NgayKetThuc = dtNgayKetThuc.Value;
                hd.NgayKy = dtNgayKi.Value;
                hd.ThoiHan = cbbThoiHan.Text;
                hd.HeSoLuong = double.Parse(spHeSoLuong.EditValue.ToString());
                hd.LanKy = int.Parse(spLanKi.EditValue.ToString());
                hd.MaNV = int.Parse(seNhanVien.EditValue.ToString());
                hd.IDCongTy = 1;
                hd.Create_By = 1;
                hd.Create_Date = DateTime.Now;
                hd.NoiDung = txtNoiDung.RtfText;
                _hd.Edit(hd);
            }
        }
        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmHopDong_Load(object sender, EventArgs e)
        {
            _hd = new HopDong();
            _nhanvien = new NhanVien();
            _them = false;
            _ShowHide(true);
            LoadData();
            LoadNV();
            splitContainer1.Panel1Collapsed = true;
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _ShowHide(false);
            _them = true;  
            ReSet();
            splitContainer1.Panel1Collapsed = false;
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            _them = false;
            _ShowHide(false);
            splitContainer1.Panel1Collapsed = false;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (MessageBox.Show("Bạn có chắc chắn xóa không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                _hd.Delete(_sohd,1);
                LoadData();
            }
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            SaveData();
            LoadData();
            _them = false;
            _ShowHide(true);
            splitContainer1.Panel1Collapsed = true;
        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _them = false;

            _ShowHide(true);
            splitContainer1.Panel1Collapsed = true;
        }

        private void btnPrint_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _lstHD  = _hd.getItemFull(_sohd);
            rpHopDongLaoDong rpt = new rpHopDongLaoDong(_lstHD);
            rpt.ShowPreviewDialog();
        }

        private void btnDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void gvHopDong_Click(object sender, EventArgs e)
        {

            if (gvHopDong.RowCount > 0)
            {

                _sohd = gvHopDong.GetFocusedRowCellValue("SoHopDong").ToString();
                var hd = _hd.getItem(_sohd);
                txtSoHopDong.Text =_sohd;
                dtNgayBatDau.Value = hd.NgayBatDau.Value;
                dtNgayKetThuc.Value = hd.NgayKetThuc.Value;
                dtNgayKi.Value = hd.NgayKy.Value;
                cbbThoiHan.Text = hd.ThoiHan;
                spHeSoLuong.Text = hd.HeSoLuong.ToString();
                spLanKi.Text = hd.LanKy.ToString();
                seNhanVien.EditValue = hd.MaNV;
                txtNoiDung.RtfText = hd.NoiDung;
                _lstHD = _hd.getItemFull(_sohd);

            }
        }
    }
}