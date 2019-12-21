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
using System.Data.SqlClient;
using DACK.DAO;
using DACK.BUS;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.Controls;

namespace DACK
{
    public partial class frmQlsanpham : DevExpress.XtraEditors.XtraForm
    {
        Datbase db = new Datbase();
        int IDmh = 3;
        int row = 0;
        int Role=0;
        List<Sanpham> sanphams;
        SanphamBUS sanphamBus = new SanphamBUS();
        public frmQlsanpham()
        {
            InitializeComponent();
            
        }
        public frmQlsanpham(int role)
        {
            InitializeComponent();
            
            Role = role;
        }

        private void Qlsanpham_Load(object sender, EventArgs e)
        {
            //Loaddata();
            //Roleform roleform = phanquyen();
            //btnthem.Enabled = roleform.Them;
            //bntxoa.Enabled = roleform.Xoa;
            //btnsua.Enabled = roleform.Sua;
            //btnin.Enabled = roleform.Inan;
            //btnhap.Enabled = roleform.Nhap;
            //btnxuat.Enabled = roleform.Xuat;
            //grviewsanpham.RowHeight = 100;
            sanphams = sanphamBus.LIstsanpham();

            grvsanpham.DataSource = sanphams;// new BindingList<Sanpham>(sanphams); ;
           
            
        }
        

        private void Loaddata()
        {           
           var data = sanphamBus.loadsanpham();
            grvsanpham.DataSource = data;
          
            
        }

        public Roleform phanquyen() {
            var role =db.quyentruycap(Role,IDmh);
            return role;
        }
       
        public string Laylocation(int id)
        {
            string Location = sanphamBus.Location(id);
            return Location;
        }
        private void Btnsua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
                Object id = grviewsanpham.GetRowCellValue(grviewsanpham.FocusedRowHandle, "Id");
                Object tenHang = grviewsanpham.GetRowCellValue(grviewsanpham.FocusedRowHandle, "TenHang");
                Object loaiHang = grviewsanpham.GetRowCellValue(grviewsanpham.FocusedRowHandle, "LoaiHang");
                Object ngaySanXuat = grviewsanpham.GetRowCellValue(grviewsanpham.FocusedRowHandle, "NgaySanXuat");
                Object xuatXu = grviewsanpham.GetRowCellValue(grviewsanpham.FocusedRowHandle, "XuatXu");
                Object soLuong = grviewsanpham.GetRowCellValue(grviewsanpham.FocusedRowHandle, "SoLuong");
                Object hinhAnh = Laylocation((int)id);
                Object nhaCungCap = grviewsanpham.GetRowCellValue(grviewsanpham.FocusedRowHandle, "NhaCungCap");
                Object giaMua = grviewsanpham.GetRowCellValue(grviewsanpham.FocusedRowHandle, "GiaMua");
                Object giaBanLe = grviewsanpham.GetRowCellValue(grviewsanpham.FocusedRowHandle, "GiaBan");
                Object giaBanSi = grviewsanpham.GetRowCellValue(grviewsanpham.FocusedRowHandle, "VAT");
                Object khohang = grviewsanpham.GetRowCellValue(grviewsanpham.FocusedRowHandle, "Khohang");
                Object thuonghieu = grviewsanpham.GetRowCellValue(grviewsanpham.FocusedRowHandle, "Thuonghieu");
            Sanpham sanpham = new Sanpham()
            {
                Id = int.Parse(id.ToString()),
                TenHang = tenHang.ToString(),
                LoaiHang = loaiHang.ToString(),
                NgaySanXuat = ngaySanXuat.ToString(),
                XuatXu = xuatXu.ToString(),
                SoLuong = int.Parse(soLuong.ToString()),
                HinhAnh = hinhAnh,
                NhaCungCap = nhaCungCap.ToString(),
                GiaMua = long.Parse(giaMua.ToString()),
                GiaBan = long.Parse(giaBanLe.ToString()),
                VAT = int.Parse(giaBanSi.ToString()),
                Khohang = khohang.ToString(),
                Thuonghieu = thuonghieu.ToString()

                };
                Themsuasanpham themsuasanpham = new Themsuasanpham(sanpham);
                themsuasanpham.Show();
                themsuasanpham.khicapnhat += Themsuasanpham_khicapnhat;
            
        }

        private void Themsuasanpham_khicapnhat()
        {

            Loaddata();
        }

        private void Bntxoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {          
                Object id = grviewsanpham.GetRowCellValue(grviewsanpham.FocusedRowHandle, "Id");              
                var row = sanphamBus.Xoasanpham(int.Parse(id.ToString()), grviewsanpham);
                if (row > 0)
                {
                    grviewsanpham.DeleteRow(grviewsanpham.FocusedRowHandle);
                    MessageBox.Show("Xóa thành công!");
                }
                else
                {
                    MessageBox.Show("Xóa Thất bại!");
                }
            
        }

        private void Btnthem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
            Themsuasanpham themsuasanpham = new Themsuasanpham();
            themsuasanpham.Show();
            themsuasanpham.khicapnhat += Themsuasanpham_khicapnhat;
        }

        private void Grvsanpham_EmbeddedNavigator_MouseClick(object sender, MouseEventArgs e)
        {
           
        }

        

        private void Grviewsanpham_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
           
            
            
        }

        private void Grviewsanpham_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            row = grviewsanpham.FocusedRowHandle;
           
            row = grviewsanpham.FocusedRowHandle;

        }


        private void Grviewsanpham_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            //if (e.Column.FieldName == "HinhAnh")
            //{
            //    e.DefaultDraw();

            //    e.Cache.DrawImage(Image.FromFile(sanphams[e.RowHandle].HinhAnh.ToString()), e.Bounds.Location);

            //}
        }
    }
}