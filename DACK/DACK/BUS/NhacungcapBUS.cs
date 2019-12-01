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
    public class NhacungcapBUS
    {
        NhacungcapDAO nhacungcapDAO = new NhacungcapDAO();
        public DataTable loadncc()
        {        
            return nhacungcapDAO.loadncc();
        }
        public int Xoancc(int Id, GridView grviewsanpham)
        {
          
            return nhacungcapDAO.Xoancc(Id,grviewsanpham);
        }
        public int themsuancc(int Id, Nhacungcap Nhacungcap)
        {
            
            return nhacungcapDAO.themsuancc(Id, Nhacungcap);
        }
    }
}
