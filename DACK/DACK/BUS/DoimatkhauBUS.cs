using DACK.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DACK.BUS
{
    public class DoimatkhauBUS
    {
        DoimatkhauDAO doimatkhau = new DoimatkhauDAO();
        public int luumatkhau(string matkhau, int Id)
        {
            return doimatkhau.luumatkhau(matkhau,Id);
        }
    }
}
