using DACK.DAO;
using DACK.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DACK.BUS
{
    public class ThutienBUS
    {
        ThutienDAO DB = new ThutienDAO();
        public List<Phieuxuathang> Listpheuxuathang(int makh)
        {
           
            return DB.Listpheuxuathang(makh);
        }
        public long Tongtienphieuthuthu(int Maphieuthu)
        {
            
            return DB.Tongtienphieuthuthu(Maphieuthu);
        }
        public int Demthuoctinh()
        {
            
            return DB.Demthuoctinh();
        }
        public int SuaTienphieuthu(string Id, long tongtien)
        {
           
            return DB.SuaTienphieuthu(Id,tongtien);
        }
       
        public int themhoadonthu(Hoadonthutratien hoadonthutratien)
        {
            
            return DB.themhoadonthu(hoadonthutratien);
        }
        public int themcthoadonthu(CTphieuthutratien luoithutratien)
        {
            
            return DB.themcthoadonthu(luoithutratien);
        }

        public Object IDhoadonthu(string mahoadonthu)
        {

            return DB.IDhoadonthu( mahoadonthu);
        }
    }
}
