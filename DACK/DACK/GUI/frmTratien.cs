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
using DACK.BUS;
using DACK.DTO;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraReports.UI;

namespace DACK.GUI
{
    public partial class frmTratien : DevExpress.XtraEditors.XtraForm
    {
        int Id = 0;
        MuahangBUS muahangBUS = new MuahangBUS();
        TratienBUS tratienBUS = new TratienBUS();
        List<Nhacungcap> lstNCC = new List<Nhacungcap>();
        List<Nhansu> lstnhanvien = new List<Nhansu>();
        List<Phieunhaphang> phieunhaphangs = new List<Phieunhaphang>();
        List<Luoithutratien> luoithutratiens;
       
        decimal tientra;
        decimal tongtien;
        decimal tienno;
        public frmTratien()
        {
            InitializeComponent();
        }
        public frmTratien(int Id)
        {
            InitializeComponent();
            this.Id = Id;
        }

        private void FrmTratien_Load(object sender, EventArgs e)
        {
            Chondoituong();
            repository1.NullText = "Chọn khách hàng trước khi thực hiện";
            int sohd = tratienBUS.Demthuoctinh();
            txtmahoadonchi.Text = "PCHI00" + (sohd + 1);
            cbbnhanvien.EditValue = Id;
            txtngaylap.Text = DateTime.Now.ToString();
        }

        public void Chondoituong()
        {
            lstNCC = muahangBUS.ChonNCC();
            cbbNcc.Properties.DataSource = lstNCC;
            cbbNcc.Properties.DisplayMember = "TenNCC";
            cbbNcc.Properties.ValueMember = "Id";
            cbbNcc.Properties.PopupResizeMode = ResizeMode.FrameResize;
            cbbNcc.Properties.BestFitMode = BestFitMode.BestFitResizePopup;

            lstnhanvien = muahangBUS.Chonnv();
            cbbnhanvien.Properties.DataSource = lstnhanvien;
            cbbnhanvien.Properties.DisplayMember = "Ten";
            cbbnhanvien.Properties.ValueMember = "Id";
            cbbnhanvien.Properties.PopupResizeMode = ResizeMode.FrameResize;
            cbbnhanvien.Properties.BestFitMode = BestFitMode.BestFitResizePopup;

            luoithutratiens = new List<Luoithutratien>();
            gridControl1.DataSource = new BindingList<Luoithutratien>(luoithutratiens);
        }
        public void LoaditemID(int mancc)
        {
            phieunhaphangs = tratienBUS.Listpheunhaphang(mancc);
            repository1.DataSource = phieunhaphangs;
            repository1.ValueMember = "Maphieuthu";
            repository1.DisplayMember = "Maphieuthu";
            repository1.NullText = "Chọn mã phiếu chi";
            Maphieuxuathang.ColumnEdit = repository1;


        }
        public Nhacungcap layNcc()
        {
            Nhacungcap nhacungcap = new Nhacungcap();
            for (int i = 0; i < lstNCC.Count; i++)
            {
                if (lstNCC[i].Id == int.Parse(cbbNcc.EditValue.ToString()))
                {
                    nhacungcap = lstNCC[i];
                }
            }
            return nhacungcap;
        }
        private void CbbNcc_EditValueChanged(object sender, EventArgs e)
        {
            Nhacungcap nhacungcap = layNcc();
            txtdiachi.Text = nhacungcap.DiaChi;
            txtmancc.Text = nhacungcap.Id.ToString();
            txtsodienthoai.Text = nhacungcap.DienThoai.ToString();
            txtwebsite.Text = nhacungcap.Website;
            LoaditemID(nhacungcap.Id);
        }

