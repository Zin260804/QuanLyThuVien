using QuanLyThuVien.DAL;
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

namespace QuanLyThuVien.TrangChu
{
    public partial class FThongTinSach : Form
    {
        public FThongTinSach()
        {
            InitializeComponent();
        }
        ThongTinSachDao dao = new ThongTinSachDao();
        private void FThongTinSach_Load(object sender, EventArgs e)
        {
            dtthongtinsach.DataSource = dao.LoadThongtinsach();
        }

        private void txtTimKiem_KeyUp(object sender, KeyEventArgs e)
        {
            string searchValue = txtTimKiem.Text.Trim();
            if (rdmasach.Checked)
            {
                DataTable result = dao.TimKiemSach(maSach: searchValue);
                dtthongtinsach.DataSource = result;
            }
            else if (rdtensach.Checked)
            {
                DataTable result = dao.TimKiemSach(tenSach: searchValue);
                dtthongtinsach.DataSource = result;
            }
            else if (rdnxb.Checked)
            {
                DataTable result = dao.TimKiemSach(tenNXB: searchValue);
                dtthongtinsach.DataSource = result;
            }
            else if (rdtacgia.Checked)
            {
                DataTable result = dao.TimKiemSach(tenTG: searchValue);
                dtthongtinsach.DataSource = result;
            }
        }

        private void btnxuat_Click(object sender, EventArgs e)
        {
           /* string directoryPath = @"C:\DuLieuSachExcel";
            if (!System.IO.Directory.Exists(directoryPath))
            {
                System.IO.Directory.CreateDirectory(directoryPath);
            }
            string fileName = "ThongTinSach_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".xlsx";
            string filePath = System.IO.Path.Combine(directoryPath, fileName);
            if (dao.XuatDuLieuSachExcel(filePath))
            {
                MessageBox.Show("Xuất file Excel thành công: " + filePath);
            }
            else
            {
                MessageBox.Show("Xuất file Excel thất bại.");
            }
*/


        }
    }
}
