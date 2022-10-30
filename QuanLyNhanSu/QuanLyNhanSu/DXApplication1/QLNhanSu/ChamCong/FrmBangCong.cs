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

namespace QLNhanSu.ChamCong
{
    public partial class FrmBangCong : DevExpress.XtraEditors.XtraForm
    {
        public FrmBangCong()
        {
            InitializeComponent();
        }
        KyCong _kycong;
        bool _them;
        int _id;
        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmBangCong_Load(object sender, EventArgs e)
        {
            _them = false;
            _kycong = new KyCong();
            _ShowHide(true);
            LoadData();
            cbbNam.Text = DateTime.Now.Year.ToString();
            cbbThang.Text = DateTime.Now.Month.ToString();

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
           
        }
        void LoadData()
        {
            gcBangCong.DataSource = _kycong.getList();
            gvBangCong.OptionsBehavior.Editable = false;

        }
        void SaveData()
        {
            if (_them)
            {
                tblKYCONG kc = new tblKYCONG();
                kc.MAKYCONG = int.Parse(cbbNam.Text)*100+int.Parse(cbbThang.Text);//Mã kỳ công == 202201
                kc.NAM = int.Parse(cbbNam.Text);
                kc.THANG = int.Parse(cbbThang.Text);
                kc.KHOA = ckKhoa.Checked;
                kc.TRANGTHAI = ckTranThai.Checked;
                kc.NGAYCONGTRONGTHANG = Funstions.demSoNgayLamViecTrongThang(int.Parse(cbbThang.Text), int.Parse(cbbNam.Text));
                kc.NGAYTINHCONG = DateTime.Now;
                kc.Created_By = 1;
                kc.Created_Date = DateTime.Now;
                _kycong.Add(kc);
            }
            else
            {
                var kc = _kycong.getItem(_id);
                kc.MAKYCONG = int.Parse(cbbNam.Text) * 100 + int.Parse(cbbThang.Text);//Mã kỳ công == 202201
                kc.NAM = int.Parse(cbbNam.Text);
                kc.THANG = int.Parse(cbbThang.Text);
                kc.KHOA = ckKhoa.Checked;
                kc.TRANGTHAI = ckTranThai.Checked;
                kc.NGAYCONGTRONGTHANG = Funstions.demSoNgayLamViecTrongThang(int.Parse(cbbThang.Text), int.Parse(cbbNam.Text));
                kc.NGAYTINHCONG = DateTime.Now;
                kc.Created_By = 1;
                kc.Created_Date = DateTime.Now;
                _kycong.Edit(kc);
            }
        }
        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _ShowHide(false);
            _them = true;
            cbbNam.Text = DateTime.Now.Year.ToString();
            cbbThang.Text = DateTime.Now.Month.ToString();
            ckKhoa.Checked = false;
            ckTranThai.Checked = false;
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            _them = false;
            _ShowHide(false);
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                _kycong.Delete(_id, 1);
                LoadData();
            }
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveData();
            LoadData();
            _them = false;
            _ShowHide(true);
        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _them = false;

            _ShowHide(true);
        }

        private void btnPrint_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void gvBangCong_Click(object sender, EventArgs e)
        {
            _id = int.Parse(gvBangCong.GetFocusedRowCellValue("ID").ToString());
            cbbNam.Text = gvBangCong.GetFocusedRowCellValue("NAM").ToString();
            cbbThang.Text = gvBangCong.GetFocusedRowCellValue("THANG").ToString();
            ckKhoa.Checked = bool.Parse(gvBangCong.GetFocusedRowCellValue("KHOA").ToString());
            ckTranThai.Checked = bool.Parse(gvBangCong.GetFocusedRowCellValue("TRANGTHAI").ToString());
        }
    }
}