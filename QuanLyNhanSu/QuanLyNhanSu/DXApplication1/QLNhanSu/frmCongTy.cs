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
    public partial class frmCongTy : DevExpress.XtraEditors.XtraForm
    {
        public frmCongTy()
        {
            InitializeComponent();
        }
        CongTy _congty;
        bool _them;
        int _id;
        private void frmCongTy_Load(object sender, EventArgs e)
        {
            _them = false;
            _congty = new CongTy();
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
            txtDiaChi.Enabled = !kt;
            txtDienThoai.Enabled = !kt;
            txtEmail.Enabled = !kt;

        }
        void LoadData()
        {
            gcCongTy.DataSource = _congty.getList();
            gvCongTy.OptionsBehavior.Editable = false;

        }
        void SaveData()
        {
            if (_them)
            {
                tblCongTy ct = new tblCongTy();
                ct.TenCongTy = txtTen.Text;
                ct.Email = txtEmail.Text;
                ct.DienThoai = txtDienThoai.Text;
                ct.DiaChi = txtDiaChi.Text;
                _congty.Add(ct);
            }
            else
            {
                var ct = _congty.getItem(_id);
                ct.TenCongTy = txtTen.Text;
                ct.Email = txtEmail.Text;
                ct.DienThoai = txtDienThoai.Text;
                ct.DiaChi = txtDiaChi.Text;
                _congty.Edit(ct);
            }
        }
        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _ShowHide(false);
            _them = true;
            txtTen.Text = string.Empty;
            txtDiaChi.Text = string.Empty;
            txtDienThoai.Text = string.Empty;
            txtEmail.Text = string.Empty;
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
                _congty.Delete(_id);
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

        private void gvCongTy_Click(object sender, EventArgs e)
        {
            if (gvCongTy.RowCount > 0)
            {
                _id = int.Parse(gvCongTy.GetFocusedRowCellValue("IDCongTy").ToString());
                txtTen.Text = gvCongTy.GetFocusedRowCellValue("TenCongTy").ToString();
                txtEmail.Text = gvCongTy.GetFocusedRowCellValue("Email").ToString();
                txtDienThoai.Text = gvCongTy.GetFocusedRowCellValue("DienThoai").ToString();
                txtDiaChi.Text = gvCongTy.GetFocusedRowCellValue("DiaChi").ToString();

            }
        }
    }
}