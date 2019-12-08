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
using DevExpress.XtraEditors.Controls;

namespace DACK.GUI
{
    public partial class frmMuahang : DevExpress.XtraEditors.XtraForm
    {
        MuahangBUS muahangBUS = new MuahangBUS();
        List<Nhacungcap> lstNCC = new List<Nhacungcap>();
        List<Nhansu> lstnhanvien = new List<Nhansu>();
        List<Khohang> lstkhohang = new List<Khohang>();
        List<Luoinhaphang> lstphieuxh = new List<Luoinhaphang>();
        public frmMuahang()
        {
            InitializeComponent();
        }
        public void Chondoituong()
        {
            lstNCC = muahangBUS.ChonNCC();
            cbbNCC.Properties.DataSource = lstNCC;
            cbbNCC.Properties.DisplayMember = "TenNCC";
            cbbNCC.Properties.ValueMember = "Id";
            cbbNCC.Properties.PopupResizeMode = ResizeMode.FrameResize;
            cbbNCC.Properties.BestFitMode = BestFitMode.BestFitResizePopup;

            lstnhanvien = muahangBUS.Chonnv();
            cbbnhanviennhap.Properties.DataSource = lstnhanvien;
            cbbnhanviennhap.Properties.DisplayMember = "Ten";
            cbbnhanviennhap.Properties.ValueMember = "Id";
            cbbnhanviennhap.Properties.PopupResizeMode = ResizeMode.FrameResize;
            cbbnhanviennhap.Properties.BestFitMode = BestFitMode.BestFitResizePopup;

            lstkhohang = muahangBUS.ChonKhohang();
            cbbkhonhap.Properties.DataSource = lstkhohang;
            cbbkhonhap.Properties.DisplayMember = "Tenkhohang";
            cbbkhonhap.Properties.ValueMember = "Id";
            cbbkhonhap.Properties.PopupResizeMode = ResizeMode.FrameResize;
            cbbkhonhap.Properties.BestFitMode = BestFitMode.BestFitResizePopup;
            lstphieuxh = new List<Luoinhaphang>();
            gridControl1.DataSource = new BindingList<Luoinhaphang>(lstphieuxh);


        }

        private void FrmMuahang_Load(object sender, EventArgs e)
        {
            Chondoituong();
        }

        private void CbbNCC_EditValueChanged(object sender, EventArgs e)
        {
            Nhacungcap nhacungcap = laykhachang();
            txtdiachi.Text = nhacungcap.DiaChi;
            txtdienthoai.Text = nhacungcap.DienThoai.ToString();
            txtMancc.Text = nhacungcap.Id.ToString(); ;
            txttwebsite.Text = nhacungcap.Website;
       
        }

        public Nhacungcap laykhachang()
        {
            Nhacungcap nhacungcap = new Nhacungcap();
            for (int i = 0; i < lstNCC.Count; i++)
            {
                if (lstNCC[i].Id == int.Parse(cbbNCC.EditValue.ToString()))
                {
                    nhacungcap = lstNCC[i];
                }
            }
            return nhacungcap;
        }
    }
}