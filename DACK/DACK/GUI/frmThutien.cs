using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraLayout;
using DACK.DTO;
using DACK.BUS;
using DevExpress.XtraEditors.Controls;

namespace DACK.GUI
{
    public partial class frmThutien : DevExpress.XtraEditors.XtraForm
    {
        ThutienBUS thutienBUS = new ThutienBUS(); 
        BanhangBUS banhangBUS = new BanhangBUS();
        List<Khachhang> lstkachchang = new List<Khachhang>();
        List<Nhansu> lstnhanvien = new List<Nhansu>();
        List<Phieuxuathang> phieuxuathangs = new List<Phieuxuathang>();
        List<Luoithutratien> luoithutratiens; 
        int Id = 0;
        decimal tientra;
        decimal tongtien;
        decimal tienno;
        public frmThutien()
        {
            InitializeComponent();
        }
        public frmThutien(int ID)
        {
            InitializeComponent();
            Id = ID;
        }

        private void FrmThutien_Load(object sender, EventArgs e)
        {
            Chondoituong();
            repository1.NullText = "Chọn khách hàng trước khi thực hiện";
            int sohd = thutienBUS.Demthuoctinh();           
            txtmahoadonthu.Text = "PTHU00" + (sohd + 1);
        }
        public void Chondoituong()
        {
            lstkachchang = banhangBUS.ChonKh();
            cbbkhachhang.Properties.DataSource = lstkachchang;
            cbbkhachhang.Properties.DisplayMember = "Ten";
            cbbkhachhang.Properties.ValueMember = "Id";
            cbbkhachhang.Properties.PopupResizeMode = ResizeMode.FrameResize;
            cbbkhachhang.Properties.BestFitMode = BestFitMode.BestFitResizePopup;
            
            lstnhanvien = banhangBUS.Chonnv();
            cbbnhanvienlap.Properties.DataSource = lstnhanvien;
            cbbnhanvienlap.Properties.DisplayMember = "Ten";
            cbbnhanvienlap.Properties.ValueMember = "Id";
            cbbnhanvienlap.Properties.PopupResizeMode = ResizeMode.FrameResize;
            cbbnhanvienlap.Properties.BestFitMode = BestFitMode.BestFitResizePopup;
            txtngaylap.Text = DateTime.Now.ToString();
            cbbnhanvienlap.EditValue = Id;
            
            luoithutratiens = new List<Luoithutratien>();
            gridControl1.DataSource = new BindingList<Luoithutratien>(luoithutratiens);


        }
        public Khachhang laykhachang()
        {
            Khachhang khachhang = new Khachhang();
            for (int i = 0; i < lstkachchang.Count; i++)
            {
                if (lstkachchang[i].Id == int.Parse(cbbkhachhang.EditValue.ToString()))
                {
                    khachhang = lstkachchang[i];
                }
            }
            return khachhang;
        }
        private void Cbbkhachhang_EditValueChanged(object sender, EventArgs e)
        {
            Khachhang nhansu = laykhachang();
            txtemail.Text = nhansu.Email;
            txtdiachi.Text = nhansu.Diachi;
            txtsodienthoai.Text = nhansu.Sodienthoai.ToString();
            txtmakh.Text = nhansu.Id.ToString();
            LoaditemID(int.Parse(cbbkhachhang.EditValue.ToString()));

        }
        public void LoaditemID(int makh)
        {
            phieuxuathangs = thutienBUS.Listpheuxuathang(makh);
            repository1.DataSource = phieuxuathangs;
            repository1.ValueMember = "Madonhang";
            repository1.DisplayMember = "Madonhang";
            repository1.NullText = "Chọn mã phiếu thu";
            Maphieuxuathang.ColumnEdit = repository1;

            
        }
        public Phieuxuathang layinfoPXH(string Value)
        {
            Phieuxuathang phieuxuathang = new Phieuxuathang();
            for (int i = 0; i < phieuxuathangs.Count; i++)
            {
                if (phieuxuathangs[i].Madonhang == Value)
                {
                    phieuxuathang = phieuxuathangs[i];
                    break;
                }
            }
            return phieuxuathang;
        }
        Phieuxuathang phieuxuathang = new Phieuxuathang();
        private void GridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName == "Maphieuxuathang")
            {
                var Value = gridView1.GetRowCellValue(e.RowHandle, e.Column);
                if (Value.ToString() !="")
                {
                     phieuxuathang = layinfoPXH(Value.ToString());
                }
                if (phieuxuathang != null)
                {
                    gridView1.SetRowCellValue(e.RowHandle, "Ngaylapphieu", phieuxuathang.Ngaylap);
                    gridView1.SetRowCellValue(e.RowHandle, "Tongtienphieuthu", phieuxuathang.Tongtien);                   
                    if (gridView1.GetFocusedRowCellValue(Tientra) == null)
                    {
                        tientra = 0;
                    }
                    else
                    {
                        tientra = Convert.ToDecimal(gridView1.GetFocusedRowCellValue(Tientra));
                        if (phieuxuathang.Tongtien < tientra)
                        {
                            MessageBox.Show("Số tiền nhập lớn hơn tiền nợ " + phieuxuathang.Tongtien );
                        }
                        else
                        {
                            tongtien = Convert.ToDecimal(gridView1.GetFocusedRowCellValue(Tongtienphieuthu));
                            tienno = tongtien - tientra;
                            gridView1.SetFocusedRowCellValue(Tienno, tienno);
                        }
                    }
                }

            }

