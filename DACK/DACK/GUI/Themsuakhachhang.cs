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
    public partial class Themsuakhachhang : DevExpress.XtraEditors.XtraForm
    {
        int Id = 0;
        KhachangBUS khachangBUS = new KhachangBUS();
        public delegate void addnhansu();
        public event addnhansu khicapnhat = null;
        public Themsuakhachhang()
        {
            InitializeComponent();
            btnluu.Text = "Thêm";
        }
        public Themsuakhachhang(Khachhang khachhang )
        {
            InitializeComponent();
            Id = khachhang.Id;
            txtdiachi.Text = khachhang.Diachi;
            txtemail.Text = khachhang.Email;
            txtnganhang.Text = khachhang.Nganhang;
            txtsodienthoai.Text = khachhang.Sodienthoai.ToString();
            txtsotaikhoan.Text = khachhang.Sodienthoai.ToString();
            txttenkh.Text = khachhang.Ten;
            datetimeBD.Text = khachhang.Ngaysinh;
            btnluu.Text = "Cập nhật";
            if (khachhang.Gioitinh == "Nam")
            {
                rdonam.Checked = true;
            }
            else
            {
                rdonu.Checked = false;
            }
        }

        private void Btnluu_Click(object sender, EventArgs e)
        {
            Khachhang khachhang = laykh();
            var row = khachangBUS.themsuanhansu(Id, khachhang);
            if (row > 0)
            {              
                  khicapnhat();               
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
        public Khachhang laykh()
        {
            Khachhang khachhang = new Khachhang();
            khachhang.Ten = txttenkh.Text;
            khachhang.Email = txtemail.Text;
            khachhang.Diachi = txtdiachi.Text;
            khachhang.Nganhang = txtnganhang.Text;
            khachhang.Sotk = long.Parse(txtsotaikhoan.Text);
            khachhang.Sodienthoai = long.Parse(txtsodienthoai.Text);
            khachhang.Ngaysinh = datetimeBD.Text;
            if (rdonam.Checked == true)
            {
                khachhang.Gioitinh = "Nam";
            }
            else if (rdonu.Checked == true)
            {
                khachhang.Gioitinh = "Nữ";
            }
            return khachhang;
        }
    }
}