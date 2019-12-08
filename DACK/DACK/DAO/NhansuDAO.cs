using DACK.DTO;
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
    public class NhansuDAO
    {
        public Datbase db = new Datbase();
        public DataTable loadnhansu(int IDmh)
        {
            string sql = "";
            if (IDmh != 1)
            {
                sql = string.Format("Select * from Nhansu Where IdQuyen={0} or IdQuyen={1} ", 2, 3);
            }
            else
            { sql = string.Format("Select * from Nhansu Where IdQuyen={0}", IDmh); } //Where Id = { 0 }
            var datatable = db.laydulieu(sql);
            return datatable;
        }
        public int Xoanhansu(int Id, GridView grviewsanpham)
        {
            string sql = string.Format("Delete from Nhansu Where Id={0} ", Id);
            string colum = "TenDangNhap";
            var rs = db.Xoaulieu(sql, grviewsanpham, colum);
            return rs;
        }
        public int themsuanhansu(int Id, Nhansu nhansu)
        {
            string sql = "";
            if (nhansu.MatKhau!="aaaaaaaa" && Id != 0)
            {             

                sql = string.Format("Update Nhansu Set TenDangNhap=N'{0}',MatKhau= N'{1}',Ten=N'{2}',Email='{3}',NgayThamgia='{4}',Diachi=N'{5}',IdQuyen='{6}',Gioitinh=N'{7}',Nganhang=N'{8}',Sotk='{9}',Sodienthoai=N'{10}' Where Id='{11}'", nhansu.TenDangNhap, nhansu.MatKhau, nhansu.Ten, nhansu.Email, nhansu.NgayThamgia, nhansu.Diachi, nhansu.IdQuyen, nhansu.Gioitinh, nhansu.Nganhang, nhansu.Sotk, nhansu.Sodienthoai, Id);
            }else
            if (Id != 0)
            {
                sql = string.Format("Update Nhansu Set TenDangNhap=N'{0}',Ten= N'{1}',Email='{2}',NgayThamgia='{3}',Diachi=N'{4}',IdQuyen='{5}',Gioitinh=N'{6}',Nganhang=N'{7}',Sotk='{8}',Sodienthoai='{9}' Where Id='{10}'", nhansu.TenDangNhap, nhansu.Ten, nhansu.Email, nhansu.NgayThamgia, nhansu.Diachi, nhansu.IdQuyen, nhansu.Gioitinh, nhansu.Nganhang, nhansu.Sotk, nhansu.Sodienthoai, Id);
            }
            else
            {
                sql = string.Format("Insert into Nhansu(TenDangNhap,MatKhau,Ten,Email,NgayThamgia,Diachi,IdQuyen,Gioitinh,Nganhang,Sotk,Sodienthoai) Values(N'{0}',N'{1}',N'{2}','{3}','{4}',N'{5}','{6}',N'{7}',N'{8}','{9}',N'{10}')", nhansu.TenDangNhap, nhansu.MatKhau, nhansu.Ten, nhansu.Email, nhansu.NgayThamgia, nhansu.Diachi, nhansu.IdQuyen, nhansu.Gioitinh, nhansu.Nganhang, nhansu.Sotk, nhansu.Sodienthoai);
            }
            var rs = db.thesuadulieu(sql);
            return rs;
        }

        public void Laodcbbedit(ComboBoxEdit comboBoxEdit, string tenbang, string tencot)
        {
            string sql = string.Format("Select * from {0}", tenbang);
            db.Laodcbb(comboBoxEdit, sql, tencot);
        }


        public Nhansu Laynhansu(int ID)
        {          
            string sql = string.Format("Select * from Nhansu where Id='{0}'", ID);          
            return db.Laynhansu(sql);
        }
    }
}
