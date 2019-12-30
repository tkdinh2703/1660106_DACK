using DACK.DTO;
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
        LoginDAO loginDAO = new LoginDAO();
        public Form1()
        {
            InitializeComponent();
        }

        private void Frmmanin_khiketthuc()
        {
            this.Close();
        }
        private void XuLyDangXuat()
        {
            this.Visible = true;
        }

        public int ID(string username)
        {
            int id;
            var row = loginDAO.LayId(username);
             id= int.Parse(row.ToString());
            
            return id;
        }

        private void Linkdk_Click(object sender, EventArgs e)
        {
            Themsuanguoidung themsuanguoidung = new Themsuanguoidung();
            themsuanguoidung.Show();
        }

        private void BtnLogin_MouseEnter(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnLogin_Enter(object sender, EventArgs e)
        {

        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUser.Text;
            string passwork = txtPasswork.Text;
            if (username.Length != 0 && passwork.Length != 0)
            {

                var v = loginDAO.Login(username, passwork);
                if (v != null)
                {
                    int role = (int)v;
                    //MessageBox.Show("" + role);
                    frmTrangchu frmmanin = new frmTrangchu(role, ID(username), passwork);
                    frmmanin.Show();
                    frmmanin.khiDangXuat += XuLyDangXuat;
                    frmmanin.khiketthuc += Frmmanin_khiketthuc;

                    this.Visible = false;
                }
                else
                {
                    MessageBox.Show("Đăng nhập không thành công Kiểm tra lại thông tin đăng nhập ");
                }

            }
            else
            {
                MessageBox.Show("Thông tin đăng nhập không được bỏ trống");
            }
        }
    }
}
