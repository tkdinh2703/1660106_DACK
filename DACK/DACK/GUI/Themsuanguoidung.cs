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
using DACK.DTO;
using DACK.BUS;

namespace DACK.GUI
{
    public partial class Themsuanguoidung : Form
    {
        NhansuBUS nhansuBUS = new NhansuBUS();
        int Id = 0;
        int Role = 0;
        int IDmh = 0;
        public delegate void addnhansu();
        public event addnhansu khicapnhat = null;
        public Themsuanguoidung()
        {
            InitializeComponent();
            this.Text = "Đăng ký";
            layoutControlItem16.ContentVisible = false;
            btnluu.Text = "Lưu";
           
                cbbquyenhan.Text = "Người dùng";
                cbbquyenhan.Enabled = false;
            
        }
        public Themsuanguoidung(int Role,int Idmh)
        {
            InitializeComponent();
            this.Role = Role;
            this.IDmh = Idmh;
            layoutControlItem16.ContentVisible = false;
            btnluu.Text = "Thêm";
            if (Idmh == 1)
            {
                this.Text = "Thêm người dùng";
            }
            if (Idmh == 2)
            {
                this.Text = "Thêm nhân sự";
            }
        }
        public Themsuanguoidung(Nhansu nhansu, string matkhau)
        {
            InitializeComponent();
            this.Text = "Cập nhật thông tin";
            btnluu.Text = "Cập nhật";
            Id = nhansu.Id;
            btnluu.Enabled = false;
          
            txttentk.Text = nhansu.TenDangNhap;
            txttentk.Enabled = false;
            txtmatkhau.Text = matkhau;
            txtmatkhau.Enabled = false;
            txtxnmatkhau.Text = matkhau;
            txtxnmatkhau.Enabled = false;
            txtdiachi.Text = nhansu.Diachi;
            txtdiachi.Enabled = false;
            txttennguoidung.Text = nhansu.Ten;
            txttennguoidung.Enabled = false;
            txtemail.Text = nhansu.Email;
            txtemail.Enabled = false;
            txtngaythamhia.Text = nhansu.NgayThamgia;
            txtngaythamhia.Enabled = false;
            txtnganhang.Text = nhansu.Nganhang;
            txtnganhang.Enabled = false;
            txttaikhoan.Text = nhansu.Sotk.ToString();
            txttaikhoan.Enabled = false;
            txtsodeinthoai.Text = nhansu.Sodienthoai.ToString();
            txtsodeinthoai.Enabled = false;
            
            if (nhansu.Gioitinh == "Nam")
            {
                rdonam.Checked = true;
            }
            if (nhansu.Gioitinh == "Nữ")
            {
                rdonu.Checked = true;
            }
            if (nhansu.IdQuyen == 1)
            {
                cbbquyenhan.Text = "Người dùng";
            }
            if (nhansu.IdQuyen == 2)
            {
                cbbquyenhan.Text = "Nhân viên";
            }
            if (nhansu.IdQuyen == 3)
            {
                cbbquyenhan.Text = "Admin";
            }          
            rdonam.Enabled = false;
            rdonu.Enabled = false;
            cbbquyenhan.Enabled = false;
            label1.Enabled = false;

        }
        public Themsuanguoidung(Nhansu nhansu,int Idmh)
        {
            InitializeComponent();
            this.Text = "Cập nhật thông tin";
            Role = 3;
            this.IDmh = Idmh;
            btnluu.Text="Cập nhật";
            layoutControlItem16.ContentVisible = false;
            Id = nhansu.Id;
            txttentk.Text = nhansu.TenDangNhap;
            txtmatkhau.Text = "aaaaaaaa";
            txtxnmatkhau.Text = "aaaaaaaa";
            txtdiachi.Text = nhansu.Diachi;
            txttennguoidung.Text = nhansu.Ten;
            txtemail.Text = nhansu.Email;
            txtngaythamhia.Text = nhansu.NgayThamgia;
            txtnganhang.Text = nhansu.Nganhang;
            txttaikhoan.Text = nhansu.Sotk.ToString();
            txtsodeinthoai.Text = nhansu.Sodienthoai.ToString();
            if (nhansu.IdQuyen == 1)
            {
                cbbquyenhan.Text = "Người dùng";
            }
            if (nhansu.IdQuyen == 2)
            {
                cbbquyenhan.Text = "Nhân viên";
            }
            if (nhansu.IdQuyen == 3)
            {
                cbbquyenhan.Text = "Admin";
            }
            if (nhansu.Gioitinh == "Nam")
            {
                rdonam.Checked = true;
            }
            if (nhansu.Gioitinh == "Nữ")
            {
                rdonu.Checked = true;
            }         


        }

        private void Btnluu_Click(object sender, EventArgs e)
        {
            Nhansu nhansu= laynhansu();
            var row = nhansuBUS.themsuanhansu(Id,nhansu);
            if (row > 0)
            {
                if (Role == 2 ||Role==3)
                {
                    khicapnhat();
                }

                
                if (Id != 0)
                {
                    MessageBox.Show("Cập nhật thành công!");
                }
                else
                {
                    MessageBox.Show("Thêm thành viên thành công!");
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại!");
            }
        }
        public Nhansu laynhansu()
        {
            Nhansu nhansu = new Nhansu();
            nhansu.Id = this.Id;
            int quyen = 0;
            if (cbbquyenhan.Text == "Người dùng")
            {
                quyen = 1;
            }
            if (cbbquyenhan.Text == "Nhân viên")
            {
                quyen = 2;
            }
            if (cbbquyenhan.Text == "Admin")
            {
                quyen = 3;
            }

            nhansu.IdQuyen = quyen;
            nhansu.MatKhau = txtmatkhau.Text;
            nhansu.Nganhang = txtnganhang.Text;
            nhansu.NgayThamgia = txtngaythamhia.Text;
            nhansu.Sodienthoai =int.Parse(txtsodeinthoai.Text);
            nhansu.Sotk = long.Parse(txttaikhoan.Text);
            nhansu.Ten = txttennguoidung.Text;
            nhansu.TenDangNhap = txttentk.Text;
            nhansu.Diachi = txtdiachi.Text;
            nhansu.Email = txtemail.Text;
            if(rdonam.Checked==true)
            {
                nhansu.Gioitinh = "Nam";
            }
            if (rdonu.Checked == true)
            {
                nhansu.Gioitinh = "Nữ";
            }


            return nhansu;
        }

        private void Themsuanhansu_Load(object sender, EventArgs e)
        {
            nhansuBUS.Laodcbbedit(cbbquyenhan, "Quyen", "TenQuyen");
            if (IDmh==1)
            {
                cbbquyenhan.Text = "Người dùng";
                cbbquyenhan.Enabled = false;
            }


        }

        private void Btnthaydoi_Click(object sender, EventArgs e)
        {
            layoutControlItem16.ContentVisible=false;  //.Visibility(btnthaydoi,Visible);
            btnluu.Enabled = true;
            btndong.Enabled = true;
            txttentk.Enabled = true;
            txtmatkhau.Enabled = true;
            txtxnmatkhau.Enabled = true;
            txtdiachi.Enabled = true;
            txttennguoidung.Enabled = true;
            txtemail.Enabled = true;
            txtngaythamhia.Enabled = true;
            txtnganhang.Enabled = true;
            txttaikhoan.Enabled = true;
            txtsodeinthoai.Enabled = true;                    
            rdonam.Enabled = true;
            rdonu.Enabled = true;
            label1.Enabled = true;
            
           // btnthaydoi.Visible = false;
        }

        private void Btndong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}