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
using QLNhanSu.Reports;
using DevExpress.XtraReports.UI;
using BusinessPlayer.DTO;

namespace QLNhanSu
{
    public partial class KhenThuongFrm : DevExpress.XtraEditors.XtraForm
    {
        public KhenThuongFrm()
        {
            InitializeComponent();
        }
        bool _them;
        string _soQD;
        KhenThuong _ktkl;
        NhanVien _nhanvien;
        List<KhenThuong_DTO> _lstKT;
        
        private void KhenThuongFrm_Load(object sender, EventArgs e)
        {
            _ktkl = new KhenThuong();
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
            gcKhenThuong.Enabled = kt;
            txtSoQD.Enabled = !kt;
            txtNoiDung.Enabled = !kt;
            txtLyDo.Enabled = !kt;
            //dtNgayBatDau.Enabled = !kt;
            //dtNgayKetThuc.Enabled = !kt;
            slkNhanVien.Enabled = !kt;

        }
        void LoadData()
        {
            gcKhenThuong.DataSource = _ktkl.getListFull(1);
            gvKhenThuong.OptionsBehavior.Editable = false;

        }
        void ReSet()
        {
            txtSoQD.Text = string.Empty;
            txtLyDo.Text = string.Empty;
            txtNoiDung.Text = string.Empty;
            //dtNgayBatDau.Value = DateTime.Now;
            //dtNgayKetThuc.Value = dtNgayBatDau.Value.AddMonths(6);
            

        }
        void LoadNV()
        {
            slkNhanVien.Properties.DataSource = _nhanvien.getList();
            slkNhanVien.Properties.ValueMember = "MaNV";
            slkNhanVien.Properties.DisplayMember = "HoTen";
        }
        void SaveData()
        {
            if (_them)
            {
                //số hd có dạng: 00001/2022/HĐLĐ
                var maxSoQD = _ktkl.MaxSoQuyetDinh(1);
                int so = int.Parse(maxSoQD.Substring(0, 5)) + 1;
                tblKhenThuong_KyLuat kt = new tblKhenThuong_KyLuat();
                kt.SoQuyetDinh = so.ToString("00000") + @"/2022/QDKT";
                //hd.NgayBatDau = dtNgayBatDau.Value;
                //hd.NgayKetThuc = dtNgayKetThuc.Value; 
                kt.LyDo = txtLyDo.Text;
                kt.Ngay = dtNgay.Value;
                kt.NoiDung = txtNoiDung.Text;
                kt.MaNV = int.Parse(slkNhanVien.EditValue.ToString());
                kt.Loai = 1;
                kt.Created_By = 1;
                kt.Created_Date = DateTime.Now;
                _ktkl.Add(kt);

            }
            else
            {
                var kt = _ktkl.getItem(_soQD);
                //hd.NgayBatDau = dtNgayBatDau.Value;
                //hd.NgayKetThuc = dtNgayKetThuc.Value;
                kt.LyDo = txtLyDo.Text;
                kt.Ngay = dtNgay.Value;
                kt.NoiDung = txtNoiDung.Text;
                kt.MaNV = int.Parse(slkNhanVien.EditValue.ToString());
                kt.Update_By = 1;
                kt.Update_Date = DateTime.Now;
                _ktkl.Edit(kt);
            }
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

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
                _ktkl.Delete(_soQD,1);
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
            _lstKT = _ktkl.getItemFull(_soQD);
            rpKhenThuongKyLuat rp = new rpKhenThuongKyLuat(_lstKT);
            rp.ShowPreviewDialog();
        }

        private void btnDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void gcKhenThuong_Click(object sender, EventArgs e)
        {
            if (gvKhenThuong.RowCount > 0)
            {
                _soQD = gvKhenThuong.GetFocusedRowCellValue("SoQuyetDinh").ToString();
                var kt = _ktkl.getItem(_soQD);
                txtSoQD.Text = _soQD;
                //dtNgayBatDau.Value = hd.NgayBatDau.Value;
                //dtNgayKetThuc.Value = hd.NgayKetThuc.Value;
                dtNgay.Value = kt.Ngay.Value;
                slkNhanVien.EditValue = kt.MaNV;
                txtNoiDung.Text = kt.NoiDung;
                txtLyDo.Text = kt.LyDo;
                _lstKT = _ktkl.getItemFull(_soQD);


            }
        }
    }
}