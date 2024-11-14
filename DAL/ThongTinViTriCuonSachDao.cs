using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace QuanLyThuVien.DAL
{
    class ThongTinViTriCuonSachDao
    {
        public DataTable LoadThongTinCuonSachViTri()
        {
            string query = "select * from View_ThongTinCuonSachViTri";
            return DbConnection.Instance.Load(query);
        }
        public bool XuatDuLieuThongTinCuonSachViTri(string filePath)
        {
            try
            {
                // Lấy dữ liệu từ View_ThongTinCuonSachViTri
                DataTable dataTable = LoadThongTinCuonSachViTri();
                StringBuilder fileContent = new StringBuilder();

                // Duyệt qua từng dòng dữ liệu và xây dựng nội dung cho file
                foreach (DataRow row in dataTable.Rows)
                {
                    fileContent.AppendLine("Mã Cuốn Sách: " + row["MaCS"].ToString());
                    fileContent.AppendLine("Tên Đầu Sách: " + row["TenDauSach"].ToString());
                    fileContent.AppendLine("Khu Vực: " + row["KhuVuc"].ToString());
                    fileContent.AppendLine("Kệ: " + row["Ke"].ToString());
                    fileContent.AppendLine("Ngăn: " + row["Ngan"].ToString());
                    fileContent.AppendLine(new string('-', 30)); // Dấu phân cách giữa các bản ghi
                }

                // Ghi dữ liệu vào file
                System.IO.File.WriteAllText(filePath, fileContent.ToString());
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
                return false;
            }
        }


    }
}
