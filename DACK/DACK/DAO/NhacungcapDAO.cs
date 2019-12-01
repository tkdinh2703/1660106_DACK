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
    class NhacungcapDAO
    {
        public Datbase db = new Datbase();
        public DataTable loadncc()
        {
            
               string sql = string.Format("Select * from Nhacungcap ");
          
            var datatable = db.laydulieu(sql);
            return datatable;
        }
        public int Xoancc(int Id, GridView grviewsanpham)
        {
            string sql = string.Format("Delete from Nhacungcap Where Id={0} ", Id);
            string colum = "TenNCC";
            var rs = db.Xoaulieu(sql, grviewsanpham, colum);
            return rs;
        }
        public int themsuancc(int Id, Nhacungcap Nhacungcap)
        {
            string sql = "";                      
            if (Id != 0)
            {
                sql = string.Format("Update Nhacungcap Set TenNCC=N'{0}',DiaChi= N'{1}',DienThoai='{2}',Website='{3}' Where Id='{4}'", Nhacungcap.TenNCC, Nhacungcap.DiaChi, Nhacungcap.DienThoai, Nhacungcap.Website, Id);
            }
            else
            {
                sql = string.Format("Insert into Nhacungcap(TenNCC,DiaChi,DienThoai,Website) Values(N'{0}',N'{1}','{2}','N{3}')", Nhacungcap.TenNCC, Nhacungcap.DiaChi, Nhacungcap.DienThoai, Nhacungcap.Website);
            }
            var rs = db.thesuadulieu(sql);
            return rs;
        }
    }
}
