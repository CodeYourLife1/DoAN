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
using BusinessPlayer.DTO;
using QLNhanSu.Reports;
using DevExpress.XtraReports.UI;

namespace QLNhanSu
{
    public partial class frmNhanVien_DieuChuyen : DevExpress.XtraEditors.XtraForm
    {
        public frmNhanVien_DieuChuyen()
        {
            InitializeComponent();
        }
        bool _them;
        string _soQD;
        NhanVien_DieuChuyen _nvdc;
        NhanVien _nhanvien;
        PhongBan _phongban;
        List<DieuChuyen_DTO> _LstDC;
        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmNhanVien_DieuChuyen_Load(object sender, EventArgs e)
        {
            _nvdc = new NhanVien_DieuChuyen();
            _nhanvien = new NhanVien();
            _phongban = new PhongBan();
            _them = false;
            _ShowHide(true);
            LoadNV();
            LoadData();
            LoadDonViDen();
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
            gcDieuChuyen.Enabled = kt;
            txtSoQD.Enabled = !kt;
            txtGhiChu.Enabled = !kt;
            cbbDonVi.Enabled = !kt;
            txtLyDo.Enabled = !kt;
            slkNhanVien.Enabled = !kt;

        }
        void LoadData()
        {
            gcDieuChuyen.DataSource = _nvdc.getListFull();
            gvDieuChuyen.OptionsBehavior.Editable = false;

        }
        void ReSet()
        {
            txtSoQD.Text = string.Empty;
            txtLyDo.Text = string.Empty;
            txtGhiChu.Text = string.Empty;
            //dtNgayBatDau.Value = DateTime.Now;
            //dtNgayKetThuc.Value = dtNgayBatDau.Value.AddMonths(6);


        }
        void LoadDonViDen()
        {
            cbbDonVi.DataSource = _phongban.getList();
            cbbDonVi.DisplayMember = "TenPhongBan";
            cbbDonVi.ValueMember = "IDPhongBan";
        }
        void LoadNV()
        {
            slkNhanVien.Properties.DataSource = _nhanvien.getList();
            slkNhanVien.Properties.ValueMember = "MaNV";
            slkNhanVien.Properties.DisplayMember = "HoTen";
        }
        void SaveData()
        {
            tblDieuChuyen dc;

            if (_them)
            {
                //số hd có dạng: 00001/2022/HĐLĐ
                var maxSoQD = _nvdc.MaxSoQuyetDinh(1);
                int so = int.Parse(maxSoQD.Substring(0, 5)) + 1;
                dc = new tblDieuChuyen();
                dc.SoQuyetDinh = so.ToString("00000") + @"/"+ DateTime.Now.Year.ToString()+@"/QDDC";
                dc.LyDo = txtLyDo.Text;
                dc.Ngay = dtNgay.Value;
                dc.GhiChu = txtGhiChu.Text;
                dc.MaNV = int.Parse(slkNhanVien.EditValue.ToString());
                dc.MaPB = _nhanvien.getItem(int.Parse(slkNhanVien.EditValue.ToString())).IDPhongBan;
                dc.MaPB2 = int.Parse(cbbDonVi.SelectedValue.ToString());
                dc.Created_By = 1;
                dc.Created_Date = DateTime.Now;
                _nvdc.Add(dc);

            }
            else
            {
                dc = _nvdc.getItem(_soQD);
                dc.LyDo = txtLyDo.Text;
                dc.Ngay = dtNgay.Value;
                dc.GhiChu = txtGhiChu.Text;
                dc.MaNV = int.Parse(slkNhanVien.EditValue.ToString());
                dc.MaPB = _nhanvien.getItem(int.Parse(slkNhanVien.EditValue.ToString())).IDPhongBan;
                dc.MaPB2 = int.Parse(cbbDonVi.SelectedValue.ToString());
                dc.Update_By = 1;
                dc.Update_Date = DateTime.Now;
                _nvdc.Edit(dc);
            }
            var nv = _nhanvien.getItem(dc.MaNV.Value);
            nv.IDPhongBan = dc.MaPB2;
            _nhanvien.Edit(nv);

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
                _nvdc.Delete(_soQD, 1);
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
            _LstDC = _nvdc.getItemFull(_soQD);
            rpDieuChuyenNhanVien rp = new rpDieuChuyenNhanVien(_LstDC);
            rp.ShowPreviewDialog();
        }

        private void btnDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void gcDieuChuyen_Click(object sender, EventArgs e)
        {
            if (gvDieuChuyen.RowCount > 0)
            {
                _soQD = gvDieuChuyen.GetFocusedRowCellValue("SoQuyetDinh").ToString();
                var dc = _nvdc.getItem(_soQD);
                txtSoQD.Text = _soQD;
                dtNgay.Value = dc.Ngay.Value;
                slkNhanVien.EditValue = dc.MaNV;
                txtGhiChu.Text = dc.GhiChu;
                txtLyDo.Text = dc.LyDo;
                cbbDonVi.SelectedValue = dc.MaPB2;
                _LstDC = _nvdc.getItemFull(_soQD);


            }
        }
    }
    
}