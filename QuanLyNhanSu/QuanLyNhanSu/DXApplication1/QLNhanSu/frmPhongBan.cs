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

namespace QLNhanSu
{
    public partial class frmPhongBan : DevExpress.XtraEditors.XtraForm
    {
        public frmPhongBan()
        {
            InitializeComponent();
        }
        PhongBan _phongban;
        bool _them;
        int _id;
        private void frmPhongBan_Load(object sender, EventArgs e)
        {
            _them = false;
            _phongban = new PhongBan();
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
            gcPhongBan.DataSource = _phongban.getList();
            gvPhongBan.OptionsBehavior.Editable = false;

        }
        void SaveData()
        {
            if (_them)
            {
                tblPhongBan pb = new tblPhongBan();
                pb.TenPhongBan = txtTen.Text;
                _phongban.Add(pb);
            }
            else
            {
                var pb = _phongban.getItem(_id);
                pb.TenPhongBan = txtTen.Text;
                _phongban.Edit(pb);
            }
        }
        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

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
                _phongban.Delete(_id);
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

        private void gvPhongBan_Click(object sender, EventArgs e)
        {
            _id = int.Parse(gvPhongBan.GetFocusedRowCellValue("IDPhongBan").ToString());
            txtTen.Text = gvPhongBan.GetFocusedRowCellValue("TenPhongBan").ToString();
        }
    }
}