            if (e.Column == Tientra)
            {
                tientra = Convert.ToDecimal(gridView1.GetFocusedRowCellValue(Tientra));
                if (phieuxuathang.Tongtien < tientra)
                {
                    MessageBox.Show("Số tiền nhập lớn hơn tiền nợ " + phieuxuathang.Tongtien);
                }
                else
                {
                    tongtien = Convert.ToDecimal(gridView1.GetFocusedRowCellValue(Tongtienphieuthu));
                    tienno = tongtien - tientra;                 
                    gridView1.SetFocusedRowCellValue(Tienno, tienno);
                   
                }

            }
        }

        private void SimpleButton1_Click(object sender, EventArgs e)
        {
            Hoadonthutratien hoadonthutratien = laythongtinhoadonthu();
            thutienBUS.themhoadonthu(hoadonthutratien);
            CThoadonthu();

            for (int i = gridView1.RowCount - 1; i >= 0; i--)
            {
                gridView1.DeleteRow(i);
            }
            luoithutratiens.Clear();
            LoaditemID(int.Parse(txtmakh.Text));
            int sohd = thutienBUS.Demthuoctinh();
            txtmahoadonthu.Text = "PTHU00" + (sohd + 1);
        }
        public void CThoadonthu()
        {
            var id = thutienBUS.IDhoadonthu(txtmahoadonthu.Text);
            CTphieuthutratien luoithutratien = new CTphieuthutratien();                      
            for (int i = 0; i < luoithutratiens.Count; i++)
            {
                luoithutratien.Mahoadonthu = (int)id;
                luoithutratien.Maphieuxuathang = luoithutratiens[i].Maphieuxuathang;
                luoithutratien.Tontienhdthu = luoithutratiens[i].Tongtienphieuthu;
                luoithutratien.Tientra = luoithutratiens[i].Tientra;
                luoithutratien.Tieno = luoithutratiens[i].Tienno;
                thutienBUS.themcthoadonthu(luoithutratien);               
                thutienBUS.SuaTienphieuthu(luoithutratiens[i].Maphieuxuathang, luoithutratiens[i].Tienno);
            }
            
        }
        public Hoadonthutratien laythongtinhoadonthu()
        {
            Hoadonthutratien hoadonthutratien = new Hoadonthutratien();
            hoadonthutratien.Mahoadonthu = txtmahoadonthu.Text;
            hoadonthutratien.Makh = int.Parse(txtmakh.Text);
            hoadonthutratien.Ngaylap = txtngaylap.Text;
            hoadonthutratien.Manv = int.Parse(cbbnhanvienlap.EditValue.ToString());
            return hoadonthutratien;
        }
    }
}