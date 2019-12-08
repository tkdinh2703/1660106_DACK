using DACK.DAO;
using DACK.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DACK.BUS
{
    public class MuahangBUS
    {
        MuahangDAO db = new MuahangDAO();
        public List<Nhacungcap> ChonNCC()
        {
            return db.ChonNCC();
        }
        public List<Nhansu> Chonnv()
        {
            
            return db.Chonnv();
        }
        public List<Khohang> ChonKhohang()
        {         
            return db.ChonKhohang();
        }
    }
}
