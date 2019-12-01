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
    public partial class FrmQlnhacungcap : DevExpress.XtraEditors.XtraForm
    {
        Datbase db = new Datbase();
        int Role = 0;
        int IDmh=4;
        NhacungcapBUS nhacungcapBUS = new NhacungcapBUS();
        public FrmQlnhacungcap()
        {
            InitializeComponent();
        }
        public FrmQlnhacungcap(int role)
        {
            InitializeComponent();
            Role = role;
        }


        private void FrmQlnhacungcap_Load(object sender, EventArgs e)
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
            
            var data = nhacungcapBUS.loadncc();
            gridcontrol1.DataSource = data;

        }
        public Roleform phanquyen()
        {
            var role = db.quyentruycap(Role, IDmh);
            return role;
        }

        private void BarButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Object id = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Id");
            var row = nhacungcapBUS.Xoancc(int.Parse(id.ToString()), gridView1);
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
            Object tenNCC = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "TenNCC");
            Object diaChi = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "DiaChi");
            Object Ddienthoai = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "DienThoai");
            Object website = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Website");
            Nhacungcap nhacungcap = new Nhacungcap()
            {
                Id = int.Parse(id.ToString()),
                TenNCC = tenNCC.ToString(),
                DiaChi = diaChi.ToString(),
                DienThoai = long.Parse(Ddienthoai.ToString()),
                Website = website.ToString(),
               
            };
            Themsunhacungcap themsuancc = new Themsunhacungcap(nhacungcap);
            themsuancc.Show();
            themsuancc.khicapnhat += Themsuancc_khicapnhat;
        }

        private void Themsuancc_khicapnhat()
        {
            Loaddata();
        }

        private void Btnthem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Themsunhacungcap themsuancc = new Themsunhacungcap();
            themsuancc.Show();
            themsuancc.khicapnhat += Themsuancc_khicapnhat;
        }
    }
}