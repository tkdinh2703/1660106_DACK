using DACK.DTO;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DACK.DAO
{
    
    public class NhasanxuatDAO
    {
        public Datbase db = new Datbase();
        public DataTable loadnsx()
        {

            string sql = string.Format("Select * from Thuonghieu ");

            var datatable = db.laydulieu(sql);
            return datatable;
        }
        public int Xoansx(int Id, GridView grviewsanpham)
        {
            string sql = string.Format("Delete from Thuonghieu Where Id={0} ", Id);
            string colum = "TenNSX";
            var rs = db.Xoaulieu(sql, grviewsanpham, colum);
            return rs;
        }
        public int themsuansx(int Id, Nhasanxuat nhasanxuat)
        {
            string sql = "";
            if (Id != 0)
            {
                sql = string.Format("Update Thuonghieu Set TenNSX=N'{0}',Quocgia= N'{1}',Website=N'{2}' Where Id='{3}'", nhasanxuat.TenNSX, nhasanxuat.Quocgia, nhasanxuat.Website, Id);
            }
            else
            {
                sql = string.Format("Insert into Thuonghieu(TenNSX,Quocgia,Website) Values(N'{0}',N'{1}','{2}')", nhasanxuat.TenNSX, nhasanxuat.Quocgia, nhasanxuat.Website);
            }
            var rs = db.thesuadulieu(sql);
            return rs;
        }
    }
}
