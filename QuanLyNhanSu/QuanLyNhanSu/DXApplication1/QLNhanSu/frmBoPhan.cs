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
    public partial class frmBoPhan : DevExpress.XtraEditors.XtraForm
    {
        public frmBoPhan()
        {
            InitializeComponent();
        }
        BoPhan _bophan;
        bool _them;
        int _id;
        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmBoPhan_Load(object sender, EventArgs e)
        {
            _them = false;
            _bophan = new BoPhan();
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
            gcBoPhan.DataSource = _bophan.getList();
            gvBoPhan.OptionsBehavior.Editable = false;

        }
        void SaveData()
        {
            if (_them)
            {
                tblBoPhan pb = new tblBoPhan();
                pb.TenBoPhan = txtTen.Text;
                _bophan.Add(pb);
            }
            else
            {
                var pb = _bophan.getItem(_id);
                pb.TenBoPhan = txtTen.Text;
                _bophan.Edit(pb);
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
                _bophan.Delete(_id);
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

        private void gvBoPhan_Click(object sender, EventArgs e)
        {
            _id = int.Parse(gvBoPhan.GetFocusedRowCellValue("IDBoPhan").ToString());
            txtTen.Text = gvBoPhan.GetFocusedRowCellValue("TenBoPhan").ToString();
        }
    }
}