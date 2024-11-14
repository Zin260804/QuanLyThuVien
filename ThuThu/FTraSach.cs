using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyThuVien.DAL;
using QuanLyThuVien.DTO;


namespace QuanLyThuVien.ThuThu
{
    public partial class FTraSach : Form
    {
        string mapm = null;
        PhieuMuonDao phieumuondao = new PhieuMuonDao();
        public FTraSach()
        {
            InitializeComponent();
        }

        private void FTraSach_Load(object sender, EventArgs e)
        {
            dtTrangThaiPhieuMuon.DataSource = DbConnection.Instance.Load("SELECT * FROM dbo.Func_ThongTinTrangThaiPhieuMuon()");
        }

        private void dtTrangThaiPhieuMuon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtTrangThaiPhieuMuon.Rows[e.RowIndex];
                mapm = row.Cells["MaPM"].Value.ToString();              
            }
            phieumuondao.HienThiChiTietPhieuMuon(mapm, dtChiTietPhieuMuon);
        }

        private void btnTraSach_Click(object sender, EventArgs e)
        {
            phieumuondao.TraSachTheoPhieuMuon(mapm);
            FTraSach_Load(sender, e);
            mapm = null;
        }
    }
}
