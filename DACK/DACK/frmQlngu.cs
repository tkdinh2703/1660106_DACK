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
    public partial class frmQlngu : Form
    {
        int Role;
        int Idmanhinh = 1;
        
        string path = @"Data Source=DESKTOP-2H8FUNK\SQLEXPRESS;Initial Catalog=QLBH-DACK;User ID=sa;Password=1";
        public frmQlngu()
        {
            InitializeComponent();
        }
        public frmQlngu(int role)
        {
            Role = role;
           
            InitializeComponent();
        }

        private void FrmQlnhansu_Load(object sender, EventArgs e)
        {
           Roleform role= Quyen();
            button1.Visible = true;
            button2.Visible = false;
            if (Role == 2)
            {
                button1.Visible = role.Them;
                button2.Visible = role.Xoa;
                button3.Visible = role.Sua;
                //button4.Visible = role.Xuat;
            }
            Loaddata();

        }
        private void Loaddata()
        {
            SqlConnection sqlConnection = new SqlConnection(path);
            string query = "Select * from Sanpham";
            //SqlCommand command = new SqlCommand(query, sqlConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(query, sqlConnection);
            DataTable data = new DataTable();
            adapter.Fill(data);
            //.DataSource = data;

        }
        public Roleform Quyen()
        {
            int id = 0;
            Roleform roleform = new Roleform();

            SqlConnection con = new SqlConnection(path);
            string sql = string.Format("Select * from Phanquyen where QuyenId='{0}' and ManhinhId='{1}'", Role, Idmanhinh);
            SqlCommand sqlCommand = new SqlCommand(sql, con);
            con.Open();
            SqlDataReader row = sqlCommand.ExecuteReader();
            if (row.HasRows)
            {              
                row.Read();
                roleform.Them = Boolean.Parse(row[4].ToString());
                roleform.Xoa = Boolean.Parse(row[5].ToString());
                roleform.Sua = Boolean.Parse(row[6].ToString());
                roleform.Inan = Boolean.Parse(row[7].ToString());
                roleform.Nhap = Boolean.Parse(row[8].ToString());
                roleform.Xuat = Boolean.Parse(row[9].ToString());
                
            }
            

            con.Close();
            return roleform;
        }


        private void Button3_Click(object sender, EventArgs e)
        {

        }

        private void Button6_Click(object sender, EventArgs e)
        {

        }

        private void Button5_Click(object sender, EventArgs e)
        {

        }

        private void Button4_Click(object sender, EventArgs e)
        {

        }

        private void Button7_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
