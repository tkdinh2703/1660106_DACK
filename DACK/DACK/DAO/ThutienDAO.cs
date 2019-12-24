using DACK.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DACK.DAO
{
    public class ThutienDAO
    {
        Datbase DB = new Datbase();
        public List<Phieuxuathang> Listpheuxuathang(int makh)
        {
            string sql = string.Format("select * from Phieuxuathang where Makh='{0}' ", makh);
            return DB.Listpheuxuathang( sql);
        }
        public long Tongtienphieuthuthu(int Maphieuthu)
        {
            string sql = string.Format("select * from Chitietphieuxuathang where Maphieuxuathang='{0}' ", Maphieuthu);
            return DB.Tongtienphieuthuthu(sql);
        }
        public int Demthuoctinh()
        {
            string sql = "select count(Id) from Hoadonthu";
            return DB.Demthuoctinh(sql);
        }
        public int SuaTienphieuthu(string Id,long tongtien)
        {
            string sql = string.Format("Update Phieuxuathang Set Tongtien='{0}' Where Madonhang='{1}'", tongtien, Id);
            return DB.thesuadulieu(sql);
        }
        public int themhoadonthu(Hoadonthutratien hoadonthutratien)
        {
            string sql = string.Format("Insert into Hoadonthu(Makh,Mahoadonthu,Ngaylap,Manv) Values('{0}','{1}','{2}','{3}')", hoadonthutratien.Makh, hoadonthutratien.Mahoadonthu, hoadonthutratien.Ngaylap,hoadonthutratien.Manv);
            return DB.thesuadulieu(sql);
        }
        public int themcthoadonthu(CTphieuthutratien cTphieuthutratien)
        {
            string sql = string.Format("Insert into Chitiethoadonthu(Mahoadonthu,Maphieuxuathang,Tontienhdthu,Tientra,Tieno) Values('{0}','{1}','{2}','{3}','{4}')", cTphieuthutratien.Mahoadonthu, cTphieuthutratien.Maphieuxuathang, cTphieuthutratien.Tontienhdthu, cTphieuthutratien.Tientra, cTphieuthutratien.Tieno);
            return DB.thesuadulieu(sql);
        }
        public Object IDhoadonthu(string mahoadonthu)
        {
            string sql = string.Format("Select Id from Hoadonthu where Mahoadonthu='{0}' ", mahoadonthu);
            return DB.Laythuoctinh(sql);
        }
    }
}
