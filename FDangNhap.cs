using QuanLyThuVien.ThuThu;
using QuanLyThuVien.TrangChu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien.DAL
{
    public partial class FDangNhap : Form
    {     
        public static string mtt;
        DangNhapDao dangnhapdao = new DangNhapDao();    
       
        public FDangNhap()
        {
            InitializeComponent(); 
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (rdbThuThu.Checked)
            {
                mtt = dangnhapdao.XacThucTaiKhoan(txtTaiKhoan.Text, txtPassword.Text);
                if (mtt != null)
                {
                    FManHinhChinh fmanhinhchinh = new FManHinhChinh();
                    this.Hide();
                    fmanhinhchinh.ShowDialog();
                    fmanhinhchinh = null;
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại !");
                }
            }
            if (rdbDocGia.Checked)
            {
                // Kiểm tra mã độc giả từ textbox
                if (dangnhapdao.XacThucDocGia(txtTaiKhoan.Text.Trim()))
                {
                    
                    MessageBox.Show("Mã độc giả hợp lệ!", "Xác Thực", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    FThongTinSach fthongtinsach =  new FThongTinSach();
                    this.Hide();
                    fthongtinsach.ShowDialog();
                    fthongtinsach = null;
                    this.Show();
                }
                else
                {
                    // Thông báo nếu mã độc giả không tồn tại
                    MessageBox.Show("Mã độc giả không tồn tại!", "Xác Thực", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

        }



        private void txtTaiKhoan_KeyDown(object sender, KeyEventArgs e)
        {
            if (rdbDocGia.Checked)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    btnDangNhap.PerformClick(); // Kích hoạt sự kiện Click của nút Đăng nhập
                }
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (rdbThuThu.Checked)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    btnDangNhap.PerformClick(); // Kích hoạt sự kiện Click của nút Đăng nhập
                }
            }
        }

        private void rdbThuThu_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.Visible = true;
        }

        private void rbdDocGia_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.Visible = false;
        }
    }
}
