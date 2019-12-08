using DACK.DAO;
using DACK.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DACK.BUS
{
    public class BanhangBUS
    {
        BanhangDAO db = new BanhangDAO();
        public List<Khachhang> ChonKh()
        {
           

            return db.ChonKh();
        }
        public List<Nhansu> Chonnv()
        {
            return db.Chonnv();
        }
        public List<Khohang> ChonKhohang()
        {      
            return db.ChonKhohang();
        }
        public int Insertphieuxuathang(Phieuxuathang phieuxuathang)
        {

            return db.Insertphieuxuathang(phieuxuathang);
        }
        public Object IDphieuuxuathang(string maphieuxuathang)
        {

            return db.IDphieuuxuathang(maphieuxuathang);
        }
        public int InsertCTphieuxuathang(Chitietphieuxuathang phieuxuathang)
        {

            return db.InsertCTphieuxuathang(phieuxuathang);
        }
        public int UpdateSoluonghang(int soluong, int Id)
        {

            return db.UpdateSoluonghang(soluong,Id);
        }
        public List<Sanpham> LIstsanpham()
        {

            
            return db.LIstsanpham(); ;
        }
    }
}
