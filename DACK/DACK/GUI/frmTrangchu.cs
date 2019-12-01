using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DACK.GUI;
using DACK.BUS;
using DACK.DTO;

namespace DACK
{
    public partial class frmTrangchu : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        int Id, Role;
        string passwork;
        public delegate void addsanpham();
        public event addsanpham khiketthuc = null;

        public delegate void dangxuat();
        public event dangxuat khiDangXuat = null;

        public frmTrangchu()
        {
            InitializeComponent();
        }

        public frmTrangchu(int role, int Id,string  passwork)
        {
            InitializeComponent();
            this.Id = Id;
            this.Role = role;
            this.passwork = passwork;
           
        }

        private void Btnquanlyuser_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmQlnguoidung qlnguoidung = new frmQlnguoidung(Role,1);
            qlnguoidung.Show();
        }

        private void Btnnahnvien_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmQlnguoidung qlnhansu = new frmQlnguoidung(Role,2);
            qlnhansu.Show();
        }

        private void Btnsanpham_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmQlsanpham qlsanpham = new frmQlsanpham(Role);
            qlsanpham.Show();
        }

        private void BtnDangxuat_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
            this.khiDangXuat();
        }

        private void Btnnahcungcap_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmQlnhacungcap frmQlnhacungcap = new FrmQlnhacungcap(Role);
            frmQlnhacungcap.Show();
        }

        private void BtnNhasanxuat_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmQlnhasanxuat qlnhasanxuat = new frmQlnhasanxuat(Role);
            qlnhasanxuat.Show();
        }

        private void Btnkhohang_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmQlkhohang qlkhohang = new frmQlkhohang(Role);
            qlkhohang.Show();
        }

        private void BtnDoimatkhau_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmDoimatkhau doimatkhau=new frmDoimatkhau(Id,passwork);
            doimatkhau.Show();
            doimatkhau.khicapnhat += Doimatkhau_khicapnhat;
        }

        private void Doimatkhau_khicapnhat()
        {
            this.Close();
        }

        private void BtnThoat_ItemClick(object sender, ItemClickEventArgs e)
        {
            khiketthuc();
        }

        private void Btnthongtintk_ItemClick(object sender, ItemClickEventArgs e)
        {
            NhansuBUS nhansuBUS = new NhansuBUS();
            Nhansu nhansu = nhansuBUS.Laynhansu(Id);
            Themsuanguoidung themsuanguoidung = new Themsuanguoidung(nhansu,passwork);
            themsuanguoidung.Show();
        }

        private void Btnbanhang_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void FrmTrangchu_Load(object sender, EventArgs e)
        {
            if (Role == 1) {
                btnquanlyuser.Enabled = false;
                
            }
        }
    }
}