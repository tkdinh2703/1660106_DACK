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
using DACK.DTO;
using DACK.BUS;
using DevExpress.XtraEditors.Controls;

namespace DACK.GUI
{
    public partial class frmBanhang : DevExpress.XtraEditors.XtraForm
    {
        int ID = 0;
        List<Sanpham> lstsp = new List<Sanpham>();
        List<Khachhang> lstkachchang= new List<Khachhang>();
        List<Nhansu> lstnhanvien = new List<Nhansu>();
        List<Khohang> lstkhohang = new List<Khohang>();
        List<Luoixuatnhaphang> lstluoixuathang = new List<Luoixuatnhaphang>();
        BanhangBUS banhangBUS =  new BanhangBUS();
        private decimal qsoluong = 0;
        private decimal thanhtien = 0;
        private decimal giahientai = 0;
        private decimal vat = 0;
        private decimal Tongth = 0;
        public frmBanhang()
        {
            InitializeComponent();
        }
        public frmBanhang(int id)
        {
            InitializeComponent();
            ID = id;
        }

        private void FrmBanhang_Load(object sender, EventArgs e)
        {
            Chondoituong();
            LoaditemID();
            int sohd = banhangBUS.Demthuoctinh();
            txtmadonhang.Text = "BHPT0" + (sohd + 1);
            cbbnhanvien.EditValue = ID; ;
            txtngaylap.Text = DateTime.Now.ToString();      
            EditorButton editorButton = new EditorButton(ButtonPredefines.Plus);
            cbbChonKh.Properties.Buttons.Add(editorButton);          
            editorButton.Click += EditorButton_Click;
        }

        private void EditorButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("aa");
        }

        public void Chondoituong() {
            lstkachchang= banhangBUS.ChonKh();
            cbbChonKh.Properties.DataSource = lstkachchang;
            cbbChonKh.Properties.DisplayMember = "Ten";
            cbbChonKh.Properties.ValueMember = "Id";
            cbbChonKh.Properties.PopupResizeMode = ResizeMode.FrameResize;
            cbbChonKh.Properties.BestFitMode = BestFitMode.BestFitResizePopup;

            lstnhanvien = banhangBUS.Chonnv();
            cbbnhanvien.Properties.DataSource = lstnhanvien;
            cbbnhanvien.Properties.DisplayMember = "Ten";
            cbbnhanvien.Properties.ValueMember = "Id";
            cbbnhanvien.Properties.PopupResizeMode = ResizeMode.FrameResize;
            cbbnhanvien.Properties.BestFitMode = BestFitMode.BestFitResizePopup;

            lstkhohang = banhangBUS.ChonKhohang();
            cbbKho.Properties.DataSource = lstkhohang;
            cbbKho.Properties.DisplayMember = "Tenkhohang";
            cbbKho.Properties.ValueMember = "Id";
            cbbKho.Properties.PopupResizeMode = ResizeMode.FrameResize;
            cbbKho.Properties.BestFitMode = BestFitMode.BestFitResizePopup;
            lstluoixuathang = new List<Luoixuatnhaphang>(); 
            gridControl1.DataSource = new BindingList<Luoixuatnhaphang>(lstluoixuathang) ;


        }

        private void Btnxuathoadom_Click(object sender, EventArgs e)
        {
            //for (int i = 0; i < lstphieuxh.Count; i++)
            //{
                MessageBox.Show("" +cbbnhanvien.EditValue);
            //}
        }

      
        public Khachhang laykhachang()
        {
            Khachhang khachhang = new Khachhang();
            for(int i = 0;i < lstkachchang.Count;i++)
            {
                if (lstkachchang[i].Id == int.Parse(cbbChonKh.EditValue.ToString()))
                {
                    khachhang = lstkachchang[i];
                }
            }
            return khachhang;
        }

