using QuanLyThuVien.DAL;
using QuanLyThuVien.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien.ThuThu
{
    public partial class FViTri : Form
    {
        ViTriDao vitridao = new ViTriDao();
        public FViTri()
        {
            InitializeComponent();
        }     
        private void btnXoa_Click(object sender, EventArgs e)
        {
            ViTri vitri = new ViTri(txtMaViTri.Text, txtKhuVuc.Text,
            txtKe.Text, txtNgan.Text);
            vitridao.XoaViTri(vitri);
            FViTri_Load(sender, e);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            ViTri vitri = new ViTri(txtMaViTri.Text, txtKhuVuc.Text,
            txtKe.Text, txtNgan.Text);
            vitridao.SuaViTri(vitri);
            FViTri_Load(sender, e);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ViTri vitri = new ViTri(txtMaViTri.Text, txtKhuVuc.Text,
            txtKe.Text, txtNgan.Text);
            vitridao.ThemViTri(vitri);
            FViTri_Load(sender, e);
        }

        private void dtViTri_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = dtViTri.Rows[e.RowIndex];
            txtMaViTri.Text = selectedRow.Cells["MaVT"].Value.ToString();
            txtKhuVuc.Text = selectedRow.Cells["KhuVuc"].Value.ToString();
            txtKe.Text = selectedRow.Cells["Ke"].Value.ToString();
            txtNgan.Text = selectedRow.Cells["Ngan"].Value.ToString();
        }

        private void FViTri_Load(object sender, EventArgs e)
        {
            dtViTri.DataSource = vitridao.LoadViTri();
            SqlCommand cmd = new SqlCommand("Proc_ThemViTri_AutoMaVT", DbConnection.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            if (DbConnection.conn.State == ConnectionState.Closed)
            {
                DbConnection.Instance.OpenConnection();
            }
            var result = cmd.ExecuteScalar();
            txtMaViTri.Text = result != null ? result.ToString() : "VT1"; 

            DbConnection.Instance.CloseConnection();
        }


        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string maVT = txtTimkiemvt.Text;

            if (string.IsNullOrEmpty(maVT))
            {
                MessageBox.Show("Vui lòng nhập mã vị trí cần tìm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataTable dt = vitridao.TimKiemViTri(maVT);

            if (dt != null && dt.Rows.Count > 0)
            {
                dtViTri.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Không tìm thấy vị trí với mã: " + maVT, "Kết quả tìm kiếm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dtViTri.DataSource = null; 
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            dtViTri.DataSource = vitridao.LoadViTri();
            FViTri_Load(sender, e);
        }

        
    }
}
