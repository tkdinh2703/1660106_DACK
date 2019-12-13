using DACK.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DACK.DAO
{
    public class BanhangDAO
    {
        Datbase db = new Datbase();
        public List<Khachhang> ChonKh()
        {
            

            string sql = string.Format("Select * from DSKhachhang");
            
            return db.ChonKh(sql);
        }
        public List<Nhansu> Chonnv()
        {
            string sql = string.Format("Select * from Nhansu where IdQuyen= {0} or IdQuyen = {1}", 2,3);
            return db.Chonnv(sql);
        }
        public Nhansu laynhansu(int id)
        {
            string sql =  string.Format("Select * from Nhansu where Id= {0}", id); 
            return db.Laynhansu(sql);
        }
        public List<Khohang> ChonKhohang()
        {
                    
            string sql = string.Format("Select * from Khohang"); 
           
            return db.ChonKhohang(sql);
        }

        public int Insertphieuxuathang(Phieuxuathang phieuxuathang)
        {
            
                string sql = string.Format("Insert into Phieuxuathang(Madonhang,Makh,Makho,Manv,Ngaylap) Values('{0}','{1}','{2}','{3}','{4}')", phieuxuathang.Madonhang, phieuxuathang.Makh, phieuxuathang.Makho, phieuxuathang.Manv, phieuxuathang.Ngaylap);
            
            var rs = db.thesuadulieu(sql);
            return rs;
        }
        public int InsertCTphieuxuathang(Chitietphieuxuatnhaphang phieuxuathang)
        {

            string sql = string.Format("Insert into Chitietphieuxuathang(Maphieuxuathang,Masp,SoLuong,Dongiahientai,Thanhtien) Values('{0}','{1}','{2}','{3}','{4}')", phieuxuathang.Maphieuxuathang, phieuxuathang.Masp, phieuxuathang.SoLuong, phieuxuathang.Dongiahientai, phieuxuathang.Thanhtien);

            var rs = db.thesuadulieu(sql);
            return rs;
        }
        public int UpdateSoluonghang(int soluong,int Id)
        {

            string sql = string.Format("Update Sanphams Set SoLuong=N'{0}' Where Id='{1}'", soluong, Id);

            var rs = db.thesuadulieu(sql);
            return rs;
        }
        public Object IDphieuuxuathang(string maphieuxuathang)
        {
            string sql = string.Format("Select Id from Phieuxuathang where Madonhang='{0}' ", maphieuxuathang);
            return db.Laythuoctinh(sql);
        }
        public List<Sanpham> LIstsanpham()
        {

            string sql = string.Format("Select * from Sanphams");
            return db.LIstsanpham(sql); ;
        }
        public int Demthuoctinh()
        {
            string sql = "select count(Id) from Phieuxuathang";
            return db.Demthuoctinh(sql);
        }
    }
}
