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
    public partial class frmChucVu : DevExpress.XtraEditors.XtraForm
    {
        public frmChucVu()
        {
            InitializeComponent();
        }
        ChucVu _chucvu;
        bool _them;
        int _id;
        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmChucVu_Load(object sender, EventArgs e)
        {
            _them = false;
            _chucvu = new ChucVu();
            _ShowHide(true);
            LoadData();
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
            txtTen.Enabled = !kt;

        }
        void LoadData()
        {
            gcChucVu.DataSource = _chucvu.getList();
            gvChucVu.OptionsBehavior.Editable = false;

        }
        void SaveData()
        {
            if (_them)
            {
                tblChucVu cv = new tblChucVu();
                cv.TenChucVu = txtTen.Text;
                _chucvu.Add(cv);
            }
            else
            {
                var cv = _chucvu.getItem(_id);
                cv.TenChucVu = txtTen.Text;
                _chucvu.Edit(cv);
            }
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _ShowHide(false);
            _them = true;
            txtTen.Text = string.Empty;
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
                _chucvu.Delete(_id);
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

        private void gvChucVu_Click(object sender, EventArgs e)
        {
            _id = int.Parse(gvChucVu.GetFocusedRowCellValue("IDChucVu").ToString());
            txtTen.Text = gvChucVu.GetFocusedRowCellValue("TenChucVu").ToString();
        }
    }
}