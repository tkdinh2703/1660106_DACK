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
    public partial class themsuakhohang : DevExpress.XtraEditors.XtraForm
    {
        int Id = 0;
        KhohangBUS khohangBUS = new KhohangBUS();
        public delegate void addsanpham();
        public event addsanpham khicapnhat = null;
        public themsuakhohang()
        {
            InitializeComponent();
            btnluu.Text = "Thêm kho hàng";
        }
        public themsuakhohang(Khohang khohang)
        {
            InitializeComponent();
            Id = khohang.Id;
            txtdiachi.Text = khohang.Diachikho;
            txtkhohang.Text = khohang.Tenkhohang;

        }

        private void Btnluu_Click(object sender, EventArgs e)
        {
            Khohang ncc = Laythongtinncc();
            var row = khohangBUS.themsuankh(Id, ncc);

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
        

        
        
        
        private Khohang Laythongtinncc()
        {
            Khohang ncc = new Khohang();
            ncc.Tenkhohang = txtkhohang.Text;
            ncc.Diachikho = txtdiachi.Text;                         
            return ncc;

        }
    }
}