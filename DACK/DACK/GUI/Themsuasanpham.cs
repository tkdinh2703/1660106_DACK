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
using DevExpress.XtraEditors.Controls;
using DACK.GUI;
using DACK.DTO;

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
            this.Text = "Thêm sản phẩm ";
        }
        public Themsuasanpham(int id)
        {
            InitializeComponent();
           
        }
        public Themsuasanpham(Sanpham s)
        {
            InitializeComponent();
            btnLuu.Text = "Cập nhật sản phẩm";
            this.Text = "Cập nhật sản phẩm";
            Id = s.Id;
            txtTenhang.Text = s.TenHang;
            txtngaysx.Text = s.NgaySanXuat;
            txtXuatxu.Text = s.XuatXu;
            txtsoluong.Value = s.SoLuong;
            txtGiabanle.Value = s.GiaBan;
            txtGiabansi.Value = s.VAT;
            txtGiamua.Value = s.GiaMua;
            cbbkhohang.EditValue = laykhohang(s.Khohang);
            cbbLoaihang.Text = s.LoaiHang;
            cbbNhacungcap.EditValue = layncc(s.NhaCungCap);
            cbbthuonghieu.Text = s.Thuonghieu;
            pictureBox1.ImageLocation = s.HinhAnh.ToString();
            srcAnh = s.HinhAnh.ToString();
            
        }
        SanphamDAO sanphamDAO = new SanphamDAO();
        public int laykhohang(string value)
        {

            int id = sanphamDAO.laykhohang(value);
            return id;
        }
        public int layncc(string value)
        {
            int id = sanphamDAO.layncc(value);
            return id;
            
        }

        private void Themsuasanpham_Load(object sender, EventArgs e)
        {
            Loadkhoahang();
            Loadlaoihang(cbbLoaihang);
            Loadnhacungcap();
            Loadthuonghieu(cbbthuonghieu);

            EditorButton editorButton = new EditorButton(ButtonPredefines.Plus);
            cbbkhohang.Properties.Buttons.Add(editorButton);
            editorButton.Click += EditorButton_Click;

            EditorButton editorButton2 = new EditorButton(ButtonPredefines.Plus);
            cbbNhacungcap.Properties.Buttons.Add(editorButton2);
            editorButton2.Click += EditorButton2_Click; 

        }

        private void EditorButton2_Click(object sender, EventArgs e)
        {
            Themsunhacungcap themsunhacungcap = new Themsunhacungcap();
            themsunhacungcap.Show();
            themsunhacungcap.khicapnhat += Themsunhacungcap_khicapnhat;
        }

        private void Themsunhacungcap_khicapnhat()
        {
            List<Nhacungcap> lstNCC = muahangBUS.ChonNCC();
            cbbNhacungcap.Properties.DataSource = lstNCC;
            cbbNhacungcap.Properties.DisplayMember = "TenNCC";
            cbbNhacungcap.Properties.ValueMember = "Id";
            cbbNhacungcap.Properties.PopupResizeMode = ResizeMode.FrameResize;
            cbbNhacungcap.Properties.BestFitMode = BestFitMode.BestFitResizePopup;
            cbbNhacungcap.EditValue = lstNCC[lstNCC.Count - 1].Id;
        }

        private void EditorButton_Click(object sender, EventArgs e)
        {
            themsuakhohang qlkhohang = new themsuakhohang();
            qlkhohang.Show();
            qlkhohang.khicapnhat += Qlkhohang_khicapnhat;
        }

        private void Qlkhohang_khicapnhat()
        {
            List<Khohang> lstkhohang = banhangBUS.ChonKhohang();
            cbbkhohang.Properties.DataSource = lstkhohang;
            cbbkhohang.Properties.DisplayMember = "Tenkhohang";
            cbbkhohang.Properties.ValueMember = "Id";
            cbbkhohang.Properties.PopupResizeMode = ResizeMode.FrameResize;
            cbbkhohang.Properties.BestFitMode = BestFitMode.BestFitResizePopup;
            cbbkhohang.EditValue = lstkhohang[lstkhohang.Count - 1].Id;
        }

        public void Loadlaoihang(ComboBoxEdit comboBoxEdit)
        {
            
            sanphamBus.Laodcbbedit(comboBoxEdit, "Loaihang", "TenLHang");
        }
        BanhangBUS banhangBUS = new BanhangBUS();
        List<Khohang> lstkhohang;
        public void Loadkhoahang() {


            lstkhohang = banhangBUS.ChonKhohang();
            cbbkhohang.Properties.DataSource = lstkhohang;
            cbbkhohang.Properties.DisplayMember = "Tenkhohang";
            cbbkhohang.Properties.ValueMember = "Id";
            cbbkhohang.Properties.PopupResizeMode = ResizeMode.FrameResize;
            cbbkhohang.Properties.BestFitMode = BestFitMode.BestFitResizePopup;
        }

        public void Loadthuonghieu(ComboBoxEdit comboBoxEdit)
        {          
           
            sanphamBus.Laodcbbedit(comboBoxEdit, "Thuonghieu", "TenNSX");
        }
        List<Nhacungcap> lstNCC;
        MuahangBUS muahangBUS = new MuahangBUS();
        public void Loadnhacungcap()
        {
            lstNCC = muahangBUS.ChonNCC();
            cbbNhacungcap.Properties.DataSource = lstNCC;
            cbbNhacungcap.Properties.DisplayMember = "TenNCC";
            cbbNhacungcap.Properties.ValueMember = "Id";
            cbbNhacungcap.Properties.PopupResizeMode = ResizeMode.FrameResize;
            cbbNhacungcap.Properties.BestFitMode = BestFitMode.BestFitResizePopup;
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
            sanpham.GiaBan = (int)txtGiabanle.Value;
            sanpham.VAT = (int)txtGiabansi.Value;
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