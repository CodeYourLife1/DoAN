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
using QLNhanSu.Reports;
using BusinessPlayer.DTO;
using DevExpress.XtraReports.UI;
using DataPlayer;
using BusinessPlayer;
using System.IO;

namespace QLNhanSu
{
    public partial class FRmNhanVIennn : DevExpress.XtraEditors.XtraForm
    {
        public FRmNhanVIennn()
        {
            InitializeComponent();
        }
        private NhanVien _nhanvien;
        private ClassDanToc _dantoc;
        private TonGiao _tongiao;
        private ChucVu _chucvu;
        private TrinhDo _trinhdo;
        private PhongBan _phongban;
        private BoPhan _bophan;
        private bool _them;
        private int _id;
        List<NhanVienDTO> _lstNVDTO;
        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        void LoadCombo()
        {
            cbbBoPhan.DataSource = _bophan.getList();
            cbbBoPhan.DisplayMember = "TenBoPhan";
            cbbBoPhan.ValueMember = "IDBoPhan";
            cbbChucVu.DataSource = _chucvu.getList();
            cbbChucVu.DisplayMember = "TenChucVu";
            cbbChucVu.ValueMember = "IDChucVu";



            cbbDanToc.DataSource = _dantoc.getList();
            cbbDanToc.DisplayMember = "TenDanToc";
            cbbDanToc.ValueMember = "ID";


            cbbTonGiao.DataSource = _tongiao.getList();
            cbbTonGiao.DisplayMember = "TenTonGiao";
            cbbTonGiao.ValueMember = "ID";

            cbbPhongBan.DataSource = _phongban.getList();
            cbbPhongBan.DisplayMember = "TenPhongBan";
            cbbPhongBan.ValueMember = "IDPhongBan";

            cbbTrinhDo.DataSource = _trinhdo.getList();
            cbbTrinhDo.DisplayMember = "TenTrinhDo";
            cbbTrinhDo.ValueMember = "IDTrinhDo";
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
            txtHoTen.Enabled = !kt;
            txtDienThoai.Enabled = !kt;
            txtCCCD.Enabled = !kt;
            txtDiaChi.Enabled = !kt;
            chkGioiTinh.Enabled = !kt;
            cbbBoPhan.Enabled = !kt;
            cbbChucVu.Enabled = !kt;
            cbbDanToc.Enabled = !kt;
            cbbTonGiao.Enabled = !kt;
            cbbPhongBan.Enabled = !kt;
            cbbTrinhDo.Enabled = !kt;
            btnHinhAnh.Enabled = !kt;
            dtNgaySinh.Enabled = !kt;
        }
        void LoadData()
        {
            gcNhanVien.DataSource = _nhanvien.getListFull();
            gvNhanVien.OptionsBehavior.Editable = false;
            _lstNVDTO = _nhanvien.getListFull();
        }
        void ReSet()
        {
            txtHoTen.Text = string.Empty;
            txtDienThoai.Text = string.Empty;
            txtCCCD.Text = string.Empty;
            txtDiaChi.Text = string.Empty;
            chkGioiTinh.Checked = false;

        }
        void SaveData()
        {
            if (_them)
            {
                tblNhanVien nv = new tblNhanVien();
                nv.HoTen = txtHoTen.Text;
                nv.GioiTinh = chkGioiTinh.Checked;
                nv.NgaySinh = dtNgaySinh.Value;
                nv.DienThoai = txtDienThoai.Text;
                nv.CCCD = txtCCCD.Text;
                nv.DiaChi = txtDiaChi.Text;
                nv.HinhAnh = ImageToBase64(pictureBox1.Image, pictureBox1.Image.RawFormat);
                nv.IDBoPhan = int.Parse(cbbBoPhan.SelectedValue.ToString());
                nv.IDChucVu = int.Parse(cbbChucVu.SelectedValue.ToString());
                nv.IDDanToc = int.Parse(cbbDanToc.SelectedValue.ToString());
                nv.IDTonGiao = int.Parse(cbbTonGiao.SelectedValue.ToString());
                nv.IDPhongBan = int.Parse(cbbPhongBan.SelectedValue.ToString());
                nv.IDTrinhDo = int.Parse(cbbTrinhDo.SelectedValue.ToString());
                nv.IDCongTy = 1;
                _nhanvien.Add(nv);
            }
            else
            {
                var nv = _nhanvien.getItem(_id);
                nv.HoTen = txtHoTen.Text;
                nv.GioiTinh = chkGioiTinh.Checked;
                nv.NgaySinh = dtNgaySinh.Value;
                nv.DienThoai = txtDienThoai.Text;
                nv.CCCD = txtCCCD.Text;
                nv.DiaChi = txtDiaChi.Text;
                nv.HinhAnh = ImageToBase64(pictureBox1.Image, pictureBox1.Image.RawFormat);
                nv.IDBoPhan = int.Parse(cbbBoPhan.SelectedValue.ToString());
                nv.IDChucVu = int.Parse(cbbChucVu.SelectedValue.ToString());
                nv.IDDanToc = int.Parse(cbbDanToc.SelectedValue.ToString());
                nv.IDTonGiao = int.Parse(cbbTonGiao.SelectedValue.ToString());
                nv.IDPhongBan = int.Parse(cbbPhongBan.SelectedValue.ToString());
                nv.IDTrinhDo = int.Parse(cbbTrinhDo.SelectedValue.ToString());
                nv.IDCongTy = 1;
                _nhanvien.Edit(nv);
            }
        }
        //Hàm chuyển đổi hình ảnh
        public byte[] ImageToBase64(Image image, System.Drawing.Imaging.ImageFormat format)
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
        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _ShowHide(false);
            _them = true;
            ReSet();
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
            RPDanhSachNhanVien rp = new RPDanhSachNhanVien(_lstNVDTO);
            rp.ShowRibbonPreview();
        }

        private void btnDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void gvNhanVien_Click(object sender, EventArgs e)
        {

            if (gvNhanVien.RowCount > 0)
            {
                
                _id = int.Parse(gvNhanVien.GetFocusedRowCellValue("MaNV").ToString());
                var nv = _nhanvien.getItem(_id);
                txtHoTen.Text = nv.HoTen;
                chkGioiTinh.Checked = nv.GioiTinh.Value;
                dtNgaySinh.Value = nv.NgaySinh.Value;
                txtDienThoai.Text = nv.DienThoai;
                txtCCCD.Text = nv.CCCD;
                txtDiaChi.Text = nv.DiaChi;
                pictureBox1.Image = Base64ToImage(nv.HinhAnh);
                cbbBoPhan.SelectedValue = nv.IDBoPhan;
                cbbChucVu.SelectedValue = nv.IDChucVu;
                cbbDanToc.SelectedValue = nv.IDDanToc;
                cbbTonGiao.SelectedValue = nv.IDTonGiao;
                cbbPhongBan.SelectedValue = nv.IDPhongBan;
                cbbTrinhDo.SelectedValue = nv.IDTrinhDo;
                //nv.IDCongTy = 1;
            }
        }

        private void FRmNhanVIennn_Load(object sender, EventArgs e)
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
            LoadCombo();
            splitContainer1.Panel1Collapsed = true;
        }

        private void btnHinhAnh_Click(object sender, EventArgs e)
        {

            OpenFileDialog openfile = new OpenFileDialog();
            openfile.Filter = "Picture file (.png, .jpg)|*.png; *.jpg";
            openfile.Title = "Chọn hình ảnh";
            if (openfile.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openfile.FileName);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
    }
}