using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BusinessPlayer;
using QLNhanSu.ChamCong;

namespace QLNhanSu
{
    public partial class MainFrom : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public MainFrom()
        {
            InitializeComponent();
        }

        void openFrom(Type typeFrom)
        {
            foreach(var frm in MdiChildren)
            {
                if(frm.GetType()==typeFrom)
                {
                    frm.Activate();
                    return;
                }
            }
            Form f = (Form)Activator.CreateInstance(typeFrom);
            f.MdiParent = this;
            f.Show();
        }
        NhanVien _nhanvien;
        HopDong _hopdong;
        private void MainFrom_Load(object sender, EventArgs e)
        {
            _nhanvien = new NhanVien();
            _hopdong = new HopDong();
            ribbonControl1.SelectedPage = ribbonPage2;
            LoadSinhNhat();
            LoadLenLuong();
        }
        void LoadSinhNhat()
        {
            lstSinhNhat.DataSource = _nhanvien.GetSinhNhat();
            lstSinhNhat.DisplayMember = "HoTen";
            lstSinhNhat.ValueMember = "MaNV";

        }
        void LoadLenLuong()
        {
            lstLenLuong.DataSource = _hopdong.getLenLuong();
            lstLenLuong.DisplayMember = "HoTen";
            lstLenLuong.ValueMember = "MaNV";
        }
        private void btnDanToc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openFrom(typeof(frmDanToc));
        }

        private void btnTonGiao_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openFrom(typeof(FrmTonGiao));
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnTrinhDo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openFrom(typeof(frmTrinhDo));
        }

        private void btnPhongBan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openFrom(typeof(frmPhongBan));
        }

        private void btnCongTy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openFrom(typeof(frmCongTy));
        }

        private void btnBoPhan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openFrom(typeof(frmBoPhan));
        }

        private void btnChuVu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openFrom(typeof(frmChucVu));
        }

        private void btnNhanVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openFrom(typeof(frmNhanVien));
        }

        private void btnHopDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openFrom(typeof(frmHopDong));
        }

        private void btnKhenKL_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openFrom(typeof(KhenThuongFrm));
        }
        private void btnKyLuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openFrom(typeof(frmKyLuat));
        }

        private void btnDieuChuyen_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openFrom(typeof(frmNhanVien_DieuChuyen));
        }

        private void btnThoiViec_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openFrom(typeof(frmThoiViec));
        }

        private void tbnQuanLyLuong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openFrom(typeof(frmQuanLyLuong));
        }

        private void lstSinhNhat_CustomizeItem(object sender, DevExpress.XtraEditors.CustomizeTemplatedItemEventArgs e)
        {
            if(e.TemplatedItem.Elements[1].Text.Substring(0,2)==DateTime.Now.Day.ToString())
            {
                e.TemplatedItem.AppearanceItem.Normal.ForeColor = Color.Black;
            }
        }

        private void lstLenLuong_CustomizeItem(object sender, DevExpress.XtraEditors.CustomizeTemplatedItemEventArgs e)
        {
            if (e.TemplatedItem.Elements[1].Text.Substring(0, 2) == DateTime.Now.Day.ToString())
            {
                e.TemplatedItem.AppearanceItem.Normal.ForeColor = Color.Black;
            }
        }

        private void btnLoaiCa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openFrom(typeof(FrmLoaiCa));
        }

        private void btnLoaiCong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openFrom(typeof(FrmLoaiCong));
        }

        private void btnBangCong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openFrom(typeof(FrmBangCong));
        }
    }
} 
