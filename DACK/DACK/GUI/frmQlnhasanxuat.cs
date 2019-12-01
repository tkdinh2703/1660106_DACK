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
    public partial class frmQlnhasanxuat : DevExpress.XtraEditors.XtraForm
    {
        int Role = 0;
        Datbase db = new Datbase();
        int IDmh=5;
        NhasanxuatBUS nhasanxuatBUS = new NhasanxuatBUS();
        public frmQlnhasanxuat()
        {
            InitializeComponent();
        }
        public frmQlnhasanxuat(int role)
        {
            InitializeComponent();
            Role = role;
        }

        private void FrmQlnhasanxuat_Load(object sender, EventArgs e)
        {
            Loaddata();
            Roleform roleform = phanquyen();
            btnthem.Enabled = roleform.Them;
            btnxoa.Enabled = roleform.Xoa;
            btnsua.Enabled = roleform.Sua;
            btnin.Enabled = roleform.Inan;
            btnhhap.Enabled = roleform.Nhap;
            btnxuat.Enabled = roleform.Xuat;
        }
        private void Loaddata()
        {

            var data = nhasanxuatBUS.loadncc();
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
            var row = nhasanxuatBUS.Xoansx(int.Parse(id.ToString()), gridView1);
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
            Object tenNCC = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "TenNSX");
            Object diaChi = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Quocgia");          
            Object website = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Website");
            Nhasanxuat nhasanxuat = new Nhasanxuat()
            {
                Id = int.Parse(id.ToString()),
                TenNSX = tenNCC.ToString(),
                Quocgia = diaChi.ToString(),
                Website = website.ToString(),

            };
            themsuanhasanxxuat themsuansx = new themsuanhasanxxuat(nhasanxuat);
            themsuansx.Show();
            themsuansx.khicapnhat += Themsuansx_khicapnhat;
        }

        private void Themsuansx_khicapnhat()
        {
            Loaddata();
        }

        private void Btnthem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            themsuanhasanxxuat themsuansx = new themsuanhasanxxuat();
            themsuansx.Show();
            themsuansx.khicapnhat += Themsuansx_khicapnhat;
        }
    
    }
}