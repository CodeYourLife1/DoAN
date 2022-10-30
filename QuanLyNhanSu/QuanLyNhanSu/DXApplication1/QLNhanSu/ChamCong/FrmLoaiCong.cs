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

namespace QLNhanSu.ChamCong
{
    public partial class FrmLoaiCong : DevExpress.XtraEditors.XtraForm
    {
        public FrmLoaiCong()
        {
            InitializeComponent();
        }
        LoaiCong _loaicong;
        bool _them;
        int _id;
        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmLoaiCong_Load(object sender, EventArgs e)
        {
            _them = false;
            _loaicong = new LoaiCong();
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
            spHeSo.EditValue = !kt;
        }
        void LoadData()
        {
            gcLoaiCong.DataSource = _loaicong.getList();
            gvLoaiCong.OptionsBehavior.Editable = false;

        }
        void SaveData()
        {
            if (_them)
            {
                tblLoaiCong cv = new tblLoaiCong();
                cv.TenLoaiCong = txtTen.Text;
                cv.HeSo = double.Parse(spHeSo.EditValue.ToString());
                cv.Created_By = 1;
                cv.Created_Date = DateTime.Now;
                _loaicong.Add(cv);
            }
            else
            {
                var cv = _loaicong.getItem(_id);
                cv.TenLoaiCong = txtTen.Text;
                cv.HeSo = double.Parse(spHeSo.EditValue.ToString());
                cv.Update_By = 1;
                cv.Update_Date = DateTime.Now;
                _loaicong.Edit(cv);
            }
        }
        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _ShowHide(false);
            _them = true;
            txtTen.Text = string.Empty;
            spHeSo.EditValue = 1;
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
                _loaicong.Delete(_id, 1);
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

        private void gvLoaiCong_Click(object sender, EventArgs e)
        {
            _id = int.Parse(gvLoaiCong.GetFocusedRowCellValue("IDLoaiCong").ToString());
            txtTen.Text = gvLoaiCong.GetFocusedRowCellValue("TenLoaiCong").ToString();
            spHeSo.Text = gvLoaiCong.GetFocusedRowCellValue("HeSo").ToString();
        }
    }
}