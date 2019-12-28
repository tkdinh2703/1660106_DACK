namespace DACK
{
    partial class frmQlsanpham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQlsanpham));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnthem = new DevExpress.XtraBars.BarButtonItem();
            this.bntxoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnsua = new DevExpress.XtraBars.BarButtonItem();
            this.btnin = new DevExpress.XtraBars.BarButtonItem();
            this.btnhap = new DevExpress.XtraBars.BarButtonItem();
            this.btnxuat = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.grvsanpham = new DevExpress.XtraGrid.GridControl();
            this.grviewsanpham = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LoaiHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NgaySanXuat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.XuatXu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoLuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Thuonghieu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NhaCungCap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GiaMua = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GiaBan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.VAT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HinhAnh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemPictureEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.repositoryItemPictureEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.repositoryItemImageEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemImageEdit();
            this.repositoryItemImageEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemImageEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvsanpham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grviewsanpham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageEdit2)).BeginInit();
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
            this.bntxoa,
            this.btnsua,
            this.btnin,
            this.btnhap,
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
            new DevExpress.XtraBars.LinkPersistInfo(this.bntxoa),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnin),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnhap),
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
            // bntxoa
            // 
            this.bntxoa.Caption = "Xóa";
            this.bntxoa.Id = 1;
            this.bntxoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bntxoa.ImageOptions.Image")));
            this.bntxoa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bntxoa.ImageOptions.LargeImage")));
            this.bntxoa.Name = "bntxoa";
            this.bntxoa.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.bntxoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Bntxoa_ItemClick);
            // 
            // btnsua
            // 
            this.btnsua.Caption = "Sửa";
            this.btnsua.Id = 2;
            this.btnsua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnsua.ImageOptions.Image")));
            this.btnsua.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnsua.ImageOptions.LargeImage")));
            this.btnsua.Name = "btnsua";
            this.btnsua.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnsua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Btnsua_ItemClick);
            // 
            // btnin
            // 
            this.btnin.Caption = "In";
            this.btnin.Id = 3;
            this.btnin.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnin.ImageOptions.Image")));
            this.btnin.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnin.ImageOptions.LargeImage")));
            this.btnin.Name = "btnin";
            this.btnin.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // btnhap
            // 
            this.btnhap.Caption = "Nhập";
            this.btnhap.Id = 4;
            this.btnhap.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnhap.ImageOptions.Image")));
            this.btnhap.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnhap.ImageOptions.LargeImage")));
            this.btnhap.Name = "btnhap";
            this.btnhap.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
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
            this.barDockControlTop.Size = new System.Drawing.Size(963, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 449);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(963, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 425);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(963, 24);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 425);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.grvsanpham);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 24);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(853, 148, 409, 266);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(963, 425);
            this.layoutControl1.TabIndex = 9;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // grvsanpham
            // 
            this.grvsanpham.EmbeddedNavigator.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Grvsanpham_EmbeddedNavigator_MouseClick);
            this.grvsanpham.Location = new System.Drawing.Point(12, 12);
            this.grvsanpham.MainView = this.grviewsanpham;
            this.grvsanpham.MenuManager = this.barManager1;
            this.grvsanpham.Name = "grvsanpham";
            this.grvsanpham.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemPictureEdit1,
            this.repositoryItemImageEdit1,
            this.repositoryItemImageEdit2,
            this.repositoryItemPictureEdit2});
            this.grvsanpham.Size = new System.Drawing.Size(939, 401);
            this.grvsanpham.TabIndex = 0;
            this.grvsanpham.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grviewsanpham});
            // 
            // grviewsanpham
            // 
            this.grviewsanpham.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Id,
            this.TenHang,
            this.LoaiHang,
            this.NgaySanXuat,
            this.XuatXu,
            this.SoLuong,
            this.Thuonghieu,
            this.NhaCungCap,
            this.GiaMua,
            this.GiaBan,
            this.VAT,
            this.HinhAnh});
            this.grviewsanpham.GridControl = this.grvsanpham;
            this.grviewsanpham.GroupPanelText = "Nhập từ tìm kiếm";
            this.grviewsanpham.Name = "grviewsanpham";
            this.grviewsanpham.RowHeight = 120;
            this.grviewsanpham.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.Grviewsanpham_RowClick);
            this.grviewsanpham.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.Grviewsanpham_RowCellClick);
            this.grviewsanpham.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(this.Grviewsanpham_CustomDrawCell);
            // 
            // Id
            // 
            this.Id.AppearanceCell.Options.UseTextOptions = true;
            this.Id.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Id.Caption = "Mã sản phẩm";
            this.Id.FieldName = "Id";
            this.Id.Name = "Id";
            this.Id.OptionsColumn.AllowEdit = false;
            this.Id.OptionsColumn.AllowFocus = false;
            this.Id.Visible = true;
            this.Id.VisibleIndex = 0;
            // 
            // TenHang
            // 
            this.TenHang.AppearanceCell.Options.UseTextOptions = true;
            this.TenHang.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.TenHang.Caption = "Tên Hàng";
            this.TenHang.FieldName = "TenHang";
            this.TenHang.Name = "TenHang";
            this.TenHang.OptionsColumn.AllowEdit = false;
            this.TenHang.OptionsColumn.AllowFocus = false;
            this.TenHang.Visible = true;
            this.TenHang.VisibleIndex = 1;
            // 
            // LoaiHang
            // 
            this.LoaiHang.AppearanceCell.Options.UseTextOptions = true;
            this.LoaiHang.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.LoaiHang.Caption = "Loại Hàng";
            this.LoaiHang.FieldName = "LoaiHang";
            this.LoaiHang.Name = "LoaiHang";
            this.LoaiHang.OptionsColumn.AllowEdit = false;
            this.LoaiHang.OptionsColumn.AllowFocus = false;
            this.LoaiHang.Visible = true;
            this.LoaiHang.VisibleIndex = 2;
            // 
            // NgaySanXuat
            // 
            this.NgaySanXuat.AppearanceCell.Options.UseTextOptions = true;
            this.NgaySanXuat.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.NgaySanXuat.Caption = "Ngày Sản Xuất";
            this.NgaySanXuat.FieldName = "NgaySanXuat";
            this.NgaySanXuat.Name = "NgaySanXuat";
            this.NgaySanXuat.OptionsColumn.AllowEdit = false;
            this.NgaySanXuat.OptionsColumn.AllowFocus = false;
            this.NgaySanXuat.Visible = true;
            this.NgaySanXuat.VisibleIndex = 3;
            // 
            // XuatXu
            // 
            this.XuatXu.AppearanceCell.Options.UseTextOptions = true;
            this.XuatXu.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.XuatXu.Caption = "Xuất Xứ";
            this.XuatXu.FieldName = "XuatXu";
            this.XuatXu.Name = "XuatXu";
            this.XuatXu.OptionsColumn.AllowEdit = false;
            this.XuatXu.OptionsColumn.AllowFocus = false;
            this.XuatXu.Visible = true;
            this.XuatXu.VisibleIndex = 4;
            // 
            // SoLuong
            // 
            this.SoLuong.AppearanceCell.Options.UseTextOptions = true;
            this.SoLuong.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.SoLuong.Caption = "Số Lượng";
            this.SoLuong.FieldName = "SoLuong";
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.OptionsColumn.AllowEdit = false;
            this.SoLuong.OptionsColumn.AllowFocus = false;
            this.SoLuong.Visible = true;
            this.SoLuong.VisibleIndex = 5;
            // 
            // Thuonghieu
            // 
            this.Thuonghieu.AppearanceCell.Options.UseTextOptions = true;
            this.Thuonghieu.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Thuonghieu.Caption = "Thương Hiệu";
            this.Thuonghieu.FieldName = "Thuonghieu";
            this.Thuonghieu.Name = "Thuonghieu";
            this.Thuonghieu.OptionsColumn.AllowEdit = false;
            this.Thuonghieu.OptionsColumn.AllowFocus = false;
            this.Thuonghieu.Visible = true;
            this.Thuonghieu.VisibleIndex = 6;
            // 
            // NhaCungCap
            // 
            this.NhaCungCap.AppearanceCell.Options.UseTextOptions = true;
            this.NhaCungCap.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.NhaCungCap.Caption = "Nhà Cung Cấp";
            this.NhaCungCap.FieldName = "NhaCungCap";
            this.NhaCungCap.Name = "NhaCungCap";
            this.NhaCungCap.OptionsColumn.AllowEdit = false;
            this.NhaCungCap.OptionsColumn.AllowFocus = false;
            this.NhaCungCap.Visible = true;
            this.NhaCungCap.VisibleIndex = 7;
            // 
            // GiaMua
            // 
            this.GiaMua.AppearanceCell.Options.UseTextOptions = true;
            this.GiaMua.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GiaMua.Caption = "Giá mua";
            this.GiaMua.FieldName = "GiaMua";
            this.GiaMua.Name = "GiaMua";
            this.GiaMua.OptionsColumn.AllowEdit = false;
            this.GiaMua.OptionsColumn.AllowFocus = false;
            this.GiaMua.Visible = true;
            this.GiaMua.VisibleIndex = 8;
            // 
            // GiaBan
            // 
            this.GiaBan.AppearanceCell.Options.UseTextOptions = true;
            this.GiaBan.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GiaBan.Caption = "Giá bán ";
            this.GiaBan.FieldName = "GiaBan";
            this.GiaBan.Name = "GiaBan";
            this.GiaBan.OptionsColumn.AllowEdit = false;
            this.GiaBan.OptionsColumn.AllowFocus = false;
            this.GiaBan.Visible = true;
            this.GiaBan.VisibleIndex = 9;
            // 
            // VAT
            // 
            this.VAT.AppearanceCell.Options.UseTextOptions = true;
            this.VAT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.VAT.Caption = "VAT";
            this.VAT.FieldName = "VAT";
            this.VAT.Name = "VAT";
            this.VAT.OptionsColumn.AllowEdit = false;
            this.VAT.OptionsColumn.AllowFocus = false;
            this.VAT.Visible = true;
            this.VAT.VisibleIndex = 10;
            // 
            // HinhAnh
            // 
            this.HinhAnh.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.HinhAnh.AppearanceHeader.Options.UseImage = true;
            this.HinhAnh.Caption = "Hình ảnh";
            this.HinhAnh.ColumnEdit = this.repositoryItemPictureEdit2;
            this.HinhAnh.FieldName = "HinhAnh";
            this.HinhAnh.Name = "HinhAnh";
            this.HinhAnh.OptionsColumn.AllowEdit = false;
            this.HinhAnh.OptionsColumn.AllowFocus = false;
            this.HinhAnh.Visible = true;
            this.HinhAnh.VisibleIndex = 11;
            this.HinhAnh.Width = 175;
            // 
            // repositoryItemPictureEdit2
            // 
            this.repositoryItemPictureEdit2.Name = "repositoryItemPictureEdit2";
            this.repositoryItemPictureEdit2.ZoomPercent = 22D;
            // 
            // repositoryItemPictureEdit1
            // 
            this.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1";
            this.repositoryItemPictureEdit1.ZoomPercent = 40D;
            // 
            // repositoryItemImageEdit1
            // 
            this.repositoryItemImageEdit1.AutoHeight = false;
            this.repositoryItemImageEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemImageEdit1.Name = "repositoryItemImageEdit1";
            // 
            // repositoryItemImageEdit2
            // 
            this.repositoryItemImageEdit2.AutoHeight = false;
            this.repositoryItemImageEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemImageEdit2.Name = "repositoryItemImageEdit2";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(963, 425);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.grvsanpham;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(943, 405);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // frmQlsanpham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 449);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmQlsanpham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý sản phẩm";
            this.Load += new System.EventHandler(this.Qlsanpham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grvsanpham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grviewsanpham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageEdit2)).EndInit();
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
        private DevExpress.XtraBars.BarButtonItem bntxoa;
        private DevExpress.XtraBars.BarButtonItem btnsua;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraGrid.GridControl grvsanpham;
        private DevExpress.XtraGrid.Views.Grid.GridView grviewsanpham;
        private DevExpress.XtraGrid.Columns.GridColumn Id;
        private DevExpress.XtraGrid.Columns.GridColumn TenHang;
        private DevExpress.XtraGrid.Columns.GridColumn LoaiHang;
        private DevExpress.XtraGrid.Columns.GridColumn NgaySanXuat;
        private DevExpress.XtraGrid.Columns.GridColumn XuatXu;
        private DevExpress.XtraGrid.Columns.GridColumn SoLuong;
        private DevExpress.XtraGrid.Columns.GridColumn Thuonghieu;
        private DevExpress.XtraGrid.Columns.GridColumn NhaCungCap;
        private DevExpress.XtraGrid.Columns.GridColumn GiaMua;
        private DevExpress.XtraGrid.Columns.GridColumn GiaBan;
        private DevExpress.XtraGrid.Columns.GridColumn VAT;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemPictureEdit1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageEdit repositoryItemImageEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn HinhAnh;
        private DevExpress.XtraBars.BarButtonItem btnin;
        private DevExpress.XtraBars.BarButtonItem btnhap;
        private DevExpress.XtraBars.BarButtonItem btnxuat;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageEdit repositoryItemImageEdit2;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemPictureEdit2;
    }
}