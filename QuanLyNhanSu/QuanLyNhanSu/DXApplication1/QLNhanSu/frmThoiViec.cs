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
    public partial class frmThoiViec : DevExpress.XtraEditors.XtraForm
    {
        public frmThoiViec()
        {
            InitializeComponent();
        }
        bool _them;
        string _soQD;
        NhanVien_ThoiViec _nvtv;
        NhanVien _nhanvien;
        //List<DieuChuyen_DTO> _LstDC;
        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void frmThoiViec_Load(object sender, EventArgs e)
        {
            _nvtv = new NhanVien_ThoiViec();
            _nhanvien = new NhanVien();
            
            _them = false;
            _ShowHide(true);
            LoadNV();
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
            gcThoiViec.Enabled = kt;
            txtSoQD.Enabled = !kt;
            txtGhiChu.Enabled = !kt;
            dtNgayNopDon.Enabled =! kt;
            txtLyDo.Enabled = !kt;
            slkNhanVien.Enabled = !kt;

        }
        void LoadData()
        {
            gcThoiViec.DataSource = _nvtv.getListFull();
            gvThoiViec.OptionsBehavior.Editable = false;

        }
        void ReSet()
        {
            txtSoQD.Text = string.Empty;
            txtLyDo.Text = string.Empty;
            txtGhiChu.Text = string.Empty;
            dtNgayNopDon.Value = DateTime.Now;
            dtNgayNghi.Value = dtNgayNopDon.Value.AddDays(45);


        }
        void LoadNV()
        {
            slkNhanVien.Properties.DataSource = _nhanvien.getList();
            slkNhanVien.Properties.ValueMember = "MaNV";
            slkNhanVien.Properties.DisplayMember = "HoTen";
        }
        void SaveData()
        {
            tblThoiViec tv;

            if (_them)
            {
                //số hd có dạng: 00001/2022/HĐLĐ
                var maxSoQD = _nvtv.MaxSoQuyetDinh(1);
                int so = int.Parse(maxSoQD.Substring(0, 5)) + 1;
                tv = new tblThoiViec();
                tv.SoQuyetDinh = so.ToString("00000") + @"/" + DateTime.Now.Year.ToString() + @"/QDTV";
                tv.LyDo = txtLyDo.Text;
                tv.NgayNopDon = dtNgayNopDon.Value;
                tv.NgayNghi = dtNgayNghi.Value;
                tv.GhiChu = txtGhiChu.Text;
                tv.MaNV = int.Parse(slkNhanVien.EditValue.ToString());
                tv.Created_By = 1;
                tv.Created_Date = DateTime.Now;
                _nvtv.Add(tv);

            }
            else
            {
                tv = _nvtv.getItem(_soQD);
                tv.LyDo = txtLyDo.Text;
                tv.NgayNopDon = dtNgayNopDon.Value;
                tv.NgayNghi = dtNgayNghi.Value;
                tv.GhiChu = txtGhiChu.Text;
                tv.MaNV = int.Parse(slkNhanVien.EditValue.ToString());
                tv.Update_By = 1;
                tv.Update_Date = DateTime.Now;
                _nvtv.Edit(tv);
            }
            var nv = _nhanvien.getItem(tv.MaNV.Value);
            nv.DaThoiViec = true;
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
                _nvtv.Delete(_soQD, 1);
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

        private void gcThoiViec_Click(object sender, EventArgs e)
        {
            if (gvThoiViec.RowCount > 0)
            {
                _soQD = gvThoiViec.GetFocusedRowCellValue("SoQuyetDinh").ToString();
                var tv = _nvtv.getItem(_soQD);
                txtSoQD.Text = _soQD;
                dtNgayNopDon.Value = tv.NgayNopDon.Value;
                dtNgayNghi.Value = tv.NgayNghi.Value;
                slkNhanVien.EditValue = tv.MaNV;
                txtGhiChu.Text = tv.GhiChu;
                txtLyDo.Text = tv.LyDo;
                //_LstDC = _nvtv.getItemFull(_soQD);


            }
        }

        private void dtNgayNopDon_ValueChanged(object sender, EventArgs e)
        {
            dtNgayNghi.Value = dtNgayNopDon.Value.AddDays(45);
        }
    }
}