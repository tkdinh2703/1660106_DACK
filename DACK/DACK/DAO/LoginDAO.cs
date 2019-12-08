using DACK.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DACK.DTO
{
    public class LoginDAO
    {
        Datbase datbase = new Datbase();
        public Object Login(string username,string passwork)
        {
            string sql = string.Format("Select IdQuyen from Nhansu where TenDangNhap='{0}' and MatKhau='{1}'", username, passwork);
            return datbase.Laythuoctinh(sql);
        }
        public Object LayId(string username)
        {
             string sql = string.Format("Select Id from Nhansu where TenDangNhap = '{0}'", username);
            return datbase.Laythuoctinh(sql);
        }
    }
}
