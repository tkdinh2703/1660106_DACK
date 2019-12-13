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
        public List<Sanpham> LIstsanpham()
        {


            return db.LIstsanpham(); ;
        }

        public int Insertphieunhaphang(Phieunhaphang phieunhaphang)
        {
            return db.Insertphieunhaphang(phieunhaphang);
        }

        public int InsertCTphieuxuathang(Chitietphieuxuatnhaphang phieuxuathang)
        {
            return db.InsertCTphieuxuathang( phieuxuathang);
        }
        public int UpdateSoluonghang(int soluong, int Id)
        {

            return db.UpdateSoluonghang( soluong,  Id);
        }
        public Object IDphieunhaphang(string maphieuchi)
        {
            return db.IDphieunhaphang( maphieuchi);
        }

        public int Demthuoctinh()
        {
            return db.Demthuoctinh();
        }
    }
}
