namespace DACK.GUI
{
    partial class frmQlnguoidung
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQlnguoidung));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnthem = new DevExpress.XtraBars.BarButtonItem();
            this.btnsua = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnin = new DevExpress.XtraBars.BarButtonItem();
            this.btnnhap = new DevExpress.XtraBars.BarButtonItem();
            this.btnxuat = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenDangNhap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MatKhau = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Ten = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Email = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NgayThamgia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Diachi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Gioitinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Nganhang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Sotk = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Sodienthoai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdQuyen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnthem,
            this.btnsua,
            this.btnin,
            this.btnXoa,
            this.btnnhap,
            this.btnxuat});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 6;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnthem),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnsua),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnXoa),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnin),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnnhap),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnxuat)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnthem
            // 
            this.btnthem.Caption = "Thêm";
            this.btnthem.Id = 0;
            this.btnthem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnthem.ImageOptions.Image")));
            this.btnthem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnthem.ImageOptions.LargeImage")));
            this.btnthem.Name = "btnthem";
            this.btnthem.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnthem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Btnthem_ItemClick);
            // 
            // btnsua
            // 
            this.btnsua.Caption = "Sửa";
            this.btnsua.Id = 1;
            this.btnsua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnsua.ImageOptions.Image")));
            this.btnsua.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnsua.ImageOptions.LargeImage")));
            this.btnsua.Name = "btnsua";
            this.btnsua.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnsua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Btnsua_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.Id = 3;
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.LargeImage")));
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnXoa_ItemClick);
            // 
            // btnin
            // 
            this.btnin.Caption = "In";
            this.btnin.Id = 2;
            this.btnin.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnin.ImageOptions.Image")));
            this.btnin.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnin.ImageOptions.LargeImage")));
            this.btnin.Name = "btnin";
            this.btnin.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // btnnhap
            // 
            this.btnnhap.Caption = "Nhập ";
            this.btnnhap.Id = 4;
            this.btnnhap.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnnhap.ImageOptions.Image")));
            this.btnnhap.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnnhap.ImageOptions.LargeImage")));
            this.btnnhap.Name = "btnnhap";
            this.btnnhap.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // btnxuat
            // 
            this.btnxuat.Caption = "Xuất";
            this.btnxuat.Id = 5;
            this.btnxuat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnxuat.ImageOptions.Image")));
            this.btnxuat.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnxuat.ImageOptions.LargeImage")));
            this.btnxuat.Name = "btnxuat";
            this.btnxuat.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(870, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 268);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(870, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 244);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(870, 24);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 244);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gridControl1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 24);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(870, 244);
            this.layoutControl1.TabIndex = 4;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(12, 12);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.barManager1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(846, 220);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Id,
            this.TenDangNhap,
            this.MatKhau,
            this.Ten,
            this.Email,
            this.NgayThamgia,
            this.Diachi,
            this.Gioitinh,
            this.Nganhang,
            this.Sotk,
            this.Sodienthoai,
            this.IdQuyen});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // Id
            // 
            this.Id.Caption = "Mã người dùng";
            this.Id.FieldName = "Id";
            this.Id.Name = "Id";
            this.Id.Visible = true;
            this.Id.VisibleIndex = 0;
            // 
            // TenDangNhap
            // 
            this.TenDangNhap.Caption = "Tên đăng nhập";
            this.TenDangNhap.FieldName = "TenDangNhap";
            this.TenDangNhap.Name = "TenDangNhap";
            this.TenDangNhap.Visible = true;
            this.TenDangNhap.VisibleIndex = 1;
            // 
            // MatKhau
            // 
            this.MatKhau.Caption = "Mật khẩu";
            this.MatKhau.FieldName = "MatKhau";
            this.MatKhau.Name = "MatKhau";
            this.MatKhau.Visible = true;
            this.MatKhau.VisibleIndex = 2;
            // 
            // Ten
            // 
            this.Ten.Caption = "Họ tên";
            this.Ten.FieldName = "Ten";
            this.Ten.Name = "Ten";
            this.Ten.Visible = true;
            this.Ten.VisibleIndex = 3;
            // 
            // Email
            // 
            this.Email.Caption = "Email";
            this.Email.FieldName = "Email";
            this.Email.Name = "Email";
            this.Email.Visible = true;
            this.Email.VisibleIndex = 4;
            // 
            // NgayThamgia
            // 
            this.NgayThamgia.Caption = "Ngày tham gia";
            this.NgayThamgia.FieldName = "NgayThamgia";
            this.NgayThamgia.Name = "NgayThamgia";
            this.NgayThamgia.Visible = true;
            this.NgayThamgia.VisibleIndex = 5;
            // 
            // Diachi
            // 
            this.Diachi.Caption = "Địa chỉ";
            this.Diachi.FieldName = "Diachi";
            this.Diachi.Name = "Diachi";
            this.Diachi.Visible = true;
            this.Diachi.VisibleIndex = 6;
            // 
            // Gioitinh
            // 
            this.Gioitinh.Caption = "Giới tính";
            this.Gioitinh.FieldName = "Gioitinh";
            this.Gioitinh.Name = "Gioitinh";
            this.Gioitinh.Visible = true;
            this.Gioitinh.VisibleIndex = 7;
            // 
            // Nganhang
            // 
            this.Nganhang.Caption = "Ngân hàng";
            this.Nganhang.FieldName = "Nganhang";
            this.Nganhang.Name = "Nganhang";
            this.Nganhang.Visible = true;
            this.Nganhang.VisibleIndex = 8;
            // 
            // Sotk
            // 
            this.Sotk.Caption = "Số tài khoản";
            this.Sotk.FieldName = "Sotk";
            this.Sotk.Name = "Sotk";
            this.Sotk.Visible = true;
            this.Sotk.VisibleIndex = 9;
            // 
            // Sodienthoai
            // 
            this.Sodienthoai.Caption = "Số điện thoại";
            this.Sodienthoai.FieldName = "Sodienthoai";
            this.Sodienthoai.Name = "Sodienthoai";
            this.Sodienthoai.Visible = true;
            this.Sodienthoai.VisibleIndex = 10;
            // 
            // IdQuyen
            // 
            this.IdQuyen.Caption = "Mã quyền hạn";
            this.IdQuyen.FieldName = "IdQuyen";
            this.IdQuyen.Name = "IdQuyen";
            this.IdQuyen.Visible = true;
            this.IdQuyen.VisibleIndex = 11;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(870, 244);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(850, 224);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // frmQlnguoidung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 268);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmQlnguoidung";
            this.Text = "Quản lý người dùng";
            this.Load += new System.EventHandler(this.FrmQlnguoidung_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnthem;
        private DevExpress.XtraBars.BarButtonItem btnsua;
        private DevExpress.XtraBars.BarButtonItem btnin;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnnhap;
        private DevExpress.XtraBars.BarButtonItem btnxuat;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn Id;
        private DevExpress.XtraGrid.Columns.GridColumn TenDangNhap;
        private DevExpress.XtraGrid.Columns.GridColumn MatKhau;
        private DevExpress.XtraGrid.Columns.GridColumn Ten;
        private DevExpress.XtraGrid.Columns.GridColumn Email;
        private DevExpress.XtraGrid.Columns.GridColumn NgayThamgia;
        private DevExpress.XtraGrid.Columns.GridColumn Diachi;
        private DevExpress.XtraGrid.Columns.GridColumn Gioitinh;
        private DevExpress.XtraGrid.Columns.GridColumn Nganhang;
        private DevExpress.XtraGrid.Columns.GridColumn Sotk;
        private DevExpress.XtraGrid.Columns.GridColumn Sodienthoai;
        private DevExpress.XtraGrid.Columns.GridColumn IdQuyen;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
    }
}