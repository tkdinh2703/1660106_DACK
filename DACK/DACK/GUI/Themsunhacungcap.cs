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
    public partial class Themsunhacungcap : DevExpress.XtraEditors.XtraForm
    {
        NhacungcapBUS nhacungcapBUS = new NhacungcapBUS();
        int Id = 0;
        public delegate void addsanpham();
        public event addsanpham khicapnhat = null;
        public Themsunhacungcap()
        {
            InitializeComponent();
            btnluu.Text = "Thêm nhà cung cấp";
        }
        public Themsunhacungcap(Nhacungcap nhacungcap)
        {
            InitializeComponent();
            Id = nhacungcap.Id;
            txtdiachincc.Text = nhacungcap.DiaChi;
            txtncc.Text = nhacungcap.TenNCC;
            txtwebsitencc.Text = nhacungcap.Website;
            txtsdtncc.Text = nhacungcap.DienThoai.ToString();
            btnluu.Text = "Cập nhật sản phẩm";
        }

        private void Btnluu_Click(object sender, EventArgs e)
        {
            Nhacungcap ncc= Laythongtinncc();
            var row = nhacungcapBUS.themsuancc(Id, ncc);

            if (row > 0)
            {
                khicapnhat();
                if (Id != 0)
                {
                    MessageBox.Show("Cập nhật thành công!");
                }
                else
                {
                    MessageBox.Show("Thêm sản phẩm thành công!");
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại!");
            }
        }
        private Nhacungcap Laythongtinncc()
        {
            Nhacungcap ncc = new Nhacungcap();
            ncc.TenNCC = txtncc.Text;
            ncc.DiaChi = txtdiachincc.Text.ToString();
            ncc.DienThoai = long.Parse(txtsdtncc.Text);
            ncc.Website = txtwebsitencc.Text;          
            return ncc;

        }
    }
}