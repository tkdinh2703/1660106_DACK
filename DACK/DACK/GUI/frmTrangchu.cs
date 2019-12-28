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
        private Form Isactive(Type type)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == type)
                {
                    return f;
                }
            }
            return null;
        }
        private void Btnquanlyuser_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form form = Isactive(typeof(frmQlnhansu));
            if (form == null)
            {
                frmQlnhansu qlnguoidung = new frmQlnhansu(Role, 1);
                qlnguoidung.MdiParent = this;
                qlnguoidung.Show();
            }
            else
            {
                
                if (form.Text == "frmQlnguoidung")
                {
                    frmQlnhansu qlnguoidung = new frmQlnhansu(Role, 1);
                    qlnguoidung.MdiParent = this;
                    qlnguoidung.Show();
                }else
                    form.Activate();
            }

        }

        private void Btnnahnvien_ItemClick(object sender, ItemClickEventArgs e)
        {
            
            Form form = Isactive(typeof(frmQlnguoidung));
            if (form == null)
            {
                frmQlnguoidung qlnhansu = new frmQlnguoidung(Role, 2);
                qlnhansu.MdiParent = this;
                qlnhansu.Show();
            }
            else
                form.Activate();
        }

        private void Btnsanpham_ItemClick(object sender, ItemClickEventArgs e)
        {
                      
            Form form = Isactive(typeof(frmQlsanpham));
            if (form == null)
            {
                frmQlsanpham qlsanpham = new frmQlsanpham(Role);
                qlsanpham.MdiParent = this;
                qlsanpham.Show();
            }
            else
                form.Activate();
        }

        private void BtnDangxuat_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
            this.khiDangXuat();
        }

        private void Btnnahcungcap_ItemClick(object sender, ItemClickEventArgs e)
        {
                    
            Form form = Isactive(typeof(FrmQlnhacungcap));
            if (form == null)
            {
                FrmQlnhacungcap frmQlnhacungcap = new FrmQlnhacungcap(Role);
                frmQlnhacungcap.MdiParent = this;
                frmQlnhacungcap.Show();
            }
            else
                form.Activate();
        }

        private void BtnNhasanxuat_ItemClick(object sender, ItemClickEventArgs e)
        {
            
        }

        private void Btnkhohang_ItemClick(object sender, ItemClickEventArgs e)
        {
           
        }

        private void BtnDoimatkhau_ItemClick(object sender, ItemClickEventArgs e)
        {

            Form form = Isactive(typeof(frmDoimatkhau));
            if (form == null)
            {

                frmDoimatkhau doimatkhau = new frmDoimatkhau(Id, passwork);
                doimatkhau.MdiParent = this;
                doimatkhau.Show();
                doimatkhau.khicapnhat += Doimatkhau_khicapnhat;
            }
            else
                form.Activate();
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
           
            Form form = Isactive(typeof(Themsuanguoidung));
            if (form == null)
            {
                Themsuanguoidung themsuanguoidung = new Themsuanguoidung(nhansu, passwork);              
                themsuanguoidung.MdiParent = this;
                themsuanguoidung.Show();
            }
            else
                form.Activate();
        }

        private void Btnbanhang_ItemClick(object sender, ItemClickEventArgs e)
        {
            
            Form form = Isactive(typeof(frmBanhang));
            if (form == null)
            {
                frmBanhang banhang = new frmBanhang(Id);
                banhang.MdiParent = this;
                banhang.Show();
            }
            else
                form.Activate();
        }

        private void BntqlKhachhang_ItemClick(object sender, ItemClickEventArgs e)
        {

            Form form = Isactive(typeof(frmQlKhachhang));
            if (form == null)
            {
                frmQlKhachhang banhang = new frmQlKhachhang(Role);
                banhang.MdiParent = this;
                banhang.Show();
            }
            else
                form.Activate();
        }

        private void BtnMuahang_ItemClick(object sender, ItemClickEventArgs e)
        {
        
            Form form = Isactive(typeof(frmMuahang));
            if (form == null)
            {
                frmMuahang banhang = new frmMuahang(Id);
                banhang.MdiParent = this;
                banhang.Show();
            }
            else
                form.Activate();
        }

        private void Btnnhaphang_ItemClick(object sender, ItemClickEventArgs e)
        {

            Form form = Isactive(typeof(frmBanhang));
            if (form == null)
            {
                frmBanhang banhang = new frmBanhang(Id);
                banhang.MdiParent = this;
                banhang.Show();
            }
            else
                form.Activate();
        }

        private void Btntinhtien_ItemClick(object sender, ItemClickEventArgs e)
        {
          
            Form form = Isactive(typeof(frmThutien));
            if (form == null)
            {
                frmThutien banhang = new frmThutien(Id);
                banhang.MdiParent = this;
                banhang.Show();
            }
            else
                form.Activate();
        }

        private void Btntratien_ItemClick(object sender, ItemClickEventArgs e)
        {

            Form form = Isactive(typeof(frmTratien));
            if (form == null)
            {
                frmTratien banhang = new frmTratien(Id);
                banhang.MdiParent = this;
                banhang.Show();
            }
            else
                form.Activate();
        }

        private void Btnnhasnaxuat_ItemClick(object sender, ItemClickEventArgs e)
        {
        
            Form form = Isactive(typeof(frmQlnhasanxuat));
            if (form == null)
            {
                frmQlnhasanxuat banhang = new frmQlnhasanxuat(Role);
                banhang.MdiParent = this;
                banhang.Show();
            }
            else
                form.Activate();
        }

        private void Btnkho_ItemClick(object sender, ItemClickEventArgs e)
        {
 
            Form form = Isactive(typeof(frmQlkhohang));
            if (form == null)
            {
                frmQlkhohang banhang = new frmQlkhohang(Role);
                banhang.MdiParent = this;
                banhang.Show();
            }
            else
                form.Activate();
        }

        private void FrmTrangchu_Load(object sender, EventArgs e)
        {
            if (Role == 1) {
                btnquanlyuser.Enabled = false;
                
            }
        }
    }
}