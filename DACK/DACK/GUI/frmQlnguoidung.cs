﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DACK.DAO;
using DACK.BUS;
using DACK.DTO;
using DevExpress.XtraReports.UI;

namespace DACK.GUI
{
    public partial class frmQlnguoidung : DevExpress.XtraEditors.XtraForm
    {
        Datbase db = new Datbase();
        int Role = 1;
        int Idmh = 0;
        NhansuBUS nhansuBus = new NhansuBUS();
        public frmQlnguoidung()
        {
            InitializeComponent();
        }
        public frmQlnguoidung(int role, int Idmh)
        {
            InitializeComponent();
            this.Idmh = Idmh;
            Role = role;
        }
        public void Loadnhansu()
        {

            gridControl1.DataSource = nhansuDao.Lstnhansu(Idmh);
        }
        public Roleform phanquyen()
        {
            var role = db.quyentruycap(Role, Idmh);
            return role;
        }

        private void FrmQlnguoidung_Load(object sender, EventArgs e)
        {
            Loadnhansu();
            Roleform roleform = phanquyen();
            btnthem.Enabled = roleform.Them;
            btnXoa.Enabled = roleform.Xoa;
            btnsua.Enabled = roleform.Sua;
            btnin.Enabled = roleform.Inan;
            btnnhap.Enabled = roleform.Nhap;
            btnxuat.Enabled = roleform.Xuat;
        }

        private void BtnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Object id = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Id");

            var row = nhansuBus.Xoanhansu(int.Parse(id.ToString()), gridView1);
            if (row > 0)
            {
                gridView1.DeleteRow(gridView1.FocusedRowHandle);
                MessageBox.Show("Xóa thành công!");
            }
            else
            {
                MessageBox.Show("Xóa Thất bại!");
            }
        }

        private void Btnsua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Object id = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Id");
            Object tenDangNhap = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "TenDangNhap");
            Object matKhau = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MatKhau");
            Object ten = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Ten");
            Object tmail = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Email");
            Object ngayThamgia = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "NgayThamgia");
            Object diachi = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Diachi");
            Object idQuyen = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "IdQuyen");
            Object gioitinh = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Gioitinh");
            Object nganhang = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Nganhang");
            Object sotk = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Sotk");
            Object sodienthoai = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Sodienthoai");

            Nhansu nhansu = new Nhansu()
            {
                Id = (int)id,
                TenDangNhap = tenDangNhap.ToString(),
                MatKhau = nhansuDao.Laypasswork((int)id),
                Ten = ten.ToString(),
                Email = tmail.ToString(),
                NgayThamgia = ngayThamgia.ToString(),
                Diachi = diachi.ToString(),
                IdQuyen = (int)idQuyen,
                Gioitinh = gioitinh.ToString(),
                Nganhang = nganhang.ToString(),
                Sotk = (long)sotk,
                Sodienthoai = (int)sodienthoai


            };
            Themsuanguoidung themsuanhansu = new Themsuanguoidung(nhansu, Idmh);
            themsuanhansu.Show();
            themsuanhansu.khicapnhat += Themsuanhansu_khicapnhat;
        }

        private void Themsuanhansu_khicapnhat()
        {
            Loadnhansu();
        }

        private void Btnthem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Themsuanguoidung themsuanhansu = new Themsuanguoidung(Role, Idmh);
            themsuanhansu.Show();
            themsuanhansu.khicapnhat += Themsuanhansu_khicapnhat;
        }
        NhansuDAO nhansuDao = new NhansuDAO(); 
        private void Btnin_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Dsnguoidung dsnguoidung = new Dsnguoidung();
            List<Nhansu> lstkachchang = nhansuDao.Dsnguoidung();
            dsnguoidung.DataSource = lstkachchang;
            ReportPrintTool report = new ReportPrintTool(dsnguoidung);
            report.ShowPreview();
        }
    }
}