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
using System.IO;
using QLNhanSu.Reports;
using DevExpress.XtraReports.UI;
using BusinessPlayer.DTO;

namespace QLNhanSu
{
    public partial class frmNhanVien : DevExpress.XtraEditors.XtraForm
    {
        public frmNhanVien()
        {
            InitializeComponent();
        }
        NhanVien _nhanvien;
        ClassDanToc _dantoc;
        TonGiao _tongiao;
        ChucVu _chucvu;
        TrinhDo _trinhdo;
        PhongBan _phongban;
        BoPhan _bophan;
        bool _them;
        int _id;
        List<NhanVienDTO> _lstNVDTO;

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

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
            txtTen.Enabled =!kt;
            txtCCCD.Enabled = !kt;
            txtDienThoai.Enabled =!kt;
            txtDiaChi.Enabled = !kt;
            chkGioiTinh.Enabled= !kt;
            btnHinhAnh.Enabled = !kt;
            dtNgaySinh.Enabled = !kt;
            //pictureBox1.Enabled = !kt;

        }
        void reset()
        {
            txtTen.Text = string.Empty;
            txtCCCD.Text = string.Empty;
            txtDienThoai.Text = string.Empty;
            txtDiaChi.Text = string.Empty;
            chkGioiTinh.Checked = false;

        }
        void LoadData()
        {
            gcDanhSanh.DataSource = _nhanvien.getListFull();
            gvDanhSach.OptionsBehavior.Editable = false;
            _lstNVDTO = _nhanvien.getListFull();

        }
        void SaveData()
        {
            if (_them)
            {
                tblNhanVien nv = new tblNhanVien();
                nv.HoTen = txtTen.Text;
                nv.GioiTinh = chkGioiTinh.Checked;
                nv.DienThoai = txtDienThoai.Text;
                nv.DiaChi = txtDiaChi.Text;
                nv.CCCD = txtCCCD.Text;
                nv.NgaySinh = dtNgaySinh.Value;
                nv.HinhAnh = ImageToBase64(pictureBox1.Image, pictureBox1.Image.RawFormat);
                nv.IDBoPhan = int.Parse( cbbBoPhan.SelectedValue.ToString());
                nv.IDChucVu = int.Parse(cbbChucVu.SelectedValue.ToString());
                nv.IDPhongBan = int.Parse(cbbPhongBan.SelectedValue.ToString());
                nv.IDTonGiao = int.Parse(cbbTonGiao.SelectedValue.ToString());
                nv.IDDanToc = int.Parse(cbbDanToc.SelectedValue.ToString());
                nv.IDTrinhDo = int.Parse(cbbTrinhDo.SelectedValue.ToString());
                nv.IDCongTy = 1;
                _nhanvien.Add(nv);
            }
            else
            {
                var nv = _nhanvien.getItem(_id);
                nv.HoTen = txtTen.Text;
                nv.GioiTinh = chkGioiTinh.Checked;
                nv.DienThoai = txtDienThoai.Text;
                nv.DiaChi = txtDiaChi.Text;
                nv.CCCD = txtCCCD.Text;
                nv.NgaySinh = dtNgaySinh.Value;
                nv.HinhAnh = ImageToBase64(pictureBox1.Image, pictureBox1.Image.RawFormat);
                nv.IDBoPhan = int.Parse(cbbBoPhan.SelectedValue.ToString());
                nv.IDChucVu = int.Parse(cbbChucVu.SelectedValue.ToString());
                nv.IDPhongBan = int.Parse(cbbPhongBan.SelectedValue.ToString());
                nv.IDTonGiao = int.Parse(cbbTonGiao.SelectedValue.ToString());
                nv.IDDanToc = int.Parse(cbbDanToc.SelectedValue.ToString());
                nv.IDTrinhDo = int.Parse(cbbTrinhDo.SelectedValue.ToString());
                nv.IDCongTy = 1;
                _nhanvien.Edit(nv);
            }
        }
        void LoadComBoBox()
        {
            cbbBoPhan.DataSource = _bophan.getList();
            cbbBoPhan.DisplayMember = "TenBoPhan";
            cbbBoPhan.ValueMember = "IDBoPhan";

            cbbChucVu.DataSource = _chucvu.getList();
            cbbChucVu.DisplayMember = "TenChucVu";
            cbbChucVu.ValueMember = "IDChucVu";

            cbbPhongBan.DataSource = _phongban.getList();
            cbbPhongBan.DisplayMember = "TenPhongBan";
            cbbPhongBan.ValueMember = "IDPhongBan";

            cbbTonGiao.DataSource = _tongiao.getList();
            cbbTonGiao.DisplayMember = "TenTonGiao";
            cbbTonGiao.ValueMember = "ID";

            cbbDanToc.DataSource = _dantoc.getList();
            cbbDanToc.DisplayMember = "TenDanToc";
            cbbDanToc.ValueMember = "ID";

            cbbTrinhDo.DataSource = _trinhdo.getList();
            cbbTrinhDo.DisplayMember = "TenTrinhDo";
            cbbTrinhDo.ValueMember = "IDTrinhDo";
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            _them = false;
            _nhanvien = new NhanVien();
            _dantoc = new ClassDanToc();
            _tongiao = new TonGiao();
            _chucvu = new ChucVu();
            _trinhdo = new TrinhDo();
            _phongban = new PhongBan();
            _bophan = new BoPhan();
            _ShowHide(true);
            LoadData();
            LoadComBoBox();
            splitContainer1.Panel1Collapsed = true;
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _ShowHide(false);
            _them = true;
            reset();
            splitContainer1.Panel1Collapsed = false;
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _them = false;
            _ShowHide(false);
            splitContainer1.Panel1Collapsed = false;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                _nhanvien.Delete(_id);
                LoadData();
            }
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveData();
            LoadData();
            _them = false;
            _ShowHide(true);
            splitContainer1.Panel1Collapsed = true;
        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _them = false;

