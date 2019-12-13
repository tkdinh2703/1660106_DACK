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
    public partial class frmMuahang : DevExpress.XtraEditors.XtraForm
    {
        int Id = 0;
        MuahangBUS muahangBUS = new MuahangBUS();
        List<Nhacungcap> lstNCC = new List<Nhacungcap>();
        List<Nhansu> lstnhanvien = new List<Nhansu>();
        List<Khohang> lstkhohang = new List<Khohang>();
        List<Sanpham> lstsp = new List<Sanpham>();
        List<Luoixuatnhaphang> lstphieuxh = new List<Luoixuatnhaphang>();
        private decimal qsoluong = 0;
        private decimal thanhtien = 0;
        private decimal giahientai = 0;
        private decimal vat = 0;
        private decimal Tongth = 0;
        public frmMuahang()
        {
            InitializeComponent();
        }
        public frmMuahang(int id)
        {
            InitializeComponent();
            Id = id;
        }
        public void LoaditemID()
        {
            lstsp = muahangBUS.LIstsanpham();
            repository1.DataSource = lstsp;
            repository1.ValueMember = "TenHang";
            repository1.DisplayMember = "TenHang";
            repository1.NullText = "Chọn theo tên";
            Tenhang.ColumnEdit = repository1;

            repositoryID.DataSource = lstsp;
            repositoryID.ValueMember = "Id";
            repositoryID.DisplayMember = "Id";
            repositoryID.NullText = "Chọn theo mã";
            Idsp.ColumnEdit = repositoryID;

        }
        public void Chondoituong()
        {
            lstNCC = muahangBUS.ChonNCC();
            cbbNCC.Properties.DataSource = lstNCC;
            cbbNCC.Properties.DisplayMember = "TenNCC";
            cbbNCC.Properties.ValueMember = "Id";
            cbbNCC.Properties.PopupResizeMode = ResizeMode.FrameResize;
            cbbNCC.Properties.BestFitMode = BestFitMode.BestFitResizePopup;

            lstnhanvien = muahangBUS.Chonnv();
            cbbnhanviennhap.Properties.DataSource = lstnhanvien;
            cbbnhanviennhap.Properties.DisplayMember = "Ten";
            cbbnhanviennhap.Properties.ValueMember = "Id";
            cbbnhanviennhap.Properties.PopupResizeMode = ResizeMode.FrameResize;
            cbbnhanviennhap.Properties.BestFitMode = BestFitMode.BestFitResizePopup;

            lstkhohang = muahangBUS.ChonKhohang();
            cbbkhonhap.Properties.DataSource = lstkhohang;
            cbbkhonhap.Properties.DisplayMember = "Tenkhohang";
            cbbkhonhap.Properties.ValueMember = "Id";
            cbbkhonhap.Properties.PopupResizeMode = ResizeMode.FrameResize;
            cbbkhonhap.Properties.BestFitMode = BestFitMode.BestFitResizePopup;
            lstphieuxh = new List<Luoixuatnhaphang>();
            gridControl1.DataSource = new BindingList<Luoixuatnhaphang>(lstphieuxh);
            cbbnhanviennhap.EditValue = Id;
            cbbkhonhap.EditValue = 1;

            EditorButton editorButton = new EditorButton(ButtonPredefines.Plus);
            cbbNCC.Properties.Buttons.Add(editorButton);
            editorButton.Click += EditorButton_Click;
        }

        private void EditorButton_Click(object sender, EventArgs e)
        {
            Themsunhacungcap themsunhacungcap = new Themsunhacungcap();
            themsunhacungcap.Show();
        }

        private void FrmMuahang_Load(object sender, EventArgs e)
        {
            Chondoituong();
            LoaditemID();
            int sohd = muahangBUS.Demthuoctinh();
            txtmaphieuchi.Text = "BHPC0" + (sohd + 1);
            txtngaylap.Text = DateTime.Now.ToString();
        }

        private void CbbNCC_EditValueChanged(object sender, EventArgs e)
        {
            Nhacungcap nhacungcap = laykhachang();
            txtdiachi.Text = nhacungcap.DiaChi;
            txtdienthoai.Text = nhacungcap.DienThoai.ToString();
            txtMancc.Text = nhacungcap.Id.ToString(); 
            txttwebsite.Text = nhacungcap.Website;
            
        }

        public Nhacungcap laykhachang()
        {
            Nhacungcap nhacungcap = new Nhacungcap();
            for (int i = 0; i < lstNCC.Count; i++)
            {
                if (lstNCC[i].Id == int.Parse(cbbNCC.EditValue.ToString()))
                {
                    nhacungcap = lstNCC[i];
                }
            }
            return nhacungcap;
        }
        Sanpham sanpham = new Sanpham();
        private void GridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName == "Tenhang")
            {
                var Value = gridView1.GetRowCellValue(e.RowHandle, e.Column);
                if(Value.ToString()!= "")
                {
                    sanpham = laysanpham(Value.ToString());
                }
                
                if (sanpham != null)
                {
                    gridView1.SetRowCellValue(e.RowHandle, "Idsp", sanpham.Id);
                    gridView1.SetRowCellValue(e.RowHandle, "Loaihang", sanpham.LoaiHang);
                    gridView1.SetRowCellValue(e.RowHandle, "Giahientai", sanpham.GiaMua);
                    if (gridView1.GetFocusedRowCellValue(Soluong) == null)
                    {
                        qsoluong = 0;
                    }
                    else
                    {
                        qsoluong = Convert.ToDecimal(gridView1.GetFocusedRowCellValue(Soluong));
                        
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
            if (e.Column.FieldName == "Idsp")
            {
                var Value = gridView1.GetRowCellValue(e.RowHandle, e.Column);
                if ((int)Value != 0)
                {
                    sanpham = laysanphamtheoID(int.Parse(Value.ToString()));
                }

                if (sanpham != null)
                {
                    //gridView1.SetRowCellValue(e.RowHandle, "Tenhang", sanpham.TenHang);
                    lstphieuxh[lstphieuxh.Count-1].Tenhang = sanpham.TenHang;
                    gridView1.SetRowCellValue(e.RowHandle, "Loaihang", sanpham.LoaiHang);
                    gridView1.SetRowCellValue(e.RowHandle, "Giahientai", sanpham.GiaMua);
                    if (gridView1.GetFocusedRowCellValue(Soluong) == null)
                    {
                        qsoluong = 0;
                    }
                    else
                    {
                        qsoluong = Convert.ToDecimal(gridView1.GetFocusedRowCellValue(Soluong));

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
            if (e.Column == Soluong)
            {
                qsoluong = Convert.ToDecimal(gridView1.GetFocusedRowCellValue(Soluong));
                
                    giahientai = Convert.ToDecimal(gridView1.GetFocusedRowCellValue(Giahientai));
                    thanhtien = qsoluong * giahientai;
                    vat = (thanhtien * sanpham.VAT) / 100;
                    gridView1.SetFocusedRowCellValue(Thanhtien, thanhtien);
                    gridView1.SetFocusedRowCellValue(VAT, vat);
                    Tongth = vat + thanhtien;
                    gridView1.SetFocusedRowCellValue(Tongthanhtoan, Tongth);               
            }
        }
        public Sanpham laysanpham(string Value)
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
        public Sanpham laysanphamtheoID(int Value)
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

        private void Btnluu_Click(object sender, EventArgs e)
        {
            Phieunhaphang phieuxuathang = new Phieunhaphang();
            phieuxuathang.Maphieuthu = txtmaphieuchi.Text;
            phieuxuathang.Makho = int.Parse(cbbkhonhap.EditValue.ToString());
            phieuxuathang.MaNcc = int.Parse(txtMancc.Text);
            phieuxuathang.Manv = int.Parse(cbbnhanviennhap.EditValue.ToString());
            phieuxuathang.Ngaylap = txtngaylap.Text;
            // chua rang buoc madonhang
            muahangBUS.Insertphieunhaphang(phieuxuathang);

            var id = muahangBUS.IDphieunhaphang(phieuxuathang.Maphieuthu);
            int soluong;
            Chitietphieuxuatnhaphang ctPhieuxuathang = new Chitietphieuxuatnhaphang();
            for (int i = 0; i < lstphieuxh.Count; i++)
            {
                ctPhieuxuathang.Maphieuxuathang = int.Parse(id.ToString());
                ctPhieuxuathang.Masp = lstphieuxh[i].Idsp;
                ctPhieuxuathang.SoLuong = lstphieuxh[i].Soluong;
                ctPhieuxuathang.Dongiahientai = lstphieuxh[i].Giahientai;
                ctPhieuxuathang.Thanhtien = lstphieuxh[i].Tongthanhtoan;
                muahangBUS.InsertCTphieuxuathang(ctPhieuxuathang);
                sanpham = laysanphamtheoID(lstphieuxh[i].Idsp);
                soluong = sanpham.SoLuong + lstphieuxh[i].Soluong;
                muahangBUS.UpdateSoluonghang(soluong, lstphieuxh[i].Idsp);
            }


            for (int i = gridView1.RowCount - 1; i >= 0; i--)
            {
                gridView1.DeleteRow(i);
            }
            lstphieuxh.Clear();
            LoaditemID();
            int sohd = muahangBUS.Demthuoctinh();
            txtmaphieuchi.Text = "BHPC0" + (sohd + 1);
            txtngaylap.Text = DateTime.Now.ToString();
        }
    }
}