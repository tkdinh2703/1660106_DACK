using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DACK.DAO
{
    public class DoimatkhauDAO
    {
        Datbase db = new Datbase();
        public int luumatkhau(string matkhau,int Id)
        {        
            string sql = string.Format("Update Nhansu Set MatKhau=N'{0}' Where Id='{1}'", matkhau, Id);
             var rs = db.thesuadulieu(sql);
            return rs;
        }
    }
}