        public Sanpham laysanpham(int Value)
        {
            Sanpham sanpham = new Sanpham();
            for (int i = 0; i < lstsp.Count; i++)
            {
                if (lstsp[i].Id == Value)
                {
                    sanpham = lstsp[i];
                    break;
                }
            }
            return sanpham;
        }
        public Sanpham laysanphamtheoTen(string Value)
        {
            Sanpham sanpham = new Sanpham();
            for (int i = 0; i < lstsp.Count; i++)
            {
                if (lstsp[i].TenHang == Value)
                {
                    sanpham = lstsp[i];
                    break;
                }
            }
            return sanpham;
        }
        private void CbbChonKh_EditValueChanged_1(object sender, EventArgs e)
        {
            Khachhang nhansu = laykhachang();
            gridControl1.Text = nhansu.Diachi;
            txtemail.Text = nhansu.Email;
            txtDiachi.Text = nhansu.Diachi;
            txtsodienthoai.Text = nhansu.Sodienthoai.ToString();
            txtmakh.Text = nhansu.Id.ToString();
                   
            //cbbnhanvien.SelectedText
        }
        public void LoaditemID()
        {
             lstsp = banhangBUS.LIstsanpham();
            repositoryItem.DataSource = lstsp;
            repositoryItem.ValueMember = "Id";
            repositoryItem.DisplayMember = "Id";
            repositoryItem.NullText = "Chọn sản phẩm";
            Idsp.ColumnEdit = repositoryItem;

            repositoryName.DataSource = lstsp;
            repositoryName.ValueMember = "TenHang";
            repositoryName.DisplayMember = "TenHang";
            repositoryName.NullText = "Chọn sản phẩm";
            Tenhang.ColumnEdit = repositoryName;
        }
        Sanpham sanpham = new Sanpham();
        private void GridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
          
