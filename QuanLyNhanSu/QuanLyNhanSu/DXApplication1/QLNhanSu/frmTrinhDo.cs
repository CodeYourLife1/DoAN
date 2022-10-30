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
    public partial class frmTrinhDo : DevExpress.XtraEditors.XtraForm
    {
        public frmTrinhDo()
        {
            InitializeComponent();
        }
        TrinhDo _trinhdo;
        bool _them;
        int _id;
        private void frmTrinhDo_Load(object sender, EventArgs e)
        {
            _them = false;
            _trinhdo = new TrinhDo();
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
            gcTrinhDo.DataSource = _trinhdo.getList();
            gvTrinhDo.OptionsBehavior.Editable = false;

        }
        void SaveData()
        {
            if (_them)
            {
                tblTrinhDo td = new tblTrinhDo();
                td.TenTrinhDo = txtTen.Text;
                _trinhdo.Add(td);
            }
            else
            {
                var td = _trinhdo.getItem(_id);
                td.TenTrinhDo = txtTen.Text;
                _trinhdo.Edit(td);
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
                _trinhdo.Delete(_id);
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

        private void gvTrinhDo_Click(object sender, EventArgs e)
        {
            _id = int.Parse(gvTrinhDo.GetFocusedRowCellValue("IDTrinhDo").ToString());
            txtTen.Text = gvTrinhDo.GetFocusedRowCellValue("TenTrinhDo").ToString();
        }
    }
}