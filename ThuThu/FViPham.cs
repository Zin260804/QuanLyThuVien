using QuanLyThuVien.DAL;
using QuanLyThuVien.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien.ThuThu
{
    public partial class FViPham : Form
    {
        PhieuMuonDao phieumuondao = new PhieuMuonDao();   
        public FViPham()
        {
            InitializeComponent();
        }

        private void FViPham_Load(object sender, EventArgs e)
        {
            dtViPham.DataSource = phieumuondao.LayThongKeChiTietPhieuMuonViPham();
        }
    }
}