            if (e.Column.FieldName == "Idsp")
            {
                var Value = gridView1.GetRowCellValue(e.RowHandle, e.Column);
                sanpham = laysanpham((int)Value);
                if(sanpham!=null)
                {
                    gridView1.SetRowCellValue(e.RowHandle, "Tenhang", sanpham.TenHang);
                    gridView1.SetRowCellValue(e.RowHandle, "Loaihang", sanpham.LoaiHang);
                    gridView1.SetRowCellValue(e.RowHandle, "Giahientai", sanpham.GiaBan);
                    if (gridView1.GetFocusedRowCellValue(Soluong) == null)
                    {
                        qsoluong = 0;
                    }
                    else
                    {
                        qsoluong = Convert.ToDecimal(gridView1.GetFocusedRowCellValue(Soluong));
                        if (sanpham.SoLuong < qsoluong)
                        {
                            MessageBox.Show("Sản  phẩm " + sanpham.TenHang + " xuất quá số lượng trong kho");
                        }
                        else
                        {
                            giahientai = Convert.ToDecimal(gridView1.GetFocusedRowCellValue(Giahientai));
                            thanhtien = qsoluong * giahientai;
                            vat = (thanhtien * sanpham.VAT) / 100;
                            gridView1.SetFocusedRowCellValue(Thanhtien, thanhtien);
                            gridView1.SetFocusedRowCellValue(VAT, vat);
                            Tongth = vat + thanhtien;
                            gridView1.SetFocusedRowCellValue(Tongthanhtoan, Tongth);
                        }
                    }
                }
                
                              
                
            }
            if (e.Column.FieldName == "Tenhang")
            {
                var Value = gridView1.GetRowCellValue(e.RowHandle, e.Column);
                sanpham = laysanphamtheoTen(Value.ToString());
                if (sanpham != null)
                {
                    //gridView1.SetRowCellValue(e.RowHandle, "Idsp", sanpham.Id);
                    lstluoixuathang[lstluoixuathang.Count - 1].Idsp = sanpham.Id;
                    gridView1.SetRowCellValue(e.RowHandle, "Loaihang", sanpham.LoaiHang);
                    gridView1.SetRowCellValue(e.RowHandle, "Giahientai", sanpham.GiaBan);
                    if (gridView1.GetFocusedRowCellValue(Soluong) == null)
                    {
                        qsoluong = 0;
                    }
                    else
                    {
                        qsoluong = Convert.ToDecimal(gridView1.GetFocusedRowCellValue(Soluong));
                        if (sanpham.SoLuong < qsoluong)
                        {
                            MessageBox.Show("Sản  phẩm " + sanpham.TenHang + " xuất quá số lượng trong kho");
                        }
                        else
                        {
                            giahientai = Convert.ToDecimal(gridView1.GetFocusedRowCellValue(Giahientai));
                            thanhtien = qsoluong * giahientai;
                            vat = (thanhtien * sanpham.VAT) / 100;
                            gridView1.SetFocusedRowCellValue(Thanhtien, thanhtien);
                            gridView1.SetFocusedRowCellValue(VAT, vat);
                            Tongth = vat + thanhtien;
                            gridView1.SetFocusedRowCellValue(Tongthanhtoan, Tongth);
                        }
                    }
                }



            }
            if (e.Column == Soluong)
            {            
                qsoluong = Convert.ToDecimal(gridView1.GetFocusedRowCellValue(Soluong));
                if (sanpham.SoLuong < qsoluong)
                {
                    MessageBox.Show("Sản  phẩm " + sanpham.TenHang + " xuất quá số lượng trong kho "+sanpham.SoLuong);                   
                }
                else
                {
                    giahientai = Convert.ToDecimal(gridView1.GetFocusedRowCellValue(Giahientai));
                    thanhtien = qsoluong * giahientai;
                    vat = (thanhtien * sanpham.VAT) / 100;
                    gridView1.SetFocusedRowCellValue(Thanhtien, thanhtien);
                    gridView1.SetFocusedRowCellValue(VAT, vat);
                    Tongth = vat + thanhtien;
                    gridView1.SetFocusedRowCellValue(Tongthanhtoan, Tongth);
                }

                
                
            }
        }

        private void Btnthnahtoan_Click(object sender, EventArgs e)
        {
            Phieuxuathang phieuxuathang = new Phieuxuathang();
            phieuxuathang.Madonhang = txtmadonhang.Text;
            phieuxuathang.Makho = int.Parse(cbbKho.EditValue.ToString());
            phieuxuathang.Makh = int.Parse(txtmakh.Text);
            phieuxuathang.Manv= int.Parse(cbbnhanvien.EditValue.ToString());
            phieuxuathang.Ngaylap = txtngaylap.Text;
            // chua rang buoc madonhang
            banhangBUS.Insertphieuxuathang(phieuxuathang);

            var id = banhangBUS.IDphieuuxuathang(phieuxuathang.Madonhang);
            int soluong;
            Chitietphieuxuatnhaphang ctPhieuxuathang = new Chitietphieuxuatnhaphang();
            for (int i = 0; i < lstluoixuathang.Count; i++)
            {
                ctPhieuxuathang.Maphieuxuathang = int.Parse(id.ToString());
                ctPhieuxuathang.Masp = lstluoixuathang[i].Idsp;
                ctPhieuxuathang.SoLuong = lstluoixuathang[i].Soluong;
                ctPhieuxuathang.Dongiahientai = lstluoixuathang[i].Giahientai;
                ctPhieuxuathang.Thanhtien = lstluoixuathang[i].Tongthanhtoan;
                banhangBUS.InsertCTphieuxuathang(ctPhieuxuathang);
                sanpham = laysanpham(lstluoixuathang[i].Idsp);
                soluong = sanpham.SoLuong - lstluoixuathang[i].Soluong;
                banhangBUS.UpdateSoluonghang(soluong, lstluoixuathang[i].Idsp);
            }
            

            for (int i= gridView1.RowCount-1; i>=0;i--)
            {
                gridView1.DeleteRow(i);
            }
            lstluoixuathang.Clear();
            LoaditemID();
            int sohd = banhangBUS.Demthuoctinh();
            txtmadonhang.Text = "BHPT0" + (sohd+1);
        }

        private void Cbbnhanvien_EditValueChanged(object sender, EventArgs e)
        {
           
        }
    }
}