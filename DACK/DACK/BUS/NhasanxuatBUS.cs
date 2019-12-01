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
    public class NhasanxuatBUS
    {
        NhasanxuatDAO nhacungcapDAO = new NhasanxuatDAO();
        public DataTable loadncc()
        {

           
            return nhacungcapDAO.loadnsx();
        }
        public int Xoansx(int Id, GridView grviewsanpham)
        {
            
            return nhacungcapDAO.Xoansx( Id,  grviewsanpham);
        }
        public int themsuansx(int Id, Nhasanxuat nhasanxuat)
        {
           
             
            return nhacungcapDAO.themsuansx(Id,nhasanxuat); 
        }
    }
}
