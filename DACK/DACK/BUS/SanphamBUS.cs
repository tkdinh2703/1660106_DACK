using DACK.DAO;
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
    class SanphamBUS
    {
        SanphamDAO sanphamDAO = new SanphamDAO();
        public DataTable loadsanpham()
        {
            return sanphamDAO.loadsanpham();

        }
        public int Xoasanpham(int Id, GridView grviewsanpham)
        {

            return sanphamDAO.Xoasanpham(Id, grviewsanpham);
        }
        public int themsuasanpham(int Id, Sanpham sanpham)
        {
           
            return sanphamDAO.themsuasanpham(Id,sanpham);
        }

        public void Laodcbbedit(ComboBoxEdit comboBoxEdit, string tenbang, string tencot)
        {
            sanphamDAO.Laodcbbedit(comboBoxEdit,tenbang,tencot);
        }
        public List<Sanpham> LIstsanpham()
        {
            return sanphamDAO.LIstsanpham();
        }
        public string Location(int Id)
        {
            
            return sanphamDAO.Location(Id).ToString();
        }
    }
}
