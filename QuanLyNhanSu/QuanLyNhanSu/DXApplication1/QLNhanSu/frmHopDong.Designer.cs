namespace QLNhanSu
{
    partial class frmHopDong
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHopDong));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnSua = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnLuu = new DevExpress.XtraBars.BarButtonItem();
            this.btnHuy = new DevExpress.XtraBars.BarButtonItem();
            this.btnPrint = new DevExpress.XtraBars.BarButtonItem();
            this.btnDong = new DevExpress.XtraBars.BarButtonItem();
            this.bar4 = new DevExpress.XtraBars.Bar();
            this.bar5 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.cbbThoiHan = new System.Windows.Forms.ComboBox();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.txtNoiDung = new DevExpress.XtraRichEdit.RichEditControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.seNhanVien = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.NhanVien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Ten = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.spHeSoLuong = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.spLanKi = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.dtNgayKi = new System.Windows.Forms.DateTimePicker();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.dtNgayKetThuc = new System.Windows.Forms.DateTimePicker();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.dtNgayBatDau = new System.Windows.Forms.DateTimePicker();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtSoHopDong = new DevExpress.XtraEditors.TextEdit();
            this.gcHopDong = new DevExpress.XtraGrid.GridControl();
            this.gvHopDong = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.SoHopDong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NgayBatDau = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NgayKetThuc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ThoiHan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HeSoLuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LanKy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaNV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HoTen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NgayKi = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.seNhanVien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spHeSoLuong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spLanKi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoHopDong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcHopDong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvHopDong)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar3,
            this.bar4,
            this.bar5});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnThem,
            this.btnSua,
            this.btnXoa,
            this.btnLuu,
            this.btnHuy,
            this.btnPrint,
            this.btnDong});
            this.barManager1.MainMenu = this.bar4;
            this.barManager1.MaxItemId = 7;
            this.barManager1.StatusBar = this.bar5;
            // 
            // bar3
            // 
            this.bar3.BarName = "Tools";
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 1;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSua, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnLuu, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnHuy, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnPrint, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnDong, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar3.Text = "Tools";
            // 
            // btnThem
            // 
            this.btnThem.Caption = "Thêm";
            this.btnThem.Id = 0;
            this.btnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.Image")));
            this.btnThem.Name = "btnThem";
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick);
            // 
            // btnSua
            // 
            this.btnSua.Caption = "Sửa";
            this.btnSua.Id = 1;
            this.btnSua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.Image")));
            this.btnSua.Name = "btnSua";
            this.btnSua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSua_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.Id = 2;
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
            // 
            // btnLuu
            // 
            this.btnLuu.Caption = "Lưu";
            this.btnLuu.Id = 3;
            this.btnLuu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.ImageOptions.Image")));
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLuu_ItemClick);
            // 
            // btnHuy
            // 
            this.btnHuy.Caption = "Hủy";
            this.btnHuy.Id = 4;
            this.btnHuy.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.ImageOptions.Image")));
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHuy_ItemClick);
            // 
            // btnPrint
            // 
            this.btnPrint.Caption = "In";
            this.btnPrint.Id = 5;
            this.btnPrint.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.ImageOptions.Image")));
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPrint_ItemClick);
            // 
            // btnDong
            // 
            this.btnDong.Caption = "Đóng";
            this.btnDong.Id = 6;
            this.btnDong.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDong.ImageOptions.Image")));
            this.btnDong.Name = "btnDong";
            this.btnDong.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDong_ItemClick);
            // 
            // bar4
            // 
            this.bar4.BarName = "Main menu";
            this.bar4.DockCol = 0;
            this.bar4.DockRow = 0;
            this.bar4.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar4.OptionsBar.MultiLine = true;
            this.bar4.OptionsBar.UseWholeRow = true;
            this.bar4.Text = "Main menu";
            // 
            // bar5
            // 
            this.bar5.BarName = "Status bar";
            this.bar5.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar5.DockCol = 0;
            this.bar5.DockRow = 0;
            this.bar5.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar5.OptionsBar.AllowQuickCustomization = false;
            this.bar5.OptionsBar.DrawDragBorder = false;
            this.bar5.OptionsBar.UseWholeRow = true;
            this.bar5.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barDockControlTop.Appearance.Options.UseFont = true;
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlTop.Size = new System.Drawing.Size(1549, 71);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 786);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlBottom.Size = new System.Drawing.Size(1549, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 71);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 715);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1549, 71);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 715);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 71);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.cbbThoiHan);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl9);
            this.splitContainer1.Panel1.Controls.Add(this.txtNoiDung);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl8);
            this.splitContainer1.Panel1.Controls.Add(this.seNhanVien);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl7);
            this.splitContainer1.Panel1.Controls.Add(this.spHeSoLuong);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl4);
            this.splitContainer1.Panel1.Controls.Add(this.spLanKi);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl3);
            this.splitContainer1.Panel1.Controls.Add(this.dtNgayKi);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl2);
            this.splitContainer1.Panel1.Controls.Add(this.dtNgayKetThuc);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl6);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl5);
            this.splitContainer1.Panel1.Controls.Add(this.dtNgayBatDau);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl1);
            this.splitContainer1.Panel1.Controls.Add(this.txtSoHopDong);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gcHopDong);
            this.splitContainer1.Size = new System.Drawing.Size(1549, 715);
            this.splitContainer1.SplitterDistance = 416;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 8;
            // 
            // cbbThoiHan
            // 
            this.cbbThoiHan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbThoiHan.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbThoiHan.FormattingEnabled = true;
            this.cbbThoiHan.Items.AddRange(new object[] {
            "3 tháng ",
            "6 tháng ",
            "1 năm",
            "2 năm",
            "3 năm",
            "5 năm"});
            this.cbbThoiHan.Location = new System.Drawing.Point(692, 100);
            this.cbbThoiHan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbbThoiHan.Name = "cbbThoiHan";
            this.cbbThoiHan.Size = new System.Drawing.Size(129, 25);
            this.cbbThoiHan.TabIndex = 37;
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(602, 100);
            this.labelControl9.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(68, 19);
            this.labelControl9.TabIndex = 36;
            this.labelControl9.Text = "Thời Hạn";
            // 
            // txtNoiDung
            // 
            this.txtNoiDung.Location = new System.Drawing.Point(3, 137);
            this.txtNoiDung.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNoiDung.MenuManager = this.barManager1;
            this.txtNoiDung.Name = "txtNoiDung";
            this.txtNoiDung.Size = new System.Drawing.Size(1546, 372);
            this.txtNoiDung.TabIndex = 35;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(3, 100);
            this.labelControl8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(70, 19);
            this.labelControl8.TabIndex = 34;
            this.labelControl8.Text = "Nội Dung";
            // 
            // seNhanVien
            // 
            this.seNhanVien.Location = new System.Drawing.Point(983, 18);
            this.seNhanVien.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.seNhanVien.MenuManager = this.barManager1;
            this.seNhanVien.Name = "seNhanVien";
            this.seNhanVien.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seNhanVien.Properties.Appearance.Options.UseFont = true;
            this.seNhanVien.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.seNhanVien.Properties.PopupView = this.searchLookUpEdit1View;
            this.seNhanVien.Size = new System.Drawing.Size(216, 26);
            this.seNhanVien.TabIndex = 33;
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.NhanVien,
            this.Ten});
            this.searchLookUpEdit1View.DetailHeight = 431;
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // NhanVien
            // 
            this.NhanVien.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.NhanVien.AppearanceHeader.Options.UseFont = true;
            this.NhanVien.Caption = "ID";
            this.NhanVien.FieldName = "MaNV";
            this.NhanVien.MaxWidth = 93;
            this.NhanVien.MinWidth = 23;
            this.NhanVien.Name = "NhanVien";
            this.NhanVien.Visible = true;
            this.NhanVien.VisibleIndex = 0;
            this.NhanVien.Width = 87;
            // 
            // Ten
            // 
            this.Ten.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.Ten.AppearanceHeader.Options.UseFont = true;
            this.Ten.Caption = "Họ Tên";
            this.Ten.FieldName = "HoTen";
            this.Ten.MaxWidth = 175;
            this.Ten.MinWidth = 23;
            this.Ten.Name = "Ten";
            this.Ten.Visible = true;
            this.Ten.VisibleIndex = 1;
            this.Ten.Width = 87;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(881, 25);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(76, 19);
            this.labelControl7.TabIndex = 32;
            this.labelControl7.Text = "Nhân Viên";
            // 
            // spHeSoLuong
            // 
            this.spHeSoLuong.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spHeSoLuong.Location = new System.Drawing.Point(983, 50);
            this.spHeSoLuong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.spHeSoLuong.MenuManager = this.barManager1;
            this.spHeSoLuong.Name = "spHeSoLuong";
            this.spHeSoLuong.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spHeSoLuong.Properties.Appearance.Options.UseFont = true;
            this.spHeSoLuong.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spHeSoLuong.Size = new System.Drawing.Size(129, 24);
            this.spHeSoLuong.TabIndex = 31;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(866, 54);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(95, 19);
            this.labelControl4.TabIndex = 30;
            this.labelControl4.Text = "Hệ Số Lương";
            // 
            // spLanKi
            // 
            this.spLanKi.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spLanKi.Location = new System.Drawing.Point(692, 14);
            this.spLanKi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.spLanKi.MenuManager = this.barManager1;
            this.spLanKi.Name = "spLanKi";
            this.spLanKi.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spLanKi.Properties.Appearance.Options.UseFont = true;
            this.spLanKi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spLanKi.Properties.IsFloatValue = false;
            this.spLanKi.Properties.Mask.EditMask = "N00";
            this.spLanKi.Size = new System.Drawing.Size(129, 26);
            this.spLanKi.TabIndex = 29;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(602, 57);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(59, 19);
            this.labelControl3.TabIndex = 28;
            this.labelControl3.Text = "Ngày Kí";
            // 
            // dtNgayKi
            // 
            this.dtNgayKi.CalendarFont = new System.Drawing.Font("Tahoma", 10F);
            this.dtNgayKi.CustomFormat = "dd/MM/yyyy";
            this.dtNgayKi.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNgayKi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgayKi.Location = new System.Drawing.Point(692, 53);
            this.dtNgayKi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtNgayKi.Name = "dtNgayKi";
            this.dtNgayKi.Size = new System.Drawing.Size(130, 27);
            this.dtNgayKi.TabIndex = 27;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(205, 100);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(107, 19);
            this.labelControl2.TabIndex = 26;
            this.labelControl2.Text = "Ngày Kết Thúc";
            // 
            // dtNgayKetThuc
            // 
            this.dtNgayKetThuc.CalendarFont = new System.Drawing.Font("Tahoma", 10F);
            this.dtNgayKetThuc.CustomFormat = "dd/MM/yyyy";
            this.dtNgayKetThuc.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNgayKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgayKetThuc.Location = new System.Drawing.Point(332, 91);
            this.dtNgayKetThuc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtNgayKetThuc.Name = "dtNgayKetThuc";
            this.dtNgayKetThuc.Size = new System.Drawing.Size(130, 27);
            this.dtNgayKetThuc.TabIndex = 25;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(612, 16);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(50, 19);
            this.labelControl6.TabIndex = 12;
            this.labelControl6.Text = "Lần Kí";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(205, 63);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(100, 19);
            this.labelControl5.TabIndex = 11;
            this.labelControl5.Text = "Ngày Bắt Đầu";
            // 
            // dtNgayBatDau
            // 
            this.dtNgayBatDau.CalendarFont = new System.Drawing.Font("Tahoma", 10F);
            this.dtNgayBatDau.CustomFormat = "dd/MM/yyyy";
            this.dtNgayBatDau.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNgayBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgayBatDau.Location = new System.Drawing.Point(332, 54);
            this.dtNgayBatDau.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtNgayBatDau.Name = "dtNgayBatDau";
            this.dtNgayBatDau.Size = new System.Drawing.Size(130, 27);
            this.dtNgayBatDau.TabIndex = 3;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(205, 20);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(96, 19);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Số Hợp Đồng";
            // 
            // txtSoHopDong
            // 
            this.txtSoHopDong.Location = new System.Drawing.Point(332, 17);
            this.txtSoHopDong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSoHopDong.Name = "txtSoHopDong";
            this.txtSoHopDong.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoHopDong.Properties.Appearance.Options.UseFont = true;
            this.txtSoHopDong.Properties.ReadOnly = true;
            this.txtSoHopDong.Size = new System.Drawing.Size(133, 24);
            this.txtSoHopDong.TabIndex = 0;
            // 
            // gcHopDong
            // 
            this.gcHopDong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcHopDong.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gcHopDong.Location = new System.Drawing.Point(0, 0);
            this.gcHopDong.MainView = this.gvHopDong;
            this.gcHopDong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gcHopDong.Name = "gcHopDong";
            this.gcHopDong.Size = new System.Drawing.Size(1549, 294);
            this.gcHopDong.TabIndex = 0;
            this.gcHopDong.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvHopDong});
            // 
            // gvHopDong
            // 
            this.gvHopDong.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.SoHopDong,
            this.NgayBatDau,
            this.NgayKetThuc,
            this.ThoiHan,
            this.HeSoLuong,
            this.LanKy,
            this.MaNV,
            this.HoTen,
            this.NgayKi});
            this.gvHopDong.DetailHeight = 431;
            this.gvHopDong.GridControl = this.gcHopDong;
            this.gvHopDong.Name = "gvHopDong";
            this.gvHopDong.Click += new System.EventHandler(this.gvHopDong_Click);
            // 
            // SoHopDong
            // 
            this.SoHopDong.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SoHopDong.AppearanceCell.Options.UseFont = true;
            this.SoHopDong.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SoHopDong.AppearanceHeader.Options.UseFont = true;
            this.SoHopDong.Caption = "Số Hợp Đồng";
            this.SoHopDong.FieldName = "SoHopDong";
            this.SoHopDong.MaxWidth = 140;
            this.SoHopDong.MinWidth = 140;
            this.SoHopDong.Name = "SoHopDong";
            this.SoHopDong.Visible = true;
            this.SoHopDong.VisibleIndex = 0;
            this.SoHopDong.Width = 140;
            // 
            // NgayBatDau
            // 
            this.NgayBatDau.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NgayBatDau.AppearanceCell.Options.UseFont = true;
            this.NgayBatDau.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NgayBatDau.AppearanceHeader.Options.UseFont = true;
            this.NgayBatDau.Caption = "Ngày Bắt Đầu";
            this.NgayBatDau.FieldName = "NgayBatDau";
            this.NgayBatDau.MaxWidth = 200;
            this.NgayBatDau.MinWidth = 200;
            this.NgayBatDau.Name = "NgayBatDau";
            this.NgayBatDau.Visible = true;
            this.NgayBatDau.VisibleIndex = 2;
            this.NgayBatDau.Width = 200;
            // 
            // NgayKetThuc
            // 
            this.NgayKetThuc.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NgayKetThuc.AppearanceCell.Options.UseFont = true;
            this.NgayKetThuc.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NgayKetThuc.AppearanceHeader.Options.UseFont = true;
            this.NgayKetThuc.Caption = "Ngày Kết Thúc";
            this.NgayKetThuc.FieldName = "NgayKetThuc";
            this.NgayKetThuc.MaxWidth = 200;
            this.NgayKetThuc.MinWidth = 200;
            this.NgayKetThuc.Name = "NgayKetThuc";
            this.NgayKetThuc.Visible = true;
            this.NgayKetThuc.VisibleIndex = 3;
            this.NgayKetThuc.Width = 200;
            // 
            // ThoiHan
            // 
            this.ThoiHan.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThoiHan.AppearanceCell.Options.UseFont = true;
            this.ThoiHan.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThoiHan.AppearanceHeader.Options.UseFont = true;
            this.ThoiHan.Caption = "Thời Hạn";
            this.ThoiHan.FieldName = "ThoiHan";
            this.ThoiHan.MaxWidth = 140;
            this.ThoiHan.MinWidth = 140;
            this.ThoiHan.Name = "ThoiHan";
            this.ThoiHan.Visible = true;
            this.ThoiHan.VisibleIndex = 4;
            this.ThoiHan.Width = 140;
            // 
            // HeSoLuong
            // 
            this.HeSoLuong.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeSoLuong.AppearanceCell.Options.UseFont = true;
            this.HeSoLuong.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeSoLuong.AppearanceHeader.Options.UseFont = true;
            this.HeSoLuong.Caption = "Hệ Số Lương";
            this.HeSoLuong.FieldName = "HeSoLuong";
            this.HeSoLuong.MaxWidth = 140;
            this.HeSoLuong.MinWidth = 140;
            this.HeSoLuong.Name = "HeSoLuong";
            this.HeSoLuong.Visible = true;
            this.HeSoLuong.VisibleIndex = 5;
            this.HeSoLuong.Width = 140;
            // 
            // LanKy
            // 
            this.LanKy.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LanKy.AppearanceCell.Options.UseFont = true;
            this.LanKy.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LanKy.AppearanceHeader.Options.UseFont = true;
            this.LanKy.Caption = "Lần Kí";
            this.LanKy.FieldName = "LanKy";
            this.LanKy.MaxWidth = 140;
            this.LanKy.MinWidth = 140;
            this.LanKy.Name = "LanKy";
            this.LanKy.Visible = true;
            this.LanKy.VisibleIndex = 6;
            this.LanKy.Width = 140;
            // 
            // MaNV
            // 
            this.MaNV.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaNV.AppearanceCell.Options.UseFont = true;
            this.MaNV.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaNV.AppearanceHeader.Options.UseFont = true;
            this.MaNV.Caption = "Mã NV";
            this.MaNV.FieldName = "MaNV";
            this.MaNV.MaxWidth = 140;
            this.MaNV.MinWidth = 140;
            this.MaNV.Name = "MaNV";
            this.MaNV.Width = 140;
            // 
            // HoTen
            // 
            this.HoTen.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HoTen.AppearanceCell.Options.UseFont = true;
            this.HoTen.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HoTen.AppearanceHeader.Options.UseFont = true;
            this.HoTen.Caption = "Nhân Viên";
            this.HoTen.FieldName = "HoTen";
            this.HoTen.MaxWidth = 140;
            this.HoTen.MinWidth = 140;
            this.HoTen.Name = "HoTen";
            this.HoTen.Visible = true;
            this.HoTen.VisibleIndex = 1;
            this.HoTen.Width = 140;
            // 
            // NgayKi
            // 
            this.NgayKi.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NgayKi.AppearanceCell.Options.UseFont = true;
            this.NgayKi.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NgayKi.AppearanceHeader.Options.UseFont = true;
            this.NgayKi.Caption = "Ngày Kí";
            this.NgayKi.FieldName = "NgayKy";
            this.NgayKi.MinWidth = 23;
            this.NgayKi.Name = "NgayKi";
            this.NgayKi.Visible = true;
            this.NgayKi.VisibleIndex = 7;
            this.NgayKi.Width = 87;
            // 
            // frmHopDong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1549, 806);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("frmHopDong.IconOptions.LargeImage")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmHopDong";
            this.Text = "Hợp Đồng ";
            this.Load += new System.EventHandler(this.frmHopDong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.seNhanVien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spHeSoLuong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spLanKi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoHopDong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcHopDong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvHopDong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnSua;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnLuu;
        private DevExpress.XtraBars.BarButtonItem btnHuy;
        private DevExpress.XtraBars.BarButtonItem btnPrint;
        private DevExpress.XtraBars.BarButtonItem btnDong;
        private DevExpress.XtraBars.Bar bar4;
        private DevExpress.XtraBars.Bar bar5;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private System.Windows.Forms.DateTimePicker dtNgayBatDau;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtSoHopDong;
        private DevExpress.XtraGrid.GridControl gcHopDong;
        private DevExpress.XtraGrid.Views.Grid.GridView gvHopDong;
        private DevExpress.XtraGrid.Columns.GridColumn SoHopDong;
        private DevExpress.XtraGrid.Columns.GridColumn NgayBatDau;
        private DevExpress.XtraGrid.Columns.GridColumn NgayKetThuc;
        private DevExpress.XtraGrid.Columns.GridColumn ThoiHan;
        private DevExpress.XtraGrid.Columns.GridColumn HeSoLuong;
        private DevExpress.XtraGrid.Columns.GridColumn LanKy;
        private DevExpress.XtraGrid.Columns.GridColumn MaNV;
        private DevExpress.XtraGrid.Columns.GridColumn HoTen;
        private DevExpress.XtraEditors.SearchLookUpEdit seNhanVien;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.SpinEdit spHeSoLuong;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.SpinEdit spLanKi;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.DateTimePicker dtNgayKi;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.DateTimePicker dtNgayKetThuc;
        private DevExpress.XtraRichEdit.RichEditControl txtNoiDung;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraGrid.Columns.GridColumn NhanVien;
        private DevExpress.XtraGrid.Columns.GridColumn Ten;
        private System.Windows.Forms.ComboBox cbbThoiHan;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraGrid.Columns.GridColumn NgayKi;
    }
}