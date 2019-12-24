using DACK.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DACK.BUS
{
    public class TratienBUS
    {
        TratienDAO DB = new TratienDAO();
        public List<Phieunhaphang> Listpheunhaphang(int mancc)
        {
           
            return DB.Listpheunhaphang(mancc);
        }

        public int Demthuoctinh()
        {
            
            return DB.Demthuoctinh();
        }
        public int SuaTienphieuchi(string Id, long tongtien)
        {
            return DB.SuaTienphieuchi(Id,tongtien);
        }
        public int themhoadonchi(Hoadonthutratien hoadonthutratien)
        {
            return DB.themhoadonchi(hoadonthutratien);
        }
        public int themcthoadonthu(CTphieuthutratien cTphieuthutratien)
        {
            return DB.themcthoadonthu(cTphieuthutratien);
        }
        public Object IDhoadonchi(string mahoadonchi)
        {
             return DB.IDhoadonchi(mahoadonchi);
        }
    }
}
