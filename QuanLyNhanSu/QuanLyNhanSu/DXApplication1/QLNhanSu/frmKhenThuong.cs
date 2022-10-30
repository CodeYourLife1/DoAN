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
    public partial class frmKhenThuong : DevExpress.XtraEditors.XtraForm
    {
        public frmKhenThuong()
        {
            InitializeComponent();
        }
        bool _them;
        string _soQD;
        KhenThuong_KyLuat _ktkl;
        NhanVien _nhanvien;

        private void frmKhenThuong_Load(object sender, EventArgs e)
        {
            _ktkl = new KhenThuong_KyLuat();
            _nhanvien = new NhanVien();
            _them = false;
            _ShowHide(true);
            LoadNV();
            LoadData();
           
            splitContainer1.Panel1Collapsed = true;
        }
       private void _ShowHide(bool kt)
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
            //dtNgayBatDau.Enabled = !kt;
            //dtNgayKetThuc.Enabled = !kt;
            //dtNgayKi.Enabled = !kt;
            txtNoiDung.Enabled = !kt;
            txtLyDo.Enabled = !kt;
            slkNhanVien.Enabled = !kt;
            


        }
      private  void LoadData()
        {
            gcKhenThuong.DataSource = _ktkl.getList(1);
            gvKhenThuong.OptionsBehavior.Editable = false;

        }
       private void ReSet()
        {
            txtSoQD.Text = string.Empty;
            txtLyDo.Text = string.Empty;
            txtNoiDung.Text = string.Empty;
            //dtNgayBatDau.Value = DateTime.Now;
            //dtNgayBatDau.Value = dtNgayBatDau.Value.AddMonths(6);
           

        }
      private  void SaveData()
        {
            if (_them)
            {
                //số hd có dạng: 00001/2022/HĐLĐ
                var maxSoQD = _ktkl.MaxSoQD(1);
                int so = int.Parse(maxSoQD.Substring(0, 5)) + 1;
                tblKhenThuong_KyLuat kt = new tblKhenThuong_KyLuat();
                kt.SoQuyetDinh = so.ToString("00000") + @"/2022/QDKT";
                //hd.NgayBatDau = dtNgayBatDau.Value;
                //hd.NgayKetThuc = dtNgayKetThuc.Value;
                kt.Loai = 1;
                kt.LyDo = txtLyDo.Text;
                kt.Ngay = dtNgay.Value;
                kt.NoiDung = txtNoiDung.Text;
                kt.MaNV = int.Parse(slkNhanVien.EditValue.ToString());
                kt.Created_By = 1;
                kt.Created_Date = DateTime.Now;
                _ktkl.Add(kt);

            }
            else
            {
                var kt = _ktkl.getItem(_soQD);
                //hd.NgayBatDau = dtNgayBatDau.Value;
                //hd.NgayKetThuc = dtNgayKetThuc.Value;
                kt.Ngay = dtNgay.Value;
                kt.MaNV = int.Parse(slkNhanVien.EditValue.ToString());
                kt.NoiDung = txtNoiDung.Text;
                kt.LyDo = txtLyDo.Text;
                kt.Update_By = 1;
                kt.Update_Date = DateTime.Now;
                _ktkl.Edit(kt);
            }
        } 
        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        void LoadNV()
        {
            slkNhanVien.Properties.DataSource = _nhanvien.getList();
            slkNhanVien.Properties.ValueMember = "MaNV";
            slkNhanVien.Properties.DisplayMember = "HoTen";
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
                _ktkl.Delete(_soQD);
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
            //_lstHD = _hd.getItemFull(_sohd);
            //rpHopDongLaoDong rpt = new rpHopDongLaoDong(_lstHD);
            //rpt.ShowPreviewDialog();
        }

        private void btnDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void gvKhenThuong_Click(object sender, EventArgs e)
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
                
                //_lstHD = _hd.getItemFull(_soQD);

            }
        }
      
    }
}