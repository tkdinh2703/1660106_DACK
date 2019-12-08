using DACK.DAO;
using DACK.DTO;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DACK.BUS
{
    public class KhachangBUS
    {
        public KhachhangDAO db = new KhachhangDAO();
        public DataTable loadkhachang()
        {
        
            return db.loadkhachang();
        }
        public int Xoanhansu(int Id, GridView grviewsanpham)
        {
         
            return db.Xoanhansu(Id, grviewsanpham);
        }
        public int themsuanhansu(int Id, Khachhang nhansu)
        {
          
            return db.themsuanhansu(Id,nhansu);
        }

        //public void Laodcbbedit(ComboBoxEdit comboBoxEdit, string tenbang, string tencot)
        //{
        //    string sql = string.Format("Select * from {0}", tenbang);
        //    db.Laodcbb(comboBoxEdit, sql, tencot);
        //}


        //public Nhansu Laynhansu(int ID)
        //{
        //    string sql = string.Format("Select * from Nhansu where Id='{0}'", ID);
        //    return db.Laynhansu(sql);
        //}
    }
}
