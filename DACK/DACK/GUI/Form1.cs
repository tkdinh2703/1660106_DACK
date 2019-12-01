using DACK.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DACK
{
    public partial class Form1 : Form
    {
        string path = @"Data Source=DESKTOP-2H8FUNK\SQLEXPRESS;Initial Catalog=QLBH-DACK;User ID=sa;Password=1";
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            
            string username = txtUser.Text;
            string passwork = txtPasswork.Text;
            if (username.Length != 0 && passwork.Length != 0)
            {
                SqlConnection conn = new SqlConnection(path);
                string sql = string.Format("Select IdQuyen from Nhansu where TenDangNhap='{0}' and MatKhau='{1}'", username, passwork);
                conn.Open();
                SqlCommand sqlCommand = new SqlCommand(sql, conn);
                var v = sqlCommand.ExecuteScalar();
                if (v != null)
                {
                    int role = (int)v;
                    MessageBox.Show("" + role);
                        frmTrangchu frmmanin = new frmTrangchu(role,ID(username), passwork);
                        frmmanin.Show();
                    frmmanin.khiketthuc += Frmmanin_khiketthuc;
                }
                else
                {
                    MessageBox.Show("Đang nhập không thành công Kiểm tra lại thông tin đăng nhập ");
                }
                conn.Close();
            }
            else {
                MessageBox.Show("Thông tin đăng nhập không được bỏ trống");
            }
        }

        private void Frmmanin_khiketthuc()
        {
            this.Close();
        }

        public int ID(string username)
        {
            int id;
            SqlConnection con = new SqlConnection(path);          
            string sql = string.Format("Select Id from Nhansu where TenDangNhap = '{0}'", username);
            SqlCommand sqlCommand = new SqlCommand(sql, con);
            con.Open();
            var row = sqlCommand.ExecuteScalar();
             id= int.Parse(row.ToString());
            con.Close();
            return id;
        }

        private void Linkdk_Click(object sender, EventArgs e)
        {
            Themsuanguoidung themsuanguoidung = new Themsuanguoidung();
            themsuanguoidung.Show();
        }
    }
}
