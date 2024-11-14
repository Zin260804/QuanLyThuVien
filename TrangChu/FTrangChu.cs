using QuanLyThuVien.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien.TrangChu
{
    public partial class FTrangChu : Form
    {
        ThongKeDao thongkedao = new ThongKeDao();
        public FTrangChu()
        {
            InitializeComponent();
            lblDauSach.Text = thongkedao.ThongKe("SELECT dbo.Func_TongDauSach()");
            lblDocGia.Text = thongkedao.ThongKe("SELECT dbo.Func_TongDocGia()");
            lblNhaXuatBan.Text = thongkedao.ThongKe("SELECT dbo.Func_TongNhaXuatBan()");
            lblPhieuQuaHan.Text = thongkedao.ThongKe("SELECT dbo.Func_TongPhieuMuonQuaHan()");
            lblSach.Text = thongkedao.ThongKe("SELECT dbo.Func_TongSoSachHienCo()");
            lblTacGia.Text = thongkedao.ThongKe("SELECT dbo.Func_TongTacGia()");
        }

        private void btnDuDoan_Click(object sender, EventArgs e)
        {
            dtThongKe.DataSource = thongkedao.DuDoanBoSungSach();
        }

        private void btnHoatDong_Click(object sender, EventArgs e)
        {
            dtThongKe.DataSource = thongkedao.ThongKeTrongKhoangThoiGianMacDinh();
        }

        private void btnKhoSach_Click(object sender, EventArgs e)
        {
            dtThongKe.DataSource = thongkedao.ThongKeKhoSach(); 
        }
    }
}