            _ShowHide(true);
            splitContainer1.Panel1Collapsed = true;
        }

        private void btnPrint_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            RPDanhSachNhanVien rpt = new RPDanhSachNhanVien(_lstNVDTO);
            rpt.ShowPreview();


        }

        private void btnDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void gvDanhSach_Click(object sender, EventArgs e)
        {
            _id = int.Parse(gvDanhSach.GetFocusedRowCellValue("MaNV").ToString());
            var nv = _nhanvien.getItem(_id);
            txtTen.Text = nv.HoTen;
            chkGioiTinh.Checked = nv.GioiTinh.Value;
            txtDienThoai.Text = nv.DienThoai;
            txtDiaChi.Text = nv.DiaChi;
            txtCCCD.Text = nv.CCCD;
            dtNgaySinh.Value = nv.NgaySinh.Value;
            pictureBox1.Image = Base64ToImage(nv.HinhAnh);
            cbbBoPhan.SelectedValue = nv.IDBoPhan;
            cbbChucVu.SelectedValue = nv.IDChucVu;
            cbbPhongBan.SelectedValue = nv.IDPhongBan;
            cbbTonGiao.SelectedValue = nv.IDTonGiao;
            cbbDanToc.SelectedValue = nv.IDDanToc;
            cbbTrinhDo.SelectedValue = nv.IDTrinhDo;
            

        }
        public byte[] ImageToBase64(Image image,System.Drawing.Imaging.ImageFormat format)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, format);
                byte[] imageBytes = ms.ToArray();

                return imageBytes;
            }
        }
        public Image Base64ToImage(byte[] imageBytes)
        {
            MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length);
            ms.Write(imageBytes, 0, imageBytes.Length);
            Image image = Image.FromStream(ms, true);
            return image;

        }

        private void btnHinhAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog();
            openfile.Filter = "picture file(.png, .jpg)|*.png;*jpg";
            openfile.Title = "Chọn Hình Ảnh";
            if(openfile.ShowDialog()==DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openfile.FileName);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
    }
}