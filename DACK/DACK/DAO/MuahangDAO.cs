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
            string sql = string.Format("Select * from Nhansu where IdQuyen= {0} or IdQuyen= {1}",2, 3);
            return db.Chonnv(sql);
        }
        public List<Khohang> ChonKhohang()
        {

            string sql = string.Format("Select * from Khohang");

            return db.ChonKhohang(sql);
        }
        public List<Sanpham> LIstsanpham()
        {

            string sql = string.Format("Select * from Sanphams");
            return db.LIstsanpham(sql); ;
        }
        public int Insertphieunhaphang(Phieunhaphang phieunhaphang)
        {

            string sql = string.Format("Insert into Phieunhaphang(Maphieuthu,MaNcc,MaNvnhap,MaKhonhap,Ngaynhap,Tongtien) Values('{0}','{1}','{2}','{3}','{4}','{5}')", phieunhaphang.Maphieuthu, phieunhaphang.MaNcc, phieunhaphang.Manv, phieunhaphang.Makho, phieunhaphang.Ngaylap, phieunhaphang.Tongtien);

            var rs = db.thesuadulieu(sql);
            return rs;
        }

        public int InsertCTphieuxuathang(CTPhieuxuatnhaphang phieuxuathang)
        {

            string sql = string.Format("Insert into Chitietphieunhaphang(Maphieunhaphang,Masp,SoLuong,Dongia,Thanhtien) Values('{0}','{1}','{2}','{3}','{4}')", phieuxuathang.Maphieuxuathang, phieuxuathang.Masp, phieuxuathang.SoLuong, phieuxuathang.Dongiahientai, phieuxuathang.Thanhtien);

            var rs = db.thesuadulieu(sql);
            return rs;
        }
        public int UpdateSoluonghang(int soluong, int Id)
        {

            string sql = string.Format("Update Sanphams Set SoLuong=N'{0}' Where Id='{1}'", soluong, Id);

            var rs = db.thesuadulieu(sql);
            return rs;
        }
        public Object IDphieunhaphang(string maphieuchi)
        {
            string sql = string.Format("Select Id from Phieunhaphang where Maphieuthu='{0}' ", maphieuchi);
            return db.Laythuoctinh(sql);
        }
        
        public int Demthuoctinh()
        {
            string sql = "select count(Id) from Phieunhaphang";
            return db.Demthuoctinh(sql);
        }
    }
}