        public Phieunhaphang layinfoPXH(string Value)
        {
            Phieunhaphang phieunhaphang = new Phieunhaphang();
            for (int i = 0; i < phieunhaphangs.Count; i++)
            {
                if (phieunhaphangs[i].Maphieuthu == Value)
                {
                    phieunhaphang = phieunhaphangs[i];
                    break;
                }
            }
            return phieunhaphang;
        }
        Phieunhaphang phienhaphang = new Phieunhaphang();
        private void GridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName == "Maphieuxuathang")
            {
                var Value = gridView1.GetRowCellValue(e.RowHandle, e.Column);
                if (Value.ToString() != "")
                {
                    phienhaphang = layinfoPXH(Value.ToString());
                }
                if (phienhaphang != null)
                {
                    gridView1.SetRowCellValue(e.RowHandle, "Ngaylapphieu", phienhaphang.Ngaylap);
                    gridView1.SetRowCellValue(e.RowHandle, "Tongtienphieuthu", phienhaphang.Tongtien);
                    if (gridView1.GetFocusedRowCellValue(Tientra) == null)
                    {
                        tientra = 0;
                    }
                    else
                    {
                        tientra = Convert.ToDecimal(gridView1.GetFocusedRowCellValue(Tientra));
                        if (phienhaphang.Tongtien < tientra)
                        {
                            MessageBox.Show("Số tiền nhập lớn hơn tiền nợ " + phienhaphang.Tongtien);
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
                if (phienhaphang.Tongtien < tientra)
                {
                    MessageBox.Show("Số tiền nhập lớn hơn tiền nợ " + phienhaphang.Tongtien);
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
            Hoadonthutratien hoadonthutratien = laythongtinhoadonchi();
            tratienBUS.themhoadonchi(hoadonthutratien);
            CThoadonchi();
            if (checkin.Checked == true)
            {
                Inhoadonthuchi dsnguoidung = new Inhoadonthuchi();
                dsnguoidung.DataSource = luoithutratiens;
                ReportPrintTool report = new ReportPrintTool(dsnguoidung);
                dsnguoidung.txtmahoadon.Text = txtmahoadonchi.Text;
                dsnguoidung.txtname.Text = cbbNcc.Text;
                dsnguoidung.txtngay.Text = txtngaylap.Text;
                dsnguoidung.txtsodienthoai.Text = txtsodienthoai.Text;
                dsnguoidung.txttienconno.Text = tongTienno().ToString();
                dsnguoidung.txttongtientra.Text = tongTientra().ToString();
                dsnguoidung.lbltieude.Text = "Hóa đơn trả tiền";
                dsnguoidung.lblthutratien.Text = "Người thanh toán";
                dsnguoidung.txttienctytra.Text = "Tiền công ty trả trước:";
                dsnguoidung.txtctyconno.Text = "Tiền công ty trả còn nợ";
                dsnguoidung.lblbt3.Text = "Nhà cung cấp";
                dsnguoidung.lblname.Text = "Nhà cung cấp:";
                report.ShowPreview();

            }

        }
        public long tongTientra()
        {
            long tongtien = 0;
            for (int i = 0; i < luoithutratiens.Count; i++)
            {
                tongtien += luoithutratiens[i].Tientra;
            }
            return tongtien;
        }
        public long tongTienno()
        {
            long tongtien = 0;
            for (int i = 0; i < luoithutratiens.Count; i++)
            {
                tongtien += luoithutratiens[i].Tienno;
            }
            return tongtien;
        }
        public void CThoadonchi()
        {
            var id = tratienBUS.IDhoadonchi(txtmahoadonchi.Text);
            CTphieuthutratien luoithutratien = new CTphieuthutratien();
            for (int i = 0; i < luoithutratiens.Count; i++)
            {
                luoithutratien.Mahoadonthu = (int)id;
                luoithutratien.Maphieuxuathang = luoithutratiens[i].Maphieuxuathang;
                luoithutratien.Tontienhdthu = luoithutratiens[i].Tongtienphieuthu;
                luoithutratien.Tientra = luoithutratiens[i].Tientra;
                luoithutratien.Tieno = luoithutratiens[i].Tienno;
                tratienBUS.themcthoadonthu(luoithutratien);
                tratienBUS.SuaTienphieuchi(luoithutratiens[i].Maphieuxuathang, luoithutratiens[i].Tienno);
            }

        }
        public Hoadonthutratien laythongtinhoadonchi()
        {
            Hoadonthutratien hoadonthutratien = new Hoadonthutratien();
            hoadonthutratien.Mahoadonthu = txtmahoadonchi.Text;
            hoadonthutratien.Makh = int.Parse(txtmancc.Text);
            hoadonthutratien.Ngaylap = txtngaylap.Text;
            hoadonthutratien.Manv = int.Parse(cbbnhanvien.EditValue.ToString());
            return hoadonthutratien;
        }

        private void SimpleButton2_Click(object sender, EventArgs e)
        {
            for (int i = gridView1.RowCount - 1; i >= 0; i--)
            {
                gridView1.DeleteRow(i);
            }
            luoithutratiens.Clear();
            LoaditemID(int.Parse(txtmancc.Text));
            int sohd = tratienBUS.Demthuoctinh();
            txtmahoadonchi.Text = "PCHI00" + (sohd + 1);
        }
    }
}