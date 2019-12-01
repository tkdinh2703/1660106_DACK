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
    public partial class themsuanhasanxxuat : DevExpress.XtraEditors.XtraForm
    {
        NhasanxuatBUS nhasanxautBUS = new NhasanxuatBUS();
        int Id = 0;
        public delegate void addsanpham();
        public event addsanpham khicapnhat = null;
        public themsuanhasanxxuat()
        {
            InitializeComponent();
            btnluu.Text = "Thêm nhà sản xuất";
        }
        public themsuanhasanxxuat(Nhasanxuat nhasanxuat)
        {
            InitializeComponent();
            Id = nhasanxuat.Id;
            txtquocgia.Text = nhasanxuat.Quocgia;
            txttebnsx.Text = nhasanxuat.TenNSX;
            txtwebsite.Text = nhasanxuat.Website;
        }

        private void Btnluu_Click(object sender, EventArgs e)
        {
            Nhasanxuat ncc = Laythongtinncc();
            var row = nhasanxautBUS.themsuansx(Id, ncc);

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
        
        
        private Nhasanxuat Laythongtinncc()
        {
            Nhasanxuat ncc = new Nhasanxuat();
            ncc.TenNSX = txttebnsx.Text;
            ncc.Quocgia = txtquocgia.Text;        
            ncc.Website = txtwebsite.Text;          
            return ncc;

        }
    }
}