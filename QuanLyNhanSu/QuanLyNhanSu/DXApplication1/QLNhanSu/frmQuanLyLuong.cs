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
using BusinessPlayer;
using DataPlayer;
namespace QLNhanSu
{
    public partial class frmQuanLyLuong : DevExpress.XtraEditors.XtraForm
    {
        public frmQuanLyLuong()
        {
            InitializeComponent();
        }
        bool _them;
        string _soQD;
        NhanVien_NangLuong _nvnl;
        HopDong _hopdong;
        NhanVien _nhanvien;
        //List<DieuChuyen_DTO> _LstDC;
        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmQuanLyLuong_Load(object sender, EventArgs e)
        {
            _nvnl = new NhanVien_NangLuong();
            _hopdong = new HopDong();
            _nhanvien = new NhanVien();
            _them = false;
            _ShowHide(true);
            LoadHopDong();
            LoadData();
            splitContainer1.Panel1Collapsed = true;
        }
        void _ShowHide(bool kt)
        {
            btnLuu.Enabled = !kt;
            btnHuy.Enabled = !kt;
            btnThem.Enabled = kt;
            btnSua.Enabled = kt;
            btnXoa.Enabled = kt;
            btnDong.Enabled = kt;
            btnPrint.Enabled = kt;
            gcNangLuong.Enabled = kt;
            txtSoQD.Enabled = !kt;
            txtGhiChu.Enabled = !kt;
            slkHopDong.Enabled = !kt;

        }
        void LoadData()
        {
            gcNangLuong.DataSource = _nvnl.getListFull();
            gvNangLuong.OptionsBehavior.Editable = false;

        }
        void ReSet()
        {
            txtSoQD.Text = string.Empty;
            txtGhiChu.Text = string.Empty;
            //dtNgayBatDau.Value = DateTime.Now;
            //dtNgayKetThuc.Value = dtNgayBatDau.Value.AddMonths(6);


        }
        void LoadHopDong()
        {
            slkHopDong.Properties.DataSource = _hopdong.getListFull();
            slkHopDong.Properties.ValueMember = "SoHopDong";
            slkHopDong.Properties.DisplayMember = "SoHopDong";
        }
        void SaveData()
        {
            tblNhanVien_NangLuong nl;

            if (_them)
            {
                //số hd có dạng: 00001/2022/HĐLĐ
                var maxSoQD = _nvnl.MaxSoQuyetDinh(1);
                int so = int.Parse(maxSoQD.Substring(0, 5)) + 1;
                nl = new tblNhanVien_NangLuong();
                nl.SoQuyetDinh = so.ToString("00000") + @"/" + DateTime.Now.Year.ToString() + @"/QDNL";
                nl.SoHopDong = slkHopDong.EditValue.ToString();
                nl.NgayKi = dtNgayKi.Value;
                nl.NgayLenLuong = dtNgayLenLuong.Value;
                nl.HeSoLuongHienTai = _hopdong.getItem(slkHopDong.EditValue.ToString()).HeSoLuong;
                nl.HeSoLuogMoi = double.Parse(spHSLmoi.EditValue.ToString());
                nl.GhiChu = txtGhiChu.Text;
                nl.MaNV = _hopdong.getItem(slkHopDong.EditValue.ToString()).MaNV;
                nl.Created_By = 1;
                nl.Creared_Date = DateTime.Now;
                _nvnl.Add(nl);

            }
            else
            {
                nl = _nvnl.getItem(_soQD);
                nl.SoHopDong = slkHopDong.EditValue.ToString();
                nl.NgayKi = dtNgayKi.Value;
                nl.NgayLenLuong = dtNgayLenLuong.Value;
                nl.HeSoLuongHienTai = _hopdong.getItem(slkHopDong.EditValue.ToString()).HeSoLuong;
                nl.HeSoLuogMoi = double.Parse(spHSLmoi.EditValue.ToString());
                nl.GhiChu = txtGhiChu.Text;
                nl.MaNV = _hopdong.getItem(slkHopDong.EditValue.ToString()).MaNV;
                nl.Update_By = 1;
                nl.Update_Date = DateTime.Now;
                _nvnl.Edit(nl);
            }
            var hd = _hopdong.getItem(slkHopDong.EditValue.ToString());
            hd.HeSoLuong =double.Parse( spHSLmoi.EditValue.ToString());
            _hopdong.Edit(hd);
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
                _nvnl.Delete(_soQD, 1);
                var hd = _hopdong.getItem(slkHopDong.EditValue.ToString());
                hd.HeSoLuong = double.Parse(spHSLcu.EditValue.ToString());
                _hopdong.Edit(hd);
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

        }

        private void btnDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void gvNangLuong_Click(object sender, EventArgs e)
        {
            if (gvNangLuong.RowCount > 0)
            {
                _soQD = gvNangLuong.GetFocusedRowCellValue("SoQuyetDinh").ToString();
                var nl = _nvnl.getItem(_soQD);
                txtSoQD.Text = _soQD;
                dtNgayKi.Value = nl.NgayKi.Value;
                dtNgayLenLuong.Value = nl.NgayLenLuong.Value;
                slkHopDong.EditValue = nl.SoHopDong;
                txtGhiChu.Text = nl.GhiChu;
                spHSLcu.EditValue = nl.HeSoLuongHienTai;
                spHSLmoi.EditValue = nl.HeSoLuogMoi;
                txtNhanVien.Text = gvNangLuong.GetFocusedRowCellValue("HoTen").ToString();
                //_LstDC = _nvdc.getItemFull(_soQD);
            }
        }

        private void slkHongDong_EditValueChanged(object sender, EventArgs e)
        {
            var hd = _hopdong.getItemFull(slkHopDong.EditValue.ToString());
            if (hd.Count!=0)
            {
                txtNhanVien.Text = hd[0].MaNV + " - " + hd[0].HoTen;
                spHSLcu.EditValue = hd[0].HeSoLuong;
            }
        }
    }
}