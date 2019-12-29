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
using DACK.DTO;
using DACK.DAO;
using DevExpress.XtraReports.UI;

namespace DACK.GUI
{
    public partial class frmQlKhachhang : DevExpress.XtraEditors.XtraForm
    {
        Datbase db = new Datbase();
        int Idmh = 7;
        int Role =0;
        KhachangBUS khachangBUS = new KhachangBUS();
        public frmQlKhachhang(int Role)
        {
            InitializeComponent();
            this.Role = Role;
        }
        public void Loadnhansu()
        {

            gridControl1.DataSource = khachangBUS.loadkhachang();
        }
        public Roleform phanquyen()
        {
            var role = db.quyentruycap(Role, Idmh);
            return role;
        }

        private void FrmQlKhachhang_Load(object sender, EventArgs e)
        {
            Loadnhansu();
            Roleform roleform = phanquyen();
            btnthem.Enabled = roleform.Them;
            btnxoa.Enabled = roleform.Xoa;
            btnsua.Enabled = roleform.Sua;
            btnin.Enabled = roleform.Inan;
            btnnhap.Enabled = roleform.Nhap;
            btnxuat.Enabled = roleform.Xuat;
        }

        private void Btnsua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Object id = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Id");
            var row = khachangBUS.Xoanhansu(int.Parse(id.ToString()), gridView1);
            if (row > 0)
            {
                gridView1.DeleteRow(gridView1.FocusedRowHandle);
                MessageBox.Show("Xóa thành công!");
            }
            else
            {
                MessageBox.Show("Xóa Thất bại!");
            }
        }

        private void Btnxoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Object id = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Id");        
            Object ten = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Ten");
            Object tmail = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Email");
            Object ngaysinh = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Ngaysinh");
            Object diachi = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Diachi");           
            Object gioitinh = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Gioitinh");
            Object nganhang = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Nganhang");
            Object sotk = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Sotk");
            Object sodienthoai = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Sodienthoai");

            Khachhang  nhansu = new Khachhang()
            {
                Id = (int)id,                
                Ten = ten.ToString(),
                Email = tmail.ToString(),
                Ngaysinh = ngaysinh.ToString(),
                Diachi = diachi.ToString(),               
                Gioitinh = gioitinh.ToString(),
                Nganhang = nganhang.ToString(),
                Sotk = (long)sotk,
                Sodienthoai = (int)sodienthoai


            };
            Themsuakhachhang themsuakhachhang = new Themsuakhachhang(nhansu);
            themsuakhachhang.Show();
            themsuakhachhang.khicapnhat += Themsuanhansu_khicapnhat;
        }

        private void Themsuanhansu_khicapnhat()
        {
            Loadnhansu();
        }

        private void Btnthem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Themsuakhachhang themsuakhachhang = new Themsuakhachhang();
            themsuakhachhang.Show();
            themsuakhachhang.khicapnhat += Themsuanhansu_khicapnhat;
        }

        private void GridControl1_Click(object sender, EventArgs e)
        {

        }
        BanhangBUS banhangBUS = new BanhangBUS();
        private void Btnin_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Dskhachang dsnguoidung = new Dskhachang();
            List<Khachhang> lstkachchang = banhangBUS.ChonKh();
            dsnguoidung.DataSource = lstkachchang;
            ReportPrintTool report = new ReportPrintTool(dsnguoidung);
            report.ShowPreview();
        }
    }
}