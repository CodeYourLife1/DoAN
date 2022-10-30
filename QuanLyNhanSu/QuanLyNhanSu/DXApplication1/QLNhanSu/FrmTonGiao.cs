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
    public partial class FrmTonGiao : DevExpress.XtraEditors.XtraForm
    {
        public FrmTonGiao()
        {
            InitializeComponent();
        }
        TonGiao _tongiao;
        bool _them;
        int _id;
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
            gcTonGiao.DataSource = _tongiao.getList();
            gvTonGiao.OptionsBehavior.Editable = false;

        }
        void SaveData()
        {
            if (_them)
            {
                tblTonGiao tg = new tblTonGiao();
                tg.TenTonGiao = txtTen.Text;
                _tongiao.Add(tg);
            }
            else
            {
                var tg = _tongiao.getItem(_id);
                tg.TenTonGiao = txtTen.Text;
                _tongiao.Edit(tg);
            }
        }
        private void FrmTonGiao_Load(object sender, EventArgs e)
        {
            _them = false;
            _tongiao = new TonGiao();
            _ShowHide(true);
            LoadData();
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
                _tongiao.Delete(_id);
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

        private void gvTonGiao_Click(object sender, EventArgs e)
        {
            _id = int.Parse(gvTonGiao.GetFocusedRowCellValue("ID").ToString());
            txtTen.Text = gvTonGiao.GetFocusedRowCellValue("TenTonGiao").ToString();
        }
    }
}