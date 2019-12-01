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
using System.Data.SqlClient;
using System.IO;
using System.Drawing.Imaging;
using DACK.DAO;
using DACK.BUS;

namespace DACK
{
    public partial class Themsuasanpham : DevExpress.XtraEditors.XtraForm
    {
        SanphamBUS sanphamBus = new SanphamBUS();
        
        string srcAnh = "";
        int Id=0;
        public delegate void addsanpham();
        public event addsanpham khicapnhat=null;
        public Themsuasanpham()
        {
            InitializeComponent();
            btnLuu.Text = "Thêm sản phẩm";
        }
        public Themsuasanpham(int id)
        {
            InitializeComponent();
           
        }
        public Themsuasanpham(Sanpham s)
        {
            InitializeComponent();
            btnLuu.Text = "Cập nhật sản phẩm";
            Id = s.Id;
            txtTenhang.Text = s.TenHang;
            txtngaysx.Text = s.NgaySanXuat;
            txtXuatxu.Text = s.XuatXu;
            txtsoluong.Value = s.SoLuong;
            txtGiabanle.Value = s.GiaBanLe;
            txtGiabansi.Value = s.GiaBanSi;
            txtGiamua.Value = s.GiaMua;
            cbbkhohang.Text = s.Khohang;
            cbbLoaihang.Text = s.LoaiHang;
            cbbNhacungcap.Text = s.NhaCungCap;
            cbbthuonghieu.Text = s.Thuonghieu;
            pictureBox1.ImageLocation = s.HinhAnh;
            srcAnh = s.HinhAnh;
            
        }

        private void Themsuasanpham_Load(object sender, EventArgs e)
        {
            Loadkhoahang(cbbkhohang);
            Loadlaoihang(cbbLoaihang);
            Loadnhacungcap(cbbNhacungcap);
            Loadthuonghieu(cbbthuonghieu);
            cbbkhohang.Properties.Buttons.Add(new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.OK) );
        }
        public void Loadlaoihang(ComboBoxEdit comboBoxEdit)
        {
            
            sanphamBus.Laodcbbedit(comboBoxEdit, "Loaihang", "TenLHang");
        }
        public void Loadkhoahang(ComboBoxEdit comboBoxEdit) {

            
            sanphamBus.Laodcbbedit(comboBoxEdit, "Khohang", "Tenkhohang");
        }

        public void Loadthuonghieu(ComboBoxEdit comboBoxEdit)
        {          
           
            sanphamBus.Laodcbbedit(comboBoxEdit, "Thuonghieu", "TenNSX");
        }

        public void Loadnhacungcap(ComboBoxEdit comboBoxEdit)
        {   
            sanphamBus.Laodcbbedit(comboBoxEdit, "Nhacungcap", "TenNCC");
        }


        private void PictureBox1_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = fileDialog.Filter = "PNG files(*.png)|*.png|All files(*.*)|*.*";
            fileDialog.FilterIndex = 1;
            fileDialog.RestoreDirectory = true;
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = fileDialog.FileName;
            }
            srcAnh = fileDialog.FileName;
        }

        private void BtnLuu_Click(object sender, EventArgs e)
        {
            Sanpham sanpham = Laythongtinsp();
           
            var row = sanphamBus.themsuasanpham(Id,sanpham);
            if (row > 0)
            {
                khicapnhat();
                if (Id != 0)
                {
                    MessageBox.Show("Cập nhật thành công!");
                }
                else {
                    MessageBox.Show("Thêm sản phẩm thành công!");
                }
                this.Close();
            }
            else {
                MessageBox.Show("Cập nhật thất bại!");
            }
            
        }
        private Sanpham Laythongtinsp()
        {
            Sanpham sanpham = new Sanpham();

            sanpham.TenHang = txtTenhang.Text;        
            sanpham.LoaiHang = cbbLoaihang.Text.ToString();
            sanpham.NgaySanXuat = txtngaysx.Text;
            sanpham.XuatXu = txtXuatxu.Text;
            sanpham.SoLuong = (int)txtsoluong.Value;
            sanpham.HinhAnh = srcAnh;
            sanpham.NhaCungCap = cbbNhacungcap.Text;
            sanpham.GiaMua = (int)txtGiamua.Value;
            sanpham.GiaBanLe = (int)txtGiabanle.Value;
            sanpham.GiaBanSi = (int)txtGiabansi.Value;
            sanpham.Khohang = cbbkhohang.Text;
            sanpham.Thuonghieu = cbbthuonghieu.Text;
            return sanpham;

        }
        private byte[] anh()
        {
            FileStream fs;
            fs = new FileStream(srcAnh, FileMode.Open, FileAccess.Read);
            byte[] picbyte = new byte[fs.Length];
            fs.Read(picbyte, 0, System.Convert.ToInt32(fs.Length));
            fs.Close();
            return picbyte;
        }
      
        private void Btnhonhanh_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            //fileDialog.Filter = fileDialog.Filter = "PNG files(*.png)|*.png|All files(*.*)|*.*";
            //fileDialog.FilterIndex = 1;
            //fileDialog.RestoreDirectory = true;
            //if (fileDialog.ShowDialog() == DialogResult.OK)
            //{
            //    pictureBox1.ImageLocation = fileDialog.FileName;
            //}
            //srcAnh = fileDialog.FileName;
            fileDialog.ShowDialog();
            string file = fileDialog.FileName;
            srcAnh = fileDialog.FileName;         
            Image image = Image.FromFile(file);
            pictureBox1.Image = image;


        }

        private void Btndong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}