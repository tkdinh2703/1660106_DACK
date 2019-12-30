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
    public class KhohangDAO
    {
        public Datbase db = new Datbase();
        public DataTable loadnkh()
        {

            string sql = string.Format("Select * from Khohang ");

            var datatable = db.laydulieu(sql);
            return datatable;
        }

        public int Xoankh(int Id, GridView grviewsanpham)
        {
            string sql = string.Format("Delete from Khohang Where Id={0} ", Id);
            string colum = "Tenkhohang";
            var rs = db.Xoaulieu(sql, grviewsanpham, colum);
            return rs;
        }
        public int themsuankh(int Id, Khohang khohang)
        {
            string sql = "";
            if (Id != 0)
            {
                sql = string.Format("Update Khohang Set Tenkhohang=N'{0}',Diachikho= N'{1}' Where Id='{2}'", khohang.Tenkhohang, khohang.Diachikho, Id);
            }
            else
            {
                sql = string.Format("Insert into Khohang(Tenkhohang,Diachikho) Values(N'{0}',N'{1}')", khohang.Tenkhohang, khohang.Diachikho);
            }
            var rs = db.thesuadulieu(sql);
            return rs;
        }
       
    }
}
