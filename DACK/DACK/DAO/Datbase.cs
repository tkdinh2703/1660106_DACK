using DACK.DTO;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DACK.DAO
{
    public class Datbase
    {
        string path = @"Data Source=DESKTOP-2H8FUNK\SQLEXPRESS;Initial Catalog=QLBH-DACK;User ID=sa;Password=1";
        public DataTable laydulieu(string sql)
        {
            SqlConnection sqlConnection = new SqlConnection(path);
            
            //SqlCommand command = new SqlCommand(query, sqlConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(sql, sqlConnection);
            DataTable datatable = new DataTable();
            adapter.Fill(datatable);

            return datatable;
        }
        public int Xoaulieu(string sql ,GridView grviewsanpham,string namecolum)
        {
            int row = 0;
           Object name = grviewsanpham.GetRowCellValue(grviewsanpham.FocusedRowHandle, namecolum);
            if (XtraMessageBox.Show("Bạn có muốn xóa " + name + "?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Object id = grviewsanpham.GetRowCellValue(grviewsanpham.FocusedRowHandle, "Id");
                SqlConnection con = new SqlConnection(path);
               
                SqlCommand sqlCommand = new SqlCommand(sql, con);
                con.Open();
                row = sqlCommand.ExecuteNonQuery();
                con.Close();               
            }
            return row;
        }
        public int thesuadulieu(string sql)
        {
            int row = 0;
            SqlConnection con = new SqlConnection(path);   
            SqlCommand sqlCommand = new SqlCommand(sql, con);

            con.Open();
            row = sqlCommand.ExecuteNonQuery();
            con.Close();
            return row;
        }

        public void Laodcbb(ComboBoxEdit comboBoxEdit,string sql,string tencot)
        {

            SqlConnection conn = new SqlConnection(path);           
            SqlCommand command = new SqlCommand(sql, conn);
            SqlDataAdapter sqlData = new SqlDataAdapter(command);
            var dt = new DataTable();
            sqlData.Fill(dt);
            conn.Open();

            //var dr = command.ExecuteReader();
            foreach (DataRow row in dt.Rows)
            {
                comboBoxEdit.Properties.Items.Add(row[tencot]);
            }
            conn.Close();
        }

        public Nhansu Laynhansu(string sql)
        {
            int id = 0;
            Nhansu roleform = new Nhansu();

            SqlConnection con = new SqlConnection(path);          
            SqlCommand sqlCommand = new SqlCommand(sql, con);
            con.Open();
            SqlDataReader row = sqlCommand.ExecuteReader();
            if (row.HasRows)
            {
                row.Read();
                roleform.Id = int.Parse(row[0].ToString());
                roleform.TenDangNhap =(row[1].ToString());
                roleform.MatKhau = (row[2].ToString());
                roleform.Ten = (row[3].ToString());
                roleform.Email = (row[4].ToString());
                roleform.NgayThamgia = (row[5].ToString());
                roleform.Diachi = (row[6].ToString());
                roleform.IdQuyen = int.Parse(row[7].ToString());
                roleform.Gioitinh = (row[8].ToString());
                roleform.Nganhang = (row[9].ToString());               
                roleform.Sotk = long.Parse(row[10].ToString());              
                roleform.Sodienthoai = int.Parse(row[11].ToString());
               

            }


            con.Close();
            return roleform;
        }

        public Roleform quyentruycap(int role, int IDmanhinh)
        {
           
            Roleform roleform = new Roleform();

            SqlConnection con = new SqlConnection(path);
            string sql = string.Format("Select * from Phanquyen where QuyenId='{0}' and ManhinhId='{1}'", role, IDmanhinh);
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

    }
}
