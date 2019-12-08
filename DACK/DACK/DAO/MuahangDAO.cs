using DACK.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DACK.DAO
{
    public class MuahangDAO
    {
        Datbase db = new Datbase();
        public List<Nhacungcap> ChonNCC()
        {
            string sql = "select * from Nhacungcap";
            return db.ChonNCC( sql);
        }
        public List<Nhansu> Chonnv()
        {
            string sql = string.Format("Select * from Nhansu where IdQuyen= {0}", 3);
            return db.Chonnv(sql);
        }
        public List<Khohang> ChonKhohang()
        {

            string sql = string.Format("Select * from Khohang");

            return db.ChonKhohang(sql);
        }
    }
}
