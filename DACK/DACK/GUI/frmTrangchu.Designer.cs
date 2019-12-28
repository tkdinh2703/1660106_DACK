namespace DACK
{
    partial class frmTrangchu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTrangchu));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.btnDangxuat = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.btnthongtintk = new DevExpress.XtraBars.BarButtonItem();
            this.btnDoimatkhau = new DevExpress.XtraBars.BarButtonItem();
            this.btnquanlyuser = new DevExpress.XtraBars.BarButtonItem();
            this.btnQuyenhan = new DevExpress.XtraBars.BarButtonItem();
            this.btnMuahang = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.btnbanhang = new DevExpress.XtraBars.BarButtonItem();
            this.btnnahnvien = new DevExpress.XtraBars.BarButtonItem();
            this.btnsanpham = new DevExpress.XtraBars.BarButtonItem();
            this.btnnahcungcap = new DevExpress.XtraBars.BarButtonItem();
            this.btnNhasanxuat = new DevExpress.XtraBars.BarButtonItem();
            this.btnkhohang = new DevExpress.XtraBars.BarButtonItem();
            this.btnnhaphang = new DevExpress.XtraBars.BarButtonItem();
            this.bntqlKhachhang = new DevExpress.XtraBars.BarButtonItem();
            this.btntinhtien = new DevExpress.XtraBars.BarButtonItem();
            this.btntratien = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.btnnhasnaxuat = new DevExpress.XtraBars.BarButtonItem();
            this.btnkho = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonHethong = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonDangxuat = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribondoimatkhau = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonDanhmuc = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonBanhang = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonQuanly = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonNhanvien = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.barButtonItem1,
            this.btnDangxuat,
            this.btnThoat,
            this.btnthongtintk,
            this.btnDoimatkhau,
            this.btnquanlyuser,
            this.btnQuyenhan,
            this.btnMuahang,
            this.barButtonItem3,
            this.btnbanhang,
            this.btnnahnvien,
            this.btnsanpham,
            this.btnnahcungcap,
            this.btnNhasanxuat,
            this.btnkhohang,
            this.btnnhaphang,
            this.bntqlKhachhang,
            this.btntinhtien,
            this.btntratien,
            this.barButtonItem2,
            this.barButtonItem4,
            this.btnnhasnaxuat,
            this.btnkho});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 27;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonHethong,
            this.ribbonDanhmuc,
            this.ribbonQuanly});
            this.ribbon.Size = new System.Drawing.Size(927, 158);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 2;
            this.barButtonItem1.ImageOptions.Image = global::DACK.Properties.Resources.logout_icon;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // btnDangxuat
            // 
            this.btnDangxuat.Caption = "Đăng xuất";
            this.btnDangxuat.Id = 3;
            this.btnDangxuat.ImageOptions.LargeImage = global::DACK.Properties.Resources.logout_icon;
            this.btnDangxuat.Name = "btnDangxuat";
            this.btnDangxuat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnDangxuat_ItemClick);
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "Kết Thúc";
            this.btnThoat.Id = 4;
            this.btnThoat.ImageOptions.LargeImage = global::DACK.Properties.Resources.Button_Log_Off_icon;
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnThoat_ItemClick);
            // 
            // btnthongtintk
            // 
            this.btnthongtintk.Caption = "Thông tin tài khoản";
            this.btnthongtintk.Id = 5;
            this.btnthongtintk.ImageOptions.LargeImage = global::DACK.Properties.Resources.Users_icon;
            this.btnthongtintk.Name = "btnthongtintk";
            this.btnthongtintk.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Btnthongtintk_ItemClick);
            // 
            // btnDoimatkhau
            // 
            this.btnDoimatkhau.Caption = "Đổi mật khẩu";
            this.btnDoimatkhau.Id = 6;
            this.btnDoimatkhau.ImageOptions.LargeImage = global::DACK.Properties.Resources.secrecy_icon;
            this.btnDoimatkhau.Name = "btnDoimatkhau";
            this.btnDoimatkhau.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnDoimatkhau_ItemClick);
            // 
            // btnquanlyuser
            // 
            this.btnquanlyuser.Caption = "Quản lý người dùng";
            this.btnquanlyuser.Id = 7;
            this.btnquanlyuser.ImageOptions.LargeImage = global::DACK.Properties.Resources.notebook_girl_icon;
            this.btnquanlyuser.Name = "btnquanlyuser";
            this.btnquanlyuser.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Btnquanlyuser_ItemClick);
            // 
            // btnQuyenhan
            // 
            this.btnQuyenhan.Caption = "Quyền hạn";
            this.btnQuyenhan.Id = 8;
            this.btnQuyenhan.ImageOptions.LargeImage = global::DACK.Properties.Resources.Actions_user_group_delete_icon;
            this.btnQuyenhan.Name = "btnQuyenhan";
            // 
            // btnMuahang
            // 
            this.btnMuahang.Caption = "Mua hàng";
            this.btnMuahang.Id = 9;
            this.btnMuahang.ImageOptions.LargeImage = global::DACK.Properties.Resources.cach_mua_si_tai_tong_kho_si_sai_gon;
            this.btnMuahang.Name = "btnMuahang";
            this.btnMuahang.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnMuahang_ItemClick);
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "barButtonItem3";
            this.barButtonItem3.Id = 10;
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // btnbanhang
            // 
            this.btnbanhang.Caption = "Bán hàng";
            this.btnbanhang.Id = 11;
            this.btnbanhang.Name = "btnbanhang";
            this.btnbanhang.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Btnbanhang_ItemClick);
            // 
            // btnnahnvien
            // 
            this.btnnahnvien.Caption = "Nhân viên";
            this.btnnahnvien.Id = 12;
            this.btnnahnvien.ImageOptions.LargeImage = global::DACK.Properties.Resources.Users_icon;
            this.btnnahnvien.Name = "btnnahnvien";
            this.btnnahnvien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Btnnahnvien_ItemClick);
            // 
            // btnsanpham
            // 
            this.btnsanpham.Caption = "Sản phẩm";
            this.btnsanpham.Id = 14;
            this.btnsanpham.ImageOptions.LargeImage = global::DACK.Properties.Resources.OCON;
            this.btnsanpham.Name = "btnsanpham";
            this.btnsanpham.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Btnsanpham_ItemClick);
            // 
            // btnnahcungcap
            // 
            this.btnnahcungcap.Caption = "Nhà cung cấp";
            this.btnnahcungcap.Id = 15;
            this.btnnahcungcap.ImageOptions.LargeImage = global::DACK.Properties.Resources._2339C1;
            this.btnnahcungcap.Name = "btnnahcungcap";
            this.btnnahcungcap.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Btnnahcungcap_ItemClick);
            // 
            // btnNhasanxuat
            // 
            this.btnNhasanxuat.Caption = "Nhà Sản Xuất";
            this.btnNhasanxuat.Id = 16;
            this.btnNhasanxuat.ImageOptions.LargeImage = global::DACK.Properties.Resources.erp_manufacturing_phan_mem_quan_ly_san_xuat;
            this.btnNhasanxuat.Name = "btnNhasanxuat";
            this.btnNhasanxuat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnNhasanxuat_ItemClick);
            // 
            // btnkhohang
            // 
            this.btnkhohang.Caption = "Kho hàng";
            this.btnkhohang.Id = 17;
            this.btnkhohang.Name = "btnkhohang";
            this.btnkhohang.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Btnkhohang_ItemClick);
            // 
            // btnnhaphang
            // 
            this.btnnhaphang.Caption = "Bán hàng";
            this.btnnhaphang.Id = 18;
            this.btnnhaphang.ImageOptions.LargeImage = global::DACK.Properties.Resources._34111331981_80664f28e0_o;
            this.btnnhaphang.Name = "btnnhaphang";
            this.btnnhaphang.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Btnnhaphang_ItemClick);
            // 
            // bntqlKhachhang
            // 
            this.bntqlKhachhang.Caption = "Khách hàng";
            this.bntqlKhachhang.Id = 19;
            this.bntqlKhachhang.ImageOptions.LargeImage = global::DACK.Properties.Resources.images;
            this.bntqlKhachhang.Name = "bntqlKhachhang";
            this.bntqlKhachhang.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BntqlKhachhang_ItemClick);
            // 
            // btntinhtien
            // 
            this.btntinhtien.Caption = "Tính tiền    ";
            this.btntinhtien.Id = 20;
            this.btntinhtien.ImageOptions.LargeImage = global::DACK.Properties.Resources.payment_icon;
            this.btntinhtien.Name = "btntinhtien";
            this.btntinhtien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Btntinhtien_ItemClick);
            // 
            // btntratien
            // 
            this.btntratien.Caption = "Trả tiền";
            this.btntratien.Id = 21;
            this.btntratien.ImageOptions.LargeImage = global::DACK.Properties.Resources.cartera_cuero_marron_mucho_dinero_68708_304;
            this.btntratien.Name = "btntratien";
            this.btntratien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Btntratien_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "barButtonItem2";
            this.barButtonItem2.Id = 23;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "barButtonItem4";
            this.barButtonItem4.Id = 24;
            this.barButtonItem4.Name = "barButtonItem4";
            // 
            // btnnhasnaxuat
            // 
            this.btnnhasnaxuat.Caption = "Nhà sản xuất";
            this.btnnhasnaxuat.Id = 25;
            this.btnnhasnaxuat.ImageOptions.LargeImage = global::DACK.Properties.Resources.erp_manufacturing_phan_mem_quan_ly_san_xuat;
            this.btnnhasnaxuat.Name = "btnnhasnaxuat";
            this.btnnhasnaxuat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Btnnhasnaxuat_ItemClick);
            // 
            // btnkho
            // 
            this.btnkho.Caption = "Kho hàng";
            this.btnkho.Id = 26;
            this.btnkho.ImageOptions.LargeImage = global::DACK.Properties.Resources.icon_kho_report_31;
            this.btnkho.Name = "btnkho";
            this.btnkho.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Btnkho_ItemClick);
            // 
            // ribbonHethong
            // 
            this.ribbonHethong.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonDangxuat,
            this.ribondoimatkhau});
            this.ribbonHethong.Name = "ribbonHethong";
            this.ribbonHethong.Text = "Hệ thống";
            // 
            // ribbonDangxuat
            // 
            this.ribbonDangxuat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ribbonDangxuat.ImageOptions.Image")));
            this.ribbonDangxuat.ItemLinks.Add(this.btnDangxuat);
            this.ribbonDangxuat.ItemLinks.Add(this.btnThoat);
            this.ribbonDangxuat.ItemLinks.Add(this.btnquanlyuser);
            this.ribbonDangxuat.Name = "ribbonDangxuat";
            this.ribbonDangxuat.Text = "Hệ thống";
            // 
            // ribondoimatkhau
            // 
            this.ribondoimatkhau.ItemLinks.Add(this.btnthongtintk);
            this.ribondoimatkhau.ItemLinks.Add(this.btnDoimatkhau);
            this.ribondoimatkhau.ItemLinks.Add(this.btnQuyenhan);
            this.ribondoimatkhau.Name = "ribondoimatkhau";
            this.ribondoimatkhau.Text = "Bảo mật";
            // 
            // ribbonDanhmuc
            // 
            this.ribbonDanhmuc.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonBanhang,
            this.ribbonPageGroup1});
            this.ribbonDanhmuc.Name = "ribbonDanhmuc";
            this.ribbonDanhmuc.Text = "Danh Mục";
            // 
            // ribbonBanhang
            // 
            this.ribbonBanhang.ItemLinks.Add(this.btnMuahang);
            this.ribbonBanhang.ItemLinks.Add(this.btnnhaphang);
            this.ribbonBanhang.Name = "ribbonBanhang";
            this.ribbonBanhang.Text = "Giao dịch";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btntinhtien);
            this.ribbonPageGroup1.ItemLinks.Add(this.btntratien);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Thanh toán";
            // 
            // ribbonQuanly
            // 
            this.ribbonQuanly.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonNhanvien,
            this.ribbonPageGroup2});
            this.ribbonQuanly.Name = "ribbonQuanly";
            this.ribbonQuanly.Text = "Quản lý";
            // 
            // ribbonNhanvien
            // 
            this.ribbonNhanvien.ItemLinks.Add(this.btnnahnvien);
            this.ribbonNhanvien.ItemLinks.Add(this.btnsanpham);
            this.ribbonNhanvien.ItemLinks.Add(this.bntqlKhachhang);
            this.ribbonNhanvien.Name = "ribbonNhanvien";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnnahcungcap);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnnhasnaxuat);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnkho);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 473);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(927, 24);
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // frmTrangchu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 497);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.IconOptions.Image = global::DACK.Properties.Resources.Text_Documents_icon;
            this.IsMdiContainer = true;
            this.Name = "frmTrangchu";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Trang chủ";
            this.Load += new System.EventHandler(this.FrmTrangchu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonHethong;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonDangxuat;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribondoimatkhau;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonDanhmuc;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonBanhang;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonQuanly;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonNhanvien;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem btnDangxuat;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private DevExpress.XtraBars.BarButtonItem btnthongtintk;
        private DevExpress.XtraBars.BarButtonItem btnDoimatkhau;
        private DevExpress.XtraBars.BarButtonItem btnquanlyuser;
        private DevExpress.XtraBars.BarButtonItem btnQuyenhan;
        private DevExpress.XtraBars.BarButtonItem btnMuahang;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem btnbanhang;
        private DevExpress.XtraBars.BarButtonItem btnnahnvien;
        private DevExpress.XtraBars.BarButtonItem btnsanpham;
        private DevExpress.XtraBars.BarButtonItem btnnahcungcap;
        private DevExpress.XtraBars.BarButtonItem btnNhasanxuat;
        private DevExpress.XtraBars.BarButtonItem btnkhohang;
        private DevExpress.XtraBars.BarButtonItem btnnhaphang;
        private DevExpress.XtraBars.BarButtonItem bntqlKhachhang;
        private DevExpress.XtraBars.BarButtonItem btntinhtien;
        private DevExpress.XtraBars.BarButtonItem btntratien;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarButtonItem btnnhasnaxuat;
        private DevExpress.XtraBars.BarButtonItem btnkho;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
    }
}