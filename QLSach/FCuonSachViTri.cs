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

namespace QuanLyThuVien.ThuThu
{
    public partial class FCuonSachViTri : Form
    {
        public FCuonSachViTri()
        {
            InitializeComponent();
        }

        private void FCuonSachViTri_Load(object sender, EventArgs e)
        {
            dtCuonSachViTri.DataSource = DbConnection.Instance.Load("select * from View_ThongTinCuonSachViTri");
        }

        private void btnXuatFile_Click(object sender, EventArgs e)
        {
            // Đảm bảo thư mục tồn tại
            string directoryPath = @"D:\ky1_nam3\DBMS";
            if (!System.IO.Directory.Exists(directoryPath))
            {
                System.IO.Directory.CreateDirectory(directoryPath);
            }

            // Tạo tên file mới dựa trên thời gian hiện tại
            string fileName = "ThongTinCuonSach_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".txt";
            string filePath = System.IO.Path.Combine(directoryPath, fileName);

            // Tạo đối tượng ThongTinViTriCuonSachDao để gọi phương thức XuatDuLieuThongTinCuonSachViTri
            ThongTinViTriCuonSachDao thongTinViTriCuonSachDao = new ThongTinViTriCuonSachDao();

            // Gọi phương thức xuất dữ liệu với tên file mới
            if (thongTinViTriCuonSachDao.XuatDuLieuThongTinCuonSachViTri(filePath))
            {
                MessageBox.Show("Xuất file thành công: " + filePath);
            }
            else
            {
                MessageBox.Show("Xuất file thất bại.");
            }
        }
    }
}
