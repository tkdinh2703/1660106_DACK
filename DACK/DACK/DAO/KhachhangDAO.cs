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
    public class KhachhangDAO
    {
        public Datbase db = new Datbase();
        public DataTable loadkhachang()
        {
          
             string sql = string.Format("Select * from DSKhachhang");
            
            var datatable = db.laydulieu(sql);
            return datatable;
        }
        public int Xoanhansu(int Id, GridView grviewsanpham)
        {
            string sql = string.Format("Delete from DSKhachhang Where Id={0} ", Id);
            string colum = "Ten";
            var rs = db.Xoaulieu(sql, grviewsanpham, colum);
            return rs;
        }
        public int themsuanhansu(int Id, Khachhang nhansu)
        {
            string sql = "";           
            if (Id != 0)
            {
                sql = string.Format("Update DSKhachhang Set Ten= N'{0}',Email='{1}',Ngaysinh='{2}',Diachi=N'{3}',Gioitinh=N'{4}',Nganhang=N'{5}',Sotk='{6}',Sodienthoai='{7}' Where Id='{8}'", nhansu.Ten, nhansu.Email, nhansu.Ngaysinh, nhansu.Diachi, nhansu.Gioitinh, nhansu.Nganhang, nhansu.Sotk, nhansu.Sodienthoai, Id);
            }
            else
            {
                sql = string.Format("Insert into DSKhachhang(Ten,Email,Ngaysinh,Diachi,Gioitinh,Nganhang,Sotk,Sodienthoai) Values(N'{0}',N'{1}',N'{2}','{3}','{4}',N'{5}','{6}',N'{7}')", nhansu.Ten, nhansu.Email, nhansu.Ngaysinh, nhansu.Diachi, nhansu.Gioitinh, nhansu.Nganhang, nhansu.Sotk, nhansu.Sodienthoai);
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
