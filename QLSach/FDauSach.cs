using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyThuVien.DAL;
using QuanLyThuVien.DTO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace QuanLyThuVien.ThuThu
{
   
    public partial class FDauSach : Form
    {
        DauSachDao dao= new DauSachDao();
        public FDauSach()
        {
            InitializeComponent();         
            dtDauSach.DataSource = dao.LoadDauSach(); 
        }
        public void LoadData()
        {
            dtDauSach.DataSource = dao.LoadDauSach();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            DauSach dausachmoi = new DauSach(txtMaDS.Text,txtMaTacGia.Text,
                txtMaNhaXuatBan.Text,txtTen.Text,txtTheLoai.Text);
            dao.ThemDauSach(dausachmoi);
            FDauSach_Load(sender, e);
        }

        private void dtDauSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = dtDauSach.Rows[e.RowIndex];
            txtMaDS.Text = selectedRow.Cells["MaDS"].Value.ToString();
            txtTen.Text = selectedRow.Cells["Ten"].Value.ToString();
            txtMaTacGia.Text = selectedRow.Cells["MaTG"].Value.ToString();
            txtMaNhaXuatBan.Text = selectedRow.Cells["MaNXB"].Value.ToString();
            txtTheLoai.Text = selectedRow.Cells["TheLoai"].Value.ToString();
    
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DauSach dausachmoi = new DauSach(txtMaDS.Text, txtMaTacGia.Text,
                 txtMaNhaXuatBan.Text, txtTen.Text, txtTheLoai.Text);
            dao.XoaDauSach(dausachmoi);
            FDauSach_Load(sender, e);
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            DauSach dausachmoi = new DauSach(txtMaDS.Text, txtMaTacGia.Text,
              txtMaNhaXuatBan.Text, txtTen.Text, txtTheLoai.Text);
            dao.SuaDauSach(dausachmoi);
            FDauSach_Load(sender, e);
        }

        private void txtTimKiem_KeyUp(object sender, KeyEventArgs e)
        {
            string keyword = txtTimKiem.Text.Trim();     
            dao.TimKiemDauSach(keyword, dtDauSach);
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtTimKiem.Text = "";
            txtTheLoai.Text = "";
            txtTen.Text = "";
            txtMaTacGia.Text = "";
            txtMaNhaXuatBan.Text = "";
            txtMaDS.Text = "";
        }

        private void FDauSach_Load(object sender, EventArgs e)
        {
            dtDauSach.DataSource = dao.LoadDauSach();
        }
    }
}
