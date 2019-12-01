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
    class NhansuBUS
    {
        NhansuDAO nhansuDAO = new NhansuDAO();
        public DataTable loadnhansu(int Idmh)
        {
          
            return nhansuDAO.loadnhansu(Idmh);
        }
        public int Xoanhansu(int Id, GridView grviewsanpham)
        {
            
            return nhansuDAO.Xoanhansu(Id,grviewsanpham);
        }
        public int themsuanhansu(int Id, Nhansu nhansu)
        {
           
            return nhansuDAO.themsuanhansu(Id, nhansu);
        }

        public void Laodcbbedit(ComboBoxEdit comboBoxEdit, string tenbang, string tencot)
        {
             nhansuDAO.Laodcbbedit(comboBoxEdit, tenbang, tencot);
        }
        public Nhansu Laynhansu(int ID)
        {
            return nhansuDAO.Laynhansu(ID);
        }
    }
}
