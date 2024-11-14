using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using QuanLyThuVien.DAL;
using QuanLyThuVien.DTO;

namespace QuanLyThuVien.ThuThu
{
    public partial class FTaoPhieuMuon : Form
    {
        string macs;
        PhieuMuonDao phieumuondao = new PhieuMuonDao();
        public FTaoPhieuMuon()
        {
            InitializeComponent();
            txtMaTT.Text = FDangNhap.mtt;
            dtpNgayMuon.Value = DateTime.Now;
            dtpNgayTraDuKien.Value = DateTime.Now.AddMonths(1);
        }

        public void FTaoPhieuMuon_Load(object sender, EventArgs e)
        {
            dtTrangThaiCuonSach.DataSource = DbConnection.Instance.Load("SELECT * FROM dbo.Func_ThongTinTrangThaiCuonSach()");
            dtPhieuMuon.DataSource = phieumuondao.LoadPhieuMuon(); 
        }
        private void btnTaoPhieuMuon_Click(object sender, EventArgs e)
        {
            PhieuMuon phieumuon = new PhieuMuon(txtMaPM.Text,txtMaDG.Text, txtMaTT.Text, dtpNgayMuon.Value, dtpNgayTraDuKien.Value);
            phieumuondao.TaoPhieuMuon(phieumuon);
            FTaoPhieuMuon_Load(sender, e);
        }

        private void dtTrangThaiCuonSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = dtTrangThaiCuonSach.Rows[e.RowIndex];
            macs = selectedRow.Cells["MaCS"].Value.ToString();           
        }
        private void btnThemSachVaoPhieuMuon_Click(object sender, EventArgs e)
        {
            PhieuMuon phieumuon = new PhieuMuon(txtMaPM.Text, txtMaDG.Text, txtMaTT.Text, dtpNgayMuon.Value, dtpNgayTraDuKien.Value);
            phieumuondao.ThemSachVaoPhieuMuon(phieumuon, macs);
            FTaoPhieuMuon_Load(sender, e);
        }

        private void dtPhieuMuon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtPhieuMuon.Rows[e.RowIndex];
                txtMaPM.Text = row.Cells["MaPM"].Value.ToString();
                txtMaDG.Text = row.Cells["MaDG"].Value.ToString();
                txtMaTT.Text = row.Cells["MaTT"].Value.ToString();
                dtpNgayMuon.Value = Convert.ToDateTime(row.Cells["NgayMuon"].Value);
                dtpNgayTraDuKien.Value = Convert.ToDateTime(row.Cells["NgayTra"].Value);
            }          
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaDG.Text = "";
            txtMaPM.Text = "";         
            txtTimKiem.Text = "";
            FTaoPhieuMuon_Load(sender, e);
        }
    }
}
