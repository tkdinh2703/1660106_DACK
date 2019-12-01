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
using DACK.BUS;

namespace DACK.GUI
{
    public partial class frmDoimatkhau : DevExpress.XtraEditors.XtraForm
    {
        DoimatkhauBUS doimatkhau = new DoimatkhauBUS();
        int Id;
        string passwork;
        public delegate void addsanpham();
        public event addsanpham khicapnhat = null;
        public frmDoimatkhau()
        {
            InitializeComponent();
        }
        public frmDoimatkhau(int ID, string passwork)
        {
            InitializeComponent();
            this.Id = ID;
            this.passwork = passwork;

        }

        private void Txtmatkhaumoi_EditValueChanged(object sender, EventArgs e)
        {
           
        }

        private void Txtconfigmk_EditValueChanged(object sender, EventArgs e)
        {
            
        }

        private void Btnluu_Click(object sender, EventArgs e)
        {
            if (txtmatkhaumoi.Text != txtconfigmk.Text)
            {
                MessageBox.Show("Mật khẩu mới và mật khẩu xác nhận phải giống nhau!");
            }
            else
            {
                var rs =doimatkhau.luumatkhau(txtmatkhaumoi.Text,Id);
                if (rs > 0)
                {
                    MessageBox.Show("Đổi mật khẩu thành công!");
                    this.Close();
                    khicapnhat();
                }

            }

        }

        private void Txtmatkhaumoi_Click(object sender, EventArgs e)
        {
            if (txtmkcu.Text != passwork)
            {
                MessageBox.Show("Mật khẩu cũ không đúng");
                txtmkcu.Focus();
            }
        }

        private void Txtconfigmk_Click(object sender, EventArgs e)
        {
            if (txtmkcu.Text != passwork)
            {
                MessageBox.Show("Mật khẩu cũ không đúng");
                txtmkcu.Focus();
            }
        }
    }
}