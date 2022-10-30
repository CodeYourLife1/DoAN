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
    public partial class frmDanToc : DevExpress.XtraEditors.XtraForm
    {
        public frmDanToc()
        {
            InitializeComponent();
        }
        ClassDanToc _dantoc;
        bool _them;
        int _id;
        private void frmDanToc_Load(object sender, EventArgs e)
        {
            _them = false;
            _dantoc = new ClassDanToc();
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
            gcDanToc.DataSource = _dantoc.getList();
            gvDanToc.OptionsBehavior.Editable = false;
            
        }
        void SaveData()
        {
            if (_them)
            {
                tblDanToc dt = new tblDanToc();
                dt.TenDanToc = txtTen.Text;
                _dantoc.Add(dt);
            }
            else
            {
                var dt = _dantoc.getItem(_id);
                dt.TenDanToc = txtTen.Text;
                _dantoc.Edit(dt);
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
            if(MessageBox.Show("Bạn có chắc chắn xóa không", "Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)==DialogResult.Yes)
            {
                _dantoc.Delete(_id);
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

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
       

        private void gvDanToc_Click(object sender, EventArgs e)
        {
           
            _id = int.Parse(gvDanToc.GetFocusedRowCellValue("ID").ToString());
            txtTen.Text = gvDanToc.GetFocusedRowCellValue("TenDanToc").ToString();
        }
    }
}