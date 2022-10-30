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
    public partial class FrmLoaiCa : DevExpress.XtraEditors.XtraForm
    {
        public FrmLoaiCa()
        {
            InitializeComponent();
        }
        LoaiCaLam _loaica;
        bool _them;
        int _id;
        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void LoaiCa_Load(object sender, EventArgs e)
        {
            _them = false;
            _loaica = new LoaiCaLam();
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
            gcLoaiCa.DataSource = _loaica.getList();
            gvLoaiCa.OptionsBehavior.Editable = false;

        }
        void SaveData()
        {
            if (_them)
            {
                tblLoaiCa cv = new tblLoaiCa();
                cv.TenLoaiCa = txtTen.Text;
                cv.HeSo = double.Parse(spHeSo.EditValue.ToString());
                cv.Created_By = 1;
                cv.Created_Date = DateTime.Now;
                _loaica.Add(cv);
            }
            else
            {
                var cv = _loaica.getItem(_id);
                cv.TenLoaiCa = txtTen.Text;
                cv.HeSo = double.Parse(spHeSo.EditValue.ToString());
                cv.Update_By = 1;
                cv.Update_Date = DateTime.Now;
                _loaica.Edit(cv);
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
                _loaica.Delete(_id, 1);
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

        private void gvLoaiCa_Click(object sender, EventArgs e)
        {
            _id = int.Parse(gvLoaiCa.GetFocusedRowCellValue("IDLoaiCa").ToString());
            txtTen.Text = gvLoaiCa.GetFocusedRowCellValue("TenLoaiCa").ToString();
            spHeSo.Text = gvLoaiCa.GetFocusedRowCellValue("HeSo").ToString();
        }

        private void gvLoaiCa_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            
        }
    }
}