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

namespace DACK
{
    public partial class frmQlsanpham : DevExpress.XtraEditors.XtraForm
    {
        Datbase db = new Datbase();
        int IDmh = 3;
        int row = 0;
        int Role=0;
        SanphamBUS sanphamBus = new SanphamBUS();
        public frmQlsanpham()
        {
            InitializeComponent();
            grviewsanpham.ShownEditor += grviewsanpham_ShownEditor;
        }
        public frmQlsanpham(int role)
        {
            InitializeComponent();
            grviewsanpham.ShownEditor += grviewsanpham_ShownEditor;
            Role = role;
        }

        private void grviewsanpham_ShownEditor(object sender, EventArgs e)
        {
            grviewsanpham.ActiveEditor.MouseUp += new MouseEventHandler(ActiveEditor_MouseUp);
        }

        private void ActiveEditor_MouseUp(object sender, MouseEventArgs e)
        {

            Object hinhanh = grviewsanpham.GetRowCellValue(grviewsanpham.FocusedRowHandle, "HinhAnh");
            pictureBox1.ImageLocation = hinhanh.ToString();
            row = grviewsanpham.FocusedRowHandle;
        }

        private void Qlsanpham_Load(object sender, EventArgs e)
        {
            Loaddata();
            Roleform roleform = phanquyen();
            btnthem.Enabled = roleform.Them;
            bntxoa.Enabled = roleform.Xoa;
            btnsua.Enabled = roleform.Sua;
            btnin.Enabled = roleform.Inan;
            btnhap.Enabled = roleform.Nhap;
            btnxuat.Enabled = roleform.Xuat;
        }
        

        private void Loaddata()
        {           
           var data = sanphamBus.loadsanpham();
            grvsanpham.DataSource = data;
            Bingding();
            
        }

        public Roleform phanquyen() {
            var role =db.quyentruycap(Role,IDmh);
            return role;
        }
        public void Bingding() {
            Object hinhanh = grviewsanpham.GetRowCellValue(grviewsanpham.FocusedRowHandle, "HinhAnh");
            pictureBox1.ImageLocation = hinhanh.ToString();
        }

        private void Btnsua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
                Object id = grviewsanpham.GetRowCellValue(grviewsanpham.FocusedRowHandle, "Id");
                Object tenHang = grviewsanpham.GetRowCellValue(grviewsanpham.FocusedRowHandle, "TenHang");
                Object loaiHang = grviewsanpham.GetRowCellValue(grviewsanpham.FocusedRowHandle, "LoaiHang");
                Object ngaySanXuat = grviewsanpham.GetRowCellValue(grviewsanpham.FocusedRowHandle, "NgaySanXuat");
                Object xuatXu = grviewsanpham.GetRowCellValue(grviewsanpham.FocusedRowHandle, "XuatXu");
                Object soLuong = grviewsanpham.GetRowCellValue(grviewsanpham.FocusedRowHandle, "SoLuong");
                Object hinhAnh = grviewsanpham.GetRowCellValue(grviewsanpham.FocusedRowHandle, "HinhAnh");
                Object nhaCungCap = grviewsanpham.GetRowCellValue(grviewsanpham.FocusedRowHandle, "NhaCungCap");
                Object giaMua = grviewsanpham.GetRowCellValue(grviewsanpham.FocusedRowHandle, "GiaMua");
                Object giaBanLe = grviewsanpham.GetRowCellValue(grviewsanpham.FocusedRowHandle, "GiaBanLe");
                Object giaBanSi = grviewsanpham.GetRowCellValue(grviewsanpham.FocusedRowHandle, "GiaBanSi");
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
                HinhAnh = hinhAnh.ToString(),
                NhaCungCap = nhaCungCap.ToString(),
                GiaMua = int.Parse(giaMua.ToString()),
                GiaBanLe = int.Parse(giaBanLe.ToString()),
                GiaBanSi = int.Parse(giaBanSi.ToString()),
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
            Bingding();
            row = grviewsanpham.FocusedRowHandle;

        }

       

        //btnFrist
        private void SimpleButton1_Click(object sender, EventArgs e)
        {
            grviewsanpham.FocusedRowHandle = 0;
            row = 0;
            lbvitri.Text = ((row + 1) + "/" + grviewsanpham.RowCount);
            Bingding();
        }

        private void Btnnext_Click(object sender, EventArgs e)
        {
            if (row < grviewsanpham.RowCount)
            {
                if (row != grviewsanpham.RowCount - 1)
                {
                    row++;
                    grviewsanpham.FocusedRowHandle = row;
                    Bingding();
                }
                else
                    MessageBox.Show("Đã hết sản phẩm!");
            }
            lbvitri.Text = ((row + 1) + "/" + grviewsanpham.RowCount);
        }

        private void Btnprev_Click(object sender, EventArgs e)
        {
            if (row >= 0)
            {
                if (row != 0)
                {
                    row--;
                    grviewsanpham.FocusedRowHandle = row;
                    Bingding();
                }
                else
                    MessageBox.Show("First Record");
            }
            lbvitri.Text = ((row + 1) + "/" + grviewsanpham.RowCount);
        }

        private void Btnlast_Click(object sender, EventArgs e)
        {
            grviewsanpham.FocusedRowHandle = grviewsanpham.RowCount - 1;
            row = grviewsanpham.RowCount - 1;
            lbvitri.Text = ((row + 1) + "/" + grviewsanpham.RowCount);
            Bingding();
        }
    }
}