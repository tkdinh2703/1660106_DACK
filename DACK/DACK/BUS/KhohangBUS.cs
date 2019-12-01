using DACK.DAO;
using DACK.DTO;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DACK.BUS
{
    public class KhohangBUS
    {
        KhohangDAO khohangDAO = new KhohangDAO();
        public DataTable loadnkh()
        {

           
            return khohangDAO.loadnkh();
        }
        public int Xoankh(int Id, GridView grviewsanpham)
        {

            return khohangDAO.Xoankh(Id,grviewsanpham);
        }
        public int themsuankh(int Id, Khohang khohang)
        {
           
            return khohangDAO.themsuankh(Id,khohang);
        }
    }
}
