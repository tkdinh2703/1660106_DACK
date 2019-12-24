using DACK.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DACK.DTO
{
    public class TratienDAO
    {
        Datbase DB = new Datbase();
        public List<Phieunhaphang> Listpheunhaphang(int mancc)
        {
            string sql = string.Format("select * from Phieunhaphang where MaNcc='{0}' ", mancc);
            return DB.Listpheunhaphang(sql);
        }
        
        public int Demthuoctinh()
        {
            string sql = "select count(Id) from Hoadonchi";
            return DB.Demthuoctinh(sql);
        }
        public int SuaTienphieuchi(string Id, long tongtien)
        {
            string sql = string.Format("Update Phieunhaphang Set Tongtien='{0}' Where Maphieuthu='{1}'", tongtien, Id);
            return DB.thesuadulieu(sql);
        }
        public int themhoadonchi(Hoadonthutratien hoadonthutratien)
        {
            string sql = string.Format("Insert into Hoadonchi(Mahoadonchi,MaNCC,Ngaylap,Manv) Values('{0}','{1}','{2}','{3}')", hoadonthutratien.Mahoadonthu, hoadonthutratien.Makh, hoadonthutratien.Ngaylap, hoadonthutratien.Manv);
            return DB.thesuadulieu(sql);
        }
        public int themcthoadonthu(CTphieuthutratien cTphieuthutratien)
        {
            string sql = string.Format("Insert into Chitiethoadonchi(Mahoadonchi,Maphieunhaphang,Tongtienhoadon,Tientra,Tienno) Values('{0}','{1}','{2}','{3}','{4}')", cTphieuthutratien.Mahoadonthu, cTphieuthutratien.Maphieuxuathang, cTphieuthutratien.Tontienhdthu, cTphieuthutratien.Tientra, cTphieuthutratien.Tieno);
            return DB.thesuadulieu(sql);
        }
        public Object IDhoadonchi(string mahoadonchi)
        {
            string sql = string.Format("Select Id from Hoadonchi where Mahoadonchi='{0}' ", mahoadonchi);
            return DB.Laythuoctinh(sql);
        }
    }
}
