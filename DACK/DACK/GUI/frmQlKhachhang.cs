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
    public partial class frmQlKhachhang : DevExpress.XtraEditors.XtraForm
    {
        KhachangBUS khachang = new KhachangBUS();
        public frmQlKhachhang()
        {
            InitializeComponent();
        }
        public void Loadnhansu()
        {

            gridControl1.DataSource = khachang.loadkhachang();
        }

        private void FrmQlKhachhang_Load(object sender, EventArgs e)
        {

        }
    }
}