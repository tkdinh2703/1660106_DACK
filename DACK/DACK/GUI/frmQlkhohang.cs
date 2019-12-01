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

namespace DACK.GUI
{
    public partial class frmQlkhohang : DevExpress.XtraEditors.XtraForm
    {
        Datbase db = new Datbase();
        int Role = 0;
        int IDmh = 6;
        KhohangBUS khohangBUS = new KhohangBUS();
        public frmQlkhohang()
        {
            InitializeComponent();
        }
        public frmQlkhohang(int role)
        {
            InitializeComponent();
            Role = role;
        }

        private void FrmQlkhohang_Load(object sender, EventArgs e)
        {
            Loaddata();
            Roleform roleform = phanquyen();
            btnthem.Enabled = roleform.Them;
            btnxoa.Enabled = roleform.Xoa;
            btnsua.Enabled = roleform.Sua;
            btnin.Enabled = roleform.Inan;
            btnnhap.Enabled = roleform.Nhap;
            btnxuat.Enabled = roleform.Xuat;

        }
        private void Loaddata()
        {

            var data = khohangBUS.loadnkh();
            gridControl1.DataSource = data;

        }
        public Roleform phanquyen()
        {
            var role = db.quyentruycap(Role, IDmh);
            return role;
        }

        private void Btnxoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Object id = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Id");
            var row = khohangBUS.Xoankh(int.Parse(id.ToString()), gridView1);
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

        private void Btnsua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            Object id = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Id");
            Object tenNCC = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Tenkhohang");
            Object diaChi = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Diachikho");
            
            Khohang khohang = new Khohang()
            {
                Id = int.Parse(id.ToString()),
                Tenkhohang = tenNCC.ToString(),
                Diachikho = diaChi.ToString(),               
            };
            themsuakhohang themsuansx = new themsuakhohang(khohang);
            themsuansx.Show();
            themsuansx.khicapnhat += Themsuansx_khicapnhat;
        }

        private void Themsuansx_khicapnhat()
        {
            Loaddata();
        }

        private void Btnthem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            themsuakhohang themsuansx = new themsuakhohang();
            themsuansx.Show();
            themsuansx.khicapnhat += Themsuansx_khicapnhat;
        }
    }
}