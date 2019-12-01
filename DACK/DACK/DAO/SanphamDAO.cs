using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DACK.DAO
{
    public class SanphamDAO
    {
        public Datbase db = new Datbase();
        public DataTable loadsanpham()
        {
            string sql = String.Format("Select * from Sanphams ");
            var datatable = db.laydulieu(sql);
            return datatable;
        }
        public int Xoasanpham(int Id, GridView grviewsanpham)
        {
            string sql = string.Format("Delete from Sanphams Where Id={0} ", Id);
            string colum = "TenHang";
            var rs = db.Xoaulieu(sql,grviewsanpham,colum);
            return rs;
        }
        public int themsuasanpham(int Id,Sanpham sanpham)
        {
            string sql = "";
            if (Id != 0)
            {
                sql = string.Format("Update Sanphams Set TenHang=N'{0}',LoaiHang= N'{1}',NgaySanXuat='{2}',XuatXu=N'{3}',SoLuong='{4}',HinhAnh='{5}',NhaCungCap=N'{6}',GiaMua='{7}',GiaBanLe='{8}',GiaBanSi='{9}',Khohang=N'{10}',Thuonghieu=N'{11}' Where Id='{12}' ", sanpham.TenHang, sanpham.LoaiHang, sanpham.NgaySanXuat, sanpham.XuatXu, sanpham.SoLuong, sanpham.HinhAnh, sanpham.NhaCungCap, sanpham.GiaMua, sanpham.GiaBanLe, sanpham.GiaBanSi, sanpham.Khohang, sanpham.Thuonghieu,Id);
            }
            else
            {
                sql = string.Format("Insert into Sanphams(TenHang,LoaiHang,NgaySanXuat,XuatXu,SoLuong,HinhAnh,NhaCungCap,GiaMua,GiaBanLe,GiaBanSi,Khohang,Thuonghieu) Values('{0}',N'{1}',N'{2}',N'{3}','{4}','{5}',N'{6}','{7}','{8}','{9}',N'{10}',N'{11}')", sanpham.TenHang, sanpham.LoaiHang, sanpham.NgaySanXuat, sanpham.XuatXu, sanpham.SoLuong, sanpham.HinhAnh, sanpham.NhaCungCap, sanpham.GiaMua, sanpham.GiaBanLe, sanpham.GiaBanSi, sanpham.Khohang, sanpham.Thuonghieu);
            }
            var rs = db.thesuadulieu(sql);
            return rs;
        }

        public void Laodcbbedit(ComboBoxEdit comboBoxEdit,string tenbang,  string tencot)
        {
            string sql = string.Format("Select * from {0}", tenbang);
            db.Laodcbb(comboBoxEdit,sql,tencot);
        }
    }
}
